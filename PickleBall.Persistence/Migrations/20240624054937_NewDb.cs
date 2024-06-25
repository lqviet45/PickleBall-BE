using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PickleBall.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NewDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IdentityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DayOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Date",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateWorking = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Date", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wallet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wallet_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.Id);
                    table.ForeignKey(
                        name: "FK_District_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Deposit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WalletId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deposit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deposit_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deposit_Wallet_WalletId",
                        column: x => x.WalletId,
                        principalTable: "Wallet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ward",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ward", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ward_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WalletId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransactionStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transaction_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transaction_Deposit_DepositId",
                        column: x => x.DepositId,
                        principalTable: "Deposit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transaction_Wallet_WalletId",
                        column: x => x.WalletId,
                        principalTable: "Wallet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourtGroup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WalletId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinSlots = table.Column<int>(type: "int", nullable: false),
                    MaxSlots = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourtGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourtGroup_ApplicationUser_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CourtGroup_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourtGroup_Wallet_WalletId",
                        column: x => x.WalletId,
                        principalTable: "Wallet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourtGroup_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookMark",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourtGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookMark", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookMark_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookMark_CourtGroup_CourtGroupId",
                        column: x => x.CourtGroupId,
                        principalTable: "CourtGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourtYard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourtGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CourtYardStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourtYard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourtYard_CourtGroup_CourtGroupId",
                        column: x => x.CourtGroupId,
                        principalTable: "CourtGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DateCourtGroup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourtGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsClosed = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateCourtGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DateCourtGroup_CourtGroup_CourtGroupId",
                        column: x => x.CourtGroupId,
                        principalTable: "CourtGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DateCourtGroup_Date_DateId",
                        column: x => x.DateId,
                        principalTable: "Date",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MediaUrl = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourtGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Media_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Media_CourtGroup_CourtGroupId",
                        column: x => x.CourtGroupId,
                        principalTable: "CourtGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourtYardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CourtGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumberOfPlayers = table.Column<int>(type: "int", nullable: false),
                    TimeRange = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BookingStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_CourtGroup_CourtGroupId",
                        column: x => x.CourtGroupId,
                        principalTable: "CourtGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Booking_CourtYard_CourtYardId",
                        column: x => x.CourtYardId,
                        principalTable: "CourtYard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Booking_Date_DateId",
                        column: x => x.DateId,
                        principalTable: "Date",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cost",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MorningCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Afternoon = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EveningCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CourtYardType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CourtYardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cost_CourtYard_CourtYardId",
                        column: x => x.CourtYardId,
                        principalTable: "CourtYard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Slot",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourtYardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SlotName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slot_CourtYard_CourtYardId",
                        column: x => x.CourtYardId,
                        principalTable: "CourtYard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SlotBooking",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SlotId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlotBooking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SlotBooking_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SlotBooking_Slot_SlotId",
                        column: x => x.SlotId,
                        principalTable: "Slot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DayOfBirth", "Email", "EmailConfirmed", "FirstName", "FullName", "IdentityId", "LastName", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("059f0b6a-1940-021d-901e-108a95bc55cb"), 0, "55b6e6d2-1129-48f5-abb7-7eb0aa637aff", new DateTime(2020, 12, 17, 20, 37, 7, 370, DateTimeKind.Unspecified).AddTicks(1432), null, false, "Dean", "Dean Kuhic", "0cc9905f-3365-ff2c-1f9f-4aba085d8770", "Kuhic", "East Brodyville", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("07f55f54-53db-bc35-fdb4-1e717d9a0efb"), 0, "fcbd4c32-81af-467f-8d8d-3b6a8a30b15f", new DateTime(2020, 12, 16, 19, 44, 19, 255, DateTimeKind.Unspecified).AddTicks(787), null, false, "Donna", "Donna Champlin", "df4b81d6-345d-97dc-9d44-8bb8facc20f6", "Champlin", "Lake Cecilia", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("09157063-f7b9-3de0-5999-e058bfd294d2"), 0, "79c277a7-dc3d-4b41-8ae5-0fd12956061d", new DateTime(2020, 8, 6, 23, 42, 39, 78, DateTimeKind.Unspecified).AddTicks(3070), null, false, "Jack", "Jack Kuhic", "9ee3119c-4328-3f79-e77b-88bbe364ee3e", "Kuhic", "West Julien", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("1233f8f5-32db-7367-7ee3-dac050c8d597"), 0, "78f276fe-8190-4913-8882-cc78a115ccbc", new DateTime(2020, 12, 9, 2, 5, 56, 377, DateTimeKind.Unspecified).AddTicks(5649), null, false, "Terrance", "Terrance Romaguera", "66e6e571-a162-719b-66b2-929c755de312", "Romaguera", "Carleyhaven", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("18d34369-a53b-032e-483f-3773c3e7b578"), 0, "7b64f889-ea55-4bf0-90fb-b10a6f2b0602", new DateTime(2020, 6, 3, 12, 8, 57, 912, DateTimeKind.Unspecified).AddTicks(7736), null, false, "Maxine", "Maxine Ruecker", "e6ae1478-8f1b-c943-f57b-e72e6c001c6d", "Ruecker", "Collinston", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("1b95837c-302e-82d9-d3e3-5c19fca249af"), 0, "894f7d02-a027-4087-b99a-079bbd2253b8", new DateTime(2020, 9, 4, 9, 6, 41, 467, DateTimeKind.Unspecified).AddTicks(4414), null, false, "Diana", "Diana Powlowski", "2e768de9-5437-4cd3-f08b-d2e2e7d40211", "Powlowski", "Anitamouth", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("1c32f657-87c5-33dc-2dda-a177a4571d84"), 0, "75fb2601-0894-4515-9a46-ca5f41959951", new DateTime(2020, 4, 6, 1, 36, 14, 740, DateTimeKind.Unspecified).AddTicks(1950), null, false, "Dixie", "Dixie Gutkowski", "ce783dce-3330-39f6-ccd4-c9e7f969e278", "Gutkowski", "Port Zora", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("1d16222e-1f0e-1a0c-5815-5e539e98ce71"), 0, "8b083873-4a92-4f74-a930-ec8bffe422f3", new DateTime(2020, 8, 23, 3, 33, 28, 785, DateTimeKind.Unspecified).AddTicks(7708), null, false, "Keith", "Keith Harber", "d514bae7-e826-25b0-02af-0fdda22d0484", "Harber", "Wolftown", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("2096d739-97f1-5726-27cd-ede8d3504da0"), 0, "b260c69c-499f-4a5f-9b78-680054970b0d", new DateTime(2020, 11, 1, 16, 50, 13, 175, DateTimeKind.Unspecified).AddTicks(9464), null, false, "Randy", "Randy Pfannerstill", "1b11925c-517c-ecf5-a4d0-66b86f322057", "Pfannerstill", "Quitzonstad", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("2667404a-245a-3ccc-8b84-6bcf135effe7"), 0, "88600619-d974-4a28-a736-d27075899de7", new DateTime(2020, 6, 8, 12, 8, 24, 319, DateTimeKind.Unspecified).AddTicks(9966), null, false, "Harold", "Harold Spinka", "59cac7e4-231b-c59d-acd3-11c12b699747", "Spinka", "East Arch", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("26a67ecd-6180-8d3b-fd52-41408b6939c3"), 0, "139445f8-3f8a-405e-b9b1-fa1a3b24578f", new DateTime(2020, 7, 2, 10, 44, 13, 859, DateTimeKind.Unspecified).AddTicks(5186), null, false, "Omar", "Omar Funk", "4beba8bb-5ef4-c802-76d5-5caf7391e5e8", "Funk", "Arnulfomouth", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("2aad91df-816e-d669-9d49-6e5763a37c45"), 0, "840b9a88-c028-4fac-aeb5-935eba38216e", new DateTime(2020, 9, 30, 10, 27, 37, 878, DateTimeKind.Unspecified).AddTicks(6802), null, false, "Dana", "Dana Zemlak", "a1a4b064-b5a1-6239-54ea-94f627f5d5ee", "Zemlak", "Jaskolskitown", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("3140208e-efb5-0baa-5dcf-f3688dfb49d4"), 0, "5cb0d71f-1dea-4931-a1d7-4e3036d9138e", new DateTime(2020, 10, 8, 6, 14, 50, 65, DateTimeKind.Unspecified).AddTicks(8727), null, false, "Pablo", "Pablo Hilll", "6ddae3f3-6dd0-b5d3-9730-c62b54d79fc1", "Hilll", "Dantestad", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("31c8786a-f2fa-ab7a-0bac-5f1e9b3f2bcd"), 0, "52069692-f756-4b73-acaf-66900916bd02", new DateTime(2020, 5, 28, 3, 59, 23, 872, DateTimeKind.Unspecified).AddTicks(9311), null, false, "Kelly", "Kelly Leuschke", "ad0e2ced-74dc-76db-8864-6ffd2dc498c6", "Leuschke", "East Alecburgh", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("333a1cdf-9180-489a-54b3-b6f44bf638e2"), 0, "56f8a6d8-50c6-4dfb-ae29-ecaa2453d98b", new DateTime(2020, 6, 17, 14, 3, 17, 865, DateTimeKind.Unspecified).AddTicks(3488), null, false, "Marlon", "Marlon Stamm", "83379392-106b-2fae-28cf-057e64db923d", "Stamm", "Lake Josestad", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("335ac148-c512-5b69-ffda-43761a02659d"), 0, "b156f167-d45a-4a4d-aed9-3a80720d94f9", new DateTime(2020, 3, 28, 11, 31, 29, 356, DateTimeKind.Unspecified).AddTicks(9946), null, false, "Kathleen", "Kathleen Simonis", "a6f14516-e376-69e7-fa14-3707d3bec6d3", "Simonis", "North Friedrichberg", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("3ec9b182-31fc-749c-dd38-f3bcb0dede4d"), 0, "24c1ff2f-c434-4990-9b41-fd1ad37c8bbb", new DateTime(2020, 6, 19, 14, 41, 41, 225, DateTimeKind.Unspecified).AddTicks(8597), null, false, "Andy", "Andy Macejkovic", "273ee7fa-1096-0806-6580-6035ad238abb", "Macejkovic", "Lake Anastacioland", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("3ece3fb3-867d-a0ec-c08c-c4d7a942e500"), 0, "5f1741c5-99d8-440a-8beb-e7ef168873d6", new DateTime(2020, 2, 26, 10, 2, 45, 185, DateTimeKind.Unspecified).AddTicks(3074), null, false, "Caleb", "Caleb McLaughlin", "8d7cfe35-4037-69a4-9010-3e955372071c", "McLaughlin", "Garrybury", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("4571167a-fb5e-362b-9985-3d5adc0468ba"), 0, "4fe0d0a5-4d8c-471c-92db-03f7b929cae1", new DateTime(2020, 2, 24, 16, 38, 40, 750, DateTimeKind.Unspecified).AddTicks(9350), null, false, "Jennifer", "Jennifer Walter", "3421c057-2c71-d10c-d6a7-0dc0be6e42a1", "Walter", "North Beth", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("4c126f9a-33e0-75c9-f02b-a2757bdecca9"), 0, "763a0361-2616-4bda-b1de-eeeb50cfedd3", new DateTime(2020, 8, 7, 13, 34, 8, 149, DateTimeKind.Unspecified).AddTicks(1897), null, false, "Tim", "Tim Bayer", "05b7e294-9934-a5b8-0f18-137e48268997", "Bayer", "Johnsonside", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("4e7220ff-01af-050f-260e-566ab34b8a58"), 0, "0575951b-23ff-47ac-a5ae-77e3963ecdb4", new DateTime(2020, 3, 11, 10, 7, 25, 949, DateTimeKind.Unspecified).AddTicks(9082), null, false, "Doris", "Doris West", "997b4e3f-4f96-e3c9-f6ce-a9307486cf39", "West", "South Osborne", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("609afabf-efdb-fb3f-7207-2583625812b2"), 0, "82026001-5543-48ef-b75d-d96e344ca01e", new DateTime(2020, 12, 19, 23, 57, 39, 209, DateTimeKind.Unspecified).AddTicks(6954), null, false, "Eva", "Eva Morar", "29038bbd-cf05-e388-f26d-ea42379b2495", "Morar", "Lake Dagmarburgh", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("60e01340-3a21-225b-1cfd-f38583c3b73c"), 0, "bf41c3fa-9bd8-431f-93de-848f7a82540c", new DateTime(2020, 11, 17, 3, 23, 32, 533, DateTimeKind.Unspecified).AddTicks(2815), null, false, "Justin", "Justin Moen", "59f4c3dd-63c7-802c-fb31-bd9e977a1968", "Moen", "North Leonburgh", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("61674358-aa9b-9f64-d9f7-8f1a58970f78"), 0, "ea5605ef-e627-499b-ad9d-94435102c71b", new DateTime(2020, 10, 11, 7, 47, 8, 409, DateTimeKind.Unspecified).AddTicks(1603), null, false, "Rex", "Rex Rohan", "cebdf523-6ef2-84d8-8d04-bd66760f9121", "Rohan", "Reichertville", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("6452ec5b-59d8-7ce6-64aa-80f861750375"), 0, "5d2b0aee-dd7f-4310-b9fb-fd5909535bab", new DateTime(2020, 6, 29, 14, 13, 19, 528, DateTimeKind.Unspecified).AddTicks(9534), null, false, "Louise", "Louise Dickens", "ba3ee3a6-83cc-fdb8-70ee-5b5ec895bb0d", "Dickens", "East Herthashire", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("660c4f13-ac34-972b-b671-5e720dd466c3"), 0, "2f8f7579-e03f-43a2-b0e5-f1768e316bb3", new DateTime(2020, 5, 3, 1, 56, 51, 685, DateTimeKind.Unspecified).AddTicks(6891), null, false, "Melanie", "Melanie Hirthe", "99031a60-1784-2efd-0d49-2832ad01cfc7", "Hirthe", "South Cameron", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("6833ed3a-236f-0ee7-896b-1c4a69d03e78"), 0, "c18aa8c2-8f91-457b-bcb2-c46eaa44803e", new DateTime(2020, 10, 9, 21, 41, 20, 744, DateTimeKind.Unspecified).AddTicks(4161), null, false, "Clay", "Clay Block", "4d61e3ca-0fbc-7439-93b0-bd1b7f83bd0f", "Block", "New Charleneville", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("6f110748-4060-7943-3d81-f85d8b09c12c"), 0, "f7710835-9258-4b24-923a-6528eecafebf", new DateTime(2020, 8, 16, 2, 16, 17, 355, DateTimeKind.Unspecified).AddTicks(2873), null, false, "Ernestine", "Ernestine Beahan", "d00c731a-22e1-2a78-d380-652c3a592a59", "Beahan", "East Monicaborough", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("78f7dc5f-0278-90bd-523a-268de4bc0e49"), 0, "2e7030da-a207-4690-a517-433d8e8eb283", new DateTime(2020, 4, 23, 21, 24, 2, 936, DateTimeKind.Unspecified).AddTicks(9287), null, false, "Ramon", "Ramon Bosco", "bf7d49f4-add1-3f5d-6662-ab0691ba4f72", "Bosco", "Lake Diegoland", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("7c844000-8c04-39ea-0259-b55207b2c092"), 0, "1dec64f7-256d-4bf1-bbec-64df48f6b331", new DateTime(2020, 10, 29, 9, 20, 29, 351, DateTimeKind.Unspecified).AddTicks(6256), null, false, "Nettie", "Nettie Hahn", "7b9c8e27-b616-0e1a-1a5a-283e9c9f2fe8", "Hahn", "Feeneymouth", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("7f5038db-db10-9886-e48c-3e1f519a4cfc"), 0, "7553bbe4-cee6-48b4-90dc-273e91aa49c9", new DateTime(2020, 1, 20, 21, 3, 20, 574, DateTimeKind.Unspecified).AddTicks(2441), null, false, "Jerry", "Jerry O'Kon", "00af2f42-9ce6-645d-bfe6-9d7cdf8189f2", "O'Kon", "New Kelli", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("883f6641-68e4-d729-affb-e4c4535dc8e2"), 0, "7011d872-0c59-4a4e-abee-4bbde6213b9f", new DateTime(2020, 5, 2, 3, 7, 29, 821, DateTimeKind.Unspecified).AddTicks(3433), null, false, "Rudolph", "Rudolph Feil", "74f225c1-084b-88ab-0cd4-bc0b8fa62b50", "Feil", "New Roslyn", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("88c74234-830e-5eb8-783e-185b933787f0"), 0, "33e077cd-e18b-4714-bf10-005279e78c0b", new DateTime(2020, 8, 10, 0, 29, 7, 348, DateTimeKind.Unspecified).AddTicks(8816), null, false, "Patti", "Patti Dickinson", "6be9abeb-a828-9374-79e3-1a87032718f6", "Dickinson", "Margretside", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("88df2f3a-6795-d362-6d43-591ec672055d"), 0, "6408b9b7-4cbb-4d6d-81c5-9b6524b4a25e", new DateTime(2020, 11, 16, 1, 17, 41, 85, DateTimeKind.Unspecified).AddTicks(8045), null, false, "Max", "Max Bruen", "81de96d9-8353-6fb1-0a58-350ef0f5e74a", "Bruen", "Port Anthonyside", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("89b78bdb-be24-151c-31f7-e7421644e19f"), 0, "6c3ff478-7157-4998-9d52-de75d60f1d78", new DateTime(2020, 12, 4, 5, 31, 47, 647, DateTimeKind.Unspecified).AddTicks(8932), null, false, "Ernesto", "Ernesto Dibbert", "3f0bad4c-7e24-a819-d4f6-bf35f9c96c0c", "Dibbert", "New Murrayburgh", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("958622b0-9ce3-bd80-11a2-342663de9bee"), 0, "a67561f2-c737-4a9d-8ee4-d8f2b543cf6b", new DateTime(2020, 3, 31, 17, 47, 26, 954, DateTimeKind.Unspecified).AddTicks(239), null, false, "Elsie", "Elsie Lesch", "fc672374-bd8b-3d43-1b61-81f96b27f458", "Lesch", "South Wellingtonborough", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), 0, "bef3b3c3-56bd-4992-9d2e-5b01239fe119", new DateTime(2020, 9, 30, 14, 49, 12, 324, DateTimeKind.Unspecified).AddTicks(1575), null, false, "Kim", "Kim Renner", "46e63ca8-ed80-6881-bd10-e2e3d1cca53c", "Renner", "Gilesview", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("97eb2ed4-df10-55bd-d364-a3db4a109f23"), 0, "6ce4ace3-b534-4029-9502-1a31bc07958e", new DateTime(2020, 9, 26, 2, 56, 29, 481, DateTimeKind.Unspecified).AddTicks(7744), null, false, "Olivia", "Olivia Greenfelder", "7f012fb3-032d-c7d6-bf08-c60ada4af9c5", "Greenfelder", "Hintzshire", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("9c3b8b80-ec77-0d7d-387e-ebec94e998eb"), 0, "a363a542-bc38-4bab-8c27-5f8a6f1c7bd8", new DateTime(2020, 10, 27, 11, 38, 29, 834, DateTimeKind.Unspecified).AddTicks(9796), null, false, "Percy", "Percy Carter", "1fa7f76b-474c-ae73-e30c-1006428e31ba", "Carter", "Haleyville", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("a70e2abe-63c2-d3ef-4c81-3e6c0feb02be"), 0, "7e6831e8-c1c4-4794-aa69-a94cc92ccc6e", new DateTime(2020, 2, 24, 8, 3, 19, 580, DateTimeKind.Unspecified).AddTicks(5577), null, false, "Claude", "Claude Wehner", "21d66fc3-0e9c-5c52-a0bb-1f3447fcccf8", "Wehner", "South Lowellberg", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("b35b2234-24f4-2054-ad1a-71ce513a15ab"), 0, "4e1d3397-172d-4655-b80b-5e30cb66db30", new DateTime(2020, 11, 19, 23, 12, 48, 388, DateTimeKind.Unspecified).AddTicks(793), null, false, "Carlton", "Carlton Steuber", "fa6f8747-3f5d-bbef-55f9-f750e56dce5a", "Steuber", "South Evalynland", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("cce0516f-9f9f-f24f-f163-d6b684ab1f52"), 0, "7ee6fcd9-9c89-4be7-bbfa-7578d391537d", new DateTime(2020, 5, 29, 17, 52, 26, 881, DateTimeKind.Unspecified).AddTicks(7072), null, false, "Dave", "Dave Bartoletti", "31c807c8-b2f3-9f0b-f233-689f2b1041c7", "Bartoletti", "North Deeville", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("cf08e502-8911-c595-40a7-61187ed55224"), 0, "009fe3fc-d8ab-4c8a-a4f2-92fed50d02a8", new DateTime(2020, 7, 7, 13, 11, 57, 707, DateTimeKind.Unspecified).AddTicks(2001), null, false, "Lynda", "Lynda Heller", "36a9ff8f-811b-ae7c-63cb-ef0d43492d90", "Heller", "East Warrenfort", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("f046ac78-05d2-c7c1-40ea-bf733a9492ed"), 0, "1bdd0c20-8fe8-47a7-b90e-5bc8c5b8d63b", new DateTime(2020, 2, 2, 22, 21, 38, 181, DateTimeKind.Unspecified).AddTicks(736), null, false, "Woodrow", "Woodrow Pouros", "aa42f7bc-4e80-4075-063f-cb3fb0b39468", "Pouros", "Mantefort", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f"), 0, "a50c21ec-f105-4b67-a52f-8ea667892d87", new DateTime(2020, 6, 6, 14, 14, 59, 560, DateTimeKind.Unspecified).AddTicks(2355), null, false, "Danny", "Danny Armstrong", "2fd8dec3-11a8-7963-28c8-2ad32a72b863", "Armstrong", "Deckowtown", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("f29a2a8e-4d8b-a1cd-8c19-b674b6ff66b4"), 0, "39ba65e2-87e7-45f1-9155-77313bb49c35", new DateTime(2020, 4, 30, 15, 16, 41, 409, DateTimeKind.Unspecified).AddTicks(8424), null, false, "Diane", "Diane Kulas", "fa6fed24-694c-b0a5-3bd8-cdc1c06247ad", "Kulas", "South Jodyport", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("f3dcdac7-43a2-0adf-530c-9653f4b2c78d"), 0, "c5f5b8bd-9153-404f-8e47-2f9b80153b5a", new DateTime(2020, 1, 10, 9, 56, 53, 661, DateTimeKind.Unspecified).AddTicks(5249), null, false, "Terry", "Terry Satterfield", "52bcd238-7cbc-1c6d-22c9-5e2f6a009a54", "Satterfield", "West Merrittport", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("f4e4bdec-d0c1-62a7-fb99-0355c25a4a9d"), 0, "f09ddbfe-f252-418c-a268-4964f297823c", new DateTime(2020, 1, 30, 22, 50, 30, 865, DateTimeKind.Unspecified).AddTicks(8223), null, false, "April", "April Frami", "f7937bb7-a2e3-1eb9-6d17-c530ca9261b5", "Frami", "West Forest", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("fa1681fd-093d-667e-c5fd-012c2fc33394"), 0, "4dad8228-6fd8-4b2c-8a00-7b07b8347c10", new DateTime(2020, 10, 14, 15, 52, 36, 123, DateTimeKind.Unspecified).AddTicks(3623), null, false, "Harry", "Harry Abbott", "a4d60023-2f40-602b-ee79-b453e39036df", "Abbott", "Port Minnie", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("fb7425eb-5298-bbd0-7d77-413ff692b4dc"), 0, "2b97bc64-f6e4-4b5a-891a-0cf2baf7ea07", new DateTime(2020, 11, 8, 20, 35, 7, 810, DateTimeKind.Unspecified).AddTicks(5020), null, false, "Kara", "Kara Koch", "8691391b-7ae7-ddd9-7b79-e1135bbb7788", "Koch", "Valentinaland", false, null, null, null, null, null, false, null, false, null }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2020, 1, 6, 11, 20, 48, 83, DateTimeKind.Unspecified).AddTicks(6269), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 11, 22, 2, 30, 11, 875, DateTimeKind.Unspecified).AddTicks(9674), new TimeSpan(0, 7, 0, 0, 0)), "Jakubowskiville" },
                    { 2, new DateTimeOffset(new DateTime(2020, 12, 27, 21, 33, 38, 736, DateTimeKind.Unspecified).AddTicks(9842), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 3, 26, 21, 0, 47, 806, DateTimeKind.Unspecified).AddTicks(9375), new TimeSpan(0, 7, 0, 0, 0)), "Kilbackberg" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 3, new DateTimeOffset(new DateTime(2020, 4, 18, 16, 4, 20, 728, DateTimeKind.Unspecified).AddTicks(3117), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 6, 20, 43, 23, 19, DateTimeKind.Unspecified).AddTicks(2827), new TimeSpan(0, 7, 0, 0, 0)), "South Georgianaburgh" },
                    { 4, new DateTimeOffset(new DateTime(2020, 4, 8, 8, 6, 42, 657, DateTimeKind.Unspecified).AddTicks(9516), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 8, 1, 56, 42, 864, DateTimeKind.Unspecified).AddTicks(7753), new TimeSpan(0, 7, 0, 0, 0)), "North Eulahborough" },
                    { 5, new DateTimeOffset(new DateTime(2020, 4, 22, 18, 58, 22, 478, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 28, 6, 34, 59, 431, DateTimeKind.Unspecified).AddTicks(2710), new TimeSpan(0, 7, 0, 0, 0)), "Tiffanyton" },
                    { 6, new DateTimeOffset(new DateTime(2020, 4, 24, 12, 34, 33, 312, DateTimeKind.Unspecified).AddTicks(9355), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 4, 3, 16, 41, 6, 639, DateTimeKind.Unspecified).AddTicks(4618), new TimeSpan(0, 7, 0, 0, 0)), "North Evanhaven" },
                    { 7, new DateTimeOffset(new DateTime(2020, 7, 2, 1, 56, 13, 215, DateTimeKind.Unspecified).AddTicks(6503), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 15, 1, 34, 11, 827, DateTimeKind.Unspecified).AddTicks(8059), new TimeSpan(0, 7, 0, 0, 0)), "North Donnaburgh" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 8, new DateTimeOffset(new DateTime(2020, 5, 10, 20, 52, 37, 915, DateTimeKind.Unspecified).AddTicks(4484), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 5, 19, 0, 47, 52, 520, DateTimeKind.Unspecified).AddTicks(7715), new TimeSpan(0, 7, 0, 0, 0)), "South Evelineport" },
                    { 9, new DateTimeOffset(new DateTime(2020, 12, 4, 19, 47, 4, 192, DateTimeKind.Unspecified).AddTicks(237), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 7, 25, 21, 45, 20, 988, DateTimeKind.Unspecified).AddTicks(7780), new TimeSpan(0, 7, 0, 0, 0)), "Mertzview" },
                    { 10, new DateTimeOffset(new DateTime(2020, 8, 27, 6, 3, 16, 777, DateTimeKind.Unspecified).AddTicks(6594), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 6, 19, 20, 46, 30, 233, DateTimeKind.Unspecified).AddTicks(7572), new TimeSpan(0, 7, 0, 0, 0)), "New Sebastian" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[] { 11, new DateTimeOffset(new DateTime(2020, 10, 31, 3, 47, 15, 901, DateTimeKind.Unspecified).AddTicks(194), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 6, 20, 2, 54, 43, 526, DateTimeKind.Unspecified).AddTicks(1230), new TimeSpan(0, 7, 0, 0, 0)), "Waltershire" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[] { 12, new DateTimeOffset(new DateTime(2020, 12, 14, 6, 8, 51, 693, DateTimeKind.Unspecified).AddTicks(8474), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 3, 10, 3, 55, 22, 952, DateTimeKind.Unspecified).AddTicks(1296), new TimeSpan(0, 7, 0, 0, 0)), "Lubowitzfurt" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[] { 13, new DateTimeOffset(new DateTime(2020, 3, 16, 0, 18, 20, 830, DateTimeKind.Unspecified).AddTicks(3603), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 1, 14, 34, 10, 735, DateTimeKind.Unspecified).AddTicks(4846), new TimeSpan(0, 7, 0, 0, 0)), "Russelborough" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 14, new DateTimeOffset(new DateTime(2020, 2, 4, 2, 42, 30, 340, DateTimeKind.Unspecified).AddTicks(4394), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 10, 17, 14, 30, 51, 308, DateTimeKind.Unspecified).AddTicks(5638), new TimeSpan(0, 7, 0, 0, 0)), "Amaraburgh" },
                    { 15, new DateTimeOffset(new DateTime(2020, 5, 6, 7, 17, 1, 420, DateTimeKind.Unspecified).AddTicks(6102), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 8, 11, 12, 27, 58, 191, DateTimeKind.Unspecified).AddTicks(5620), new TimeSpan(0, 7, 0, 0, 0)), "Ryanberg" },
                    { 16, new DateTimeOffset(new DateTime(2020, 10, 28, 10, 59, 58, 655, DateTimeKind.Unspecified).AddTicks(6819), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 5, 15, 21, 18, 31, 727, DateTimeKind.Unspecified).AddTicks(7011), new TimeSpan(0, 7, 0, 0, 0)), "Port Morganbury" },
                    { 17, new DateTimeOffset(new DateTime(2020, 4, 25, 21, 29, 23, 826, DateTimeKind.Unspecified).AddTicks(5985), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 6, 5, 21, 48, 101, DateTimeKind.Unspecified).AddTicks(5170), new TimeSpan(0, 7, 0, 0, 0)), "Lake Skye" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 18, new DateTimeOffset(new DateTime(2020, 10, 3, 15, 40, 12, 836, DateTimeKind.Unspecified).AddTicks(5869), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 5, 2, 15, 12, 50, 158, DateTimeKind.Unspecified).AddTicks(6323), new TimeSpan(0, 7, 0, 0, 0)), "Sawaynborough" },
                    { 19, new DateTimeOffset(new DateTime(2020, 4, 7, 19, 48, 40, 196, DateTimeKind.Unspecified).AddTicks(6126), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 7, 22, 40, 45, 671, DateTimeKind.Unspecified).AddTicks(480), new TimeSpan(0, 7, 0, 0, 0)), "Jeffburgh" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 20, new DateTimeOffset(new DateTime(2020, 9, 27, 17, 41, 8, 63, DateTimeKind.Unspecified).AddTicks(6226), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 3, 29, 21, 55, 51, 684, DateTimeKind.Unspecified).AddTicks(8544), new TimeSpan(0, 7, 0, 0, 0)), "Reichertport" },
                    { 21, new DateTimeOffset(new DateTime(2020, 2, 12, 17, 24, 44, 840, DateTimeKind.Unspecified).AddTicks(7113), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 2, 11, 19, 53, 21, 949, DateTimeKind.Unspecified).AddTicks(1782), new TimeSpan(0, 7, 0, 0, 0)), "East Clovis" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 22, new DateTimeOffset(new DateTime(2020, 4, 2, 20, 19, 20, 572, DateTimeKind.Unspecified).AddTicks(3483), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 26, 13, 41, 52, 193, DateTimeKind.Unspecified).AddTicks(3034), new TimeSpan(0, 7, 0, 0, 0)), "New Merl" },
                    { 23, new DateTimeOffset(new DateTime(2020, 7, 12, 8, 29, 34, 78, DateTimeKind.Unspecified).AddTicks(4355), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 8, 22, 14, 2, 51, 750, DateTimeKind.Unspecified).AddTicks(5840), new TimeSpan(0, 7, 0, 0, 0)), "Fredericberg" },
                    { 24, new DateTimeOffset(new DateTime(2020, 2, 4, 12, 7, 51, 222, DateTimeKind.Unspecified).AddTicks(68), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 10, 23, 56, 58, 613, DateTimeKind.Unspecified).AddTicks(4561), new TimeSpan(0, 7, 0, 0, 0)), "Justonstad" },
                    { 25, new DateTimeOffset(new DateTime(2020, 5, 14, 1, 46, 1, 514, DateTimeKind.Unspecified).AddTicks(7233), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 9, 13, 23, 8, 15, 823, DateTimeKind.Unspecified).AddTicks(9973), new TimeSpan(0, 7, 0, 0, 0)), "Dickinsonberg" },
                    { 26, new DateTimeOffset(new DateTime(2020, 6, 12, 10, 38, 42, 910, DateTimeKind.Unspecified).AddTicks(2775), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 8, 15, 5, 23, 11, 158, DateTimeKind.Unspecified).AddTicks(3588), new TimeSpan(0, 7, 0, 0, 0)), "Andreston" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[] { 27, new DateTimeOffset(new DateTime(2020, 3, 3, 22, 30, 55, 391, DateTimeKind.Unspecified).AddTicks(871), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 5, 19, 40, 17, 984, DateTimeKind.Unspecified).AddTicks(1684), new TimeSpan(0, 7, 0, 0, 0)), "Port Stanleytown" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 28, new DateTimeOffset(new DateTime(2020, 12, 27, 10, 29, 24, 579, DateTimeKind.Unspecified).AddTicks(2079), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 18, 22, 4, 24, 934, DateTimeKind.Unspecified).AddTicks(9374), new TimeSpan(0, 7, 0, 0, 0)), "Nitzscheport" },
                    { 29, new DateTimeOffset(new DateTime(2020, 4, 16, 16, 37, 14, 265, DateTimeKind.Unspecified).AddTicks(5460), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 10, 8, 37, 12, 680, DateTimeKind.Unspecified).AddTicks(1728), new TimeSpan(0, 7, 0, 0, 0)), "West Sammy" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[] { 30, new DateTimeOffset(new DateTime(2020, 12, 28, 19, 20, 22, 432, DateTimeKind.Unspecified).AddTicks(6965), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 4, 22, 7, 40, 1, 142, DateTimeKind.Unspecified).AddTicks(8395), new TimeSpan(0, 7, 0, 0, 0)), "East Delfina" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 31, new DateTimeOffset(new DateTime(2020, 10, 11, 7, 47, 8, 409, DateTimeKind.Unspecified).AddTicks(1603), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 3, 19, 6, 30, 41, 714, DateTimeKind.Unspecified).AddTicks(7448), new TimeSpan(0, 7, 0, 0, 0)), "Grimesfort" },
                    { 32, new DateTimeOffset(new DateTime(2020, 8, 9, 6, 59, 37, 33, DateTimeKind.Unspecified).AddTicks(3154), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 3, 28, 17, 11, 21, 446, DateTimeKind.Unspecified).AddTicks(9998), new TimeSpan(0, 7, 0, 0, 0)), "Port Eraberg" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 33, new DateTimeOffset(new DateTime(2020, 11, 13, 7, 45, 19, 607, DateTimeKind.Unspecified).AddTicks(6985), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 9, 9, 20, 42, 58, 424, DateTimeKind.Unspecified).AddTicks(7269), new TimeSpan(0, 7, 0, 0, 0)), "Jordynhaven" },
                    { 34, new DateTimeOffset(new DateTime(2020, 6, 15, 11, 36, 33, 861, DateTimeKind.Unspecified).AddTicks(7603), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 5, 5, 16, 42, 44, 959, DateTimeKind.Unspecified).AddTicks(4274), new TimeSpan(0, 7, 0, 0, 0)), "North Ashlynnhaven" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 35, new DateTimeOffset(new DateTime(2020, 5, 12, 15, 22, 34, 259, DateTimeKind.Unspecified).AddTicks(5883), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 4, 13, 50, 6, 653, DateTimeKind.Unspecified).AddTicks(5869), new TimeSpan(0, 7, 0, 0, 0)), "Schmidtshire" },
                    { 36, new DateTimeOffset(new DateTime(2020, 10, 7, 6, 42, 30, 532, DateTimeKind.Unspecified).AddTicks(9483), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 6, 20, 8, 24, 30, 596, DateTimeKind.Unspecified).AddTicks(5973), new TimeSpan(0, 7, 0, 0, 0)), "Port Alvinamouth" },
                    { 37, new DateTimeOffset(new DateTime(2020, 10, 12, 6, 44, 36, 651, DateTimeKind.Unspecified).AddTicks(734), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 30, 3, 13, 56, 240, DateTimeKind.Unspecified).AddTicks(6919), new TimeSpan(0, 7, 0, 0, 0)), "Sporerland" },
                    { 38, new DateTimeOffset(new DateTime(2020, 6, 20, 18, 3, 17, 130, DateTimeKind.Unspecified).AddTicks(2827), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 10, 23, 15, 48, 6, DateTimeKind.Unspecified).AddTicks(5378), new TimeSpan(0, 7, 0, 0, 0)), "East Joyceberg" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[] { 39, new DateTimeOffset(new DateTime(2020, 4, 21, 22, 23, 28, 2, DateTimeKind.Unspecified).AddTicks(2845), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 8, 6, 0, 38, 9, 279, DateTimeKind.Unspecified).AddTicks(7183), new TimeSpan(0, 7, 0, 0, 0)), "Jonasshire" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 40, new DateTimeOffset(new DateTime(2020, 8, 20, 2, 42, 5, 684, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 12, 29, 17, 48, 19, 865, DateTimeKind.Unspecified).AddTicks(6258), new TimeSpan(0, 7, 0, 0, 0)), "Howellside" },
                    { 41, new DateTimeOffset(new DateTime(2020, 5, 5, 7, 40, 4, 153, DateTimeKind.Unspecified).AddTicks(2839), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 4, 5, 4, 40, 2, 547, DateTimeKind.Unspecified).AddTicks(6549), new TimeSpan(0, 7, 0, 0, 0)), "South Kaylastad" },
                    { 42, new DateTimeOffset(new DateTime(2020, 8, 31, 13, 55, 4, 355, DateTimeKind.Unspecified).AddTicks(501), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 1, 19, 13, 11, 383, DateTimeKind.Unspecified).AddTicks(5758), new TimeSpan(0, 7, 0, 0, 0)), "Izabellamouth" },
                    { 43, new DateTimeOffset(new DateTime(2020, 10, 26, 4, 10, 53, 704, DateTimeKind.Unspecified).AddTicks(319), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 9, 11, 14, 43, 3, 786, DateTimeKind.Unspecified).AddTicks(1844), new TimeSpan(0, 7, 0, 0, 0)), "Kobymouth" },
                    { 44, new DateTimeOffset(new DateTime(2020, 9, 11, 9, 21, 24, 742, DateTimeKind.Unspecified).AddTicks(5141), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 4, 22, 12, 49, 53, 385, DateTimeKind.Unspecified).AddTicks(5153), new TimeSpan(0, 7, 0, 0, 0)), "South Amie" },
                    { 45, new DateTimeOffset(new DateTime(2020, 1, 13, 17, 20, 7, 146, DateTimeKind.Unspecified).AddTicks(8644), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 30, 20, 9, 54, 142, DateTimeKind.Unspecified).AddTicks(6302), new TimeSpan(0, 7, 0, 0, 0)), "West Wendy" },
                    { 46, new DateTimeOffset(new DateTime(2020, 1, 27, 16, 55, 50, 381, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 6, 22, 7, 33, 11, 275, DateTimeKind.Unspecified).AddTicks(6197), new TimeSpan(0, 7, 0, 0, 0)), "North Kaci" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 47, new DateTimeOffset(new DateTime(2020, 2, 7, 14, 50, 43, 347, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 6, 17, 23, 54, 58, 995, DateTimeKind.Unspecified).AddTicks(4366), new TimeSpan(0, 7, 0, 0, 0)), "Samantaport" },
                    { 48, new DateTimeOffset(new DateTime(2020, 4, 25, 8, 5, 58, 449, DateTimeKind.Unspecified).AddTicks(6619), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 4, 26, 23, 7, 4, 673, DateTimeKind.Unspecified).AddTicks(9507), new TimeSpan(0, 7, 0, 0, 0)), "East Warrenfort" },
                    { 49, new DateTimeOffset(new DateTime(2020, 6, 11, 10, 26, 47, 283, DateTimeKind.Unspecified).AddTicks(7826), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 10, 23, 18, 32, 16, 422, DateTimeKind.Unspecified).AddTicks(5192), new TimeSpan(0, 7, 0, 0, 0)), "New Preston" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[] { 50, new DateTimeOffset(new DateTime(2020, 8, 19, 6, 2, 10, 193, DateTimeKind.Unspecified).AddTicks(6713), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 5, 5, 4, 23, 45, 761, DateTimeKind.Unspecified).AddTicks(4016), new TimeSpan(0, 7, 0, 0, 0)), "Port Marleyburgh" });

            migrationBuilder.InsertData(
                table: "Date",
                columns: new[] { "Id", "CreatedOnUtc", "DateStatus", "DateWorking", "IsDeleted", "ModifiedOnUtc" },
                values: new object[,]
                {
                    { new Guid("01ad3228-c7cf-2c9e-d4a1-fd8116fa3d09"), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 1, 31, 147, DateTimeKind.Unspecified).AddTicks(1051), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2024, 3, 19, 18, 54, 41, 644, DateTimeKind.Local).AddTicks(1102), false, new DateTimeOffset(new DateTime(2024, 1, 12, 13, 17, 25, 982, DateTimeKind.Unspecified).AddTicks(9898), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("0a0ab19c-dca2-9549-e1e4-78b199327e3a"), new DateTimeOffset(new DateTime(2023, 7, 16, 0, 13, 35, 179, DateTimeKind.Unspecified).AddTicks(5460), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 12, 29, 5, 31, 25, 990, DateTimeKind.Local).AddTicks(8588), true, new DateTimeOffset(new DateTime(2023, 12, 16, 9, 20, 43, 180, DateTimeKind.Unspecified).AddTicks(4989), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("0a6fb183-3558-f00e-f5e7-4a756503f84a"), new DateTimeOffset(new DateTime(2023, 10, 6, 5, 50, 37, 560, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 12, 29, 23, 40, 11, 917, DateTimeKind.Local).AddTicks(207), false, new DateTimeOffset(new DateTime(2023, 8, 18, 10, 27, 58, 759, DateTimeKind.Unspecified).AddTicks(7743), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("0b40e562-d9b5-504a-8985-07682b0d588f"), new DateTimeOffset(new DateTime(2023, 9, 26, 14, 47, 35, 834, DateTimeKind.Unspecified).AddTicks(3684), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 8, 21, 6, 53, 8, 635, DateTimeKind.Local).AddTicks(4731), true, new DateTimeOffset(new DateTime(2024, 6, 9, 0, 22, 27, 63, DateTimeKind.Unspecified).AddTicks(6773), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("15c913df-778a-5837-5d13-48652553d7ec"), new DateTimeOffset(new DateTime(2024, 3, 21, 1, 22, 12, 882, DateTimeKind.Unspecified).AddTicks(3381), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 10, 5, 8, 31, 1, 793, DateTimeKind.Local).AddTicks(6094), true, new DateTimeOffset(new DateTime(2024, 3, 6, 20, 17, 13, 338, DateTimeKind.Unspecified).AddTicks(2159), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("1bea9f71-a600-20c9-1c80-f09d1740b7b9"), new DateTimeOffset(new DateTime(2023, 6, 26, 11, 9, 12, 966, DateTimeKind.Unspecified).AddTicks(7558), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 12, 14, 11, 24, 52, 316, DateTimeKind.Local).AddTicks(360), false, new DateTimeOffset(new DateTime(2023, 8, 14, 11, 51, 49, 809, DateTimeKind.Unspecified).AddTicks(8189), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("23a9378e-d600-40a4-2f2b-60ee79b453e3"), new DateTimeOffset(new DateTime(2023, 10, 31, 3, 0, 8, 0, DateTimeKind.Unspecified).AddTicks(9334), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 6, 17, 15, 27, 46, 83, DateTimeKind.Local).AddTicks(4509), true, new DateTimeOffset(new DateTime(2024, 4, 7, 4, 42, 12, 799, DateTimeKind.Unspecified).AddTicks(2180), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("2cedef5f-ad0e-74dc-db76-88646ffd2dc4"), new DateTimeOffset(new DateTime(2023, 11, 19, 16, 49, 0, 548, DateTimeKind.Unspecified).AddTicks(7944), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 6, 25, 0, 39, 46, 929, DateTimeKind.Local).AddTicks(110), true, new DateTimeOffset(new DateTime(2024, 5, 21, 20, 14, 10, 419, DateTimeKind.Unspecified).AddTicks(5888), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("2dd53712-d464-ab85-d589-e18ec580c88b"), new DateTimeOffset(new DateTime(2023, 12, 5, 13, 53, 30, 473, DateTimeKind.Unspecified).AddTicks(8674), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 2, 14, 2, 52, 28, 426, DateTimeKind.Local).AddTicks(3744), false, new DateTimeOffset(new DateTime(2023, 12, 13, 2, 8, 15, 680, DateTimeKind.Unspecified).AddTicks(4728), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("31663645-0c09-f634-73cd-57a9e98d762e"), new DateTimeOffset(new DateTime(2024, 5, 18, 18, 30, 15, 347, DateTimeKind.Unspecified).AddTicks(3988), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 10, 11, 14, 30, 23, 767, DateTimeKind.Local).AddTicks(4358), true, new DateTimeOffset(new DateTime(2024, 2, 23, 20, 24, 53, 194, DateTimeKind.Unspecified).AddTicks(232), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("329db5e7-fa1e-fcc9-05d4-975ed3d8499f"), new DateTimeOffset(new DateTime(2023, 8, 16, 10, 50, 54, 478, DateTimeKind.Unspecified).AddTicks(1596), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2024, 1, 8, 4, 35, 51, 122, DateTimeKind.Local).AddTicks(5575), true, new DateTimeOffset(new DateTime(2023, 7, 24, 23, 4, 45, 977, DateTimeKind.Unspecified).AddTicks(8745), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("33c32f2c-6294-2427-27ce-133348d2a829"), new DateTimeOffset(new DateTime(2023, 11, 1, 9, 35, 32, 157, DateTimeKind.Unspecified).AddTicks(7948), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 7, 15, 3, 48, 26, 256, DateTimeKind.Local).AddTicks(3016), true, new DateTimeOffset(new DateTime(2024, 3, 18, 8, 22, 49, 133, DateTimeKind.Unspecified).AddTicks(5403), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("41cd8dba-2c1f-9307-b7df-385c9a4619ab"), new DateTimeOffset(new DateTime(2023, 10, 26, 16, 25, 11, 968, DateTimeKind.Unspecified).AddTicks(2029), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 6, 28, 1, 25, 56, 424, DateTimeKind.Local).AddTicks(7455), false, new DateTimeOffset(new DateTime(2024, 3, 3, 4, 4, 20, 416, DateTimeKind.Unspecified).AddTicks(7732), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"), new DateTimeOffset(new DateTime(2024, 2, 3, 5, 5, 12, 814, DateTimeKind.Unspecified).AddTicks(8318), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 7, 8, 18, 42, 10, 150, DateTimeKind.Local).AddTicks(4299), false, new DateTimeOffset(new DateTime(2023, 11, 18, 1, 23, 8, 23, DateTimeKind.Unspecified).AddTicks(5717), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("438c5b08-ff8f-36a9-1b81-7cae63cbef0d"), new DateTimeOffset(new DateTime(2023, 8, 1, 3, 40, 20, 23, DateTimeKind.Unspecified).AddTicks(900), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 8, 12, 22, 59, 1, 589, DateTimeKind.Local).AddTicks(1030), true, new DateTimeOffset(new DateTime(2023, 12, 10, 12, 44, 35, 671, DateTimeKind.Unspecified).AddTicks(2460), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("4ee9d2ad-28cd-df95-80ff-ff977fca08f6"), new DateTimeOffset(new DateTime(2023, 7, 4, 7, 8, 18, 654, DateTimeKind.Unspecified).AddTicks(9529), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 4, 1, 16, 54, 19, 466, DateTimeKind.Local).AddTicks(4675), false, new DateTimeOffset(new DateTime(2023, 8, 22, 6, 9, 54, 936, DateTimeKind.Unspecified).AddTicks(761), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("568c09f6-f8f3-7e55-ac44-2d01fb2b510c"), new DateTimeOffset(new DateTime(2024, 5, 7, 15, 40, 52, 32, DateTimeKind.Unspecified).AddTicks(9897), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 9, 8, 1, 30, 32, 798, DateTimeKind.Local).AddTicks(3704), true, new DateTimeOffset(new DateTime(2024, 4, 4, 19, 34, 13, 326, DateTimeKind.Unspecified).AddTicks(8777), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("586f024d-8980-f523-bdce-f26ed8848d04"), new DateTimeOffset(new DateTime(2024, 5, 19, 6, 53, 16, 997, DateTimeKind.Unspecified).AddTicks(9043), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 6, 21, 8, 9, 59, 108, DateTimeKind.Local).AddTicks(4901), true, new DateTimeOffset(new DateTime(2023, 9, 12, 4, 12, 52, 606, DateTimeKind.Unspecified).AddTicks(5708), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("65d2756d-3dd3-155c-3a97-87de8ded6a3a"), new DateTimeOffset(new DateTime(2024, 3, 8, 12, 31, 20, 23, DateTimeKind.Unspecified).AddTicks(4622), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 12, 15, 9, 25, 31, 408, DateTimeKind.Local).AddTicks(9724), true, new DateTimeOffset(new DateTime(2023, 7, 13, 5, 9, 59, 575, DateTimeKind.Unspecified).AddTicks(6108), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"), new DateTimeOffset(new DateTime(2024, 6, 20, 7, 39, 18, 717, DateTimeKind.Unspecified).AddTicks(3037), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 7, 7, 19, 52, 51, 393, DateTimeKind.Local).AddTicks(606), true, new DateTimeOffset(new DateTime(2023, 8, 26, 11, 20, 32, 66, DateTimeKind.Unspecified).AddTicks(8798), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("72ff2f81-65bc-ae2b-5287-501db8b47d7f"), new DateTimeOffset(new DateTime(2023, 10, 29, 11, 43, 0, 963, DateTimeKind.Unspecified).AddTicks(6795), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2024, 5, 22, 22, 13, 41, 894, DateTimeKind.Local).AddTicks(6350), true, new DateTimeOffset(new DateTime(2023, 8, 9, 4, 9, 15, 266, DateTimeKind.Unspecified).AddTicks(4402), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("786a9718-31c8-f2fa-7aab-0bac5f1e9b3f"), new DateTimeOffset(new DateTime(2023, 12, 21, 0, 21, 52, 762, DateTimeKind.Unspecified).AddTicks(5117), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2024, 5, 12, 16, 11, 1, 49, DateTimeKind.Local).AddTicks(9457), false, new DateTimeOffset(new DateTime(2024, 5, 6, 20, 42, 27, 570, DateTimeKind.Unspecified).AddTicks(6677), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("7ee018f5-529b-b002-62f6-8e93af65c0a8"), new DateTimeOffset(new DateTime(2024, 3, 24, 11, 30, 51, 709, DateTimeKind.Unspecified).AddTicks(6398), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 8, 12, 8, 2, 43, 353, DateTimeKind.Local).AddTicks(1103), false, new DateTimeOffset(new DateTime(2024, 3, 28, 8, 51, 17, 586, DateTimeKind.Unspecified).AddTicks(8729), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("88df2f3a-6795-d362-6d43-591ec672055d"), new DateTimeOffset(new DateTime(2024, 5, 13, 22, 43, 32, 331, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 4, 22, 16, 52, 35, 714, DateTimeKind.Local).AddTicks(3096), false, new DateTimeOffset(new DateTime(2024, 4, 27, 16, 0, 3, 179, DateTimeKind.Unspecified).AddTicks(3666), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("8a824ff6-5da4-5a90-b481-2ddcd8750729"), new DateTimeOffset(new DateTime(2024, 2, 28, 8, 27, 14, 565, DateTimeKind.Unspecified).AddTicks(1191), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 7, 9, 15, 22, 31, 646, DateTimeKind.Local).AddTicks(3939), false, new DateTimeOffset(new DateTime(2024, 2, 1, 10, 19, 7, 411, DateTimeKind.Unspecified).AddTicks(6325), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"), new DateTimeOffset(new DateTime(2023, 11, 7, 10, 43, 14, 787, DateTimeKind.Unspecified).AddTicks(9872), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 12, 27, 10, 48, 16, 98, DateTimeKind.Local).AddTicks(7645), false, new DateTimeOffset(new DateTime(2024, 6, 18, 3, 57, 24, 331, DateTimeKind.Unspecified).AddTicks(1989), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("91dfd5e5-2aad-816e-69d6-9d496e5763a3"), new DateTimeOffset(new DateTime(2023, 8, 25, 20, 24, 55, 533, DateTimeKind.Unspecified).AddTicks(498), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 12, 18, 23, 10, 46, 324, DateTimeKind.Local).AddTicks(4232), false, new DateTimeOffset(new DateTime(2024, 2, 14, 18, 58, 8, 849, DateTimeKind.Unspecified).AddTicks(9229), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("945bcd22-15c9-5455-89f7-4e1337084c23"), new DateTimeOffset(new DateTime(2024, 1, 11, 20, 11, 9, 257, DateTimeKind.Unspecified).AddTicks(6509), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 3, 5, 3, 32, 40, 461, DateTimeKind.Local).AddTicks(9914), true, new DateTimeOffset(new DateTime(2023, 12, 25, 4, 56, 22, 928, DateTimeKind.Unspecified).AddTicks(8582), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("9565b1f8-8099-f90f-8b29-3b957e2d5fd5"), new DateTimeOffset(new DateTime(2024, 1, 1, 4, 59, 25, 116, DateTimeKind.Unspecified).AddTicks(4002), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 2, 22, 1, 5, 0, 746, DateTimeKind.Local).AddTicks(4107), false, new DateTimeOffset(new DateTime(2024, 4, 7, 19, 3, 20, 159, DateTimeKind.Unspecified).AddTicks(5399), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new DateTimeOffset(new DateTime(2023, 9, 30, 20, 53, 42, 332, DateTimeKind.Unspecified).AddTicks(1272), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 10, 11, 4, 53, 57, 403, DateTimeKind.Local).AddTicks(7389), true, new DateTimeOffset(new DateTime(2024, 5, 22, 23, 2, 13, 813, DateTimeKind.Unspecified).AddTicks(3320), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("97581a8f-780f-3896-228c-51e74509eb80"), new DateTimeOffset(new DateTime(2024, 3, 21, 6, 30, 44, 739, DateTimeKind.Unspecified).AddTicks(4119), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 10, 4, 12, 42, 1, 484, DateTimeKind.Local).AddTicks(511), true, new DateTimeOffset(new DateTime(2023, 9, 21, 10, 45, 28, 360, DateTimeKind.Unspecified).AddTicks(6439), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("a1a1a4b0-39b5-5462-ea94-f627f5d5eee0"), new DateTimeOffset(new DateTime(2024, 6, 11, 11, 14, 15, 172, DateTimeKind.Unspecified).AddTicks(8481), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 7, 14, 19, 53, 19, 627, DateTimeKind.Local).AddTicks(3488), true, new DateTimeOffset(new DateTime(2023, 10, 25, 2, 34, 20, 677, DateTimeKind.Unspecified).AddTicks(5403), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("a89ed451-1505-13b4-c458-7a030c759f3f"), new DateTimeOffset(new DateTime(2023, 11, 18, 5, 40, 53, 637, DateTimeKind.Unspecified).AddTicks(4579), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 3, 28, 5, 1, 0, 120, DateTimeKind.Local).AddTicks(23), true, new DateTimeOffset(new DateTime(2024, 1, 16, 11, 7, 51, 192, DateTimeKind.Unspecified).AddTicks(1750), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("a951f11b-2234-b35b-f424-5420ad1a71ce"), new DateTimeOffset(new DateTime(2023, 10, 27, 17, 13, 22, 437, DateTimeKind.Unspecified).AddTicks(2125), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2024, 3, 4, 11, 45, 29, 371, DateTimeKind.Local).AddTicks(680), true, new DateTimeOffset(new DateTime(2023, 11, 4, 18, 50, 18, 540, DateTimeKind.Unspecified).AddTicks(478), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("a99052b6-a953-00fb-7f94-ad45509c5449"), new DateTimeOffset(new DateTime(2024, 5, 4, 20, 17, 7, 744, DateTimeKind.Unspecified).AddTicks(8374), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 2, 7, 5, 8, 51, 211, DateTimeKind.Local).AddTicks(5563), true, new DateTimeOffset(new DateTime(2024, 5, 6, 22, 46, 28, 749, DateTimeKind.Unspecified).AddTicks(8679), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("b552bde3-659b-cead-d5fa-148bef7b2fa2"), new DateTimeOffset(new DateTime(2024, 2, 28, 21, 44, 10, 383, DateTimeKind.Unspecified).AddTicks(4625), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 12, 12, 23, 57, 49, 65, DateTimeKind.Local).AddTicks(8621), false, new DateTimeOffset(new DateTime(2024, 5, 26, 10, 26, 12, 830, DateTimeKind.Unspecified).AddTicks(3532), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("c764ce19-c657-b651-c26d-f786a83ce646"), new DateTimeOffset(new DateTime(2024, 4, 25, 3, 23, 47, 411, DateTimeKind.Unspecified).AddTicks(2706), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 2, 21, 3, 4, 31, 696, DateTimeKind.Local).AddTicks(334), false, new DateTimeOffset(new DateTime(2023, 11, 23, 13, 29, 30, 821, DateTimeKind.Unspecified).AddTicks(3208), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("c962b121-02f9-08e5-cf11-8995c540a761"), new DateTimeOffset(new DateTime(2024, 5, 8, 10, 54, 3, 416, DateTimeKind.Unspecified).AddTicks(5571), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2024, 2, 14, 5, 48, 31, 566, DateTimeKind.Local).AddTicks(4336), false, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 49, 24, 604, DateTimeKind.Unspecified).AddTicks(2879), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("d1e3e210-a5cc-8b3c-b036-22584367619b"), new DateTimeOffset(new DateTime(2024, 2, 28, 13, 41, 55, 217, DateTimeKind.Unspecified).AddTicks(9689), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 11, 7, 10, 8, 8, 403, DateTimeKind.Local).AddTicks(4882), false, new DateTimeOffset(new DateTime(2023, 9, 2, 3, 55, 13, 893, DateTimeKind.Unspecified).AddTicks(5778), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("d382d930-5ce3-fc19-a249-af962f5f0ce2"), new DateTimeOffset(new DateTime(2024, 5, 20, 20, 22, 32, 710, DateTimeKind.Unspecified).AddTicks(1695), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 7, 11, 20, 34, 34, 350, DateTimeKind.Local).AddTicks(7531), false, new DateTimeOffset(new DateTime(2024, 2, 10, 9, 50, 6, 952, DateTimeKind.Unspecified).AddTicks(5841), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("d40d725e-c366-8b4f-8503-1295b3ba6483"), new DateTimeOffset(new DateTime(2023, 10, 3, 21, 56, 16, 201, DateTimeKind.Unspecified).AddTicks(5527), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 8, 15, 2, 9, 33, 489, DateTimeKind.Local).AddTicks(3917), false, new DateTimeOffset(new DateTime(2023, 7, 9, 17, 17, 24, 778, DateTimeKind.Unspecified).AddTicks(3161), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("d869bded-4313-a2e6-a4e8-a0bd6c2ba7d6"), new DateTimeOffset(new DateTime(2024, 6, 22, 6, 37, 56, 541, DateTimeKind.Unspecified).AddTicks(4317), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 8, 1, 20, 41, 35, 217, DateTimeKind.Local).AddTicks(8520), true, new DateTimeOffset(new DateTime(2023, 10, 16, 23, 28, 39, 351, DateTimeKind.Unspecified).AddTicks(3758), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("de9b9d52-a435-67eb-d140-657d5050c5b9"), new DateTimeOffset(new DateTime(2023, 12, 24, 6, 21, 1, 571, DateTimeKind.Unspecified).AddTicks(5031), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 5, 27, 9, 32, 14, 942, DateTimeKind.Local).AddTicks(257), true, new DateTimeOffset(new DateTime(2023, 9, 14, 22, 36, 11, 239, DateTimeKind.Unspecified).AddTicks(4054), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("decd2662-0804-7b5c-9997-690f47fb03e9"), new DateTimeOffset(new DateTime(2024, 5, 10, 0, 12, 42, 670, DateTimeKind.Unspecified).AddTicks(7410), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 8, 10, 19, 8, 41, 343, DateTimeKind.Local).AddTicks(8441), true, new DateTimeOffset(new DateTime(2023, 12, 15, 11, 26, 43, 629, DateTimeKind.Unspecified).AddTicks(8008), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d"), new DateTimeOffset(new DateTime(2023, 8, 4, 12, 45, 20, 469, DateTimeKind.Unspecified).AddTicks(9336), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2024, 4, 27, 7, 52, 24, 734, DateTimeKind.Local).AddTicks(1159), true, new DateTimeOffset(new DateTime(2023, 7, 5, 16, 25, 29, 70, DateTimeKind.Unspecified).AddTicks(3537), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("e7e2d28b-02d4-3311-7a1c-f2134f0c6634"), new DateTimeOffset(new DateTime(2023, 8, 23, 11, 38, 51, 135, DateTimeKind.Unspecified).AddTicks(5554), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 10, 19, 12, 48, 25, 537, DateTimeKind.Local).AddTicks(1722), false, new DateTimeOffset(new DateTime(2023, 10, 9, 7, 38, 14, 233, DateTimeKind.Unspecified).AddTicks(8111), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("ec779c3b-0d7d-7e38-ebec-94e998eb0c68"), new DateTimeOffset(new DateTime(2023, 6, 28, 18, 37, 1, 472, DateTimeKind.Unspecified).AddTicks(162), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 5, 11, 11, 37, 40, 858, DateTimeKind.Local).AddTicks(6876), true, new DateTimeOffset(new DateTime(2023, 12, 21, 3, 14, 3, 286, DateTimeKind.Unspecified).AddTicks(5872), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("f24616bd-e6a9-6c93-6269-33ef855ab90a"), new DateTimeOffset(new DateTime(2024, 5, 21, 11, 22, 34, 299, DateTimeKind.Unspecified).AddTicks(9207), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 9, 26, 5, 30, 43, 315, DateTimeKind.Local).AddTicks(2394), true, new DateTimeOffset(new DateTime(2024, 6, 9, 16, 53, 22, 119, DateTimeKind.Unspecified).AddTicks(5736), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("fa6f8747-3f5d-bbef-55f9-f750e56dce5a"), new DateTimeOffset(new DateTime(2024, 1, 2, 11, 50, 3, 907, DateTimeKind.Unspecified).AddTicks(5060), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2024, 5, 13, 12, 2, 25, 63, DateTimeKind.Local).AddTicks(8961), true, new DateTimeOffset(new DateTime(2024, 2, 20, 18, 40, 12, 591, DateTimeKind.Unspecified).AddTicks(1381), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("ffd7dafa-8d35-ae04-36c7-ca601a039984"), new DateTimeOffset(new DateTime(2023, 10, 5, 19, 23, 15, 14, DateTimeKind.Unspecified).AddTicks(964), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 1, 7, 9, 11, 44, 137, DateTimeKind.Local).AddTicks(9764), true, new DateTimeOffset(new DateTime(2024, 6, 15, 8, 3, 7, 652, DateTimeKind.Unspecified).AddTicks(7192), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[] { 1, 39, new DateTimeOffset(new DateTime(2020, 11, 22, 2, 30, 11, 875, DateTimeKind.Unspecified).AddTicks(9674), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 9, 10, 18, 7, 9, 466, DateTimeKind.Unspecified).AddTicks(5804), new TimeSpan(0, 7, 0, 0, 0)), "East Winnifred" });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 2, 23, new DateTimeOffset(new DateTime(2020, 12, 29, 5, 34, 57, 8, DateTimeKind.Unspecified).AddTicks(8054), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 6, 28, 7, 57, 47, 122, DateTimeKind.Unspecified).AddTicks(2925), new TimeSpan(0, 7, 0, 0, 0)), "North Novatown" },
                    { 3, 14, new DateTimeOffset(new DateTime(2020, 11, 29, 10, 12, 37, 137, DateTimeKind.Unspecified).AddTicks(6391), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 1, 18, 0, 40, 732, DateTimeKind.Unspecified).AddTicks(7403), new TimeSpan(0, 7, 0, 0, 0)), "Darronchester" },
                    { 4, 17, new DateTimeOffset(new DateTime(2020, 5, 6, 19, 13, 45, 178, DateTimeKind.Unspecified).AddTicks(6852), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 1, 27, 18, 40, 14, 889, DateTimeKind.Unspecified).AddTicks(4474), new TimeSpan(0, 7, 0, 0, 0)), "Sonyafort" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[] { 5, 35, new DateTimeOffset(new DateTime(2020, 12, 17, 20, 11, 26, 629, DateTimeKind.Unspecified).AddTicks(6764), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 8, 29, 4, 10, 31, 221, DateTimeKind.Unspecified).AddTicks(2731), new TimeSpan(0, 7, 0, 0, 0)), "Wuckertton" });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 6, 35, new DateTimeOffset(new DateTime(2020, 12, 17, 4, 3, 45, 443, DateTimeKind.Unspecified).AddTicks(7917), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 9, 23, 14, 5, 17, 780, DateTimeKind.Unspecified).AddTicks(6107), new TimeSpan(0, 7, 0, 0, 0)), "Marleyton" },
                    { 7, 25, new DateTimeOffset(new DateTime(2020, 7, 6, 4, 39, 34, 443, DateTimeKind.Unspecified).AddTicks(2006), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 8, 28, 18, 0, 20, 743, DateTimeKind.Unspecified).AddTicks(9128), new TimeSpan(0, 7, 0, 0, 0)), "Lynchtown" },
                    { 8, 33, new DateTimeOffset(new DateTime(2020, 5, 28, 2, 14, 44, 345, DateTimeKind.Unspecified).AddTicks(3713), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 7, 26, 18, 4, 23, 383, DateTimeKind.Unspecified).AddTicks(8763), new TimeSpan(0, 7, 0, 0, 0)), "Antwonside" },
                    { 9, 22, new DateTimeOffset(new DateTime(2020, 8, 27, 6, 3, 16, 777, DateTimeKind.Unspecified).AddTicks(6594), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 6, 19, 20, 46, 30, 233, DateTimeKind.Unspecified).AddTicks(7572), new TimeSpan(0, 7, 0, 0, 0)), "West Macyhaven" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 10, 40, new DateTimeOffset(new DateTime(2020, 6, 20, 2, 54, 43, 526, DateTimeKind.Unspecified).AddTicks(1230), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 5, 29, 5, 5, 50, 377, DateTimeKind.Unspecified).AddTicks(5220), new TimeSpan(0, 7, 0, 0, 0)), "Wisozkville" },
                    { 11, 28, new DateTimeOffset(new DateTime(2020, 12, 4, 9, 2, 9, 344, DateTimeKind.Unspecified).AddTicks(5560), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 3, 3, 4, 6, 51, 355, DateTimeKind.Unspecified).AddTicks(4368), new TimeSpan(0, 7, 0, 0, 0)), "Amaliafort" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 12, 17, new DateTimeOffset(new DateTime(2020, 5, 21, 10, 14, 36, 581, DateTimeKind.Unspecified).AddTicks(468), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 13, 22, 5, 44, 562, DateTimeKind.Unspecified).AddTicks(7091), new TimeSpan(0, 7, 0, 0, 0)), "Cummeratastad" },
                    { 13, 46, new DateTimeOffset(new DateTime(2020, 9, 30, 14, 49, 12, 324, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 5, 6, 7, 17, 1, 420, DateTimeKind.Unspecified).AddTicks(6102), new TimeSpan(0, 7, 0, 0, 0)), "South Sylvanmouth" },
                    { 14, 22, new DateTimeOffset(new DateTime(2020, 10, 28, 10, 59, 58, 655, DateTimeKind.Unspecified).AddTicks(6819), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 5, 15, 21, 18, 31, 727, DateTimeKind.Unspecified).AddTicks(7011), new TimeSpan(0, 7, 0, 0, 0)), "Port Morganbury" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[] { 15, 16, new DateTimeOffset(new DateTime(2020, 12, 6, 5, 21, 48, 101, DateTimeKind.Unspecified).AddTicks(5170), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 25, 18, 12, 56, 262, DateTimeKind.Unspecified).AddTicks(39), new TimeSpan(0, 7, 0, 0, 0)), "Trantowfurt" });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[] { 16, 40, new DateTimeOffset(new DateTime(2020, 4, 1, 19, 9, 10, 198, DateTimeKind.Unspecified).AddTicks(6035), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 7, 1, 12, 30, 59, 578, DateTimeKind.Unspecified).AddTicks(1059), new TimeSpan(0, 7, 0, 0, 0)), "East Mallie" });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 17, 15, new DateTimeOffset(new DateTime(2020, 2, 14, 11, 51, 42, 831, DateTimeKind.Unspecified).AddTicks(6846), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 4, 11, 23, 52, 24, 808, DateTimeKind.Unspecified).AddTicks(2624), new TimeSpan(0, 7, 0, 0, 0)), "Jaynemouth" },
                    { 18, 14, new DateTimeOffset(new DateTime(2020, 11, 3, 6, 58, 6, 227, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 20, 9, 51, 34, 696, DateTimeKind.Unspecified).AddTicks(1255), new TimeSpan(0, 7, 0, 0, 0)), "Hayesburgh" },
                    { 19, 45, new DateTimeOffset(new DateTime(2020, 4, 15, 16, 56, 23, 292, DateTimeKind.Unspecified).AddTicks(5470), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 4, 2, 20, 19, 20, 572, DateTimeKind.Unspecified).AddTicks(3483), new TimeSpan(0, 7, 0, 0, 0)), "West Laura" },
                    { 20, 39, new DateTimeOffset(new DateTime(2020, 7, 12, 8, 29, 34, 78, DateTimeKind.Unspecified).AddTicks(4355), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 8, 22, 14, 2, 51, 750, DateTimeKind.Unspecified).AddTicks(5840), new TimeSpan(0, 7, 0, 0, 0)), "Fredericberg" },
                    { 21, 28, new DateTimeOffset(new DateTime(2020, 2, 10, 23, 56, 58, 613, DateTimeKind.Unspecified).AddTicks(4561), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 18, 15, 20, 19, 783, DateTimeKind.Unspecified).AddTicks(8340), new TimeSpan(0, 7, 0, 0, 0)), "Kyraside" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 22, 10, new DateTimeOffset(new DateTime(2020, 6, 23, 12, 32, 12, 163, DateTimeKind.Unspecified).AddTicks(1880), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 10, 7, 11, 10, 478, DateTimeKind.Unspecified).AddTicks(5587), new TimeSpan(0, 7, 0, 0, 0)), "New Elianside" },
                    { 23, 28, new DateTimeOffset(new DateTime(2020, 1, 14, 7, 3, 14, 717, DateTimeKind.Unspecified).AddTicks(2686), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 2, 7, 2, 25, 59, 444, DateTimeKind.Unspecified).AddTicks(635), new TimeSpan(0, 7, 0, 0, 0)), "Port Dashawn" },
                    { 24, 42, new DateTimeOffset(new DateTime(2020, 6, 26, 5, 5, 27, 517, DateTimeKind.Unspecified).AddTicks(3764), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 27, 10, 29, 24, 579, DateTimeKind.Unspecified).AddTicks(2079), new TimeSpan(0, 7, 0, 0, 0)), "North Nicolafurt" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 25, 28, new DateTimeOffset(new DateTime(2020, 4, 16, 16, 37, 14, 265, DateTimeKind.Unspecified).AddTicks(5460), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 10, 8, 37, 12, 680, DateTimeKind.Unspecified).AddTicks(1728), new TimeSpan(0, 7, 0, 0, 0)), "West Sammy" },
                    { 26, 20, new DateTimeOffset(new DateTime(2020, 4, 22, 7, 40, 1, 142, DateTimeKind.Unspecified).AddTicks(8395), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 25, 18, 3, 40, 322, DateTimeKind.Unspecified).AddTicks(1102), new TimeSpan(0, 7, 0, 0, 0)), "East Adela" },
                    { 27, 15, new DateTimeOffset(new DateTime(2020, 4, 11, 16, 24, 31, 394, DateTimeKind.Unspecified).AddTicks(8093), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 31, 22, 40, 32, 707, DateTimeKind.Unspecified).AddTicks(1272), new TimeSpan(0, 7, 0, 0, 0)), "Fadelmouth" },
                    { 28, 17, new DateTimeOffset(new DateTime(2020, 4, 18, 14, 47, 43, 613, DateTimeKind.Unspecified).AddTicks(5945), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 6, 26, 3, 56, 4, 181, DateTimeKind.Unspecified).AddTicks(3568), new TimeSpan(0, 7, 0, 0, 0)), "West Noeliamouth" },
                    { 29, 7, new DateTimeOffset(new DateTime(2020, 11, 14, 22, 4, 26, 740, DateTimeKind.Unspecified).AddTicks(7614), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 29, 16, 59, 47, 928, DateTimeKind.Unspecified).AddTicks(4920), new TimeSpan(0, 7, 0, 0, 0)), "West Chelsie" },
                    { 30, 28, new DateTimeOffset(new DateTime(2020, 3, 13, 19, 58, 27, 22, DateTimeKind.Unspecified).AddTicks(4382), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 8, 1, 24, 49, 712, DateTimeKind.Unspecified).AddTicks(1259), new TimeSpan(0, 7, 0, 0, 0)), "Felicitafort" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 31, 50, new DateTimeOffset(new DateTime(2020, 12, 15, 7, 7, 39, 460, DateTimeKind.Unspecified).AddTicks(3107), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 3, 22, 23, 16, 1, 633, DateTimeKind.Unspecified).AddTicks(7019), new TimeSpan(0, 7, 0, 0, 0)), "DuBuqueside" },
                    { 32, 27, new DateTimeOffset(new DateTime(2020, 11, 14, 2, 51, 15, 357, DateTimeKind.Unspecified).AddTicks(1856), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 10, 12, 6, 44, 36, 651, DateTimeKind.Unspecified).AddTicks(734), new TimeSpan(0, 7, 0, 0, 0)), "Schimmelhaven" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 33, 49, new DateTimeOffset(new DateTime(2020, 6, 20, 18, 3, 17, 130, DateTimeKind.Unspecified).AddTicks(2827), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 10, 23, 15, 48, 6, DateTimeKind.Unspecified).AddTicks(5378), new TimeSpan(0, 7, 0, 0, 0)), "East Joyceberg" },
                    { 34, 33, new DateTimeOffset(new DateTime(2020, 8, 6, 0, 38, 9, 279, DateTimeKind.Unspecified).AddTicks(7183), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 9, 28, 7, 53, 42, 511, DateTimeKind.Unspecified).AddTicks(3480), new TimeSpan(0, 7, 0, 0, 0)), "Waldochester" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 35, 22, new DateTimeOffset(new DateTime(2020, 4, 24, 10, 39, 2, 675, DateTimeKind.Unspecified).AddTicks(5696), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 10, 3, 10, 18, 5, 858, DateTimeKind.Unspecified).AddTicks(9703), new TimeSpan(0, 7, 0, 0, 0)), "Hillltown" },
                    { 36, 28, new DateTimeOffset(new DateTime(2020, 5, 14, 3, 12, 33, 783, DateTimeKind.Unspecified).AddTicks(19), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 5, 25, 23, 20, 49, 11, DateTimeKind.Unspecified).AddTicks(1012), new TimeSpan(0, 7, 0, 0, 0)), "Madysonmouth" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[] { 37, 29, new DateTimeOffset(new DateTime(2020, 4, 12, 16, 32, 10, 830, DateTimeKind.Unspecified).AddTicks(564), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 6, 3, 8, 46, 37, 837, DateTimeKind.Unspecified).AddTicks(3973), new TimeSpan(0, 7, 0, 0, 0)), "Port Sandy" });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 38, 10, new DateTimeOffset(new DateTime(2020, 7, 2, 16, 6, 46, 253, DateTimeKind.Unspecified).AddTicks(505), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 12, 16, 1, 50, 166, DateTimeKind.Unspecified).AddTicks(222), new TimeSpan(0, 7, 0, 0, 0)), "South Israel" },
                    { 39, 35, new DateTimeOffset(new DateTime(2020, 1, 9, 22, 48, 48, 21, DateTimeKind.Unspecified).AddTicks(6003), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 1, 13, 17, 20, 7, 146, DateTimeKind.Unspecified).AddTicks(8644), new TimeSpan(0, 7, 0, 0, 0)), "Hermanbury" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[] { 40, 45, new DateTimeOffset(new DateTime(2020, 1, 27, 16, 55, 50, 381, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 6, 22, 7, 33, 11, 275, DateTimeKind.Unspecified).AddTicks(6197), new TimeSpan(0, 7, 0, 0, 0)), "North Kaci" });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 41, 28, new DateTimeOffset(new DateTime(2020, 6, 17, 23, 54, 58, 995, DateTimeKind.Unspecified).AddTicks(4366), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 7, 7, 13, 11, 57, 707, DateTimeKind.Unspecified).AddTicks(2001), new TimeSpan(0, 7, 0, 0, 0)), "Kunzeside" },
                    { 42, 9, new DateTimeOffset(new DateTime(2020, 4, 26, 23, 7, 4, 673, DateTimeKind.Unspecified).AddTicks(9507), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 26, 0, 59, 44, 247, DateTimeKind.Unspecified).AddTicks(663), new TimeSpan(0, 7, 0, 0, 0)), "Shanahanchester" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 43, 30, new DateTimeOffset(new DateTime(2020, 10, 22, 18, 16, 15, 692, DateTimeKind.Unspecified).AddTicks(9480), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 12, 9, 55, 20, 6, DateTimeKind.Unspecified).AddTicks(2292), new TimeSpan(0, 7, 0, 0, 0)), "Lynchville" },
                    { 44, 35, new DateTimeOffset(new DateTime(2020, 5, 13, 6, 0, 41, 864, DateTimeKind.Unspecified).AddTicks(2368), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 12, 20, 12, 26, 24, 637, DateTimeKind.Unspecified).AddTicks(7343), new TimeSpan(0, 7, 0, 0, 0)), "West Mae" },
                    { 45, 43, new DateTimeOffset(new DateTime(2020, 12, 13, 1, 13, 26, 561, DateTimeKind.Unspecified).AddTicks(7776), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 1, 9, 51, 56, 591, DateTimeKind.Unspecified).AddTicks(6817), new TimeSpan(0, 7, 0, 0, 0)), "Harveyfort" },
                    { 46, 22, new DateTimeOffset(new DateTime(2020, 10, 12, 11, 17, 55, 968, DateTimeKind.Unspecified).AddTicks(5274), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 6, 26, 20, 48, 52, 824, DateTimeKind.Unspecified).AddTicks(8567), new TimeSpan(0, 7, 0, 0, 0)), "South Vicentemouth" },
                    { 47, 27, new DateTimeOffset(new DateTime(2020, 10, 31, 8, 24, 2, 344, DateTimeKind.Unspecified).AddTicks(9299), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 9, 10, 11, 40, 2, 824, DateTimeKind.Unspecified).AddTicks(6583), new TimeSpan(0, 7, 0, 0, 0)), "Eleazarshire" },
                    { 48, 29, new DateTimeOffset(new DateTime(2020, 4, 23, 18, 37, 12, 850, DateTimeKind.Unspecified).AddTicks(7244), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 23, 4, 13, 30, 572, DateTimeKind.Unspecified).AddTicks(7043), new TimeSpan(0, 7, 0, 0, 0)), "Lake Giovanna" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 49, 7, new DateTimeOffset(new DateTime(2020, 9, 4, 11, 12, 42, 393, DateTimeKind.Unspecified).AddTicks(1), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 11, 25, 14, 35, 46, 305, DateTimeKind.Unspecified).AddTicks(7569), new TimeSpan(0, 7, 0, 0, 0)), "Port Jacebury" },
                    { 50, 45, new DateTimeOffset(new DateTime(2020, 11, 6, 12, 35, 15, 882, DateTimeKind.Unspecified).AddTicks(9721), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 4, 7, 14, 17, 44, 211, DateTimeKind.Unspecified).AddTicks(6056), new TimeSpan(0, 7, 0, 0, 0)), "Ahmadstad" }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("0804decd-7b5c-9799-690f-47fb03e9ce3b"), 525.22m, new DateTimeOffset(new DateTime(2020, 7, 10, 3, 49, 13, 370, DateTimeKind.Unspecified).AddTicks(9516), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 7, 18, 11, 18, 178, DateTimeKind.Unspecified).AddTicks(1665), new TimeSpan(0, 7, 0, 0, 0)), "Money Market Account", new Guid("660c4f13-ac34-972b-b671-5e720dd466c3") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c512bfb-868e-3e86-eded-bd69d81343e6"), 650.35m, new DateTimeOffset(new DateTime(2020, 6, 27, 5, 56, 4, 915, DateTimeKind.Unspecified).AddTicks(7087), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 11, 19, 59, 13, 581, DateTimeKind.Unspecified).AddTicks(3488), new TimeSpan(0, 7, 0, 0, 0)), "Checking Account", new Guid("07f55f54-53db-bc35-fdb4-1e717d9a0efb") },
                    { new Guid("14fad5ce-ef8b-2f7b-a2d9-96de815383b1"), 786.33m, new DateTimeOffset(new DateTime(2020, 8, 23, 11, 12, 17, 756, DateTimeKind.Unspecified).AddTicks(788), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 12, 5, 3, 15, 40, 794, DateTimeKind.Unspecified).AddTicks(8623), new TimeSpan(0, 7, 0, 0, 0)), "Money Market Account", new Guid("a70e2abe-63c2-d3ef-4c81-3e6c0feb02be") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("1cc2cfcb-de45-52b6-90a9-53a9fb007f94"), 515.65m, new DateTimeOffset(new DateTime(2020, 8, 15, 16, 19, 14, 535, DateTimeKind.Unspecified).AddTicks(6950), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 3, 25, 16, 21, 48, 34, DateTimeKind.Unspecified).AddTicks(8826), new TimeSpan(0, 7, 0, 0, 0)), "Savings Account", new Guid("18d34369-a53b-032e-483f-3773c3e7b578") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("1f41cd8d-072c-b793-df38-5c9a4619abd6"), 661.13m, new DateTimeOffset(new DateTime(2020, 9, 9, 15, 14, 43, 740, DateTimeKind.Unspecified).AddTicks(9573), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 3, 18, 19, 2, 30, 659, DateTimeKind.Unspecified).AddTicks(5111), new TimeSpan(0, 7, 0, 0, 0)), "Savings Account", new Guid("cf08e502-8911-c595-40a7-61187ed55224") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("2495c693-e3b9-7c6f-3898-b7dd200bc116"), 731.59m, new DateTimeOffset(new DateTime(2020, 11, 29, 10, 12, 37, 137, DateTimeKind.Unspecified).AddTicks(6391), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 1, 18, 0, 40, 732, DateTimeKind.Unspecified).AddTicks(7403), new TimeSpan(0, 7, 0, 0, 0)), "Auto Loan Account", new Guid("3ec9b182-31fc-749c-dd38-f3bcb0dede4d") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("2b65bc72-52ae-5087-1db8-b47d7fa37ad2"), 346.96m, new DateTimeOffset(new DateTime(2020, 6, 19, 20, 46, 30, 233, DateTimeKind.Unspecified).AddTicks(7572), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 30, 14, 58, 39, 305, DateTimeKind.Unspecified).AddTicks(7133), new TimeSpan(0, 7, 0, 0, 0)), "Personal Loan Accoun", new Guid("7f5038db-db10-9886-e48c-3e1f519a4cfc") },
                    { new Guid("2cc304c0-f65d-fe35-7c8d-3740a4699010"), 548.64m, new DateTimeOffset(new DateTime(2020, 4, 1, 17, 14, 16, 94, DateTimeKind.Unspecified).AddTicks(7752), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 12, 31, 6, 7, 25, 223, DateTimeKind.Unspecified).AddTicks(8677), new TimeSpan(0, 7, 0, 0, 0)), "Personal Loan Accoun", new Guid("3ece3fb3-867d-a0ec-c08c-c4d7a942e500") },
                    { new Guid("2d49430d-4e90-f11b-51a9-34225bb3f424"), 189.96m, new DateTimeOffset(new DateTime(2020, 10, 22, 18, 16, 15, 692, DateTimeKind.Unspecified).AddTicks(9480), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 12, 9, 55, 20, 6, DateTimeKind.Unspecified).AddTicks(2292), new TimeSpan(0, 7, 0, 0, 0)), "Home Loan Account", new Guid("88c74234-830e-5eb8-783e-185b933787f0") },
                    { new Guid("2e768de9-5437-4cd3-f08b-d2e2e7d40211"), 642.55m, new DateTimeOffset(new DateTime(2020, 12, 8, 10, 58, 47, 193, DateTimeKind.Unspecified).AddTicks(7078), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 3, 28, 19, 1, 11, 310, DateTimeKind.Unspecified).AddTicks(8367), new TimeSpan(0, 7, 0, 0, 0)), "Checking Account", new Guid("958622b0-9ce3-bd80-11a2-342663de9bee") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("2f96af49-0c5f-aae2-4230-9edddf13c915"), 312.48m, new DateTimeOffset(new DateTime(2020, 2, 22, 2, 18, 31, 0, DateTimeKind.Unspecified).AddTicks(7504), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 2, 1, 36, 47, 105, DateTimeKind.Unspecified).AddTicks(9820), new TimeSpan(0, 7, 0, 0, 0)), "Personal Loan Accoun", new Guid("09157063-f7b9-3de0-5999-e058bfd294d2") },
                    { new Guid("35498364-2209-f8c2-b165-9599800ff98b"), 264.98m, new DateTimeOffset(new DateTime(2020, 5, 17, 12, 46, 38, 960, DateTimeKind.Unspecified).AddTicks(2169), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 9, 14, 22, 27, 25, 210, DateTimeKind.Unspecified).AddTicks(5735), new TimeSpan(0, 7, 0, 0, 0)), "Money Market Account", new Guid("61674358-aa9b-9f64-d9f7-8f1a58970f78") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("39fa5661-2eba-2269-1baa-fed1aa195356"), 626.68m, new DateTimeOffset(new DateTime(2020, 8, 21, 10, 21, 42, 208, DateTimeKind.Unspecified).AddTicks(1087), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 12, 18, 2, 52, 25, 812, DateTimeKind.Unspecified).AddTicks(1646), new TimeSpan(0, 7, 0, 0, 0)), "Auto Loan Account", new Guid("6452ec5b-59d8-7ce6-64aa-80f861750375") },
                    { new Guid("3f5dfa6f-bbef-f955-f750-e56dce5a4d97"), 139.35m, new DateTimeOffset(new DateTime(2020, 3, 22, 8, 53, 34, 255, DateTimeKind.Unspecified).AddTicks(9394), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 21, 8, 31, 42, 675, DateTimeKind.Unspecified).AddTicks(8069), new TimeSpan(0, 7, 0, 0, 0)), "Personal Loan Accoun", new Guid("97eb2ed4-df10-55bd-d364-a3db4a109f23") },
                    { new Guid("3f6d13d5-a7c2-18f5-e07e-9b5202b062f6"), 749.98m, new DateTimeOffset(new DateTime(2020, 12, 22, 4, 46, 57, 111, DateTimeKind.Unspecified).AddTicks(8518), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 4, 17, 1, 57, 19, 303, DateTimeKind.Unspecified).AddTicks(5638), new TimeSpan(0, 7, 0, 0, 0)), "Home Loan Account", new Guid("1b95837c-302e-82d9-d3e3-5c19fca249af") },
                    { new Guid("3f9f750c-38ab-aaa4-4eb4-7f55421996b8"), 139.90m, new DateTimeOffset(new DateTime(2020, 12, 2, 7, 59, 45, 228, DateTimeKind.Unspecified).AddTicks(5519), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 4, 14, 1, 24, 6, 981, DateTimeKind.Unspecified).AddTicks(1165), new TimeSpan(0, 7, 0, 0, 0)), "Credit Card Account", new Guid("f3dcdac7-43a2-0adf-530c-9653f4b2c78d") },
                    { new Guid("4042cc3e-fa91-d7da-ff35-8d04ae36c7ca"), 714.22m, new DateTimeOffset(new DateTime(2020, 7, 15, 20, 22, 7, 462, DateTimeKind.Unspecified).AddTicks(1292), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 20, 7, 29, 16, 338, DateTimeKind.Unspecified).AddTicks(9740), new TimeSpan(0, 7, 0, 0, 0)), "Credit Card Account", new Guid("fb7425eb-5298-bbd0-7d77-413ff692b4dc") },
                    { new Guid("53256548-ecd7-7437-d8f5-f4529d9bde35"), 525.67m, new DateTimeOffset(new DateTime(2020, 1, 16, 19, 32, 49, 382, DateTimeKind.Unspecified).AddTicks(1356), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 6, 20, 3, 5, 37, 566, DateTimeKind.Unspecified).AddTicks(2692), new TimeSpan(0, 7, 0, 0, 0)), "Checking Account", new Guid("9c3b8b80-ec77-0d7d-387e-ebec94e998eb") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("5fac0bab-9b1e-2b3f-cd52-f09e51d49ea8"), 530.62m, new DateTimeOffset(new DateTime(2020, 10, 16, 1, 26, 33, 383, DateTimeKind.Unspecified).AddTicks(181), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 1, 28, 1, 31, 35, 878, DateTimeKind.Unspecified).AddTicks(3399), new TimeSpan(0, 7, 0, 0, 0)), "Credit Card Account", new Guid("2096d739-97f1-5726-27cd-ede8d3504da0") },
                    { new Guid("602b2f40-79ee-53b4-e390-36dfc79c1897"), 142.24m, new DateTimeOffset(new DateTime(2020, 5, 7, 3, 56, 42, 922, DateTimeKind.Unspecified).AddTicks(5669), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 6, 26, 11, 55, 44, 937, DateTimeKind.Unspecified).AddTicks(301), new TimeSpan(0, 7, 0, 0, 0)), "Personal Loan Accoun", new Guid("2667404a-245a-3ccc-8b84-6bcf135effe7") },
                    { new Guid("69680ceb-a2ec-41e6-f64f-828aa45d905a"), 498.20m, new DateTimeOffset(new DateTime(2020, 10, 10, 21, 35, 54, 200, DateTimeKind.Unspecified).AddTicks(5826), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 11, 7, 21, 56, 17, 780, DateTimeKind.Unspecified).AddTicks(5085), new TimeSpan(0, 7, 0, 0, 0)), "Auto Loan Account", new Guid("1c32f657-87c5-33dc-2dda-a177a4571d84") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("6e2aad91-6981-9dd6-496e-5763a37c45fb"), 700.43m, new DateTimeOffset(new DateTime(2020, 2, 21, 23, 49, 53, 209, DateTimeKind.Unspecified).AddTicks(8892), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 11, 14, 5, 0, 996, DateTimeKind.Unspecified).AddTicks(306), new TimeSpan(0, 7, 0, 0, 0)), "Savings Account", new Guid("fa1681fd-093d-667e-c5fd-012c2fc33394") },
                    { new Guid("72d6a72b-0a05-898f-22cd-5b94c9155554"), 335.15m, new DateTimeOffset(new DateTime(2020, 1, 1, 19, 13, 11, 383, DateTimeKind.Unspecified).AddTicks(5758), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 18, 10, 15, 11, 277, DateTimeKind.Unspecified).AddTicks(4186), new TimeSpan(0, 7, 0, 0, 0)), "Investment Account", new Guid("1233f8f5-32db-7367-7ee3-dac050c8d597") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("754ae7f5-0365-4af8-7c83-951b2e30d982"), 521.95m, new DateTimeOffset(new DateTime(2020, 3, 9, 14, 43, 4, 588, DateTimeKind.Unspecified).AddTicks(3527), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 5, 14, 12, 5, 5, 564, DateTimeKind.Unspecified).AddTicks(3254), new TimeSpan(0, 7, 0, 0, 0)), "Money Market Account", new Guid("b35b2234-24f4-2054-ad1a-71ce513a15ab") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("89504ad9-0785-2b68-0d58-8f71c7d88de8"), 959.23m, new DateTimeOffset(new DateTime(2020, 4, 20, 7, 30, 2, 415, DateTimeKind.Unspecified).AddTicks(6905), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 11, 1, 19, 31, 329, DateTimeKind.Unspecified).AddTicks(9863), new TimeSpan(0, 7, 0, 0, 0)), "Money Market Account", new Guid("f4e4bdec-d0c1-62a7-fb99-0355c25a4a9d") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("8c223896-e751-0945-eb80-f68b20142b12"), 199.13m, new DateTimeOffset(new DateTime(2020, 2, 12, 17, 24, 44, 840, DateTimeKind.Unspecified).AddTicks(7113), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 2, 11, 19, 53, 21, 949, DateTimeKind.Unspecified).AddTicks(1782), new TimeSpan(0, 7, 0, 0, 0)), "Money Market Account", new Guid("31c8786a-f2fa-ab7a-0bac-5f1e9b3f2bcd") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"), 892.58m, new DateTimeOffset(new DateTime(2020, 5, 15, 21, 53, 38, 112, DateTimeKind.Unspecified).AddTicks(1731), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 12, 25, 15, 7, 47, 655, DateTimeKind.Unspecified).AddTicks(3846), new TimeSpan(0, 7, 0, 0, 0)), "Savings Account", new Guid("1d16222e-1f0e-1a0c-5815-5e539e98ce71") },
                    { new Guid("9225cd84-cc3f-197a-0d9b-61826df2719f"), 281.91m, new DateTimeOffset(new DateTime(2020, 7, 27, 11, 15, 33, 143, DateTimeKind.Unspecified).AddTicks(1905), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 3, 12, 43, 52, 682, DateTimeKind.Unspecified).AddTicks(7039), new TimeSpan(0, 7, 0, 0, 0)), "Home Loan Account", new Guid("7c844000-8c04-39ea-0259-b55207b2c092") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("9433c32f-2762-2724-ce13-3348d2a829fd"), 645.53m, new DateTimeOffset(new DateTime(2020, 9, 24, 19, 33, 12, 457, DateTimeKind.Unspecified).AddTicks(6893), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 9, 18, 21, 20, 53, 901, DateTimeKind.Unspecified).AddTicks(2209), new TimeSpan(0, 7, 0, 0, 0)), "Money Market Account", new Guid("f29a2a8e-4d8b-a1cd-8c19-b674b6ff66b4") },
                    { new Guid("9528cd4e-80df-ffff-977f-ca08f6548f59"), 866.85m, new DateTimeOffset(new DateTime(2020, 5, 12, 6, 2, 28, 264, DateTimeKind.Unspecified).AddTicks(4242), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 2, 25, 11, 1, 34, 119, DateTimeKind.Unspecified).AddTicks(7386), new TimeSpan(0, 7, 0, 0, 0)), "Credit Card Account", new Guid("2aad91df-816e-d669-9d49-6e5763a37c45") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("a740c595-1861-d57e-5224-f6098c56f3f8"), 990.24m, new DateTimeOffset(new DateTime(2020, 1, 17, 11, 42, 52, 284, DateTimeKind.Unspecified).AddTicks(5721), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 17, 18, 45, 58, 301, DateTimeKind.Unspecified).AddTicks(2240), new TimeSpan(0, 7, 0, 0, 0)), "Home Loan Account", new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f") },
                    { new Guid("ab153a51-6d1e-d275-65d3-3d5c153a9787"), 525.45m, new DateTimeOffset(new DateTime(2020, 4, 24, 14, 31, 53, 904, DateTimeKind.Unspecified).AddTicks(3217), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 9, 14, 23, 41, 43, 347, DateTimeKind.Unspecified).AddTicks(6497), new TimeSpan(0, 7, 0, 0, 0)), "Credit Card Account", new Guid("60e01340-3a21-225b-1cfd-f38583c3b73c") },
                    { new Guid("ac34660c-972b-71b6-5e72-0dd466c34f8b"), 850.06m, new DateTimeOffset(new DateTime(2020, 8, 7, 11, 50, 46, 224, DateTimeKind.Unspecified).AddTicks(1058), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 23, 2, 11, 18, 45, DateTimeKind.Unspecified).AddTicks(3838), new TimeSpan(0, 7, 0, 0, 0)), "Personal Loan Accoun", new Guid("3140208e-efb5-0baa-5dcf-f3688dfb49d4") },
                    { new Guid("ad322849-cf01-9ec7-2cd4-a1fd8116fa3d"), 319.55m, new DateTimeOffset(new DateTime(2020, 12, 13, 9, 11, 54, 471, DateTimeKind.Unspecified).AddTicks(2558), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 21, 0, 27, 49, 307, DateTimeKind.Unspecified).AddTicks(1403), new TimeSpan(0, 7, 0, 0, 0)), "Checking Account", new Guid("883f6641-68e4-d729-affb-e4c4535dc8e2") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("b05d30e7-c2f8-4c2f-7d7e-0b670a682b5a"), 893.17m, new DateTimeOffset(new DateTime(2020, 6, 20, 3, 37, 10, 404, DateTimeKind.Unspecified).AddTicks(418), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 7, 31, 9, 48, 1, 360, DateTimeKind.Unspecified).AddTicks(5294), new TimeSpan(0, 7, 0, 0, 0)), "Checking Account", new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("b08b3ca5-2236-4358-6761-9baa649fd9f7"), 71.36m, new DateTimeOffset(new DateTime(2020, 7, 25, 18, 12, 56, 262, DateTimeKind.Unspecified).AddTicks(39), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 26, 0, 27, 59, 557, DateTimeKind.Unspecified).AddTicks(9799), new TimeSpan(0, 7, 0, 0, 0)), "Investment Account", new Guid("89b78bdb-be24-151c-31f7-e7421644e19f") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("b43e0475-76b4-6bbc-f7a7-1f4c4773aee3"), 179.82m, new DateTimeOffset(new DateTime(2020, 2, 10, 1, 48, 33, 699, DateTimeKind.Unspecified).AddTicks(4541), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 9, 8, 9, 39, 18, 144, DateTimeKind.Unspecified).AddTicks(9000), new TimeSpan(0, 7, 0, 0, 0)), "Personal Loan Accoun", new Guid("333a1cdf-9180-489a-54b3-b6f44bf638e2") },
                    { new Guid("b651c657-6dc2-86f7-a83c-e64680ed8168"), 50.35m, new DateTimeOffset(new DateTime(2020, 9, 11, 5, 47, 6, 910, DateTimeKind.Unspecified).AddTicks(4995), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 2, 4, 2, 42, 30, 340, DateTimeKind.Unspecified).AddTicks(4394), new TimeSpan(0, 7, 0, 0, 0)), "Personal Loan Accoun", new Guid("4571167a-fb5e-362b-9985-3d5adc0468ba") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("c550507d-bdb9-e558-e1a4-45366631090c"), 127.93m, new DateTimeOffset(new DateTime(2020, 10, 7, 12, 3, 32, 557, DateTimeKind.Unspecified).AddTicks(1453), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 7, 10, 58, 11, 326, DateTimeKind.Unspecified).AddTicks(4310), new TimeSpan(0, 7, 0, 0, 0)), "Home Loan Account", new Guid("26a67ecd-6180-8d3b-fd52-41408b6939c3") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("c57fd8b3-7dcc-83e2-69aa-a4108d4d026f"), 13.45m, new DateTimeOffset(new DateTime(2020, 11, 18, 22, 4, 24, 934, DateTimeKind.Unspecified).AddTicks(9374), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 6, 15, 8, 46, 13, 586, DateTimeKind.Unspecified).AddTicks(2313), new TimeSpan(0, 7, 0, 0, 0)), "Money Market Account", new Guid("609afabf-efdb-fb3f-7207-2583625812b2") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("d3626795-436d-1e59-c672-055d47c2ed18"), 748.46m, new DateTimeOffset(new DateTime(2020, 2, 11, 9, 28, 0, 386, DateTimeKind.Unspecified).AddTicks(3550), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 4, 21, 2, 53, 57, 178, DateTimeKind.Unspecified).AddTicks(2754), new TimeSpan(0, 7, 0, 0, 0)), "Savings Account", new Guid("059f0b6a-1940-021d-901e-108a95bc55cb") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("d405fcc9-5e97-d8d3-499f-7ce08d1783e3"), 782.81m, new DateTimeOffset(new DateTime(2020, 4, 5, 14, 28, 56, 88, DateTimeKind.Unspecified).AddTicks(7904), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 10, 29, 5, 57, 43, 860, DateTimeKind.Unspecified).AddTicks(3340), new TimeSpan(0, 7, 0, 0, 0)), "Personal Loan Accoun", new Guid("f046ac78-05d2-c7c1-40ea-bf733a9492ed") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("d86ef2ce-8d84-bd04-6676-0f9121b162c9"), 325.58m, new DateTimeOffset(new DateTime(2020, 10, 7, 0, 8, 12, 512, DateTimeKind.Unspecified).AddTicks(5571), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 8, 9, 6, 59, 37, 33, DateTimeKind.Unspecified).AddTicks(3154), new TimeSpan(0, 7, 0, 0, 0)), "Money Market Account", new Guid("6833ed3a-236f-0ee7-896b-1c4a69d03e78") },
                    { new Guid("e07e234c-6fb5-08dc-5b8c-438fffa9361b"), 125.53m, new DateTimeOffset(new DateTime(2020, 6, 19, 20, 5, 33, 975, DateTimeKind.Unspecified).AddTicks(5038), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 27, 16, 55, 50, 381, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 7, 0, 0, 0)), "Home Loan Account", new Guid("4c126f9a-33e0-75c9-f02b-a2757bdecca9") },
                    { new Guid("e189d5ab-c58e-c880-8b39-bc2da6528da9"), 874.66m, new DateTimeOffset(new DateTime(2020, 10, 22, 12, 13, 20, 806, DateTimeKind.Unspecified).AddTicks(3387), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 2, 20, 8, 51, 675, DateTimeKind.Unspecified).AddTicks(6989), new TimeSpan(0, 7, 0, 0, 0)), "Investment Account", new Guid("335ac148-c512-5b69-ffda-43761a02659d") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("e6a9f246-6c93-6962-33ef-855ab90a53b0"), 41.48m, new DateTimeOffset(new DateTime(2020, 9, 23, 14, 5, 17, 780, DateTimeKind.Unspecified).AddTicks(6107), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 9, 26, 15, 36, 7, 580, DateTimeKind.Unspecified).AddTicks(5040), new TimeSpan(0, 7, 0, 0, 0)), "Money Market Account", new Guid("88df2f3a-6795-d362-6d43-591ec672055d") },
                    { new Guid("edef5f70-0e2c-dcad-74db-7688646ffd2d"), 92.96m, new DateTimeOffset(new DateTime(2020, 9, 22, 18, 47, 21, 152, DateTimeKind.Unspecified).AddTicks(7159), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 22, 12, 6, 44, 103, DateTimeKind.Unspecified).AddTicks(5617), new TimeSpan(0, 7, 0, 0, 0)), "Savings Account", new Guid("6f110748-4060-7943-3d81-f85d8b09c12c") },
                    { new Guid("f694ea54-f527-eed5-e010-5eca808b3b9c"), 41.27m, new DateTimeOffset(new DateTime(2020, 10, 22, 14, 51, 18, 56, DateTimeKind.Unspecified).AddTicks(5675), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 12, 10, 55, 37, 787, DateTimeKind.Unspecified).AddTicks(2114), new TimeSpan(0, 7, 0, 0, 0)), "Auto Loan Account", new Guid("78f7dc5f-0278-90bd-523a-268de4bc0e49") },
                    { new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"), 780.24m, new DateTimeOffset(new DateTime(2020, 12, 1, 17, 19, 15, 553, DateTimeKind.Unspecified).AddTicks(9436), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 10, 29, 11, 45, 11, 493, DateTimeKind.Unspecified).AddTicks(708), new TimeSpan(0, 7, 0, 0, 0)), "Investment Account", new Guid("4e7220ff-01af-050f-260e-566ab34b8a58") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("fc468bcc-b19c-0a0a-a2dc-4995e1e478b1"), 778.11m, new DateTimeOffset(new DateTime(2020, 9, 11, 1, 16, 16, 760, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 9, 10, 50, 29, 169, DateTimeKind.Unspecified).AddTicks(6939), new TimeSpan(0, 7, 0, 0, 0)), "Home Loan Account", new Guid("cce0516f-9f9f-f24f-f163-d6b684ab1f52") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("06109627-6508-6080-35ad-238abbb04a8e"), 711.17m, new DateTimeOffset(new DateTime(2020, 4, 17, 18, 48, 56, 764, DateTimeKind.Unspecified).AddTicks(8306), new TimeSpan(0, 7, 0, 0, 0)), "Non voluptatem nam.", true, new DateTimeOffset(new DateTime(2020, 6, 4, 12, 44, 51, 393, DateTimeKind.Unspecified).AddTicks(8721), new TimeSpan(0, 7, 0, 0, 0)), "adipisci", new Guid("cf08e502-8911-c595-40a7-61187ed55224"), new Guid("8c223896-e751-0945-eb80-f68b20142b12") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("0ae18c23-5a4e-0f8e-e3c1-25f2744b08ab"), 659.33m, new DateTimeOffset(new DateTime(2020, 4, 20, 1, 46, 59, 676, DateTimeKind.Unspecified).AddTicks(8701), new TimeSpan(0, 7, 0, 0, 0)), "Dolor ut eum consequuntur nam voluptatem.", new DateTimeOffset(new DateTime(2020, 2, 25, 3, 15, 37, 511, DateTimeKind.Unspecified).AddTicks(1947), new TimeSpan(0, 7, 0, 0, 0)), "quam", new Guid("7f5038db-db10-9886-e48c-3e1f519a4cfc"), new Guid("b05d30e7-c2f8-4c2f-7d7e-0b670a682b5a") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("29a8d248-66fd-66c5-8262-26cdde04085c"), 628.74m, new DateTimeOffset(new DateTime(2020, 6, 22, 22, 37, 6, 953, DateTimeKind.Unspecified).AddTicks(9482), new TimeSpan(0, 7, 0, 0, 0)), "Iste ut consequatur veniam accusamus explicabo quia.", true, new DateTimeOffset(new DateTime(2020, 7, 10, 3, 49, 13, 370, DateTimeKind.Unspecified).AddTicks(9516), new TimeSpan(0, 7, 0, 0, 0)), "libero", new Guid("1d16222e-1f0e-1a0c-5815-5e539e98ce71"), new Guid("a740c595-1861-d57e-5224-f6098c56f3f8") },
                    { new Guid("2aad91df-816e-d669-9d49-6e5763a37c45"), 992.63m, new DateTimeOffset(new DateTime(2020, 6, 30, 21, 14, 10, 69, DateTimeKind.Unspecified).AddTicks(920), new TimeSpan(0, 7, 0, 0, 0)), "Cumque vero rerum illum.", true, new DateTimeOffset(new DateTime(2020, 1, 11, 7, 22, 31, 921, DateTimeKind.Unspecified).AddTicks(4933), new TimeSpan(0, 7, 0, 0, 0)), "mollitia", new Guid("a70e2abe-63c2-d3ef-4c81-3e6c0feb02be"), new Guid("3f5dfa6f-bbef-f955-f750-e56dce5a4d97") },
                    { new Guid("2b94bacd-417a-aaf6-249c-e7305db0f8c2"), 533.10m, new DateTimeOffset(new DateTime(2020, 6, 4, 17, 8, 9, 461, DateTimeKind.Unspecified).AddTicks(4790), new TimeSpan(0, 7, 0, 0, 0)), "Aut qui sint autem sit.", true, new DateTimeOffset(new DateTime(2020, 3, 21, 21, 45, 40, 911, DateTimeKind.Unspecified).AddTicks(6633), new TimeSpan(0, 7, 0, 0, 0)), "hic", new Guid("7c844000-8c04-39ea-0259-b55207b2c092"), new Guid("edef5f70-0e2c-dcad-74db-7688646ffd2d") }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("2f96af49-0c5f-aae2-4230-9edddf13c915"), 857.80m, new DateTimeOffset(new DateTime(2020, 10, 4, 8, 50, 59, 933, DateTimeKind.Unspecified).AddTicks(6221), new TimeSpan(0, 7, 0, 0, 0)), "Aut animi incidunt.", new DateTimeOffset(new DateTime(2020, 9, 6, 9, 3, 19, 740, DateTimeKind.Unspecified).AddTicks(5129), new TimeSpan(0, 7, 0, 0, 0)), "vitae", new Guid("09157063-f7b9-3de0-5999-e058bfd294d2"), new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("35f65d2c-7cfe-378d-40a4-6990103e9553"), 169.11m, new DateTimeOffset(new DateTime(2020, 6, 28, 17, 27, 34, 252, DateTimeKind.Unspecified).AddTicks(5063), new TimeSpan(0, 7, 0, 0, 0)), "Autem autem laborum nulla et asperiores officia sunt.", true, new DateTimeOffset(new DateTime(2020, 10, 5, 4, 9, 41, 591, DateTimeKind.Unspecified).AddTicks(5684), new TimeSpan(0, 7, 0, 0, 0)), "nulla", new Guid("f4e4bdec-d0c1-62a7-fb99-0355c25a4a9d"), new Guid("fc468bcc-b19c-0a0a-a2dc-4995e1e478b1") },
                    { new Guid("36b08b3c-5822-6743-619b-aa649fd9f78f"), 847.09m, new DateTimeOffset(new DateTime(2020, 9, 16, 14, 39, 44, 445, DateTimeKind.Unspecified).AddTicks(1211), new TimeSpan(0, 7, 0, 0, 0)), "Et nam placeat et corrupti.", true, new DateTimeOffset(new DateTime(2020, 4, 7, 19, 48, 40, 196, DateTimeKind.Unspecified).AddTicks(6126), new TimeSpan(0, 7, 0, 0, 0)), "repellendus", new Guid("b35b2234-24f4-2054-ad1a-71ce513a15ab"), new Guid("14fad5ce-ef8b-2f7b-a2d9-96de815383b1") },
                    { new Guid("3a6aed8d-5a99-4edd-8327-5c278eb6b17d"), 129.28m, new DateTimeOffset(new DateTime(2020, 4, 7, 14, 17, 44, 211, DateTimeKind.Unspecified).AddTicks(6056), new TimeSpan(0, 7, 0, 0, 0)), "Qui quam quia aspernatur quos saepe et sit laborum voluptatem.", true, new DateTimeOffset(new DateTime(2020, 12, 30, 17, 55, 58, 49, DateTimeKind.Unspecified).AddTicks(2201), new TimeSpan(0, 7, 0, 0, 0)), "labore", new Guid("059f0b6a-1940-021d-901e-108a95bc55cb"), new Guid("ac34660c-972b-71b6-5e72-0dd466c34f8b") },
                    { new Guid("3d5d14e4-3fcc-7089-9fe4-9d676b30922d"), 904.33m, new DateTimeOffset(new DateTime(2020, 8, 29, 15, 9, 14, 0, DateTimeKind.Unspecified).AddTicks(2794), new TimeSpan(0, 7, 0, 0, 0)), "Incidunt maiores ab.", true, new DateTimeOffset(new DateTime(2020, 10, 11, 8, 44, 55, 723, DateTimeKind.Unspecified).AddTicks(1251), new TimeSpan(0, 7, 0, 0, 0)), "quis", new Guid("2667404a-245a-3ccc-8b84-6bcf135effe7"), new Guid("53256548-ecd7-7437-d8f5-f4529d9bde35") }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("4206100c-318e-34ba-525e-7c82b1c93efc"), 646.03m, new DateTimeOffset(new DateTime(2020, 9, 24, 11, 3, 6, 762, DateTimeKind.Unspecified).AddTicks(7284), new TimeSpan(0, 7, 0, 0, 0)), "Distinctio voluptatibus vel ipsa ut.", new DateTimeOffset(new DateTime(2020, 11, 23, 5, 32, 4, 349, DateTimeKind.Unspecified).AddTicks(9953), new TimeSpan(0, 7, 0, 0, 0)), "neque", new Guid("4e7220ff-01af-050f-260e-566ab34b8a58"), new Guid("9528cd4e-80df-ffff-977f-ca08f6548f59") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("49d8d35e-7c9f-8de0-1783-e3bd52b59b65"), 330.13m, new DateTimeOffset(new DateTime(2020, 6, 20, 11, 8, 12, 390, DateTimeKind.Unspecified).AddTicks(389), new TimeSpan(0, 7, 0, 0, 0)), "Fugit assumenda eius non repellat.", true, new DateTimeOffset(new DateTime(2020, 6, 6, 5, 41, 18, 639, DateTimeKind.Unspecified).AddTicks(8879), new TimeSpan(0, 7, 0, 0, 0)), "maiores", new Guid("1c32f657-87c5-33dc-2dda-a177a4571d84"), new Guid("e07e234c-6fb5-08dc-5b8c-438fffa9361b") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("53c4e4fb-c85d-80e2-8ad9-652748a30f3c"), 202.26m, new DateTimeOffset(new DateTime(2020, 1, 31, 23, 20, 43, 293, DateTimeKind.Unspecified).AddTicks(6106), new TimeSpan(0, 7, 0, 0, 0)), "Nobis commodi voluptatibus amet quis laboriosam molestias facere.", new DateTimeOffset(new DateTime(2020, 12, 2, 20, 11, 19, 544, DateTimeKind.Unspecified).AddTicks(9834), new TimeSpan(0, 7, 0, 0, 0)), "eos", new Guid("cf08e502-8911-c595-40a7-61187ed55224"), new Guid("e189d5ab-c58e-c880-8b39-bc2da6528da9") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("5e9bf4a4-e003-baa5-4f70-00a7f0b154fd"), 213.94m, new DateTimeOffset(new DateTime(2020, 3, 7, 14, 16, 37, 541, DateTimeKind.Unspecified).AddTicks(3979), new TimeSpan(0, 7, 0, 0, 0)), "Qui totam commodi iusto fuga commodi eaque est asperiores.", true, new DateTimeOffset(new DateTime(2020, 6, 20, 8, 12, 9, 102, DateTimeKind.Unspecified).AddTicks(7311), new TimeSpan(0, 7, 0, 0, 0)), "voluptate", new Guid("333a1cdf-9180-489a-54b3-b6f44bf638e2"), new Guid("69680ceb-a2ec-41e6-f64f-828aa45d905a") },
                    { new Guid("61cb6c4e-d08c-e867-a5e9-d2d209173f4e"), 827.81m, new DateTimeOffset(new DateTime(2020, 2, 8, 7, 52, 2, 282, DateTimeKind.Unspecified).AddTicks(2798), new TimeSpan(0, 7, 0, 0, 0)), "Inventore praesentium dolor voluptates itaque.", true, new DateTimeOffset(new DateTime(2020, 6, 23, 18, 1, 11, 435, DateTimeKind.Unspecified).AddTicks(2493), new TimeSpan(0, 7, 0, 0, 0)), "perspiciatis", new Guid("4e7220ff-01af-050f-260e-566ab34b8a58"), new Guid("9433c32f-2762-2724-ce13-3348d2a829fd") },
                    { new Guid("69626c93-ef33-5a85-b90a-53b0f5a84781"), 556.49m, new DateTimeOffset(new DateTime(2020, 5, 28, 2, 14, 44, 345, DateTimeKind.Unspecified).AddTicks(3713), new TimeSpan(0, 7, 0, 0, 0)), "Nisi atque rerum dolorum architecto saepe.", true, new DateTimeOffset(new DateTime(2020, 7, 26, 18, 4, 23, 383, DateTimeKind.Unspecified).AddTicks(8763), new TimeSpan(0, 7, 0, 0, 0)), "sit", new Guid("1d16222e-1f0e-1a0c-5815-5e539e98ce71"), new Guid("2cc304c0-f65d-fe35-7c8d-3740a4699010") }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("6de550f7-5ace-974d-8476-ab3a2fdf8895"), 794.94m, new DateTimeOffset(new DateTime(2020, 11, 4, 3, 10, 26, 503, DateTimeKind.Unspecified).AddTicks(5474), new TimeSpan(0, 7, 0, 0, 0)), "Delectus impedit qui enim autem est ipsum molestias fugit.", new DateTimeOffset(new DateTime(2020, 2, 26, 7, 15, 36, 324, DateTimeKind.Unspecified).AddTicks(3106), new TimeSpan(0, 7, 0, 0, 0)), "et", new Guid("cf08e502-8911-c595-40a7-61187ed55224"), new Guid("c57fd8b3-7dcc-83e2-69aa-a4108d4d026f") },
                    { new Guid("71b6972b-725e-d40d-66c3-4f8b85031295"), 438.83m, new DateTimeOffset(new DateTime(2020, 1, 29, 16, 44, 3, 561, DateTimeKind.Unspecified).AddTicks(3346), new TimeSpan(0, 7, 0, 0, 0)), "Sit est a et deserunt sint architecto perspiciatis rerum.", new DateTimeOffset(new DateTime(2020, 8, 5, 17, 11, 24, 427, DateTimeKind.Unspecified).AddTicks(3900), new TimeSpan(0, 7, 0, 0, 0)), "tenetur", new Guid("60e01340-3a21-225b-1cfd-f38583c3b73c"), new Guid("d3626795-436d-1e59-c672-055d47c2ed18") }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("7feb6649-70fc-ef5f-ed2c-0eaddc74db76"), 375.80m, new DateTimeOffset(new DateTime(2020, 9, 22, 18, 47, 21, 152, DateTimeKind.Unspecified).AddTicks(7159), new TimeSpan(0, 7, 0, 0, 0)), "Perspiciatis repellat magni mollitia sunt.", true, new DateTimeOffset(new DateTime(2020, 12, 22, 12, 6, 44, 103, DateTimeKind.Unspecified).AddTicks(5617), new TimeSpan(0, 7, 0, 0, 0)), "repellat", new Guid("9c3b8b80-ec77-0d7d-387e-ebec94e998eb"), new Guid("9225cd84-cc3f-197a-0d9b-61826df2719f") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("8bf680eb-1420-122b-37d5-2d64d485abd5"), 775.09m, new DateTimeOffset(new DateTime(2020, 6, 20, 13, 18, 39, 4, DateTimeKind.Unspecified).AddTicks(6817), new TimeSpan(0, 7, 0, 0, 0)), "Ut rem ea distinctio omnis.", new DateTimeOffset(new DateTime(2020, 5, 30, 23, 36, 22, 165, DateTimeKind.Unspecified).AddTicks(5252), new TimeSpan(0, 7, 0, 0, 0)), "quisquam", new Guid("09157063-f7b9-3de0-5999-e058bfd294d2"), new Guid("fc468bcc-b19c-0a0a-a2dc-4995e1e478b1") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("914042cc-dafa-ffd7-358d-04ae36c7ca60"), 703.91m, new DateTimeOffset(new DateTime(2020, 11, 6, 17, 8, 49, 277, DateTimeKind.Unspecified).AddTicks(8392), new TimeSpan(0, 7, 0, 0, 0)), "Rerum porro accusantium aliquam velit quos.", true, new DateTimeOffset(new DateTime(2020, 2, 15, 22, 25, 49, 504, DateTimeKind.Unspecified).AddTicks(7156), new TimeSpan(0, 7, 0, 0, 0)), "quo", new Guid("059f0b6a-1940-021d-901e-108a95bc55cb"), new Guid("1f41cd8d-072c-b793-df38-5c9a4619abd6") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("93072c1f-dfb7-5c38-9a46-19abd61d8bdf"), 939.59m, new DateTimeOffset(new DateTime(2020, 2, 17, 13, 24, 59, 634, DateTimeKind.Unspecified).AddTicks(5223), new TimeSpan(0, 7, 0, 0, 0)), "Fugit et consectetur.", new DateTimeOffset(new DateTime(2020, 12, 19, 22, 37, 15, 310, DateTimeKind.Unspecified).AddTicks(2095), new TimeSpan(0, 7, 0, 0, 0)), "ipsam", new Guid("78f7dc5f-0278-90bd-523a-268de4bc0e49"), new Guid("69680ceb-a2ec-41e6-f64f-828aa45d905a") },
                    { new Guid("94ea5462-27f6-d5f5-eee0-105eca808b3b"), 347.79m, new DateTimeOffset(new DateTime(2020, 9, 10, 6, 4, 10, 978, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 7, 0, 0, 0)), "Velit temporibus ipsa consectetur illo laboriosam qui.", new DateTimeOffset(new DateTime(2020, 7, 19, 3, 21, 29, 954, DateTimeKind.Unspecified).AddTicks(8676), new TimeSpan(0, 7, 0, 0, 0)), "expedita", new Guid("f046ac78-05d2-c7c1-40ea-bf733a9492ed"), new Guid("9225cd84-cc3f-197a-0d9b-61826df2719f") },
                    { new Guid("953b298b-2d7e-d55f-136d-3fc2a7f518e0"), 204.56m, new DateTimeOffset(new DateTime(2020, 2, 27, 14, 46, 6, 449, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, 7, 0, 0, 0)), "Qui unde fugit placeat accusantium impedit.", new DateTimeOffset(new DateTime(2020, 4, 14, 14, 28, 36, 505, DateTimeKind.Unspecified).AddTicks(1912), new TimeSpan(0, 7, 0, 0, 0)), "vel", new Guid("88df2f3a-6795-d362-6d43-591ec672055d"), new Guid("b05d30e7-c2f8-4c2f-7d7e-0b670a682b5a") },
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), 731.59m, new DateTimeOffset(new DateTime(2020, 2, 8, 1, 56, 42, 864, DateTimeKind.Unspecified).AddTicks(7753), new TimeSpan(0, 7, 0, 0, 0)), "Laboriosam sit minus.", new DateTimeOffset(new DateTime(2020, 3, 9, 13, 40, 51, 467, DateTimeKind.Unspecified).AddTicks(5012), new TimeSpan(0, 7, 0, 0, 0)), "sunt", new Guid("fb7425eb-5298-bbd0-7d77-413ff692b4dc"), new Guid("72d6a72b-0a05-898f-22cd-5b94c9155554") }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("9a2771a7-4449-f54d-62d9-b0a724366a66"), 539.94m, new DateTimeOffset(new DateTime(2020, 10, 12, 10, 47, 18, 159, DateTimeKind.Unspecified).AddTicks(3036), new TimeSpan(0, 7, 0, 0, 0)), "Neque et libero fugit et dolores tempora quia molestias corrupti.", true, new DateTimeOffset(new DateTime(2020, 5, 13, 0, 24, 7, 623, DateTimeKind.Unspecified).AddTicks(7319), new TimeSpan(0, 7, 0, 0, 0)), "libero", new Guid("1d16222e-1f0e-1a0c-5815-5e539e98ce71"), new Guid("2cc304c0-f65d-fe35-7c8d-3740a4699010") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("9cfc468b-0ab1-a20a-dc49-95e1e478b199"), 740.44m, new DateTimeOffset(new DateTime(2020, 9, 11, 1, 16, 16, 760, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 7, 0, 0, 0)), "Earum cupiditate quasi eveniet tempore omnis.", new DateTimeOffset(new DateTime(2020, 7, 9, 10, 50, 29, 169, DateTimeKind.Unspecified).AddTicks(6939), new TimeSpan(0, 7, 0, 0, 0)), "corrupti", new Guid("f046ac78-05d2-c7c1-40ea-bf733a9492ed"), new Guid("3f9f750c-38ab-aaa4-4eb4-7f55421996b8") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("9ef052cd-d451-a89e-0515-b413c4587a03"), 463.38m, new DateTimeOffset(new DateTime(2020, 7, 27, 6, 25, 23, 35, DateTimeKind.Unspecified).AddTicks(811), new TimeSpan(0, 7, 0, 0, 0)), "Impedit animi iusto ad.", true, new DateTimeOffset(new DateTime(2020, 3, 4, 16, 13, 45, 498, DateTimeKind.Unspecified).AddTicks(911), new TimeSpan(0, 7, 0, 0, 0)), "id", new Guid("3ece3fb3-867d-a0ec-c08c-c4d7a942e500"), new Guid("1f41cd8d-072c-b793-df38-5c9a4619abd6") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("a2e64313-e8a4-bda0-6c2b-a7d672050a8f"), 555.27m, new DateTimeOffset(new DateTime(2020, 4, 12, 16, 32, 10, 830, DateTimeKind.Unspecified).AddTicks(564), new TimeSpan(0, 7, 0, 0, 0)), "Quod harum animi qui error suscipit repellat accusamus.", new DateTimeOffset(new DateTime(2020, 6, 3, 8, 46, 37, 837, DateTimeKind.Unspecified).AddTicks(3973), new TimeSpan(0, 7, 0, 0, 0)), "et", new Guid("3ece3fb3-867d-a0ec-c08c-c4d7a942e500"), new Guid("754ae7f5-0365-4af8-7c83-951b2e30d982") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("a9d7c48c-e542-6100-d98e-dd9402ebd05d"), 299.81m, new DateTimeOffset(new DateTime(2020, 12, 10, 9, 42, 50, 333, DateTimeKind.Unspecified).AddTicks(3690), new TimeSpan(0, 7, 0, 0, 0)), "Repellat quas molestiae itaque et doloremque incidunt nemo veritatis.", true, new DateTimeOffset(new DateTime(2020, 11, 13, 4, 40, 31, 274, DateTimeKind.Unspecified).AddTicks(1134), new TimeSpan(0, 7, 0, 0, 0)), "porro", new Guid("3140208e-efb5-0baa-5dcf-f3688dfb49d4"), new Guid("754ae7f5-0365-4af8-7c83-951b2e30d982") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("af4e7220-0f01-2605-0e56-6ab34b8a588c"), 102.34m, new DateTimeOffset(new DateTime(2020, 8, 2, 21, 47, 41, 346, DateTimeKind.Unspecified).AddTicks(6569), new TimeSpan(0, 7, 0, 0, 0)), "Sed repudiandae ea eligendi officia quam.", new DateTimeOffset(new DateTime(2020, 12, 21, 19, 8, 55, 858, DateTimeKind.Unspecified).AddTicks(5485), new TimeSpan(0, 7, 0, 0, 0)), "consequatur", new Guid("1b95837c-302e-82d9-d3e3-5c19fca249af"), new Guid("39fa5661-2eba-2269-1baa-fed1aa195356") },
                    { new Guid("b1835381-0a6f-3558-0ef0-f5e74a756503"), 485.62m, new DateTimeOffset(new DateTime(2020, 5, 14, 12, 5, 5, 564, DateTimeKind.Unspecified).AddTicks(3254), new TimeSpan(0, 7, 0, 0, 0)), "Pariatur dolorum laborum et doloribus et occaecati vel.", new DateTimeOffset(new DateTime(2020, 10, 26, 7, 27, 3, 231, DateTimeKind.Unspecified).AddTicks(2670), new TimeSpan(0, 7, 0, 0, 0)), "natus", new Guid("b35b2234-24f4-2054-ad1a-71ce513a15ab"), new Guid("b43e0475-76b4-6bbc-f7a7-1f4c4773aee3") },
                    { new Guid("b35b2234-24f4-2054-ad1a-71ce513a15ab"), 854.79m, new DateTimeOffset(new DateTime(2020, 12, 7, 3, 10, 6, 157, DateTimeKind.Unspecified).AddTicks(1279), new TimeSpan(0, 7, 0, 0, 0)), "Autem ab repellat rerum odio.", new DateTimeOffset(new DateTime(2020, 6, 12, 16, 30, 49, 234, DateTimeKind.Unspecified).AddTicks(5625), new TimeSpan(0, 7, 0, 0, 0)), "officiis", new Guid("61674358-aa9b-9f64-d9f7-8f1a58970f78"), new Guid("0804decd-7b5c-9799-690f-47fb03e9ce3b") }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("b50b40e5-4ad9-8950-8507-682b0d588f71"), 43.36m, new DateTimeOffset(new DateTime(2020, 1, 21, 19, 9, 49, 349, DateTimeKind.Unspecified).AddTicks(5881), new TimeSpan(0, 7, 0, 0, 0)), "A optio modi minus rerum voluptatem officiis.", true, new DateTimeOffset(new DateTime(2020, 5, 25, 17, 51, 7, 609, DateTimeKind.Unspecified).AddTicks(8780), new TimeSpan(0, 7, 0, 0, 0)), "architecto", new Guid("f4e4bdec-d0c1-62a7-fb99-0355c25a4a9d"), new Guid("3f9f750c-38ab-aaa4-4eb4-7f55421996b8") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("b5e07e23-dc6f-5b08-8c43-8fffa9361b81"), 927.11m, new DateTimeOffset(new DateTime(2020, 10, 27, 16, 1, 0, 560, DateTimeKind.Unspecified).AddTicks(6586), new TimeSpan(0, 7, 0, 0, 0)), "Ut et dolores eveniet ut atque dicta.", new DateTimeOffset(new DateTime(2020, 1, 11, 0, 46, 2, 197, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 7, 0, 0, 0)), "non", new Guid("660c4f13-ac34-972b-b671-5e720dd466c3"), new Guid("2e768de9-5437-4cd3-f08b-d2e2e7d40211") },
                    { new Guid("b8961942-64a3-8d69-d7fd-c7c3cbcfc21c"), 432.17m, new DateTimeOffset(new DateTime(2020, 9, 27, 6, 31, 14, 987, DateTimeKind.Unspecified).AddTicks(7085), new TimeSpan(0, 7, 0, 0, 0)), "Inventore impedit non est modi debitis voluptas voluptates optio.", new DateTimeOffset(new DateTime(2020, 3, 8, 0, 1, 7, 440, DateTimeKind.Unspecified).AddTicks(2699), new TimeSpan(0, 7, 0, 0, 0)), "error", new Guid("6f110748-4060-7943-3d81-f85d8b09c12c"), new Guid("69680ceb-a2ec-41e6-f64f-828aa45d905a") },
                    { new Guid("cc3f9225-197a-9b0d-6182-6df2719fea1b"), 980.81m, new DateTimeOffset(new DateTime(2020, 6, 21, 13, 51, 57, 810, DateTimeKind.Unspecified).AddTicks(9401), new TimeSpan(0, 7, 0, 0, 0)), "Delectus voluptas minus veniam et nesciunt.", new DateTimeOffset(new DateTime(2020, 6, 21, 22, 35, 15, 640, DateTimeKind.Unspecified).AddTicks(1685), new TimeSpan(0, 7, 0, 0, 0)), "ut", new Guid("609afabf-efdb-fb3f-7207-2583625812b2"), new Guid("f694ea54-f527-eed5-e010-5eca808b3b9c") },
                    { new Guid("cd4ee9d2-9528-80df-ffff-977fca08f654"), 839.72m, new DateTimeOffset(new DateTime(2020, 9, 30, 20, 47, 59, 884, DateTimeKind.Unspecified).AddTicks(1661), new TimeSpan(0, 7, 0, 0, 0)), "Sit et rerum pariatur.", new DateTimeOffset(new DateTime(2020, 1, 18, 10, 13, 59, 453, DateTimeKind.Unspecified).AddTicks(3463), new TimeSpan(0, 7, 0, 0, 0)), "excepturi", new Guid("4571167a-fb5e-362b-9985-3d5adc0468ba"), new Guid("2cc304c0-f65d-fe35-7c8d-3740a4699010") },
                    { new Guid("cd73f634-a957-8de9-762e-3754d34cf08b"), 748.96m, new DateTimeOffset(new DateTime(2020, 3, 7, 12, 10, 55, 729, DateTimeKind.Unspecified).AddTicks(3142), new TimeSpan(0, 7, 0, 0, 0)), "Vero quia rerum et omnis cupiditate aut sunt.", new DateTimeOffset(new DateTime(2020, 8, 1, 17, 36, 45, 990, DateTimeKind.Unspecified).AddTicks(892), new TimeSpan(0, 7, 0, 0, 0)), "et", new Guid("883f6641-68e4-d729-affb-e4c4535dc8e2"), new Guid("b05d30e7-c2f8-4c2f-7d7e-0b670a682b5a") },
                    { new Guid("d27aa37f-034f-ce19-64c7-57c651b6c26d"), 811.22m, new DateTimeOffset(new DateTime(2020, 10, 17, 14, 30, 51, 308, DateTimeKind.Unspecified).AddTicks(5638), new TimeSpan(0, 7, 0, 0, 0)), "Assumenda laboriosam autem dolorem qui laborum ab nemo et.", new DateTimeOffset(new DateTime(2020, 7, 22, 17, 56, 42, 284, DateTimeKind.Unspecified).AddTicks(3051), new TimeSpan(0, 7, 0, 0, 0)), "architecto", new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f"), new Guid("2b65bc72-52ae-5087-1db8-b47d7fa37ad2") }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("d42c9ec7-fda1-1681-fa3d-097e66c5fd01"), 869.35m, new DateTimeOffset(new DateTime(2020, 3, 9, 15, 42, 32, 800, DateTimeKind.Unspecified).AddTicks(2615), new TimeSpan(0, 7, 0, 0, 0)), "Eum eos alias ea.", true, new DateTimeOffset(new DateTime(2020, 6, 19, 16, 7, 36, 695, DateTimeKind.Unspecified).AddTicks(5449), new TimeSpan(0, 7, 0, 0, 0)), "alias", new Guid("4e7220ff-01af-050f-260e-566ab34b8a58"), new Guid("e189d5ab-c58e-c880-8b39-bc2da6528da9") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("d57e1861-2452-09f6-8c56-f3f8557eac44"), 776.26m, new DateTimeOffset(new DateTime(2020, 11, 23, 2, 38, 5, 756, DateTimeKind.Unspecified).AddTicks(7608), new TimeSpan(0, 7, 0, 0, 0)), "Vero autem nulla magni eius ipsum delectus.", new DateTimeOffset(new DateTime(2020, 10, 31, 10, 23, 2, 508, DateTimeKind.Unspecified).AddTicks(9808), new TimeSpan(0, 7, 0, 0, 0)), "ut", new Guid("2096d739-97f1-5726-27cd-ede8d3504da0"), new Guid("2b65bc72-52ae-5087-1db8-b47d7fa37ad2") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("d87437ec-f4f5-9d52-9bde-35a4eb67d140"), 627.06m, new DateTimeOffset(new DateTime(2020, 5, 23, 12, 40, 19, 76, DateTimeKind.Unspecified).AddTicks(9423), new TimeSpan(0, 7, 0, 0, 0)), "Molestias beatae assumenda et est aut aut nihil recusandae.", true, new DateTimeOffset(new DateTime(2020, 1, 19, 21, 10, 47, 394, DateTimeKind.Unspecified).AddTicks(5526), new TimeSpan(0, 7, 0, 0, 0)), "nam", new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f"), new Guid("53256548-ecd7-7437-d8f5-f4529d9bde35") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("db033f39-57ce-32f6-1cc5-87dc332ddaa1"), 330.22m, new DateTimeOffset(new DateTime(2020, 7, 9, 21, 41, 55, 475, DateTimeKind.Unspecified).AddTicks(2678), new TimeSpan(0, 7, 0, 0, 0)), "Omnis sapiente ullam.", new DateTimeOffset(new DateTime(2020, 1, 23, 4, 28, 2, 804, DateTimeKind.Unspecified).AddTicks(1032), new TimeSpan(0, 7, 0, 0, 0)), "cupiditate", new Guid("2096d739-97f1-5726-27cd-ede8d3504da0"), new Guid("53256548-ecd7-7437-d8f5-f4529d9bde35") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("e4e3def4-b2a1-c4a3-49f8-a662fe7e5157"), 356.77m, new DateTimeOffset(new DateTime(2020, 11, 15, 2, 8, 39, 796, DateTimeKind.Unspecified).AddTicks(3527), new TimeSpan(0, 7, 0, 0, 0)), "Ipsam mollitia atque atque et inventore laborum.", true, new DateTimeOffset(new DateTime(2020, 12, 23, 0, 6, 1, 196, DateTimeKind.Unspecified).AddTicks(4719), new TimeSpan(0, 7, 0, 0, 0)), "similique", new Guid("cf08e502-8911-c595-40a7-61187ed55224"), new Guid("c57fd8b3-7dcc-83e2-69aa-a4108d4d026f") },
                    { new Guid("e6a2ec69-f641-824f-8aa4-5d905ab4812d"), 768.81m, new DateTimeOffset(new DateTime(2020, 10, 25, 5, 37, 5, 395, DateTimeKind.Unspecified).AddTicks(9988), new TimeSpan(0, 7, 0, 0, 0)), "A qui voluptatem qui rerum deserunt voluptas voluptas assumenda expedita.", true, new DateTimeOffset(new DateTime(2020, 3, 3, 16, 56, 56, 443, DateTimeKind.Unspecified).AddTicks(8860), new TimeSpan(0, 7, 0, 0, 0)), "repellendus", new Guid("059f0b6a-1940-021d-901e-108a95bc55cb"), new Guid("fc468bcc-b19c-0a0a-a2dc-4995e1e478b1") },
                    { new Guid("ee602b2f-b479-e353-9036-dfc79c18976a"), 652.90m, new DateTimeOffset(new DateTime(2020, 11, 5, 20, 22, 45, 403, DateTimeKind.Unspecified).AddTicks(3034), new TimeSpan(0, 7, 0, 0, 0)), "Rerum corrupti voluptatem nobis delectus eos.", true, new DateTimeOffset(new DateTime(2020, 3, 4, 6, 35, 3, 882, DateTimeKind.Unspecified).AddTicks(6650), new TimeSpan(0, 7, 0, 0, 0)), "sint", new Guid("2667404a-245a-3ccc-8b84-6bcf135effe7"), new Guid("c57fd8b3-7dcc-83e2-69aa-a4108d4d026f") },
                    { new Guid("f2cebdf5-d86e-8d84-04bd-66760f9121b1"), 167.65m, new DateTimeOffset(new DateTime(2020, 6, 26, 3, 56, 4, 181, DateTimeKind.Unspecified).AddTicks(3568), new TimeSpan(0, 7, 0, 0, 0)), "Ut qui omnis ut nihil.", true, new DateTimeOffset(new DateTime(2020, 2, 18, 9, 55, 4, 315, DateTimeKind.Unspecified).AddTicks(9502), new TimeSpan(0, 7, 0, 0, 0)), "maiores", new Guid("78f7dc5f-0278-90bd-523a-268de4bc0e49"), new Guid("5fac0bab-9b1e-2b3f-cd52-f09e51d49ea8") }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("f93c9215-2941-5f5a-c931-444a0a6156fa"), 40.81m, new DateTimeOffset(new DateTime(2020, 7, 9, 13, 54, 39, 511, DateTimeKind.Unspecified).AddTicks(9340), new TimeSpan(0, 7, 0, 0, 0)), "Eius quibusdam in voluptatum vel illo sed.", new DateTimeOffset(new DateTime(2020, 5, 4, 1, 0, 43, 596, DateTimeKind.Unspecified).AddTicks(101), new TimeSpan(0, 7, 0, 0, 0)), "quia", new Guid("cce0516f-9f9f-f24f-f163-d6b684ab1f52"), new Guid("2d49430d-4e90-f11b-51a9-34225bb3f424") },
                    { new Guid("fe70d0a9-755e-b31a-d87f-c5cc7de28369"), 828.21m, new DateTimeOffset(new DateTime(2020, 12, 27, 10, 29, 24, 579, DateTimeKind.Unspecified).AddTicks(2079), new TimeSpan(0, 7, 0, 0, 0)), "Facere facilis sint.", new DateTimeOffset(new DateTime(2020, 11, 18, 22, 4, 24, 934, DateTimeKind.Unspecified).AddTicks(9374), new TimeSpan(0, 7, 0, 0, 0)), "quasi", new Guid("f046ac78-05d2-c7c1-40ea-bf733a9492ed"), new Guid("2495c693-e3b9-7c6f-3898-b7dd200bc116") }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("048d35ff-36ae-cac7-601a-03998417fd2e"), new DateTimeOffset(new DateTime(2020, 11, 6, 17, 8, 49, 277, DateTimeKind.Unspecified).AddTicks(8392), new TimeSpan(0, 7, 0, 0, 0)), 2, true, new DateTimeOffset(new DateTime(2020, 2, 15, 22, 25, 49, 504, DateTimeKind.Unspecified).AddTicks(7156), new TimeSpan(0, 7, 0, 0, 0)), "East Jennyfer" },
                    { new Guid("0c666a36-75bf-3e04-b4b4-76bc6bf7a71f"), new DateTimeOffset(new DateTime(2020, 11, 2, 3, 38, 22, 486, DateTimeKind.Unspecified).AddTicks(890), new TimeSpan(0, 7, 0, 0, 0)), 26, true, new DateTimeOffset(new DateTime(2020, 4, 13, 1, 22, 27, 594, DateTimeKind.Unspecified).AddTicks(8521), new TimeSpan(0, 7, 0, 0, 0)), "East Louie" },
                    { new Guid("15d6a64d-3c92-41f9-295a-5fc931444a0a"), new DateTimeOffset(new DateTime(2020, 9, 22, 1, 44, 15, 282, DateTimeKind.Unspecified).AddTicks(3886), new TimeSpan(0, 7, 0, 0, 0)), 14, true, new DateTimeOffset(new DateTime(2020, 12, 17, 9, 57, 56, 948, DateTimeKind.Unspecified).AddTicks(857), new TimeSpan(0, 7, 0, 0, 0)), "South Marcelle" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("1aad2054-ce71-3a51-15ab-1e6d75d265d3"), new DateTimeOffset(new DateTime(2020, 12, 7, 3, 10, 6, 157, DateTimeKind.Unspecified).AddTicks(1279), new TimeSpan(0, 7, 0, 0, 0)), 3, new DateTimeOffset(new DateTime(2020, 6, 12, 16, 30, 49, 234, DateTimeKind.Unspecified).AddTicks(5625), new TimeSpan(0, 7, 0, 0, 0)), "Nitzscheview" },
                    { new Guid("1e329db5-c9fa-05fc-d497-5ed3d8499f7c"), new DateTimeOffset(new DateTime(2020, 5, 16, 19, 58, 48, 313, DateTimeKind.Unspecified).AddTicks(1696), new TimeSpan(0, 7, 0, 0, 0)), 15, new DateTimeOffset(new DateTime(2020, 2, 10, 13, 49, 17, 936, DateTimeKind.Unspecified).AddTicks(8525), new TimeSpan(0, 7, 0, 0, 0)), "Vonton" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("25654813-d753-37ec-74d8-f5f4529d9bde"), new DateTimeOffset(new DateTime(2020, 4, 4, 1, 43, 41, 908, DateTimeKind.Unspecified).AddTicks(8822), new TimeSpan(0, 7, 0, 0, 0)), 42, true, new DateTimeOffset(new DateTime(2020, 5, 18, 9, 28, 4, 850, DateTimeKind.Unspecified).AddTicks(202), new TimeSpan(0, 7, 0, 0, 0)), "South Vernamouth" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("2dbc398b-52a6-a98d-d070-fe5e751ab3d8"), new DateTimeOffset(new DateTime(2020, 10, 6, 8, 21, 21, 565, DateTimeKind.Unspecified).AddTicks(8784), new TimeSpan(0, 7, 0, 0, 0)), 3, new DateTimeOffset(new DateTime(2020, 1, 14, 7, 3, 14, 717, DateTimeKind.Unspecified).AddTicks(2686), new TimeSpan(0, 7, 0, 0, 0)), "South Genesisside" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("318e4206-34ba-5e52-7c82-b1c93efc319c"), new DateTimeOffset(new DateTime(2020, 8, 15, 6, 27, 26, 793, DateTimeKind.Unspecified).AddTicks(9351), new TimeSpan(0, 7, 0, 0, 0)), 33, true, new DateTimeOffset(new DateTime(2020, 12, 17, 6, 25, 21, 515, DateTimeKind.Unspecified).AddTicks(9986), new TimeSpan(0, 7, 0, 0, 0)), "West Makaylashire" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("3313ce27-d248-29a8-fd66-c566826226cd"), new DateTimeOffset(new DateTime(2020, 7, 5, 14, 37, 40, 355, DateTimeKind.Unspecified).AddTicks(7921), new TimeSpan(0, 7, 0, 0, 0)), 39, new DateTimeOffset(new DateTime(2020, 10, 20, 14, 17, 2, 493, DateTimeKind.Unspecified).AddTicks(8677), new TimeSpan(0, 7, 0, 0, 0)), "Haleyburgh" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("3a6aed8d-5a99-4edd-8327-5c278eb6b17d"), new DateTimeOffset(new DateTime(2020, 2, 5, 17, 54, 17, 131, DateTimeKind.Unspecified).AddTicks(1998), new TimeSpan(0, 7, 0, 0, 0)), 43, true, new DateTimeOffset(new DateTime(2020, 7, 19, 0, 45, 33, 69, DateTimeKind.Unspecified).AddTicks(4658), new TimeSpan(0, 7, 0, 0, 0)), "Brantberg" },
                    { new Guid("3a7e3299-e0c5-5df7-64b0-a4a1a1b53962"), new DateTimeOffset(new DateTime(2020, 11, 22, 4, 33, 39, 260, DateTimeKind.Unspecified).AddTicks(5363), new TimeSpan(0, 7, 0, 0, 0)), 22, true, new DateTimeOffset(new DateTime(2020, 7, 9, 21, 4, 21, 808, DateTimeKind.Unspecified).AddTicks(701), new TimeSpan(0, 7, 0, 0, 0)), "Jovanihaven" },
                    { new Guid("3aab7684-df2f-9588-6762-d36d43591ec6"), new DateTimeOffset(new DateTime(2020, 6, 28, 13, 22, 3, 844, DateTimeKind.Unspecified).AddTicks(7697), new TimeSpan(0, 7, 0, 0, 0)), 14, true, new DateTimeOffset(new DateTime(2020, 11, 20, 9, 53, 55, 655, DateTimeKind.Unspecified).AddTicks(6105), new TimeSpan(0, 7, 0, 0, 0)), "Pollichville" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("3f9225cd-7acc-0d19-9b61-826df2719fea"), new DateTimeOffset(new DateTime(2020, 2, 5, 15, 55, 54, 163, DateTimeKind.Unspecified).AddTicks(3262), new TimeSpan(0, 7, 0, 0, 0)), 19, new DateTimeOffset(new DateTime(2020, 7, 8, 1, 29, 0, 604, DateTimeKind.Unspecified).AddTicks(5894), new TimeSpan(0, 7, 0, 0, 0)), "Selenashire" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("40179df0-b9b7-ccb0-8b46-fc9cb10a0aa2"), new DateTimeOffset(new DateTime(2020, 12, 3, 22, 12, 58, 497, DateTimeKind.Unspecified).AddTicks(2697), new TimeSpan(0, 7, 0, 0, 0)), 43, true, new DateTimeOffset(new DateTime(2020, 1, 22, 7, 39, 35, 63, DateTimeKind.Unspecified).AddTicks(1178), new TimeSpan(0, 7, 0, 0, 0)), "New Fleta" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("40e562d7-b50b-4ad9-5089-8507682b0d58"), new DateTimeOffset(new DateTime(2020, 12, 16, 11, 32, 50, 387, DateTimeKind.Unspecified).AddTicks(8566), new TimeSpan(0, 7, 0, 0, 0)), 22, new DateTimeOffset(new DateTime(2020, 12, 4, 10, 23, 21, 13, DateTimeKind.Unspecified).AddTicks(43), new TimeSpan(0, 7, 0, 0, 0)), "Lednermouth" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("41e6a2ec-4ff6-8a82-a45d-905ab4812ddc"), new DateTimeOffset(new DateTime(2020, 1, 16, 2, 32, 54, 970, DateTimeKind.Unspecified).AddTicks(5164), new TimeSpan(0, 7, 0, 0, 0)), 43, true, new DateTimeOffset(new DateTime(2020, 3, 5, 16, 48, 13, 498, DateTimeKind.Unspecified).AddTicks(6635), new TimeSpan(0, 7, 0, 0, 0)), "Schadenshire" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("4d8d10a4-6f02-8058-8923-f5bdcef26ed8"), new DateTimeOffset(new DateTime(2020, 4, 22, 7, 40, 1, 142, DateTimeKind.Unspecified).AddTicks(8395), new TimeSpan(0, 7, 0, 0, 0)), 20, new DateTimeOffset(new DateTime(2020, 11, 25, 18, 3, 40, 322, DateTimeKind.Unspecified).AddTicks(1102), new TimeSpan(0, 7, 0, 0, 0)), "East Adela" },
                    { new Guid("52ae2b65-5087-b81d-b47d-7fa37ad24f03"), new DateTimeOffset(new DateTime(2020, 10, 31, 3, 47, 15, 901, DateTimeKind.Unspecified).AddTicks(194), new TimeSpan(0, 7, 0, 0, 0)), 27, new DateTimeOffset(new DateTime(2020, 6, 20, 2, 54, 43, 526, DateTimeKind.Unspecified).AddTicks(1230), new TimeSpan(0, 7, 0, 0, 0)), "Lake Timmothyshire" },
                    { new Guid("54f608ca-598f-a8ca-8e37-a92300d6a440"), new DateTimeOffset(new DateTime(2020, 3, 11, 17, 31, 40, 530, DateTimeKind.Unspecified).AddTicks(2693), new TimeSpan(0, 7, 0, 0, 0)), 4, new DateTimeOffset(new DateTime(2020, 1, 6, 13, 50, 57, 171, DateTimeKind.Unspecified).AddTicks(5185), new TimeSpan(0, 7, 0, 0, 0)), "South Nat" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("5e10e0ee-80ca-3b8b-9c77-ec7d0d387eeb"), new DateTimeOffset(new DateTime(2020, 7, 19, 3, 21, 29, 954, DateTimeKind.Unspecified).AddTicks(8676), new TimeSpan(0, 7, 0, 0, 0)), 10, true, new DateTimeOffset(new DateTime(2020, 1, 26, 22, 15, 55, 693, DateTimeKind.Unspecified).AddTicks(6533), new TimeSpan(0, 7, 0, 0, 0)), "West Reganburgh" },
                    { new Guid("60447f7b-fee5-ba9d-8dcd-411f2c0793b7"), new DateTimeOffset(new DateTime(2020, 8, 22, 11, 48, 58, 362, DateTimeKind.Unspecified).AddTicks(8924), new TimeSpan(0, 7, 0, 0, 0)), 35, true, new DateTimeOffset(new DateTime(2020, 10, 28, 13, 9, 22, 349, DateTimeKind.Unspecified).AddTicks(3), new TimeSpan(0, 7, 0, 0, 0)), "New Sallie" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("62b12191-f9c9-e502-08cf-118995c540a7"), new DateTimeOffset(new DateTime(2020, 11, 29, 16, 59, 47, 928, DateTimeKind.Unspecified).AddTicks(4920), new TimeSpan(0, 7, 0, 0, 0)), 16, new DateTimeOffset(new DateTime(2020, 2, 9, 19, 46, 7, 70, DateTimeKind.Unspecified).AddTicks(7483), new TimeSpan(0, 7, 0, 0, 0)), "East Brant" },
                    { new Guid("67435822-9b61-64aa-9fd9-f78f1a58970f"), new DateTimeOffset(new DateTime(2020, 7, 6, 8, 19, 13, 552, DateTimeKind.Unspecified).AddTicks(4105), new TimeSpan(0, 7, 0, 0, 0)), 18, new DateTimeOffset(new DateTime(2020, 9, 16, 14, 39, 44, 445, DateTimeKind.Unspecified).AddTicks(1211), new TimeSpan(0, 7, 0, 0, 0)), "New Nelleport" },
                    { new Guid("69816e2a-9dd6-6e49-5763-a37c45fb1f8b"), new DateTimeOffset(new DateTime(2020, 3, 7, 18, 23, 32, 899, DateTimeKind.Unspecified).AddTicks(5488), new TimeSpan(0, 7, 0, 0, 0)), 30, new DateTimeOffset(new DateTime(2020, 6, 30, 21, 14, 10, 69, DateTimeKind.Unspecified).AddTicks(920), new TimeSpan(0, 7, 0, 0, 0)), "New Ruthiehaven" },
                    { new Guid("71b6972b-725e-d40d-66c3-4f8b85031295"), new DateTimeOffset(new DateTime(2020, 2, 21, 13, 19, 56, 813, DateTimeKind.Unspecified).AddTicks(5536), new TimeSpan(0, 7, 0, 0, 0)), 49, new DateTimeOffset(new DateTime(2020, 9, 1, 3, 29, 29, 853, DateTimeKind.Unspecified).AddTicks(6931), new TimeSpan(0, 7, 0, 0, 0)), "South Vena" },
                    { new Guid("7fb44eaa-4255-9619-b8a3-64698dd7fdc7"), new DateTimeOffset(new DateTime(2020, 8, 11, 16, 15, 36, 138, DateTimeKind.Unspecified).AddTicks(9716), new TimeSpan(0, 7, 0, 0, 0)), 7, new DateTimeOffset(new DateTime(2020, 5, 26, 12, 33, 31, 347, DateTimeKind.Unspecified).AddTicks(7113), new TimeSpan(0, 7, 0, 0, 0)), "Port Kacie" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("86f76dc2-3ca8-46e6-80ed-8168bd10e2e3"), new DateTimeOffset(new DateTime(2020, 9, 30, 14, 49, 12, 324, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 7, 0, 0, 0)), 11, true, new DateTimeOffset(new DateTime(2020, 5, 6, 7, 17, 1, 420, DateTimeKind.Unspecified).AddTicks(6102), new TimeSpan(0, 7, 0, 0, 0)), "Port Ophelia" },
                    { new Guid("93e6a9f2-626c-3369-ef85-5ab90a53b0f5"), new DateTimeOffset(new DateTime(2020, 1, 15, 1, 34, 11, 827, DateTimeKind.Unspecified).AddTicks(8059), new TimeSpan(0, 7, 0, 0, 0)), 3, true, new DateTimeOffset(new DateTime(2020, 6, 11, 11, 41, 47, 844, DateTimeKind.Unspecified).AddTicks(5273), new TimeSpan(0, 7, 0, 0, 0)), "East Jessyca" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new DateTimeOffset(new DateTime(2020, 8, 30, 0, 38, 16, 925, DateTimeKind.Unspecified).AddTicks(600), new TimeSpan(0, 7, 0, 0, 0)), 36, new DateTimeOffset(new DateTime(2020, 9, 2, 6, 3, 4, 571, DateTimeKind.Unspecified).AddTicks(871), new TimeSpan(0, 7, 0, 0, 0)), "Lake Ashtynton" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("9b7ee018-0252-62b0-f68e-93af65c0a83e"), new DateTimeOffset(new DateTime(2020, 8, 24, 17, 19, 52, 944, DateTimeKind.Unspecified).AddTicks(3262), new TimeSpan(0, 7, 0, 0, 0)), 38, true, new DateTimeOffset(new DateTime(2020, 3, 10, 11, 6, 7, 168, DateTimeKind.Unspecified).AddTicks(2678), new TimeSpan(0, 7, 0, 0, 0)), "East Magali" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("9ef052cd-d451-a89e-0515-b413c4587a03"), new DateTimeOffset(new DateTime(2020, 10, 4, 16, 11, 23, 444, DateTimeKind.Unspecified).AddTicks(1442), new TimeSpan(0, 7, 0, 0, 0)), 13, new DateTimeOffset(new DateTime(2020, 4, 17, 4, 55, 15, 710, DateTimeKind.Unspecified).AddTicks(8374), new TimeSpan(0, 7, 0, 0, 0)), "South Leland" },
                    { new Guid("a2e64313-e8a4-bda0-6c2b-a7d672050a8f"), new DateTimeOffset(new DateTime(2020, 5, 5, 7, 40, 4, 153, DateTimeKind.Unspecified).AddTicks(2839), new TimeSpan(0, 7, 0, 0, 0)), 13, new DateTimeOffset(new DateTime(2020, 4, 5, 4, 40, 2, 547, DateTimeKind.Unspecified).AddTicks(6549), new TimeSpan(0, 7, 0, 0, 0)), "South Lizeth" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("a8ffd52a-3d62-ea5c-e177-a771279a4944"), new DateTimeOffset(new DateTime(2020, 11, 15, 14, 45, 29, 658, DateTimeKind.Unspecified).AddTicks(2156), new TimeSpan(0, 7, 0, 0, 0)), 17, true, new DateTimeOffset(new DateTime(2020, 1, 20, 5, 43, 18, 148, DateTimeKind.Unspecified).AddTicks(7147), new TimeSpan(0, 7, 0, 0, 0)), "Bernhardport" },
                    { new Guid("a99052b6-a953-00fb-7f94-ad45509c5449"), new DateTimeOffset(new DateTime(2020, 12, 19, 7, 37, 48, 118, DateTimeKind.Unspecified).AddTicks(7773), new TimeSpan(0, 7, 0, 0, 0)), 19, true, new DateTimeOffset(new DateTime(2020, 9, 10, 2, 9, 48, 349, DateTimeKind.Unspecified).AddTicks(5114), new TimeSpan(0, 7, 0, 0, 0)), "Connland" },
                    { new Guid("ad0e2ced-74dc-76db-8864-6ffd2dc498c6"), new DateTimeOffset(new DateTime(2020, 10, 9, 7, 57, 16, 113, DateTimeKind.Unspecified).AddTicks(3679), new TimeSpan(0, 7, 0, 0, 0)), 30, true, new DateTimeOffset(new DateTime(2020, 8, 12, 22, 25, 8, 850, DateTimeKind.Unspecified).AddTicks(578), new TimeSpan(0, 7, 0, 0, 0)), "East Alecburgh" },
                    { new Guid("ad659bb5-d5ce-14fa-8bef-7b2fa2d996de"), new DateTimeOffset(new DateTime(2020, 3, 5, 15, 28, 36, 484, DateTimeKind.Unspecified).AddTicks(6203), new TimeSpan(0, 7, 0, 0, 0)), 4, true, new DateTimeOffset(new DateTime(2020, 3, 19, 6, 43, 58, 413, DateTimeKind.Unspecified).AddTicks(8637), new TimeSpan(0, 7, 0, 0, 0)), "Watsicaborough" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("ae7c811b-cb63-0def-4349-2d904e1bf151"), new DateTimeOffset(new DateTime(2020, 9, 30, 11, 45, 51, 797, DateTimeKind.Unspecified).AddTicks(7003), new TimeSpan(0, 7, 0, 0, 0)), 42, new DateTimeOffset(new DateTime(2020, 5, 29, 17, 8, 54, 755, DateTimeKind.Unspecified).AddTicks(8622), new TimeSpan(0, 7, 0, 0, 0)), "Marilynetown" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("af49a2fc-2f96-0c5f-e2aa-42309edddf13"), new DateTimeOffset(new DateTime(2020, 2, 22, 2, 18, 31, 0, DateTimeKind.Unspecified).AddTicks(7504), new TimeSpan(0, 7, 0, 0, 0)), 25, true, new DateTimeOffset(new DateTime(2020, 12, 2, 1, 36, 47, 105, DateTimeKind.Unspecified).AddTicks(9820), new TimeSpan(0, 7, 0, 0, 0)), "Rolfsonburgh" },
                    { new Guid("b1f8c222-9565-8099-0ff9-8b293b957e2d"), new DateTimeOffset(new DateTime(2020, 10, 15, 6, 13, 43, 483, DateTimeKind.Unspecified).AddTicks(6951), new TimeSpan(0, 7, 0, 0, 0)), 26, true, new DateTimeOffset(new DateTime(2020, 1, 19, 21, 4, 39, 408, DateTimeKind.Unspecified).AddTicks(6184), new TimeSpan(0, 7, 0, 0, 0)), "West Sylviaport" },
                    { new Guid("b9c55050-58bd-e1e5-a445-366631090c34"), new DateTimeOffset(new DateTime(2020, 1, 30, 0, 4, 16, 189, DateTimeKind.Unspecified).AddTicks(8397), new TimeSpan(0, 7, 0, 0, 0)), 7, true, new DateTimeOffset(new DateTime(2020, 7, 4, 10, 2, 54, 109, DateTimeKind.Unspecified).AddTicks(7008), new TimeSpan(0, 7, 0, 0, 0)), "Port Robbieton" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("d354372e-f04c-d28b-e2e7-d40211337a1c"), new DateTimeOffset(new DateTime(2020, 3, 7, 12, 10, 55, 729, DateTimeKind.Unspecified).AddTicks(3142), new TimeSpan(0, 7, 0, 0, 0)), 39, new DateTimeOffset(new DateTime(2020, 8, 1, 17, 36, 45, 990, DateTimeKind.Unspecified).AddTicks(892), new TimeSpan(0, 7, 0, 0, 0)), "Weldonmouth" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("d42c9ec7-fda1-1681-fa3d-097e66c5fd01"), new DateTimeOffset(new DateTime(2020, 8, 13, 16, 49, 29, 274, DateTimeKind.Unspecified).AddTicks(9976), new TimeSpan(0, 7, 0, 0, 0)), 15, true, new DateTimeOffset(new DateTime(2020, 11, 11, 3, 19, 44, 731, DateTimeKind.Unspecified).AddTicks(7409), new TimeSpan(0, 7, 0, 0, 0)), "Port Abeville" },
                    { new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab"), new DateTimeOffset(new DateTime(2020, 11, 5, 20, 22, 45, 403, DateTimeKind.Unspecified).AddTicks(3034), new TimeSpan(0, 7, 0, 0, 0)), 8, true, new DateTimeOffset(new DateTime(2020, 3, 4, 6, 35, 3, 882, DateTimeKind.Unspecified).AddTicks(6650), new TimeSpan(0, 7, 0, 0, 0)), "Vivianhaven" },
                    { new Guid("df8b1dd6-47d6-6f87-fa5d-3fefbb55f9f7"), new DateTimeOffset(new DateTime(2020, 6, 8, 4, 40, 10, 158, DateTimeKind.Unspecified).AddTicks(5571), new TimeSpan(0, 7, 0, 0, 0)), 47, true, new DateTimeOffset(new DateTime(2020, 11, 19, 23, 12, 48, 388, DateTimeKind.Unspecified).AddTicks(793), new TimeSpan(0, 7, 0, 0, 0)), "Carleyside" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("f3568c09-55f8-ac7e-442d-01fb2b510c8e"), new DateTimeOffset(new DateTime(2020, 11, 23, 2, 38, 5, 756, DateTimeKind.Unspecified).AddTicks(7608), new TimeSpan(0, 7, 0, 0, 0)), 43, new DateTimeOffset(new DateTime(2020, 10, 31, 10, 23, 2, 508, DateTimeKind.Unspecified).AddTicks(9808), new TimeSpan(0, 7, 0, 0, 0)), "East Celestinoshire" },
                    { new Guid("f5f00e35-4ae7-6575-03f8-4a7c83951b2e"), new DateTimeOffset(new DateTime(2020, 6, 24, 3, 25, 2, 978, DateTimeKind.Unspecified).AddTicks(2546), new TimeSpan(0, 7, 0, 0, 0)), 31, new DateTimeOffset(new DateTime(2020, 3, 9, 14, 43, 4, 588, DateTimeKind.Unspecified).AddTicks(3527), new TimeSpan(0, 7, 0, 0, 0)), "Yvetteton" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("f680eb09-208b-2b14-1237-d52d64d485ab"), new DateTimeOffset(new DateTime(2020, 4, 12, 9, 19, 15, 617, DateTimeKind.Unspecified).AddTicks(4047), new TimeSpan(0, 7, 0, 0, 0)), 36, true, new DateTimeOffset(new DateTime(2020, 8, 20, 0, 36, 20, 736, DateTimeKind.Unspecified).AddTicks(1106), new TimeSpan(0, 7, 0, 0, 0)), "Rosannamouth" },
                    { new Guid("f7895455-134e-0837-4c23-7ee0b56fdc08"), new DateTimeOffset(new DateTime(2020, 1, 9, 22, 48, 48, 21, DateTimeKind.Unspecified).AddTicks(6003), new TimeSpan(0, 7, 0, 0, 0)), 35, true, new DateTimeOffset(new DateTime(2020, 1, 13, 17, 20, 7, 146, DateTimeKind.Unspecified).AddTicks(8644), new TimeSpan(0, 7, 0, 0, 0)), "Hermanbury" },
                    { new Guid("fb470f69-e903-3bce-6577-08add2e94ecd"), new DateTimeOffset(new DateTime(2020, 8, 5, 12, 25, 58, 989, DateTimeKind.Unspecified).AddTicks(3117), new TimeSpan(0, 7, 0, 0, 0)), 39, true, new DateTimeOffset(new DateTime(2020, 10, 27, 4, 54, 36, 849, DateTimeKind.Unspecified).AddTicks(4510), new TimeSpan(0, 7, 0, 0, 0)), "East Emmieside" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("feaa1b22-aad1-5319-5664-b0e4145d3dcc"), new DateTimeOffset(new DateTime(2020, 8, 6, 15, 10, 0, 460, DateTimeKind.Unspecified).AddTicks(8200), new TimeSpan(0, 7, 0, 0, 0)), 15, new DateTimeOffset(new DateTime(2020, 6, 28, 17, 59, 9, 490, DateTimeKind.Unspecified).AddTicks(5073), new TimeSpan(0, 7, 0, 0, 0)), "East Emelieton" });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[] { new Guid("0493a29e-5c9f-7083-66de-782b4b0aa3e9"), null, new DateTimeOffset(new DateTime(2020, 4, 14, 5, 28, 37, 44, DateTimeKind.Unspecified).AddTicks(4610), new TimeSpan(0, 7, 0, 0, 0)), true, 9, 1, new DateTimeOffset(new DateTime(2020, 7, 19, 19, 52, 49, 454, DateTimeKind.Unspecified).AddTicks(8463), new TimeSpan(0, 7, 0, 0, 0)), "Sporer - Thiel", 41.689910073154573m, new Guid("18d34369-a53b-032e-483f-3773c3e7b578"), new Guid("9528cd4e-80df-ffff-977f-ca08f6548f59"), new Guid("3aab7684-df2f-9588-6762-d36d43591ec6") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[,]
                {
                    { new Guid("06278a51-2c88-111e-be6c-94ebbe9406f5"), null, new DateTimeOffset(new DateTime(2020, 11, 30, 9, 39, 7, 341, DateTimeKind.Unspecified).AddTicks(6192), new TimeSpan(0, 7, 0, 0, 0)), 6, 2, new DateTimeOffset(new DateTime(2020, 12, 4, 18, 22, 48, 913, DateTimeKind.Unspecified).AddTicks(4667), new TimeSpan(0, 7, 0, 0, 0)), "Klocko, Parisian and Bailey", 37.979252467387912m, new Guid("6f110748-4060-7943-3d81-f85d8b09c12c"), new Guid("2cc304c0-f65d-fe35-7c8d-3740a4699010"), new Guid("fb470f69-e903-3bce-6577-08add2e94ecd") },
                    { new Guid("127c7d69-9bd8-fb05-b310-08e536b36c28"), null, new DateTimeOffset(new DateTime(2020, 2, 27, 5, 27, 41, 102, DateTimeKind.Unspecified).AddTicks(1774), new TimeSpan(0, 7, 0, 0, 0)), 9, 4, new DateTimeOffset(new DateTime(2020, 6, 8, 14, 46, 43, 98, DateTimeKind.Unspecified).AddTicks(6542), new TimeSpan(0, 7, 0, 0, 0)), "Dooley and Sons", 72.576695055503737m, new Guid("60e01340-3a21-225b-1cfd-f38583c3b73c"), new Guid("e189d5ab-c58e-c880-8b39-bc2da6528da9"), new Guid("41e6a2ec-4ff6-8a82-a45d-905ab4812ddc") },
                    { new Guid("1f1fc172-de8f-09d4-b2d2-48077225518c"), null, new DateTimeOffset(new DateTime(2020, 6, 14, 7, 28, 41, 393, DateTimeKind.Unspecified).AddTicks(7602), new TimeSpan(0, 7, 0, 0, 0)), 9, 4, new DateTimeOffset(new DateTime(2020, 9, 20, 17, 3, 8, 444, DateTimeKind.Unspecified).AddTicks(6445), new TimeSpan(0, 7, 0, 0, 0)), "Schinner, Bernhard and Kunze", 58.848826167568909m, new Guid("4e7220ff-01af-050f-260e-566ab34b8a58"), new Guid("d86ef2ce-8d84-bd04-6676-0f9121b162c9"), new Guid("62b12191-f9c9-e502-08cf-118995c540a7") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[] { new Guid("21113ab3-a8e3-d3de-a9d6-d2d7bdd33bc3"), null, new DateTimeOffset(new DateTime(2020, 2, 27, 8, 40, 51, 760, DateTimeKind.Unspecified).AddTicks(8594), new TimeSpan(0, 7, 0, 0, 0)), true, 5, 4, new DateTimeOffset(new DateTime(2020, 3, 26, 10, 25, 14, 185, DateTimeKind.Unspecified).AddTicks(8767), new TimeSpan(0, 7, 0, 0, 0)), "Konopelski Group", 16.254251493259438m, new Guid("2aad91df-816e-d669-9d49-6e5763a37c45"), new Guid("b651c657-6dc2-86f7-a83c-e64680ed8168"), new Guid("ae7c811b-cb63-0def-4349-2d904e1bf151") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[,]
                {
                    { new Guid("21a19a75-c397-f2f7-c138-1c350582a9e4"), null, new DateTimeOffset(new DateTime(2020, 3, 18, 16, 26, 6, 826, DateTimeKind.Unspecified).AddTicks(7600), new TimeSpan(0, 7, 0, 0, 0)), 6, 2, new DateTimeOffset(new DateTime(2020, 11, 19, 1, 9, 16, 699, DateTimeKind.Unspecified).AddTicks(5238), new TimeSpan(0, 7, 0, 0, 0)), "Rolfson, Moen and Runte", 83.432374125547897m, new Guid("60e01340-3a21-225b-1cfd-f38583c3b73c"), new Guid("1f41cd8d-072c-b793-df38-5c9a4619abd6"), new Guid("f7895455-134e-0837-4c23-7ee0b56fdc08") },
                    { new Guid("230d8922-1828-483c-7858-c33ace94d9e3"), null, new DateTimeOffset(new DateTime(2020, 5, 2, 7, 7, 30, 72, DateTimeKind.Unspecified).AddTicks(5121), new TimeSpan(0, 7, 0, 0, 0)), 5, 3, new DateTimeOffset(new DateTime(2020, 7, 15, 15, 1, 56, 255, DateTimeKind.Unspecified).AddTicks(374), new TimeSpan(0, 7, 0, 0, 0)), "Reichel LLC", 27.049287472874479m, new Guid("61674358-aa9b-9f64-d9f7-8f1a58970f78"), new Guid("c550507d-bdb9-e558-e1a4-45366631090c"), new Guid("df8b1dd6-47d6-6f87-fa5d-3fefbb55f9f7") },
                    { new Guid("25d1af98-3aa3-46f2-ec74-b73f32a89b98"), null, new DateTimeOffset(new DateTime(2020, 4, 19, 4, 7, 47, 562, DateTimeKind.Unspecified).AddTicks(7763), new TimeSpan(0, 7, 0, 0, 0)), 9, 2, new DateTimeOffset(new DateTime(2020, 9, 8, 17, 39, 59, 789, DateTimeKind.Unspecified).AddTicks(8025), new TimeSpan(0, 7, 0, 0, 0)), "Ziemann Group", 6.9124351557867805m, new Guid("1c32f657-87c5-33dc-2dda-a177a4571d84"), new Guid("2e768de9-5437-4cd3-f08b-d2e2e7d40211"), new Guid("3aab7684-df2f-9588-6762-d36d43591ec6") },
                    { new Guid("2702e6e6-01b4-12c7-f857-2a2e74316200"), null, new DateTimeOffset(new DateTime(2020, 2, 15, 0, 20, 59, 801, DateTimeKind.Unspecified).AddTicks(3750), new TimeSpan(0, 7, 0, 0, 0)), 7, 5, new DateTimeOffset(new DateTime(2020, 11, 23, 7, 52, 58, 366, DateTimeKind.Unspecified).AddTicks(6668), new TimeSpan(0, 7, 0, 0, 0)), "Reinger Group", 72.931643714630854m, new Guid("18d34369-a53b-032e-483f-3773c3e7b578"), new Guid("0804decd-7b5c-9799-690f-47fb03e9ce3b"), new Guid("df8b1dd6-47d6-6f87-fa5d-3fefbb55f9f7") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[,]
                {
                    { new Guid("28e6c30d-ecf2-2b5e-8579-6a8da40c4c08"), null, new DateTimeOffset(new DateTime(2020, 1, 24, 16, 45, 16, 529, DateTimeKind.Unspecified).AddTicks(6374), new TimeSpan(0, 7, 0, 0, 0)), true, 10, 4, new DateTimeOffset(new DateTime(2020, 4, 26, 9, 22, 18, 399, DateTimeKind.Unspecified).AddTicks(6763), new TimeSpan(0, 7, 0, 0, 0)), "Hodkiewicz, Turner and Bayer", 63.903093883722631m, new Guid("31c8786a-f2fa-ab7a-0bac-5f1e9b3f2bcd"), new Guid("0c512bfb-868e-3e86-eded-bd69d81343e6"), new Guid("a8ffd52a-3d62-ea5c-e177-a771279a4944") },
                    { new Guid("3011c86c-bfe7-4b3a-ce71-01f5eeceda98"), null, new DateTimeOffset(new DateTime(2020, 4, 27, 13, 36, 25, 67, DateTimeKind.Unspecified).AddTicks(6988), new TimeSpan(0, 7, 0, 0, 0)), true, 8, 3, new DateTimeOffset(new DateTime(2020, 7, 20, 19, 17, 22, 754, DateTimeKind.Unspecified).AddTicks(4515), new TimeSpan(0, 7, 0, 0, 0)), "Marquardt, Berge and O'Hara", 33.867992817362791m, new Guid("f046ac78-05d2-c7c1-40ea-bf733a9492ed"), new Guid("d405fcc9-5e97-d8d3-499f-7ce08d1783e3"), new Guid("ad659bb5-d5ce-14fa-8bef-7b2fa2d996de") },
                    { new Guid("348368bc-8bcb-f0bc-509c-091ae65f56c5"), null, new DateTimeOffset(new DateTime(2020, 9, 6, 4, 32, 58, 39, DateTimeKind.Unspecified).AddTicks(9592), new TimeSpan(0, 7, 0, 0, 0)), true, 8, 4, new DateTimeOffset(new DateTime(2020, 11, 16, 0, 5, 24, 918, DateTimeKind.Unspecified).AddTicks(6160), new TimeSpan(0, 7, 0, 0, 0)), "Gusikowski - Harber", 13.276769544592498m, new Guid("1d16222e-1f0e-1a0c-5815-5e539e98ce71"), new Guid("2d49430d-4e90-f11b-51a9-34225bb3f424"), new Guid("fb470f69-e903-3bce-6577-08add2e94ecd") },
                    { new Guid("3b2ed5e9-129c-9803-e89b-09e05c86f18c"), null, new DateTimeOffset(new DateTime(2020, 5, 30, 6, 44, 35, 397, DateTimeKind.Unspecified).AddTicks(8514), new TimeSpan(0, 7, 0, 0, 0)), true, 9, 2, new DateTimeOffset(new DateTime(2020, 1, 28, 22, 46, 5, 461, DateTimeKind.Unspecified).AddTicks(1865), new TimeSpan(0, 7, 0, 0, 0)), "Breitenberg, Pouros and Gerlach", 56.994097085666938m, new Guid("78f7dc5f-0278-90bd-523a-268de4bc0e49"), new Guid("4042cc3e-fa91-d7da-ff35-8d04ae36c7ca"), new Guid("93e6a9f2-626c-3369-ef85-5ab90a53b0f5") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[] { new Guid("3e750e72-baaf-dcae-09f8-58958919c4f7"), null, new DateTimeOffset(new DateTime(2020, 10, 30, 1, 18, 11, 746, DateTimeKind.Unspecified).AddTicks(7929), new TimeSpan(0, 7, 0, 0, 0)), 9, 4, new DateTimeOffset(new DateTime(2020, 8, 6, 4, 33, 59, 583, DateTimeKind.Unspecified).AddTicks(1781), new TimeSpan(0, 7, 0, 0, 0)), "Carroll, Walter and Gerlach", 38.414614586818348m, new Guid("26a67ecd-6180-8d3b-fd52-41408b6939c3"), new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"), new Guid("f7895455-134e-0837-4c23-7ee0b56fdc08") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[] { new Guid("3fa48bde-c787-08ca-f634-04c6ceec6dfd"), null, new DateTimeOffset(new DateTime(2020, 2, 2, 3, 11, 44, 514, DateTimeKind.Unspecified).AddTicks(4701), new TimeSpan(0, 7, 0, 0, 0)), true, 9, 5, new DateTimeOffset(new DateTime(2020, 12, 12, 3, 59, 37, 488, DateTimeKind.Unspecified).AddTicks(3069), new TimeSpan(0, 7, 0, 0, 0)), "Shanahan - Zieme", 12.998753944876963m, new Guid("9c3b8b80-ec77-0d7d-387e-ebec94e998eb"), new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"), new Guid("67435822-9b61-64aa-9fd9-f78f1a58970f") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[,]
                {
                    { new Guid("3fd8f5fa-4f62-2ff9-5043-3e33fc7bef58"), null, new DateTimeOffset(new DateTime(2020, 7, 4, 8, 8, 24, 229, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 7, 0, 0, 0)), 10, 5, new DateTimeOffset(new DateTime(2020, 8, 19, 11, 36, 58, 308, DateTimeKind.Unspecified).AddTicks(7410), new TimeSpan(0, 7, 0, 0, 0)), "Greenfelder, Thompson and Hyatt", 76.469700617003143m, new Guid("88df2f3a-6795-d362-6d43-591ec672055d"), new Guid("754ae7f5-0365-4af8-7c83-951b2e30d982"), new Guid("3a7e3299-e0c5-5df7-64b0-a4a1a1b53962") },
                    { new Guid("4009c9b3-f618-5fff-134b-47a79f0fdc72"), null, new DateTimeOffset(new DateTime(2020, 11, 23, 7, 29, 7, 270, DateTimeKind.Unspecified).AddTicks(9886), new TimeSpan(0, 7, 0, 0, 0)), 5, 3, new DateTimeOffset(new DateTime(2020, 2, 25, 7, 54, 34, 127, DateTimeKind.Unspecified).AddTicks(4), new TimeSpan(0, 7, 0, 0, 0)), "Hagenes - Wolff", 57.315499264428184m, new Guid("88c74234-830e-5eb8-783e-185b933787f0"), new Guid("c57fd8b3-7dcc-83e2-69aa-a4108d4d026f"), new Guid("86f76dc2-3ca8-46e6-80ed-8168bd10e2e3") },
                    { new Guid("43a522de-b5ce-181d-f920-5e853754359a"), null, new DateTimeOffset(new DateTime(2020, 7, 22, 3, 52, 27, 481, DateTimeKind.Unspecified).AddTicks(6670), new TimeSpan(0, 7, 0, 0, 0)), 9, 5, new DateTimeOffset(new DateTime(2020, 7, 25, 6, 24, 36, 758, DateTimeKind.Unspecified).AddTicks(438), new TimeSpan(0, 7, 0, 0, 0)), "Corwin, Boyle and Kunze", 52.754276601017551m, new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new Guid("ab153a51-6d1e-d275-65d3-3d5c153a9787"), new Guid("4d8d10a4-6f02-8058-8923-f5bdcef26ed8") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[] { new Guid("51b355f6-95d6-d189-d290-b43e07fdb192"), null, new DateTimeOffset(new DateTime(2020, 3, 31, 9, 40, 57, 688, DateTimeKind.Unspecified).AddTicks(3151), new TimeSpan(0, 7, 0, 0, 0)), true, 7, 2, new DateTimeOffset(new DateTime(2020, 10, 28, 18, 0, 42, 947, DateTimeKind.Unspecified).AddTicks(2525), new TimeSpan(0, 7, 0, 0, 0)), "Haag - Bernhard", 17.591857570964764m, new Guid("3140208e-efb5-0baa-5dcf-f3688dfb49d4"), new Guid("d3626795-436d-1e59-c672-055d47c2ed18"), new Guid("25654813-d753-37ec-74d8-f5f4529d9bde") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[] { new Guid("5d7c09a1-50cf-c09e-103d-b97e2dac22f8"), null, new DateTimeOffset(new DateTime(2020, 4, 20, 22, 26, 17, 44, DateTimeKind.Unspecified).AddTicks(150), new TimeSpan(0, 7, 0, 0, 0)), 9, 4, new DateTimeOffset(new DateTime(2020, 10, 12, 12, 10, 13, 435, DateTimeKind.Unspecified).AddTicks(1562), new TimeSpan(0, 7, 0, 0, 0)), "Volkman, Bergstrom and Johns", 18.778735173763135m, new Guid("cce0516f-9f9f-f24f-f163-d6b684ab1f52"), new Guid("fc468bcc-b19c-0a0a-a2dc-4995e1e478b1"), new Guid("f3568c09-55f8-ac7e-442d-01fb2b510c8e") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[] { new Guid("5e390d4d-ab7e-34d9-d4ec-ef08c5ede18f"), null, new DateTimeOffset(new DateTime(2020, 1, 10, 16, 41, 18, 689, DateTimeKind.Unspecified).AddTicks(3662), new TimeSpan(0, 7, 0, 0, 0)), true, 6, 3, new DateTimeOffset(new DateTime(2020, 10, 18, 15, 35, 10, 115, DateTimeKind.Unspecified).AddTicks(1147), new TimeSpan(0, 7, 0, 0, 0)), "Medhurst LLC", 86.540180205619018m, new Guid("1c32f657-87c5-33dc-2dda-a177a4571d84"), new Guid("a740c595-1861-d57e-5224-f6098c56f3f8"), new Guid("ad659bb5-d5ce-14fa-8bef-7b2fa2d996de") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[] { new Guid("69caa284-6f54-050a-1ec3-6e9841ddbe45"), null, new DateTimeOffset(new DateTime(2020, 3, 30, 6, 7, 5, 223, DateTimeKind.Unspecified).AddTicks(106), new TimeSpan(0, 7, 0, 0, 0)), 7, 5, new DateTimeOffset(new DateTime(2020, 11, 1, 12, 47, 33, 994, DateTimeKind.Unspecified).AddTicks(3179), new TimeSpan(0, 7, 0, 0, 0)), "Hodkiewicz, Stiedemann and Cruickshank", 71.56295052429799m, new Guid("88c74234-830e-5eb8-783e-185b933787f0"), new Guid("2b65bc72-52ae-5087-1db8-b47d7fa37ad2"), new Guid("71b6972b-725e-d40d-66c3-4f8b85031295") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[] { new Guid("76309572-1c3d-0b0b-8d0b-44898d0b71ef"), null, new DateTimeOffset(new DateTime(2020, 12, 7, 8, 18, 24, 363, DateTimeKind.Unspecified).AddTicks(8622), new TimeSpan(0, 7, 0, 0, 0)), true, 10, 5, new DateTimeOffset(new DateTime(2020, 1, 1, 0, 21, 38, 302, DateTimeKind.Unspecified).AddTicks(6749), new TimeSpan(0, 7, 0, 0, 0)), "Bins - Hilpert", 90.753630254768656m, new Guid("78f7dc5f-0278-90bd-523a-268de4bc0e49"), new Guid("2495c693-e3b9-7c6f-3898-b7dd200bc116"), new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[] { new Guid("7b04bb20-cbba-8555-0d9a-5e5834745d1d"), null, new DateTimeOffset(new DateTime(2020, 10, 7, 19, 59, 32, 521, DateTimeKind.Unspecified).AddTicks(2581), new TimeSpan(0, 7, 0, 0, 0)), 10, 2, new DateTimeOffset(new DateTime(2020, 11, 6, 23, 49, 46, 928, DateTimeKind.Unspecified).AddTicks(8933), new TimeSpan(0, 7, 0, 0, 0)), "Jenkins - Hermann", 24.414798488102263m, new Guid("3ec9b182-31fc-749c-dd38-f3bcb0dede4d"), new Guid("14fad5ce-ef8b-2f7b-a2d9-96de815383b1"), new Guid("25654813-d753-37ec-74d8-f5f4529d9bde") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[,]
                {
                    { new Guid("7e9c4417-9abe-fd77-e589-9fecf460cd25"), null, new DateTimeOffset(new DateTime(2020, 5, 10, 9, 52, 24, 443, DateTimeKind.Unspecified).AddTicks(1500), new TimeSpan(0, 7, 0, 0, 0)), true, 6, 5, new DateTimeOffset(new DateTime(2020, 5, 22, 2, 52, 51, 291, DateTimeKind.Unspecified).AddTicks(849), new TimeSpan(0, 7, 0, 0, 0)), "Batz Inc", 46.995693918315526m, new Guid("18d34369-a53b-032e-483f-3773c3e7b578"), new Guid("b08b3ca5-2236-4358-6761-9baa649fd9f7"), new Guid("86f76dc2-3ca8-46e6-80ed-8168bd10e2e3") },
                    { new Guid("7eeca4f2-d4f4-da46-7745-00fb969be0df"), null, new DateTimeOffset(new DateTime(2020, 7, 19, 0, 4, 20, 333, DateTimeKind.Unspecified).AddTicks(5710), new TimeSpan(0, 7, 0, 0, 0)), true, 6, 1, new DateTimeOffset(new DateTime(2020, 6, 1, 11, 0, 5, 239, DateTimeKind.Unspecified).AddTicks(5528), new TimeSpan(0, 7, 0, 0, 0)), "Larson, Mraz and Smitham", 22.627855487460178m, new Guid("6f110748-4060-7943-3d81-f85d8b09c12c"), new Guid("9225cd84-cc3f-197a-0d9b-61826df2719f"), new Guid("2dbc398b-52a6-a98d-d070-fe5e751ab3d8") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[,]
                {
                    { new Guid("80243f7a-52a2-60fb-11bc-323115781a81"), null, new DateTimeOffset(new DateTime(2020, 9, 12, 14, 13, 46, 146, DateTimeKind.Unspecified).AddTicks(6727), new TimeSpan(0, 7, 0, 0, 0)), 7, 2, new DateTimeOffset(new DateTime(2020, 4, 13, 2, 59, 59, 940, DateTimeKind.Unspecified).AddTicks(6612), new TimeSpan(0, 7, 0, 0, 0)), "Langosh - Mueller", 84.034632707030818m, new Guid("3ec9b182-31fc-749c-dd38-f3bcb0dede4d"), new Guid("e07e234c-6fb5-08dc-5b8c-438fffa9361b"), new Guid("62b12191-f9c9-e502-08cf-118995c540a7") },
                    { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), null, new DateTimeOffset(new DateTime(2020, 3, 16, 11, 24, 16, 769, DateTimeKind.Unspecified).AddTicks(6003), new TimeSpan(0, 7, 0, 0, 0)), 6, 4, new DateTimeOffset(new DateTime(2020, 9, 10, 13, 18, 25, 634, DateTimeKind.Unspecified).AddTicks(1648), new TimeSpan(0, 7, 0, 0, 0)), "Wiegand, Botsford and Crooks", 38.81513669286628m, new Guid("4e7220ff-01af-050f-260e-566ab34b8a58"), new Guid("602b2f40-79ee-53b4-e390-36dfc79c1897"), new Guid("d42c9ec7-fda1-1681-fa3d-097e66c5fd01") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[,]
                {
                    { new Guid("83e4f60e-ea2b-f473-73f6-909e673cbdeb"), null, new DateTimeOffset(new DateTime(2020, 4, 4, 22, 32, 5, 291, DateTimeKind.Unspecified).AddTicks(1707), new TimeSpan(0, 7, 0, 0, 0)), true, 10, 3, new DateTimeOffset(new DateTime(2020, 4, 21, 3, 21, 1, 264, DateTimeKind.Unspecified).AddTicks(959), new TimeSpan(0, 7, 0, 0, 0)), "Kilback - Dibbert", 33.546049142510629m, new Guid("f4e4bdec-d0c1-62a7-fb99-0355c25a4a9d"), new Guid("5fac0bab-9b1e-2b3f-cd52-f09e51d49ea8"), new Guid("40179df0-b9b7-ccb0-8b46-fc9cb10a0aa2") },
                    { new Guid("8891162f-8813-026d-bc01-44d5e3922476"), null, new DateTimeOffset(new DateTime(2020, 7, 14, 15, 46, 20, 120, DateTimeKind.Unspecified).AddTicks(6540), new TimeSpan(0, 7, 0, 0, 0)), true, 9, 3, new DateTimeOffset(new DateTime(2020, 10, 11, 5, 37, 5, 693, DateTimeKind.Unspecified).AddTicks(7240), new TimeSpan(0, 7, 0, 0, 0)), "Mills, Yost and Connelly", 40.382244220647097m, new Guid("fa1681fd-093d-667e-c5fd-012c2fc33394"), new Guid("1cc2cfcb-de45-52b6-90a9-53a9fb007f94"), new Guid("d354372e-f04c-d28b-e2e7-d40211337a1c") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[] { new Guid("8f4ff836-e126-dbd5-09b3-1f3e8190949c"), null, new DateTimeOffset(new DateTime(2020, 9, 20, 11, 36, 27, 384, DateTimeKind.Unspecified).AddTicks(5071), new TimeSpan(0, 7, 0, 0, 0)), 8, 4, new DateTimeOffset(new DateTime(2020, 8, 18, 6, 24, 6, 102, DateTimeKind.Unspecified).AddTicks(8087), new TimeSpan(0, 7, 0, 0, 0)), "Parisian Group", 97.409943337277449m, new Guid("cce0516f-9f9f-f24f-f163-d6b684ab1f52"), new Guid("72d6a72b-0a05-898f-22cd-5b94c9155554"), new Guid("a2e64313-e8a4-bda0-6c2b-a7d672050a8f") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[,]
                {
                    { new Guid("92dc29c8-1055-fe68-1b1c-1fa97be8cebd"), null, new DateTimeOffset(new DateTime(2020, 6, 3, 19, 15, 0, 433, DateTimeKind.Unspecified).AddTicks(3968), new TimeSpan(0, 7, 0, 0, 0)), true, 9, 4, new DateTimeOffset(new DateTime(2020, 9, 26, 15, 58, 47, 538, DateTimeKind.Unspecified).AddTicks(1252), new TimeSpan(0, 7, 0, 0, 0)), "Lakin, Ryan and Gulgowski", 91.803146950808875m, new Guid("883f6641-68e4-d729-affb-e4c4535dc8e2"), new Guid("89504ad9-0785-2b68-0d58-8f71c7d88de8"), new Guid("d354372e-f04c-d28b-e2e7-d40211337a1c") },
                    { new Guid("967ad428-ade0-4670-63df-2293f92710bd"), null, new DateTimeOffset(new DateTime(2020, 2, 14, 2, 5, 58, 437, DateTimeKind.Unspecified).AddTicks(3807), new TimeSpan(0, 7, 0, 0, 0)), true, 7, 2, new DateTimeOffset(new DateTime(2020, 9, 4, 5, 16, 19, 951, DateTimeKind.Unspecified).AddTicks(940), new TimeSpan(0, 7, 0, 0, 0)), "Jenkins - Kessler", 53.691436822848175m, new Guid("7f5038db-db10-9886-e48c-3e1f519a4cfc"), new Guid("f694ea54-f527-eed5-e010-5eca808b3b9c"), new Guid("60447f7b-fee5-ba9d-8dcd-411f2c0793b7") },
                    { new Guid("9b5b2c85-3033-3987-b842-af9ad2f401ee"), null, new DateTimeOffset(new DateTime(2020, 5, 20, 20, 23, 12, 708, DateTimeKind.Unspecified).AddTicks(2046), new TimeSpan(0, 7, 0, 0, 0)), true, 10, 5, new DateTimeOffset(new DateTime(2020, 3, 17, 15, 32, 25, 420, DateTimeKind.Unspecified).AddTicks(7353), new TimeSpan(0, 7, 0, 0, 0)), "Pollich LLC", 86.255903793618019m, new Guid("89b78bdb-be24-151c-31f7-e7421644e19f"), new Guid("3f9f750c-38ab-aaa4-4eb4-7f55421996b8"), new Guid("a8ffd52a-3d62-ea5c-e177-a771279a4944") },
                    { new Guid("9c6f8f96-22b1-289a-c54b-5e4dfdad5164"), null, new DateTimeOffset(new DateTime(2020, 4, 22, 0, 20, 6, 891, DateTimeKind.Unspecified).AddTicks(5432), new TimeSpan(0, 7, 0, 0, 0)), true, 6, 3, new DateTimeOffset(new DateTime(2020, 1, 10, 17, 37, 45, 14, DateTimeKind.Unspecified).AddTicks(298), new TimeSpan(0, 7, 0, 0, 0)), "Conroy, Shields and Haley", 65.910348575054884m, new Guid("335ac148-c512-5b69-ffda-43761a02659d"), new Guid("69680ceb-a2ec-41e6-f64f-828aa45d905a"), new Guid("ad0e2ced-74dc-76db-8864-6ffd2dc498c6") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[,]
                {
                    { new Guid("9ca00e7a-c1e3-6c17-e48e-824e0221be0f"), null, new DateTimeOffset(new DateTime(2020, 8, 9, 9, 3, 46, 841, DateTimeKind.Unspecified).AddTicks(5528), new TimeSpan(0, 7, 0, 0, 0)), 9, 2, new DateTimeOffset(new DateTime(2020, 11, 5, 4, 1, 10, 454, DateTimeKind.Unspecified).AddTicks(6504), new TimeSpan(0, 7, 0, 0, 0)), "Hermann LLC", 17.77330140432958m, new Guid("cce0516f-9f9f-f24f-f163-d6b684ab1f52"), new Guid("2f96af49-0c5f-aae2-4230-9edddf13c915"), new Guid("54f608ca-598f-a8ca-8e37-a92300d6a440") },
                    { new Guid("a272346f-6e7b-3bd0-6c34-9e210a9a58f9"), null, new DateTimeOffset(new DateTime(2020, 5, 26, 9, 16, 9, 857, DateTimeKind.Unspecified).AddTicks(8006), new TimeSpan(0, 7, 0, 0, 0)), 8, 2, new DateTimeOffset(new DateTime(2020, 2, 1, 2, 22, 3, 42, DateTimeKind.Unspecified).AddTicks(9316), new TimeSpan(0, 7, 0, 0, 0)), "Brekke LLC", 51.86742618813526m, new Guid("88df2f3a-6795-d362-6d43-591ec672055d"), new Guid("ac34660c-972b-71b6-5e72-0dd466c34f8b"), new Guid("60447f7b-fee5-ba9d-8dcd-411f2c0793b7") },
                    { new Guid("a5eda47f-1114-87ff-6f4f-f1601aa53201"), null, new DateTimeOffset(new DateTime(2020, 10, 11, 2, 6, 20, 760, DateTimeKind.Unspecified).AddTicks(4944), new TimeSpan(0, 7, 0, 0, 0)), 6, 5, new DateTimeOffset(new DateTime(2020, 12, 4, 11, 34, 51, 723, DateTimeKind.Unspecified).AddTicks(1068), new TimeSpan(0, 7, 0, 0, 0)), "Goldner - Huels", 80.313473184273361m, new Guid("6833ed3a-236f-0ee7-896b-1c4a69d03e78"), new Guid("53256548-ecd7-7437-d8f5-f4529d9bde35"), new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab") },
                    { new Guid("b307a8f1-8763-7935-2985-aef5229e12e8"), null, new DateTimeOffset(new DateTime(2020, 10, 20, 19, 1, 54, 4, DateTimeKind.Unspecified).AddTicks(7914), new TimeSpan(0, 7, 0, 0, 0)), 8, 3, new DateTimeOffset(new DateTime(2020, 6, 16, 9, 12, 53, 925, DateTimeKind.Unspecified).AddTicks(1276), new TimeSpan(0, 7, 0, 0, 0)), "Schamberger - Metz", 32.052976937057944m, new Guid("1d16222e-1f0e-1a0c-5815-5e539e98ce71"), new Guid("b05d30e7-c2f8-4c2f-7d7e-0b670a682b5a"), new Guid("f3568c09-55f8-ac7e-442d-01fb2b510c8e") },
                    { new Guid("b6d7f535-95f3-33b7-367d-cfee3eeb94b5"), null, new DateTimeOffset(new DateTime(2020, 2, 29, 0, 38, 29, 7, DateTimeKind.Unspecified).AddTicks(1912), new TimeSpan(0, 7, 0, 0, 0)), 8, 4, new DateTimeOffset(new DateTime(2020, 11, 21, 12, 27, 16, 15, DateTimeKind.Unspecified).AddTicks(8101), new TimeSpan(0, 7, 0, 0, 0)), "Lockman Group", 95.791983951251917m, new Guid("3ec9b182-31fc-749c-dd38-f3bcb0dede4d"), new Guid("6e2aad91-6981-9dd6-496e-5763a37c45fb"), new Guid("52ae2b65-5087-b81d-b47d-7fa37ad24f03") },
                    { new Guid("bfb312c3-362b-ec49-fcb7-61f2db22d65c"), null, new DateTimeOffset(new DateTime(2020, 8, 7, 8, 58, 3, 422, DateTimeKind.Unspecified).AddTicks(1320), new TimeSpan(0, 7, 0, 0, 0)), 9, 4, new DateTimeOffset(new DateTime(2020, 11, 7, 0, 42, 20, 225, DateTimeKind.Unspecified).AddTicks(2492), new TimeSpan(0, 7, 0, 0, 0)), "Weissnat, Brakus and Langosh", 2.487427802517745m, new Guid("333a1cdf-9180-489a-54b3-b6f44bf638e2"), new Guid("edef5f70-0e2c-dcad-74db-7688646ffd2d"), new Guid("3313ce27-d248-29a8-fd66-c566826226cd") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[,]
                {
                    { new Guid("d50616cd-e87d-fb90-4c81-972b768dde09"), null, new DateTimeOffset(new DateTime(2020, 3, 11, 5, 29, 39, 58, DateTimeKind.Unspecified).AddTicks(5282), new TimeSpan(0, 7, 0, 0, 0)), true, 6, 1, new DateTimeOffset(new DateTime(2020, 7, 9, 16, 50, 18, 811, DateTimeKind.Unspecified).AddTicks(6833), new TimeSpan(0, 7, 0, 0, 0)), "Okuneva and Sons", 1.56143352881140723m, new Guid("cf08e502-8911-c595-40a7-61187ed55224"), new Guid("8c223896-e751-0945-eb80-f68b20142b12"), new Guid("b1f8c222-9565-8099-0ff9-8b293b957e2d") },
                    { new Guid("d68b7c23-85f9-8075-e44c-4687d3b0fee0"), null, new DateTimeOffset(new DateTime(2020, 9, 30, 23, 2, 17, 995, DateTimeKind.Unspecified).AddTicks(6825), new TimeSpan(0, 7, 0, 0, 0)), true, 9, 4, new DateTimeOffset(new DateTime(2020, 2, 13, 14, 52, 23, 863, DateTimeKind.Unspecified).AddTicks(905), new TimeSpan(0, 7, 0, 0, 0)), "Lind Inc", 38.119178496356704m, new Guid("26a67ecd-6180-8d3b-fd52-41408b6939c3"), new Guid("35498364-2209-f8c2-b165-9599800ff98b"), new Guid("86f76dc2-3ca8-46e6-80ed-8168bd10e2e3") },
                    { new Guid("d8ba0acf-0390-1c22-d57c-1ed83e20da2d"), null, new DateTimeOffset(new DateTime(2020, 8, 16, 9, 23, 9, 161, DateTimeKind.Unspecified).AddTicks(5816), new TimeSpan(0, 7, 0, 0, 0)), true, 5, 5, new DateTimeOffset(new DateTime(2020, 10, 20, 22, 2, 56, 392, DateTimeKind.Unspecified).AddTicks(9513), new TimeSpan(0, 7, 0, 0, 0)), "Grady Inc", 69.318451256173822m, new Guid("1c32f657-87c5-33dc-2dda-a177a4571d84"), new Guid("3f5dfa6f-bbef-f955-f750-e56dce5a4d97"), new Guid("15d6a64d-3c92-41f9-295a-5fc931444a0a") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[,]
                {
                    { new Guid("ecfd54e4-0562-714b-50c5-b3c9c135e33c"), null, new DateTimeOffset(new DateTime(2020, 5, 9, 18, 14, 58, 595, DateTimeKind.Unspecified).AddTicks(6394), new TimeSpan(0, 7, 0, 0, 0)), 9, 1, new DateTimeOffset(new DateTime(2020, 8, 19, 4, 25, 37, 809, DateTimeKind.Unspecified).AddTicks(3958), new TimeSpan(0, 7, 0, 0, 0)), "Klocko Group", 57.932322550999192m, new Guid("3ece3fb3-867d-a0ec-c08c-c4d7a942e500"), new Guid("9433c32f-2762-2724-ce13-3348d2a829fd"), new Guid("3313ce27-d248-29a8-fd66-c566826226cd") },
                    { new Guid("f0e4e673-9791-2674-c3e7-318835ff3826"), null, new DateTimeOffset(new DateTime(2020, 7, 17, 14, 6, 43, 743, DateTimeKind.Unspecified).AddTicks(7735), new TimeSpan(0, 7, 0, 0, 0)), 10, 5, new DateTimeOffset(new DateTime(2020, 2, 7, 23, 43, 58, 892, DateTimeKind.Unspecified).AddTicks(2776), new TimeSpan(0, 7, 0, 0, 0)), "Simonis - Maggio", 67.210269595128604m, new Guid("609afabf-efdb-fb3f-7207-2583625812b2"), new Guid("b43e0475-76b4-6bbc-f7a7-1f4c4773aee3"), new Guid("40179df0-b9b7-ccb0-8b46-fc9cb10a0aa2") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[] { new Guid("f1bc12e3-c49a-c11a-5ea9-86da5b57bd3f"), null, new DateTimeOffset(new DateTime(2020, 12, 9, 1, 9, 35, 339, DateTimeKind.Unspecified).AddTicks(2939), new TimeSpan(0, 7, 0, 0, 0)), true, 6, 3, new DateTimeOffset(new DateTime(2020, 7, 13, 3, 31, 21, 706, DateTimeKind.Unspecified).AddTicks(1543), new TimeSpan(0, 7, 0, 0, 0)), "Ryan - White", 13.131674546809708m, new Guid("31c8786a-f2fa-ab7a-0bac-5f1e9b3f2bcd"), new Guid("39fa5661-2eba-2269-1baa-fed1aa195356"), new Guid("f5f00e35-4ae7-6575-03f8-4a7c83951b2e") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[] { new Guid("f5f85426-4a96-102b-b370-6c47f097c2da"), null, new DateTimeOffset(new DateTime(2020, 7, 7, 10, 58, 11, 19, DateTimeKind.Unspecified).AddTicks(5326), new TimeSpan(0, 7, 0, 0, 0)), 6, 3, new DateTimeOffset(new DateTime(2020, 7, 30, 7, 51, 30, 314, DateTimeKind.Unspecified).AddTicks(8410), new TimeSpan(0, 7, 0, 0, 0)), "Collier, Funk and D'Amore", 76.427007250686652m, new Guid("60e01340-3a21-225b-1cfd-f38583c3b73c"), new Guid("e6a9f246-6c93-6962-33ef-855ab90a53b0"), new Guid("df8b1dd6-47d6-6f87-fa5d-3fefbb55f9f7") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WalletId", "WardId" },
                values: new object[,]
                {
                    { new Guid("f8c04973-8c15-fad4-da69-c16372e3e554"), null, new DateTimeOffset(new DateTime(2020, 4, 12, 12, 34, 41, 896, DateTimeKind.Unspecified).AddTicks(3530), new TimeSpan(0, 7, 0, 0, 0)), true, 9, 5, new DateTimeOffset(new DateTime(2020, 5, 28, 3, 47, 17, 649, DateTimeKind.Unspecified).AddTicks(2296), new TimeSpan(0, 7, 0, 0, 0)), "Stiedemann Inc", 78.751091507613238m, new Guid("1c32f657-87c5-33dc-2dda-a177a4571d84"), new Guid("3f6d13d5-a7c2-18f5-e07e-9b5202b062f6"), new Guid("0c666a36-75bf-3e04-b4b4-76bc6bf7a71f") },
                    { new Guid("fc782382-6898-3940-dec5-4409f8c4fa93"), null, new DateTimeOffset(new DateTime(2020, 10, 28, 1, 45, 29, 104, DateTimeKind.Unspecified).AddTicks(8005), new TimeSpan(0, 7, 0, 0, 0)), true, 7, 3, new DateTimeOffset(new DateTime(2020, 5, 31, 7, 11, 43, 52, DateTimeKind.Unspecified).AddTicks(2303), new TimeSpan(0, 7, 0, 0, 0)), "Gulgowski and Sons", 23.625873812300077m, new Guid("f3dcdac7-43a2-0adf-530c-9653f4b2c78d"), new Guid("ad322849-cf01-9ec7-2cd4-a1fd8116fa3d"), new Guid("a2e64313-e8a4-bda0-6c2b-a7d672050a8f") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("022b0a9c-ade3-e2c5-5965-1d09f1ff000d"), 703.60m, new Guid("6fed2434-4cfa-a569-b03b-d8cdc1c06247"), new DateTimeOffset(new DateTime(2020, 2, 9, 11, 14, 2, 130, DateTimeKind.Unspecified).AddTicks(853), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9ef052cd-d451-a89e-0515-b413c4587a03"), "Non at aliquam et.", true, new DateTimeOffset(new DateTime(2020, 4, 30, 15, 16, 41, 409, DateTimeKind.Unspecified).AddTicks(8424), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("1b95837c-302e-82d9-d3e3-5c19fca249af"), new Guid("602b2f40-79ee-53b4-e390-36dfc79c1897") },
                    { new Guid("030f5a58-a7ac-b018-f69d-1b2122d384ac"), 143.43m, new Guid("bb95c85e-2a0d-daf5-4042-df1c3a338091"), new DateTimeOffset(new DateTime(2020, 3, 27, 15, 26, 0, 285, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 7, 0, 0, 0)), new Guid("35f65d2c-7cfe-378d-40a4-6990103e9553"), "Facere illum voluptate sed nostrum harum maiores autem sit illo.", true, new DateTimeOffset(new DateTime(2020, 1, 9, 6, 14, 50, 548, DateTimeKind.Unspecified).AddTicks(3082), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("89b78bdb-be24-151c-31f7-e7421644e19f"), new Guid("53256548-ecd7-7437-d8f5-f4529d9bde35") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("07858950-2b68-580d-8f71-c7d88de8e7b5"), 943.23m, new Guid("83178de0-bde3-b552-9b65-adced5fa148b"), new DateTimeOffset(new DateTime(2020, 3, 24, 20, 52, 15, 311, DateTimeKind.Unspecified).AddTicks(3062), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d57e1861-2452-09f6-8c56-f3f8557eac44"), "Commodi sit nostrum doloremque natus dolor praesentium.", new DateTimeOffset(new DateTime(2020, 10, 13, 14, 27, 47, 15, DateTimeKind.Unspecified).AddTicks(6990), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("89b78bdb-be24-151c-31f7-e7421644e19f"), new Guid("72d6a72b-0a05-898f-22cd-5b94c9155554") },
                    { new Guid("10e0eed5-ca5e-8b80-3b9c-77ec7d0d387e"), 820.27m, new Guid("4ff641e6-8a82-5da4-905a-b4812ddcd875"), new DateTimeOffset(new DateTime(2020, 3, 19, 11, 48, 45, 194, DateTimeKind.Unspecified).AddTicks(3458), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d27aa37f-034f-ce19-64c7-57c651b6c26d"), "Qui non sed fuga doloribus.", new DateTimeOffset(new DateTime(2020, 1, 17, 18, 19, 32, 227, DateTimeKind.Unspecified).AddTicks(6697), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("cf08e502-8911-c595-40a7-61187ed55224"), new Guid("a740c595-1861-d57e-5224-f6098c56f3f8") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("122a97a1-f7c4-f517-d8b8-6d416f55c34a"), 379.09m, new Guid("e4513bd5-cac7-1b59-239d-c5acd311c12b"), new DateTimeOffset(new DateTime(2020, 10, 1, 6, 8, 19, 529, DateTimeKind.Unspecified).AddTicks(7088), new TimeSpan(0, 7, 0, 0, 0)), new Guid("61cb6c4e-d08c-e867-a5e9-d2d209173f4e"), "Ad labore laborum veritatis corrupti repellendus.", true, new DateTimeOffset(new DateTime(2020, 3, 20, 23, 13, 11, 163, DateTimeKind.Unspecified).AddTicks(2525), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("335ac148-c512-5b69-ffda-43761a02659d"), new Guid("b05d30e7-c2f8-4c2f-7d7e-0b670a682b5a") },
                    { new Guid("19aad1fe-5653-b064-e414-5d3dcc3f8970"), 606.44m, new Guid("b43c1f24-e7fa-273e-9610-060865806035"), new DateTimeOffset(new DateTime(2020, 10, 25, 19, 57, 28, 344, DateTimeKind.Unspecified).AddTicks(7439), new TimeSpan(0, 7, 0, 0, 0)), new Guid("71b6972b-725e-d40d-66c3-4f8b85031295"), "Rerum omnis reprehenderit dolores et quis.", true, new DateTimeOffset(new DateTime(2020, 1, 22, 21, 25, 55, 196, DateTimeKind.Unspecified).AddTicks(6296), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("1c32f657-87c5-33dc-2dda-a177a4571d84"), new Guid("b651c657-6dc2-86f7-a83c-e64680ed8168") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("1c32f657-87c5-33dc-2dda-a177a4571d84"), 939.44m, new Guid("bf3af6cf-1c49-d45e-0f73-96b51c2c318c"), new DateTimeOffset(new DateTime(2020, 6, 7, 22, 38, 2, 599, DateTimeKind.Unspecified).AddTicks(1503), new TimeSpan(0, 7, 0, 0, 0)), new Guid("49d8d35e-7c9f-8de0-1783-e3bd52b59b65"), "Nulla nobis et ut ut non ut sit suscipit.", new DateTimeOffset(new DateTime(2020, 12, 31, 22, 35, 20, 689, DateTimeKind.Unspecified).AddTicks(7086), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("18d34369-a53b-032e-483f-3773c3e7b578"), new Guid("2cc304c0-f65d-fe35-7c8d-3740a4699010") },
                    { new Guid("1e5fac0b-3f9b-cd2b-52f0-9e51d49ea805"), 926.13m, new Guid("aaa438ab-b44e-557f-4219-96b8a364698d"), new DateTimeOffset(new DateTime(2020, 12, 2, 7, 59, 45, 228, DateTimeKind.Unspecified).AddTicks(5519), new TimeSpan(0, 7, 0, 0, 0)), new Guid("ee602b2f-b479-e353-9036-dfc79c18976a"), "Fuga quaerat sit laudantium id.", new DateTimeOffset(new DateTime(2020, 4, 14, 1, 24, 6, 981, DateTimeKind.Unspecified).AddTicks(1165), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("883f6641-68e4-d729-affb-e4c4535dc8e2"), new Guid("b43e0475-76b4-6bbc-f7a7-1f4c4773aee3") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("20c9a600-801c-9df0-1740-b7b9b0cc8b46"), 104.33m, new Guid("f7e0c53a-645d-a4b0-a1a1-b5396254ea94"), new DateTimeOffset(new DateTime(2020, 2, 9, 1, 36, 7, 503, DateTimeKind.Unspecified).AddTicks(1793), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9a2771a7-4449-f54d-62d9-b0a724366a66"), "Ipsam nobis ex beatae earum iure fuga eveniet placeat.", true, new DateTimeOffset(new DateTime(2020, 11, 22, 4, 33, 39, 260, DateTimeKind.Unspecified).AddTicks(5363), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("f046ac78-05d2-c7c1-40ea-bf733a9492ed"), new Guid("0c512bfb-868e-3e86-eded-bd69d81343e6") },
                    { new Guid("275c2783-b68e-7db1-3ef2-0f18e430ad7b"), 18.39m, new Guid("38dfb793-9a5c-1946-abd6-1d8bdfd64787"), new DateTimeOffset(new DateTime(2020, 9, 8, 6, 3, 51, 648, DateTimeKind.Unspecified).AddTicks(6833), new TimeSpan(0, 7, 0, 0, 0)), new Guid("2b94bacd-417a-aaf6-249c-e7305db0f8c2"), "Voluptatem minus alias incidunt fuga repudiandae ut.", true, new DateTimeOffset(new DateTime(2020, 12, 10, 22, 17, 30, 126, DateTimeKind.Unspecified).AddTicks(4141), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("88df2f3a-6795-d362-6d43-591ec672055d"), new Guid("53256548-ecd7-7437-d8f5-f4529d9bde35") },
                    { new Guid("28cd4ee9-df95-ff80-ff97-7fca08f6548f"), 184.87m, new Guid("e353b479-3690-c7df-9c18-976a78c831fa"), new DateTimeOffset(new DateTime(2020, 7, 27, 23, 5, 39, 258, DateTimeKind.Unspecified).AddTicks(5218), new TimeSpan(0, 7, 0, 0, 0)), new Guid("cd4ee9d2-9528-80df-ffff-977fca08f654"), "Rerum pariatur magnam tenetur nihil architecto ipsam occaecati maxime.", true, new DateTimeOffset(new DateTime(2020, 5, 11, 2, 14, 21, 877, DateTimeKind.Unspecified).AddTicks(3781), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("60e01340-3a21-225b-1cfd-f38583c3b73c"), new Guid("9225cd84-cc3f-197a-0d9b-61826df2719f") },
                    { new Guid("33c32f2c-6294-2427-27ce-133348d2a829"), 285.17m, new Guid("7b5c0804-9799-0f69-47fb-03e9ce3b6577"), new DateTimeOffset(new DateTime(2020, 7, 10, 3, 49, 13, 370, DateTimeKind.Unspecified).AddTicks(9516), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9cfc468b-0ab1-a20a-dc49-95e1e478b199"), "Ad sit est.", true, new DateTimeOffset(new DateTime(2020, 12, 7, 18, 11, 18, 178, DateTimeKind.Unspecified).AddTicks(1665), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("335ac148-c512-5b69-ffda-43761a02659d"), new Guid("d405fcc9-5e97-d8d3-499f-7ce08d1783e3") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("37778a15-5d58-4813-6525-53d7ec3774d8"), 351.42m, new Guid("507d6540-c550-bdb9-58e5-e1a445366631"), new DateTimeOffset(new DateTime(2020, 1, 19, 21, 10, 47, 394, DateTimeKind.Unspecified).AddTicks(5526), new TimeSpan(0, 7, 0, 0, 0)), new Guid("914042cc-dafa-ffd7-358d-04ae36c7ca60"), "Eum non cupiditate a provident.", new DateTimeOffset(new DateTime(2020, 8, 16, 16, 41, 46, 561, DateTimeKind.Unspecified).AddTicks(3937), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("4e7220ff-01af-050f-260e-566ab34b8a58"), new Guid("b651c657-6dc2-86f7-a83c-e64680ed8168") },
                    { new Guid("4042cc3e-fa91-d7da-ff35-8d04ae36c7ca"), 714.22m, new Guid("c7cf01ad-2c9e-a1d4-fd81-16fa3d097e66"), new DateTimeOffset(new DateTime(2020, 12, 13, 9, 11, 54, 471, DateTimeKind.Unspecified).AddTicks(2558), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b1835381-0a6f-3558-0ef0-f5e74a756503"), "Rerum porro accusantium aliquam velit quos.", new DateTimeOffset(new DateTime(2020, 7, 21, 0, 27, 49, 307, DateTimeKind.Unspecified).AddTicks(1403), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("09157063-f7b9-3de0-5999-e058bfd294d2"), new Guid("fc468bcc-b19c-0a0a-a2dc-4995e1e478b1") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("41d8c209-3f66-e488-6829-d7affbe4c453"), 663.27m, new Guid("bfceb585-a8f3-16cf-cdba-942b7a41f6aa"), new DateTimeOffset(new DateTime(2020, 1, 8, 1, 48, 0, 77, DateTimeKind.Unspecified).AddTicks(5484), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d87437ec-f4f5-9d52-9bde-35a4eb67d140"), "Nisi non illo eos sed eos est nobis commodi voluptatibus.", true, new DateTimeOffset(new DateTime(2020, 12, 23, 6, 9, 16, 831, DateTimeKind.Unspecified).AddTicks(677), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("fa1681fd-093d-667e-c5fd-012c2fc33394"), new Guid("2e768de9-5437-4cd3-f08b-d2e2e7d40211") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("4206100c-318e-34ba-525e-7c82b1c93efc"), 662.90m, new Guid("5f5a2941-31c9-4a44-0a61-56fa39ba2e69"), new DateTimeOffset(new DateTime(2020, 6, 25, 22, 38, 45, 908, DateTimeKind.Unspecified).AddTicks(5111), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a2e64313-e8a4-bda0-6c2b-a7d672050a8f"), "Vel ipsa ut enim odit similique natus voluptatem et enim.", new DateTimeOffset(new DateTime(2020, 10, 12, 13, 38, 39, 382, DateTimeKind.Unspecified).AddTicks(9631), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("4e7220ff-01af-050f-260e-566ab34b8a58"), new Guid("9528cd4e-80df-ffff-977f-ca08f6548f59") },
                    { new Guid("487e1318-8926-dc97-7c4d-5a2e22161d0e"), 283.99m, new Guid("95ceb534-9906-3d08-05b4-056fad2672cc"), new DateTimeOffset(new DateTime(2020, 11, 18, 8, 43, 55, 142, DateTimeKind.Unspecified).AddTicks(8059), new TimeSpan(0, 7, 0, 0, 0)), new Guid("af4e7220-0f01-2605-0e56-6ab34b8a588c"), "Voluptas incidunt accusamus.", new DateTimeOffset(new DateTime(2020, 12, 31, 15, 46, 40, 575, DateTimeKind.Unspecified).AddTicks(190), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("88df2f3a-6795-d362-6d43-591ec672055d"), new Guid("e07e234c-6fb5-08dc-5b8c-438fffa9361b") },
                    { new Guid("49430def-902d-1b4e-f151-a934225bb3f4"), 686.03m, new Guid("d365d275-5c3d-3a15-9787-de8ded6a3a99"), new DateTimeOffset(new DateTime(2020, 4, 24, 14, 31, 53, 904, DateTimeKind.Unspecified).AddTicks(3217), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f2cebdf5-d86e-8d84-04bd-66760f9121b1"), "Consequatur expedita quidem doloremque libero.", new DateTimeOffset(new DateTime(2020, 9, 14, 23, 41, 43, 347, DateTimeKind.Unspecified).AddTicks(6497), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("26a67ecd-6180-8d3b-fd52-41408b6939c3"), new Guid("ac34660c-972b-71b6-5e72-0dd466c34f8b") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("4bf4b6b3-38f6-68e2-0600-f403e85ab410"), 154.27m, new Guid("b51df14c-3a1c-6aa4-7d9f-822ac2eed94c"), new DateTimeOffset(new DateTime(2020, 9, 21, 10, 22, 54, 680, DateTimeKind.Unspecified).AddTicks(954), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7feb6649-70fc-ef5f-ed2c-0eaddc74db76"), "Ut sunt eum.", true, new DateTimeOffset(new DateTime(2020, 4, 10, 19, 1, 41, 312, DateTimeKind.Unspecified).AddTicks(8063), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("88c74234-830e-5eb8-783e-185b933787f0"), new Guid("4042cc3e-fa91-d7da-ff35-8d04ae36c7ca") },
                    { new Guid("55bbef3f-f7f9-e550-6dce-5a4d978476ab"), 590.95m, new Guid("c61e5943-0572-475d-c2ed-18d762e5400b"), new DateTimeOffset(new DateTime(2020, 9, 11, 8, 8, 10, 513, DateTimeKind.Unspecified).AddTicks(3592), new TimeSpan(0, 7, 0, 0, 0)), new Guid("53c4e4fb-c85d-80e2-8ad9-652748a30f3c"), "Ratione autem et.", true, new DateTimeOffset(new DateTime(2020, 10, 18, 12, 44, 11, 421, DateTimeKind.Unspecified).AddTicks(2062), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("18d34369-a53b-032e-483f-3773c3e7b578"), new Guid("754ae7f5-0365-4af8-7c83-951b2e30d982") },
                    { new Guid("57cd73f6-e9a9-768d-2e37-54d34cf08bd2"), 858.58m, new Guid("ac34660c-972b-71b6-5e72-0dd466c34f8b"), new DateTimeOffset(new DateTime(2020, 8, 16, 19, 1, 51, 174, DateTimeKind.Unspecified).AddTicks(5915), new TimeSpan(0, 7, 0, 0, 0)), new Guid("2aad91df-816e-d669-9d49-6e5763a37c45"), "Rerum et omnis cupiditate aut.", true, new DateTimeOffset(new DateTime(2020, 2, 24, 22, 25, 44, 778, DateTimeKind.Unspecified).AddTicks(9717), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("6833ed3a-236f-0ee7-896b-1c4a69d03e78"), new Guid("3f9f750c-38ab-aaa4-4eb4-7f55421996b8") },
                    { new Guid("5b56ef22-52ec-d864-59e6-7c64aa80f861"), 828.96m, new Guid("951d01c8-0f73-33be-d62e-4dc85eed4438"), new DateTimeOffset(new DateTime(2020, 11, 23, 23, 19, 9, 617, DateTimeKind.Unspecified).AddTicks(4741), new TimeSpan(0, 7, 0, 0, 0)), new Guid("93072c1f-dfb7-5c38-9a46-19abd61d8bdf"), "Vero facere id asperiores placeat.", true, new DateTimeOffset(new DateTime(2020, 1, 24, 15, 50, 26, 832, DateTimeKind.Unspecified).AddTicks(5728), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("1c32f657-87c5-33dc-2dda-a177a4571d84"), new Guid("a740c595-1861-d57e-5224-f6098c56f3f8") },
                    { new Guid("5f702285-9be0-b426-2e79-e32f70dde1ba"), 940.99m, new Guid("80a4ba18-ba4a-6b60-5e7d-df7d9935d59a"), new DateTimeOffset(new DateTime(2020, 5, 16, 21, 45, 3, 923, DateTimeKind.Unspecified).AddTicks(4913), new TimeSpan(0, 7, 0, 0, 0)), new Guid("953b298b-2d7e-d55f-136d-3fc2a7f518e0"), "Nulla ipsum totam consequatur omnis beatae nam.", true, new DateTimeOffset(new DateTime(2020, 10, 7, 1, 4, 50, 205, DateTimeKind.Unspecified).AddTicks(1735), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("333a1cdf-9180-489a-54b3-b6f44bf638e2"), new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("62b12191-f9c9-e502-08cf-118995c540a7"), 89.14m, new Guid("2bfb012d-0c51-868e-863e-ededbd69d813"), new DateTimeOffset(new DateTime(2020, 6, 20, 18, 3, 17, 130, DateTimeKind.Unspecified).AddTicks(2827), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b5e07e23-dc6f-5b08-8c43-8fffa9361b81"), "Perspiciatis expedita aliquid dolorem et voluptatibus quidem doloribus tenetur quia.", new DateTimeOffset(new DateTime(2020, 11, 10, 23, 15, 48, 6, DateTimeKind.Unspecified).AddTicks(5378), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("1c32f657-87c5-33dc-2dda-a177a4571d84"), new Guid("3f5dfa6f-bbef-f955-f750-e56dce5a4d97") },
                    { new Guid("64bab395-4983-0935-22c2-f8b165959980"), 295.96m, new Guid("f5a7c23f-e018-9b7e-5202-b062f68e93af"), new DateTimeOffset(new DateTime(2020, 4, 17, 1, 57, 19, 303, DateTimeKind.Unspecified).AddTicks(5638), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6de550f7-5ace-974d-8476-ab3a2fdf8895"), "Molestias consectetur laboriosam voluptates.", new DateTimeOffset(new DateTime(2020, 2, 27, 14, 46, 6, 449, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("f29a2a8e-4d8b-a1cd-8c19-b674b6ff66b4"), new Guid("602b2f40-79ee-53b4-e390-36dfc79c1897") },
                    { new Guid("6d302f06-2a8e-f29a-8b4d-cda18c19b674"), 650.03m, new Guid("9b073640-dd34-cea5-c3ba-2cd8cece56fc"), new DateTimeOffset(new DateTime(2020, 1, 20, 15, 0, 44, 418, DateTimeKind.Unspecified).AddTicks(2514), new TimeSpan(0, 7, 0, 0, 0)), new Guid("e4e3def4-b2a1-c4a3-49f8-a662fe7e5157"), "Autem enim ipsa.", new DateTimeOffset(new DateTime(2020, 1, 30, 0, 59, 49, 871, DateTimeKind.Unspecified).AddTicks(4574), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("1233f8f5-32db-7367-7ee3-dac050c8d597"), new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f") },
                    { new Guid("8a362423-e4dd-38b9-a363-09e8fcc69301"), 785.13m, new Guid("c62fe184-919c-bc81-0855-94e2b7053499"), new DateTimeOffset(new DateTime(2020, 9, 29, 4, 36, 13, 472, DateTimeKind.Unspecified).AddTicks(3735), new TimeSpan(0, 7, 0, 0, 0)), new Guid("db033f39-57ce-32f6-1cc5-87dc332ddaa1"), "Magni quia voluptas in et vel.", new DateTimeOffset(new DateTime(2020, 2, 1, 10, 34, 48, 275, DateTimeKind.Unspecified).AddTicks(7022), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("a70e2abe-63c2-d3ef-4c81-3e6c0feb02be"), new Guid("edef5f70-0e2c-dcad-74db-7688646ffd2d") },
                    { new Guid("8d52a62d-d0a9-fe70-5e75-1ab3d87fc5cc"), 898.73m, new Guid("80586f02-2389-bdf5-cef2-6ed8848d04bd"), new DateTimeOffset(new DateTime(2020, 4, 22, 7, 40, 1, 142, DateTimeKind.Unspecified).AddTicks(8395), new TimeSpan(0, 7, 0, 0, 0)), new Guid("3a6aed8d-5a99-4edd-8327-5c278eb6b17d"), "Eum quasi eaque.", new DateTimeOffset(new DateTime(2020, 11, 25, 18, 3, 40, 322, DateTimeKind.Unspecified).AddTicks(1102), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("3140208e-efb5-0baa-5dcf-f3688dfb49d4"), new Guid("b43e0475-76b4-6bbc-f7a7-1f4c4773aee3") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("8e4ab0bb-8585-3fb3-ce3e-7d86eca0c08c"), 68.80m, new Guid("f3fadc6e-90d9-2eb7-46a8-70e9198a1a68"), new DateTimeOffset(new DateTime(2020, 3, 3, 15, 33, 50, 50, DateTimeKind.Unspecified).AddTicks(4111), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b8961942-64a3-8d69-d7fd-c7c3cbcfc21c"), "Ullam debitis deserunt tempora deserunt reprehenderit veritatis qui beatae consequatur.", true, new DateTimeOffset(new DateTime(2020, 12, 3, 1, 33, 14, 860, DateTimeKind.Unspecified).AddTicks(1406), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("7f5038db-db10-9886-e48c-3e1f519a4cfc"), new Guid("d3626795-436d-1e59-c672-055d47c2ed18") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("8ea9a6ab-4020-b531-efaa-0b5dcff3688d"), 340.21m, new Guid("18a6ddb1-a192-09d2-4383-93efd0ca3d58"), new DateTimeOffset(new DateTime(2020, 3, 16, 17, 53, 14, 337, DateTimeKind.Unspecified).AddTicks(4144), new TimeSpan(0, 7, 0, 0, 0)), new Guid("94ea5462-27f6-d5f5-eee0-105eca808b3b"), "Cum nemo ducimus eligendi.", new DateTimeOffset(new DateTime(2020, 4, 8, 6, 59, 58, 723, DateTimeKind.Unspecified).AddTicks(6021), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("97eb2ed4-df10-55bd-d364-a3db4a109f23"), new Guid("69680ceb-a2ec-41e6-f64f-828aa45d905a") },
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), 83.57m, new Guid("69626c93-ef33-5a85-b90a-53b0f5a84781"), new DateTimeOffset(new DateTime(2020, 7, 2, 1, 56, 13, 215, DateTimeKind.Unspecified).AddTicks(6503), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4206100c-318e-34ba-525e-7c82b1c93efc"), "Sit minus eveniet vel et.", new DateTimeOffset(new DateTime(2020, 1, 15, 1, 34, 11, 827, DateTimeKind.Unspecified).AddTicks(8059), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("fb7425eb-5298-bbd0-7d77-413ff692b4dc"), new Guid("72d6a72b-0a05-898f-22cd-5b94c9155554") },
                    { new Guid("97b5d36d-c630-542b-d79f-c1f4fe32674a"), 708.01m, new Guid("db164e00-c0de-d431-90de-3502965bb37c"), new DateTimeOffset(new DateTime(2020, 12, 30, 9, 58, 40, 129, DateTimeKind.Unspecified).AddTicks(2235), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f93c9215-2941-5f5a-c931-444a0a6156fa"), "Et dicta voluptas repellendus quia.", new DateTimeOffset(new DateTime(2020, 7, 10, 12, 35, 46, 929, DateTimeKind.Unspecified).AddTicks(2330), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("cf08e502-8911-c595-40a7-61187ed55224"), new Guid("2e768de9-5437-4cd3-f08b-d2e2e7d40211") },
                    { new Guid("a5e0035e-4fba-0070-a7f0-b154fde1fc18"), 437.19m, new Guid("fe35f65d-8d7c-4037-a469-90103e955372"), new DateTimeOffset(new DateTime(2020, 2, 22, 15, 33, 3, 129, DateTimeKind.Unspecified).AddTicks(4022), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d42c9ec7-fda1-1681-fa3d-097e66c5fd01"), "Commodi eaque est asperiores illum provident sunt ex.", new DateTimeOffset(new DateTime(2020, 10, 31, 9, 51, 23, 722, DateTimeKind.Unspecified).AddTicks(1758), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("f29a2a8e-4d8b-a1cd-8c19-b674b6ff66b4"), new Guid("fc468bcc-b19c-0a0a-a2dc-4995e1e478b1") },
                    { new Guid("aa9b6167-9f64-f7d9-8f1a-58970f789638"), 732.98m, new Guid("d537122b-642d-85d4-abd5-89e18ec580c8"), new DateTimeOffset(new DateTime(2020, 7, 12, 8, 29, 34, 78, DateTimeKind.Unspecified).AddTicks(4355), new TimeSpan(0, 7, 0, 0, 0)), new Guid("29a8d248-66fd-66c5-8262-26cdde04085c"), "Dolor debitis quisquam cupiditate quaerat possimus.", new DateTimeOffset(new DateTime(2020, 8, 22, 14, 2, 51, 750, DateTimeKind.Unspecified).AddTicks(5840), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("09157063-f7b9-3de0-5999-e058bfd294d2"), new Guid("c550507d-bdb9-e558-e1a4-45366631090c") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("ad91dfd5-6e2a-6981-d69d-496e5763a37c"), 595.94m, new Guid("25cd8427-3f92-7acc-190d-9b61826df271"), new DateTimeOffset(new DateTime(2020, 8, 4, 11, 17, 22, 754, DateTimeKind.Unspecified).AddTicks(5856), new TimeSpan(0, 7, 0, 0, 0)), new Guid("2f96af49-0c5f-aae2-4230-9edddf13c915"), "Cumque vero rerum illum.", true, new DateTimeOffset(new DateTime(2020, 1, 15, 15, 47, 35, 752, DateTimeKind.Unspecified).AddTicks(6317), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("31c8786a-f2fa-ab7a-0bac-5f1e9b3f2bcd"), new Guid("9225cd84-cc3f-197a-0d9b-61826df2719f") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("ae2b65bc-8752-1d50-b8b4-7d7fa37ad24f"), 927.40m, new Guid("81ed8046-bd68-e210-e3d1-cca53c8bb036"), new DateTimeOffset(new DateTime(2020, 7, 23, 23, 39, 33, 336, DateTimeKind.Unspecified).AddTicks(2445), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8bf680eb-1420-122b-37d5-2d64d485abd5"), "Ipsum provident deserunt a unde quidem ab consequatur architecto eum.", new DateTimeOffset(new DateTime(2020, 11, 1, 12, 44, 6, 853, DateTimeKind.Unspecified).AddTicks(1360), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("97eb2ed4-df10-55bd-d364-a3db4a109f23"), new Guid("2e768de9-5437-4cd3-f08b-d2e2e7d40211") },
                    { new Guid("af4e7220-0f01-2605-0e56-6ab34b8a588c"), 499.98m, new Guid("42bab6e5-def4-e4e3-a1b2-a3c449f8a662"), new DateTimeOffset(new DateTime(2020, 8, 13, 18, 19, 17, 625, DateTimeKind.Unspecified).AddTicks(7372), new TimeSpan(0, 7, 0, 0, 0)), new Guid("fe70d0a9-755e-b31a-d87f-c5cc7de28369"), "Repudiandae ea eligendi officia.", new DateTimeOffset(new DateTime(2020, 5, 19, 11, 26, 12, 641, DateTimeKind.Unspecified).AddTicks(1102), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("1b95837c-302e-82d9-d3e3-5c19fca249af"), new Guid("39fa5661-2eba-2269-1baa-fed1aa195356") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("b41e9ba8-71a4-7b18-0dfd-0318ea7471aa"), 914.69m, new Guid("2fb312ed-7f01-032d-d6c7-bf08c60ada4a"), new DateTimeOffset(new DateTime(2020, 3, 17, 13, 6, 22, 422, DateTimeKind.Unspecified).AddTicks(5169), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b35b2234-24f4-2054-ad1a-71ce513a15ab"), "Voluptas iste eos rerum magnam nihil.", true, new DateTimeOffset(new DateTime(2020, 4, 9, 17, 49, 37, 68, DateTimeKind.Unspecified).AddTicks(1039), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("6452ec5b-59d8-7ce6-64aa-80f861750375"), new Guid("b651c657-6dc2-86f7-a83c-e64680ed8168") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("bda0e8a4-2b6c-d6a7-7205-0a8f8922cd5b"), 453.12m, new Guid("6fb5e07e-08dc-8c5b-438f-ffa9361b817c"), new DateTimeOffset(new DateTime(2020, 6, 19, 20, 5, 33, 975, DateTimeKind.Unspecified).AddTicks(5038), new TimeSpan(0, 7, 0, 0, 0)), new Guid("cc3f9225-197a-9b0d-6182-6df2719fea1b"), "Suscipit repellat accusamus quisquam in omnis sit.", new DateTimeOffset(new DateTime(2020, 1, 27, 16, 55, 50, 381, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("f3dcdac7-43a2-0adf-530c-9653f4b2c78d"), new Guid("5fac0bab-9b1e-2b3f-cd52-f09e51d49ea8") },
                    { new Guid("bdd8753b-eb6d-3480-646a-2cfb19c131d2"), 269.46m, new Guid("3330ce78-39f6-d4cc-c9e7-f969e2787cf3"), new DateTimeOffset(new DateTime(2020, 1, 21, 21, 37, 13, 425, DateTimeKind.Unspecified).AddTicks(4598), new TimeSpan(0, 7, 0, 0, 0)), new Guid("06109627-6508-6080-35ad-238abbb04a8e"), "Explicabo labore rerum cum vel suscipit voluptates repellendus repellendus.", new DateTimeOffset(new DateTime(2020, 1, 1, 5, 9, 13, 58, DateTimeKind.Unspecified).AddTicks(5793), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("61674358-aa9b-9f64-d9f7-8f1a58970f78"), new Guid("d86ef2ce-8d84-bd04-6676-0f9121b162c9") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("c2cfcbc3-451c-b6de-5290-a953a9fb007f"), 817.12m, new Guid("dcad0e2c-db74-8876-646f-fd2dc498c6ec"), new DateTimeOffset(new DateTime(2020, 11, 28, 7, 24, 33, 743, DateTimeKind.Unspecified).AddTicks(7253), new TimeSpan(0, 7, 0, 0, 0)), new Guid("e6a2ec69-f641-824f-8aa4-5d905ab4812d"), "Sint vel assumenda eos dolores aperiam nemo veniam amet.", true, new DateTimeOffset(new DateTime(2020, 9, 22, 18, 47, 21, 152, DateTimeKind.Unspecified).AddTicks(7159), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("958622b0-9ce3-bd80-11a2-342663de9bee"), new Guid("b43e0475-76b4-6bbc-f7a7-1f4c4773aee3") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("d31c4457-74c3-ad4a-6e5d-d27963c16e2a"), 245.19m, new Guid("96997b4e-c94f-f6e3-cea9-307486cf393f"), new DateTimeOffset(new DateTime(2020, 10, 1, 8, 52, 42, 524, DateTimeKind.Unspecified).AddTicks(6167), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a9d7c48c-e542-6100-d98e-dd9402ebd05d"), "Non dolores qui qui in aut sequi a.", new DateTimeOffset(new DateTime(2020, 6, 24, 13, 47, 21, 814, DateTimeKind.Unspecified).AddTicks(4889), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("07f55f54-53db-bc35-fdb4-1e717d9a0efb"), new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("d52a2c37-a8ff-3d62-5cea-e177a771279a"), 510.61m, new Guid("75bf0c66-3e04-b4b4-76bc-6bf7a71f4c47"), new DateTimeOffset(new DateTime(2020, 10, 12, 10, 47, 18, 159, DateTimeKind.Unspecified).AddTicks(3036), new TimeSpan(0, 7, 0, 0, 0)), new Guid("3d5d14e4-3fcc-7089-9fe4-9d676b30922d"), "Rerum ullam dolores modi.", true, new DateTimeOffset(new DateTime(2020, 5, 13, 0, 24, 7, 623, DateTimeKind.Unspecified).AddTicks(7319), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("60e01340-3a21-225b-1cfd-f38583c3b73c"), new Guid("d405fcc9-5e97-d8d3-499f-7ce08d1783e3") },
                    { new Guid("de96d9a2-5381-b183-6f0a-58350ef0f5e7"), 70.98m, new Guid("a2fc195c-af49-2f96-5f0c-e2aa42309edd"), new DateTimeOffset(new DateTime(2020, 1, 20, 7, 42, 9, 565, DateTimeKind.Unspecified).AddTicks(9209), new TimeSpan(0, 7, 0, 0, 0)), new Guid("69626c93-ef33-5a85-b90a-53b0f5a84781"), "Atque natus porro pariatur dolorum laborum et doloribus et occaecati.", true, new DateTimeOffset(new DateTime(2020, 4, 2, 15, 14, 46, 882, DateTimeKind.Unspecified).AddTicks(6824), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("f046ac78-05d2-c7c1-40ea-bf733a9492ed"), new Guid("e189d5ab-c58e-c880-8b39-bc2da6528da9") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("df1097eb-55bd-64d3-a3db-4a109f23666b"), 11.04m, new Guid("7a647cf4-86de-48e8-fdde-1e2017543522"), new DateTimeOffset(new DateTime(2020, 8, 11, 6, 56, 14, 334, DateTimeKind.Unspecified).AddTicks(5153), new TimeSpan(0, 7, 0, 0, 0)), new Guid("0ae18c23-5a4e-0f8e-e3c1-25f2744b08ab"), "Quia tempora et hic culpa et ipsum quo nihil.", new DateTimeOffset(new DateTime(2020, 10, 18, 14, 0, 13, 916, DateTimeKind.Unspecified).AddTicks(6784), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("4e7220ff-01af-050f-260e-566ab34b8a58"), new Guid("b05d30e7-c2f8-4c2f-7d7e-0b670a682b5a") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("df7c5d15-2500-c7ae-6439-d5b0dd579f03"), 275.58m, new Guid("a147e5b6-1409-7309-52d3-3334fea5f3e3"), new DateTimeOffset(new DateTime(2020, 12, 20, 14, 27, 14, 741, DateTimeKind.Unspecified).AddTicks(802), new TimeSpan(0, 7, 0, 0, 0)), new Guid("36b08b3c-5822-6743-619b-aa649fd9f78f"), "Qui deleniti porro.", true, new DateTimeOffset(new DateTime(2020, 1, 13, 18, 20, 4, 308, DateTimeKind.Unspecified).AddTicks(7671), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("9c3b8b80-ec77-0d7d-387e-ebec94e998eb"), new Guid("c550507d-bdb9-e558-e1a4-45366631090c") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("e3958622-809c-11bd-a234-2663de9bee82"), 675.63m, new Guid("4e33388c-6ec3-d477-acb7-e3eb93b33828"), new DateTimeOffset(new DateTime(2020, 6, 20, 22, 39, 44, 122, DateTimeKind.Unspecified).AddTicks(356), new TimeSpan(0, 7, 0, 0, 0)), new Guid("5e9bf4a4-e003-baa5-4f70-00a7f0b154fd"), "Blanditiis nostrum tempore.", new DateTimeOffset(new DateTime(2020, 4, 15, 0, 6, 0, 32, DateTimeKind.Unspecified).AddTicks(2055), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("2667404a-245a-3ccc-8b84-6bcf135effe7"), new Guid("2e768de9-5437-4cd3-f08b-d2e2e7d40211") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("f4ce1a83-32f5-ed61-7e69-84c38a62f6f3"), 874.08m, new Guid("3d43bd8b-611b-f981-6b27-f458889dbfb2"), new DateTimeOffset(new DateTime(2020, 9, 4, 5, 55, 41, 304, DateTimeKind.Unspecified).AddTicks(6117), new TimeSpan(0, 7, 0, 0, 0)), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), "Tempore quia ratione neque ratione exercitationem est sit.", true, new DateTimeOffset(new DateTime(2020, 4, 11, 19, 8, 56, 495, DateTimeKind.Unspecified).AddTicks(4390), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("89b78bdb-be24-151c-31f7-e7421644e19f"), new Guid("602b2f40-79ee-53b4-e390-36dfc79c1897") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("f8b05d30-2fc2-7d4c-7e0b-670a682b5ace"), 157.14m, new Guid("084b74f2-88ab-d40c-bc0b-8fa62b500b66"), new DateTimeOffset(new DateTime(2020, 4, 20, 1, 46, 59, 676, DateTimeKind.Unspecified).AddTicks(8701), new TimeSpan(0, 7, 0, 0, 0)), new Guid("cd73f634-a957-8de9-762e-3754d34cf08b"), "Corrupti ut tempora maiores sapiente quas.", new DateTimeOffset(new DateTime(2020, 2, 25, 3, 15, 37, 511, DateTimeKind.Unspecified).AddTicks(1947), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("18d34369-a53b-032e-483f-3773c3e7b578"), new Guid("a740c595-1861-d57e-5224-f6098c56f3f8") },
                    { new Guid("fa4d9d8d-bfba-b0e0-5817-0205f5910bf9"), 523.05m, new Guid("a3fba1d5-1e52-9f33-be65-269180b8aaf5"), new DateTimeOffset(new DateTime(2020, 4, 6, 1, 39, 0, 120, DateTimeKind.Unspecified).AddTicks(3481), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b50b40e5-4ad9-8950-8507-682b0d588f71"), "Aut beatae ipsam amet et doloribus ullam et iusto.", new DateTimeOffset(new DateTime(2020, 1, 22, 9, 1, 9, 820, DateTimeKind.Unspecified).AddTicks(8796), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("88df2f3a-6795-d362-6d43-591ec672055d"), new Guid("b43e0475-76b4-6bbc-f7a7-1f4c4773aee3") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("01ad3228-c7cf-2c9e-d4a1-fd8116fa3d09"), new Guid("06278a51-2c88-111e-be6c-94ebbe9406f5"), new DateTimeOffset(new DateTime(2020, 12, 13, 9, 11, 54, 471, DateTimeKind.Unspecified).AddTicks(2558), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 21, 0, 27, 49, 307, DateTimeKind.Unspecified).AddTicks(1403), new TimeSpan(0, 7, 0, 0, 0)), new Guid("883f6641-68e4-d729-affb-e4c4535dc8e2") });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("0a0ab19c-dca2-9549-e1e4-78b199327e3a"), new Guid("8f4ff836-e126-dbd5-09b3-1f3e8190949c"), new DateTimeOffset(new DateTime(2020, 1, 22, 11, 23, 58, 503, DateTimeKind.Unspecified).AddTicks(6764), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 6, 23, 20, 31, 6, 504, DateTimeKind.Unspecified).AddTicks(6291), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1d16222e-1f0e-1a0c-5815-5e539e98ce71") });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("0a6fb183-3558-f00e-f5e7-4a756503f84a"), new Guid("7eeca4f2-d4f4-da46-7745-00fb969be0df"), new DateTimeOffset(new DateTime(2020, 4, 13, 17, 1, 0, 884, DateTimeKind.Unspecified).AddTicks(3627), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 24, 21, 38, 22, 83, DateTimeKind.Unspecified).AddTicks(9488), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1d16222e-1f0e-1a0c-5815-5e539e98ce71") });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("0b40e562-d9b5-504a-8985-07682b0d588f"), new Guid("2702e6e6-01b4-12c7-f857-2a2e74316200"), new DateTimeOffset(new DateTime(2020, 4, 4, 1, 57, 59, 158, DateTimeKind.Unspecified).AddTicks(5478), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 16, 11, 32, 50, 387, DateTimeKind.Unspecified).AddTicks(8566), new TimeSpan(0, 7, 0, 0, 0)), new Guid("059f0b6a-1940-021d-901e-108a95bc55cb") },
                    { new Guid("15c913df-778a-5837-5d13-48652553d7ec"), new Guid("d8ba0acf-0390-1c22-d57c-1ed83e20da2d"), new DateTimeOffset(new DateTime(2020, 9, 27, 12, 32, 36, 206, DateTimeKind.Unspecified).AddTicks(5096), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 9, 13, 7, 27, 36, 662, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 7, 0, 0, 0)), new Guid("fb7425eb-5298-bbd0-7d77-413ff692b4dc") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("1bea9f71-a600-20c9-1c80-f09d1740b7b9"), new Guid("7eeca4f2-d4f4-da46-7745-00fb969be0df"), new DateTimeOffset(new DateTime(2020, 1, 2, 22, 19, 36, 290, DateTimeKind.Unspecified).AddTicks(8878), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 20, 23, 2, 13, 133, DateTimeKind.Unspecified).AddTicks(9507), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f4e4bdec-d0c1-62a7-fb99-0355c25a4a9d") });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("23a9378e-d600-40a4-2f2b-60ee79b453e3"), new Guid("a5eda47f-1114-87ff-6f4f-f1601aa53201"), new DateTimeOffset(new DateTime(2020, 5, 8, 14, 10, 31, 325, DateTimeKind.Unspecified).AddTicks(779), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 10, 14, 15, 52, 36, 123, DateTimeKind.Unspecified).AddTicks(3623), new TimeSpan(0, 7, 0, 0, 0)), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") },
                    { new Guid("2cedef5f-ad0e-74dc-db76-88646ffd2dc4"), new Guid("967ad428-ade0-4670-63df-2293f92710bd"), new DateTimeOffset(new DateTime(2020, 5, 28, 3, 59, 23, 872, DateTimeKind.Unspecified).AddTicks(9311), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 11, 28, 7, 24, 33, 743, DateTimeKind.Unspecified).AddTicks(7253), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6833ed3a-236f-0ee7-896b-1c4a69d03e78") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("2dd53712-d464-ab85-d589-e18ec580c88b"), new Guid("69caa284-6f54-050a-1ec3-6e9841ddbe45"), new DateTimeOffset(new DateTime(2020, 6, 13, 1, 3, 53, 798, DateTimeKind.Unspecified).AddTicks(765), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 6, 20, 13, 18, 39, 4, DateTimeKind.Unspecified).AddTicks(6817), new TimeSpan(0, 7, 0, 0, 0)), new Guid("97eb2ed4-df10-55bd-d364-a3db4a109f23") });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("31663645-0c09-f634-73cd-57a9e98d762e"), new Guid("230d8922-1828-483c-7858-c33ace94d9e3"), new DateTimeOffset(new DateTime(2020, 11, 25, 5, 40, 38, 671, DateTimeKind.Unspecified).AddTicks(5671), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 9, 1, 7, 35, 16, 518, DateTimeKind.Unspecified).AddTicks(1913), new TimeSpan(0, 7, 0, 0, 0)), new Guid("fb7425eb-5298-bbd0-7d77-413ff692b4dc") },
                    { new Guid("329db5e7-fa1e-fcc9-05d4-975ed3d8499f"), new Guid("8891162f-8813-026d-bc01-44d5e3922476"), new DateTimeOffset(new DateTime(2020, 2, 22, 22, 1, 17, 802, DateTimeKind.Unspecified).AddTicks(3374), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 1, 31, 10, 15, 9, 302, DateTimeKind.Unspecified).AddTicks(522), new TimeSpan(0, 7, 0, 0, 0)), new Guid("333a1cdf-9180-489a-54b3-b6f44bf638e2") },
                    { new Guid("33c32f2c-6294-2427-27ce-133348d2a829"), new Guid("4009c9b3-f618-5fff-134b-47a79f0fdc72"), new DateTimeOffset(new DateTime(2020, 5, 9, 20, 45, 55, 481, DateTimeKind.Unspecified).AddTicks(9440), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 9, 24, 19, 33, 12, 457, DateTimeKind.Unspecified).AddTicks(6893), new TimeSpan(0, 7, 0, 0, 0)), new Guid("335ac148-c512-5b69-ffda-43761a02659d") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("41cd8dba-2c1f-9307-b7df-385c9a4619ab"), new Guid("f1bc12e3-c49a-c11a-5ea9-86da5b57bd3f"), new DateTimeOffset(new DateTime(2020, 5, 4, 3, 35, 35, 292, DateTimeKind.Unspecified).AddTicks(3871), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 9, 9, 15, 14, 43, 740, DateTimeKind.Unspecified).AddTicks(9573), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6833ed3a-236f-0ee7-896b-1c4a69d03e78") },
                    { new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"), new Guid("2702e6e6-01b4-12c7-f857-2a2e74316200"), new DateTimeOffset(new DateTime(2020, 8, 11, 16, 15, 36, 138, DateTimeKind.Unspecified).AddTicks(9716), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 5, 26, 12, 33, 31, 347, DateTimeKind.Unspecified).AddTicks(7113), new TimeSpan(0, 7, 0, 0, 0)), new Guid("60e01340-3a21-225b-1cfd-f38583c3b73c") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("438c5b08-ff8f-36a9-1b81-7cae63cbef0d"), new Guid("f0e4e673-9791-2674-c3e7-318835ff3826"), new DateTimeOffset(new DateTime(2020, 2, 7, 14, 50, 43, 347, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 6, 17, 23, 54, 58, 995, DateTimeKind.Unspecified).AddTicks(4366), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7f5038db-db10-9886-e48c-3e1f519a4cfc") });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("4ee9d2ad-28cd-df95-80ff-ff977fca08f6"), new Guid("21a19a75-c397-f2f7-c138-1c350582a9e4"), new DateTimeOffset(new DateTime(2020, 1, 10, 18, 18, 41, 979, DateTimeKind.Unspecified).AddTicks(989), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 28, 17, 20, 18, 260, DateTimeKind.Unspecified).AddTicks(2219), new TimeSpan(0, 7, 0, 0, 0)), new Guid("3ec9b182-31fc-749c-dd38-f3bcb0dede4d") });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("568c09f6-f8f3-7e55-ac44-2d01fb2b510c"), new Guid("5d7c09a1-50cf-c09e-103d-b97e2dac22f8"), new DateTimeOffset(new DateTime(2020, 11, 14, 2, 51, 15, 357, DateTimeKind.Unspecified).AddTicks(1856), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 10, 12, 6, 44, 36, 651, DateTimeKind.Unspecified).AddTicks(734), new TimeSpan(0, 7, 0, 0, 0)), new Guid("78f7dc5f-0278-90bd-523a-268de4bc0e49") },
                    { new Guid("586f024d-8980-f523-bdce-f26ed8848d04"), new Guid("a5eda47f-1114-87ff-6f4f-f1601aa53201"), new DateTimeOffset(new DateTime(2020, 11, 25, 18, 3, 40, 322, DateTimeKind.Unspecified).AddTicks(1102), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 3, 20, 15, 23, 15, 930, DateTimeKind.Unspecified).AddTicks(7765), new TimeSpan(0, 7, 0, 0, 0)), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") },
                    { new Guid("65d2756d-3dd3-155c-3a97-87de8ded6a3a"), new Guid("a5eda47f-1114-87ff-6f4f-f1601aa53201"), new DateTimeOffset(new DateTime(2020, 9, 14, 23, 41, 43, 347, DateTimeKind.Unspecified).AddTicks(6497), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 1, 19, 16, 20, 22, 899, DateTimeKind.Unspecified).AddTicks(7981), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f4e4bdec-d0c1-62a7-fb99-0355c25a4a9d") },
                    { new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"), new Guid("83e4f60e-ea2b-f473-73f6-909e673cbdeb"), new DateTimeOffset(new DateTime(2020, 12, 27, 18, 49, 42, 41, DateTimeKind.Unspecified).AddTicks(5112), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 3, 3, 22, 30, 55, 391, DateTimeKind.Unspecified).AddTicks(871), new TimeSpan(0, 7, 0, 0, 0)), new Guid("60e01340-3a21-225b-1cfd-f38583c3b73c") },
                    { new Guid("72ff2f81-65bc-ae2b-5287-501db8b47d7f"), new Guid("8891162f-8813-026d-bc01-44d5e3922476"), new DateTimeOffset(new DateTime(2020, 5, 6, 22, 53, 24, 287, DateTimeKind.Unspecified).AddTicks(8952), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 2, 15, 15, 19, 38, 590, DateTimeKind.Unspecified).AddTicks(6557), new TimeSpan(0, 7, 0, 0, 0)), new Guid("88df2f3a-6795-d362-6d43-591ec672055d") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("786a9718-31c8-f2fa-7aab-0bac5f1e9b3f"), new Guid("9ca00e7a-c1e3-6c17-e48e-824e0221be0f"), new DateTimeOffset(new DateTime(2020, 6, 28, 11, 32, 16, 86, DateTimeKind.Unspecified).AddTicks(6546), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 13, 7, 52, 50, 894, DateTimeKind.Unspecified).AddTicks(8104), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1b95837c-302e-82d9-d3e3-5c19fca249af") },
                    { new Guid("7ee018f5-529b-b002-62f6-8e93af65c0a8"), new Guid("f8c04973-8c15-fad4-da69-c16372e3e554"), new DateTimeOffset(new DateTime(2020, 9, 30, 22, 41, 15, 33, DateTimeKind.Unspecified).AddTicks(7936), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 4, 20, 1, 40, 911, DateTimeKind.Unspecified).AddTicks(265), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7f5038db-db10-9886-e48c-3e1f519a4cfc") },
                    { new Guid("88df2f3a-6795-d362-6d43-591ec672055d"), new Guid("1f1fc172-de8f-09d4-b2d2-48077225518c"), new DateTimeOffset(new DateTime(2020, 11, 20, 9, 53, 55, 655, DateTimeKind.Unspecified).AddTicks(6105), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 4, 3, 10, 26, 503, DateTimeKind.Unspecified).AddTicks(5474), new TimeSpan(0, 7, 0, 0, 0)), new Guid("31c8786a-f2fa-ab7a-0bac-5f1e9b3f2bcd") },
                    { new Guid("8a824ff6-5da4-5a90-b481-2ddcd8750729"), new Guid("d8ba0acf-0390-1c22-d57c-1ed83e20da2d"), new DateTimeOffset(new DateTime(2020, 9, 5, 19, 37, 37, 889, DateTimeKind.Unspecified).AddTicks(2411), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 8, 9, 21, 29, 30, 735, DateTimeKind.Unspecified).AddTicks(7543), new TimeSpan(0, 7, 0, 0, 0)), new Guid("335ac148-c512-5b69-ffda-43761a02659d") },
                    { new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"), new Guid("83e4f60e-ea2b-f473-73f6-909e673cbdeb"), new DateTimeOffset(new DateTime(2020, 5, 15, 21, 53, 38, 112, DateTimeKind.Unspecified).AddTicks(1731), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 12, 25, 15, 7, 47, 655, DateTimeKind.Unspecified).AddTicks(3846), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1d16222e-1f0e-1a0c-5815-5e539e98ce71") },
                    { new Guid("91dfd5e5-2aad-816e-69d6-9d496e5763a3"), new Guid("fc782382-6898-3940-dec5-4409f8c4fa93"), new DateTimeOffset(new DateTime(2020, 3, 3, 7, 35, 18, 857, DateTimeKind.Unspecified).AddTicks(1849), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 8, 23, 6, 8, 32, 174, DateTimeKind.Unspecified).AddTicks(578), new TimeSpan(0, 7, 0, 0, 0)), new Guid("609afabf-efdb-fb3f-7207-2583625812b2") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("945bcd22-15c9-5455-89f7-4e1337084c23"), new Guid("7eeca4f2-d4f4-da46-7745-00fb969be0df"), new DateTimeOffset(new DateTime(2020, 7, 20, 7, 21, 32, 581, DateTimeKind.Unspecified).AddTicks(8433), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 7, 2, 16, 6, 46, 253, DateTimeKind.Unspecified).AddTicks(505), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1c32f657-87c5-33dc-2dda-a177a4571d84") });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("9565b1f8-8099-f90f-8b29-3b957e2d5fd5"), new Guid("80243f7a-52a2-60fb-11bc-323115781a81"), new DateTimeOffset(new DateTime(2020, 7, 9, 16, 9, 48, 440, DateTimeKind.Unspecified).AddTicks(5556), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 15, 6, 13, 43, 483, DateTimeKind.Unspecified).AddTicks(6951), new TimeSpan(0, 7, 0, 0, 0)), new Guid("958622b0-9ce3-bd80-11a2-342663de9bee") });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new Guid("3fd8f5fa-4f62-2ff9-5043-3e33fc7bef58"), new DateTimeOffset(new DateTime(2020, 4, 8, 8, 4, 5, 656, DateTimeKind.Unspecified).AddTicks(5098), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 11, 29, 10, 12, 37, 137, DateTimeKind.Unspecified).AddTicks(6391), new TimeSpan(0, 7, 0, 0, 0)), new Guid("fb7425eb-5298-bbd0-7d77-413ff692b4dc") },
                    { new Guid("97581a8f-780f-3896-228c-51e74509eb80"), new Guid("2702e6e6-01b4-12c7-f857-2a2e74316200"), new DateTimeOffset(new DateTime(2020, 9, 27, 17, 41, 8, 63, DateTimeKind.Unspecified).AddTicks(6226), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 3, 29, 21, 55, 51, 684, DateTimeKind.Unspecified).AddTicks(8544), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7c844000-8c04-39ea-0259-b55207b2c092") },
                    { new Guid("a1a1a4b0-39b5-5462-ea94-f627f5d5eee0"), new Guid("4009c9b3-f618-5fff-134b-47a79f0fdc72"), new DateTimeOffset(new DateTime(2020, 12, 18, 22, 24, 38, 496, DateTimeKind.Unspecified).AddTicks(9735), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 5, 2, 13, 44, 44, 1, DateTimeKind.Unspecified).AddTicks(6655), new TimeSpan(0, 7, 0, 0, 0)), new Guid("335ac148-c512-5b69-ffda-43761a02659d") },
                    { new Guid("a89ed451-1505-13b4-c458-7a030c759f3f"), new Guid("d50616cd-e87d-fb90-4c81-972b768dde09"), new DateTimeOffset(new DateTime(2020, 5, 26, 16, 51, 16, 961, DateTimeKind.Unspecified).AddTicks(5992), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 7, 24, 22, 18, 14, 516, DateTimeKind.Unspecified).AddTicks(3162), new TimeSpan(0, 7, 0, 0, 0)), new Guid("3ece3fb3-867d-a0ec-c08c-c4d7a942e500") },
                    { new Guid("a951f11b-2234-b35b-f424-5420ad1a71ce"), new Guid("8f4ff836-e126-dbd5-09b3-1f3e8190949c"), new DateTimeOffset(new DateTime(2020, 5, 5, 4, 23, 45, 761, DateTimeKind.Unspecified).AddTicks(4016), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 5, 13, 6, 0, 41, 864, DateTimeKind.Unspecified).AddTicks(2368), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1c32f657-87c5-33dc-2dda-a177a4571d84") },
                    { new Guid("a99052b6-a953-00fb-7f94-ad45509c5449"), new Guid("b6d7f535-95f3-33b7-367d-cfee3eeb94b5"), new DateTimeOffset(new DateTime(2020, 11, 11, 7, 27, 31, 68, DateTimeKind.Unspecified).AddTicks(9756), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 11, 13, 9, 56, 52, 74, DateTimeKind.Unspecified).AddTicks(59), new TimeSpan(0, 7, 0, 0, 0)), new Guid("3140208e-efb5-0baa-5dcf-f3688dfb49d4") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("b552bde3-659b-cead-d5fa-148bef7b2fa2"), new Guid("7eeca4f2-d4f4-da46-7745-00fb969be0df"), new DateTimeOffset(new DateTime(2020, 9, 6, 8, 54, 33, 707, DateTimeKind.Unspecified).AddTicks(6387), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 12, 2, 21, 36, 36, 154, DateTimeKind.Unspecified).AddTicks(5293), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f4e4bdec-d0c1-62a7-fb99-0355c25a4a9d") },
                    { new Guid("c764ce19-c657-b651-c26d-f786a83ce646"), new Guid("348368bc-8bcb-f0bc-509c-091ae65f56c5"), new DateTimeOffset(new DateTime(2020, 11, 1, 14, 34, 10, 735, DateTimeKind.Unspecified).AddTicks(4846), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 6, 1, 0, 39, 54, 145, DateTimeKind.Unspecified).AddTicks(5346), new TimeSpan(0, 7, 0, 0, 0)), new Guid("958622b0-9ce3-bd80-11a2-342663de9bee") },
                    { new Guid("c962b121-02f9-08e5-cf11-8995c540a761"), new Guid("7e9c4417-9abe-fd77-e589-9fecf460cd25"), new DateTimeOffset(new DateTime(2020, 11, 14, 22, 4, 26, 740, DateTimeKind.Unspecified).AddTicks(7614), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 29, 16, 59, 47, 928, DateTimeKind.Unspecified).AddTicks(4920), new TimeSpan(0, 7, 0, 0, 0)), new Guid("97eb2ed4-df10-55bd-d364-a3db4a109f23") },
                    { new Guid("d1e3e210-a5cc-8b3c-b036-22584367619b"), new Guid("f1bc12e3-c49a-c11a-5ea9-86da5b57bd3f"), new DateTimeOffset(new DateTime(2020, 9, 6, 0, 52, 18, 542, DateTimeKind.Unspecified).AddTicks(1812), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 3, 10, 15, 5, 37, 217, DateTimeKind.Unspecified).AddTicks(7899), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f") },
                    { new Guid("d382d930-5ce3-fc19-a249-af962f5f0ce2"), new Guid("92dc29c8-1055-fe68-1b1c-1fa97be8cebd"), new DateTimeOffset(new DateTime(2020, 11, 27, 7, 32, 56, 34, DateTimeKind.Unspecified).AddTicks(3425), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 8, 18, 21, 0, 30, 276, DateTimeKind.Unspecified).AddTicks(7569), new TimeSpan(0, 7, 0, 0, 0)), new Guid("335ac148-c512-5b69-ffda-43761a02659d") },
                    { new Guid("d40d725e-c366-8b4f-8503-1295b3ba6483"), new Guid("3e750e72-baaf-dcae-09f8-58958919c4f7"), new DateTimeOffset(new DateTime(2020, 4, 11, 9, 6, 39, 525, DateTimeKind.Unspecified).AddTicks(7098), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 16, 4, 27, 48, 102, DateTimeKind.Unspecified).AddTicks(4730), new TimeSpan(0, 7, 0, 0, 0)), new Guid("059f0b6a-1940-021d-901e-108a95bc55cb") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("d869bded-4313-a2e6-a4e8-a0bd6c2ba7d6"), new Guid("8f4ff836-e126-dbd5-09b3-1f3e8190949c"), new DateTimeOffset(new DateTime(2020, 12, 29, 17, 48, 19, 865, DateTimeKind.Unspecified).AddTicks(6258), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 4, 24, 10, 39, 2, 675, DateTimeKind.Unspecified).AddTicks(5696), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f046ac78-05d2-c7c1-40ea-bf733a9492ed") },
                    { new Guid("de9b9d52-a435-67eb-d140-657d5050c5b9"), new Guid("b6d7f535-95f3-33b7-367d-cfee3eeb94b5"), new DateTimeOffset(new DateTime(2020, 7, 1, 17, 31, 24, 895, DateTimeKind.Unspecified).AddTicks(6730), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 3, 23, 9, 46, 34, 563, DateTimeKind.Unspecified).AddTicks(5751), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b35b2234-24f4-2054-ad1a-71ce513a15ab") },
                    { new Guid("decd2662-0804-7b5c-9997-690f47fb03e9"), new Guid("3fa48bde-c787-08ca-f634-04c6ceec6dfd"), new DateTimeOffset(new DateTime(2020, 11, 16, 11, 23, 5, 994, DateTimeKind.Unspecified).AddTicks(8886), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 6, 22, 22, 37, 6, 953, DateTimeKind.Unspecified).AddTicks(9482), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7f5038db-db10-9886-e48c-3e1f519a4cfc") },
                    { new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d"), new Guid("3fa48bde-c787-08ca-f634-04c6ceec6dfd"), new DateTimeOffset(new DateTime(2020, 2, 10, 23, 55, 43, 794, DateTimeKind.Unspecified).AddTicks(671), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 1, 12, 3, 35, 52, 394, DateTimeKind.Unspecified).AddTicks(4870), new TimeSpan(0, 7, 0, 0, 0)), new Guid("fa1681fd-093d-667e-c5fd-012c2fc33394") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("e7e2d28b-02d4-3311-7a1c-f2134f0c6634"), new Guid("83e4f60e-ea2b-f473-73f6-909e673cbdeb"), new DateTimeOffset(new DateTime(2020, 2, 29, 22, 49, 14, 459, DateTimeKind.Unspecified).AddTicks(7189), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 4, 16, 18, 48, 37, 557, DateTimeKind.Unspecified).AddTicks(9744), new TimeSpan(0, 7, 0, 0, 0)), new Guid("89b78bdb-be24-151c-31f7-e7421644e19f") });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("ec779c3b-0d7d-7e38-ebec-94e998eb0c68"), new Guid("3011c86c-bfe7-4b3a-ce71-01f5eeceda98"), new DateTimeOffset(new DateTime(2020, 1, 5, 5, 47, 24, 796, DateTimeKind.Unspecified).AddTicks(1398), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 6, 28, 14, 24, 26, 610, DateTimeKind.Unspecified).AddTicks(7106), new TimeSpan(0, 7, 0, 0, 0)), new Guid("660c4f13-ac34-972b-b671-5e720dd466c3") },
                    { new Guid("f24616bd-e6a9-6c93-6269-33ef855ab90a"), new Guid("a5eda47f-1114-87ff-6f4f-f1601aa53201"), new DateTimeOffset(new DateTime(2020, 11, 27, 22, 32, 57, 624, DateTimeKind.Unspecified).AddTicks(1397), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 17, 4, 3, 45, 443, DateTimeKind.Unspecified).AddTicks(7917), new TimeSpan(0, 7, 0, 0, 0)), new Guid("09157063-f7b9-3de0-5999-e058bfd294d2") },
                    { new Guid("fa6f8747-3f5d-bbef-55f9-f750e56dce5a"), new Guid("25d1af98-3aa3-46f2-ec74-b73f32a89b98"), new DateTimeOffset(new DateTime(2020, 7, 10, 23, 0, 27, 231, DateTimeKind.Unspecified).AddTicks(6886), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 8, 29, 5, 50, 35, 915, DateTimeKind.Unspecified).AddTicks(3205), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1b95837c-302e-82d9-d3e3-5c19fca249af") },
                    { new Guid("ffd7dafa-8d35-ae04-36c7-ca601a039984"), new Guid("127c7d69-9bd8-fb05-b310-08e536b36c28"), new DateTimeOffset(new DateTime(2020, 4, 13, 6, 33, 38, 338, DateTimeKind.Unspecified).AddTicks(2487), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 22, 19, 13, 30, 976, DateTimeKind.Unspecified).AddTicks(8713), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4c126f9a-33e0-75c9-f02b-a2757bdecca9") }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("04decd26-5c08-997b-9769-0f47fb03e9ce"), new Guid("3fa48bde-c787-08ca-f634-04c6ceec6dfd"), "Available", new DateTimeOffset(new DateTime(2024, 5, 31, 7, 0, 54, 845, DateTimeKind.Unspecified).AddTicks(4725), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 22, 0, 31, 6, 65, DateTimeKind.Unspecified).AddTicks(7457), new TimeSpan(0, 7, 0, 0, 0)), "quia", "voluptatum" },
                    { new Guid("0945e751-80eb-8bf6-2014-2b1237d52d64"), new Guid("d68b7c23-85f9-8075-e44c-4687d3b0fee0"), "Available", new DateTimeOffset(new DateTime(2023, 9, 25, 9, 8, 57, 239, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 20, 2, 31, 28, 860, DateTimeKind.Unspecified).AddTicks(5069), new TimeSpan(0, 7, 0, 0, 0)), "esse", "quo" },
                    { new Guid("0a0ab19c-dca2-9549-e1e4-78b199327e3a"), new Guid("f0e4e673-9791-2674-c3e7-318835ff3826"), "Available", new DateTimeOffset(new DateTime(2024, 5, 30, 4, 16, 14, 425, DateTimeKind.Unspecified).AddTicks(5035), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 1, 15, 49, 40, 345, DateTimeKind.Unspecified).AddTicks(2940), new TimeSpan(0, 7, 0, 0, 0)), "autem", "cupiditate" },
                    { new Guid("0a6fb183-3558-f00e-f5e7-4a756503f84a"), new Guid("f0e4e673-9791-2674-c3e7-318835ff3826"), "Available", new DateTimeOffset(new DateTime(2023, 11, 9, 18, 4, 30, 501, DateTimeKind.Unspecified).AddTicks(3112), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 12, 21, 59, 58, 938, DateTimeKind.Unspecified).AddTicks(221), new TimeSpan(0, 7, 0, 0, 0)), "natus", "pariatur" }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("0bab7af2-5fac-9b1e-3f2b-cd52f09e51d4"), new Guid("83e4f60e-ea2b-f473-73f6-909e673cbdeb"), "Available", new DateTimeOffset(new DateTime(2023, 7, 25, 12, 11, 50, 256, DateTimeKind.Unspecified).AddTicks(6371), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 13, 11, 59, 41, 870, DateTimeKind.Unspecified).AddTicks(6059), new TimeSpan(0, 7, 0, 0, 0)), "iusto", "voluptatem" },
                    { new Guid("0c037a58-9f75-ab3f-38a4-aa4eb47f5542"), new Guid("d8ba0acf-0390-1c22-d57c-1ed83e20da2d"), "Available", new DateTimeOffset(new DateTime(2023, 7, 30, 12, 6, 21, 700, DateTimeKind.Unspecified).AddTicks(8275), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 11, 1, 15, 22, 41, 7, DateTimeKind.Unspecified).AddTicks(2093), new TimeSpan(0, 7, 0, 0, 0)), "consequuntur", "dolores" },
                    { new Guid("0c4f13f2-3466-2bac-97b6-715e720dd466"), new Guid("fc782382-6898-3940-dec5-4409f8c4fa93"), "Booked", new DateTimeOffset(new DateTime(2023, 8, 18, 11, 15, 21, 446, DateTimeKind.Unspecified).AddTicks(2574), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 1, 30, 0, 40, 22, 891, DateTimeKind.Unspecified).AddTicks(3917), new TimeSpan(0, 7, 0, 0, 0)), "facilis", "autem" },
                    { new Guid("0f7666bd-2191-62b1-c9f9-02e508cf1189"), new Guid("d50616cd-e87d-fb90-4c81-972b768dde09"), "Available", new DateTimeOffset(new DateTime(2024, 3, 3, 9, 32, 35, 91, DateTimeKind.Unspecified).AddTicks(9477), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 2, 14, 5, 48, 31, 557, DateTimeKind.Unspecified).AddTicks(8595), new TimeSpan(0, 7, 0, 0, 0)), "sint", "dolores" }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("19469a5c-d6ab-8b1d-dfd6-47876ffa5d3f"), new Guid("7e9c4417-9abe-fd77-e589-9fecf460cd25"), "Booked", new DateTimeOffset(new DateTime(2023, 10, 24, 14, 37, 41, 902, DateTimeKind.Unspecified).AddTicks(7283), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 19, 14, 2, 11, 911, DateTimeKind.Unspecified).AddTicks(6656), new TimeSpan(0, 7, 0, 0, 0)), "accusamus", "autem" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("28490d2e-ad32-cf01-c79e-2cd4a1fd8116"), new Guid("80243f7a-52a2-60fb-11bc-323115781a81"), "Booked", new DateTimeOffset(new DateTime(2024, 2, 28, 19, 55, 4, 201, DateTimeKind.Unspecified).AddTicks(1494), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 6, 5, 22, 1, 31, 138, DateTimeKind.Unspecified).AddTicks(5568), new TimeSpan(0, 7, 0, 0, 0)), "ea", "voluptatem" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("2f40a4d6-602b-79ee-b453-e39036dfc79c"), new Guid("a272346f-6e7b-3bd0-6c34-9e210a9a58f9"), "Booked", new DateTimeOffset(new DateTime(2024, 5, 3, 18, 55, 55, 76, DateTimeKind.Unspecified).AddTicks(2171), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 29, 16, 46, 19, 589, DateTimeKind.Unspecified).AddTicks(8831), new TimeSpan(0, 7, 0, 0, 0)), "quisquam", "qui" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("30e4180f-7bad-447f-60e5-fe9dba8dcd41"), new Guid("3011c86c-bfe7-4b3a-ce71-01f5eeceda98"), "Booked", new DateTimeOffset(new DateTime(2023, 9, 12, 15, 9, 34, 629, DateTimeKind.Unspecified).AddTicks(3464), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 10, 19, 4, 19, 52, 956, DateTimeKind.Unspecified).AddTicks(5991), new TimeSpan(0, 7, 0, 0, 0)), "repudiandae", "porro" },
                    { new Guid("31c95f5a-4a44-610a-56fa-39ba2e69221b"), new Guid("348368bc-8bcb-f0bc-509c-091ae65f56c5"), "Booked", new DateTimeOffset(new DateTime(2024, 6, 4, 2, 11, 34, 705, DateTimeKind.Unspecified).AddTicks(8455), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 4, 11, 21, 44, 58, 257, DateTimeKind.Unspecified).AddTicks(1381), new TimeSpan(0, 7, 0, 0, 0)), "in", "vel" },
                    { new Guid("39b5a1a1-5462-94ea-f627-f5d5eee0105e"), new Guid("9ca00e7a-c1e3-6c17-e48e-824e0221be0f"), "Booked", new DateTimeOffset(new DateTime(2023, 8, 4, 12, 38, 17, 873, DateTimeKind.Unspecified).AddTicks(9575), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 8, 28, 1, 34, 6, 619, DateTimeKind.Unspecified).AddTicks(9677), new TimeSpan(0, 7, 0, 0, 0)), "nam", "consequuntur" }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("4042cc3e-fa91-d7da-ff35-8d04ae36c7ca"), new Guid("f8c04973-8c15-fad4-da69-c16372e3e554"), "Booked", new DateTimeOffset(new DateTime(2023, 10, 7, 5, 38, 20, 97, DateTimeKind.Unspecified).AddTicks(5635), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 7, 9, 11, 44, 129, DateTimeKind.Unspecified).AddTicks(4276), new TimeSpan(0, 7, 0, 0, 0)), "at", "nihil" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("40d167eb-7d65-5050-c5b9-bd58e5e1a445"), new Guid("d50616cd-e87d-fb90-4c81-972b768dde09"), "Available", new DateTimeOffset(new DateTime(2024, 2, 8, 5, 31, 23, 228, DateTimeKind.Unspecified).AddTicks(6741), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 8, 30, 12, 44, 13, 591, DateTimeKind.Unspecified).AddTicks(8654), new TimeSpan(0, 7, 0, 0, 0)), "recusandae", "hic" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("4d5ace6d-8497-ab76-3a2f-df88956762d3"), new Guid("1f1fc172-de8f-09d4-b2d2-48077225518c"), "Available", new DateTimeOffset(new DateTime(2023, 8, 28, 6, 16, 56, 573, DateTimeKind.Unspecified).AddTicks(2280), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 3, 17, 8, 4, 45, 895, DateTimeKind.Unspecified).AddTicks(3732), new TimeSpan(0, 7, 0, 0, 0)), "fugiat", "impedit" },
                    { new Guid("582236b0-6743-9b61-aa64-9fd9f78f1a58"), new Guid("5d7c09a1-50cf-c09e-103d-b97e2dac22f8"), "Booked", new DateTimeOffset(new DateTime(2023, 10, 25, 4, 2, 26, 825, DateTimeKind.Unspecified).AddTicks(8328), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 24, 7, 58, 46, 865, DateTimeKind.Unspecified).AddTicks(8042), new TimeSpan(0, 7, 0, 0, 0)), "repellendus", "et" }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("5837778a-135d-6548-2553-d7ec3774d8f5"), new Guid("51b355f6-95d6-d189-d290-b43e07fdb192"), "Available", new DateTimeOffset(new DateTime(2024, 3, 11, 1, 28, 44, 605, DateTimeKind.Unspecified).AddTicks(5588), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 8, 25, 21, 3, 29, 256, DateTimeKind.Unspecified).AddTicks(2709), new TimeSpan(0, 7, 0, 0, 0)), "blanditiis", "aliquid" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("5ce3d382-fc19-49a2-af96-2f5f0ce2aa42"), new Guid("3fa48bde-c787-08ca-f634-04c6ceec6dfd"), "Available", new DateTimeOffset(new DateTime(2023, 9, 25, 4, 4, 23, 549, DateTimeKind.Unspecified).AddTicks(9570), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 30, 16, 48, 51, 808, DateTimeKind.Unspecified).AddTicks(1271), new TimeSpan(0, 7, 0, 0, 0)), "consequatur", "rerum" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("6649549c-7feb-70fc-5fef-ed2c0eaddc74"), new Guid("8891162f-8813-026d-bc01-44d5e3922476"), "Booked", new DateTimeOffset(new DateTime(2024, 2, 8, 5, 15, 50, 659, DateTimeKind.Unspecified).AddTicks(39), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 6, 24, 18, 27, 11, 208, DateTimeKind.Unspecified).AddTicks(473), new TimeSpan(0, 7, 0, 0, 0)), "quia", "quo" },
                    { new Guid("69bdeded-13d8-e643-a2a4-e8a0bd6c2ba7"), new Guid("3b2ed5e9-129c-9803-e89b-09e05c86f18c"), "Booked", new DateTimeOffset(new DateTime(2023, 10, 16, 23, 28, 39, 342, DateTimeKind.Unspecified).AddTicks(7954), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 3, 26, 23, 7, 42, 526, DateTimeKind.Unspecified).AddTicks(1963), new TimeSpan(0, 7, 0, 0, 0)), "saepe", "consequatur" }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("6d13d55f-c23f-f5a7-18e0-7e9b5202b062"), new Guid("ecfd54e4-0562-714b-50c5-b3c9c135e33c"), "Available", new DateTimeOffset(new DateTime(2023, 10, 9, 14, 46, 55, 970, DateTimeKind.Unspecified).AddTicks(8549), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 21, 3, 35, 43, 117, DateTimeKind.Unspecified).AddTicks(194), new TimeSpan(0, 7, 0, 0, 0)), "fugit", "accusantium" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("6dc2b651-86f7-3ca8-e646-80ed8168bd10"), new Guid("06278a51-2c88-111e-be6c-94ebbe9406f5"), "Booked", new DateTimeOffset(new DateTime(2023, 7, 27, 22, 55, 44, 504, DateTimeKind.Unspecified).AddTicks(5944), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 9, 14, 17, 48, 28, 508, DateTimeKind.Unspecified).AddTicks(4664), new TimeSpan(0, 7, 0, 0, 0)), "et", "dignissimos" },
                    { new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"), new Guid("7b04bb20-cbba-8555-0d9a-5e5834745d1d"), "Available", new DateTimeOffset(new DateTime(2024, 3, 14, 10, 48, 37, 186, DateTimeKind.Unspecified).AddTicks(3760), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 1, 23, 42, 56, 984, DateTimeKind.Unspecified).AddTicks(6087), new TimeSpan(0, 7, 0, 0, 0)), "est", "ab" },
                    { new Guid("81b45a90-dc2d-75d8-0729-b4372c2ad5ff"), new Guid("3e750e72-baaf-dcae-09f8-58958919c4f7"), "Available", new DateTimeOffset(new DateTime(2024, 4, 17, 18, 26, 42, 63, DateTimeKind.Unspecified).AddTicks(3430), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 8, 26, 5, 46, 33, 111, DateTimeKind.Unspecified).AddTicks(2304), new TimeSpan(0, 7, 0, 0, 0)), "voluptas", "expedita" },
                    { new Guid("8364bab3-3549-2209-c2f8-b1659599800f"), new Guid("d50616cd-e87d-fb90-4c81-972b768dde09"), "Booked", new DateTimeOffset(new DateTime(2023, 11, 9, 1, 36, 15, 627, DateTimeKind.Unspecified).AddTicks(5054), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 3, 8, 11, 17, 1, 877, DateTimeKind.Unspecified).AddTicks(8622), new TimeSpan(0, 7, 0, 0, 0)), "voluptatem", "voluptatem" }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("87973a15-8dde-6aed-3a99-5add4e83275c"), new Guid("7eeca4f2-d4f4-da46-7745-00fb969be0df"), "Available", new DateTimeOffset(new DateTime(2023, 10, 16, 7, 26, 49, 517, DateTimeKind.Unspecified).AddTicks(9683), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 16, 17, 3, 7, 239, DateTimeKind.Unspecified).AddTicks(9493), new TimeSpan(0, 7, 0, 0, 0)), "nisi", "reprehenderit" },
                    { new Guid("8b1ffb45-1ea4-e025-e09e-2784cd25923f"), new Guid("b6d7f535-95f3-33b7-367d-cfee3eeb94b5"), "Available", new DateTimeOffset(new DateTime(2024, 4, 27, 7, 52, 24, 725, DateTimeKind.Unspecified).AddTicks(5810), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 22, 23, 17, 40, 396, DateTimeKind.Unspecified).AddTicks(2031), new TimeSpan(0, 7, 0, 0, 0)), "veniam", "a" }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("8bc880c5-bc39-a62d-528d-a9d070fe5e75"), new Guid("8891162f-8813-026d-bc01-44d5e3922476"), "Available", new DateTimeOffset(new DateTime(2024, 6, 5, 5, 59, 22, 200, DateTimeKind.Unspecified).AddTicks(1505), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 4, 23, 28, 19, 577, DateTimeKind.Unspecified).AddTicks(4930), new TimeSpan(0, 7, 0, 0, 0)), "et", "inventore" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("9528cd4e-80df-ffff-977f-ca08f6548f59"), new Guid("d8ba0acf-0390-1c22-d57c-1ed83e20da2d"), "Booked", new DateTimeOffset(new DateTime(2023, 8, 12, 7, 35, 29, 495, DateTimeKind.Unspecified).AddTicks(8651), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 3, 18, 52, 4, 931, DateTimeKind.Unspecified).AddTicks(7376), new TimeSpan(0, 7, 0, 0, 0)), "excepturi", "sit" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new Guid("d50616cd-e87d-fb90-4c81-972b768dde09"), "Available", new DateTimeOffset(new DateTime(2024, 5, 25, 6, 50, 17, 399, DateTimeKind.Unspecified).AddTicks(7611), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 2, 21, 13, 27, 53, 592, DateTimeKind.Unspecified).AddTicks(1627), new TimeSpan(0, 7, 0, 0, 0)), "ut", "sunt" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("9a2771a7-4449-f54d-62d9-b0a724366a66"), new Guid("f0e4e673-9791-2674-c3e7-318835ff3826"), "Available", new DateTimeOffset(new DateTime(2023, 7, 3, 16, 46, 0, 133, DateTimeKind.Unspecified).AddTicks(3301), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 9, 4, 45, 879, DateTimeKind.Unspecified).AddTicks(6421), new TimeSpan(0, 7, 0, 0, 0)), "ut", "libero" },
                    { new Guid("9f71f26d-1bea-a600-c920-1c80f09d1740"), new Guid("43a522de-b5ce-181d-f920-5e853754359a"), "Available", new DateTimeOffset(new DateTime(2023, 6, 26, 11, 9, 12, 958, DateTimeKind.Unspecified).AddTicks(2216), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 14, 11, 51, 49, 801, DateTimeKind.Unspecified).AddTicks(2847), new TimeSpan(0, 7, 0, 0, 0)), "non", "similique" }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("a957cd73-8de9-2e76-3754-d34cf08bd2e2"), new Guid("f8c04973-8c15-fad4-da69-c16372e3e554"), "Available", new DateTimeOffset(new DateTime(2024, 2, 26, 21, 56, 18, 134, DateTimeKind.Unspecified).AddTicks(7243), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 11, 2, 11, 48, 23, 518, DateTimeKind.Unspecified).AddTicks(8685), new TimeSpan(0, 7, 0, 0, 0)), "et", "vero" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("a9ff8f43-1b36-7c81-ae63-cbef0d43492d"), new Guid("2702e6e6-01b4-12c7-f857-2a2e74316200"), "Booked", new DateTimeOffset(new DateTime(2023, 7, 4, 13, 35, 38, 865, DateTimeKind.Unspecified).AddTicks(81), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 27, 0, 57, 53, 392, DateTimeKind.Unspecified).AddTicks(1014), new TimeSpan(0, 7, 0, 0, 0)), "atque", "dolor" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("aa6983e2-10a4-4d8d-026f-58808923f5bd"), new Guid("a272346f-6e7b-3bd0-6c34-9e210a9a58f9"), "Booked", new DateTimeOffset(new DateTime(2024, 1, 30, 16, 47, 58, 113, DateTimeKind.Unspecified).AddTicks(4511), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 3, 16, 19, 50, 44, 281, DateTimeKind.Unspecified).AddTicks(4548), new TimeSpan(0, 7, 0, 0, 0)), "impedit", "facere" },
                    { new Guid("ae2b65bc-8752-1d50-b8b4-7d7fa37ad24f"), new Guid("d68b7c23-85f9-8075-e44c-4687d3b0fee0"), "Booked", new DateTimeOffset(new DateTime(2023, 7, 21, 3, 12, 52, 784, DateTimeKind.Unspecified).AddTicks(208), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 7, 5, 22, 13, 7, 46, DateTimeKind.Unspecified).AddTicks(3240), new TimeSpan(0, 7, 0, 0, 0)), "provident", "repellendus" }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("bde38317-b552-659b-adce-d5fa148bef7b"), new Guid("230d8922-1828-483c-7858-c33ace94d9e3"), "Available", new DateTimeOffset(new DateTime(2024, 2, 28, 21, 44, 10, 374, DateTimeKind.Unspecified).AddTicks(9077), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 26, 10, 26, 12, 821, DateTimeKind.Unspecified).AddTicks(7986), new TimeSpan(0, 7, 0, 0, 0)), "repellat", "sunt" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("c32f2c01-9433-2762-2427-ce133348d2a8"), new Guid("21113ab3-a8e3-d3de-a9d6-d2d7bdd33bc3"), "Booked", new DateTimeOffset(new DateTime(2024, 3, 18, 8, 22, 49, 124, DateTimeKind.Unspecified).AddTicks(9925), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 3, 12, 10, 10, 30, 568, DateTimeKind.Unspecified).AddTicks(5244), new TimeSpan(0, 7, 0, 0, 0)), "earum", "facilis" },
                    { new Guid("c3c7fdd7-cfcb-1cc2-45de-b65290a953a9"), new Guid("a5eda47f-1114-87ff-6f4f-f1601aa53201"), "Available", new DateTimeOffset(new DateTime(2023, 7, 27, 7, 30, 35, 792, DateTimeKind.Unspecified).AddTicks(3789), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 10, 13, 22, 24, 13, 45, DateTimeKind.Unspecified).AddTicks(8179), new TimeSpan(0, 7, 0, 0, 0)), "modi", "voluptas" }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("c9945bcd-5515-8954-f74e-1337084c237e"), new Guid("7eeca4f2-d4f4-da46-7745-00fb969be0df"), "Booked", new DateTimeOffset(new DateTime(2024, 3, 4, 22, 11, 1, 409, DateTimeKind.Unspecified).AddTicks(7424), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 15, 1, 39, 30, 52, DateTimeKind.Unspecified).AddTicks(7438), new TimeSpan(0, 7, 0, 0, 0)), "qui", "illo" },
                    { new Guid("e6a9f246-6c93-6962-33ef-855ab90a53b0"), new Guid("3fa48bde-c787-08ca-f634-04c6ceec6dfd"), "Booked", new DateTimeOffset(new DateTime(2023, 12, 24, 14, 45, 49, 882, DateTimeKind.Unspecified).AddTicks(8397), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 8, 14, 23, 48, 494, DateTimeKind.Unspecified).AddTicks(9969), new TimeSpan(0, 7, 0, 0, 0)), "ipsa", "voluptatem" },
                    { new Guid("e88dd8c7-b5e7-329d-1efa-c9fc05d4975e"), new Guid("8891162f-8813-026d-bc01-44d5e3922476"), "Available", new DateTimeOffset(new DateTime(2024, 1, 8, 4, 35, 51, 113, DateTimeKind.Unspecified).AddTicks(9952), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 3, 12, 1, 24, 36, 930, DateTimeKind.Unspecified).AddTicks(5619), new TimeSpan(0, 7, 0, 0, 0)), "doloremque", "dolor" },
                    { new Guid("ecc698c4-a3bd-d5e5-df91-ad2a6e8169d6"), new Guid("7b04bb20-cbba-8555-0d9a-5e5834745d1d"), "Available", new DateTimeOffset(new DateTime(2024, 3, 13, 9, 5, 41, 864, DateTimeKind.Unspecified).AddTicks(9166), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 3, 0, 15, 54, 613, DateTimeKind.Unspecified).AddTicks(4997), new TimeSpan(0, 7, 0, 0, 0)), "totam", "quia" },
                    { new Guid("edc2475d-d718-e562-400b-b5d94a508985"), new Guid("7e9c4417-9abe-fd77-e589-9fecf460cd25"), "Available", new DateTimeOffset(new DateTime(2023, 12, 27, 7, 26, 1, 183, DateTimeKind.Unspecified).AddTicks(4214), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 16, 13, 8, 33, 143, DateTimeKind.Unspecified).AddTicks(8131), new TimeSpan(0, 7, 0, 0, 0)), "ut", "aut" },
                    { new Guid("f4b35b22-5424-ad20-1a71-ce513a15ab1e"), new Guid("28e6c30d-ecf2-2b5e-8579-6a8da40c4c08"), "Available", new DateTimeOffset(new DateTime(2023, 9, 8, 12, 25, 57, 115, DateTimeKind.Unspecified).AddTicks(5744), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 14, 3, 3, 229, DateTimeKind.Unspecified).AddTicks(176), new TimeSpan(0, 7, 0, 0, 0)), "at", "suscipit" }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("f62452d5-8c09-f356-f855-7eac442d01fb"), new Guid("3fd8f5fa-4f62-2ff9-5043-3e33fc7bef58"), "Available", new DateTimeOffset(new DateTime(2023, 8, 20, 0, 38, 28, 539, DateTimeKind.Unspecified).AddTicks(3040), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 7, 15, 40, 52, 24, DateTimeKind.Unspecified).AddTicks(4091), new TimeSpan(0, 7, 0, 0, 0)), "provident", "autem" },
                    { new Guid("f76bbc76-1fa7-474c-73ae-e30c1006428e"), new Guid("8f4ff836-e126-dbd5-09b3-1f3e8190949c"), "Booked", new DateTimeOffset(new DateTime(2024, 3, 1, 22, 28, 54, 812, DateTimeKind.Unspecified).AddTicks(2552), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 4, 14, 17, 41, 44, 898, DateTimeKind.Unspecified).AddTicks(3811), new TimeSpan(0, 7, 0, 0, 0)), "qui", "necessitatibus" }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"), new Guid("7eeca4f2-d4f4-da46-7745-00fb969be0df"), "Booked", new DateTimeOffset(new DateTime(2024, 3, 2, 18, 8, 47, 192, DateTimeKind.Unspecified).AddTicks(3408), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 5, 4, 55, 24, 771, DateTimeKind.Unspecified).AddTicks(2974), new TimeSpan(0, 7, 0, 0, 0)), "natus", "et" });

            migrationBuilder.InsertData(
                table: "DateCourtGroup",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "DateId", "IsClosed", "IsDeleted", "ModifiedOnUtc" },
                values: new object[,]
                {
                    { new Guid("001bea9f-c9a6-1c20-80f0-9d1740b7b9b0"), new Guid("7eeca4f2-d4f4-da46-7745-00fb969be0df"), new DateTimeOffset(new DateTime(2023, 8, 4, 0, 34, 56, 101, DateTimeKind.Unspecified).AddTicks(3314), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8a824ff6-5da4-5a90-b481-2ddcd8750729"), false, true, new DateTimeOffset(new DateTime(2024, 4, 10, 21, 53, 51, 334, DateTimeKind.Unspecified).AddTicks(7190), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("031a60ca-8499-fd17-2e0d-492832ad01cf"), new Guid("1f1fc172-de8f-09d4-b2d2-48077225518c"), new DateTimeOffset(new DateTime(2024, 1, 4, 5, 51, 54, 71, DateTimeKind.Unspecified).AddTicks(6741), new TimeSpan(0, 7, 0, 0, 0)), new Guid("01ad3228-c7cf-2c9e-d4a1-fd8116fa3d09"), true, true, new DateTimeOffset(new DateTime(2024, 4, 30, 16, 13, 38, 877, DateTimeKind.Unspecified).AddTicks(732), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("1203858b-b395-64ba-8349-350922c2f8b1"), new Guid("51b355f6-95d6-d189-d290-b43e07fdb192"), new DateTimeOffset(new DateTime(2023, 7, 23, 5, 33, 40, 239, DateTimeKind.Unspecified).AddTicks(7025), new TimeSpan(0, 7, 0, 0, 0)), new Guid("31663645-0c09-f634-73cd-57a9e98d762e"), false, false, new DateTimeOffset(new DateTime(2024, 1, 28, 6, 1, 1, 105, DateTimeKind.Unspecified).AddTicks(7581), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("1c7a3311-13f2-0c4f-6634-ac2b97b6715e"), new Guid("b6d7f535-95f3-33b7-367d-cfee3eeb94b5"), new DateTimeOffset(new DateTime(2023, 10, 10, 3, 55, 2, 881, DateTimeKind.Unspecified).AddTicks(2894), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a89ed451-1505-13b4-c458-7a030c759f3f"), true, false, new DateTimeOffset(new DateTime(2024, 4, 22, 4, 14, 55, 273, DateTimeKind.Unspecified).AddTicks(4950), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("22389678-518c-45e7-09eb-80f68b20142b"), new Guid("06278a51-2c88-111e-be6c-94ebbe9406f5"), new DateTimeOffset(new DateTime(2023, 8, 6, 6, 14, 21, 519, DateTimeKind.Unspecified).AddTicks(397), new TimeSpan(0, 7, 0, 0, 0)), new Guid("586f024d-8980-f523-bdce-f26ed8848d04"), true, true, new DateTimeOffset(new DateTime(2023, 8, 5, 8, 42, 58, 627, DateTimeKind.Unspecified).AddTicks(5068), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("234c0837-e07e-6fb5-dc08-5b8c438fffa9"), new Guid("3b2ed5e9-129c-9803-e89b-09e05c86f18c"), new DateTimeOffset(new DateTime(2024, 5, 9, 21, 52, 32, 169, DateTimeKind.Unspecified).AddTicks(8991), new TimeSpan(0, 7, 0, 0, 0)), new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d"), true, false, new DateTimeOffset(new DateTime(2023, 12, 12, 8, 55, 10, 653, DateTimeKind.Unspecified).AddTicks(8433), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("29a8d248-66fd-66c5-8262-26cdde04085c"), new Guid("f0e4e673-9791-2674-c3e7-318835ff3826"), new DateTimeOffset(new DateTime(2023, 10, 24, 10, 11, 20, 545, DateTimeKind.Unspecified).AddTicks(3682), new TimeSpan(0, 7, 0, 0, 0)), new Guid("c962b121-02f9-08e5-cf11-8995c540a761"), false, false, new DateTimeOffset(new DateTime(2023, 11, 26, 7, 35, 18, 348, DateTimeKind.Unspecified).AddTicks(1065), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("2bfb012d-0c51-868e-863e-ededbd69d813"), new Guid("2702e6e6-01b4-12c7-f857-2a2e74316200"), new DateTimeOffset(new DateTime(2023, 10, 30, 15, 11, 4, 220, DateTimeKind.Unspecified).AddTicks(3941), new TimeSpan(0, 7, 0, 0, 0)), new Guid("2dd53712-d464-ab85-d589-e18ec580c88b"), false, false, new DateTimeOffset(new DateTime(2023, 12, 19, 18, 45, 41, 594, DateTimeKind.Unspecified).AddTicks(451), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("37778a15-5d58-4813-6525-53d7ec3774d8"), new Guid("8891162f-8813-026d-bc01-44d5e3922476"), new DateTimeOffset(new DateTime(2023, 12, 15, 22, 42, 3, 404, DateTimeKind.Unspecified).AddTicks(3400), new TimeSpan(0, 7, 0, 0, 0)), new Guid("c764ce19-c657-b651-c26d-f786a83ce646"), true, true, new DateTimeOffset(new DateTime(2024, 2, 17, 3, 39, 33, 939, DateTimeKind.Unspecified).AddTicks(8739), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("3a51ce71-ab15-6d1e-75d2-65d33d5c153a"), new Guid("51b355f6-95d6-d189-d290-b43e07fdb192"), new DateTimeOffset(new DateTime(2023, 11, 29, 15, 39, 29, 137, DateTimeKind.Unspecified).AddTicks(1646), new TimeSpan(0, 7, 0, 0, 0)), new Guid("31663645-0c09-f634-73cd-57a9e98d762e"), false, false, new DateTimeOffset(new DateTime(2024, 4, 5, 0, 7, 32, 646, DateTimeKind.Unspecified).AddTicks(8701), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("3aab7684-df2f-9588-6762-d36d43591ec6"), new Guid("9b5b2c85-3033-3987-b842-af9ad2f401ee"), new DateTimeOffset(new DateTime(2024, 4, 22, 16, 52, 35, 716, DateTimeKind.Unspecified).AddTicks(8398), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a89ed451-1505-13b4-c458-7a030c759f3f"), false, true, new DateTimeOffset(new DateTime(2023, 12, 21, 2, 11, 40, 523, DateTimeKind.Unspecified).AddTicks(1186), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("3dfa1681-7e09-c566-fd01-2c2fc3339462"), new Guid("967ad428-ade0-4670-63df-2293f92710bd"), new DateTimeOffset(new DateTime(2023, 9, 1, 4, 32, 9, 478, DateTimeKind.Unspecified).AddTicks(6353), new TimeSpan(0, 7, 0, 0, 0)), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), true, true, new DateTimeOffset(new DateTime(2023, 12, 12, 4, 57, 13, 373, DateTimeKind.Unspecified).AddTicks(9189), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("430defcb-2d49-4e90-1bf1-51a934225bb3"), new Guid("5e390d4d-ab7e-34d9-d4ec-ef08c5ede18f"), new DateTimeOffset(new DateTime(2024, 4, 16, 7, 21, 53, 100, DateTimeKind.Unspecified).AddTicks(8600), new TimeSpan(0, 7, 0, 0, 0)), new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"), false, true, new DateTimeOffset(new DateTime(2024, 4, 15, 7, 5, 52, 371, DateTimeKind.Unspecified).AddTicks(2890), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("4eaaa438-7fb4-4255-1996-b8a364698dd7"), new Guid("d50616cd-e87d-fb90-4c81-972b768dde09"), new DateTimeOffset(new DateTime(2024, 2, 7, 18, 42, 12, 53, DateTimeKind.Unspecified).AddTicks(8078), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7ee018f5-529b-b002-62f6-8e93af65c0a8"), true, false, new DateTimeOffset(new DateTime(2023, 7, 8, 18, 42, 10, 152, DateTimeKind.Unspecified).AddTicks(9533), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("51c657c7-c2b6-f76d-86a8-3ce64680ed81"), new Guid("5e390d4d-ab7e-34d9-d4ec-ef08c5ede18f"), new DateTimeOffset(new DateTime(2024, 3, 4, 18, 36, 43, 588, DateTimeKind.Unspecified).AddTicks(8245), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9565b1f8-8099-f90f-8b29-3b957e2d5fd5"), true, true, new DateTimeOffset(new DateTime(2023, 7, 28, 15, 32, 7, 18, DateTimeKind.Unspecified).AddTicks(7646), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("580a6fb1-0e35-f5f0-e74a-756503f84a7c"), new Guid("7eeca4f2-d4f4-da46-7745-00fb969be0df"), new DateTimeOffset(new DateTime(2023, 11, 9, 18, 4, 30, 512, DateTimeKind.Unspecified).AddTicks(3942), new TimeSpan(0, 7, 0, 0, 0)), new Guid("decd2662-0804-7b5c-9997-690f47fb03e9"), false, false, new DateTimeOffset(new DateTime(2023, 11, 12, 21, 59, 58, 949, DateTimeKind.Unspecified).AddTicks(1050), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("5ce3d382-fc19-49a2-af96-2f5f0ce2aa42"), new Guid("3fa48bde-c787-08ca-f634-04c6ceec6dfd"), new DateTimeOffset(new DateTime(2023, 7, 13, 20, 31, 46, 244, DateTimeKind.Unspecified).AddTicks(2773), new TimeSpan(0, 7, 0, 0, 0)), new Guid("fa6f8747-3f5d-bbef-55f9-f750e56dce5a"), false, true, new DateTimeOffset(new DateTime(2023, 9, 25, 4, 4, 23, 561, DateTimeKind.Unspecified).AddTicks(390), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("6239b5a1-ea54-f694-27f5-d5eee0105eca"), new Guid("28e6c30d-ecf2-2b5e-8579-6a8da40c4c08"), new DateTimeOffset(new DateTime(2023, 8, 4, 12, 38, 17, 885, DateTimeKind.Unspecified).AddTicks(148), new TimeSpan(0, 7, 0, 0, 0)), new Guid("568c09f6-f8f3-7e55-ac44-2d01fb2b510c"), true, true, new DateTimeOffset(new DateTime(2023, 8, 28, 1, 34, 6, 631, DateTimeKind.Unspecified).AddTicks(250), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("65bc72ff-ae2b-8752-501d-b8b47d7fa37a"), new Guid("69caa284-6f54-050a-1ec3-6e9841ddbe45"), new DateTimeOffset(new DateTime(2023, 12, 12, 9, 36, 6, 912, DateTimeKind.Unspecified).AddTicks(802), new TimeSpan(0, 7, 0, 0, 0)), new Guid("91dfd5e5-2aad-816e-69d6-9d496e5763a3"), true, false, new DateTimeOffset(new DateTime(2024, 5, 24, 3, 48, 15, 984, DateTimeKind.Unspecified).AddTicks(366), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("67eba435-40d1-7d65-5050-c5b9bd58e5e1"), new Guid("25d1af98-3aa3-46f2-ec74-b73f32a89b98"), new DateTimeOffset(new DateTime(2023, 7, 18, 10, 2, 47, 949, DateTimeKind.Unspecified).AddTicks(7861), new TimeSpan(0, 7, 0, 0, 0)), new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d"), false, false, new DateTimeOffset(new DateTime(2023, 11, 15, 1, 29, 55, 755, DateTimeKind.Unspecified).AddTicks(3060), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("6ef2cebd-84d8-048d-bd66-760f9121b162"), new Guid("0493a29e-5c9f-7083-66de-782b4b0aa3e9"), new DateTimeOffset(new DateTime(2024, 2, 26, 14, 51, 13, 613, DateTimeKind.Unspecified).AddTicks(4909), new TimeSpan(0, 7, 0, 0, 0)), new Guid("586f024d-8980-f523-bdce-f26ed8848d04"), false, true, new DateTimeOffset(new DateTime(2024, 3, 30, 12, 57, 49, 190, DateTimeKind.Unspecified).AddTicks(8903), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("71a777e1-9a27-4449-4df5-62d9b0a72436"), new Guid("3fd8f5fa-4f62-2ff9-5043-3e33fc7bef58"), new DateTimeOffset(new DateTime(2023, 7, 5, 15, 43, 56, 104, DateTimeKind.Unspecified).AddTicks(3931), new TimeSpan(0, 7, 0, 0, 0)), new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"), true, false, new DateTimeOffset(new DateTime(2023, 12, 10, 2, 4, 22, 993, DateTimeKind.Unspecified).AddTicks(956), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("73f6340c-57cd-e9a9-8d76-2e3754d34cf0"), new Guid("1f1fc172-de8f-09d4-b2d2-48077225518c"), new DateTimeOffset(new DateTime(2023, 9, 24, 12, 9, 58, 941, DateTimeKind.Unspecified).AddTicks(7537), new TimeSpan(0, 7, 0, 0, 0)), new Guid("438c5b08-ff8f-36a9-1b81-7cae63cbef0d"), false, false, new DateTimeOffset(new DateTime(2023, 11, 12, 6, 30, 54, 219, DateTimeKind.Unspecified).AddTicks(2246), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("76b4b43e-6bbc-a7f7-1f4c-4773aee30c10"), new Guid("5d7c09a1-50cf-c09e-103d-b97e2dac22f8"), new DateTimeOffset(new DateTime(2024, 2, 11, 14, 19, 11, 500, DateTimeKind.Unspecified).AddTicks(261), new TimeSpan(0, 7, 0, 0, 0)), new Guid("decd2662-0804-7b5c-9997-690f47fb03e9"), false, true, new DateTimeOffset(new DateTime(2024, 1, 10, 17, 22, 26, 431, DateTimeKind.Unspecified).AddTicks(9052), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"), new Guid("7b04bb20-cbba-8555-0d9a-5e5834745d1d"), new DateTimeOffset(new DateTime(2024, 6, 6, 18, 53, 4, 238, DateTimeKind.Unspecified).AddTicks(3365), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4ee9d2ad-28cd-df95-80ff-ff977fca08f6"), false, true, new DateTimeOffset(new DateTime(2024, 3, 14, 10, 48, 37, 197, DateTimeKind.Unspecified).AddTicks(4327), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("7fd8b31a-ccc5-e27d-8369-aaa4108d4d02"), new Guid("69caa284-6f54-050a-1ec3-6e9841ddbe45"), new DateTimeOffset(new DateTime(2024, 5, 12, 10, 54, 1, 613, DateTimeKind.Unspecified).AddTicks(2688), new TimeSpan(0, 7, 0, 0, 0)), new Guid("15c913df-778a-5837-5d13-48652553d7ec"), true, true, new DateTimeOffset(new DateTime(2023, 12, 7, 21, 35, 50, 264, DateTimeKind.Unspecified).AddTicks(5630), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("89d5ab85-8ee1-80c5-c88b-39bc2da6528d"), new Guid("83e4f60e-ea2b-f473-73f6-909e673cbdeb"), new DateTimeOffset(new DateTime(2024, 4, 15, 1, 2, 57, 484, DateTimeKind.Unspecified).AddTicks(6686), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a1a1a4b0-39b5-5462-ea94-f627f5d5eee0"), false, false, new DateTimeOffset(new DateTime(2024, 3, 26, 8, 58, 28, 354, DateTimeKind.Unspecified).AddTicks(290), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("8b3ca5cc-36b0-5822-4367-619baa649fd9"), new Guid("83e4f60e-ea2b-f473-73f6-909e673cbdeb"), new DateTimeOffset(new DateTime(2024, 1, 17, 7, 2, 32, 940, DateTimeKind.Unspecified).AddTicks(3307), new TimeSpan(0, 7, 0, 0, 0)), new Guid("33c32f2c-6294-2427-27ce-133348d2a829"), true, false, new DateTimeOffset(new DateTime(2023, 8, 19, 13, 17, 36, 236, DateTimeKind.Unspecified).AddTicks(3069), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("8f54f608-ca59-8ea8-37a9-2300d6a4402f"), new Guid("06278a51-2c88-111e-be6c-94ebbe9406f5"), new DateTimeOffset(new DateTime(2023, 9, 3, 6, 21, 17, 208, DateTimeKind.Unspecified).AddTicks(6475), new TimeSpan(0, 7, 0, 0, 0)), new Guid("de9b9d52-a435-67eb-d140-657d5050c5b9"), false, false, new DateTimeOffset(new DateTime(2023, 6, 30, 2, 40, 33, 849, DateTimeKind.Unspecified).AddTicks(8969), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("953b298b-2d7e-d55f-136d-3fc2a7f518e0"), new Guid("3fa48bde-c787-08ca-f634-04c6ceec6dfd"), new DateTimeOffset(new DateTime(2024, 2, 6, 10, 47, 30, 128, DateTimeKind.Unspecified).AddTicks(8880), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8a824ff6-5da4-5a90-b481-2ddcd8750729"), true, false, new DateTimeOffset(new DateTime(2024, 1, 7, 15, 38, 39, 370, DateTimeKind.Unspecified).AddTicks(2919), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new Guid("d50616cd-e87d-fb90-4c81-972b768dde09"), new DateTimeOffset(new DateTime(2024, 5, 22, 23, 2, 13, 815, DateTimeKind.Unspecified).AddTicks(8000), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d869bded-4313-a2e6-a4e8-a0bd6c2ba7d6"), false, true, new DateTimeOffset(new DateTime(2024, 5, 25, 6, 50, 17, 410, DateTimeKind.Unspecified).AddTicks(9715), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("9db5e7e8-1e32-c9fa-fc05-d4975ed3d849"), new Guid("7e9c4417-9abe-fd77-e589-9fecf460cd25"), new DateTimeOffset(new DateTime(2023, 8, 16, 10, 50, 54, 480, DateTimeKind.Unspecified).AddTicks(6892), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b552bde3-659b-cead-d5fa-148bef7b2fa2"), true, true, new DateTimeOffset(new DateTime(2023, 7, 24, 23, 4, 45, 980, DateTimeKind.Unspecified).AddTicks(4042), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("a72b6cbd-72d6-0a05-8f89-22cd5b94c915"), new Guid("21a19a75-c397-f2f7-c138-1c350582a9e4"), new DateTimeOffset(new DateTime(2024, 2, 23, 2, 44, 41, 33, DateTimeKind.Unspecified).AddTicks(3879), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b552bde3-659b-cead-d5fa-148bef7b2fa2"), false, false, new DateTimeOffset(new DateTime(2023, 6, 25, 8, 2, 48, 61, DateTimeKind.Unspecified).AddTicks(9138), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("a9f24616-93e6-626c-6933-ef855ab90a53"), new Guid("a5eda47f-1114-87ff-6f4f-f1601aa53201"), new DateTimeOffset(new DateTime(2024, 3, 17, 2, 54, 54, 458, DateTimeKind.Unspecified).AddTicks(9248), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d1e3e210-a5cc-8b3c-b036-22584367619b"), true, true, new DateTimeOffset(new DateTime(2024, 3, 20, 4, 25, 44, 258, DateTimeKind.Unspecified).AddTicks(8197), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("af938ef6-c065-3ea8-cc42-4091fadad7ff"), new Guid("a5eda47f-1114-87ff-6f4f-f1601aa53201"), new DateTimeOffset(new DateTime(2023, 9, 19, 11, 39, 37, 25, DateTimeKind.Unspecified).AddTicks(4689), new TimeSpan(0, 7, 0, 0, 0)), new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"), false, true, new DateTimeOffset(new DateTime(2023, 12, 16, 13, 54, 9, 421, DateTimeKind.Unspecified).AddTicks(3579), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("b45a905d-2d81-d8dc-7507-29b4372c2ad5"), new Guid("5e390d4d-ab7e-34d9-d4ec-ef08c5ede18f"), new DateTimeOffset(new DateTime(2023, 9, 16, 14, 52, 9, 309, DateTimeKind.Unspecified).AddTicks(6142), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"), false, true, new DateTimeOffset(new DateTime(2023, 10, 27, 13, 35, 16, 821, DateTimeKind.Unspecified).AddTicks(6956), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("b552bde3-659b-cead-d5fa-148bef7b2fa2"), new Guid("2702e6e6-01b4-12c7-f857-2a2e74316200"), new DateTimeOffset(new DateTime(2024, 5, 26, 10, 26, 12, 832, DateTimeKind.Unspecified).AddTicks(8826), new TimeSpan(0, 7, 0, 0, 0)), new Guid("e7e2d28b-02d4-3311-7a1c-f2134f0c6634"), true, false, new DateTimeOffset(new DateTime(2023, 8, 13, 2, 55, 30, 446, DateTimeKind.Unspecified).AddTicks(150), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("b6de451c-9052-53a9-a9fb-007f94ad4550"), new Guid("92dc29c8-1055-fe68-1b1c-1fa97be8cebd"), new DateTimeOffset(new DateTime(2024, 2, 7, 5, 8, 51, 214, DateTimeKind.Unspecified).AddTicks(794), new TimeSpan(0, 7, 0, 0, 0)), new Guid("786a9718-31c8-f2fa-7aab-0bac5f1e9b3f"), false, true, new DateTimeOffset(new DateTime(2023, 9, 17, 5, 11, 24, 713, DateTimeKind.Unspecified).AddTicks(2672), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("c5958911-a740-1861-7ed5-5224f6098c56"), new Guid("92dc29c8-1055-fe68-1b1c-1fa97be8cebd"), new DateTimeOffset(new DateTime(2023, 6, 28, 2, 39, 43, 331, DateTimeKind.Unspecified).AddTicks(9214), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8a824ff6-5da4-5a90-b481-2ddcd8750729"), false, true, new DateTimeOffset(new DateTime(2023, 7, 11, 0, 32, 28, 962, DateTimeKind.Unspecified).AddTicks(9069), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("cee903fb-653b-0877-add2-e94ecd2895df"), new Guid("3e750e72-baaf-dcae-09f8-58958919c4f7"), new DateTimeOffset(new DateTime(2024, 4, 19, 17, 44, 13, 527, DateTimeKind.Unspecified).AddTicks(8277), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1bea9f71-a600-20c9-1c80-f09d1740b7b9"), true, true, new DateTimeOffset(new DateTime(2024, 1, 24, 19, 27, 45, 121, DateTimeKind.Unspecified).AddTicks(9802), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("d6df8b1d-8747-fa6f-5d3f-efbb55f9f750"), new Guid("ecfd54e4-0562-714b-50c5-b3c9c135e33c"), new DateTimeOffset(new DateTime(2023, 11, 30, 17, 29, 46, 836, DateTimeKind.Unspecified).AddTicks(9042), new TimeSpan(0, 7, 0, 0, 0)), new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"), false, true, new DateTimeOffset(new DateTime(2024, 5, 13, 12, 2, 25, 66, DateTimeKind.Unspecified).AddTicks(4266), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("dca20a0a-9549-e4e1-78b1-99327e3ac5e0"), new Guid("127c7d69-9bd8-fb05-b310-08e536b36c28"), new DateTimeOffset(new DateTime(2023, 8, 1, 15, 49, 40, 356, DateTimeKind.Unspecified).AddTicks(3490), new TimeSpan(0, 7, 0, 0, 0)), new Guid("de9b9d52-a435-67eb-d140-657d5050c5b9"), true, false, new DateTimeOffset(new DateTime(2023, 10, 22, 0, 27, 3, 79, DateTimeKind.Unspecified).AddTicks(3563), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("dd5a993a-834e-5c27-278e-b6b17d3ef20f"), new Guid("3fd8f5fa-4f62-2ff9-5043-3e33fc7bef58"), new DateTimeOffset(new DateTime(2024, 1, 23, 11, 24, 4, 264, DateTimeKind.Unspecified).AddTicks(7801), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1bea9f71-a600-20c9-1c80-f09d1740b7b9"), true, true, new DateTimeOffset(new DateTime(2024, 2, 27, 0, 2, 19, 71, DateTimeKind.Unspecified).AddTicks(3444), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab"), new Guid("43a522de-b5ce-181d-f920-5e853754359a"), new DateTimeOffset(new DateTime(2023, 8, 14, 22, 26, 58, 135, DateTimeKind.Unspecified).AddTicks(2785), new TimeSpan(0, 7, 0, 0, 0)), new Guid("33c32f2c-6294-2427-27ce-133348d2a829"), false, false, new DateTimeOffset(new DateTime(2024, 4, 29, 9, 12, 22, 81, DateTimeKind.Unspecified).AddTicks(6833), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("dfd5e5a3-ad91-6e2a-8169-d69d496e5763"), new Guid("69caa284-6f54-050a-1ec3-6e9841ddbe45"), new DateTimeOffset(new DateTime(2023, 8, 25, 20, 24, 55, 535, DateTimeKind.Unspecified).AddTicks(5722), new TimeSpan(0, 7, 0, 0, 0)), new Guid("15c913df-778a-5837-5d13-48652553d7ec"), true, false, new DateTimeOffset(new DateTime(2024, 2, 14, 18, 58, 8, 852, DateTimeKind.Unspecified).AddTicks(4453), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d"), new Guid("43a522de-b5ce-181d-f920-5e853754359a"), new DateTimeOffset(new DateTime(2023, 7, 5, 16, 25, 29, 72, DateTimeKind.Unspecified).AddTicks(8758), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d1e3e210-a5cc-8b3c-b036-22584367619b"), false, false, new DateTimeOffset(new DateTime(2024, 2, 10, 21, 39, 17, 909, DateTimeKind.Unspecified).AddTicks(4003), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("e562d718-0b40-d9b5-4a50-898507682b0d"), new Guid("f0e4e673-9791-2674-c3e7-318835ff3826"), new DateTimeOffset(new DateTime(2023, 12, 15, 18, 10, 45, 291, DateTimeKind.Unspecified).AddTicks(450), new TimeSpan(0, 7, 0, 0, 0)), new Guid("329db5e7-fa1e-fcc9-05d4-975ed3d8499f"), false, true, new DateTimeOffset(new DateTime(2023, 9, 26, 14, 47, 35, 836, DateTimeKind.Unspecified).AddTicks(8983), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("ef5f70fc-2ced-ad0e-dc74-db7688646ffd"), new Guid("9b5b2c85-3033-3987-b842-af9ad2f401ee"), new DateTimeOffset(new DateTime(2024, 5, 7, 19, 32, 18, 608, DateTimeKind.Unspecified).AddTicks(4158), new TimeSpan(0, 7, 0, 0, 0)), new Guid("31663645-0c09-f634-73cd-57a9e98d762e"), false, true, new DateTimeOffset(new DateTime(2023, 11, 19, 16, 49, 0, 551, DateTimeKind.Unspecified).AddTicks(3172), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("f052cd2b-519e-9ed4-a805-15b413c4587a"), new Guid("3011c86c-bfe7-4b3a-ce71-01f5eeceda98"), new DateTimeOffset(new DateTime(2024, 1, 7, 3, 11, 34, 310, DateTimeKind.Unspecified).AddTicks(973), new TimeSpan(0, 7, 0, 0, 0)), new Guid("945bcd22-15c9-5455-89f7-4e1337084c23"), true, true, new DateTimeOffset(new DateTime(2023, 11, 15, 22, 39, 44, 629, DateTimeKind.Unspecified).AddTicks(2525), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("fee56044-ba9d-cd8d-411f-2c0793b7df38"), new Guid("a5eda47f-1114-87ff-6f4f-f1601aa53201"), new DateTimeOffset(new DateTime(2024, 4, 21, 1, 58, 59, 27, DateTimeKind.Unspecified).AddTicks(3458), new TimeSpan(0, 7, 0, 0, 0)), new Guid("91dfd5e5-2aad-816e-69d6-9d496e5763a3"), true, false, new DateTimeOffset(new DateTime(2024, 3, 5, 0, 23, 44, 362, DateTimeKind.Unspecified).AddTicks(5846), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("072c1f41-b793-38df-5c9a-4619abd61d8b"), new Guid("06278a51-2c88-111e-be6c-94ebbe9406f5"), new DateTimeOffset(new DateTime(2020, 12, 10, 22, 17, 30, 126, DateTimeKind.Unspecified).AddTicks(4141), new TimeSpan(0, 7, 0, 0, 0)), "http://paolo.org", new DateTimeOffset(new DateTime(2020, 11, 20, 2, 4, 19, 389, DateTimeKind.Unspecified).AddTicks(3563), new TimeSpan(0, 7, 0, 0, 0)), new Guid("07f55f54-53db-bc35-fdb4-1e717d9a0efb") },
                    { new Guid("09354983-c222-b1f8-6595-99800ff98b29"), new Guid("1f1fc172-de8f-09d4-b2d2-48077225518c"), new DateTimeOffset(new DateTime(2020, 10, 22, 15, 57, 42, 951, DateTimeKind.Unspecified).AddTicks(685), new TimeSpan(0, 7, 0, 0, 0)), "http://lindsey.biz", new DateTimeOffset(new DateTime(2020, 8, 30, 12, 15, 24, 70, DateTimeKind.Unspecified).AddTicks(5666), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9c3b8b80-ec77-0d7d-387e-ebec94e998eb") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("0d197acc-619b-6d82-f271-9fea1b00a6c9"), new Guid("0493a29e-5c9f-7083-66de-782b4b0aa3e9"), new DateTimeOffset(new DateTime(2020, 9, 20, 1, 59, 57, 796, DateTimeKind.Unspecified).AddTicks(3675), new TimeSpan(0, 7, 0, 0, 0)), true, "https://jayme.org", new DateTimeOffset(new DateTime(2020, 7, 27, 11, 15, 33, 143, DateTimeKind.Unspecified).AddTicks(1905), new TimeSpan(0, 7, 0, 0, 0)), new Guid("18d34369-a53b-032e-483f-3773c3e7b578") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("208bf680-2b14-3712-d52d-64d485abd589"), new Guid("3fd8f5fa-4f62-2ff9-5043-3e33fc7bef58"), new DateTimeOffset(new DateTime(2020, 7, 12, 8, 29, 34, 78, DateTimeKind.Unspecified).AddTicks(4355), new TimeSpan(0, 7, 0, 0, 0)), "https://opal.net", new DateTimeOffset(new DateTime(2020, 8, 22, 14, 2, 51, 750, DateTimeKind.Unspecified).AddTicks(5840), new TimeSpan(0, 7, 0, 0, 0)), new Guid("3140208e-efb5-0baa-5dcf-f3688dfb49d4") },
                    { new Guid("234c0837-e07e-6fb5-dc08-5b8c438fffa9"), new Guid("2702e6e6-01b4-12c7-f857-2a2e74316200"), new DateTimeOffset(new DateTime(2020, 1, 27, 16, 55, 50, 381, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 7, 0, 0, 0)), "http://stanford.info", new DateTimeOffset(new DateTime(2020, 6, 22, 7, 33, 11, 275, DateTimeKind.Unspecified).AddTicks(6197), new TimeSpan(0, 7, 0, 0, 0)), new Guid("660c4f13-ac34-972b-b671-5e720dd466c3") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("273ee7fa-1096-0806-6580-6035ad238abb"), new Guid("25d1af98-3aa3-46f2-ec74-b73f32a89b98"), new DateTimeOffset(new DateTime(2020, 4, 15, 19, 39, 29, 892, DateTimeKind.Unspecified).AddTicks(4558), new TimeSpan(0, 7, 0, 0, 0)), true, "https://april.net", new DateTimeOffset(new DateTime(2020, 10, 22, 7, 44, 14, 293, DateTimeKind.Unspecified).AddTicks(3072), new TimeSpan(0, 7, 0, 0, 0)), new Guid("cf08e502-8911-c595-40a7-61187ed55224") },
                    { new Guid("2d49430d-4e90-f11b-51a9-34225bb3f424"), new Guid("a272346f-6e7b-3bd0-6c34-9e210a9a58f9"), new DateTimeOffset(new DateTime(2020, 4, 25, 0, 41, 21, 899, DateTimeKind.Unspecified).AddTicks(1121), new TimeSpan(0, 7, 0, 0, 0)), true, "https://claire.biz", new DateTimeOffset(new DateTime(2020, 9, 10, 22, 55, 52, 695, DateTimeKind.Unspecified).AddTicks(2577), new TimeSpan(0, 7, 0, 0, 0)), new Guid("660c4f13-ac34-972b-b671-5e720dd466c3") },
                    { new Guid("34660c4f-2bac-b697-715e-720dd466c34f"), new Guid("76309572-1c3d-0b0b-8d0b-44898d0b71ef"), new DateTimeOffset(new DateTime(2020, 1, 9, 23, 46, 18, 401, DateTimeKind.Unspecified).AddTicks(4385), new TimeSpan(0, 7, 0, 0, 0)), true, "http://garret.org", new DateTimeOffset(new DateTime(2020, 8, 19, 7, 8, 25, 325, DateTimeKind.Unspecified).AddTicks(2802), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f29a2a8e-4d8b-a1cd-8c19-b674b6ff66b4") },
                    { new Guid("37778a15-5d58-4813-6525-53d7ec3774d8"), new Guid("d68b7c23-85f9-8075-e44c-4687d3b0fee0"), new DateTimeOffset(new DateTime(2020, 9, 17, 12, 39, 7, 938, DateTimeKind.Unspecified).AddTicks(2816), new TimeSpan(0, 7, 0, 0, 0)), true, "http://aracely.info", new DateTimeOffset(new DateTime(2020, 3, 3, 8, 13, 52, 588, DateTimeKind.Unspecified).AddTicks(9934), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f4e4bdec-d0c1-62a7-fb99-0355c25a4a9d") },
                    { new Guid("3d5d14e4-3fcc-7089-9fe4-9d676b30922d"), new Guid("51b355f6-95d6-d189-d290-b43e07fdb192"), new DateTimeOffset(new DateTime(2020, 10, 9, 1, 5, 9, 814, DateTimeKind.Unspecified).AddTicks(6427), new TimeSpan(0, 7, 0, 0, 0)), true, "http://jerome.org", new DateTimeOffset(new DateTime(2020, 1, 6, 21, 1, 13, 733, DateTimeKind.Unspecified).AddTicks(4917), new TimeSpan(0, 7, 0, 0, 0)), new Guid("3140208e-efb5-0baa-5dcf-f3688dfb49d4") },
                    { new Guid("40d167eb-7d65-5050-c5b9-bd58e5e1a445"), new Guid("8f4ff836-e126-dbd5-09b3-1f3e8190949c"), new DateTimeOffset(new DateTime(2020, 3, 7, 23, 54, 36, 924, DateTimeKind.Unspecified).AddTicks(5847), new TimeSpan(0, 7, 0, 0, 0)), true, "https://tracy.name", new DateTimeOffset(new DateTime(2020, 11, 15, 11, 56, 16, 868, DateTimeKind.Unspecified).AddTicks(8626), new TimeSpan(0, 7, 0, 0, 0)), new Guid("335ac148-c512-5b69-ffda-43761a02659d") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"), new Guid("83e4f60e-ea2b-f473-73f6-909e673cbdeb"), new DateTimeOffset(new DateTime(2020, 7, 27, 0, 47, 48, 494, DateTimeKind.Unspecified).AddTicks(3600), new TimeSpan(0, 7, 0, 0, 0)), "https://kacie.info", new DateTimeOffset(new DateTime(2020, 6, 8, 19, 14, 36, 736, DateTimeKind.Unspecified).AddTicks(399), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6f110748-4060-7943-3d81-f85d8b09c12c") },
                    { new Guid("4431c95f-0a4a-5661-fa39-ba2e69221baa"), new Guid("9c6f8f96-22b1-289a-c54b-5e4dfdad5164"), new DateTimeOffset(new DateTime(2020, 7, 9, 13, 54, 39, 511, DateTimeKind.Unspecified).AddTicks(9340), new TimeSpan(0, 7, 0, 0, 0)), "https://jarrell.net", new DateTimeOffset(new DateTime(2020, 5, 4, 1, 0, 43, 596, DateTimeKind.Unspecified).AddTicks(101), new TimeSpan(0, 7, 0, 0, 0)), new Guid("cf08e502-8911-c595-40a7-61187ed55224") },
                    { new Guid("44ac7e55-012d-2bfb-510c-8e86863eeded"), new Guid("2702e6e6-01b4-12c7-f857-2a2e74316200"), new DateTimeOffset(new DateTime(2020, 11, 10, 23, 15, 48, 6, DateTimeKind.Unspecified).AddTicks(5378), new TimeSpan(0, 7, 0, 0, 0)), "http://cathrine.name", new DateTimeOffset(new DateTime(2020, 1, 23, 21, 48, 16, 487, DateTimeKind.Unspecified).AddTicks(5646), new TimeSpan(0, 7, 0, 0, 0)), new Guid("3ec9b182-31fc-749c-dd38-f3bcb0dede4d") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("470f6997-03fb-cee9-3b65-7708add2e94e"), new Guid("3e750e72-baaf-dcae-09f8-58958919c4f7"), new DateTimeOffset(new DateTime(2020, 2, 3, 23, 27, 2, 441, DateTimeKind.Unspecified).AddTicks(7051), new TimeSpan(0, 7, 0, 0, 0)), true, "https://noemy.com", new DateTimeOffset(new DateTime(2020, 8, 5, 12, 25, 58, 989, DateTimeKind.Unspecified).AddTicks(3117), new TimeSpan(0, 7, 0, 0, 0)), new Guid("3ec9b182-31fc-749c-dd38-f3bcb0dede4d") },
                    { new Guid("519ef052-9ed4-05a8-15b4-13c4587a030c"), new Guid("d50616cd-e87d-fb90-4c81-972b768dde09"), new DateTimeOffset(new DateTime(2020, 5, 26, 16, 51, 16, 961, DateTimeKind.Unspecified).AddTicks(5992), new TimeSpan(0, 7, 0, 0, 0)), true, "http://jaleel.name", new DateTimeOffset(new DateTime(2020, 7, 24, 22, 18, 14, 516, DateTimeKind.Unspecified).AddTicks(3162), new TimeSpan(0, 7, 0, 0, 0)), new Guid("3ece3fb3-867d-a0ec-c08c-c4d7a942e500") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("586f024d-8980-f523-bdce-f26ed8848d04"), new Guid("8891162f-8813-026d-bc01-44d5e3922476"), new DateTimeOffset(new DateTime(2020, 3, 12, 19, 30, 16, 373, DateTimeKind.Unspecified).AddTicks(1082), new TimeSpan(0, 7, 0, 0, 0)), "http://matilde.com", new DateTimeOffset(new DateTime(2020, 10, 11, 7, 47, 8, 409, DateTimeKind.Unspecified).AddTicks(1603), new TimeSpan(0, 7, 0, 0, 0)), new Guid("78f7dc5f-0278-90bd-523a-268de4bc0e49") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("6bbc76b4-a7f7-4c1f-4773-aee30c100642"), new Guid("83e4f60e-ea2b-f473-73f6-909e673cbdeb"), new DateTimeOffset(new DateTime(2020, 9, 8, 9, 39, 18, 144, DateTimeKind.Unspecified).AddTicks(9000), new TimeSpan(0, 7, 0, 0, 0)), true, "https://frederic.info", new DateTimeOffset(new DateTime(2020, 10, 22, 4, 52, 8, 231, DateTimeKind.Unspecified).AddTicks(255), new TimeSpan(0, 7, 0, 0, 0)), new Guid("31c8786a-f2fa-ab7a-0bac-5f1e9b3f2bcd") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("6cbda0e8-a72b-72d6-050a-8f8922cd5b94"), new Guid("7eeca4f2-d4f4-da46-7745-00fb969be0df"), new DateTimeOffset(new DateTime(2020, 8, 31, 13, 55, 4, 355, DateTimeKind.Unspecified).AddTicks(501), new TimeSpan(0, 7, 0, 0, 0)), "https://loren.name", new DateTimeOffset(new DateTime(2020, 1, 1, 19, 13, 11, 383, DateTimeKind.Unspecified).AddTicks(5758), new TimeSpan(0, 7, 0, 0, 0)), new Guid("333a1cdf-9180-489a-54b3-b6f44bf638e2") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("6d1eab15-d275-d365-3d5c-153a9787de8d"), new Guid("a5eda47f-1114-87ff-6f4f-f1601aa53201"), new DateTimeOffset(new DateTime(2020, 9, 14, 23, 41, 43, 347, DateTimeKind.Unspecified).AddTicks(6497), new TimeSpan(0, 7, 0, 0, 0)), true, "http://jonathon.org", new DateTimeOffset(new DateTime(2020, 1, 19, 16, 20, 22, 899, DateTimeKind.Unspecified).AddTicks(7981), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f4e4bdec-d0c1-62a7-fb99-0355c25a4a9d") },
                    { new Guid("6e499dd6-6357-7ca3-45fb-1f8ba41e25e0"), new Guid("8f4ff836-e126-dbd5-09b3-1f3e8190949c"), new DateTimeOffset(new DateTime(2020, 5, 12, 9, 39, 6, 104, DateTimeKind.Unspecified).AddTicks(8526), new TimeSpan(0, 7, 0, 0, 0)), true, "https://reba.name", new DateTimeOffset(new DateTime(2020, 6, 16, 3, 28, 7, 196, DateTimeKind.Unspecified).AddTicks(445), new TimeSpan(0, 7, 0, 0, 0)), new Guid("60e01340-3a21-225b-1cfd-f38583c3b73c") },
                    { new Guid("71a777e1-9a27-4449-4df5-62d9b0a72436"), new Guid("2702e6e6-01b4-12c7-f857-2a2e74316200"), new DateTimeOffset(new DateTime(2020, 5, 1, 15, 32, 44, 760, DateTimeKind.Unspecified).AddTicks(5218), new TimeSpan(0, 7, 0, 0, 0)), true, "http://caleb.info", new DateTimeOffset(new DateTime(2020, 1, 10, 3, 56, 23, 465, DateTimeKind.Unspecified).AddTicks(9836), new TimeSpan(0, 7, 0, 0, 0)), new Guid("60e01340-3a21-225b-1cfd-f38583c3b73c") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("76db74dc-6488-fd6f-2dc4-98c6ecbda3e5"), new Guid("92dc29c8-1055-fe68-1b1c-1fa97be8cebd"), new DateTimeOffset(new DateTime(2020, 8, 20, 20, 16, 23, 203, DateTimeKind.Unspecified).AddTicks(428), new TimeSpan(0, 7, 0, 0, 0)), "http://danyka.info", new DateTimeOffset(new DateTime(2020, 2, 20, 19, 7, 51, 344, DateTimeKind.Unspecified).AddTicks(4345), new TimeSpan(0, 7, 0, 0, 0)), new Guid("333a1cdf-9180-489a-54b3-b6f44bf638e2") },
                    { new Guid("835381de-6fb1-580a-350e-f0f5e74a7565"), new Guid("7eeca4f2-d4f4-da46-7745-00fb969be0df"), new DateTimeOffset(new DateTime(2020, 4, 13, 17, 1, 0, 884, DateTimeKind.Unspecified).AddTicks(3627), new TimeSpan(0, 7, 0, 0, 0)), "https://anthony.org", new DateTimeOffset(new DateTime(2020, 2, 24, 21, 38, 22, 83, DateTimeKind.Unspecified).AddTicks(9488), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1d16222e-1f0e-1a0c-5815-5e539e98ce71") },
                    { new Guid("8752ae2b-1d50-b4b8-7d7f-a37ad24f0319"), new Guid("fc782382-6898-3940-dec5-4409f8c4fa93"), new DateTimeOffset(new DateTime(2020, 6, 20, 2, 54, 43, 526, DateTimeKind.Unspecified).AddTicks(1230), new TimeSpan(0, 7, 0, 0, 0)), "http://ozella.org", new DateTimeOffset(new DateTime(2020, 5, 29, 5, 5, 50, 377, DateTimeKind.Unspecified).AddTicks(5220), new TimeSpan(0, 7, 0, 0, 0)), new Guid("60e01340-3a21-225b-1cfd-f38583c3b73c") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("8bccb0b9-fc46-b19c-0a0a-a2dc4995e1e4"), new Guid("f8c04973-8c15-fad4-da69-c16372e3e554"), new DateTimeOffset(new DateTime(2020, 4, 5, 2, 17, 42, 549, DateTimeKind.Unspecified).AddTicks(7961), new TimeSpan(0, 7, 0, 0, 0)), true, "https://gianni.name", new DateTimeOffset(new DateTime(2020, 7, 6, 16, 41, 49, 314, DateTimeKind.Unspecified).AddTicks(9897), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f046ac78-05d2-c7c1-40ea-bf733a9492ed") },
                    { new Guid("8d52a62d-d0a9-fe70-5e75-1ab3d87fc5cc"), new Guid("83e4f60e-ea2b-f473-73f6-909e673cbdeb"), new DateTimeOffset(new DateTime(2020, 12, 27, 18, 49, 42, 41, DateTimeKind.Unspecified).AddTicks(5112), new TimeSpan(0, 7, 0, 0, 0)), true, "http://tad.biz", new DateTimeOffset(new DateTime(2020, 3, 3, 22, 30, 55, 391, DateTimeKind.Unspecified).AddTicks(871), new TimeSpan(0, 7, 0, 0, 0)), new Guid("60e01340-3a21-225b-1cfd-f38583c3b73c") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("8de07c9f-8317-bde3-52b5-9b65adced5fa"), new Guid("230d8922-1828-483c-7858-c33ace94d9e3"), new DateTimeOffset(new DateTime(2020, 1, 1, 19, 23, 54, 762, DateTimeKind.Unspecified).AddTicks(5849), new TimeSpan(0, 7, 0, 0, 0)), "http://bettie.net", new DateTimeOffset(new DateTime(2020, 6, 20, 11, 8, 12, 390, DateTimeKind.Unspecified).AddTicks(389), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9c3b8b80-ec77-0d7d-387e-ebec94e998eb") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"), new Guid("21a19a75-c397-f2f7-c138-1c350582a9e4"), new DateTimeOffset(new DateTime(2020, 11, 6, 12, 35, 15, 882, DateTimeKind.Unspecified).AddTicks(9721), new TimeSpan(0, 7, 0, 0, 0)), true, "http://simone.name", new DateTimeOffset(new DateTime(2020, 4, 7, 14, 17, 44, 211, DateTimeKind.Unspecified).AddTicks(6056), new TimeSpan(0, 7, 0, 0, 0)), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("8f580d2b-c771-8dd8-e8e7-b59d321efac9"), new Guid("7e9c4417-9abe-fd77-e589-9fecf460cd25"), new DateTimeOffset(new DateTime(2020, 9, 16, 0, 17, 18, 289, DateTimeKind.Unspecified).AddTicks(5609), new TimeSpan(0, 7, 0, 0, 0)), "https://tyler.name", new DateTimeOffset(new DateTime(2020, 12, 21, 5, 10, 51, 604, DateTimeKind.Unspecified).AddTicks(516), new TimeSpan(0, 7, 0, 0, 0)), new Guid("3140208e-efb5-0baa-5dcf-f3688dfb49d4") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("905da48a-b45a-2d81-dcd8-750729b4372c"), new Guid("d8ba0acf-0390-1c22-d57c-1ed83e20da2d"), new DateTimeOffset(new DateTime(2020, 3, 25, 2, 2, 32, 631, DateTimeKind.Unspecified).AddTicks(2147), new TimeSpan(0, 7, 0, 0, 0)), true, "http://lucienne.name", new DateTimeOffset(new DateTime(2020, 5, 5, 0, 45, 40, 143, DateTimeKind.Unspecified).AddTicks(2959), new TimeSpan(0, 7, 0, 0, 0)), new Guid("958622b0-9ce3-bd80-11a2-342663de9bee") },
                    { new Guid("93e6a9f2-626c-3369-ef85-5ab90a53b0f5"), new Guid("b307a8f1-8763-7935-2985-aef5229e12e8"), new DateTimeOffset(new DateTime(2020, 6, 11, 11, 41, 47, 844, DateTimeKind.Unspecified).AddTicks(5273), new TimeSpan(0, 7, 0, 0, 0)), true, "http://donna.biz", new DateTimeOffset(new DateTime(2020, 12, 25, 13, 22, 30, 637, DateTimeKind.Unspecified).AddTicks(1409), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1d16222e-1f0e-1a0c-5815-5e539e98ce71") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new Guid("3fa48bde-c787-08ca-f634-04c6ceec6dfd"), new DateTimeOffset(new DateTime(2020, 8, 30, 0, 38, 16, 925, DateTimeKind.Unspecified).AddTicks(600), new TimeSpan(0, 7, 0, 0, 0)), "https://darron.net", new DateTimeOffset(new DateTime(2020, 9, 2, 6, 3, 4, 571, DateTimeKind.Unspecified).AddTicks(871), new TimeSpan(0, 7, 0, 0, 0)), new Guid("88df2f3a-6795-d362-6d43-591ec672055d") },
                    { new Guid("9b616743-64aa-d99f-f78f-1a58970f7896"), new Guid("8891162f-8813-026d-bc01-44d5e3922476"), new DateTimeOffset(new DateTime(2020, 4, 7, 19, 48, 40, 196, DateTimeKind.Unspecified).AddTicks(6126), new TimeSpan(0, 7, 0, 0, 0)), "https://nelle.name", new DateTimeOffset(new DateTime(2020, 7, 7, 22, 40, 45, 671, DateTimeKind.Unspecified).AddTicks(480), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1d16222e-1f0e-1a0c-5815-5e539e98ce71") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("9ec7cf01-d42c-fda1-8116-fa3d097e66c5"), new Guid("a272346f-6e7b-3bd0-6c34-9e210a9a58f9"), new DateTimeOffset(new DateTime(2020, 12, 30, 16, 6, 44, 836, DateTimeKind.Unspecified).AddTicks(7234), new TimeSpan(0, 7, 0, 0, 0)), true, "http://maximillia.biz", new DateTimeOffset(new DateTime(2020, 10, 29, 23, 2, 1, 119, DateTimeKind.Unspecified).AddTicks(491), new TimeSpan(0, 7, 0, 0, 0)), new Guid("660c4f13-ac34-972b-b671-5e720dd466c3") },
                    { new Guid("a886f76d-e63c-8046-ed81-68bd10e2e3d1"), new Guid("69caa284-6f54-050a-1ec3-6e9841ddbe45"), new DateTimeOffset(new DateTime(2020, 8, 11, 12, 27, 58, 191, DateTimeKind.Unspecified).AddTicks(5620), new TimeSpan(0, 7, 0, 0, 0)), true, "http://sylvan.net", new DateTimeOffset(new DateTime(2020, 7, 23, 23, 39, 33, 336, DateTimeKind.Unspecified).AddTicks(2445), new TimeSpan(0, 7, 0, 0, 0)), new Guid("3ece3fb3-867d-a0ec-c08c-c4d7a942e500") },
                    { new Guid("b0645df7-a1a4-b5a1-3962-54ea94f627f5"), new Guid("4009c9b3-f618-5fff-134b-47a79f0fdc72"), new DateTimeOffset(new DateTime(2020, 12, 18, 22, 24, 38, 496, DateTimeKind.Unspecified).AddTicks(9735), new TimeSpan(0, 7, 0, 0, 0)), true, "http://earnest.biz", new DateTimeOffset(new DateTime(2020, 5, 2, 13, 44, 44, 1, DateTimeKind.Unspecified).AddTicks(6655), new TimeSpan(0, 7, 0, 0, 0)), new Guid("335ac148-c512-5b69-ffda-43761a02659d") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("c61e5943-0572-475d-c2ed-18d762e5400b"), new Guid("a272346f-6e7b-3bd0-6c34-9e210a9a58f9"), new DateTimeOffset(new DateTime(2020, 1, 20, 17, 43, 34, 304, DateTimeKind.Unspecified).AddTicks(9135), new TimeSpan(0, 7, 0, 0, 0)), "http://concepcion.biz", new DateTimeOffset(new DateTime(2020, 10, 25, 4, 35, 8, 60, DateTimeKind.Unspecified).AddTicks(6984), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7c844000-8c04-39ea-0259-b55207b2c092") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("ce272427-3313-d248-a829-fd66c5668262"), new Guid("4009c9b3-f618-5fff-134b-47a79f0fdc72"), new DateTimeOffset(new DateTime(2020, 9, 13, 9, 59, 26, 471, DateTimeKind.Unspecified).AddTicks(5189), new TimeSpan(0, 7, 0, 0, 0)), true, "http://agnes.net", new DateTimeOffset(new DateTime(2020, 7, 5, 14, 37, 40, 355, DateTimeKind.Unspecified).AddTicks(7921), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1233f8f5-32db-7367-7ee3-dac050c8d597") },
                    { new Guid("d382d930-5ce3-fc19-a249-af962f5f0ce2"), new Guid("21113ab3-a8e3-d3de-a9d6-d2d7bdd33bc3"), new DateTimeOffset(new DateTime(2020, 1, 20, 7, 42, 9, 565, DateTimeKind.Unspecified).AddTicks(9209), new TimeSpan(0, 7, 0, 0, 0)), true, "https://reba.com", new DateTimeOffset(new DateTime(2020, 4, 2, 15, 14, 46, 882, DateTimeKind.Unspecified).AddTicks(6824), new TimeSpan(0, 7, 0, 0, 0)), new Guid("3140208e-efb5-0baa-5dcf-f3688dfb49d4") },
                    { new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab"), new Guid("43a522de-b5ce-181d-f920-5e853754359a"), new DateTimeOffset(new DateTime(2020, 3, 4, 6, 35, 3, 882, DateTimeKind.Unspecified).AddTicks(6650), new TimeSpan(0, 7, 0, 0, 0)), true, "http://marlene.org", new DateTimeOffset(new DateTime(2020, 11, 19, 3, 21, 24, 374, DateTimeKind.Unspecified).AddTicks(892), new TimeSpan(0, 7, 0, 0, 0)), new Guid("059f0b6a-1940-021d-901e-108a95bc55cb") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("e502f9c9-cf08-8911-95c5-40a761187ed5"), new Guid("d68b7c23-85f9-8075-e44c-4687d3b0fee0"), new DateTimeOffset(new DateTime(2020, 3, 4, 8, 32, 32, 852, DateTimeKind.Unspecified).AddTicks(7627), new TimeSpan(0, 7, 0, 0, 0)), "http://sigurd.name", new DateTimeOffset(new DateTime(2020, 3, 13, 19, 58, 27, 22, DateTimeKind.Unspecified).AddTicks(4382), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f3dcdac7-43a2-0adf-530c-9653f4b2c78d") },
                    { new Guid("e9a957cd-768d-372e-54d3-4cf08bd2e2e7"), new Guid("69caa284-6f54-050a-1ec3-6e9841ddbe45"), new DateTimeOffset(new DateTime(2020, 12, 8, 10, 58, 47, 193, DateTimeKind.Unspecified).AddTicks(7078), new TimeSpan(0, 7, 0, 0, 0)), "https://macie.org", new DateTimeOffset(new DateTime(2020, 3, 28, 19, 1, 11, 310, DateTimeKind.Unspecified).AddTicks(8367), new TimeSpan(0, 7, 0, 0, 0)), new Guid("958622b0-9ce3-bd80-11a2-342663de9bee") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("ec779c3b-0d7d-7e38-ebec-94e998eb0c68"), new Guid("7b04bb20-cbba-8555-0d9a-5e5834745d1d"), new DateTimeOffset(new DateTime(2020, 4, 10, 18, 50, 49, 172, DateTimeKind.Unspecified).AddTicks(2274), new TimeSpan(0, 7, 0, 0, 0)), true, "http://linda.org", new DateTimeOffset(new DateTime(2020, 6, 11, 16, 32, 45, 765, DateTimeKind.Unspecified).AddTicks(7752), new TimeSpan(0, 7, 0, 0, 0)), new Guid("609afabf-efdb-fb3f-7207-2583625812b2") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("f5a7c23f-e018-9b7e-5202-b062f68e93af"), new Guid("f8c04973-8c15-fad4-da69-c16372e3e554"), new DateTimeOffset(new DateTime(2020, 9, 30, 22, 41, 15, 33, DateTimeKind.Unspecified).AddTicks(7936), new TimeSpan(0, 7, 0, 0, 0)), "https://roosevelt.net", new DateTimeOffset(new DateTime(2020, 10, 4, 20, 1, 40, 911, DateTimeKind.Unspecified).AddTicks(265), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7f5038db-db10-9886-e48c-3e1f519a4cfc") },
                    { new Guid("f608ca7f-8f54-ca59-a88e-37a92300d6a4"), new Guid("f8c04973-8c15-fad4-da69-c16372e3e554"), new DateTimeOffset(new DateTime(2020, 3, 11, 17, 31, 40, 530, DateTimeKind.Unspecified).AddTicks(2693), new TimeSpan(0, 7, 0, 0, 0)), "https://antonio.biz", new DateTimeOffset(new DateTime(2020, 1, 6, 13, 50, 57, 171, DateTimeKind.Unspecified).AddTicks(5185), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f4e4bdec-d0c1-62a7-fb99-0355c25a4a9d") },
                    { new Guid("f955bbef-50f7-6de5-ce5a-4d978476ab3a"), new Guid("f1bc12e3-c49a-c11a-5ea9-86da5b57bd3f"), new DateTimeOffset(new DateTime(2020, 11, 7, 22, 3, 20, 43, DateTimeKind.Unspecified).AddTicks(9999), new TimeSpan(0, 7, 0, 0, 0)), "http://selina.biz", new DateTimeOffset(new DateTime(2020, 3, 16, 3, 1, 38, 621, DateTimeKind.Unspecified).AddTicks(5180), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6f110748-4060-7943-3d81-f85d8b09c12c") },
                    { new Guid("fba953a9-7f00-ad94-4550-9c544966eb7f"), new Guid("7e9c4417-9abe-fd77-e589-9fecf460cd25"), new DateTimeOffset(new DateTime(2020, 6, 15, 17, 27, 56, 908, DateTimeKind.Unspecified).AddTicks(3077), new TimeSpan(0, 7, 0, 0, 0)), "http://alf.biz", new DateTimeOffset(new DateTime(2020, 6, 16, 5, 20, 55, 722, DateTimeKind.Unspecified).AddTicks(2799), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4e7220ff-01af-050f-260e-566ab34b8a58") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"), new Guid("06278a51-2c88-111e-be6c-94ebbe9406f5"), new DateTimeOffset(new DateTime(2020, 11, 11, 16, 5, 48, 103, DateTimeKind.Unspecified).AddTicks(9392), new TimeSpan(0, 7, 0, 0, 0)), true, "https://keely.com", new DateTimeOffset(new DateTime(2020, 3, 21, 18, 52, 52, 366, DateTimeKind.Unspecified).AddTicks(8117), new TimeSpan(0, 7, 0, 0, 0)), new Guid("2096d739-97f1-5726-27cd-ede8d3504da0") },
                    { new Guid("ffd7dafa-8d35-ae04-36c7-ca601a039984"), new Guid("7b04bb20-cbba-8555-0d9a-5e5834745d1d"), new DateTimeOffset(new DateTime(2020, 10, 19, 15, 3, 6, 182, DateTimeKind.Unspecified).AddTicks(4795), new TimeSpan(0, 7, 0, 0, 0)), true, "http://ulises.net", new DateTimeOffset(new DateTime(2020, 7, 5, 3, 46, 2, 269, DateTimeKind.Unspecified).AddTicks(9562), new TimeSpan(0, 7, 0, 0, 0)), new Guid("61674358-aa9b-9f64-d9f7-8f1a58970f78") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[] { new Guid("0775d8dc-b429-2c37-2ad5-ffa8623d5cea"), "Completed", new Guid("3e750e72-baaf-dcae-09f8-58958919c4f7"), new Guid("9f71f26d-1bea-a600-c920-1c80f09d1740"), new DateTimeOffset(new DateTime(2020, 8, 6, 15, 19, 49, 842, DateTimeKind.Unspecified).AddTicks(531), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a89ed451-1505-13b4-c458-7a030c759f3f"), new DateTimeOffset(new DateTime(2020, 9, 1, 7, 15, 55, 440, DateTimeKind.Unspecified).AddTicks(8434), new TimeSpan(0, 7, 0, 0, 0)), 1, "9:00 AM", new Guid("a70e2abe-63c2-d3ef-4c81-3e6c0feb02be") });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("09354983-c222-b1f8-6595-99800ff98b29"), "Confirmed", new Guid("3011c86c-bfe7-4b3a-ce71-01f5eeceda98"), new Guid("87973a15-8dde-6aed-3a99-5add4e83275c"), new DateTimeOffset(new DateTime(2020, 2, 3, 2, 35, 51, 337, DateTimeKind.Unspecified).AddTicks(9364), new TimeSpan(0, 7, 0, 0, 0)), new Guid("568c09f6-f8f3-7e55-ac44-2d01fb2b510c"), true, new DateTimeOffset(new DateTime(2020, 7, 9, 16, 9, 48, 440, DateTimeKind.Unspecified).AddTicks(5556), new TimeSpan(0, 7, 0, 0, 0)), 3, "10:00 AM", new Guid("883f6641-68e4-d729-affb-e4c4535dc8e2") },
                    { new Guid("09f62452-568c-f8f3-557e-ac442d01fb2b"), "Pending", new Guid("5d7c09a1-50cf-c09e-103d-b97e2dac22f8"), new Guid("ecc698c4-a3bd-d5e5-df91-ad2a6e8169d6"), new DateTimeOffset(new DateTime(2020, 1, 13, 2, 49, 56, 24, DateTimeKind.Unspecified).AddTicks(3630), new TimeSpan(0, 7, 0, 0, 0)), new Guid("2cedef5f-ad0e-74dc-db76-88646ffd2dc4"), true, new DateTimeOffset(new DateTime(2020, 11, 23, 2, 38, 5, 756, DateTimeKind.Unspecified).AddTicks(7608), new TimeSpan(0, 7, 0, 0, 0)), 1, "10:00 AM", new Guid("f4e4bdec-d0c1-62a7-fb99-0355c25a4a9d") },
                    { new Guid("0c4f13f2-3466-2bac-97b6-715e720dd466"), "Confirmed", new Guid("69caa284-6f54-050a-1ec3-6e9841ddbe45"), new Guid("edc2475d-d718-e562-400b-b5d94a508985"), new DateTimeOffset(new DateTime(2020, 1, 9, 23, 46, 18, 401, DateTimeKind.Unspecified).AddTicks(4385), new TimeSpan(0, 7, 0, 0, 0)), new Guid("fa6f8747-3f5d-bbef-55f9-f750e56dce5a"), true, new DateTimeOffset(new DateTime(2020, 8, 19, 7, 8, 25, 325, DateTimeKind.Unspecified).AddTicks(2802), new TimeSpan(0, 7, 0, 0, 0)), 4, "1:00 PM", new Guid("31c8786a-f2fa-ab7a-0bac-5f1e9b3f2bcd") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("0d197acc-619b-6d82-f271-9fea1b00a6c9"), "Confirmed", new Guid("f0e4e673-9791-2674-c3e7-318835ff3826"), new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"), new DateTimeOffset(new DateTime(2020, 11, 3, 12, 43, 52, 682, DateTimeKind.Unspecified).AddTicks(7039), new TimeSpan(0, 7, 0, 0, 0)), new Guid("786a9718-31c8-f2fa-7aab-0bac5f1e9b3f"), new DateTimeOffset(new DateTime(2020, 6, 21, 13, 51, 57, 810, DateTimeKind.Unspecified).AddTicks(9401), new TimeSpan(0, 7, 0, 0, 0)), 3, "11:00 AM", new Guid("2096d739-97f1-5726-27cd-ede8d3504da0") },
                    { new Guid("134ef789-0837-234c-7ee0-b56fdc085b8c"), "Confirmed", new Guid("8f4ff836-e126-dbd5-09b3-1f3e8190949c"), new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"), new DateTimeOffset(new DateTime(2020, 11, 16, 9, 2, 55, 491, DateTimeKind.Unspecified).AddTicks(5598), new TimeSpan(0, 7, 0, 0, 0)), new Guid("ec779c3b-0d7d-7e38-ebec-94e998eb0c68"), new DateTimeOffset(new DateTime(2020, 6, 19, 20, 5, 33, 975, DateTimeKind.Unspecified).AddTicks(5038), new TimeSpan(0, 7, 0, 0, 0)), 2, "10:00 PM", new Guid("97eb2ed4-df10-55bd-d364-a3db4a109f23") },
                    { new Guid("15d6a64d-3c92-41f9-295a-5fc931444a0a"), "Pending", new Guid("f0e4e673-9791-2674-c3e7-318835ff3826"), new Guid("5837778a-135d-6548-2553-d7ec3774d8f5"), new DateTimeOffset(new DateTime(2020, 6, 25, 22, 38, 45, 908, DateTimeKind.Unspecified).AddTicks(5111), new TimeSpan(0, 7, 0, 0, 0)), new Guid("01ad3228-c7cf-2c9e-d4a1-fd8116fa3d09"), new DateTimeOffset(new DateTime(2020, 10, 12, 13, 38, 39, 382, DateTimeKind.Unspecified).AddTicks(9631), new TimeSpan(0, 7, 0, 0, 0)), 2, "7:00 AM", new Guid("883f6641-68e4-d729-affb-e4c4535dc8e2") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("1681fda1-3dfa-7e09-66c5-fd012c2fc333"), "Cancelled", new Guid("bfb312c3-362b-ec49-fcb7-61f2db22d65c"), new Guid("8bc880c5-bc39-a62d-528d-a9d070fe5e75"), new DateTimeOffset(new DateTime(2020, 10, 14, 0, 48, 9, 934, DateTimeKind.Unspecified).AddTicks(1552), new TimeSpan(0, 7, 0, 0, 0)), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), true, new DateTimeOffset(new DateTime(2020, 8, 5, 23, 46, 0, 972, DateTimeKind.Unspecified).AddTicks(2432), new TimeSpan(0, 7, 0, 0, 0)), 2, "8:00 PM", new Guid("31c8786a-f2fa-ab7a-0bac-5f1e9b3f2bcd") },
                    { new Guid("19aad1fe-5653-b064-e414-5d3dcc3f8970"), "Completed", new Guid("51b355f6-95d6-d189-d290-b43e07fdb192"), new Guid("bde38317-b552-659b-adce-d5fa148bef7b"), new DateTimeOffset(new DateTime(2020, 6, 12, 15, 57, 25, 88, DateTimeKind.Unspecified).AddTicks(393), new TimeSpan(0, 7, 0, 0, 0)), new Guid("15c913df-778a-5837-5d13-48652553d7ec"), true, new DateTimeOffset(new DateTime(2020, 8, 10, 17, 33, 54, 43, DateTimeKind.Unspecified).AddTicks(5263), new TimeSpan(0, 7, 0, 0, 0)), 3, "3:00 PM", new Guid("1c32f657-87c5-33dc-2dda-a177a4571d84") },
                    { new Guid("1e329db5-c9fa-05fc-d497-5ed3d8499f7c"), "Completed", new Guid("5d7c09a1-50cf-c09e-103d-b97e2dac22f8"), new Guid("81b45a90-dc2d-75d8-0729-b4372c2ad5ff"), new DateTimeOffset(new DateTime(2020, 4, 5, 14, 28, 56, 88, DateTimeKind.Unspecified).AddTicks(7904), new TimeSpan(0, 7, 0, 0, 0)), new Guid("72ff2f81-65bc-ae2b-5287-501db8b47d7f"), true, new DateTimeOffset(new DateTime(2020, 10, 29, 5, 57, 43, 860, DateTimeKind.Unspecified).AddTicks(3340), new TimeSpan(0, 7, 0, 0, 0)), 3, "10:00 PM", new Guid("4e7220ff-01af-050f-260e-566ab34b8a58") },
                    { new Guid("1f24a4b5-b43c-e7fa-3e27-961006086580"), "Cancelled", new Guid("a272346f-6e7b-3bd0-6c34-9e210a9a58f9"), new Guid("f62452d5-8c09-f356-f855-7eac442d01fb"), new DateTimeOffset(new DateTime(2020, 12, 4, 21, 27, 47, 746, DateTimeKind.Unspecified).AddTicks(2103), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a1a1a4b0-39b5-5462-ea94-f627f5d5eee0"), true, new DateTimeOffset(new DateTime(2020, 4, 10, 10, 32, 3, 183, DateTimeKind.Unspecified).AddTicks(6585), new TimeSpan(0, 7, 0, 0, 0)), 1, "10:00 AM", new Guid("b35b2234-24f4-2054-ad1a-71ce513a15ab") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[] { new Guid("38dfb793-9a5c-1946-abd6-1d8bdfd64787"), "Pending", new Guid("f1bc12e3-c49a-c11a-5ea9-86da5b57bd3f"), new Guid("0945e751-80eb-8bf6-2014-2b1237d52d64"), new DateTimeOffset(new DateTime(2020, 3, 16, 6, 2, 15, 902, DateTimeKind.Unspecified).AddTicks(9946), new TimeSpan(0, 7, 0, 0, 0)), new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"), new DateTimeOffset(new DateTime(2020, 5, 2, 1, 48, 5, 235, DateTimeKind.Unspecified).AddTicks(4765), new TimeSpan(0, 7, 0, 0, 0)), 1, "9:00 PM", new Guid("1c32f657-87c5-33dc-2dda-a177a4571d84") });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("4206100c-318e-34ba-525e-7c82b1c93efc"), "Completed", new Guid("a5eda47f-1114-87ff-6f4f-f1601aa53201"), new Guid("04decd26-5c08-997b-9769-0f47fb03e9ce"), new DateTimeOffset(new DateTime(2020, 8, 15, 6, 27, 26, 793, DateTimeKind.Unspecified).AddTicks(9351), new TimeSpan(0, 7, 0, 0, 0)), new Guid("586f024d-8980-f523-bdce-f26ed8848d04"), true, new DateTimeOffset(new DateTime(2020, 12, 17, 6, 25, 21, 515, DateTimeKind.Unspecified).AddTicks(9986), new TimeSpan(0, 7, 0, 0, 0)), 2, "6:00 PM", new Guid("4e7220ff-01af-050f-260e-566ab34b8a58") },
                    { new Guid("430defcb-2d49-4e90-1bf1-51a934225bb3"), "Completed", new Guid("92dc29c8-1055-fe68-1b1c-1fa97be8cebd"), new Guid("8364bab3-3549-2209-c2f8-b1659599800f"), new DateTimeOffset(new DateTime(2020, 4, 25, 0, 41, 21, 899, DateTimeKind.Unspecified).AddTicks(1121), new TimeSpan(0, 7, 0, 0, 0)), new Guid("c962b121-02f9-08e5-cf11-8995c540a761"), true, new DateTimeOffset(new DateTime(2020, 9, 10, 22, 55, 52, 695, DateTimeKind.Unspecified).AddTicks(2577), new TimeSpan(0, 7, 0, 0, 0)), 1, "9:00 AM", new Guid("6f110748-4060-7943-3d81-f85d8b09c12c") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[] { new Guid("581a8ff7-0f97-9678-3822-8c51e74509eb"), "Confirmed", new Guid("0493a29e-5c9f-7083-66de-782b4b0aa3e9"), new Guid("0c4f13f2-3466-2bac-97b6-715e720dd466"), new DateTimeOffset(new DateTime(2020, 11, 3, 6, 58, 6, 227, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 7, 0, 0, 0)), new Guid("438c5b08-ff8f-36a9-1b81-7cae63cbef0d"), new DateTimeOffset(new DateTime(2020, 10, 20, 9, 51, 34, 696, DateTimeKind.Unspecified).AddTicks(1255), new TimeSpan(0, 7, 0, 0, 0)), 4, "12:00 PM", new Guid("7f5038db-db10-9886-e48c-3e1f519a4cfc") });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[] { new Guid("5ace6de5-974d-7684-ab3a-2fdf88956762"), "Confirmed", new Guid("1f1fc172-de8f-09d4-b2d2-48077225518c"), new Guid("9f71f26d-1bea-a600-c920-1c80f09d1740"), new DateTimeOffset(new DateTime(2020, 3, 16, 11, 9, 37, 19, DateTimeKind.Unspecified).AddTicks(6342), new TimeSpan(0, 7, 0, 0, 0)), new Guid("ec779c3b-0d7d-7e38-ebec-94e998eb0c68"), true, new DateTimeOffset(new DateTime(2020, 4, 23, 11, 52, 6, 400, DateTimeKind.Unspecified).AddTicks(5368), new TimeSpan(0, 7, 0, 0, 0)), 3, "8:00 PM", new Guid("78f7dc5f-0278-90bd-523a-268de4bc0e49") });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[] { new Guid("626c93e6-3369-85ef-5ab9-0a53b0f5a847"), "Confirmed", new Guid("f0e4e673-9791-2674-c3e7-318835ff3826"), new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"), new DateTimeOffset(new DateTime(2020, 7, 7, 6, 1, 11, 341, DateTimeKind.Unspecified).AddTicks(1641), new TimeSpan(0, 7, 0, 0, 0)), new Guid("31663645-0c09-f634-73cd-57a9e98d762e"), new DateTimeOffset(new DateTime(2020, 5, 10, 20, 52, 37, 915, DateTimeKind.Unspecified).AddTicks(4484), new TimeSpan(0, 7, 0, 0, 0)), 1, "3:00 PM", new Guid("883f6641-68e4-d729-affb-e4c4535dc8e2") });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("66bd048d-0f76-2191-b162-c9f902e508cf"), "Confirmed", new Guid("ecfd54e4-0562-714b-50c5-b3c9c135e33c"), new Guid("0bab7af2-5fac-9b1e-3f2b-cd52f09e51d4"), new DateTimeOffset(new DateTime(2020, 8, 22, 16, 58, 54, 890, DateTimeKind.Unspecified).AddTicks(6384), new TimeSpan(0, 7, 0, 0, 0)), new Guid("15c913df-778a-5837-5d13-48652553d7ec"), true, new DateTimeOffset(new DateTime(2020, 10, 27, 1, 43, 56, 227, DateTimeKind.Unspecified).AddTicks(1308), new TimeSpan(0, 7, 0, 0, 0)), 4, "9:00 AM", new Guid("18d34369-a53b-032e-483f-3773c3e7b578") },
                    { new Guid("66fd29a8-66c5-6282-26cd-de04085c7b99"), "Confirmed", new Guid("28e6c30d-ecf2-2b5e-8579-6a8da40c4c08"), new Guid("6d13d55f-c23f-f5a7-18e0-7e9b5202b062"), new DateTimeOffset(new DateTime(2020, 2, 17, 6, 19, 4, 667, DateTimeKind.Unspecified).AddTicks(9922), new TimeSpan(0, 7, 0, 0, 0)), new Guid("31663645-0c09-f634-73cd-57a9e98d762e"), true, new DateTimeOffset(new DateTime(2020, 11, 26, 18, 38, 26, 979, DateTimeKind.Unspecified).AddTicks(6726), new TimeSpan(0, 7, 0, 0, 0)), 4, "1:00 PM", new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[] { new Guid("6d1eab15-d275-d365-3d5c-153a9787de8d"), "Completed", new Guid("1f1fc172-de8f-09d4-b2d2-48077225518c"), new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"), new DateTimeOffset(new DateTime(2020, 10, 31, 8, 24, 2, 344, DateTimeKind.Unspecified).AddTicks(9299), new TimeSpan(0, 7, 0, 0, 0)), new Guid("de9b9d52-a435-67eb-d140-657d5050c5b9"), new DateTimeOffset(new DateTime(2020, 9, 10, 11, 40, 2, 824, DateTimeKind.Unspecified).AddTicks(6583), new TimeSpan(0, 7, 0, 0, 0)), 3, "12:00 PM", new Guid("3ec9b182-31fc-749c-dd38-f3bcb0dede4d") });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[] { new Guid("73f6340c-57cd-e9a9-8d76-2e3754d34cf0"), "Completed", new Guid("9b5b2c85-3033-3987-b842-af9ad2f401ee"), new Guid("31c95f5a-4a44-610a-56fa-39ba2e69221b"), new DateTimeOffset(new DateTime(2020, 9, 4, 9, 6, 41, 467, DateTimeKind.Unspecified).AddTicks(4414), new TimeSpan(0, 7, 0, 0, 0)), new Guid("23a9378e-d600-40a4-2f2b-60ee79b453e3"), true, new DateTimeOffset(new DateTime(2020, 5, 10, 22, 58, 46, 851, DateTimeKind.Unspecified).AddTicks(5853), new TimeSpan(0, 7, 0, 0, 0)), 3, "6:00 PM", new Guid("609afabf-efdb-fb3f-7207-2583625812b2") });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("7cfe35f6-378d-a440-6990-103e95537207"), "Completed", new Guid("5d7c09a1-50cf-c09e-103d-b97e2dac22f8"), new Guid("0c037a58-9f75-ab3f-38a4-aa4eb47f5542"), new DateTimeOffset(new DateTime(2020, 12, 7, 5, 18, 40, 226, DateTimeKind.Unspecified).AddTicks(926), new TimeSpan(0, 7, 0, 0, 0)), new Guid("fa6f8747-3f5d-bbef-55f9-f750e56dce5a"), new DateTimeOffset(new DateTime(2020, 1, 2, 21, 45, 48, 245, DateTimeKind.Unspecified).AddTicks(1580), new TimeSpan(0, 7, 0, 0, 0)), 2, "5:00 PM", new Guid("31c8786a-f2fa-ab7a-0bac-5f1e9b3f2bcd") },
                    { new Guid("81ed8046-bd68-e210-e3d1-cca53c8bb036"), "Cancelled", new Guid("fc782382-6898-3940-dec5-4409f8c4fa93"), new Guid("9a2771a7-4449-f54d-62d9-b0a724366a66"), new DateTimeOffset(new DateTime(2020, 12, 14, 3, 59, 0, 258, DateTimeKind.Unspecified).AddTicks(119), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4ee9d2ad-28cd-df95-80ff-ff977fca08f6"), new DateTimeOffset(new DateTime(2020, 9, 6, 0, 52, 18, 542, DateTimeKind.Unspecified).AddTicks(1812), new TimeSpan(0, 7, 0, 0, 0)), 2, "9:00 AM", new Guid("6452ec5b-59d8-7ce6-64aa-80f861750375") },
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), "Confirmed", new Guid("3fd8f5fa-4f62-2ff9-5043-3e33fc7bef58"), new Guid("0c037a58-9f75-ab3f-38a4-aa4eb47f5542"), new DateTimeOffset(new DateTime(2020, 4, 8, 8, 6, 42, 657, DateTimeKind.Unspecified).AddTicks(9516), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d1e3e210-a5cc-8b3c-b036-22584367619b"), new DateTimeOffset(new DateTime(2020, 2, 8, 1, 56, 42, 864, DateTimeKind.Unspecified).AddTicks(7753), new TimeSpan(0, 7, 0, 0, 0)), 1, "12:00 PM", new Guid("fb7425eb-5298-bbd0-7d77-413ff692b4dc") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("9dd66981-6e49-6357-a37c-45fb1f8ba41e"), "Confirmed", new Guid("5d7c09a1-50cf-c09e-103d-b97e2dac22f8"), new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"), new DateTimeOffset(new DateTime(2020, 5, 12, 9, 39, 6, 104, DateTimeKind.Unspecified).AddTicks(8526), new TimeSpan(0, 7, 0, 0, 0)), new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"), true, new DateTimeOffset(new DateTime(2020, 6, 16, 3, 28, 7, 196, DateTimeKind.Unspecified).AddTicks(445), new TimeSpan(0, 7, 0, 0, 0)), 3, "11:00 PM", new Guid("fb7425eb-5298-bbd0-7d77-413ff692b4dc") },
                    { new Guid("9e3042aa-dfdd-c913-158a-7737585d1348"), "Completed", new Guid("7b04bb20-cbba-8555-0d9a-5e5834745d1d"), new Guid("30e4180f-7bad-447f-60e5-fe9dba8dcd41"), new DateTimeOffset(new DateTime(2020, 9, 27, 12, 32, 36, 206, DateTimeKind.Unspecified).AddTicks(5096), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4ee9d2ad-28cd-df95-80ff-ff977fca08f6"), true, new DateTimeOffset(new DateTime(2020, 9, 13, 7, 27, 36, 662, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 7, 0, 0, 0)), 4, "7:00 PM", new Guid("3ec9b182-31fc-749c-dd38-f3bcb0dede4d") },
                    { new Guid("a4d60023-2f40-602b-ee79-b453e39036df"), "Pending", new Guid("7b04bb20-cbba-8555-0d9a-5e5834745d1d"), new Guid("39b5a1a1-5462-94ea-f627-f5d5eee0105e"), new DateTimeOffset(new DateTime(2020, 5, 7, 3, 56, 42, 922, DateTimeKind.Unspecified).AddTicks(5669), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4ee9d2ad-28cd-df95-80ff-ff977fca08f6"), true, new DateTimeOffset(new DateTime(2020, 6, 26, 11, 55, 44, 937, DateTimeKind.Unspecified).AddTicks(301), new TimeSpan(0, 7, 0, 0, 0)), 2, "1:00 PM", new Guid("9c3b8b80-ec77-0d7d-387e-ebec94e998eb") },
                    { new Guid("a7b0d962-3624-666a-0cbf-75043eb4b476"), "Confirmed", new Guid("21a19a75-c397-f2f7-c138-1c350582a9e4"), new Guid("8bc880c5-bc39-a62d-528d-a9d070fe5e75"), new DateTimeOffset(new DateTime(2020, 10, 12, 10, 47, 18, 159, DateTimeKind.Unspecified).AddTicks(3036), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d869bded-4313-a2e6-a4e8-a0bd6c2ba7d6"), true, new DateTimeOffset(new DateTime(2020, 5, 13, 0, 24, 7, 623, DateTimeKind.Unspecified).AddTicks(7319), new TimeSpan(0, 7, 0, 0, 0)), 1, "3:00 PM", new Guid("1b95837c-302e-82d9-d3e3-5c19fca249af") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("ab3f9f75-a438-4eaa-b47f-55421996b8a3"), "Pending", new Guid("69caa284-6f54-050a-1ec3-6e9841ddbe45"), new Guid("8bc880c5-bc39-a62d-528d-a9d070fe5e75"), new DateTimeOffset(new DateTime(2020, 8, 16, 5, 52, 35, 375, DateTimeKind.Unspecified).AddTicks(4249), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d1e3e210-a5cc-8b3c-b036-22584367619b"), new DateTimeOffset(new DateTime(2020, 1, 15, 5, 52, 33, 474, DateTimeKind.Unspecified).AddTicks(5702), new TimeSpan(0, 7, 0, 0, 0)), 3, "5:00 PM", new Guid("2096d739-97f1-5726-27cd-ede8d3504da0") },
                    { new Guid("ab85d464-89d5-8ee1-c580-c88b39bc2da6"), "Pending", new Guid("80243f7a-52a2-60fb-11bc-323115781a81"), new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"), new DateTimeOffset(new DateTime(2020, 5, 14, 1, 46, 1, 514, DateTimeKind.Unspecified).AddTicks(7233), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a1a1a4b0-39b5-5462-ea94-f627f5d5eee0"), new DateTimeOffset(new DateTime(2020, 9, 13, 23, 8, 15, 823, DateTimeKind.Unspecified).AddTicks(9973), new TimeSpan(0, 7, 0, 0, 0)), 4, "10:00 AM", new Guid("6f110748-4060-7943-3d81-f85d8b09c12c") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("ac0bab7a-1e5f-3f9b-2bcd-52f09e51d49e"), "Completed", new Guid("21a19a75-c397-f2f7-c138-1c350582a9e4"), new Guid("f4b35b22-5424-ad20-1a71-ce513a15ab1e"), new DateTimeOffset(new DateTime(2020, 9, 4, 4, 8, 10, 654, DateTimeKind.Unspecified).AddTicks(210), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1bea9f71-a600-20c9-1c80-f09d1740b7b9"), true, new DateTimeOffset(new DateTime(2020, 5, 17, 1, 27, 42, 136, DateTimeKind.Unspecified).AddTicks(8597), new TimeSpan(0, 7, 0, 0, 0)), 3, "10:00 AM", new Guid("6452ec5b-59d8-7ce6-64aa-80f861750375") },
                    { new Guid("ad0e2ced-74dc-76db-8864-6ffd2dc498c6"), "Confirmed", new Guid("3fa48bde-c787-08ca-f634-04c6ceec6dfd"), new Guid("f4b35b22-5424-ad20-1a71-ce513a15ab1e"), new DateTimeOffset(new DateTime(2020, 7, 18, 18, 52, 51, 993, DateTimeKind.Unspecified).AddTicks(4080), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f24616bd-e6a9-6c93-6269-33ef855ab90a"), true, new DateTimeOffset(new DateTime(2020, 3, 9, 16, 43, 9, 190, DateTimeKind.Unspecified).AddTicks(4366), new TimeSpan(0, 7, 0, 0, 0)), 2, "10:00 AM", new Guid("6f110748-4060-7943-3d81-f85d8b09c12c") },
                    { new Guid("ae048d35-c736-60ca-1a03-998417fd2e0d"), "Cancelled", new Guid("9c6f8f96-22b1-289a-c54b-5e4dfdad5164"), new Guid("40d167eb-7d65-5050-c5b9-bd58e5e1a445"), new DateTimeOffset(new DateTime(2020, 5, 3, 1, 56, 51, 685, DateTimeKind.Unspecified).AddTicks(6891), new TimeSpan(0, 7, 0, 0, 0)), new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"), true, new DateTimeOffset(new DateTime(2020, 7, 10, 1, 29, 6, 445, DateTimeKind.Unspecified).AddTicks(8774), new TimeSpan(0, 7, 0, 0, 0)), 4, "11:00 AM", new Guid("3ece3fb3-867d-a0ec-c08c-c4d7a942e500") },
                    { new Guid("b1b68e27-3e7d-0ff2-18e4-30ad7b7f4460"), "Pending", new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), new Guid("28490d2e-ad32-cf01-c79e-2cd4a1fd8116"), new DateTimeOffset(new DateTime(2020, 5, 17, 15, 26, 23, 234, DateTimeKind.Unspecified).AddTicks(1259), new TimeSpan(0, 7, 0, 0, 0)), new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"), true, new DateTimeOffset(new DateTime(2020, 1, 31, 22, 37, 24, 37, DateTimeKind.Unspecified).AddTicks(7019), new TimeSpan(0, 7, 0, 0, 0)), 3, "7:00 AM", new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("b4b81d50-7f7d-7aa3-d24f-0319ce64c757"), "Pending", new Guid("2702e6e6-01b4-12c7-f857-2a2e74316200"), new Guid("4042cc3e-fa91-d7da-ff35-8d04ae36c7ca"), new DateTimeOffset(new DateTime(2020, 3, 10, 3, 55, 22, 952, DateTimeKind.Unspecified).AddTicks(1296), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a1a1a4b0-39b5-5462-ea94-f627f5d5eee0"), new DateTimeOffset(new DateTime(2020, 12, 4, 9, 2, 9, 344, DateTimeKind.Unspecified).AddTicks(5560), new TimeSpan(0, 7, 0, 0, 0)), 3, "5:00 PM", new Guid("31c8786a-f2fa-ab7a-0bac-5f1e9b3f2bcd") },
                    { new Guid("b5a1a1a4-6239-ea54-94f6-27f5d5eee010"), "Completed", new Guid("9ca00e7a-c1e3-6c17-e48e-824e0221be0f"), new Guid("9528cd4e-80df-ffff-977f-ca08f6548f59"), new DateTimeOffset(new DateTime(2020, 8, 26, 22, 43, 21, 790, DateTimeKind.Unspecified).AddTicks(967), new TimeSpan(0, 7, 0, 0, 0)), new Guid("568c09f6-f8f3-7e55-ac44-2d01fb2b510c"), new DateTimeOffset(new DateTime(2020, 5, 5, 18, 2, 15, 671, DateTimeKind.Unspecified).AddTicks(304), new TimeSpan(0, 7, 0, 0, 0)), 1, "10:00 PM", new Guid("f29a2a8e-4d8b-a1cd-8c19-b674b6ff66b4") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("b6de451c-9052-53a9-a9fb-007f94ad4550"), "Pending", new Guid("b6d7f535-95f3-33b7-367d-cfee3eeb94b5"), new Guid("a957cd73-8de9-2e76-3754-d34cf08bd2e2"), new DateTimeOffset(new DateTime(2020, 12, 19, 7, 37, 48, 118, DateTimeKind.Unspecified).AddTicks(7773), new TimeSpan(0, 7, 0, 0, 0)), new Guid("fa6f8747-3f5d-bbef-55f9-f750e56dce5a"), true, new DateTimeOffset(new DateTime(2020, 9, 10, 2, 9, 48, 349, DateTimeKind.Unspecified).AddTicks(5114), new TimeSpan(0, 7, 0, 0, 0)), 4, "9:00 AM", new Guid("26a67ecd-6180-8d3b-fd52-41408b6939c3") },
                    { new Guid("ccc57fd8-e27d-6983-aaa4-108d4d026f58"), "Cancelled", new Guid("25d1af98-3aa3-46f2-ec74-b73f32a89b98"), new Guid("8364bab3-3549-2209-c2f8-b1659599800f"), new DateTimeOffset(new DateTime(2020, 10, 10, 8, 37, 12, 680, DateTimeKind.Unspecified).AddTicks(1728), new TimeSpan(0, 7, 0, 0, 0)), new Guid("0b40e562-d9b5-504a-8985-07682b0d588f"), true, new DateTimeOffset(new DateTime(2020, 3, 31, 14, 40, 15, 887, DateTimeKind.Unspecified).AddTicks(8394), new TimeSpan(0, 7, 0, 0, 0)), 2, "9:00 PM", new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") },
                    { new Guid("ce3fb385-7d3e-ec86-a0c0-8cc4d7a942e5"), "Confirmed", new Guid("06278a51-2c88-111e-be6c-94ebbe9406f5"), new Guid("39b5a1a1-5462-94ea-f627-f5d5eee0105e"), new DateTimeOffset(new DateTime(2020, 12, 9, 11, 5, 6, 37, DateTimeKind.Unspecified).AddTicks(2375), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d40d725e-c366-8b4f-8503-1295b3ba6483"), true, new DateTimeOffset(new DateTime(2020, 8, 9, 7, 18, 24, 154, DateTimeKind.Unspecified).AddTicks(581), new TimeSpan(0, 7, 0, 0, 0)), 1, "5:00 PM", new Guid("335ac148-c512-5b69-ffda-43761a02659d") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("d2ad0877-4ee9-28cd-95df-80ffff977fca"), "Cancelled", new Guid("5d7c09a1-50cf-c09e-103d-b97e2dac22f8"), new Guid("c9945bcd-5515-8954-f74e-1337084c237e"), new DateTimeOffset(new DateTime(2020, 10, 17, 8, 33, 56, 721, DateTimeKind.Unspecified).AddTicks(2678), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9565b1f8-8099-f90f-8b29-3b957e2d5fd5"), new DateTimeOffset(new DateTime(2020, 10, 25, 15, 18, 43, 995, DateTimeKind.Unspecified).AddTicks(1361), new TimeSpan(0, 7, 0, 0, 0)), 4, "9:00 PM", new Guid("059f0b6a-1940-021d-901e-108a95bc55cb") },
                    { new Guid("d718edc2-e562-0b40-b5d9-4a5089850768"), "Cancelled", new Guid("25d1af98-3aa3-46f2-ec74-b73f32a89b98"), new Guid("40d167eb-7d65-5050-c5b9-bd58e5e1a445"), new DateTimeOffset(new DateTime(2020, 12, 16, 11, 32, 50, 387, DateTimeKind.Unspecified).AddTicks(8566), new TimeSpan(0, 7, 0, 0, 0)), new Guid("329db5e7-fa1e-fcc9-05d4-975ed3d8499f"), new DateTimeOffset(new DateTime(2020, 12, 4, 10, 23, 21, 13, DateTimeKind.Unspecified).AddTicks(43), new TimeSpan(0, 7, 0, 0, 0)), 4, "3:00 PM", new Guid("f3dcdac7-43a2-0adf-530c-9653f4b2c78d") },
                    { new Guid("de9b9d52-a435-67eb-d140-657d5050c5b9"), "Cancelled", new Guid("b6d7f535-95f3-33b7-367d-cfee3eeb94b5"), new Guid("a957cd73-8de9-2e76-3754-d34cf08bd2e2"), new DateTimeOffset(new DateTime(2020, 1, 24, 21, 13, 11, 271, DateTimeKind.Unspecified).AddTicks(4226), new TimeSpan(0, 7, 0, 0, 0)), new Guid("786a9718-31c8-f2fa-7aab-0bac5f1e9b3f"), new DateTimeOffset(new DateTime(2020, 5, 23, 12, 40, 19, 76, DateTimeKind.Unspecified).AddTicks(9423), new TimeSpan(0, 7, 0, 0, 0)), 1, "9:00 PM", new Guid("b35b2234-24f4-2054-ad1a-71ce513a15ab") },
                    { new Guid("e018f5a7-9b7e-0252-b062-f68e93af65c0"), "Confirmed", new Guid("a272346f-6e7b-3bd0-6c34-9e210a9a58f9"), new Guid("c3c7fdd7-cfcb-1cc2-45de-b65290a953a9"), new DateTimeOffset(new DateTime(2020, 3, 10, 11, 6, 7, 168, DateTimeKind.Unspecified).AddTicks(2678), new TimeSpan(0, 7, 0, 0, 0)), new Guid("945bcd22-15c9-5455-89f7-4e1337084c23"), new DateTimeOffset(new DateTime(2020, 11, 12, 4, 59, 22, 12, DateTimeKind.Unspecified).AddTicks(2576), new TimeSpan(0, 7, 0, 0, 0)), 1, "6:00 PM", new Guid("fb7425eb-5298-bbd0-7d77-413ff692b4dc") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[] { new Guid("e64313d8-a4a2-a0e8-bd6c-2ba7d672050a"), "Cancelled", new Guid("7b04bb20-cbba-8555-0d9a-5e5834745d1d"), new Guid("5ce3d382-fc19-49a2-af96-2f5f0ce2aa42"), new DateTimeOffset(new DateTime(2020, 5, 14, 3, 12, 33, 783, DateTimeKind.Unspecified).AddTicks(19), new TimeSpan(0, 7, 0, 0, 0)), new Guid("31663645-0c09-f634-73cd-57a9e98d762e"), true, new DateTimeOffset(new DateTime(2020, 5, 25, 23, 20, 49, 11, DateTimeKind.Unspecified).AddTicks(1012), new TimeSpan(0, 7, 0, 0, 0)), 3, "6:00 PM", new Guid("89b78bdb-be24-151c-31f7-e7421644e19f") });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("eceb7e38-e994-eb98-0c68-69eca2e641f6"), "Confirmed", new Guid("f1bc12e3-c49a-c11a-5ea9-86da5b57bd3f"), new Guid("f4b35b22-5424-ad20-1a71-ce513a15ab1e"), new DateTimeOffset(new DateTime(2020, 6, 16, 9, 38, 6, 363, DateTimeKind.Unspecified).AddTicks(5150), new TimeSpan(0, 7, 0, 0, 0)), new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"), new DateTimeOffset(new DateTime(2020, 1, 12, 17, 15, 23, 855, DateTimeKind.Unspecified).AddTicks(9848), new TimeSpan(0, 7, 0, 0, 0)), 2, "2:00 PM", new Guid("88c74234-830e-5eb8-783e-185b933787f0") },
                    { new Guid("f0a70070-54b1-e1fd-fc18-10a5ccb2341f"), "Cancelled", new Guid("8f4ff836-e126-dbd5-09b3-1f3e8190949c"), new Guid("e6a9f246-6c93-6962-33ef-855ab90a53b0"), new DateTimeOffset(new DateTime(2020, 11, 28, 4, 38, 11, 532, DateTimeKind.Unspecified).AddTicks(5660), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4ee9d2ad-28cd-df95-80ff-ff977fca08f6"), new DateTimeOffset(new DateTime(2020, 8, 23, 4, 35, 47, 929, DateTimeKind.Unspecified).AddTicks(2813), new TimeSpan(0, 7, 0, 0, 0)), 4, "8:00 PM", new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f") },
                    { new Guid("f8036575-7c4a-9583-1b2e-30d982d3e35c"), "Pending", new Guid("7e9c4417-9abe-fd77-e589-9fecf460cd25"), new Guid("9a2771a7-4449-f54d-62d9-b0a724366a66"), new DateTimeOffset(new DateTime(2020, 4, 22, 1, 45, 6, 301, DateTimeKind.Unspecified).AddTicks(9067), new TimeSpan(0, 7, 0, 0, 0)), new Guid("decd2662-0804-7b5c-9997-690f47fb03e9"), new DateTimeOffset(new DateTime(2020, 6, 15, 13, 56, 51, 241, DateTimeKind.Unspecified).AddTicks(8170), new TimeSpan(0, 7, 0, 0, 0)), 3, "9:00 PM", new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f") },
                    { new Guid("fad5cead-8b14-7bef-2fa2-d996de815383"), "Confirmed", new Guid("d8ba0acf-0390-1c22-d57c-1ed83e20da2d"), new Guid("ecc698c4-a3bd-d5e5-df91-ad2a6e8169d6"), new DateTimeOffset(new DateTime(2020, 8, 14, 2, 17, 17, 512, DateTimeKind.Unspecified).AddTicks(9172), new TimeSpan(0, 7, 0, 0, 0)), new Guid("41cd8dba-2c1f-9307-b7df-385c9a4619ab"), new DateTimeOffset(new DateTime(2020, 10, 5, 16, 46, 8, 349, DateTimeKind.Unspecified).AddTicks(3925), new TimeSpan(0, 7, 0, 0, 0)), 1, "10:00 PM", new Guid("97eb2ed4-df10-55bd-d364-a3db4a109f23") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[] { new Guid("fadc6e80-d9f3-b790-2e46-a870e9198a1a"), "Completed", new Guid("d8ba0acf-0390-1c22-d57c-1ed83e20da2d"), new Guid("6dc2b651-86f7-3ca8-e646-80ed8168bd10"), new DateTimeOffset(new DateTime(2020, 11, 14, 21, 38, 7, 950, DateTimeKind.Unspecified).AddTicks(484), new TimeSpan(0, 7, 0, 0, 0)), new Guid("568c09f6-f8f3-7e55-ac44-2d01fb2b510c"), true, new DateTimeOffset(new DateTime(2020, 10, 7, 13, 2, 57, 632, DateTimeKind.Unspecified).AddTicks(5594), new TimeSpan(0, 7, 0, 0, 0)), 3, "5:00 PM", new Guid("3ec9b182-31fc-749c-dd38-f3bcb0dede4d") });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[] { new Guid("fc468bcc-b19c-0a0a-a2dc-4995e1e478b1"), "Completed", new Guid("83e4f60e-ea2b-f473-73f6-909e673cbdeb"), new Guid("c3c7fdd7-cfcb-1cc2-45de-b65290a953a9"), new DateTimeOffset(new DateTime(2020, 6, 23, 20, 31, 6, 504, DateTimeKind.Unspecified).AddTicks(6291), new TimeSpan(0, 7, 0, 0, 0)), new Guid("23a9378e-d600-40a4-2f2b-60ee79b453e3"), new DateTimeOffset(new DateTime(2020, 12, 6, 15, 26, 37, 758, DateTimeKind.Unspecified).AddTicks(1670), new TimeSpan(0, 7, 0, 0, 0)), 2, "1:00 PM", new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f") });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("072c1f41-b793-38df-5c9a-4619abd61d8b"), 41.497987933223120m, new Guid("30e4180f-7bad-447f-60e5-fe9dba8dcd41"), "Outdoor", new DateTimeOffset(new DateTime(2020, 12, 10, 22, 17, 30, 126, DateTimeKind.Unspecified).AddTicks(4141), new TimeSpan(0, 7, 0, 0, 0)), 45.221606639782720m, new DateTimeOffset(new DateTime(2020, 11, 20, 2, 4, 19, 389, DateTimeKind.Unspecified).AddTicks(3563), new TimeSpan(0, 7, 0, 0, 0)), 22.389592515486120m },
                    { new Guid("09354983-c222-b1f8-6595-99800ff98b29"), 34.969137117717960m, new Guid("a957cd73-8de9-2e76-3754-d34cf08bd2e2"), "Indoor", new DateTimeOffset(new DateTime(2020, 10, 22, 15, 57, 42, 951, DateTimeKind.Unspecified).AddTicks(685), new TimeSpan(0, 7, 0, 0, 0)), 21.810305086807480m, new DateTimeOffset(new DateTime(2020, 8, 30, 12, 15, 24, 70, DateTimeKind.Unspecified).AddTicks(5666), new TimeSpan(0, 7, 0, 0, 0)), 20.569869191651160m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("0d197acc-619b-6d82-f271-9fea1b00a6c9"), 29.337506824795840m, new Guid("0c037a58-9f75-ab3f-38a4-aa4eb47f5542"), "Outdoor", new DateTimeOffset(new DateTime(2020, 9, 20, 1, 59, 57, 796, DateTimeKind.Unspecified).AddTicks(3675), new TimeSpan(0, 7, 0, 0, 0)), 48.588216322748080m, true, new DateTimeOffset(new DateTime(2020, 7, 27, 11, 15, 33, 143, DateTimeKind.Unspecified).AddTicks(1905), new TimeSpan(0, 7, 0, 0, 0)), 46.102314608219240m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("208bf680-2b14-3712-d52d-64d485abd589"), 40.994665897914520m, new Guid("c9945bcd-5515-8954-f74e-1337084c237e"), "Indoor", new DateTimeOffset(new DateTime(2020, 7, 12, 8, 29, 34, 78, DateTimeKind.Unspecified).AddTicks(4355), new TimeSpan(0, 7, 0, 0, 0)), 38.810013639186520m, new DateTimeOffset(new DateTime(2020, 8, 22, 14, 2, 51, 750, DateTimeKind.Unspecified).AddTicks(5840), new TimeSpan(0, 7, 0, 0, 0)), 43.817405139011040m },
                    { new Guid("234c0837-e07e-6fb5-dc08-5b8c438fffa9"), 45.934353394403280m, new Guid("0c4f13f2-3466-2bac-97b6-715e720dd466"), "Indoor", new DateTimeOffset(new DateTime(2020, 1, 27, 16, 55, 50, 381, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 7, 0, 0, 0)), 29.193475273993560m, new DateTimeOffset(new DateTime(2020, 6, 22, 7, 33, 11, 275, DateTimeKind.Unspecified).AddTicks(6197), new TimeSpan(0, 7, 0, 0, 0)), 26.848064482606960m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("273ee7fa-1096-0806-6580-6035ad238abb"), 12.9623712985601160m, new Guid("0945e751-80eb-8bf6-2014-2b1237d52d64"), "Indoor", new DateTimeOffset(new DateTime(2020, 4, 15, 19, 39, 29, 892, DateTimeKind.Unspecified).AddTicks(4558), new TimeSpan(0, 7, 0, 0, 0)), 39.023068225487640m, true, new DateTimeOffset(new DateTime(2020, 10, 22, 7, 44, 14, 293, DateTimeKind.Unspecified).AddTicks(3072), new TimeSpan(0, 7, 0, 0, 0)), 31.353848884512600m },
                    { new Guid("2d49430d-4e90-f11b-51a9-34225bb3f424"), 17.565856579489000m, new Guid("39b5a1a1-5462-94ea-f627-f5d5eee0105e"), "Indoor", new DateTimeOffset(new DateTime(2020, 4, 25, 0, 41, 21, 899, DateTimeKind.Unspecified).AddTicks(1121), new TimeSpan(0, 7, 0, 0, 0)), 17.676361448912120m, true, new DateTimeOffset(new DateTime(2020, 9, 10, 22, 55, 52, 695, DateTimeKind.Unspecified).AddTicks(2577), new TimeSpan(0, 7, 0, 0, 0)), 32.24751153134160m },
                    { new Guid("34660c4f-2bac-b697-715e-720dd466c34f"), 24.995305638292480m, new Guid("5ce3d382-fc19-49a2-af96-2f5f0ce2aa42"), "Indoor", new DateTimeOffset(new DateTime(2020, 1, 9, 23, 46, 18, 401, DateTimeKind.Unspecified).AddTicks(4385), new TimeSpan(0, 7, 0, 0, 0)), 43.996224475091440m, true, new DateTimeOffset(new DateTime(2020, 8, 19, 7, 8, 25, 325, DateTimeKind.Unspecified).AddTicks(2802), new TimeSpan(0, 7, 0, 0, 0)), 25.027168008977160m },
                    { new Guid("37778a15-5d58-4813-6525-53d7ec3774d8"), 12.9962871237640680m, new Guid("4d5ace6d-8497-ab76-3a2f-df88956762d3"), "Outdoor", new DateTimeOffset(new DateTime(2020, 9, 17, 12, 39, 7, 938, DateTimeKind.Unspecified).AddTicks(2816), new TimeSpan(0, 7, 0, 0, 0)), 28.152758226801080m, true, new DateTimeOffset(new DateTime(2020, 3, 3, 8, 13, 52, 588, DateTimeKind.Unspecified).AddTicks(9934), new TimeSpan(0, 7, 0, 0, 0)), 21.987886229524320m },
                    { new Guid("3d5d14e4-3fcc-7089-9fe4-9d676b30922d"), 29.82647133051720m, new Guid("6dc2b651-86f7-3ca8-e646-80ed8168bd10"), "Indoor", new DateTimeOffset(new DateTime(2020, 10, 9, 1, 5, 9, 814, DateTimeKind.Unspecified).AddTicks(6427), new TimeSpan(0, 7, 0, 0, 0)), 46.16956572801320m, true, new DateTimeOffset(new DateTime(2020, 1, 6, 21, 1, 13, 733, DateTimeKind.Unspecified).AddTicks(4917), new TimeSpan(0, 7, 0, 0, 0)), 25.657718524177440m },
                    { new Guid("40d167eb-7d65-5050-c5b9-bd58e5e1a445"), 47.389709482616600m, new Guid("edc2475d-d718-e562-400b-b5d94a508985"), "Outdoor", new DateTimeOffset(new DateTime(2020, 3, 7, 23, 54, 36, 924, DateTimeKind.Unspecified).AddTicks(5847), new TimeSpan(0, 7, 0, 0, 0)), 34.313879937079680m, true, new DateTimeOffset(new DateTime(2020, 11, 15, 11, 56, 16, 868, DateTimeKind.Unspecified).AddTicks(8626), new TimeSpan(0, 7, 0, 0, 0)), 38.207231586895520m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"), 31.343363570674960m, new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"), "Outdoor", new DateTimeOffset(new DateTime(2020, 7, 27, 0, 47, 48, 494, DateTimeKind.Unspecified).AddTicks(3600), new TimeSpan(0, 7, 0, 0, 0)), 25.554371408910680m, new DateTimeOffset(new DateTime(2020, 6, 8, 19, 14, 36, 736, DateTimeKind.Unspecified).AddTicks(399), new TimeSpan(0, 7, 0, 0, 0)), 48.443187772502760m },
                    { new Guid("4431c95f-0a4a-5661-fa39-ba2e69221baa"), 29.020952311819880m, new Guid("69bdeded-13d8-e643-a2a4-e8a0bd6c2ba7"), "Indoor", new DateTimeOffset(new DateTime(2020, 7, 9, 13, 54, 39, 511, DateTimeKind.Unspecified).AddTicks(9340), new TimeSpan(0, 7, 0, 0, 0)), 42.589324318146960m, new DateTimeOffset(new DateTime(2020, 5, 4, 1, 0, 43, 596, DateTimeKind.Unspecified).AddTicks(101), new TimeSpan(0, 7, 0, 0, 0)), 32.97624585357320m },
                    { new Guid("44ac7e55-012d-2bfb-510c-8e86863eeded"), 16.728670171801320m, new Guid("0c4f13f2-3466-2bac-97b6-715e720dd466"), "Indoor", new DateTimeOffset(new DateTime(2020, 11, 10, 23, 15, 48, 6, DateTimeKind.Unspecified).AddTicks(5378), new TimeSpan(0, 7, 0, 0, 0)), 30.902437428432720m, new DateTimeOffset(new DateTime(2020, 1, 23, 21, 48, 16, 487, DateTimeKind.Unspecified).AddTicks(5646), new TimeSpan(0, 7, 0, 0, 0)), 14.250296300393680m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("470f6997-03fb-cee9-3b65-7708add2e94e"), 40.453835292930640m, new Guid("19469a5c-d6ab-8b1d-dfd6-47876ffa5d3f"), "Indoor", new DateTimeOffset(new DateTime(2020, 2, 3, 23, 27, 2, 441, DateTimeKind.Unspecified).AddTicks(7051), new TimeSpan(0, 7, 0, 0, 0)), 13.4147814863430240m, true, new DateTimeOffset(new DateTime(2020, 8, 5, 12, 25, 58, 989, DateTimeKind.Unspecified).AddTicks(3117), new TimeSpan(0, 7, 0, 0, 0)), 45.387891789613240m },
                    { new Guid("519ef052-9ed4-05a8-15b4-13c4587a030c"), 28.513815989025800m, new Guid("0bab7af2-5fac-9b1e-3f2b-cd52f09e51d4"), "Indoor", new DateTimeOffset(new DateTime(2020, 5, 26, 16, 51, 16, 961, DateTimeKind.Unspecified).AddTicks(5992), new TimeSpan(0, 7, 0, 0, 0)), 34.217506639760680m, true, new DateTimeOffset(new DateTime(2020, 7, 24, 22, 18, 14, 516, DateTimeKind.Unspecified).AddTicks(3162), new TimeSpan(0, 7, 0, 0, 0)), 23.181302348701880m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("586f024d-8980-f523-bdce-f26ed8848d04"), 37.724649434781000m, new Guid("87973a15-8dde-6aed-3a99-5add4e83275c"), "Outdoor", new DateTimeOffset(new DateTime(2020, 3, 12, 19, 30, 16, 373, DateTimeKind.Unspecified).AddTicks(1082), new TimeSpan(0, 7, 0, 0, 0)), 13.9614699426859000m, new DateTimeOffset(new DateTime(2020, 10, 11, 7, 47, 8, 409, DateTimeKind.Unspecified).AddTicks(1603), new TimeSpan(0, 7, 0, 0, 0)), 10.3490912357108160m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("6bbc76b4-a7f7-4c1f-4773-aee30c100642"), 24.638009990862560m, new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"), "Indoor", new DateTimeOffset(new DateTime(2020, 9, 8, 9, 39, 18, 144, DateTimeKind.Unspecified).AddTicks(9000), new TimeSpan(0, 7, 0, 0, 0)), 28.121369973812880m, true, new DateTimeOffset(new DateTime(2020, 10, 22, 4, 52, 8, 231, DateTimeKind.Unspecified).AddTicks(255), new TimeSpan(0, 7, 0, 0, 0)), 45.475480833777920m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("6cbda0e8-a72b-72d6-050a-8f8922cd5b94"), 35.340576574830600m, new Guid("6d13d55f-c23f-f5a7-18e0-7e9b5202b062"), "Indoor", new DateTimeOffset(new DateTime(2020, 8, 31, 13, 55, 4, 355, DateTimeKind.Unspecified).AddTicks(501), new TimeSpan(0, 7, 0, 0, 0)), 34.046689674279960m, new DateTimeOffset(new DateTime(2020, 1, 1, 19, 13, 11, 383, DateTimeKind.Unspecified).AddTicks(5758), new TimeSpan(0, 7, 0, 0, 0)), 39.596232357246920m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("6d1eab15-d275-d365-3d5c-153a9787de8d"), 30.560953216888440m, new Guid("2f40a4d6-602b-79ee-b453-e39036dfc79c"), "Outdoor", new DateTimeOffset(new DateTime(2020, 9, 14, 23, 41, 43, 347, DateTimeKind.Unspecified).AddTicks(6497), new TimeSpan(0, 7, 0, 0, 0)), 48.779541160343000m, true, new DateTimeOffset(new DateTime(2020, 1, 19, 16, 20, 22, 899, DateTimeKind.Unspecified).AddTicks(7981), new TimeSpan(0, 7, 0, 0, 0)), 18.801006921008680m },
                    { new Guid("6e499dd6-6357-7ca3-45fb-1f8ba41e25e0"), 42.703130819230880m, new Guid("edc2475d-d718-e562-400b-b5d94a508985"), "Outdoor", new DateTimeOffset(new DateTime(2020, 5, 12, 9, 39, 6, 104, DateTimeKind.Unspecified).AddTicks(8526), new TimeSpan(0, 7, 0, 0, 0)), 30.121875545066720m, true, new DateTimeOffset(new DateTime(2020, 6, 16, 3, 28, 7, 196, DateTimeKind.Unspecified).AddTicks(445), new TimeSpan(0, 7, 0, 0, 0)), 45.454992668449400m },
                    { new Guid("71a777e1-9a27-4449-4df5-62d9b0a72436"), 15.911027903627160m, new Guid("0c4f13f2-3466-2bac-97b6-715e720dd466"), "Outdoor", new DateTimeOffset(new DateTime(2020, 5, 1, 15, 32, 44, 760, DateTimeKind.Unspecified).AddTicks(5218), new TimeSpan(0, 7, 0, 0, 0)), 29.254346126343280m, true, new DateTimeOffset(new DateTime(2020, 1, 10, 3, 56, 23, 465, DateTimeKind.Unspecified).AddTicks(9836), new TimeSpan(0, 7, 0, 0, 0)), 18.972684931462960m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("76db74dc-6488-fd6f-2dc4-98c6ecbda3e5"), 19.144105300840040m, new Guid("8b1ffb45-1ea4-e025-e09e-2784cd25923f"), "Indoor", new DateTimeOffset(new DateTime(2020, 8, 20, 20, 16, 23, 203, DateTimeKind.Unspecified).AddTicks(428), new TimeSpan(0, 7, 0, 0, 0)), 25.417034949835880m, new DateTimeOffset(new DateTime(2020, 2, 20, 19, 7, 51, 344, DateTimeKind.Unspecified).AddTicks(4345), new TimeSpan(0, 7, 0, 0, 0)), 22.615303198162160m },
                    { new Guid("835381de-6fb1-580a-350e-f0f5e74a7565"), 12.8020571185285480m, new Guid("6d13d55f-c23f-f5a7-18e0-7e9b5202b062"), "Indoor", new DateTimeOffset(new DateTime(2020, 4, 13, 17, 1, 0, 884, DateTimeKind.Unspecified).AddTicks(3627), new TimeSpan(0, 7, 0, 0, 0)), 46.640321219638160m, new DateTimeOffset(new DateTime(2020, 2, 24, 21, 38, 22, 83, DateTimeKind.Unspecified).AddTicks(9488), new TimeSpan(0, 7, 0, 0, 0)), 46.205515934250080m },
                    { new Guid("8752ae2b-1d50-b4b8-7d7f-a37ad24f0319"), 41.409060448132960m, new Guid("0f7666bd-2191-62b1-c9f9-02e508cf1189"), "Outdoor", new DateTimeOffset(new DateTime(2020, 6, 20, 2, 54, 43, 526, DateTimeKind.Unspecified).AddTicks(1230), new TimeSpan(0, 7, 0, 0, 0)), 47.092951683836480m, new DateTimeOffset(new DateTime(2020, 5, 29, 5, 5, 50, 377, DateTimeKind.Unspecified).AddTicks(5220), new TimeSpan(0, 7, 0, 0, 0)), 13.4290638209455960m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("8bccb0b9-fc46-b19c-0a0a-a2dc4995e1e4"), 25.507539238551400m, new Guid("c3c7fdd7-cfcb-1cc2-45de-b65290a953a9"), "Outdoor", new DateTimeOffset(new DateTime(2020, 4, 5, 2, 17, 42, 549, DateTimeKind.Unspecified).AddTicks(7961), new TimeSpan(0, 7, 0, 0, 0)), 34.991066933139720m, true, new DateTimeOffset(new DateTime(2020, 7, 6, 16, 41, 49, 314, DateTimeKind.Unspecified).AddTicks(9897), new TimeSpan(0, 7, 0, 0, 0)), 47.670037614959320m },
                    { new Guid("8d52a62d-d0a9-fe70-5e75-1ab3d87fc5cc"), 46.40075152572280m, new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"), "Outdoor", new DateTimeOffset(new DateTime(2020, 12, 27, 18, 49, 42, 41, DateTimeKind.Unspecified).AddTicks(5112), new TimeSpan(0, 7, 0, 0, 0)), 19.470145762651280m, true, new DateTimeOffset(new DateTime(2020, 3, 3, 22, 30, 55, 391, DateTimeKind.Unspecified).AddTicks(871), new TimeSpan(0, 7, 0, 0, 0)), 25.166728447734720m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("8de07c9f-8317-bde3-52b5-9b65adced5fa"), 14.628293721297880m, new Guid("9a2771a7-4449-f54d-62d9-b0a724366a66"), "Indoor", new DateTimeOffset(new DateTime(2020, 1, 1, 19, 23, 54, 762, DateTimeKind.Unspecified).AddTicks(5849), new TimeSpan(0, 7, 0, 0, 0)), 40.83392113020360m, new DateTimeOffset(new DateTime(2020, 6, 20, 11, 8, 12, 390, DateTimeKind.Unspecified).AddTicks(389), new TimeSpan(0, 7, 0, 0, 0)), 24.827266118874440m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"), 45.699026005202440m, new Guid("28490d2e-ad32-cf01-c79e-2cd4a1fd8116"), "Indoor", new DateTimeOffset(new DateTime(2020, 11, 6, 12, 35, 15, 882, DateTimeKind.Unspecified).AddTicks(9721), new TimeSpan(0, 7, 0, 0, 0)), 35.146202549872080m, true, new DateTimeOffset(new DateTime(2020, 4, 7, 14, 17, 44, 211, DateTimeKind.Unspecified).AddTicks(6056), new TimeSpan(0, 7, 0, 0, 0)), 29.681340539679560m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("8f580d2b-c771-8dd8-e8e7-b59d321efac9"), 47.726941219403840m, new Guid("f62452d5-8c09-f356-f855-7eac442d01fb"), "Indoor", new DateTimeOffset(new DateTime(2020, 9, 16, 0, 17, 18, 289, DateTimeKind.Unspecified).AddTicks(5609), new TimeSpan(0, 7, 0, 0, 0)), 34.071711685541880m, new DateTimeOffset(new DateTime(2020, 12, 21, 5, 10, 51, 604, DateTimeKind.Unspecified).AddTicks(516), new TimeSpan(0, 7, 0, 0, 0)), 45.005459727256320m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("905da48a-b45a-2d81-dcd8-750729b4372c"), 35.609711811696040m, new Guid("9f71f26d-1bea-a600-c920-1c80f09d1740"), "Indoor", new DateTimeOffset(new DateTime(2020, 3, 25, 2, 2, 32, 631, DateTimeKind.Unspecified).AddTicks(2147), new TimeSpan(0, 7, 0, 0, 0)), 33.649506561294880m, true, new DateTimeOffset(new DateTime(2020, 5, 5, 0, 45, 40, 143, DateTimeKind.Unspecified).AddTicks(2959), new TimeSpan(0, 7, 0, 0, 0)), 25.749126270296560m },
                    { new Guid("93e6a9f2-626c-3369-ef85-5ab90a53b0f5"), 20.864807502769320m, new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"), "Indoor", new DateTimeOffset(new DateTime(2020, 6, 11, 11, 41, 47, 844, DateTimeKind.Unspecified).AddTicks(5273), new TimeSpan(0, 7, 0, 0, 0)), 20.530045056031120m, true, new DateTimeOffset(new DateTime(2020, 12, 25, 13, 22, 30, 637, DateTimeKind.Unspecified).AddTicks(1409), new TimeSpan(0, 7, 0, 0, 0)), 11.6208441563047680m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), 19.413829412969680m, new Guid("582236b0-6743-9b61-aa64-9fd9f78f1a58"), "Indoor", new DateTimeOffset(new DateTime(2020, 8, 30, 0, 38, 16, 925, DateTimeKind.Unspecified).AddTicks(600), new TimeSpan(0, 7, 0, 0, 0)), 39.252876876505520m, new DateTimeOffset(new DateTime(2020, 9, 2, 6, 3, 4, 571, DateTimeKind.Unspecified).AddTicks(871), new TimeSpan(0, 7, 0, 0, 0)), 38.123531764430720m },
                    { new Guid("9b616743-64aa-d99f-f78f-1a58970f7896"), 39.967427900977160m, new Guid("87973a15-8dde-6aed-3a99-5add4e83275c"), "Indoor", new DateTimeOffset(new DateTime(2020, 4, 7, 19, 48, 40, 196, DateTimeKind.Unspecified).AddTicks(6126), new TimeSpan(0, 7, 0, 0, 0)), 30.052292579809320m, new DateTimeOffset(new DateTime(2020, 7, 7, 22, 40, 45, 671, DateTimeKind.Unspecified).AddTicks(480), new TimeSpan(0, 7, 0, 0, 0)), 36.59738646196080m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("9ec7cf01-d42c-fda1-8116-fa3d097e66c5"), 37.960000069793320m, new Guid("39b5a1a1-5462-94ea-f627-f5d5eee0105e"), "Indoor", new DateTimeOffset(new DateTime(2020, 12, 30, 16, 6, 44, 836, DateTimeKind.Unspecified).AddTicks(7234), new TimeSpan(0, 7, 0, 0, 0)), 21.978269448493720m, true, new DateTimeOffset(new DateTime(2020, 10, 29, 23, 2, 1, 119, DateTimeKind.Unspecified).AddTicks(491), new TimeSpan(0, 7, 0, 0, 0)), 27.921385717541640m },
                    { new Guid("a886f76d-e63c-8046-ed81-68bd10e2e3d1"), 46.347439995197320m, new Guid("04decd26-5c08-997b-9769-0f47fb03e9ce"), "Indoor", new DateTimeOffset(new DateTime(2020, 8, 11, 12, 27, 58, 191, DateTimeKind.Unspecified).AddTicks(5620), new TimeSpan(0, 7, 0, 0, 0)), 41.015568911570840m, true, new DateTimeOffset(new DateTime(2020, 7, 23, 23, 39, 33, 336, DateTimeKind.Unspecified).AddTicks(2445), new TimeSpan(0, 7, 0, 0, 0)), 27.732490532906960m },
                    { new Guid("b0645df7-a1a4-b5a1-3962-54ea94f627f5"), 21.273646024648880m, new Guid("bde38317-b552-659b-adce-d5fa148bef7b"), "Outdoor", new DateTimeOffset(new DateTime(2020, 12, 18, 22, 24, 38, 496, DateTimeKind.Unspecified).AddTicks(9735), new TimeSpan(0, 7, 0, 0, 0)), 20.116299991550080m, true, new DateTimeOffset(new DateTime(2020, 5, 2, 13, 44, 44, 1, DateTimeKind.Unspecified).AddTicks(6655), new TimeSpan(0, 7, 0, 0, 0)), 29.728197259701880m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("c61e5943-0572-475d-c2ed-18d762e5400b"), 18.138722650771360m, new Guid("39b5a1a1-5462-94ea-f627-f5d5eee0105e"), "Outdoor", new DateTimeOffset(new DateTime(2020, 1, 20, 17, 43, 34, 304, DateTimeKind.Unspecified).AddTicks(9135), new TimeSpan(0, 7, 0, 0, 0)), 19.235869836637680m, new DateTimeOffset(new DateTime(2020, 10, 25, 4, 35, 8, 60, DateTimeKind.Unspecified).AddTicks(6984), new TimeSpan(0, 7, 0, 0, 0)), 22.203386822810120m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("ce272427-3313-d248-a829-fd66c5668262"), 10.6581440012241440m, new Guid("bde38317-b552-659b-adce-d5fa148bef7b"), "Outdoor", new DateTimeOffset(new DateTime(2020, 9, 13, 9, 59, 26, 471, DateTimeKind.Unspecified).AddTicks(5189), new TimeSpan(0, 7, 0, 0, 0)), 40.983452178064480m, true, new DateTimeOffset(new DateTime(2020, 7, 5, 14, 37, 40, 355, DateTimeKind.Unspecified).AddTicks(7921), new TimeSpan(0, 7, 0, 0, 0)), 20.940376040963640m },
                    { new Guid("d382d930-5ce3-fc19-a249-af962f5f0ce2"), 42.70146971228600m, new Guid("31c95f5a-4a44-610a-56fa-39ba2e69221b"), "Indoor", new DateTimeOffset(new DateTime(2020, 1, 20, 7, 42, 9, 565, DateTimeKind.Unspecified).AddTicks(9209), new TimeSpan(0, 7, 0, 0, 0)), 13.7907609361180840m, true, new DateTimeOffset(new DateTime(2020, 4, 2, 15, 14, 46, 882, DateTimeKind.Unspecified).AddTicks(6824), new TimeSpan(0, 7, 0, 0, 0)), 48.106788004798240m },
                    { new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab"), 37.407649395711560m, new Guid("aa6983e2-10a4-4d8d-026f-58808923f5bd"), "Outdoor", new DateTimeOffset(new DateTime(2020, 3, 4, 6, 35, 3, 882, DateTimeKind.Unspecified).AddTicks(6650), new TimeSpan(0, 7, 0, 0, 0)), 48.703171610228320m, true, new DateTimeOffset(new DateTime(2020, 11, 19, 3, 21, 24, 374, DateTimeKind.Unspecified).AddTicks(892), new TimeSpan(0, 7, 0, 0, 0)), 16.042471139711560m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("e502f9c9-cf08-8911-95c5-40a761187ed5"), 45.647683830767720m, new Guid("4d5ace6d-8497-ab76-3a2f-df88956762d3"), "Outdoor", new DateTimeOffset(new DateTime(2020, 3, 4, 8, 32, 32, 852, DateTimeKind.Unspecified).AddTicks(7627), new TimeSpan(0, 7, 0, 0, 0)), 31.805057349524040m, new DateTimeOffset(new DateTime(2020, 3, 13, 19, 58, 27, 22, DateTimeKind.Unspecified).AddTicks(4382), new TimeSpan(0, 7, 0, 0, 0)), 13.5291591675622200m },
                    { new Guid("e9a957cd-768d-372e-54d3-4cf08bd2e2e7"), 36.08567719631160m, new Guid("04decd26-5c08-997b-9769-0f47fb03e9ce"), "Indoor", new DateTimeOffset(new DateTime(2020, 12, 8, 10, 58, 47, 193, DateTimeKind.Unspecified).AddTicks(7078), new TimeSpan(0, 7, 0, 0, 0)), 44.337673519895280m, new DateTimeOffset(new DateTime(2020, 3, 28, 19, 1, 11, 310, DateTimeKind.Unspecified).AddTicks(8367), new TimeSpan(0, 7, 0, 0, 0)), 34.618906166692680m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("ec779c3b-0d7d-7e38-ebec-94e998eb0c68"), 34.951667424734520m, new Guid("a9ff8f43-1b36-7c81-ae63-cbef0d43492d"), "Outdoor", new DateTimeOffset(new DateTime(2020, 4, 10, 18, 50, 49, 172, DateTimeKind.Unspecified).AddTicks(2274), new TimeSpan(0, 7, 0, 0, 0)), 49.536474402778080m, true, new DateTimeOffset(new DateTime(2020, 6, 11, 16, 32, 45, 765, DateTimeKind.Unspecified).AddTicks(7752), new TimeSpan(0, 7, 0, 0, 0)), 14.814202359325360m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("f5a7c23f-e018-9b7e-5202-b062f68e93af"), 43.7032401718680m, new Guid("c3c7fdd7-cfcb-1cc2-45de-b65290a953a9"), "Outdoor", new DateTimeOffset(new DateTime(2020, 9, 30, 22, 41, 15, 33, DateTimeKind.Unspecified).AddTicks(7936), new TimeSpan(0, 7, 0, 0, 0)), 38.567956252288040m, new DateTimeOffset(new DateTime(2020, 10, 4, 20, 1, 40, 911, DateTimeKind.Unspecified).AddTicks(265), new TimeSpan(0, 7, 0, 0, 0)), 38.297106729958720m },
                    { new Guid("f608ca7f-8f54-ca59-a88e-37a92300d6a4"), 12.9113730615523520m, new Guid("c3c7fdd7-cfcb-1cc2-45de-b65290a953a9"), "Outdoor", new DateTimeOffset(new DateTime(2020, 3, 11, 17, 31, 40, 530, DateTimeKind.Unspecified).AddTicks(2693), new TimeSpan(0, 7, 0, 0, 0)), 22.618399473195160m, new DateTimeOffset(new DateTime(2020, 1, 6, 13, 50, 57, 171, DateTimeKind.Unspecified).AddTicks(5185), new TimeSpan(0, 7, 0, 0, 0)), 38.126331580861640m },
                    { new Guid("f955bbef-50f7-6de5-ce5a-4d978476ab3a"), 45.055789349161000m, new Guid("ae2b65bc-8752-1d50-b8b4-7d7fa37ad24f"), "Outdoor", new DateTimeOffset(new DateTime(2020, 11, 7, 22, 3, 20, 43, DateTimeKind.Unspecified).AddTicks(9999), new TimeSpan(0, 7, 0, 0, 0)), 18.614604626137120m, new DateTimeOffset(new DateTime(2020, 3, 16, 3, 1, 38, 621, DateTimeKind.Unspecified).AddTicks(5180), new TimeSpan(0, 7, 0, 0, 0)), 27.884660650922280m },
                    { new Guid("fba953a9-7f00-ad94-4550-9c544966eb7f"), 11.3860198861854240m, new Guid("f62452d5-8c09-f356-f855-7eac442d01fb"), "Indoor", new DateTimeOffset(new DateTime(2020, 6, 15, 17, 27, 56, 908, DateTimeKind.Unspecified).AddTicks(3077), new TimeSpan(0, 7, 0, 0, 0)), 22.339875089162920m, new DateTimeOffset(new DateTime(2020, 6, 16, 5, 20, 55, 722, DateTimeKind.Unspecified).AddTicks(2799), new TimeSpan(0, 7, 0, 0, 0)), 15.309891628711440m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"), 32.382522030911640m, new Guid("30e4180f-7bad-447f-60e5-fe9dba8dcd41"), "Outdoor", new DateTimeOffset(new DateTime(2020, 11, 11, 16, 5, 48, 103, DateTimeKind.Unspecified).AddTicks(9392), new TimeSpan(0, 7, 0, 0, 0)), 10.8878830451927520m, true, new DateTimeOffset(new DateTime(2020, 3, 21, 18, 52, 52, 366, DateTimeKind.Unspecified).AddTicks(8117), new TimeSpan(0, 7, 0, 0, 0)), 32.662562552216720m },
                    { new Guid("ffd7dafa-8d35-ae04-36c7-ca601a039984"), 47.889399490267680m, new Guid("a9ff8f43-1b36-7c81-ae63-cbef0d43492d"), "Indoor", new DateTimeOffset(new DateTime(2020, 10, 19, 15, 3, 6, 182, DateTimeKind.Unspecified).AddTicks(4795), new TimeSpan(0, 7, 0, 0, 0)), 38.713293945748960m, true, new DateTimeOffset(new DateTime(2020, 7, 5, 3, 46, 2, 269, DateTimeKind.Unspecified).AddTicks(9562), new TimeSpan(0, 7, 0, 0, 0)), 28.486481149907440m }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("001bea9f-c9a6-1c20-80f0-9d1740b7b9b0"), new Guid("6d13d55f-c23f-f5a7-18e0-7e9b5202b062"), new DateTimeOffset(new DateTime(2023, 8, 4, 0, 34, 56, 95, DateTimeKind.Unspecified).AddTicks(3348), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 4, 10, 21, 53, 51, 328, DateTimeKind.Unspecified).AddTicks(7224), new TimeSpan(0, 7, 0, 0, 0)), "asperiores", "eos" },
                    { new Guid("031a60ca-8499-fd17-2e0d-492832ad01cf"), new Guid("a957cd73-8de9-2e76-3754-d34cf08bd2e2"), new DateTimeOffset(new DateTime(2024, 1, 4, 5, 51, 54, 65, DateTimeKind.Unspecified).AddTicks(6668), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 4, 30, 16, 13, 38, 871, DateTimeKind.Unspecified).AddTicks(659), new TimeSpan(0, 7, 0, 0, 0)), "nam", "deleniti" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("1203858b-b395-64ba-8349-350922c2f8b1"), new Guid("6dc2b651-86f7-3ca8-e646-80ed8168bd10"), new DateTimeOffset(new DateTime(2023, 7, 23, 5, 33, 40, 233, DateTimeKind.Unspecified).AddTicks(6944), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 28, 6, 1, 1, 99, DateTimeKind.Unspecified).AddTicks(7499), new TimeSpan(0, 7, 0, 0, 0)), "perspiciatis", "rerum" },
                    { new Guid("1c7a3311-13f2-0c4f-6634-ac2b97b6715e"), new Guid("6649549c-7feb-70fc-5fef-ed2c0eaddc74"), new DateTimeOffset(new DateTime(2023, 10, 10, 3, 55, 2, 875, DateTimeKind.Unspecified).AddTicks(2811), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 22, 4, 14, 55, 267, DateTimeKind.Unspecified).AddTicks(4866), new TimeSpan(0, 7, 0, 0, 0)), "temporibus", "velit" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("22389678-518c-45e7-09eb-80f68b20142b"), new Guid("30e4180f-7bad-447f-60e5-fe9dba8dcd41"), new DateTimeOffset(new DateTime(2023, 8, 6, 6, 14, 21, 513, DateTimeKind.Unspecified).AddTicks(196), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 8, 5, 8, 42, 58, 621, DateTimeKind.Unspecified).AddTicks(4867), new TimeSpan(0, 7, 0, 0, 0)), "nesciunt", "velit" });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("234c0837-e07e-6fb5-dc08-5b8c438fffa9"), new Guid("0a6fb183-3558-f00e-f5e7-4a756503f84a"), new DateTimeOffset(new DateTime(2024, 5, 9, 21, 52, 32, 163, DateTimeKind.Unspecified).AddTicks(8808), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 12, 8, 55, 10, 647, DateTimeKind.Unspecified).AddTicks(8249), new TimeSpan(0, 7, 0, 0, 0)), "eveniet", "deleniti" },
                    { new Guid("29a8d248-66fd-66c5-8262-26cdde04085c"), new Guid("40d167eb-7d65-5050-c5b9-bd58e5e1a445"), new DateTimeOffset(new DateTime(2023, 10, 24, 10, 11, 20, 539, DateTimeKind.Unspecified).AddTicks(3617), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 26, 7, 35, 18, 342, DateTimeKind.Unspecified).AddTicks(1000), new TimeSpan(0, 7, 0, 0, 0)), "velit", "et" },
                    { new Guid("2bfb012d-0c51-868e-863e-ededbd69d813"), new Guid("0c4f13f2-3466-2bac-97b6-715e720dd466"), new DateTimeOffset(new DateTime(2023, 10, 30, 15, 11, 4, 214, DateTimeKind.Unspecified).AddTicks(3753), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 19, 18, 45, 41, 588, DateTimeKind.Unspecified).AddTicks(262), new TimeSpan(0, 7, 0, 0, 0)), "eos", "itaque" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("37778a15-5d58-4813-6525-53d7ec3774d8"), new Guid("87973a15-8dde-6aed-3a99-5add4e83275c"), new DateTimeOffset(new DateTime(2023, 12, 15, 22, 42, 3, 398, DateTimeKind.Unspecified).AddTicks(3303), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 2, 17, 3, 39, 33, 933, DateTimeKind.Unspecified).AddTicks(8642), new TimeSpan(0, 7, 0, 0, 0)), "architecto", "blanditiis" });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("3a51ce71-ab15-6d1e-75d2-65d33d5c153a"), new Guid("6dc2b651-86f7-3ca8-e646-80ed8168bd10"), new DateTimeOffset(new DateTime(2023, 11, 29, 15, 39, 29, 131, DateTimeKind.Unspecified).AddTicks(1469), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 5, 0, 7, 32, 640, DateTimeKind.Unspecified).AddTicks(8524), new TimeSpan(0, 7, 0, 0, 0)), "omnis", "sapiente" });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("3aab7684-df2f-9588-6762-d36d43591ec6"), new Guid("f4b35b22-5424-ad20-1a71-ce513a15ab1e"), new DateTimeOffset(new DateTime(2024, 4, 22, 16, 52, 35, 710, DateTimeKind.Unspecified).AddTicks(8314), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 21, 2, 11, 40, 517, DateTimeKind.Unspecified).AddTicks(1101), new TimeSpan(0, 7, 0, 0, 0)), "autem", "est" },
                    { new Guid("3dfa1681-7e09-c566-fd01-2c2fc3339462"), new Guid("8bc880c5-bc39-a62d-528d-a9d070fe5e75"), new DateTimeOffset(new DateTime(2023, 9, 1, 4, 32, 9, 472, DateTimeKind.Unspecified).AddTicks(6287), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 12, 4, 57, 13, 367, DateTimeKind.Unspecified).AddTicks(9123), new TimeSpan(0, 7, 0, 0, 0)), "alias", "ea" },
                    { new Guid("430defcb-2d49-4e90-1bf1-51a934225bb3"), new Guid("4042cc3e-fa91-d7da-ff35-8d04ae36c7ca"), new DateTimeOffset(new DateTime(2024, 4, 16, 7, 21, 53, 94, DateTimeKind.Unspecified).AddTicks(8422), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 4, 15, 7, 5, 52, 365, DateTimeKind.Unspecified).AddTicks(2712), new TimeSpan(0, 7, 0, 0, 0)), "et", "iste" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("4eaaa438-7fb4-4255-1996-b8a364698dd7"), new Guid("0bab7af2-5fac-9b1e-3f2b-cd52f09e51d4"), new DateTimeOffset(new DateTime(2024, 2, 7, 18, 42, 12, 47, DateTimeKind.Unspecified).AddTicks(8101), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 8, 18, 42, 10, 146, DateTimeKind.Unspecified).AddTicks(9556), new TimeSpan(0, 7, 0, 0, 0)), "et", "magni" });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("51c657c7-c2b6-f76d-86a8-3ce64680ed81"), new Guid("4042cc3e-fa91-d7da-ff35-8d04ae36c7ca"), new DateTimeOffset(new DateTime(2024, 3, 4, 18, 36, 43, 582, DateTimeKind.Unspecified).AddTicks(8038), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 7, 28, 15, 32, 7, 12, DateTimeKind.Unspecified).AddTicks(7438), new TimeSpan(0, 7, 0, 0, 0)), "laborum", "ab" });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("580a6fb1-0e35-f5f0-e74a-756503f84a7c"), new Guid("6d13d55f-c23f-f5a7-18e0-7e9b5202b062"), new DateTimeOffset(new DateTime(2023, 11, 9, 18, 4, 30, 506, DateTimeKind.Unspecified).AddTicks(3876), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 12, 21, 59, 58, 943, DateTimeKind.Unspecified).AddTicks(984), new TimeSpan(0, 7, 0, 0, 0)), "porro", "pariatur" });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("5ce3d382-fc19-49a2-af96-2f5f0ce2aa42"), new Guid("582236b0-6743-9b61-aa64-9fd9f78f1a58"), new DateTimeOffset(new DateTime(2023, 7, 13, 20, 31, 46, 238, DateTimeKind.Unspecified).AddTicks(2713), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 9, 25, 4, 4, 23, 555, DateTimeKind.Unspecified).AddTicks(330), new TimeSpan(0, 7, 0, 0, 0)), "consequatur", "asperiores" },
                    { new Guid("6239b5a1-ea54-f694-27f5-d5eee0105eca"), new Guid("9528cd4e-80df-ffff-977f-ca08f6548f59"), new DateTimeOffset(new DateTime(2023, 8, 4, 12, 38, 17, 879, DateTimeKind.Unspecified).AddTicks(158), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 8, 28, 1, 34, 6, 625, DateTimeKind.Unspecified).AddTicks(260), new TimeSpan(0, 7, 0, 0, 0)), "eius", "consequuntur" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("65bc72ff-ae2b-8752-501d-b8b47d7fa37a"), new Guid("04decd26-5c08-997b-9769-0f47fb03e9ce"), new DateTimeOffset(new DateTime(2023, 12, 12, 9, 36, 6, 906, DateTimeKind.Unspecified).AddTicks(592), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 24, 3, 48, 15, 978, DateTimeKind.Unspecified).AddTicks(156), new TimeSpan(0, 7, 0, 0, 0)), "officiis", "ut" },
                    { new Guid("67eba435-40d1-7d65-5050-c5b9bd58e5e1"), new Guid("0945e751-80eb-8bf6-2014-2b1237d52d64"), new DateTimeOffset(new DateTime(2023, 7, 18, 10, 2, 47, 943, DateTimeKind.Unspecified).AddTicks(7769), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 15, 1, 29, 55, 749, DateTimeKind.Unspecified).AddTicks(2968), new TimeSpan(0, 7, 0, 0, 0)), "aut", "nihil" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("6ef2cebd-84d8-048d-bd66-760f9121b162"), new Guid("0c037a58-9f75-ab3f-38a4-aa4eb47f5542"), new DateTimeOffset(new DateTime(2024, 2, 26, 14, 51, 13, 607, DateTimeKind.Unspecified).AddTicks(4717), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 3, 30, 12, 57, 49, 184, DateTimeKind.Unspecified).AddTicks(8711), new TimeSpan(0, 7, 0, 0, 0)), "dolorem", "maiores" });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("71a777e1-9a27-4449-4df5-62d9b0a72436"), new Guid("c9945bcd-5515-8954-f74e-1337084c237e"), new DateTimeOffset(new DateTime(2023, 7, 5, 15, 43, 56, 98, DateTimeKind.Unspecified).AddTicks(3951), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 10, 2, 4, 22, 987, DateTimeKind.Unspecified).AddTicks(975), new TimeSpan(0, 7, 0, 0, 0)), "ratione", "deleniti" },
                    { new Guid("73f6340c-57cd-e9a9-8d76-2e3754d34cf0"), new Guid("a957cd73-8de9-2e76-3754-d34cf08bd2e2"), new DateTimeOffset(new DateTime(2023, 9, 24, 12, 9, 58, 935, DateTimeKind.Unspecified).AddTicks(7447), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 12, 6, 30, 54, 213, DateTimeKind.Unspecified).AddTicks(2155), new TimeSpan(0, 7, 0, 0, 0)), "ut", "voluptatibus" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("76b4b43e-6bbc-a7f7-1f4c-4773aee30c10"), new Guid("0a0ab19c-dca2-9549-e1e4-78b199327e3a"), new DateTimeOffset(new DateTime(2024, 2, 11, 14, 19, 11, 494, DateTimeKind.Unspecified).AddTicks(284), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 1, 10, 17, 22, 26, 425, DateTimeKind.Unspecified).AddTicks(9074), new TimeSpan(0, 7, 0, 0, 0)), "cumque", "rerum" },
                    { new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"), new Guid("a9ff8f43-1b36-7c81-ae63-cbef0d43492d"), new DateTimeOffset(new DateTime(2024, 6, 6, 18, 53, 4, 232, DateTimeKind.Unspecified).AddTicks(3380), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 3, 14, 10, 48, 37, 191, DateTimeKind.Unspecified).AddTicks(4342), new TimeSpan(0, 7, 0, 0, 0)), "est", "iste" },
                    { new Guid("7fd8b31a-ccc5-e27d-8369-aaa4108d4d02"), new Guid("04decd26-5c08-997b-9769-0f47fb03e9ce"), new DateTimeOffset(new DateTime(2024, 5, 12, 10, 54, 1, 607, DateTimeKind.Unspecified).AddTicks(2493), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 7, 21, 35, 50, 258, DateTimeKind.Unspecified).AddTicks(5434), new TimeSpan(0, 7, 0, 0, 0)), "sint", "perferendis" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("89d5ab85-8ee1-80c5-c88b-39bc2da6528d"), new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"), new DateTimeOffset(new DateTime(2024, 4, 15, 1, 2, 57, 478, DateTimeKind.Unspecified).AddTicks(6488), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 3, 26, 8, 58, 28, 348, DateTimeKind.Unspecified).AddTicks(92), new TimeSpan(0, 7, 0, 0, 0)), "hic", "officiis" },
                    { new Guid("8b3ca5cc-36b0-5822-4367-619baa649fd9"), new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"), new DateTimeOffset(new DateTime(2024, 1, 17, 7, 2, 32, 934, DateTimeKind.Unspecified).AddTicks(3104), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 19, 13, 17, 36, 230, DateTimeKind.Unspecified).AddTicks(2865), new TimeSpan(0, 7, 0, 0, 0)), "nobis", "quasi" },
                    { new Guid("8f54f608-ca59-8ea8-37a9-2300d6a4402f"), new Guid("30e4180f-7bad-447f-60e5-fe9dba8dcd41"), new DateTimeOffset(new DateTime(2023, 9, 3, 6, 21, 17, 202, DateTimeKind.Unspecified).AddTicks(6469), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 6, 30, 2, 40, 33, 843, DateTimeKind.Unspecified).AddTicks(8963), new TimeSpan(0, 7, 0, 0, 0)), "occaecati", "maxime" },
                    { new Guid("953b298b-2d7e-d55f-136d-3fc2a7f518e0"), new Guid("582236b0-6743-9b61-aa64-9fd9f78f1a58"), new DateTimeOffset(new DateTime(2024, 2, 6, 10, 47, 30, 122, DateTimeKind.Unspecified).AddTicks(8801), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 7, 15, 38, 39, 364, DateTimeKind.Unspecified).AddTicks(2840), new TimeSpan(0, 7, 0, 0, 0)), "repellat", "sed" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new Guid("0bab7af2-5fac-9b1e-3f2b-cd52f09e51d4"), new DateTimeOffset(new DateTime(2024, 5, 22, 23, 2, 13, 809, DateTimeKind.Unspecified).AddTicks(7803), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 25, 6, 50, 17, 404, DateTimeKind.Unspecified).AddTicks(9508), new TimeSpan(0, 7, 0, 0, 0)), "ut", "minus" },
                    { new Guid("9db5e7e8-1e32-c9fa-fc05-d4975ed3d849"), new Guid("f62452d5-8c09-f356-f855-7eac442d01fb"), new DateTimeOffset(new DateTime(2023, 8, 16, 10, 50, 54, 474, DateTimeKind.Unspecified).AddTicks(6817), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 7, 24, 23, 4, 45, 974, DateTimeKind.Unspecified).AddTicks(3967), new TimeSpan(0, 7, 0, 0, 0)), "praesentium", "quis" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("a72b6cbd-72d6-0a05-8f89-22cd5b94c915"), new Guid("28490d2e-ad32-cf01-c79e-2cd4a1fd8116"), new DateTimeOffset(new DateTime(2024, 2, 23, 2, 44, 41, 27, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 6, 25, 8, 2, 48, 55, DateTimeKind.Unspecified).AddTicks(8950), new TimeSpan(0, 7, 0, 0, 0)), "qui", "error" });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("a9f24616-93e6-626c-6933-ef855ab90a53"), new Guid("2f40a4d6-602b-79ee-b453-e39036dfc79c"), new DateTimeOffset(new DateTime(2024, 3, 17, 2, 54, 54, 452, DateTimeKind.Unspecified).AddTicks(9080), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 3, 20, 4, 25, 44, 252, DateTimeKind.Unspecified).AddTicks(8027), new TimeSpan(0, 7, 0, 0, 0)), "explicabo", "ipsa" },
                    { new Guid("af938ef6-c065-3ea8-cc42-4091fadad7ff"), new Guid("2f40a4d6-602b-79ee-b453-e39036dfc79c"), new DateTimeOffset(new DateTime(2023, 9, 19, 11, 39, 37, 19, DateTimeKind.Unspecified).AddTicks(4613), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 16, 13, 54, 9, 415, DateTimeKind.Unspecified).AddTicks(3503), new TimeSpan(0, 7, 0, 0, 0)), "sequi", "recusandae" },
                    { new Guid("b45a905d-2d81-d8dc-7507-29b4372c2ad5"), new Guid("4042cc3e-fa91-d7da-ff35-8d04ae36c7ca"), new DateTimeOffset(new DateTime(2023, 9, 16, 14, 52, 9, 303, DateTimeKind.Unspecified).AddTicks(6159), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 10, 27, 13, 35, 16, 815, DateTimeKind.Unspecified).AddTicks(6973), new TimeSpan(0, 7, 0, 0, 0)), "voluptas", "voluptas" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("b552bde3-659b-cead-d5fa-148bef7b2fa2"), new Guid("0c4f13f2-3466-2bac-97b6-715e720dd466"), new DateTimeOffset(new DateTime(2024, 5, 26, 10, 26, 12, 826, DateTimeKind.Unspecified).AddTicks(8757), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 13, 2, 55, 30, 440, DateTimeKind.Unspecified).AddTicks(81), new TimeSpan(0, 7, 0, 0, 0)), "sunt", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("b6de451c-9052-53a9-a9fb-007f94ad4550"), new Guid("8b1ffb45-1ea4-e025-e09e-2784cd25923f"), new DateTimeOffset(new DateTime(2024, 2, 7, 5, 8, 51, 208, DateTimeKind.Unspecified).AddTicks(819), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 9, 17, 5, 11, 24, 707, DateTimeKind.Unspecified).AddTicks(2697), new TimeSpan(0, 7, 0, 0, 0)), "voluptas", "sint" },
                    { new Guid("c5958911-a740-1861-7ed5-5224f6098c56"), new Guid("8b1ffb45-1ea4-e025-e09e-2784cd25923f"), new DateTimeOffset(new DateTime(2023, 6, 28, 2, 39, 43, 325, DateTimeKind.Unspecified).AddTicks(9025), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 7, 11, 0, 32, 28, 956, DateTimeKind.Unspecified).AddTicks(8878), new TimeSpan(0, 7, 0, 0, 0)), "voluptatibus", "quidem" },
                    { new Guid("cee903fb-653b-0877-add2-e94ecd2895df"), new Guid("19469a5c-d6ab-8b1d-dfd6-47876ffa5d3f"), new DateTimeOffset(new DateTime(2024, 4, 19, 17, 44, 13, 521, DateTimeKind.Unspecified).AddTicks(8216), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 1, 24, 19, 27, 45, 115, DateTimeKind.Unspecified).AddTicks(9740), new TimeSpan(0, 7, 0, 0, 0)), "et", "voluptate" },
                    { new Guid("d6df8b1d-8747-fa6f-5d3f-efbb55f9f750"), new Guid("8364bab3-3549-2209-c2f8-b1659599800f"), new DateTimeOffset(new DateTime(2023, 11, 30, 17, 29, 46, 830, DateTimeKind.Unspecified).AddTicks(8955), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 13, 12, 2, 25, 60, DateTimeKind.Unspecified).AddTicks(4179), new TimeSpan(0, 7, 0, 0, 0)), "sequi", "rerum" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("dca20a0a-9549-e4e1-78b1-99327e3ac5e0"), new Guid("f76bbc76-1fa7-474c-73ae-e30c1006428e"), new DateTimeOffset(new DateTime(2023, 8, 1, 15, 49, 40, 350, DateTimeKind.Unspecified).AddTicks(3527), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 22, 0, 27, 3, 73, DateTimeKind.Unspecified).AddTicks(3600), new TimeSpan(0, 7, 0, 0, 0)), "cupiditate", "quasi" });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("dd5a993a-834e-5c27-278e-b6b17d3ef20f"), new Guid("c9945bcd-5515-8954-f74e-1337084c237e"), new DateTimeOffset(new DateTime(2024, 1, 23, 11, 24, 4, 258, DateTimeKind.Unspecified).AddTicks(7629), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 2, 27, 0, 2, 19, 65, DateTimeKind.Unspecified).AddTicks(3272), new TimeSpan(0, 7, 0, 0, 0)), "ut", "qui" });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab"), new Guid("aa6983e2-10a4-4d8d-026f-58808923f5bd"), new DateTimeOffset(new DateTime(2023, 8, 14, 22, 26, 58, 129, DateTimeKind.Unspecified).AddTicks(2794), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 29, 9, 12, 22, 75, DateTimeKind.Unspecified).AddTicks(6842), new TimeSpan(0, 7, 0, 0, 0)), "nobis", "delectus" },
                    { new Guid("dfd5e5a3-ad91-6e2a-8169-d69d496e5763"), new Guid("04decd26-5c08-997b-9769-0f47fb03e9ce"), new DateTimeOffset(new DateTime(2023, 8, 25, 20, 24, 55, 529, DateTimeKind.Unspecified).AddTicks(5750), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 14, 18, 58, 8, 846, DateTimeKind.Unspecified).AddTicks(4481), new TimeSpan(0, 7, 0, 0, 0)), "sint", "dolorem" },
                    { new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d"), new Guid("aa6983e2-10a4-4d8d-026f-58808923f5bd"), new DateTimeOffset(new DateTime(2023, 7, 5, 16, 25, 29, 66, DateTimeKind.Unspecified).AddTicks(8790), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 10, 21, 39, 17, 903, DateTimeKind.Unspecified).AddTicks(4035), new TimeSpan(0, 7, 0, 0, 0)), "sunt", "necessitatibus" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("e562d718-0b40-d9b5-4a50-898507682b0d"), new Guid("40d167eb-7d65-5050-c5b9-bd58e5e1a445"), new DateTimeOffset(new DateTime(2023, 12, 15, 18, 10, 45, 285, DateTimeKind.Unspecified).AddTicks(373), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 9, 26, 14, 47, 35, 830, DateTimeKind.Unspecified).AddTicks(8905), new TimeSpan(0, 7, 0, 0, 0)), "iusto", "voluptas" },
                    { new Guid("ef5f70fc-2ced-ad0e-dc74-db7688646ffd"), new Guid("f4b35b22-5424-ad20-1a71-ce513a15ab1e"), new DateTimeOffset(new DateTime(2024, 5, 7, 19, 32, 18, 602, DateTimeKind.Unspecified).AddTicks(4184), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 11, 19, 16, 49, 0, 545, DateTimeKind.Unspecified).AddTicks(3198), new TimeSpan(0, 7, 0, 0, 0)), "perspiciatis", "repellat" },
                    { new Guid("f052cd2b-519e-9ed4-a805-15b413c4587a"), new Guid("c32f2c01-9433-2762-2427-ce133348d2a8"), new DateTimeOffset(new DateTime(2024, 1, 7, 3, 11, 34, 304, DateTimeKind.Unspecified).AddTicks(988), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 11, 15, 22, 39, 44, 623, DateTimeKind.Unspecified).AddTicks(2540), new TimeSpan(0, 7, 0, 0, 0)), "quaerat", "sit" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("fee56044-ba9d-cd8d-411f-2c0793b7df38"), new Guid("2f40a4d6-602b-79ee-b453-e39036dfc79c"), new DateTimeOffset(new DateTime(2024, 4, 21, 1, 58, 59, 21, DateTimeKind.Unspecified).AddTicks(3361), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 3, 5, 0, 23, 44, 356, DateTimeKind.Unspecified).AddTicks(5750), new TimeSpan(0, 7, 0, 0, 0)), "eos", "ea" });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[] { new Guid("01ad3228-c7cf-2c9e-d4a1-fd8116fa3d09"), new Guid("5ace6de5-974d-7684-ab3a-2fdf88956762"), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 1, 31, 156, DateTimeKind.Unspecified).AddTicks(9326), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 12, 13, 17, 25, 992, DateTimeKind.Unspecified).AddTicks(8173), new TimeSpan(0, 7, 0, 0, 0)), new Guid("430defcb-2d49-4e90-1bf1-51a934225bb3") });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[] { new Guid("0a0ab19c-dca2-9549-e1e4-78b199327e3a"), new Guid("fad5cead-8b14-7bef-2fa2-d996de815383"), new DateTimeOffset(new DateTime(2023, 7, 16, 0, 13, 35, 189, DateTimeKind.Unspecified).AddTicks(3765), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 16, 9, 20, 43, 190, DateTimeKind.Unspecified).AddTicks(3294), new TimeSpan(0, 7, 0, 0, 0)), new Guid("37778a15-5d58-4813-6525-53d7ec3774d8") });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[] { new Guid("0a6fb183-3558-f00e-f5e7-4a756503f84a"), new Guid("66fd29a8-66c5-6282-26cd-de04085c7b99"), new DateTimeOffset(new DateTime(2023, 10, 6, 5, 50, 37, 570, DateTimeKind.Unspecified).AddTicks(264), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 18, 10, 27, 58, 769, DateTimeKind.Unspecified).AddTicks(6127), new TimeSpan(0, 7, 0, 0, 0)), new Guid("37778a15-5d58-4813-6525-53d7ec3774d8") });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("0b40e562-d9b5-504a-8985-07682b0d588f"), new Guid("ae048d35-c736-60ca-1a03-998417fd2e0d"), new DateTimeOffset(new DateTime(2023, 9, 26, 14, 47, 35, 844, DateTimeKind.Unspecified).AddTicks(2071), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 6, 9, 0, 22, 27, 73, DateTimeKind.Unspecified).AddTicks(5161), new TimeSpan(0, 7, 0, 0, 0)), new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d") },
                    { new Guid("15c913df-778a-5837-5d13-48652553d7ec"), new Guid("a7b0d962-3624-666a-0cbf-75043eb4b476"), new DateTimeOffset(new DateTime(2024, 3, 21, 1, 22, 12, 892, DateTimeKind.Unspecified).AddTicks(1759), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 3, 6, 20, 17, 13, 348, DateTimeKind.Unspecified).AddTicks(537), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8f54f608-ca59-8ea8-37a9-2300d6a4402f") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[] { new Guid("1bea9f71-a600-20c9-1c80-f09d1740b7b9"), new Guid("66fd29a8-66c5-6282-26cd-de04085c7b99"), new DateTimeOffset(new DateTime(2023, 6, 26, 11, 9, 12, 976, DateTimeKind.Unspecified).AddTicks(5867), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 14, 11, 51, 49, 819, DateTimeKind.Unspecified).AddTicks(6498), new TimeSpan(0, 7, 0, 0, 0)), new Guid("73f6340c-57cd-e9a9-8d76-2e3754d34cf0") });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("23a9378e-d600-40a4-2f2b-60ee79b453e3"), new Guid("ad0e2ced-74dc-76db-8864-6ffd2dc498c6"), new DateTimeOffset(new DateTime(2023, 10, 31, 3, 0, 8, 10, DateTimeKind.Unspecified).AddTicks(7660), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 4, 7, 4, 42, 12, 809, DateTimeKind.Unspecified).AddTicks(506), new TimeSpan(0, 7, 0, 0, 0)), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") },
                    { new Guid("2cedef5f-ad0e-74dc-db76-88646ffd2dc4"), new Guid("ccc57fd8-e27d-6983-aaa4-108d4d026f58"), new DateTimeOffset(new DateTime(2023, 11, 19, 16, 49, 0, 558, DateTimeKind.Unspecified).AddTicks(6257), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 21, 20, 14, 10, 429, DateTimeKind.Unspecified).AddTicks(4201), new TimeSpan(0, 7, 0, 0, 0)), new Guid("76b4b43e-6bbc-a7f7-1f4c-4773aee30c10") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[] { new Guid("2dd53712-d464-ab85-d589-e18ec580c88b"), new Guid("ab3f9f75-a438-4eaa-b47f-55421996b8a3"), new DateTimeOffset(new DateTime(2023, 12, 5, 13, 53, 30, 483, DateTimeKind.Unspecified).AddTicks(7094), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 13, 2, 8, 15, 690, DateTimeKind.Unspecified).AddTicks(3147), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d6df8b1d-8747-fa6f-5d3f-efbb55f9f750") });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("31663645-0c09-f634-73cd-57a9e98d762e"), new Guid("ce3fb385-7d3e-ec86-a0c0-8cc4d7a942e5"), new DateTimeOffset(new DateTime(2024, 5, 18, 18, 30, 15, 357, DateTimeKind.Unspecified).AddTicks(2359), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 2, 23, 20, 24, 53, 203, DateTimeKind.Unspecified).AddTicks(8603), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8f54f608-ca59-8ea8-37a9-2300d6a4402f") },
                    { new Guid("329db5e7-fa1e-fcc9-05d4-975ed3d8499f"), new Guid("38dfb793-9a5c-1946-abd6-1d8bdfd64787"), new DateTimeOffset(new DateTime(2023, 8, 16, 10, 50, 54, 487, DateTimeKind.Unspecified).AddTicks(9985), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 7, 24, 23, 4, 45, 987, DateTimeKind.Unspecified).AddTicks(7135), new TimeSpan(0, 7, 0, 0, 0)), new Guid("580a6fb1-0e35-f5f0-e74a-756503f84a7c") },
                    { new Guid("33c32f2c-6294-2427-27ce-133348d2a829"), new Guid("9e3042aa-dfdd-c913-158a-7737585d1348"), new DateTimeOffset(new DateTime(2023, 11, 1, 9, 35, 32, 167, DateTimeKind.Unspecified).AddTicks(6220), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 3, 18, 8, 22, 49, 143, DateTimeKind.Unspecified).AddTicks(3675), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b45a905d-2d81-d8dc-7507-29b4372c2ad5") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("41cd8dba-2c1f-9307-b7df-385c9a4619ab"), new Guid("b4b81d50-7f7d-7aa3-d24f-0319ce64c757"), new DateTimeOffset(new DateTime(2023, 10, 26, 16, 25, 11, 978, DateTimeKind.Unspecified).AddTicks(424), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 3, 3, 4, 4, 20, 426, DateTimeKind.Unspecified).AddTicks(6127), new TimeSpan(0, 7, 0, 0, 0)), new Guid("76b4b43e-6bbc-a7f7-1f4c-4773aee30c10") },
                    { new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"), new Guid("ae048d35-c736-60ca-1a03-998417fd2e0d"), new DateTimeOffset(new DateTime(2024, 2, 3, 5, 5, 12, 824, DateTimeKind.Unspecified).AddTicks(6636), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 18, 1, 23, 8, 33, DateTimeKind.Unspecified).AddTicks(4035), new TimeSpan(0, 7, 0, 0, 0)), new Guid("71a777e1-9a27-4449-4df5-62d9b0a72436") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[] { new Guid("438c5b08-ff8f-36a9-1b81-7cae63cbef0d"), new Guid("09354983-c222-b1f8-6595-99800ff98b29"), new DateTimeOffset(new DateTime(2023, 8, 1, 3, 40, 20, 32, DateTimeKind.Unspecified).AddTicks(9305), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 10, 12, 44, 35, 681, DateTimeKind.Unspecified).AddTicks(866), new TimeSpan(0, 7, 0, 0, 0)), new Guid("001bea9f-c9a6-1c20-80f0-9d1740b7b9b0") });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[] { new Guid("4ee9d2ad-28cd-df95-80ff-ff977fca08f6"), new Guid("a4d60023-2f40-602b-ee79-b453e39036df"), new DateTimeOffset(new DateTime(2023, 7, 4, 7, 8, 18, 664, DateTimeKind.Unspecified).AddTicks(7855), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 22, 6, 9, 54, 945, DateTimeKind.Unspecified).AddTicks(9088), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a72b6cbd-72d6-0a05-8f89-22cd5b94c915") });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("568c09f6-f8f3-7e55-ac44-2d01fb2b510c"), new Guid("4206100c-318e-34ba-525e-7c82b1c93efc"), new DateTimeOffset(new DateTime(2024, 5, 7, 15, 40, 52, 42, DateTimeKind.Unspecified).AddTicks(8238), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 4, 4, 19, 34, 13, 336, DateTimeKind.Unspecified).AddTicks(7118), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b6de451c-9052-53a9-a9fb-007f94ad4550") },
                    { new Guid("586f024d-8980-f523-bdce-f26ed8848d04"), new Guid("ad0e2ced-74dc-76db-8864-6ffd2dc498c6"), new DateTimeOffset(new DateTime(2024, 5, 19, 6, 53, 17, 7, DateTimeKind.Unspecified).AddTicks(7458), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 9, 12, 4, 12, 52, 616, DateTimeKind.Unspecified).AddTicks(4123), new TimeSpan(0, 7, 0, 0, 0)), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") },
                    { new Guid("65d2756d-3dd3-155c-3a97-87de8ded6a3a"), new Guid("ad0e2ced-74dc-76db-8864-6ffd2dc498c6"), new DateTimeOffset(new DateTime(2024, 3, 8, 12, 31, 20, 33, DateTimeKind.Unspecified).AddTicks(3023), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 7, 13, 5, 9, 59, 585, DateTimeKind.Unspecified).AddTicks(4509), new TimeSpan(0, 7, 0, 0, 0)), new Guid("73f6340c-57cd-e9a9-8d76-2e3754d34cf0") },
                    { new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"), new Guid("19aad1fe-5653-b064-e414-5d3dcc3f8970"), new DateTimeOffset(new DateTime(2024, 6, 20, 7, 39, 18, 727, DateTimeKind.Unspecified).AddTicks(1454), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 8, 26, 11, 20, 32, 76, DateTimeKind.Unspecified).AddTicks(7215), new TimeSpan(0, 7, 0, 0, 0)), new Guid("71a777e1-9a27-4449-4df5-62d9b0a72436") },
                    { new Guid("72ff2f81-65bc-ae2b-5287-501db8b47d7f"), new Guid("38dfb793-9a5c-1946-abd6-1d8bdfd64787"), new DateTimeOffset(new DateTime(2023, 10, 29, 11, 43, 0, 973, DateTimeKind.Unspecified).AddTicks(5221), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 8, 9, 4, 9, 15, 276, DateTimeKind.Unspecified).AddTicks(2828), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8b3ca5cc-36b0-5822-4367-619baa649fd9") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("786a9718-31c8-f2fa-7aab-0bac5f1e9b3f"), new Guid("626c93e6-3369-85ef-5ab9-0a53b0f5a847"), new DateTimeOffset(new DateTime(2023, 12, 21, 0, 21, 52, 772, DateTimeKind.Unspecified).AddTicks(3441), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 6, 20, 42, 27, 580, DateTimeKind.Unspecified).AddTicks(5001), new TimeSpan(0, 7, 0, 0, 0)), new Guid("22389678-518c-45e7-09eb-80f68b20142b") },
                    { new Guid("7ee018f5-529b-b002-62f6-8e93af65c0a8"), new Guid("fc468bcc-b19c-0a0a-a2dc-4995e1e478b1"), new DateTimeOffset(new DateTime(2024, 3, 24, 11, 30, 51, 719, DateTimeKind.Unspecified).AddTicks(4674), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 3, 28, 8, 51, 17, 596, DateTimeKind.Unspecified).AddTicks(7005), new TimeSpan(0, 7, 0, 0, 0)), new Guid("001bea9f-c9a6-1c20-80f0-9d1740b7b9b0") },
                    { new Guid("88df2f3a-6795-d362-6d43-591ec672055d"), new Guid("e018f5a7-9b7e-0252-b062-f68e93af65c0"), new DateTimeOffset(new DateTime(2024, 5, 13, 22, 43, 32, 341, DateTimeKind.Unspecified).AddTicks(2685), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 16, 0, 3, 189, DateTimeKind.Unspecified).AddTicks(2055), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6ef2cebd-84d8-048d-bd66-760f9121b162") },
                    { new Guid("8a824ff6-5da4-5a90-b481-2ddcd8750729"), new Guid("a7b0d962-3624-666a-0cbf-75043eb4b476"), new DateTimeOffset(new DateTime(2024, 2, 28, 8, 27, 14, 574, DateTimeKind.Unspecified).AddTicks(9450), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 1, 10, 19, 7, 421, DateTimeKind.Unspecified).AddTicks(4583), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b45a905d-2d81-d8dc-7507-29b4372c2ad5") },
                    { new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"), new Guid("19aad1fe-5653-b064-e414-5d3dcc3f8970"), new DateTimeOffset(new DateTime(2023, 11, 7, 10, 43, 14, 797, DateTimeKind.Unspecified).AddTicks(8270), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 18, 3, 57, 24, 341, DateTimeKind.Unspecified).AddTicks(387), new TimeSpan(0, 7, 0, 0, 0)), new Guid("37778a15-5d58-4813-6525-53d7ec3774d8") },
                    { new Guid("91dfd5e5-2aad-816e-69d6-9d496e5763a3"), new Guid("09f62452-568c-f8f3-557e-ac442d01fb2b"), new DateTimeOffset(new DateTime(2023, 8, 25, 20, 24, 55, 542, DateTimeKind.Unspecified).AddTicks(8813), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 14, 18, 58, 8, 859, DateTimeKind.Unspecified).AddTicks(7543), new TimeSpan(0, 7, 0, 0, 0)), new Guid("67eba435-40d1-7d65-5050-c5b9bd58e5e1") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[] { new Guid("945bcd22-15c9-5455-89f7-4e1337084c23"), new Guid("66fd29a8-66c5-6282-26cd-de04085c7b99"), new DateTimeOffset(new DateTime(2024, 1, 11, 20, 11, 9, 267, DateTimeKind.Unspecified).AddTicks(4847), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 25, 4, 56, 22, 938, DateTimeKind.Unspecified).AddTicks(6921), new TimeSpan(0, 7, 0, 0, 0)), new Guid("dd5a993a-834e-5c27-278e-b6b17d3ef20f") });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[] { new Guid("9565b1f8-8099-f90f-8b29-3b957e2d5fd5"), new Guid("1f24a4b5-b43c-e7fa-3e27-961006086580"), new DateTimeOffset(new DateTime(2024, 1, 1, 4, 59, 25, 126, DateTimeKind.Unspecified).AddTicks(2282), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 7, 19, 3, 20, 169, DateTimeKind.Unspecified).AddTicks(3678), new TimeSpan(0, 7, 0, 0, 0)), new Guid("fee56044-ba9d-cd8d-411f-2c0793b7df38") });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new Guid("430defcb-2d49-4e90-1bf1-51a934225bb3"), new DateTimeOffset(new DateTime(2023, 9, 30, 20, 53, 42, 341, DateTimeKind.Unspecified).AddTicks(9630), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 22, 23, 2, 13, 823, DateTimeKind.Unspecified).AddTicks(1747), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8f54f608-ca59-8ea8-37a9-2300d6a4402f") },
                    { new Guid("97581a8f-780f-3896-228c-51e74509eb80"), new Guid("ae048d35-c736-60ca-1a03-998417fd2e0d"), new DateTimeOffset(new DateTime(2024, 3, 21, 6, 30, 44, 749, DateTimeKind.Unspecified).AddTicks(2540), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 9, 21, 10, 45, 28, 370, DateTimeKind.Unspecified).AddTicks(4860), new TimeSpan(0, 7, 0, 0, 0)), new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab") },
                    { new Guid("a1a1a4b0-39b5-5462-ea94-f627f5d5eee0"), new Guid("9e3042aa-dfdd-c913-158a-7737585d1348"), new DateTimeOffset(new DateTime(2024, 6, 11, 11, 14, 15, 182, DateTimeKind.Unspecified).AddTicks(6748), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 10, 25, 2, 34, 20, 687, DateTimeKind.Unspecified).AddTicks(3670), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b45a905d-2d81-d8dc-7507-29b4372c2ad5") },
                    { new Guid("a89ed451-1505-13b4-c458-7a030c759f3f"), new Guid("9dd66981-6e49-6357-a37c-45fb1f8ba41e"), new DateTimeOffset(new DateTime(2023, 11, 18, 5, 40, 53, 647, DateTimeKind.Unspecified).AddTicks(2900), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 1, 16, 11, 7, 51, 202, DateTimeKind.Unspecified).AddTicks(72), new TimeSpan(0, 7, 0, 0, 0)), new Guid("234c0837-e07e-6fb5-dc08-5b8c438fffa9") },
                    { new Guid("a951f11b-2234-b35b-f424-5420ad1a71ce"), new Guid("fad5cead-8b14-7bef-2fa2-d996de815383"), new DateTimeOffset(new DateTime(2023, 10, 27, 17, 13, 22, 447, DateTimeKind.Unspecified).AddTicks(529), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 11, 4, 18, 50, 18, 549, DateTimeKind.Unspecified).AddTicks(8883), new TimeSpan(0, 7, 0, 0, 0)), new Guid("dd5a993a-834e-5c27-278e-b6b17d3ef20f") },
                    { new Guid("a99052b6-a953-00fb-7f94-ad45509c5449"), new Guid("b5a1a1a4-6239-ea54-94f6-27f5d5eee010"), new DateTimeOffset(new DateTime(2024, 5, 4, 20, 17, 7, 754, DateTimeKind.Unspecified).AddTicks(6689), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 6, 22, 46, 28, 759, DateTimeKind.Unspecified).AddTicks(6994), new TimeSpan(0, 7, 0, 0, 0)), new Guid("3aab7684-df2f-9588-6762-d36d43591ec6") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("b552bde3-659b-cead-d5fa-148bef7b2fa2"), new Guid("66fd29a8-66c5-6282-26cd-de04085c7b99"), new DateTimeOffset(new DateTime(2024, 2, 28, 21, 44, 10, 393, DateTimeKind.Unspecified).AddTicks(3011), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 26, 10, 26, 12, 840, DateTimeKind.Unspecified).AddTicks(1919), new TimeSpan(0, 7, 0, 0, 0)), new Guid("73f6340c-57cd-e9a9-8d76-2e3754d34cf0") },
                    { new Guid("c764ce19-c657-b651-c26d-f786a83ce646"), new Guid("eceb7e38-e994-eb98-0c68-69eca2e641f6"), new DateTimeOffset(new DateTime(2024, 4, 25, 3, 23, 47, 421, DateTimeKind.Unspecified).AddTicks(1131), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 13, 29, 30, 831, DateTimeKind.Unspecified).AddTicks(1634), new TimeSpan(0, 7, 0, 0, 0)), new Guid("fee56044-ba9d-cd8d-411f-2c0793b7df38") },
                    { new Guid("c962b121-02f9-08e5-cf11-8995c540a761"), new Guid("e64313d8-a4a2-a0e8-bd6c-2ba7d672050a"), new DateTimeOffset(new DateTime(2024, 5, 8, 10, 54, 3, 426, DateTimeKind.Unspecified).AddTicks(3982), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 23, 5, 49, 24, 614, DateTimeKind.Unspecified).AddTicks(1291), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d6df8b1d-8747-fa6f-5d3f-efbb55f9f750") },
                    { new Guid("d1e3e210-a5cc-8b3c-b036-22584367619b"), new Guid("b4b81d50-7f7d-7aa3-d24f-0319ce64c757"), new DateTimeOffset(new DateTime(2024, 2, 28, 13, 41, 55, 227, DateTimeKind.Unspecified).AddTicks(8112), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 2, 3, 55, 13, 903, DateTimeKind.Unspecified).AddTicks(4201), new TimeSpan(0, 7, 0, 0, 0)), new Guid("031a60ca-8499-fd17-2e0d-492832ad01cf") },
                    { new Guid("d382d930-5ce3-fc19-a249-af962f5f0ce2"), new Guid("0775d8dc-b429-2c37-2ad5-ffa8623d5cea"), new DateTimeOffset(new DateTime(2024, 5, 20, 20, 22, 32, 720, DateTimeKind.Unspecified).AddTicks(76), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 10, 9, 50, 6, 962, DateTimeKind.Unspecified).AddTicks(4221), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b45a905d-2d81-d8dc-7507-29b4372c2ad5") },
                    { new Guid("d40d725e-c366-8b4f-8503-1295b3ba6483"), new Guid("d718edc2-e562-0b40-b5d9-4a5089850768"), new DateTimeOffset(new DateTime(2023, 10, 3, 21, 56, 16, 211, DateTimeKind.Unspecified).AddTicks(3811), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 9, 17, 17, 24, 788, DateTimeKind.Unspecified).AddTicks(1445), new TimeSpan(0, 7, 0, 0, 0)), new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("d869bded-4313-a2e6-a4e8-a0bd6c2ba7d6"), new Guid("fad5cead-8b14-7bef-2fa2-d996de815383"), new DateTimeOffset(new DateTime(2024, 6, 22, 6, 37, 56, 551, DateTimeKind.Unspecified).AddTicks(2653), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 10, 16, 23, 28, 39, 361, DateTimeKind.Unspecified).AddTicks(2093), new TimeSpan(0, 7, 0, 0, 0)), new Guid("dca20a0a-9549-e4e1-78b1-99327e3ac5e0") },
                    { new Guid("de9b9d52-a435-67eb-d140-657d5050c5b9"), new Guid("b5a1a1a4-6239-ea54-94f6-27f5d5eee010"), new DateTimeOffset(new DateTime(2023, 12, 24, 6, 21, 1, 581, DateTimeKind.Unspecified).AddTicks(3406), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 9, 14, 22, 36, 11, 249, DateTimeKind.Unspecified).AddTicks(2429), new TimeSpan(0, 7, 0, 0, 0)), new Guid("51c657c7-c2b6-f76d-86a8-3ce64680ed81") },
                    { new Guid("decd2662-0804-7b5c-9997-690f47fb03e9"), new Guid("581a8ff7-0f97-9678-3822-8c51e74509eb"), new DateTimeOffset(new DateTime(2024, 5, 10, 0, 12, 42, 680, DateTimeKind.Unspecified).AddTicks(5679), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 15, 11, 26, 43, 639, DateTimeKind.Unspecified).AddTicks(6277), new TimeSpan(0, 7, 0, 0, 0)), new Guid("001bea9f-c9a6-1c20-80f0-9d1740b7b9b0") },
                    { new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d"), new Guid("581a8ff7-0f97-9678-3822-8c51e74509eb"), new DateTimeOffset(new DateTime(2023, 8, 4, 12, 45, 20, 479, DateTimeKind.Unspecified).AddTicks(7648), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 7, 5, 16, 25, 29, 80, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7fd8b31a-ccc5-e27d-8369-aaa4108d4d02") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[] { new Guid("e7e2d28b-02d4-3311-7a1c-f2134f0c6634"), new Guid("19aad1fe-5653-b064-e414-5d3dcc3f8970"), new DateTimeOffset(new DateTime(2023, 8, 23, 11, 38, 51, 145, DateTimeKind.Unspecified).AddTicks(3890), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 9, 7, 38, 14, 243, DateTimeKind.Unspecified).AddTicks(6447), new TimeSpan(0, 7, 0, 0, 0)), new Guid("cee903fb-653b-0877-add2-e94ecd2895df") });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("ec779c3b-0d7d-7e38-ebec-94e998eb0c68"), new Guid("ac0bab7a-1e5f-3f9b-2bcd-52f09e51d49e"), new DateTimeOffset(new DateTime(2023, 6, 28, 18, 37, 1, 481, DateTimeKind.Unspecified).AddTicks(8424), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 21, 3, 14, 3, 296, DateTimeKind.Unspecified).AddTicks(4134), new TimeSpan(0, 7, 0, 0, 0)), new Guid("89d5ab85-8ee1-80c5-c88b-39bc2da6528d") },
                    { new Guid("f24616bd-e6a9-6c93-6269-33ef855ab90a"), new Guid("ad0e2ced-74dc-76db-8864-6ffd2dc498c6"), new DateTimeOffset(new DateTime(2024, 5, 21, 11, 22, 34, 309, DateTimeKind.Unspecified).AddTicks(7629), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 6, 9, 16, 53, 22, 129, DateTimeKind.Unspecified).AddTicks(4165), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f052cd2b-519e-9ed4-a805-15b413c4587a") },
                    { new Guid("fa6f8747-3f5d-bbef-55f9-f750e56dce5a"), new Guid("ab85d464-89d5-8ee1-c580-c88b39bc2da6"), new DateTimeOffset(new DateTime(2024, 1, 2, 11, 50, 3, 917, DateTimeKind.Unspecified).AddTicks(3452), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 2, 20, 18, 40, 12, 600, DateTimeKind.Unspecified).AddTicks(9773), new TimeSpan(0, 7, 0, 0, 0)), new Guid("22389678-518c-45e7-09eb-80f68b20142b") },
                    { new Guid("ffd7dafa-8d35-ae04-36c7-ca601a039984"), new Guid("fadc6e80-d9f3-b790-2e46-a870e9198a1a"), new DateTimeOffset(new DateTime(2023, 10, 5, 19, 23, 15, 23, DateTimeKind.Unspecified).AddTicks(9238), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 6, 15, 8, 3, 7, 662, DateTimeKind.Unspecified).AddTicks(5466), new TimeSpan(0, 7, 0, 0, 0)), new Guid("5ce3d382-fc19-49a2-af96-2f5f0ce2aa42") }
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "ApplicationUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_IdentityId",
                table: "ApplicationUser",
                column: "IdentityId",
                unique: true,
                filter: "[IdentityId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "ApplicationUser",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_CourtGroupId",
                table: "Booking",
                column: "CourtGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_CourtYardId",
                table: "Booking",
                column: "CourtYardId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_DateId",
                table: "Booking",
                column: "DateId");

            migrationBuilder.CreateIndex(
                name: "IX_BookMark_CourtGroupId",
                table: "BookMark",
                column: "CourtGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_BookMark_UserId",
                table: "BookMark",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cost_CourtYardId",
                table: "Cost",
                column: "CourtYardId");

            migrationBuilder.CreateIndex(
                name: "IX_CourtGroup_ApplicationUserId",
                table: "CourtGroup",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CourtGroup_UserId",
                table: "CourtGroup",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CourtGroup_WalletId",
                table: "CourtGroup",
                column: "WalletId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourtGroup_WardId",
                table: "CourtGroup",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_CourtYard_CourtGroupId",
                table: "CourtYard",
                column: "CourtGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_DateCourtGroup_CourtGroupId",
                table: "DateCourtGroup",
                column: "CourtGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_DateCourtGroup_DateId",
                table: "DateCourtGroup",
                column: "DateId");

            migrationBuilder.CreateIndex(
                name: "IX_Deposit_UserId",
                table: "Deposit",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Deposit_WalletId",
                table: "Deposit",
                column: "WalletId");

            migrationBuilder.CreateIndex(
                name: "IX_District_CityId",
                table: "District",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_CourtGroupId",
                table: "Media",
                column: "CourtGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_UserId",
                table: "Media",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Slot_CourtYardId",
                table: "Slot",
                column: "CourtYardId");

            migrationBuilder.CreateIndex(
                name: "IX_SlotBooking_BookingId",
                table: "SlotBooking",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_SlotBooking_SlotId",
                table: "SlotBooking",
                column: "SlotId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_DepositId",
                table: "Transaction",
                column: "DepositId",
                unique: true,
                filter: "[DepositId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_UserId",
                table: "Transaction",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_WalletId",
                table: "Transaction",
                column: "WalletId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallet_UserId",
                table: "Wallet",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ward_DistrictId",
                table: "Ward",
                column: "DistrictId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BookMark");

            migrationBuilder.DropTable(
                name: "Cost");

            migrationBuilder.DropTable(
                name: "DateCourtGroup");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "SlotBooking");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Slot");

            migrationBuilder.DropTable(
                name: "Deposit");

            migrationBuilder.DropTable(
                name: "Date");

            migrationBuilder.DropTable(
                name: "CourtYard");

            migrationBuilder.DropTable(
                name: "CourtGroup");

            migrationBuilder.DropTable(
                name: "Wallet");

            migrationBuilder.DropTable(
                name: "Ward");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
