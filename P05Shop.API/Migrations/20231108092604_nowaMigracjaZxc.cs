using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class nowaMigracjaZxc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Films",
                newName: "Director");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "7", "Judyta Niedzielski", 947.599053739383m, new DateTime(2023, 3, 22, 4, 3, 32, 987, DateTimeKind.Local).AddTicks(3668), "id" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "0", "Weronika Jaros", 515.587012653512m, new DateTime(2023, 2, 17, 2, 35, 58, 334, DateTimeKind.Local).AddTicks(158), "eos" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "Olga Dudek", 987.740517770285m, new DateTime(2023, 9, 25, 14, 7, 51, 729, DateTimeKind.Local).AddTicks(4688), "ratione" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "9", "Rajnold Wójtowicz", 944.895053455557m, new DateTime(2023, 4, 15, 14, 30, 31, 365, DateTimeKind.Local).AddTicks(676), "unde" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "Lea Stanek", 419.498144894139m, new DateTime(2023, 4, 30, 3, 50, 8, 599, DateTimeKind.Local).AddTicks(6117), "aspernatur" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "4", "Anna Mroczek", 511.754347763376m, new DateTime(2023, 4, 3, 11, 38, 43, 149, DateTimeKind.Local).AddTicks(7685), "officiis" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "0", "Gerald Gajda", 772.394792875459m, new DateTime(2023, 4, 21, 2, 44, 58, 569, DateTimeKind.Local).AddTicks(4465), "aut" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "5", "Lilianna Kogut", 379.654358614075m, new DateTime(2023, 5, 17, 6, 39, 14, 805, DateTimeKind.Local).AddTicks(9523), "voluptatibus" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "Ireneusz Graczyk", 91.5445527781474m, new DateTime(2023, 9, 22, 17, 50, 38, 315, DateTimeKind.Local).AddTicks(6585), "aut" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "Nina Domagała", 153.856289495647m, new DateTime(2023, 1, 11, 17, 49, 17, 101, DateTimeKind.Local).AddTicks(7794), "ut" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "8", "Gilbert Michałek", 395.184917387173m, new DateTime(2023, 2, 22, 19, 38, 36, 855, DateTimeKind.Local).AddTicks(2218), "amet" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "Maurycy Grześkowiak", 910.073467519634m, new DateTime(2023, 10, 18, 16, 28, 50, 779, DateTimeKind.Local).AddTicks(3410), "dicta" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "4", "Tymoteusz Mazurek", 809.626763897774m, new DateTime(2023, 6, 14, 10, 45, 45, 610, DateTimeKind.Local).AddTicks(2424), "voluptas" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "Arnold Wolski", 49.1675051041727m, new DateTime(2023, 5, 29, 2, 34, 14, 907, DateTimeKind.Local).AddTicks(6693), "sed" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "Klara Tomaszewski", 984.268335762093m, new DateTime(2023, 8, 19, 7, 21, 54, 182, DateTimeKind.Local).AddTicks(395), "dolores" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "0", "Salomon Żak", 476.815506478686m, new DateTime(2023, 3, 19, 13, 43, 10, 911, DateTimeKind.Local).AddTicks(1572), "delectus" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "5", "Krzysztof Zalewski", 104.973396323143m, new DateTime(2023, 1, 9, 2, 6, 29, 41, DateTimeKind.Local).AddTicks(6382), "maxime" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "9", "Emil Biernat", 539.836693972739m, new DateTime(2023, 4, 12, 3, 14, 10, 920, DateTimeKind.Local).AddTicks(7982), "laudantium" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "Walentyna Barański", 646.066352349737m, new DateTime(2023, 10, 27, 18, 28, 34, 645, DateTimeKind.Local).AddTicks(7361), "neque" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "5", "Serafina Krukowski", 434.027346356785m, new DateTime(2022, 11, 13, 3, 26, 30, 288, DateTimeKind.Local).AddTicks(3523), "quo" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "Józefina Borowski", 526.597836321498m, new DateTime(2023, 4, 2, 4, 20, 0, 527, DateTimeKind.Local).AddTicks(297), "iure" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "9", "Oliwier Cygan", 205.234299416297m, new DateTime(2023, 5, 14, 12, 29, 12, 251, DateTimeKind.Local).AddTicks(8085), "ut" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "3", "Herman Miśkiewicz", 445.039092507697m, new DateTime(2023, 10, 26, 21, 27, 4, 291, DateTimeKind.Local).AddTicks(8285), "necessitatibus" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "1", "Gedeon Jędrzejczak", 656.56568970511m, new DateTime(2023, 8, 3, 2, 34, 21, 258, DateTimeKind.Local).AddTicks(8255), "rerum" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "Joanna Zalewski", 435.805003520476m, new DateTime(2023, 3, 30, 0, 20, 59, 820, DateTimeKind.Local).AddTicks(5110), "et" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "6", "Szymon Wilczyński", 278.68493513562m, new DateTime(2023, 3, 2, 3, 8, 8, 132, DateTimeKind.Local).AddTicks(6907), "quia" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "0", "Szymon Lipka", 290.113292811957m, new DateTime(2023, 6, 17, 12, 11, 8, 600, DateTimeKind.Local).AddTicks(5694), "minus" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "4", "Ernest Sobczak", 921.94751935636m, new DateTime(2023, 3, 6, 17, 45, 8, 462, DateTimeKind.Local).AddTicks(3532), "in" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "Laura Zaborowski", 568.042756632922m, new DateTime(2023, 2, 6, 6, 37, 37, 797, DateTimeKind.Local).AddTicks(9008), "eius" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "0", "August Malicki", 646.859666733006m, new DateTime(2023, 10, 11, 5, 44, 31, 723, DateTimeKind.Local).AddTicks(4921), "sed" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "4", "Koralia Kasprzyk", 384.478124646693m, new DateTime(2023, 7, 23, 2, 1, 43, 695, DateTimeKind.Local).AddTicks(4187), "quod" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "5", "Teodor Kołodziejczyk", 147.49753606296m, new DateTime(2023, 7, 12, 7, 16, 19, 493, DateTimeKind.Local).AddTicks(5508), "odio" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "Jan Grudzień", 453.685324946738m, new DateTime(2023, 5, 14, 1, 28, 55, 127, DateTimeKind.Local).AddTicks(3456), "distinctio" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "1", "Filemon Gutowski", 173.209604492043m, new DateTime(2023, 6, 22, 8, 47, 29, 159, DateTimeKind.Local).AddTicks(9288), "sint" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "8", "Nazariusz Dudzik", 812.055163684792m, new DateTime(2023, 2, 9, 15, 10, 15, 661, DateTimeKind.Local).AddTicks(6433), "est" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "Nestor Wojciechowski", 957.114653999039m, new DateTime(2023, 5, 17, 21, 28, 33, 522, DateTimeKind.Local).AddTicks(2882), "expedita" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "4", "Gloria Januszewski", 198.096402854704m, new DateTime(2023, 8, 22, 6, 26, 17, 368, DateTimeKind.Local).AddTicks(5487), "ullam" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "5", "Luiza Iwański", 516.931952754004m, new DateTime(2023, 4, 5, 19, 20, 1, 546, DateTimeKind.Local).AddTicks(9814), "neque" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "4", "Aleksander Marcinkowski", 831.879927467033m, new DateTime(2023, 9, 11, 20, 2, 43, 997, DateTimeKind.Local).AddTicks(577), "repellendus" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "1", "Józefina Pytel", 750.174635401077m, new DateTime(2023, 7, 19, 2, 33, 2, 702, DateTimeKind.Local).AddTicks(6764), "quam" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "5", "Anna Podgórski", 465.196982412691m, new DateTime(2023, 1, 8, 1, 31, 47, 383, DateTimeKind.Local).AddTicks(2041), "illum" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "7", "Aleksander Szcześniak", 655.146955157233m, new DateTime(2023, 10, 27, 9, 25, 50, 449, DateTimeKind.Local).AddTicks(602), "aut" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "8", "Ewelina Dróżdż", 627.662476505927m, new DateTime(2022, 12, 30, 1, 56, 26, 738, DateTimeKind.Local).AddTicks(6170), "sit" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "Wilhelmina Wróbel", 156.07502561392m, new DateTime(2023, 3, 31, 11, 28, 48, 279, DateTimeKind.Local).AddTicks(1013), "aut" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "9", "Damian Jóźwiak", 505.614110672201m, new DateTime(2023, 6, 23, 11, 0, 29, 894, DateTimeKind.Local).AddTicks(3103), "et" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "3", "Ignacy Rybicki", 423.39219746431m, new DateTime(2023, 10, 16, 22, 22, 52, 117, DateTimeKind.Local).AddTicks(6428), "nesciunt" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "Antoni Kaczmarczyk", 906.529322539237m, new DateTime(2023, 4, 28, 18, 9, 46, 699, DateTimeKind.Local).AddTicks(5828), "sed" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "3", "Pantaleon Krzyżanowski", 753.138725163945m, new DateTime(2023, 7, 14, 16, 3, 45, 861, DateTimeKind.Local).AddTicks(9365), "dignissimos" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "5", "Ksawery Florczak", 848.064586180292m, new DateTime(2023, 3, 18, 22, 27, 29, 288, DateTimeKind.Local).AddTicks(7094), "vitae" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Barcode", "Director", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "Hipolit Żurawski", 390.585544047219m, new DateTime(2023, 10, 22, 10, 11, 28, 561, DateTimeKind.Local).AddTicks(3743), "voluptas" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 22, 15, 46, 4, 272, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 2, 12, 24, 37, 908, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 21, 7, 18, 21, 181, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 22, 19, 31, 51, 541, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 22, 20, 50, 3, 270, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2023, 9, 6, 8, 37, 36, 380, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 7, 7, 49, 48, 790, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 30, 23, 4, 16, 478, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 20, 15, 3, 31, 935, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 12, 6, 45, 41, 396, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 10, 23, 59, 45, 538, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 19, 4, 31, 42, 312, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 19, 9, 45, 11, 231, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 12, 22, 57, 49, 719, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 3, 16, 3, 42, 749, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 21, 7, 58, 31, 216, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 30, 22, 20, 2, 794, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 28, 0, 2, 44, 153, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 21, 11, 20, 43, 732, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 14, 12, 51, 28, 214, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 23, 0, 14, 22, 403, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 2, 19, 41, 44, 672, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 4, 13, 31, 51, 991, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 6, 6, 8, 11, 220, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 22, 7, 37, 2, 784, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 17, 1, 13, 22, 907, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 5, 13, 16, 58, 903, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 30, 15, 42, 54, 15, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 24, 2, 13, 48, 8, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 18, 3, 9, 11, 224, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 14, 1, 35, 0, 421, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 24, 21, 22, 26, 360, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 1, 21, 51, 27, 611, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 28, 15, 7, 15, 450, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 16, 19, 59, 33, 444, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 5, 14, 33, 30, 978, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 3, 6, 6, 44, 373, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 13, 4, 8, 24, 693, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 9, 11, 46, 39, 252, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 27, 8, 32, 55, 876, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 9, 15, 38, 18, 24, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 1, 2, 49, 17, 454, DateTimeKind.Local).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 23, 18, 35, 31, 10, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 27, 16, 15, 56, 168, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 5, 12, 22, 19, 238, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 10, 17, 4, 30, 798, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 13, 12, 4, 5, 100, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 25, 8, 56, 22, 526, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 10, 13, 38, 26, 128, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 28, 2, 47, 25, 308, DateTimeKind.Local).AddTicks(3889));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Director",
                table: "Films",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "5", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 137.99403368076m, new DateTime(2022, 11, 16, 16, 46, 31, 131, DateTimeKind.Local).AddTicks(1805), "application Spring" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "5", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 159.983136395916m, new DateTime(2023, 11, 2, 2, 9, 1, 319, DateTimeKind.Local).AddTicks(9561), "Graphic Interface mobile" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 464.178101648194m, new DateTime(2023, 9, 14, 18, 26, 16, 129, DateTimeKind.Local).AddTicks(4107), "Washington green" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "4", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 103.373405277437m, new DateTime(2023, 7, 4, 9, 44, 47, 869, DateTimeKind.Local).AddTicks(9801), "Michigan aggregate" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 185.171873701351m, new DateTime(2023, 2, 21, 16, 43, 13, 725, DateTimeKind.Local).AddTicks(6134), "Tajikistan Human" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "6", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 636.874610120372m, new DateTime(2023, 4, 28, 5, 40, 48, 407, DateTimeKind.Local).AddTicks(4045), "fuchsia Silver" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "The Football Is Good For Training And Recreational Purposes", 836.622627579431m, new DateTime(2022, 11, 12, 23, 25, 27, 928, DateTimeKind.Local).AddTicks(5477), "complexity Buckinghamshire" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "9", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 732.049760168907m, new DateTime(2023, 10, 6, 8, 24, 35, 416, DateTimeKind.Local).AddTicks(8017), "Implemented Avon" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "3", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 823.990472946777m, new DateTime(2023, 9, 1, 8, 51, 39, 903, DateTimeKind.Local).AddTicks(666), "Fresh GB" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 348.630595346275m, new DateTime(2023, 8, 15, 8, 35, 39, 913, DateTimeKind.Local).AddTicks(4666), "salmon Belgium" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 284.641160375272m, new DateTime(2023, 4, 30, 1, 14, 1, 967, DateTimeKind.Local).AddTicks(6263), "index Intelligent Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", 988.516240780948m, new DateTime(2023, 1, 27, 16, 16, 11, 889, DateTimeKind.Local).AddTicks(5416), "programming Auto Loan Account" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "9", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 431.077884670383m, new DateTime(2023, 6, 4, 2, 1, 3, 702, DateTimeKind.Local).AddTicks(782), "Squares Small" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "8", "The Football Is Good For Training And Recreational Purposes", 108.542628838468m, new DateTime(2023, 5, 18, 14, 3, 28, 554, DateTimeKind.Local).AddTicks(629), "Outdoors Tasty Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 831.256413208906m, new DateTime(2023, 5, 22, 9, 45, 46, 935, DateTimeKind.Local).AddTicks(9368), "Credit Card Account Tasty" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "3", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 928.933693294848m, new DateTime(2023, 10, 28, 22, 15, 39, 880, DateTimeKind.Local).AddTicks(8949), "Small Granite Sausages monitoring" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "6", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 793.849044362478m, new DateTime(2023, 7, 24, 14, 36, 59, 99, DateTimeKind.Local).AddTicks(8437), "San Marino compressing" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "7", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 604.762392360606m, new DateTime(2023, 3, 15, 2, 58, 21, 381, DateTimeKind.Local).AddTicks(7882), "wireless compress" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "5", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 751.959149548299m, new DateTime(2023, 4, 25, 2, 28, 44, 360, DateTimeKind.Local).AddTicks(7723), "Iraqi Dinar USB" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "8", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 934.25062484073m, new DateTime(2022, 11, 24, 19, 12, 47, 167, DateTimeKind.Local).AddTicks(9804), "THX Metal" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 576.897283204783m, new DateTime(2023, 3, 6, 13, 11, 49, 35, DateTimeKind.Local).AddTicks(8408), "open-source Burgs" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "0", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 175.95459921004m, new DateTime(2023, 5, 10, 15, 5, 23, 981, DateTimeKind.Local).AddTicks(7844), "withdrawal Handmade Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "1", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 491.837397094275m, new DateTime(2023, 4, 17, 19, 1, 26, 512, DateTimeKind.Local).AddTicks(1404), "SCSI quantifying" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "9", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 211.867760635385m, new DateTime(2023, 9, 27, 17, 38, 15, 957, DateTimeKind.Local).AddTicks(5975), "deposit impactful" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "6", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 565.587814644253m, new DateTime(2023, 10, 2, 4, 48, 7, 249, DateTimeKind.Local).AddTicks(2561), "Brazilian Real Soft" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "0", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 336.597632218431m, new DateTime(2023, 2, 12, 13, 30, 34, 846, DateTimeKind.Local).AddTicks(6541), "Clothing redundant" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "3", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 319.707140555003m, new DateTime(2023, 2, 23, 5, 34, 6, 429, DateTimeKind.Local).AddTicks(9131), "synthesizing Factors" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "0", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 172.14635290352m, new DateTime(2023, 1, 23, 15, 11, 50, 185, DateTimeKind.Local).AddTicks(648), "world-class empower" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 516.982459043144m, new DateTime(2023, 6, 8, 16, 37, 9, 491, DateTimeKind.Local).AddTicks(3615), "Incredible Metal Ball Inverse" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "7", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 224.602481134516m, new DateTime(2023, 8, 20, 7, 26, 58, 156, DateTimeKind.Local).AddTicks(9916), "Realigned Gorgeous Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "8", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 44.4279083117973m, new DateTime(2023, 3, 8, 11, 32, 39, 873, DateTimeKind.Local).AddTicks(8641), "Incredible implement" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "0", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 684.413199580001m, new DateTime(2023, 8, 10, 20, 4, 39, 778, DateTimeKind.Local).AddTicks(8708), "Phased Program" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 148.837258994504m, new DateTime(2023, 7, 23, 6, 8, 38, 846, DateTimeKind.Local).AddTicks(7821), "open-source Investor" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 341.399866206292m, new DateTime(2023, 11, 8, 6, 50, 26, 314, DateTimeKind.Local).AddTicks(3370), "Administrator haptic" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "1", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 308.441545524374m, new DateTime(2023, 1, 13, 21, 8, 24, 596, DateTimeKind.Local).AddTicks(7213), "service-desk Practical Soft Chicken" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "0", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 22.6627996166529m, new DateTime(2023, 1, 11, 18, 37, 14, 93, DateTimeKind.Local).AddTicks(8775), "Credit Card Account Licensed" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "3", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 86.3958210844527m, new DateTime(2023, 3, 27, 10, 52, 20, 622, DateTimeKind.Local).AddTicks(3511), "COM withdrawal" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "The Football Is Good For Training And Recreational Purposes", 319.255191839419m, new DateTime(2023, 2, 8, 9, 20, 1, 251, DateTimeKind.Local).AddTicks(333), "Concrete Ergonomic Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 176.530922628255m, new DateTime(2023, 6, 22, 3, 56, 55, 755, DateTimeKind.Local).AddTicks(9759), "Handmade Cotton Salad Port" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "0", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 208.619120477056m, new DateTime(2023, 3, 14, 15, 17, 16, 810, DateTimeKind.Local).AddTicks(1813), "Home Loan Account Heard Island and McDonald Islands" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "9", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 906.529322539237m, new DateTime(2023, 4, 28, 18, 6, 8, 940, DateTimeKind.Local).AddTicks(1050), "paradigms Alaska" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "1", "The Football Is Good For Training And Recreational Purposes", 83.1003850372976m, new DateTime(2023, 4, 16, 22, 42, 47, 738, DateTimeKind.Local).AddTicks(5967), "Knoll blockchains" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 996.181928761854m, new DateTime(2023, 10, 16, 15, 29, 28, 323, DateTimeKind.Local).AddTicks(5449), "black panel" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "6", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 991.162918264122m, new DateTime(2023, 10, 4, 3, 7, 8, 389, DateTimeKind.Local).AddTicks(6962), "Sports & Music SSL" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "8", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 859.376315591566m, new DateTime(2022, 12, 5, 21, 36, 19, 942, DateTimeKind.Local).AddTicks(8952), "drive Identity" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "6", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 893.991202085275m, new DateTime(2023, 1, 30, 23, 19, 54, 937, DateTimeKind.Local).AddTicks(6797), "strategic deposit" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 698.066996843585m, new DateTime(2023, 3, 11, 5, 48, 2, 974, DateTimeKind.Local).AddTicks(4042), "JBOD Pre-emptive" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "0", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 75.8424568394397m, new DateTime(2023, 4, 28, 6, 7, 36, 968, DateTimeKind.Local).AddTicks(8050), "bandwidth-monitored Wyoming" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "6", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 314.284327693416m, new DateTime(2023, 11, 6, 21, 0, 19, 242, DateTimeKind.Local).AddTicks(6217), "indexing Investor" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "8", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 361.59689627569m, new DateTime(2023, 5, 1, 16, 25, 51, 553, DateTimeKind.Local).AddTicks(5441), "Metal Svalbard & Jan Mayen Islands" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 22, 15, 42, 26, 513, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 2, 12, 21, 0, 149, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 21, 7, 14, 43, 422, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 22, 19, 28, 13, 781, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 22, 20, 46, 25, 511, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2023, 9, 6, 8, 33, 58, 620, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 7, 7, 46, 11, 30, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 30, 23, 0, 38, 719, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 20, 14, 59, 54, 175, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 12, 6, 42, 3, 637, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 10, 23, 56, 7, 778, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 19, 4, 28, 4, 552, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 19, 9, 41, 33, 472, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 12, 22, 54, 11, 960, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 3, 16, 0, 4, 989, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 21, 7, 54, 53, 456, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 30, 22, 16, 25, 34, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 27, 23, 59, 6, 393, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 21, 11, 17, 5, 973, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 14, 12, 47, 50, 455, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 23, 0, 10, 44, 643, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 2, 19, 38, 6, 913, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 4, 13, 28, 14, 231, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 6, 6, 4, 33, 461, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 22, 7, 33, 25, 24, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 17, 1, 9, 45, 148, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 5, 13, 13, 21, 144, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 30, 15, 39, 16, 256, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 24, 2, 10, 10, 249, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 18, 3, 5, 33, 465, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 14, 1, 31, 22, 662, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 24, 21, 18, 48, 601, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 1, 21, 47, 49, 851, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 28, 15, 3, 37, 690, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 16, 19, 55, 55, 685, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 5, 14, 29, 53, 218, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 3, 6, 3, 6, 614, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 13, 4, 4, 46, 933, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 9, 11, 43, 1, 493, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 27, 8, 29, 18, 116, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 9, 15, 34, 40, 265, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 1, 2, 45, 39, 694, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 23, 18, 31, 53, 250, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 27, 16, 12, 18, 409, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 5, 12, 18, 41, 479, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 10, 17, 0, 53, 38, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 13, 12, 0, 27, 341, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 25, 8, 52, 44, 767, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 10, 13, 34, 48, 369, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 28, 2, 43, 47, 548, DateTimeKind.Local).AddTicks(9590));
        }
    }
}
