using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NeoSoftHRMS.Persistence.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccessGroupTbl",
                columns: table => new
                {
                    AccessGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessGroupName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessGroupTbl", x => x.AccessGroupId);
                });

            migrationBuilder.CreateTable(
                name: "BranchTbl",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchTbl", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "CountryTbl",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    CountryCode = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryTbl", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "DesignationTbl",
                columns: table => new
                {
                    DesignationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignationName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignationTbl", x => x.DesignationId);
                });

            migrationBuilder.CreateTable(
                name: "DivisionTbl",
                columns: table => new
                {
                    DivisionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DivisionName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivisionTbl", x => x.DivisionId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTypeTbl",
                columns: table => new
                {
                    EmployeeTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeTypeName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTypeTbl", x => x.EmployeeTypeId);
                });

            migrationBuilder.CreateTable(
                name: "GenderTbl",
                columns: table => new
                {
                    GenderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderTbl", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "HeadDesignationTbl",
                columns: table => new
                {
                    HeadDesignationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadDesignationName = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadDesignationTbl", x => x.HeadDesignationId);
                });

            migrationBuilder.CreateTable(
                name: "ShiftTbl",
                columns: table => new
                {
                    ShiftId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShiftName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftTbl", x => x.ShiftId);
                });

            migrationBuilder.CreateTable(
                name: "StateTbl",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateTbl", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_StateTbl_CountryTbl_CountryId",
                        column: x => x.CountryId,
                        principalTable: "CountryTbl",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeniorHeadTbl",
                columns: table => new
                {
                    SeniorHeadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeniorHeadName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    HeadDesignationId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeniorHeadTbl", x => x.SeniorHeadId);
                    table.ForeignKey(
                        name: "FK_SeniorHeadTbl_HeadDesignationTbl_HeadDesignationId",
                        column: x => x.HeadDesignationId,
                        principalTable: "HeadDesignationTbl",
                        principalColumn: "HeadDesignationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CityTbl",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityTbl", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_CityTbl_StateTbl_StateId",
                        column: x => x.StateId,
                        principalTable: "StateTbl",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationTbl",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationTbl", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_LocationTbl_CityTbl_CityId",
                        column: x => x.CityId,
                        principalTable: "CityTbl",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddEmployeeTbl",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "NVARCHAR(250)", nullable: false),
                    IndianExtNo = table.Column<string>(type: "NVARCHAR(5)", nullable: true),
                    IndianLandLine = table.Column<string>(type: "NVARCHAR(15)", nullable: true),
                    IndianMobile = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    USLandLine = table.Column<string>(type: "NVARCHAR(15)", nullable: true),
                    USMobile = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    SkypeId = table.Column<string>(type: "NVARCHAR(15)", nullable: false),
                    CcEmail = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    HeadDesignationId = table.Column<int>(type: "int", nullable: false),
                    SeniorHeadId = table.Column<int>(type: "int", nullable: false),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DutyHour = table.Column<string>(type: "NVARCHAR(8)", nullable: false),
                    LeftCompany = table.Column<bool>(type: "bit", nullable: false),
                    LeftDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "NVARCHAR(30)", nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR(32)", nullable: false),
                    EmployeeCode = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    DesignationId = table.Column<int>(type: "int", nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    Pincode = table.Column<string>(type: "NVARCHAR(6)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    BccEmail = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    PanNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShiftId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Signature = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    EmployeeTypeId = table.Column<int>(type: "int", nullable: false),
                    AccessGroupId = table.Column<int>(type: "int", nullable: false),
                    LoginStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddEmployeeTbl", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_AddEmployeeTbl_AccessGroupTbl_AccessGroupId",
                        column: x => x.AccessGroupId,
                        principalTable: "AccessGroupTbl",
                        principalColumn: "AccessGroupId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AddEmployeeTbl_BranchTbl_BranchId",
                        column: x => x.BranchId,
                        principalTable: "BranchTbl",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AddEmployeeTbl_CityTbl_CityId",
                        column: x => x.CityId,
                        principalTable: "CityTbl",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AddEmployeeTbl_CountryTbl_CountryId",
                        column: x => x.CountryId,
                        principalTable: "CountryTbl",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AddEmployeeTbl_DesignationTbl_DesignationId",
                        column: x => x.DesignationId,
                        principalTable: "DesignationTbl",
                        principalColumn: "DesignationId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AddEmployeeTbl_DivisionTbl_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "DivisionTbl",
                        principalColumn: "DivisionId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AddEmployeeTbl_EmployeeTypeTbl_EmployeeTypeId",
                        column: x => x.EmployeeTypeId,
                        principalTable: "EmployeeTypeTbl",
                        principalColumn: "EmployeeTypeId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AddEmployeeTbl_GenderTbl_GenderId",
                        column: x => x.GenderId,
                        principalTable: "GenderTbl",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AddEmployeeTbl_HeadDesignationTbl_HeadDesignationId",
                        column: x => x.HeadDesignationId,
                        principalTable: "HeadDesignationTbl",
                        principalColumn: "HeadDesignationId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AddEmployeeTbl_LocationTbl_LocationId",
                        column: x => x.LocationId,
                        principalTable: "LocationTbl",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AddEmployeeTbl_SeniorHeadTbl_SeniorHeadId",
                        column: x => x.SeniorHeadId,
                        principalTable: "SeniorHeadTbl",
                        principalColumn: "SeniorHeadId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AddEmployeeTbl_ShiftTbl_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "ShiftTbl",
                        principalColumn: "ShiftId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AddEmployeeTbl_StateTbl_StateId",
                        column: x => x.StateId,
                        principalTable: "StateTbl",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddEmployeeTbl_AccessGroupId",
                table: "AddEmployeeTbl",
                column: "AccessGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AddEmployeeTbl_BranchId",
                table: "AddEmployeeTbl",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AddEmployeeTbl_CityId",
                table: "AddEmployeeTbl",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AddEmployeeTbl_CountryId",
                table: "AddEmployeeTbl",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AddEmployeeTbl_DesignationId",
                table: "AddEmployeeTbl",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_AddEmployeeTbl_DivisionId",
                table: "AddEmployeeTbl",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_AddEmployeeTbl_EmployeeTypeId",
                table: "AddEmployeeTbl",
                column: "EmployeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AddEmployeeTbl_GenderId",
                table: "AddEmployeeTbl",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_AddEmployeeTbl_HeadDesignationId",
                table: "AddEmployeeTbl",
                column: "HeadDesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_AddEmployeeTbl_LocationId",
                table: "AddEmployeeTbl",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_AddEmployeeTbl_SeniorHeadId",
                table: "AddEmployeeTbl",
                column: "SeniorHeadId");

            migrationBuilder.CreateIndex(
                name: "IX_AddEmployeeTbl_ShiftId",
                table: "AddEmployeeTbl",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_AddEmployeeTbl_StateId",
                table: "AddEmployeeTbl",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_CityTbl_StateId",
                table: "CityTbl",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationTbl_CityId",
                table: "LocationTbl",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_SeniorHeadTbl_HeadDesignationId",
                table: "SeniorHeadTbl",
                column: "HeadDesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_StateTbl_CountryId",
                table: "StateTbl",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddEmployeeTbl");

            migrationBuilder.DropTable(
                name: "AccessGroupTbl");

            migrationBuilder.DropTable(
                name: "BranchTbl");

            migrationBuilder.DropTable(
                name: "DesignationTbl");

            migrationBuilder.DropTable(
                name: "DivisionTbl");

            migrationBuilder.DropTable(
                name: "EmployeeTypeTbl");

            migrationBuilder.DropTable(
                name: "GenderTbl");

            migrationBuilder.DropTable(
                name: "LocationTbl");

            migrationBuilder.DropTable(
                name: "SeniorHeadTbl");

            migrationBuilder.DropTable(
                name: "ShiftTbl");

            migrationBuilder.DropTable(
                name: "CityTbl");

            migrationBuilder.DropTable(
                name: "HeadDesignationTbl");

            migrationBuilder.DropTable(
                name: "StateTbl");

            migrationBuilder.DropTable(
                name: "CountryTbl");
        }
    }
}
