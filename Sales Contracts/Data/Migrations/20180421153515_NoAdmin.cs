using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Sales_Contracts.Data.Migrations
{
    public partial class NoAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContractLines");

            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.AddColumn<string>(
                name: "CustomerNo",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "admin",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ContractCompany",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Additional_Field_1 = table.Column<string>(nullable: true),
                    Additional_Field_2 = table.Column<string>(nullable: true),
                    Additional_Field_3 = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Bank_Account_No = table.Column<string>(nullable: true),
                    Bank_Name = table.Column<string>(nullable: true),
                    Chief_Accountant = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    ETag = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Phone_No = table.Column<string>(nullable: true),
                    Post_Code = table.Column<string>(nullable: true),
                    Registration_No = table.Column<string>(nullable: true),
                    Representative = table.Column<string>(nullable: true),
                    VAT_Registration_No = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractCompany", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContractCompany");

            migrationBuilder.DropColumn(
                name: "CustomerNo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "admin",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Account_No = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Agreement_Status_Code = table.Column<string>(nullable: true),
                    Agreement_Valid = table.Column<bool>(nullable: true),
                    Auto_continuation = table.Column<bool>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Contact_Name = table.Column<string>(nullable: true),
                    Contact_No = table.Column<string>(nullable: true),
                    Contract_Date = table.Column<DateTime>(nullable: true),
                    Contract_Duration = table.Column<string>(nullable: true),
                    Contract_No = table.Column<string>(nullable: true),
                    Contract_Type = table.Column<string>(nullable: true),
                    Country_Region_Code = table.Column<string>(nullable: true),
                    Credit_Limit = table.Column<decimal>(nullable: true),
                    Currency_Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ETag = table.Column<string>(nullable: true),
                    E_Mail = table.Column<string>(nullable: true),
                    Ending_Date = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Payment_Terms_Code = table.Column<string>(nullable: true),
                    Phone_No = table.Column<string>(nullable: true),
                    Post_Code = table.Column<string>(nullable: true),
                    Prepaid = table.Column<bool>(nullable: true),
                    Primary_Contract_No = table.Column<string>(nullable: true),
                    Primary_Contract_No_LinkID = table.Column<int>(nullable: true),
                    Responsible_Person_Code = table.Column<string>(nullable: true),
                    Starting_Date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contracts_Contracts_Primary_Contract_No_LinkID",
                        column: x => x.Primary_Contract_No_LinkID,
                        principalTable: "Contracts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contract",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Account_No = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Agreement_Status_Code = table.Column<string>(nullable: true),
                    Agreement_Valid = table.Column<bool>(nullable: true),
                    Auto_continuation = table.Column<bool>(nullable: true),
                    Bank_Account_No = table.Column<string>(nullable: true),
                    Bank_Name = table.Column<string>(nullable: true),
                    Bank_No = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Contact_Name = table.Column<string>(nullable: true),
                    Contact_No = table.Column<string>(nullable: true),
                    Contract_Date = table.Column<DateTime>(nullable: true),
                    Contract_Duration = table.Column<string>(nullable: true),
                    Contract_No = table.Column<string>(nullable: true),
                    Contract_Type = table.Column<string>(nullable: true),
                    Country_Region_Code = table.Column<string>(nullable: true),
                    Credit_Limit = table.Column<decimal>(nullable: true),
                    Currency_Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ETag = table.Column<string>(nullable: true),
                    E_Mail = table.Column<string>(nullable: true),
                    Ending_Date = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Open_ended_Contract = table.Column<bool>(nullable: true),
                    Payment_Terms_Code = table.Column<string>(nullable: true),
                    Phone_No = table.Column<string>(nullable: true),
                    Post_Code = table.Column<string>(nullable: true),
                    Prepaid = table.Column<bool>(nullable: true),
                    Primary_Contract_No = table.Column<string>(nullable: true),
                    Primary_Contract_No_LinkID = table.Column<int>(nullable: true),
                    Responsible_Person_Code = table.Column<string>(nullable: true),
                    Starting_Date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contract_Contracts_Primary_Contract_No_LinkID",
                        column: x => x.Primary_Contract_No_LinkID,
                        principalTable: "Contracts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractLines",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContractID = table.Column<int>(nullable: true),
                    Contract_No = table.Column<string>(nullable: true),
                    Contract_No_LinkID = table.Column<int>(nullable: true),
                    Contract_Type = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Description_2 = table.Column<string>(nullable: true),
                    ETag = table.Column<string>(nullable: true),
                    Line_Discount_Percent = table.Column<decimal>(nullable: true),
                    Line_No = table.Column<int>(nullable: false),
                    Max_Quantity = table.Column<decimal>(nullable: true),
                    Min_Quantity = table.Column<decimal>(nullable: true),
                    No = table.Column<string>(nullable: true),
                    Payment_Terms_Code = table.Column<string>(nullable: true),
                    RealizedQuantity = table.Column<decimal>(nullable: true),
                    Shipment_Due_Date = table.Column<DateTime>(nullable: true),
                    ShortcutDimCode_x005B_3_x005D_ = table.Column<string>(nullable: true),
                    ShortcutDimCode_x005B_4_x005D_ = table.Column<string>(nullable: true),
                    ShortcutDimCode_x005B_5_x005D_ = table.Column<string>(nullable: true),
                    ShortcutDimCode_x005B_6_x005D_ = table.Column<string>(nullable: true),
                    ShortcutDimCode_x005B_7_x005D_ = table.Column<string>(nullable: true),
                    ShortcutDimCode_x005B_8_x005D_ = table.Column<string>(nullable: true),
                    Shortcut_Dimension_1_Code = table.Column<string>(nullable: true),
                    Shortcut_Dimension_2_Code = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Unit_Price = table.Column<decimal>(nullable: true),
                    Unit_of_Measure_Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractLines", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ContractLines_Contract_ContractID",
                        column: x => x.ContractID,
                        principalTable: "Contract",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContractLines_Contracts_Contract_No_LinkID",
                        column: x => x.Contract_No_LinkID,
                        principalTable: "Contracts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contract_Primary_Contract_No_LinkID",
                table: "Contract",
                column: "Primary_Contract_No_LinkID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractLines_ContractID",
                table: "ContractLines",
                column: "ContractID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractLines_Contract_No_LinkID",
                table: "ContractLines",
                column: "Contract_No_LinkID");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_Primary_Contract_No_LinkID",
                table: "Contracts",
                column: "Primary_Contract_No_LinkID");
        }
    }
}
