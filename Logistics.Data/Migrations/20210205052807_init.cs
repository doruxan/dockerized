using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Logistics.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boxes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BoxId = table.Column<long>(type: "bigint", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    PartCount = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoxItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BoxId = table.Column<long>(type: "bigint", nullable: false),
                    PartNumber = table.Column<long>(type: "bigint", nullable: false),
                    PartWeight = table.Column<double>(type: "float", nullable: false),
                    PartCost = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoxItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartNumber = table.Column<long>(type: "bigint", nullable: false),
                    PartWeight = table.Column<int>(type: "int", nullable: false),
                    PartCost = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "BoxId", "CreatedDate", "IsDeleted", "ModifiedDate", "PartCount", "Weight" },
                values: new object[,]
                {
                    { new Guid("72fd5390-bf2a-4ac4-85ac-4da7e71e8afe"), 123450L, new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 651, DateTimeKind.Unspecified).AddTicks(4230), new TimeSpan(0, 0, 0, 0, 0)), false, null, null, 3.0 },
                    { new Guid("0e8f1271-5e16-49e0-a6be-b1263f5af617"), 123461L, new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 651, DateTimeKind.Unspecified).AddTicks(5230), new TimeSpan(0, 0, 0, 0, 0)), false, null, null, 8.0 },
                    { new Guid("dafc64ca-a9c4-4c8a-96b8-248273a17683"), 123472L, new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 651, DateTimeKind.Unspecified).AddTicks(5260), new TimeSpan(0, 0, 0, 0, 0)), false, null, null, 11.0 },
                    { new Guid("deaaab63-07d5-4df7-819a-692009237c9b"), 123483L, new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 651, DateTimeKind.Unspecified).AddTicks(5260), new TimeSpan(0, 0, 0, 0, 0)), false, null, null, 3.0 },
                    { new Guid("98ea2059-a469-4d79-87cc-cbe2866f938c"), 123494L, new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 651, DateTimeKind.Unspecified).AddTicks(5270), new TimeSpan(0, 0, 0, 0, 0)), false, null, null, 13.0 }
                });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "PartCost", "PartNumber", "PartWeight" },
                values: new object[,]
                {
                    { new Guid("a0d6544b-8da4-471f-8f16-eeb42193095c"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4680), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 134L, 5 },
                    { new Guid("d7849e8c-8da7-487b-ab00-d2128336bf28"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4680), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 135L, 5 },
                    { new Guid("7f17d5a1-d860-494f-b3ad-07b66d619df5"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4690), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 136L, 5 },
                    { new Guid("0aca15af-2e22-4643-9d25-f77d6973cc7c"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4690), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 137L, 5 },
                    { new Guid("7612a5bc-41c0-4589-8916-d4835e494e21"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4690), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 138L, 5 },
                    { new Guid("de8966e4-3775-439a-b510-e26f7c5c9b23"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4700), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 139L, 5 },
                    { new Guid("08800a9e-4fa4-462a-83d0-0acde11e6341"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4700), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 140L, 5 },
                    { new Guid("44de9c94-0abf-4578-8b46-fe36317e82d2"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4710), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 141L, 5 },
                    { new Guid("b2b76552-bbbf-49b7-aef7-7d0a0d00dab7"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4710), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 142L, 5 },
                    { new Guid("8cb81567-74b8-4a2e-9140-0bc14e2a4a61"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4710), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 143L, 5 },
                    { new Guid("bc59f2e2-e178-44e0-bced-77bf75757afa"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4720), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 144L, 5 },
                    { new Guid("187dd730-1bab-438e-882a-a4d986ed687d"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4730), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 146L, 5 },
                    { new Guid("56608561-df1e-42c7-955a-91cfb07ea9b1"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4680), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 133L, 5 },
                    { new Guid("1a897084-40b9-4187-b0af-5e3a96f5f33d"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4730), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 147L, 5 },
                    { new Guid("fc3cd339-f8ff-440d-94a4-7d9fe7286886"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4730), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 148L, 5 },
                    { new Guid("574633c6-5d95-4c08-82db-69e6f897395d"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4740), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 149L, 5 },
                    { new Guid("014d1ab8-62a7-40b9-a140-4c2d632d877d"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4740), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 150L, 5 },
                    { new Guid("41cff158-1419-4d0e-b4f9-de84c7a65de7"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4740), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 151L, 6 },
                    { new Guid("ba9725f4-1d84-412b-b63a-400e75666ea4"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4750), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 152L, 6 },
                    { new Guid("22276793-1c15-4ca8-a5bc-249e0d8c12b0"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4750), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 153L, 6 },
                    { new Guid("4bc5af33-8b31-4f44-b62f-eb2815b7f02f"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4760), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 154L, 6 },
                    { new Guid("bd2b2a6d-613f-48c5-8ee9-74869b8d29e7"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4760), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 155L, 6 },
                    { new Guid("ee192d91-0f9f-4b50-ba72-a1c6539496bb"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4720), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 145L, 5 },
                    { new Guid("51e5bd43-2557-48c4-a358-7779e9e941ef"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4670), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 132L, 5 },
                    { new Guid("1415eafe-3ff1-4006-bb74-475604e7b8bc"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4620), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 129L, 5 },
                    { new Guid("91f64461-0821-49e1-9d9d-208357f72265"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4660), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 130L, 5 },
                    { new Guid("11f0a773-a3a0-442a-b322-3725982586e2"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4540), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 107L, 4 },
                    { new Guid("33682ccc-c1b6-42a7-ae91-fc3e98ce4814"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4540), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 108L, 4 },
                    { new Guid("4c88bf65-aefe-4a6b-b6e7-7e7493e8c013"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4550), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 109L, 4 },
                    { new Guid("7fb63a8b-8398-428f-8734-12e4c46fea0e"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4550), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 110L, 4 },
                    { new Guid("83d9cb11-4b55-4574-acf8-b13135418ef5"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4550), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 111L, 4 },
                    { new Guid("d89b7d28-fbc5-4a36-8b5d-e14a1d3660aa"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4560), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 112L, 4 },
                    { new Guid("6fe4df34-d5f5-42e4-9128-6dc5ae47a939"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4560), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 113L, 4 },
                    { new Guid("360c7fd5-3900-4103-8ae4-4a702e648656"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4570), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 114L, 4 },
                    { new Guid("5174e924-4b4b-4af2-a3ed-44b8f369dfa6"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4570), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 115L, 4 },
                    { new Guid("8f61e808-0364-4c08-b343-e29b7f382a01"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4570), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 116L, 4 },
                    { new Guid("fbdb4108-1825-4125-830b-5e05bc5ef516"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4580), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 117L, 4 }
                });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "PartCost", "PartNumber", "PartWeight" },
                values: new object[,]
                {
                    { new Guid("03f991c8-e650-40dc-93bb-9c3f4285386d"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4580), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 118L, 4 },
                    { new Guid("8a992ab1-72c4-4028-b7c0-eaee9bbffc57"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4580), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 119L, 4 },
                    { new Guid("9bf1282f-8fc6-49e2-b8f5-035d92ad5bd5"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4590), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 120L, 4 },
                    { new Guid("a436edc5-7e67-40c2-9d01-b799dffeb6fc"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4590), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 121L, 5 },
                    { new Guid("e7379933-1184-40b9-a486-3b1e6a765b0c"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4600), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 122L, 5 },
                    { new Guid("8a9e5727-18c8-42f6-8b26-f4adeea29cd3"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4600), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 123L, 5 },
                    { new Guid("03fa47c6-322f-4141-9a24-dc6371b46443"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4600), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 124L, 5 },
                    { new Guid("bdae760b-a401-401e-96be-83219ef05dfb"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4610), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 125L, 5 },
                    { new Guid("6b6473ae-6beb-4599-8aa9-3c9e28e72eda"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4610), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 126L, 5 },
                    { new Guid("dc81ac37-5fd7-4022-9561-5c286e6ee02f"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4620), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 127L, 5 },
                    { new Guid("c1081ecf-8d43-4b59-a6fa-6de9c5961649"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4620), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 128L, 5 },
                    { new Guid("37dc2e88-76fb-4921-989f-38e1f3f67e07"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4760), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 156L, 6 },
                    { new Guid("ed7a7004-db52-4ff6-8ef3-001aa064b754"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4670), new TimeSpan(0, 0, 0, 0, 0)), false, null, 85.0, 131L, 5 },
                    { new Guid("f6b9d8a9-3cf1-4b32-ae59-f585f147a4f5"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4770), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 157L, 6 },
                    { new Guid("792a47cd-40d2-424d-b0ea-956501659cc9"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4770), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 159L, 6 },
                    { new Guid("a3100dcb-0cba-4b69-8f71-732f0fd2bf60"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4540), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 106L, 4 },
                    { new Guid("da6d8773-090c-46c0-b1d0-a7b0562fc09c"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4880), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 187L, 7 },
                    { new Guid("c432a11a-a5a7-402d-b674-b64d70e699fb"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4890), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 188L, 7 },
                    { new Guid("8837a191-17ec-4420-b4c1-b7f71b08f9f4"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5070), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 189L, 7 },
                    { new Guid("ce9a7f82-dd13-4825-a5c0-8bc37857b4e3"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5070), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 190L, 7 },
                    { new Guid("def683e7-a36c-4756-b699-ed135094a86a"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5070), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 191L, 7 },
                    { new Guid("9876ed85-9ce9-47bf-a2c4-9726c158a817"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5080), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 192L, 7 },
                    { new Guid("a5a8a57d-e9ef-4eda-b48d-0cfcf7901147"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5080), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 193L, 7 },
                    { new Guid("dc09dfbb-65be-4988-a56b-ccb446e0f8e8"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5080), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 194L, 7 },
                    { new Guid("349a9e75-183d-4ad8-aec2-5362d38b3745"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5090), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 195L, 7 },
                    { new Guid("528b4dd8-381f-4702-aabd-3781a090865e"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5090), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 196L, 7 },
                    { new Guid("3cb37172-27e1-4c52-ba9c-12b99add7204"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4880), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 186L, 7 },
                    { new Guid("d65abc6f-7f17-49ee-8729-293dd872fdcf"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5100), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 197L, 7 },
                    { new Guid("96d0e9b0-4f83-43a5-b5ec-a8bebfaff1b3"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5100), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 199L, 7 },
                    { new Guid("156067a2-8265-4af2-b662-91804cabb936"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5110), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 200L, 7 },
                    { new Guid("7dc1b6e3-d7a9-4dea-87ec-7dde3b606751"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5110), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 201L, 7 },
                    { new Guid("32096cfb-2d06-4101-8b4d-e64448b6a125"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5120), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 202L, 7 },
                    { new Guid("76f9b064-4615-4ef9-882c-1d3be4ca7289"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5120), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 203L, 7 },
                    { new Guid("004e26a5-dc78-4995-85c9-807d34eab5bf"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5120), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 204L, 7 },
                    { new Guid("325b9d42-e5cd-4e20-a83b-7f99aabe5017"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5130), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 205L, 7 },
                    { new Guid("0823fc48-3214-4d8b-8064-0b3dad762b43"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5130), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 206L, 7 },
                    { new Guid("1df7dd86-e1cb-4c60-b9e0-5118a44a4d49"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5130), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 207L, 7 },
                    { new Guid("2d0034f1-f916-4854-a8f0-4d5815d39424"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5140), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 208L, 7 },
                    { new Guid("aae026d6-b6ec-47a6-82cb-0cd6a52b19a1"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5100), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 198L, 7 },
                    { new Guid("15330576-0922-4b66-a855-933c29babf99"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4870), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 185L, 7 },
                    { new Guid("f5034307-af55-47fa-85c0-a0aa9def0173"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4870), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 184L, 7 },
                    { new Guid("ebb0b3ca-0cd3-4971-9498-3ef55e5934dc"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4870), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 183L, 7 }
                });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "PartCost", "PartNumber", "PartWeight" },
                values: new object[,]
                {
                    { new Guid("88a5fbd5-dd6e-42c2-b266-e97f1cb279a6"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4780), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 160L, 6 },
                    { new Guid("487f5c85-4c94-4b4e-abed-d4e0cf88164c"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4780), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 161L, 6 },
                    { new Guid("13c56207-297b-4d3b-8e60-1f90638b89c1"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4790), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 162L, 6 },
                    { new Guid("af01456d-cf2a-4184-86a0-e12dce86b4ce"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4790), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 163L, 6 },
                    { new Guid("2dd87dc4-9459-4e9d-ae66-0d4dadee67dd"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4790), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 164L, 6 },
                    { new Guid("0d77c7cc-e6ed-412c-8516-393217fff97f"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4800), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 165L, 6 },
                    { new Guid("28a42cca-732b-4f82-9fb6-2ff87091ebd6"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4800), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 166L, 6 },
                    { new Guid("bd59be2c-d166-4638-992e-4e04f816c81d"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4810), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 167L, 6 },
                    { new Guid("f35d25df-52c9-4788-a079-853a5535e9cc"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4810), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 168L, 6 },
                    { new Guid("1cd2fb0f-aded-4308-8f60-6d1b0b67f808"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4810), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 169L, 6 },
                    { new Guid("7913a293-4b94-4fab-a818-504fef274aa1"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4820), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 170L, 6 },
                    { new Guid("9718e61d-8643-465f-b9f0-073470537b00"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4820), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 171L, 6 },
                    { new Guid("7cff5a66-8d42-4492-9b74-75d79c728f37"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4820), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 172L, 6 },
                    { new Guid("5900b2fc-71a9-4d76-ac9b-5b58b642e74f"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4830), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 173L, 6 },
                    { new Guid("6440b768-d71f-45aa-ae02-78fb3cbc5caf"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4830), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 174L, 6 },
                    { new Guid("5b039455-db8d-437a-b719-0e7bd197a911"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4840), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 175L, 6 },
                    { new Guid("01367c34-20cb-4753-9161-092545f2b410"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4840), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 176L, 6 },
                    { new Guid("06b7963a-c42f-4bb0-9877-aabdcaa6eb78"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4840), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 177L, 6 },
                    { new Guid("220cda85-3f65-4e20-a1b9-9ecad6de29d9"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4850), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 178L, 6 },
                    { new Guid("7d0c5335-e1cd-4d13-994d-d64efef65695"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4850), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 179L, 6 },
                    { new Guid("33ed6a6c-6140-40e3-9479-37dcb5c42b62"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4860), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 180L, 6 },
                    { new Guid("1fad98d8-bad5-4edc-9a35-a36a4a1904d6"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4860), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 181L, 7 },
                    { new Guid("7508c33c-af0a-4707-8965-7b8b4cf9d6b1"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4860), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 182L, 7 },
                    { new Guid("73046ae4-de2c-43f0-8256-215c04579203"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4770), new TimeSpan(0, 0, 0, 0, 0)), false, null, 92.0, 158L, 6 },
                    { new Guid("b0a26053-c10c-4245-86cf-126f1a4cebfa"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4530), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 105L, 4 },
                    { new Guid("d89c5882-f504-44a6-b8a4-7299caccb71c"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4520), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 103L, 4 },
                    { new Guid("b70db621-8d20-49de-924a-e94f878cebe0"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5140), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 209L, 7 },
                    { new Guid("1284a62a-b3f1-4790-b105-8300931da733"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4170), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 28L, 1 },
                    { new Guid("594d59a0-f5bd-4273-a193-8d1ed77eafcc"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4170), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 29L, 1 },
                    { new Guid("caadbc17-f5af-4c71-81cd-3a8184d8cd53"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4180), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 30L, 1 },
                    { new Guid("48051ed8-5808-4c0e-9483-e8e796ebe448"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4180), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 31L, 2 },
                    { new Guid("10d81d1a-441d-41f3-97e6-d676e6103be0"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4190), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 32L, 2 },
                    { new Guid("40e01614-a482-40b1-8539-bf74b9ab5bb5"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4190), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 33L, 2 },
                    { new Guid("5c5e3c52-cad5-4e96-ac27-5c169bd2f23e"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4200), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 34L, 2 },
                    { new Guid("ba07e642-9e0c-40fb-8c8e-3d1a7c4560d1"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4200), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 35L, 2 },
                    { new Guid("75f15f29-254f-4f58-983f-0b9cc10d0916"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4210), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 36L, 2 },
                    { new Guid("23af8f82-eb1c-452a-b122-d99aacf17c3b"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4210), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 37L, 2 },
                    { new Guid("706bf7ad-ff2d-405d-93ca-211fa3e5c531"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4170), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 27L, 1 },
                    { new Guid("4fac0751-4549-43be-b344-89d040fa6c41"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4210), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 38L, 2 },
                    { new Guid("03c2c375-09a6-4aa6-9349-0b4becff26c6"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4220), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 40L, 2 },
                    { new Guid("7805acfc-b16a-40f1-bb43-c7f8ec02d29e"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4220), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 41L, 2 },
                    { new Guid("7fbd6216-907d-473b-b2e9-d55fb74fc1bd"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4230), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 42L, 2 }
                });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "PartCost", "PartNumber", "PartWeight" },
                values: new object[,]
                {
                    { new Guid("d3c29645-ee0f-4d9b-89fa-2f07e5565397"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4230), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 43L, 2 },
                    { new Guid("1ec45c57-3db0-479d-a111-0717a5585d02"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4240), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 44L, 2 },
                    { new Guid("3ca5cdfe-2904-4562-bb11-55af1606f38e"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4240), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 45L, 2 },
                    { new Guid("8d68a58b-7394-4ea6-a492-71a949d46e89"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4240), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 46L, 2 },
                    { new Guid("0bb65f83-2222-450c-8e58-9625ffd5e47d"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4250), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 47L, 2 },
                    { new Guid("9a1760bc-143e-40de-a281-76004cb9737f"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4250), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 48L, 2 },
                    { new Guid("05a1811b-ea1a-41c9-b624-41280c48f70d"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4250), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 49L, 2 },
                    { new Guid("3bae63cb-70d1-44b6-bb4f-e9e8ead6506a"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4220), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 39L, 2 },
                    { new Guid("0dd14ca6-9f60-4e2a-9a01-014b544694f1"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4160), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 26L, 1 },
                    { new Guid("9f4755a5-a3f1-41e3-ad15-e5680215d9a4"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4160), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 25L, 1 },
                    { new Guid("320f27b5-054e-4643-84bd-9cd86e925f21"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4150), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 24L, 1 },
                    { new Guid("5820eb2d-b3e9-4e36-8bd2-a33359c9879a"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(2270), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 1L, 1 },
                    { new Guid("9f86e192-d4d8-4aa0-8dc2-ec527b36966a"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4020), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 2L, 1 },
                    { new Guid("0be8c99a-043b-4658-a6e7-60ed3bf017eb"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4060), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 3L, 1 },
                    { new Guid("5d4db886-4539-4cd8-8350-5c8c1eb53d40"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4060), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 4L, 1 },
                    { new Guid("414a522d-b5d0-4c00-83ed-77d5331b6616"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4070), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 5L, 1 },
                    { new Guid("38912667-0c68-4fbc-941b-375d3a5c171a"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4080), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 6L, 1 },
                    { new Guid("85c70d13-c5eb-4a5e-ad72-aa7c3dd797fe"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4080), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 7L, 1 },
                    { new Guid("bdfde83d-68e6-4f54-8307-550916ed165e"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4090), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 8L, 1 },
                    { new Guid("d7b33f36-205b-4c8e-a814-f2017ef13e49"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4090), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 9L, 1 },
                    { new Guid("7adece7c-c1ee-4790-a79d-c28150db0fd8"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4100), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 10L, 1 },
                    { new Guid("1bde4f93-ac63-4b52-b0a8-f90a5571ed14"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4100), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 11L, 1 },
                    { new Guid("d03cd51d-72cf-4545-9358-656fa336c9fe"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4110), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 12L, 1 },
                    { new Guid("d216b820-de89-444a-b4dc-ecf566d84c78"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4110), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 13L, 1 },
                    { new Guid("d4e06f17-cee8-4e42-a8ec-6cf0b36ff633"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4110), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 14L, 1 },
                    { new Guid("f2d16ea3-ba51-4f0d-861c-3ccb54cdd458"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4120), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 15L, 1 },
                    { new Guid("41d979da-70fc-4e4b-8201-9793ff73a777"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4120), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 16L, 1 },
                    { new Guid("f188f95e-bc8d-4813-aa3c-0dc946f74a75"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4130), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 17L, 1 },
                    { new Guid("ffa66e31-e368-4c15-886a-848eb7be0c7a"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4130), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 18L, 1 },
                    { new Guid("f5ca7dcc-221b-4853-ae1a-e53ef573aaa8"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4140), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 19L, 1 },
                    { new Guid("18e4be60-59e5-4a94-bffc-1779edf26afb"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4140), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 20L, 1 },
                    { new Guid("91ed3463-75f1-4846-894f-77f0bd3c51bf"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4140), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 21L, 1 },
                    { new Guid("c4d57c4c-a684-4869-a79c-14c92a326c3e"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4150), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 22L, 1 },
                    { new Guid("f7bac24a-2a74-40a9-bd5c-d09325a77a5e"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4150), new TimeSpan(0, 0, 0, 0, 0)), false, null, 57.0, 23L, 1 },
                    { new Guid("db735f2f-3f7b-4ed2-b36c-eb6e5761e288"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4260), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 50L, 2 },
                    { new Guid("b0335d15-897e-4dfd-bcb0-60196ee14856"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4530), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 104L, 4 },
                    { new Guid("bfe77cd2-6c03-416a-b40d-7dc160412033"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4260), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 51L, 2 },
                    { new Guid("6d2ecaa1-63e9-441a-a2e9-3251dbb22dce"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4270), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 53L, 2 },
                    { new Guid("9dac35b7-9ff7-4862-92d4-671269394d41"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4440), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 81L, 3 },
                    { new Guid("6b10b74e-7b53-4ff3-9060-bb9860551fe8"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4440), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 82L, 3 },
                    { new Guid("73c9e45c-02cb-4380-b399-2cd62b68d5bb"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4450), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 83L, 3 },
                    { new Guid("7a36ac8f-4c05-42ba-a590-3421f275cfd0"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4450), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 84L, 3 }
                });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "PartCost", "PartNumber", "PartWeight" },
                values: new object[,]
                {
                    { new Guid("ba7d0d6f-48db-4642-b60f-00c17f4845bd"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4460), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 85L, 3 },
                    { new Guid("960fbad8-f740-495d-9ba5-4551b9fdfefa"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4460), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 86L, 3 },
                    { new Guid("8a194fdb-1c80-4c53-be9d-17bf2e47d5ed"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4460), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 87L, 3 },
                    { new Guid("c85cb7a3-26ea-42e3-985e-e76dbfb374b7"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4470), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 88L, 3 },
                    { new Guid("11974b74-b8d8-49db-9639-f0320f861c51"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4470), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 89L, 3 },
                    { new Guid("35a00cb4-012a-4d49-86c9-72c5f9886e41"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4470), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 90L, 3 },
                    { new Guid("c782b594-0e46-40e6-8348-4542b703eb75"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4440), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 80L, 3 },
                    { new Guid("991f5233-e2a3-4459-9afb-7b58f171fcb1"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4480), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 91L, 4 },
                    { new Guid("631bb561-72f4-4eaf-8b77-aac348e32070"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4490), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 93L, 4 },
                    { new Guid("75bf4ce9-4a00-4943-ad00-3f06bb76e1b6"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4490), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 94L, 4 },
                    { new Guid("0b7403b7-c040-4803-9371-b2b3dff3774f"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4490), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 95L, 4 },
                    { new Guid("093eaffc-07e0-4a62-a319-e8d402f01065"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4500), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 96L, 4 },
                    { new Guid("8c4094a4-28bf-4900-acba-e064823fc9de"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4500), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 97L, 4 },
                    { new Guid("68b9def1-f620-4dea-8f70-f0b3916d36a9"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4510), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 98L, 4 },
                    { new Guid("fb8626b0-1512-4aa9-8b04-ee0d77872e14"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4510), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 99L, 4 },
                    { new Guid("73b5797d-c55a-4253-9062-038f676a66cb"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4510), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 100L, 4 },
                    { new Guid("8d95e681-9997-4c60-944c-b7598d818af8"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4520), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 101L, 4 },
                    { new Guid("f684dffe-7290-4cd8-a553-27fbb24cb9a1"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4520), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 102L, 4 },
                    { new Guid("7ddce7c7-cf46-45f9-ae61-55d7f4117c5c"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4480), new TimeSpan(0, 0, 0, 0, 0)), false, null, 78.0, 92L, 4 },
                    { new Guid("fc35d04c-2591-4629-a705-e052494dbecb"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4430), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 79L, 3 },
                    { new Guid("d1ba68e4-a357-4543-bf01-026b2919cb62"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4430), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 78L, 3 },
                    { new Guid("6e12b0ca-33b1-4c65-b3aa-b82d071cf4bc"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4430), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 77L, 3 },
                    { new Guid("79a63a83-8335-4f7e-ad6e-21ba0e1ccb90"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4270), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 54L, 2 },
                    { new Guid("1e305a9f-f440-461f-af66-cc36fe09cc5a"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4280), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 55L, 2 },
                    { new Guid("2d6c16e7-4445-476c-8583-705087e0d073"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4280), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 56L, 2 },
                    { new Guid("90d23bab-37c1-4fb3-8a2e-84f2adb2ed2c"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4280), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 57L, 2 },
                    { new Guid("c6efafc1-ae9a-4f03-9127-a8a83d9d9af4"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4290), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 58L, 2 },
                    { new Guid("1bd09dd0-5a8b-42c5-a7eb-50aa18871c82"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4290), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 59L, 2 },
                    { new Guid("24f65368-fe8f-410c-9751-b680674938a8"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4300), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 60L, 2 },
                    { new Guid("6febbfc5-f0ff-44b0-a2e0-f2f90f084c9f"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4300), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 61L, 3 },
                    { new Guid("09ac06e7-0eb7-4bec-9045-e80147d93524"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4370), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 62L, 3 },
                    { new Guid("67676533-c1cc-44e2-9c7a-9671f9d8f73e"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4370), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 63L, 3 },
                    { new Guid("c5c7ef0c-9844-4fb0-b74d-232fbff59b11"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4370), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 64L, 3 },
                    { new Guid("239ee475-a601-453f-87cd-7f6790126c2e"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4380), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 65L, 3 },
                    { new Guid("df875681-3f36-49b9-a0bf-08b38c1c6200"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4380), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 66L, 3 },
                    { new Guid("977f0db1-1075-4fe2-830a-22136509f8bf"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4390), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 67L, 3 },
                    { new Guid("88a5749f-8798-45c0-8389-efea7b1d6369"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4390), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 68L, 3 },
                    { new Guid("a5878340-e677-4fef-a6ad-326c152bdb75"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4390), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 69L, 3 },
                    { new Guid("180b5881-6173-4934-a8de-209697705398"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4400), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 70L, 3 },
                    { new Guid("329acf6a-cb5a-40da-bf26-2d192a30480c"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4400), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 71L, 3 },
                    { new Guid("afe65956-22f0-41e4-8947-11ca55920437"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4410), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 72L, 3 },
                    { new Guid("eb319054-ad81-468d-aa51-221ac54a1a67"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4410), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 73L, 3 }
                });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "PartCost", "PartNumber", "PartWeight" },
                values: new object[,]
                {
                    { new Guid("33678b05-b402-4d3e-9cfd-328050debe2c"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4410), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 74L, 3 },
                    { new Guid("03e9465d-bbda-4cd3-aa90-3908950ed7de"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4420), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 75L, 3 },
                    { new Guid("b24f3b8d-6836-46cc-9ea4-0a6c568dca10"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4420), new TimeSpan(0, 0, 0, 0, 0)), false, null, 71.0, 76L, 3 },
                    { new Guid("a0b11ca3-204e-483f-9d3d-53a3dacea96c"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(4270), new TimeSpan(0, 0, 0, 0, 0)), false, null, 64.0, 52L, 2 },
                    { new Guid("e61d9d87-57cc-4c8c-a7bc-5b73f140ca9b"), new DateTimeOffset(new DateTime(2021, 2, 5, 5, 28, 6, 649, DateTimeKind.Unspecified).AddTicks(5150), new TimeSpan(0, 0, 0, 0, 0)), false, null, 99.0, 210L, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boxes");

            migrationBuilder.DropTable(
                name: "BoxItems");

            migrationBuilder.DropTable(
                name: "Parts");
        }
    }
}
