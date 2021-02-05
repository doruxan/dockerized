using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logistics.Business.Core.Interfaces.Commands;
using Logistics.Data.Context;
using Logistics.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Logistics.Business.Commands.ShippingCommands
{
    public class GenerateShipmentItems : IAsyncCommand
    {
        public bool Result { get; set; }
    }

    public class GenerateShipmentItemsHandler : IAsyncCommandHandler<GenerateShipmentItems>
    {
        private readonly LogisticsContext context;

        public GenerateShipmentItemsHandler(LogisticsContext context)

        {
            this.context = context;
        }

        public void Handle(GenerateShipmentItems command)
        {
            Task.Run(async () => { await HandleAsync(command).ConfigureAwait(false); }).Wait();
        }

        public async Task HandleAsync(GenerateShipmentItems command)
        {
            context.Database.ExecuteSqlRaw("TRUNCATE TABLE [BoxItems]");

            var parts = context.Parts.AsQueryable();
            var boxes = await context.Boxes.OrderBy(x => x.Weight).Select(x => x).ToListAsync();
            var localItems = context.BoxItems.Local.AsQueryable();
            var minPartCount = 2;
            var boxesPartCounts = new Dictionary<long, int>();

            //since the deterministic factor is not thepart  cost or weight, it is box weight and min part count
            foreach (var box in boxes)
            {
                var partCountsToAvoid = boxesPartCounts.Values.ToList();
                var pendingItems = localItems.Select(x => x.PartNumber).ToList();

                if (box.Weight % minPartCount == 0)
                {
                    var partsToInsert = await parts
                        .Where(x => x.PartWeight == box.Weight / minPartCount && !pendingItems.Contains(x.PartNumber))
                        .Take(minPartCount)
                        .ToListAsync();
                    partsToInsert.ForEach(x => context.BoxItems.Add(new BoxItemEntity
                    {
                        BoxId = box.BoxId,
                        PartNumber = x.PartNumber,
                        PartCost = x.PartWeight * 7 + 50,
                        PartWeight = x.PartWeight
                    }));
                    box.PartCount = partsToInsert.Count();
                    minPartCount++;
                    continue;
                }

                var firstItem = await parts.OrderBy(x => x.PartWeight)
                    .FirstOrDefaultAsync(x => x.PartWeight == Math.Ceiling(box.Weight / minPartCount) && !pendingItems.Contains(x.PartNumber));
                var remainningIems = await parts
                        .Where(x => x.PartWeight == firstItem.PartWeight - 1 && !pendingItems.Contains(x.PartNumber))
                        .Take(minPartCount - 1)
                        .ToListAsync();
                remainningIems.Add(firstItem);
                remainningIems.ForEach(x => context.BoxItems.Add(new BoxItemEntity
                {
                    BoxId = box.BoxId,
                    PartNumber = x.PartNumber,
                    PartCost = x.PartWeight * 7 + 50,
                    PartWeight = x.PartWeight
                }));
                box.PartCount = remainningIems.Count();
                minPartCount++;

            }

            await context.SaveChangesAsync();
        }
    }
}
