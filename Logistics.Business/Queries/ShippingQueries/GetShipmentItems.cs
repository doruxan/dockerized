using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Logistics.Business.Core.Interfaces.Queries;
using Logistics.Data.Context;
using Logistics.Data.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Logistics.Business.Queries.ShippingQueries
{

    public class GetShipmentItems : IAsyncQuery<List<BoxItemDto>>
    {

    }

    public class GetShipmentItemsExecutor : IAsyncQueryExecutor<GetShipmentItems, List<BoxItemDto>>
    {
        protected readonly LogisticsContext context;
        protected readonly IQueryProcessor queryProcessor;
        private readonly IMapper mapper;

        public GetShipmentItemsExecutor(LogisticsContext context, IQueryProcessor queryProcessor, IMapper mapper)
        {
            this.context = context;
            this.queryProcessor = queryProcessor;
            this.mapper = mapper;
        }

        public List<BoxItemDto> Execute(GetShipmentItems query)
        {
            return Task.Run(async () => { return await ExecuteAsync(query).ConfigureAwait(false); }).Result;
        }

        public async Task<List<BoxItemDto>> ExecuteAsync(GetShipmentItems query)
        {
            var generatedItems = await context.BoxItems.ToListAsync();
            var returnDtos = generatedItems.Select(x => mapper.Map<BoxItemDto>(x)).ToList();
            return returnDtos;
        }
    }
}
