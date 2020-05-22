using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Login.Web.Migrations
{
    public partial class tripANdTripsEntitities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TripEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    Source = table.Column<string>(maxLength: 100, nullable: true),
                    Target = table.Column<string>(maxLength: 100, nullable: true),
                    Qualification = table.Column<float>(nullable: false),
                    SourceLatitude = table.Column<double>(nullable: false),
                    SourceLongitude = table.Column<double>(nullable: false),
                    TargetLatitude = table.Column<double>(nullable: false),
                    TargetLongitude = table.Column<double>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    TaxiId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TripEntities_Taxis_TaxiId",
                        column: x => x.TaxiId,
                        principalTable: "Taxis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    TripId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trips_TripEntities_TripId",
                        column: x => x.TripId,
                        principalTable: "TripEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TripEntities_TaxiId",
                table: "TripEntities",
                column: "TaxiId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_TripId",
                table: "Trips",
                column: "TripId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "TripEntities");
        }
    }
}
