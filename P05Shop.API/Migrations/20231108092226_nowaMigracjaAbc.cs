using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class nowaMigracjaAbc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "5", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 137.99403368076m, new DateTime(2022, 11, 16, 16, 46, 31, 131, DateTimeKind.Local).AddTicks(1805), "application Spring" },
                    { 2, "5", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 159.983136395916m, new DateTime(2023, 11, 2, 2, 9, 1, 319, DateTimeKind.Local).AddTicks(9561), "Graphic Interface mobile" },
                    { 3, "4", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 464.178101648194m, new DateTime(2023, 9, 14, 18, 26, 16, 129, DateTimeKind.Local).AddTicks(4107), "Washington green" },
                    { 4, "4", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 103.373405277437m, new DateTime(2023, 7, 4, 9, 44, 47, 869, DateTimeKind.Local).AddTicks(9801), "Michigan aggregate" },
                    { 5, "0", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 185.171873701351m, new DateTime(2023, 2, 21, 16, 43, 13, 725, DateTimeKind.Local).AddTicks(6134), "Tajikistan Human" },
                    { 6, "6", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 636.874610120372m, new DateTime(2023, 4, 28, 5, 40, 48, 407, DateTimeKind.Local).AddTicks(4045), "fuchsia Silver" },
                    { 7, "2", "The Football Is Good For Training And Recreational Purposes", 836.622627579431m, new DateTime(2022, 11, 12, 23, 25, 27, 928, DateTimeKind.Local).AddTicks(5477), "complexity Buckinghamshire" },
                    { 8, "9", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 732.049760168907m, new DateTime(2023, 10, 6, 8, 24, 35, 416, DateTimeKind.Local).AddTicks(8017), "Implemented Avon" },
                    { 9, "3", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 823.990472946777m, new DateTime(2023, 9, 1, 8, 51, 39, 903, DateTimeKind.Local).AddTicks(666), "Fresh GB" },
                    { 10, "1", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 348.630595346275m, new DateTime(2023, 8, 15, 8, 35, 39, 913, DateTimeKind.Local).AddTicks(4666), "salmon Belgium" },
                    { 11, "2", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 284.641160375272m, new DateTime(2023, 4, 30, 1, 14, 1, 967, DateTimeKind.Local).AddTicks(6263), "index Intelligent Granite Gloves" },
                    { 12, "5", "The Football Is Good For Training And Recreational Purposes", 988.516240780948m, new DateTime(2023, 1, 27, 16, 16, 11, 889, DateTimeKind.Local).AddTicks(5416), "programming Auto Loan Account" },
                    { 13, "9", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 431.077884670383m, new DateTime(2023, 6, 4, 2, 1, 3, 702, DateTimeKind.Local).AddTicks(782), "Squares Small" },
                    { 14, "8", "The Football Is Good For Training And Recreational Purposes", 108.542628838468m, new DateTime(2023, 5, 18, 14, 3, 28, 554, DateTimeKind.Local).AddTicks(629), "Outdoors Tasty Concrete Chips" },
                    { 15, "0", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 831.256413208906m, new DateTime(2023, 5, 22, 9, 45, 46, 935, DateTimeKind.Local).AddTicks(9368), "Credit Card Account Tasty" },
                    { 16, "3", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 928.933693294848m, new DateTime(2023, 10, 28, 22, 15, 39, 880, DateTimeKind.Local).AddTicks(8949), "Small Granite Sausages monitoring" },
                    { 17, "6", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 793.849044362478m, new DateTime(2023, 7, 24, 14, 36, 59, 99, DateTimeKind.Local).AddTicks(8437), "San Marino compressing" },
                    { 18, "7", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 604.762392360606m, new DateTime(2023, 3, 15, 2, 58, 21, 381, DateTimeKind.Local).AddTicks(7882), "wireless compress" },
                    { 19, "5", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 751.959149548299m, new DateTime(2023, 4, 25, 2, 28, 44, 360, DateTimeKind.Local).AddTicks(7723), "Iraqi Dinar USB" },
                    { 20, "8", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 934.25062484073m, new DateTime(2022, 11, 24, 19, 12, 47, 167, DateTimeKind.Local).AddTicks(9804), "THX Metal" },
                    { 21, "3", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 576.897283204783m, new DateTime(2023, 3, 6, 13, 11, 49, 35, DateTimeKind.Local).AddTicks(8408), "open-source Burgs" },
                    { 22, "0", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 175.95459921004m, new DateTime(2023, 5, 10, 15, 5, 23, 981, DateTimeKind.Local).AddTicks(7844), "withdrawal Handmade Frozen Shoes" },
                    { 23, "1", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 491.837397094275m, new DateTime(2023, 4, 17, 19, 1, 26, 512, DateTimeKind.Local).AddTicks(1404), "SCSI quantifying" },
                    { 24, "9", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 211.867760635385m, new DateTime(2023, 9, 27, 17, 38, 15, 957, DateTimeKind.Local).AddTicks(5975), "deposit impactful" },
                    { 25, "6", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 565.587814644253m, new DateTime(2023, 10, 2, 4, 48, 7, 249, DateTimeKind.Local).AddTicks(2561), "Brazilian Real Soft" },
                    { 26, "0", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 336.597632218431m, new DateTime(2023, 2, 12, 13, 30, 34, 846, DateTimeKind.Local).AddTicks(6541), "Clothing redundant" },
                    { 27, "3", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 319.707140555003m, new DateTime(2023, 2, 23, 5, 34, 6, 429, DateTimeKind.Local).AddTicks(9131), "synthesizing Factors" },
                    { 28, "0", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 172.14635290352m, new DateTime(2023, 1, 23, 15, 11, 50, 185, DateTimeKind.Local).AddTicks(648), "world-class empower" },
                    { 29, "6", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 516.982459043144m, new DateTime(2023, 6, 8, 16, 37, 9, 491, DateTimeKind.Local).AddTicks(3615), "Incredible Metal Ball Inverse" },
                    { 30, "7", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 224.602481134516m, new DateTime(2023, 8, 20, 7, 26, 58, 156, DateTimeKind.Local).AddTicks(9916), "Realigned Gorgeous Wooden Fish" },
                    { 31, "8", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 44.4279083117973m, new DateTime(2023, 3, 8, 11, 32, 39, 873, DateTimeKind.Local).AddTicks(8641), "Incredible implement" },
                    { 32, "0", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 684.413199580001m, new DateTime(2023, 8, 10, 20, 4, 39, 778, DateTimeKind.Local).AddTicks(8708), "Phased Program" },
                    { 33, "2", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 148.837258994504m, new DateTime(2023, 7, 23, 6, 8, 38, 846, DateTimeKind.Local).AddTicks(7821), "open-source Investor" },
                    { 34, "2", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 341.399866206292m, new DateTime(2023, 11, 8, 6, 50, 26, 314, DateTimeKind.Local).AddTicks(3370), "Administrator haptic" },
                    { 35, "1", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 308.441545524374m, new DateTime(2023, 1, 13, 21, 8, 24, 596, DateTimeKind.Local).AddTicks(7213), "service-desk Practical Soft Chicken" },
                    { 36, "0", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 22.6627996166529m, new DateTime(2023, 1, 11, 18, 37, 14, 93, DateTimeKind.Local).AddTicks(8775), "Credit Card Account Licensed" },
                    { 37, "3", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 86.3958210844527m, new DateTime(2023, 3, 27, 10, 52, 20, 622, DateTimeKind.Local).AddTicks(3511), "COM withdrawal" },
                    { 38, "2", "The Football Is Good For Training And Recreational Purposes", 319.255191839419m, new DateTime(2023, 2, 8, 9, 20, 1, 251, DateTimeKind.Local).AddTicks(333), "Concrete Ergonomic Soft Gloves" },
                    { 39, "2", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 176.530922628255m, new DateTime(2023, 6, 22, 3, 56, 55, 755, DateTimeKind.Local).AddTicks(9759), "Handmade Cotton Salad Port" },
                    { 40, "0", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 208.619120477056m, new DateTime(2023, 3, 14, 15, 17, 16, 810, DateTimeKind.Local).AddTicks(1813), "Home Loan Account Heard Island and McDonald Islands" },
                    { 41, "9", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 906.529322539237m, new DateTime(2023, 4, 28, 18, 6, 8, 940, DateTimeKind.Local).AddTicks(1050), "paradigms Alaska" },
                    { 42, "1", "The Football Is Good For Training And Recreational Purposes", 83.1003850372976m, new DateTime(2023, 4, 16, 22, 42, 47, 738, DateTimeKind.Local).AddTicks(5967), "Knoll blockchains" },
                    { 43, "2", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 996.181928761854m, new DateTime(2023, 10, 16, 15, 29, 28, 323, DateTimeKind.Local).AddTicks(5449), "black panel" },
                    { 44, "6", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 991.162918264122m, new DateTime(2023, 10, 4, 3, 7, 8, 389, DateTimeKind.Local).AddTicks(6962), "Sports & Music SSL" },
                    { 45, "8", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 859.376315591566m, new DateTime(2022, 12, 5, 21, 36, 19, 942, DateTimeKind.Local).AddTicks(8952), "drive Identity" },
                    { 46, "6", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 893.991202085275m, new DateTime(2023, 1, 30, 23, 19, 54, 937, DateTimeKind.Local).AddTicks(6797), "strategic deposit" },
                    { 47, "9", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 698.066996843585m, new DateTime(2023, 3, 11, 5, 48, 2, 974, DateTimeKind.Local).AddTicks(4042), "JBOD Pre-emptive" },
                    { 48, "0", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 75.8424568394397m, new DateTime(2023, 4, 28, 6, 7, 36, 968, DateTimeKind.Local).AddTicks(8050), "bandwidth-monitored Wyoming" },
                    { 49, "6", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 314.284327693416m, new DateTime(2023, 11, 6, 21, 0, 19, 242, DateTimeKind.Local).AddTicks(6217), "indexing Investor" },
                    { 50, "8", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 361.59689627569m, new DateTime(2023, 5, 1, 16, 25, 51, 553, DateTimeKind.Local).AddTicks(5441), "Metal Svalbard & Jan Mayen Islands" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "3", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 712.021981759007m, new DateTime(2023, 3, 22, 15, 42, 26, 513, DateTimeKind.Local).AddTicks(874), "Gorgeous Wooden Chair" },
                    { 2, "7", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 839.010165513032m, new DateTime(2023, 10, 2, 12, 21, 0, 149, DateTimeKind.Local).AddTicks(2990), "Handcrafted Steel Shoes" },
                    { 3, "1", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 198.083692779804m, new DateTime(2023, 1, 21, 7, 14, 43, 422, DateTimeKind.Local).AddTicks(4992), "Handmade Granite Table" },
                    { 4, "1", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 160.643399712929m, new DateTime(2023, 8, 22, 19, 28, 13, 781, DateTimeKind.Local).AddTicks(6363), "Handmade Wooden Table" },
                    { 5, "0", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 359.887736376788m, new DateTime(2023, 2, 22, 20, 46, 25, 511, DateTimeKind.Local).AddTicks(2536), "Intelligent Steel Salad" },
                    { 6, "8", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 181.360829243139m, new DateTime(2023, 9, 6, 8, 33, 58, 620, DateTimeKind.Local).AddTicks(9846), "Handcrafted Rubber Bike" },
                    { 7, "1", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 938.297015022625m, new DateTime(2023, 4, 7, 7, 46, 11, 30, DateTimeKind.Local).AddTicks(9892), "Unbranded Steel Car" },
                    { 8, "3", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 223.882037785315m, new DateTime(2023, 6, 30, 23, 0, 38, 719, DateTimeKind.Local).AddTicks(2109), "Tasty Plastic Cheese" },
                    { 9, "0", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 249.172251003875m, new DateTime(2022, 12, 20, 14, 59, 54, 175, DateTimeKind.Local).AddTicks(9572), "Handcrafted Fresh Sausages" },
                    { 10, "1", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 905.322284099796m, new DateTime(2023, 10, 12, 6, 42, 3, 637, DateTimeKind.Local).AddTicks(2220), "Fantastic Frozen Gloves" },
                    { 11, "3", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 842.480734222792m, new DateTime(2023, 8, 10, 23, 56, 7, 778, DateTimeKind.Local).AddTicks(9377), "Generic Steel Ball" },
                    { 12, "1", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 928.928430071533m, new DateTime(2023, 8, 19, 4, 28, 4, 552, DateTimeKind.Local).AddTicks(8103), "Ergonomic Rubber Car" },
                    { 13, "6", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 706.948686653259m, new DateTime(2023, 7, 19, 9, 41, 33, 472, DateTimeKind.Local).AddTicks(4077), "Generic Steel Pizza" },
                    { 14, "3", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 306.262494314584m, new DateTime(2023, 1, 12, 22, 54, 11, 960, DateTimeKind.Local).AddTicks(383), "Small Metal Sausages" },
                    { 15, "2", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 378.222576259273m, new DateTime(2023, 8, 3, 16, 0, 4, 989, DateTimeKind.Local).AddTicks(7523), "Fantastic Soft Pants" },
                    { 16, "6", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 461.718092748764m, new DateTime(2022, 11, 21, 7, 54, 53, 456, DateTimeKind.Local).AddTicks(6371), "Gorgeous Frozen Towels" },
                    { 17, "7", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 126.128098112125m, new DateTime(2023, 6, 30, 22, 16, 25, 34, DateTimeKind.Local).AddTicks(5849), "Tasty Steel Cheese" },
                    { 18, "8", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 530.970371435383m, new DateTime(2023, 6, 27, 23, 59, 6, 393, DateTimeKind.Local).AddTicks(8895), "Gorgeous Granite Cheese" },
                    { 19, "9", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 913.003066283186m, new DateTime(2022, 11, 21, 11, 17, 5, 973, DateTimeKind.Local).AddTicks(2260), "Sleek Rubber Chicken" },
                    { 20, "5", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 940.814879371698m, new DateTime(2023, 4, 14, 12, 47, 50, 455, DateTimeKind.Local).AddTicks(5498), "Intelligent Wooden Salad" },
                    { 21, "4", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 479.41424090062m, new DateTime(2023, 6, 23, 0, 10, 44, 643, DateTimeKind.Local).AddTicks(7870), "Handcrafted Wooden Sausages" },
                    { 22, "7", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 320.499838554068m, new DateTime(2023, 2, 2, 19, 38, 6, 913, DateTimeKind.Local).AddTicks(5582), "Sleek Granite Car" },
                    { 23, "6", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 478.915239043029m, new DateTime(2023, 6, 4, 13, 28, 14, 231, DateTimeKind.Local).AddTicks(9138), "Small Wooden Car" },
                    { 24, "2", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 910.785444308438m, new DateTime(2023, 7, 6, 6, 4, 33, 461, DateTimeKind.Local).AddTicks(2301), "Sleek Steel Shirt" },
                    { 25, "3", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 802.238750720974m, new DateTime(2023, 7, 22, 7, 33, 25, 24, DateTimeKind.Local).AddTicks(8743), "Incredible Frozen Mouse" },
                    { 26, "7", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 150.818741621831m, new DateTime(2023, 5, 17, 1, 9, 45, 148, DateTimeKind.Local).AddTicks(4034), "Incredible Wooden Chair" },
                    { 27, "5", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 721.773541800572m, new DateTime(2023, 2, 5, 13, 13, 21, 144, DateTimeKind.Local).AddTicks(5601), "Gorgeous Plastic Chips" },
                    { 28, "5", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 688.245783060904m, new DateTime(2023, 4, 30, 15, 39, 16, 256, DateTimeKind.Local).AddTicks(817), "Incredible Fresh Bacon" },
                    { 29, "7", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 553.558320945389m, new DateTime(2023, 7, 24, 2, 10, 10, 249, DateTimeKind.Local).AddTicks(2117), "Incredible Soft Computer" },
                    { 30, "4", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 663.536718269594m, new DateTime(2022, 11, 18, 3, 5, 33, 465, DateTimeKind.Local).AddTicks(3897), "Handcrafted Rubber Bike" },
                    { 31, "2", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 922.479030014704m, new DateTime(2023, 10, 14, 1, 31, 22, 662, DateTimeKind.Local).AddTicks(2046), "Handcrafted Concrete Tuna" },
                    { 32, "3", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 255.49067058018m, new DateTime(2023, 7, 24, 21, 18, 48, 601, DateTimeKind.Local).AddTicks(2519), "Gorgeous Wooden Fish" },
                    { 33, "7", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 955.272407213818m, new DateTime(2023, 5, 1, 21, 47, 49, 851, DateTimeKind.Local).AddTicks(8405), "Handcrafted Frozen Keyboard" },
                    { 34, "8", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 151.982358236323m, new DateTime(2022, 11, 28, 15, 3, 37, 690, DateTimeKind.Local).AddTicks(5996), "Intelligent Plastic Chair" },
                    { 35, "9", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 434.299358334532m, new DateTime(2022, 12, 16, 19, 55, 55, 685, DateTimeKind.Local).AddTicks(5668), "Unbranded Wooden Pizza" },
                    { 36, "4", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 57.7988712865854m, new DateTime(2023, 1, 5, 14, 29, 53, 218, DateTimeKind.Local).AddTicks(7459), "Gorgeous Rubber Bacon" },
                    { 37, "7", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 883.980300599234m, new DateTime(2023, 4, 3, 6, 3, 6, 614, DateTimeKind.Local).AddTicks(5616), "Handcrafted Rubber Shirt" },
                    { 38, "7", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 822.452619476455m, new DateTime(2023, 1, 13, 4, 4, 46, 933, DateTimeKind.Local).AddTicks(6985), "Rustic Granite Shoes" },
                    { 39, "7", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 22.2432652671092m, new DateTime(2023, 4, 9, 11, 43, 1, 493, DateTimeKind.Local).AddTicks(2173), "Sleek Granite Chair" },
                    { 40, "2", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 158.364214679396m, new DateTime(2023, 6, 27, 8, 29, 18, 116, DateTimeKind.Local).AddTicks(9937), "Incredible Rubber Soap" },
                    { 41, "7", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 533.504530191656m, new DateTime(2023, 8, 9, 15, 34, 40, 265, DateTimeKind.Local).AddTicks(1981), "Awesome Soft Fish" },
                    { 42, "8", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 265.709933652407m, new DateTime(2023, 8, 1, 2, 45, 39, 694, DateTimeKind.Local).AddTicks(7288), "Intelligent Cotton Tuna" },
                    { 43, "2", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 294.402654204239m, new DateTime(2023, 1, 23, 18, 31, 53, 250, DateTimeKind.Local).AddTicks(6266), "Refined Soft Bike" },
                    { 44, "5", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 741.648888164036m, new DateTime(2023, 1, 27, 16, 12, 18, 409, DateTimeKind.Local).AddTicks(3890), "Handmade Cotton Bacon" },
                    { 45, "5", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 825.239833488706m, new DateTime(2023, 1, 5, 12, 18, 41, 479, DateTimeKind.Local).AddTicks(5404), "Small Soft Tuna" },
                    { 46, "1", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 305.894089151124m, new DateTime(2023, 5, 10, 17, 0, 53, 38, DateTimeKind.Local).AddTicks(8935), "Practical Frozen Computer" },
                    { 47, "4", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 778.911179241683m, new DateTime(2023, 1, 13, 12, 0, 27, 341, DateTimeKind.Local).AddTicks(2075), "Rustic Wooden Mouse" },
                    { 48, "2", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 318.709401070936m, new DateTime(2023, 2, 25, 8, 52, 44, 767, DateTimeKind.Local).AddTicks(1708), "Handcrafted Metal Mouse" },
                    { 49, "6", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 463.195345650052m, new DateTime(2023, 4, 10, 13, 34, 48, 369, DateTimeKind.Local).AddTicks(913), "Handcrafted Rubber Salad" },
                    { 50, "6", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 717.609017980569m, new DateTime(2023, 8, 28, 2, 43, 47, 548, DateTimeKind.Local).AddTicks(9590), "Incredible Plastic Shoes" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
