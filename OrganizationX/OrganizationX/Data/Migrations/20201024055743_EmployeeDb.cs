using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganizationX.Data.Migrations
{
    public partial class EmployeeDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeNumber = table.Column<long>(nullable: false),
                    Age = table.Column<long>(nullable: false),
                    Attrition = table.Column<string>(nullable: false),
                    BusinessTravel = table.Column<string>(nullable: false),
                    DailyRate = table.Column<long>(nullable: false),
                    Department = table.Column<string>(nullable: false),
                    DistanceFromHome = table.Column<long>(nullable: false),
                    Education = table.Column<long>(nullable: false),
                    EducationField = table.Column<string>(nullable: false),
                    EmployeeCount = table.Column<long>(nullable: false),
                    EnvironmentSatisfaction = table.Column<long>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    HourlyRate = table.Column<long>(nullable: false),
                    JobInvolvement = table.Column<long>(nullable: false),
                    JobLevel = table.Column<long>(nullable: false),
                    JobRole = table.Column<string>(nullable: false),
                    JobSatisfaction = table.Column<long>(nullable: false),
                    MaritalStatus = table.Column<string>(nullable: false),
                    MonthlyIncome = table.Column<long>(nullable: false),
                    MonthlyRate = table.Column<long>(nullable: false),
                    NumCompaniesWorked = table.Column<long>(nullable: false),
                    Over18 = table.Column<string>(nullable: false),
                    OverTime = table.Column<string>(nullable: false),
                    PercentSalaryHike = table.Column<long>(nullable: false),
                    PerformanceRating = table.Column<long>(nullable: false),
                    RelationshipSatisfaction = table.Column<long>(nullable: false),
                    StandardHours = table.Column<long>(nullable: false),
                    StockOptionLevel = table.Column<long>(nullable: false),
                    TotalWorkingYears = table.Column<long>(nullable: false),
                    TrainingTimesLastYear = table.Column<long>(nullable: false),
                    WorkLifeBalance = table.Column<long>(nullable: false),
                    YearsAtCompany = table.Column<long>(nullable: false),
                    YearsInCurrentRole = table.Column<long>(nullable: false),
                    YearsSinceLastPromotion = table.Column<long>(nullable: false),
                    YearsWithCurrManager = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
