using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EuropeanContracts.Infrastructure.Migrations
{
    public partial class NewOfferAddedChanegeDecimalTypeAndActionDesriptionChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ProductPrice",
                table: "Offers",
                type: "decimal(18,2)",
                nullable: false,
                comment: "Product price in EURO",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)",
                oldComment: "Product price in EURO");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fbe9f01-467b-484a-ad66-88a36327f3ad", "AQAAAAEAACcQAAAAEDrbPIBvqJx8+9AU/lQB1WSRaPVALu/Wuc9xSURhg88p7pWDE4CZmqWZgAXPI+vOZA==", "99a4a6a2-b852-43b4-89c3-f246588d8d4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a82251e-76f5-4544-9a14-dff2ddaa73cf", "AQAAAAEAACcQAAAAEHQCJaWPgpzcPZUHqy4TxYAfv85Xi7P1DqBrwi6lo5mvyZMOKt5ueZFKKlLGoKRIlQ==", "11a9dc08-35fa-4afd-a849-4046c17eb862" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d33qwej9-02ap-11mnl-hflp-lpszavr2s588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "633acc0d-2caa-4134-bc90-e8015621e229", "AQAAAAEAACcQAAAAEA/W5jyESm+lA/ONCyV1aggm3TfPIvsfqWV4tLHOvDxZ1aMfqp94vlnjB55slQaObA==", "e5dc1041-cf6f-40f9-8638-d2b2a813f0f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f895a5d1-f24e-4186-a79d-5a7dea10d4ef", "AQAAAAEAACcQAAAAEIp527d5Nqf4R5JwxUWkUqDJsvPpGlBi1QPVhVJIXwu+8m+vdI3btfWOQT9ZOf9Tqw==", "b34c41f3-7eed-4fef-be43-7aaa2ef80e2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e71656d7-0c1e-4843-9174-6876f3802711", "AQAAAAEAACcQAAAAEFlcs8l0S90D5kFu/eL3udM2I7PfgS+xAql7XnxhJcWZ13czRGLkRO1sy3vMvdXbnw==", "56ddbc30-2d29-44d6-8c35-d4a0f9df222c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbe20167-7524-40b0-ac75-c0631e422a35", "AQAAAAEAACcQAAAAEBrutkKLtRDoPCEeEdaEuUshL1jqQKTRNJhIz/OQdAMXywWslvKA89KxFvG5Sx8rWA==", "e0945df1-92d5-4d9c-b2e8-e48c7ffd02b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k3fcll56-l458-6871-q3r9-2ve3w9a54s87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e01ac4ad-cc72-4814-84dd-f1f225d3c9cc", "AQAAAAEAACcQAAAAEFNZVNatHnmHMKFh0HnmJX5A9dIEI165ChOv8sZwdZZ7FQOJ1KD35nvE8Hp+HFOCog==", "fcd25a19-f1f5-473b-8bfb-b0565f5094af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "129784b4-29ff-4ebe-9eda-e99ed2f65ba0", "AQAAAAEAACcQAAAAEL+V6GmloDztwLh2HI/65VfXXq/SMPXu/vdETID7AaPDNQ2/vT+1g1Hv9YX+2zXIsA==", "882aa5fa-0447-40a9-993f-dd7480b62777" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProductDescription", "PublicationDay" },
                values: new object[] { "Тhe produce is fresh from animals raised on certified farms", new DateTime(2024, 4, 10, 21, 38, 29, 168, DateTimeKind.Local).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductDescription", "PublicationDay" },
                values: new object[] { "Baled and suitable for recycling", new DateTime(2024, 4, 10, 21, 38, 29, 168, DateTimeKind.Local).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductDescription", "PublicationDay" },
                values: new object[] { "Manufactured in 2020 with a safety certificate", new DateTime(2024, 4, 10, 21, 38, 29, 168, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "ActionTypeId", "AddressOfDestination", "CountryOfDestination", "DeliveryTime", "IsDelivered", "IsTemperatureControlNeeded", "LoadingAddress", "LoadingCountry", "ProductDescription", "ProductImageURL", "ProductName", "ProductPrice", "ProductQuantity", "PublicationDay", "RecipientId", "SupplierId", "TransporterId" },
                values: new object[] { 4, 1, null, null, null, false, true, "Debrecen, str. Biczokert 52", "Hungary", "Оwn production with a high quality certificate", "/Images/ProductImages/chocolateProducts.png", "Chocolate Products", 36745.55m, 17450, new DateTime(2024, 4, 10, 21, 38, 29, 168, DateTimeKind.Local).AddTicks(2763), null, 1, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "ProductPrice",
                table: "Offers",
                type: "decimal(18,6)",
                nullable: false,
                comment: "Product price in EURO",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldComment: "Product price in EURO");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d27e5978-5023-4cef-af73-bd5733fdb9a5", "AQAAAAEAACcQAAAAEE8uMU8EXRMYhtlkuk6BVnuko0uYa2fSuc0ykOm9BTM9UWnUjfq3CumR9wb4HTVA2A==", "48947098-e203-4daf-9151-59d8f530b9e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc22d70d-3daa-4e8e-966e-248653d461c5", "AQAAAAEAACcQAAAAEFicr3LuZzqIRcpQZfGaAvJreNPuVBMpqtuZ0JTitB2ffybGE+4j44/m0PVhOSc6cQ==", "a2cc5a66-9606-4a2e-bcc9-2a2cd7367e03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d33qwej9-02ap-11mnl-hflp-lpszavr2s588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d33b2dcf-601e-416d-8046-3405f19d182f", "AQAAAAEAACcQAAAAELmwzbS90WHdf7Z5xH+4/b89G3X0/v1dTMh7bWHYSXxZK4Lt4ubd8Oape+Eop6SCxg==", "d49b4efd-fa54-4227-87e8-be5007eaa2db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca58610a-7079-43b3-a5ff-cdc5c21ddd28", "AQAAAAEAACcQAAAAEIS0YFfMNCrxPcG3LTacwHtCbLVeQiNxUZmAaPTSfX/MzyBgx019ZXckdgd/xCAYLg==", "2cd2e9cd-d0f4-4664-823e-a721e33fcd19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2a480f4-ab15-4bb4-88c0-a7c92a1bcaec", "AQAAAAEAACcQAAAAEBRJWWcncfhSonGfCuYFrGE6uTgBkPKXEbX4wVz7heAUE8uM5PuYv6csn5cIcoOClQ==", "f49cc834-8f6e-41ea-bf91-7479b2bb3fe7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a22581a-8245-42c7-b1d2-948841683132", "AQAAAAEAACcQAAAAEFHdzAYtcC1YmWsgzuLN/ggFMDhnTasBZ2TW86BpJsodkDZmnjyOKvU6wIB7tBmWPg==", "918f6df9-a9b2-45b2-b799-a207973e834a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k3fcll56-l458-6871-q3r9-2ve3w9a54s87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7fb33c6-151e-4856-919f-397cbf8fb5b6", "AQAAAAEAACcQAAAAEJu5bLrL2hVvX2aKboa1ccalbkreykfNi8TfYoIJ283ZRF8xlIKAQq+lFgeVx0RYqg==", "c6bdb3c9-a11a-4e3e-9612-87e8edf753d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab4da300-a802-4052-9c18-e7c1a032d7e4", "AQAAAAEAACcQAAAAEGkmFYwWYCF04Fb3KGK6nOcdysDXMxDQehBKCIlJM7xjRqCQnpOapr6/1WunVsPk1A==", "a2866013-ae79-4e35-b70b-fe863678e4b0" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProductDescription", "PublicationDay" },
                values: new object[] { "The amount is the purchase price of the goods and is in euros", new DateTime(2024, 4, 6, 16, 47, 4, 777, DateTimeKind.Local).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductDescription", "PublicationDay" },
                values: new object[] { "Тhe price is for transport the cargo to the delivery address and is in euros", new DateTime(2024, 4, 6, 16, 47, 4, 777, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductDescription", "PublicationDay" },
                values: new object[] { "Тhe price is for one month of use and is in euros", new DateTime(2024, 4, 6, 16, 47, 4, 777, DateTimeKind.Local).AddTicks(5951) });
        }
    }
}
