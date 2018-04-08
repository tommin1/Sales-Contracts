using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Sales_Contracts.Data.Migrations
{
    public partial class customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Application_Method = table.Column<string>(nullable: true),
                    Balance_Due_LCY = table.Column<decimal>(nullable: true),
                    Balance_LCY = table.Column<decimal>(nullable: true),
                    Base_Calendar_Code = table.Column<string>(nullable: true),
                    Blocked = table.Column<string>(nullable: true),
                    Combine_Shipments = table.Column<bool>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Country_Region_Code = table.Column<string>(nullable: true),
                    Credit_Limit_LCY = table.Column<decimal>(nullable: true),
                    Currency_Code = table.Column<string>(nullable: true),
                    Currency_Filter = table.Column<string>(nullable: true),
                    Customer_Disc_Group = table.Column<string>(nullable: true),
                    Customer_Posting_Group = table.Column<string>(nullable: true),
                    Customer_Price_Group = table.Column<string>(nullable: true),
                    Date_Filter = table.Column<string>(nullable: true),
                    ETag = table.Column<string>(nullable: true),
                    Fin_Charge_Terms_Code = table.Column<string>(nullable: true),
                    Gen_Bus_Posting_Group = table.Column<string>(nullable: true),
                    Global_Dimension_1_Filter = table.Column<string>(nullable: true),
                    Global_Dimension_2_Filter = table.Column<string>(nullable: true),
                    IC_Partner_Code = table.Column<string>(nullable: true),
                    Language_Code = table.Column<string>(nullable: true),
                    Last_Date_Modified = table.Column<DateTime>(nullable: true),
                    Location_Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    No = table.Column<string>(nullable: true),
                    Payment_Terms_Code = table.Column<string>(nullable: true),
                    Phone_No = table.Column<string>(nullable: true),
                    Post_Code = table.Column<string>(nullable: true),
                    Reminder_Terms_Code = table.Column<string>(nullable: true),
                    Reserve = table.Column<string>(nullable: true),
                    Responsibility_Center = table.Column<string>(nullable: true),
                    Sales_LCY = table.Column<decimal>(nullable: true),
                    Salesperson_Code = table.Column<string>(nullable: true),
                    Search_Name = table.Column<string>(nullable: true),
                    Shipping_Advice = table.Column<string>(nullable: true),
                    Shipping_Agent_Code = table.Column<string>(nullable: true),
                    VAT_Bus_Posting_Group = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    Address_2 = table.Column<string>(nullable: true),
                    AdjCustProfit = table.Column<decimal>(nullable: true),
                    AdjProfitPct = table.Column<decimal>(nullable: true),
                    Allow_Line_Disc = table.Column<bool>(nullable: true),
                    Application_Method = table.Column<string>(nullable: true),
                    Balance_Due = table.Column<decimal>(nullable: true),
                    Balance_Due_LCY = table.Column<decimal>(nullable: true),
                    Balance_LCY = table.Column<decimal>(nullable: true),
                    Base_Calendar_Code = table.Column<string>(nullable: true),
                    Bill_to_Customer_No = table.Column<string>(nullable: true),
                    Bill_to_Customer_No_LinkID = table.Column<int>(nullable: true),
                    Block_Payment_Tolerance = table.Column<bool>(nullable: true),
                    Blocked = table.Column<string>(nullable: true),
                    BlockedCustomer = table.Column<bool>(nullable: true),
                    CalcCreditLimitLCYExpendedPct = table.Column<decimal>(nullable: true),
                    Cash_Flow_Payment_Terms_Code = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Combine_Shipments = table.Column<bool>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    Copy_Sell_to_Addr_to_Qte_From = table.Column<string>(nullable: true),
                    Country_Region_Code = table.Column<string>(nullable: true),
                    Credit_Limit_LCY = table.Column<decimal>(nullable: true),
                    Currency_Code = table.Column<string>(nullable: true),
                    Currency_Filter = table.Column<string>(nullable: true),
                    CustInvDiscAmountLCY = table.Column<decimal>(nullable: true),
                    CustSalesLCY_CustProfit_AdjmtCostLCY = table.Column<decimal>(nullable: true),
                    CustomerMgt_AvgDaysToPay_No = table.Column<decimal>(nullable: true),
                    Customer_Disc_Group = table.Column<string>(nullable: true),
                    Customer_Posting_Group = table.Column<string>(nullable: true),
                    Customer_Price_Group = table.Column<string>(nullable: true),
                    Customized_Calendar = table.Column<string>(nullable: true),
                    Date_Filter = table.Column<string>(nullable: true),
                    DaysPaidPastDueDate = table.Column<decimal>(nullable: true),
                    Document_Sending_Profile = table.Column<string>(nullable: true),
                    ETag = table.Column<string>(nullable: true),
                    E_Mail = table.Column<string>(nullable: true),
                    Fax_No = table.Column<string>(nullable: true),
                    Fin_Charge_Terms_Code = table.Column<string>(nullable: true),
                    GLN = table.Column<string>(nullable: true),
                    Gen_Bus_Posting_Group = table.Column<string>(nullable: true),
                    GetAmountOnCrMemo = table.Column<decimal>(nullable: true),
                    GetAmountOnOutstandingCrMemos = table.Column<decimal>(nullable: true),
                    GetAmountOnOutstandingInvoices = table.Column<decimal>(nullable: true),
                    GetAmountOnPostedInvoices = table.Column<decimal>(nullable: true),
                    GetMoneyOwedExpected = table.Column<decimal>(nullable: true),
                    Global_Dimension_1_Filter = table.Column<string>(nullable: true),
                    Global_Dimension_2_Filter = table.Column<string>(nullable: true),
                    Home_Page = table.Column<string>(nullable: true),
                    IC_Partner_Code = table.Column<string>(nullable: true),
                    Invoice_Copies = table.Column<int>(nullable: true),
                    Invoice_Disc_Code = table.Column<string>(nullable: true),
                    Invoice_Disc_Code_LinkID = table.Column<int>(nullable: true),
                    Language_Code = table.Column<string>(nullable: true),
                    Last_Date_Modified = table.Column<DateTime>(nullable: true),
                    Last_Statement_No = table.Column<int>(nullable: true),
                    Location_Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    No = table.Column<string>(nullable: true),
                    Partner_Type = table.Column<string>(nullable: true),
                    Payment_Method_Code = table.Column<string>(nullable: true),
                    Payment_Terms_Code = table.Column<string>(nullable: true),
                    Payments_LCY = table.Column<decimal>(nullable: true),
                    Phone_No = table.Column<string>(nullable: true),
                    Post_Code = table.Column<string>(nullable: true),
                    Preferred_Bank_Account_Code = table.Column<string>(nullable: true),
                    Prepayment_Percent = table.Column<decimal>(nullable: true),
                    Prices_Including_VAT = table.Column<bool>(nullable: true),
                    Primary_Contact_No = table.Column<string>(nullable: true),
                    Print_Statements = table.Column<bool>(nullable: true),
                    Reminder_Terms_Code = table.Column<string>(nullable: true),
                    Reserve = table.Column<string>(nullable: true),
                    Responsibility_Center = table.Column<string>(nullable: true),
                    Salesperson_Code = table.Column<string>(nullable: true),
                    Search_Name = table.Column<string>(nullable: true),
                    Service_Zone_Code = table.Column<string>(nullable: true),
                    Shipment_Method_Code = table.Column<string>(nullable: true),
                    Shipping_Advice = table.Column<string>(nullable: true),
                    Shipping_Agent_Code = table.Column<string>(nullable: true),
                    Shipping_Agent_Service_Code = table.Column<string>(nullable: true),
                    Shipping_Time = table.Column<string>(nullable: true),
                    ShowMap = table.Column<string>(nullable: true),
                    TotalMoneyOwed = table.Column<decimal>(nullable: true),
                    TotalSales2 = table.Column<decimal>(nullable: true),
                    Totals = table.Column<decimal>(nullable: true),
                    VAT_Bus_Posting_Group = table.Column<string>(nullable: true),
                    VAT_Registration_No = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customer_Customers_Bill_to_Customer_No_LinkID",
                        column: x => x.Bill_to_Customer_No_LinkID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Customers_Invoice_Disc_Code_LinkID",
                        column: x => x.Invoice_Disc_Code_LinkID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerPriceAndLineDisc",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Allow_Invoice_Disc = table.Column<bool>(nullable: true),
                    Allow_Line_Disc = table.Column<bool>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Currency_Code = table.Column<string>(nullable: true),
                    CustomerID = table.Column<int>(nullable: true),
                    ETag = table.Column<string>(nullable: true),
                    Ending_Date = table.Column<DateTime>(nullable: true),
                    Line_Discount_Percent = table.Column<decimal>(nullable: true),
                    Line_Type = table.Column<string>(nullable: true),
                    Loaded_Customer_No = table.Column<string>(nullable: true),
                    Loaded_Disc_Group = table.Column<string>(nullable: true),
                    Loaded_Item_No = table.Column<string>(nullable: true),
                    Loaded_Price_Group = table.Column<string>(nullable: true),
                    Minimum_Quantity = table.Column<decimal>(nullable: false),
                    Price_Includes_VAT = table.Column<bool>(nullable: true),
                    Sales_Code = table.Column<string>(nullable: true),
                    Sales_Type = table.Column<string>(nullable: true),
                    Starting_Date = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Unit_Price = table.Column<decimal>(nullable: true),
                    Unit_of_Measure_Code = table.Column<string>(nullable: true),
                    VAT_Bus_Posting_Gr_Price = table.Column<string>(nullable: true),
                    Variant_Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPriceAndLineDisc", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerPriceAndLineDisc_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Bill_to_Customer_No_LinkID",
                table: "Customer",
                column: "Bill_to_Customer_No_LinkID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Invoice_Disc_Code_LinkID",
                table: "Customer",
                column: "Invoice_Disc_Code_LinkID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPriceAndLineDisc_CustomerID",
                table: "CustomerPriceAndLineDisc",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CustomerPriceAndLineDisc");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }
    }
}
