using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EuropeanContracts.Infrastructure.Migrations
{
    public partial class DataSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ActionsTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "The amount is the purchase price of the goods and is in euros", "Sale" },
                    { 2, "Тhe price is for one month of use and is in euros", "Rent" },
                    { 3, "Тhe price is for transport the cargo to the delivery address and is in euros", "Transportation" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n", 0, "1c1e71e9-c131-4fed-a2df-d3688b835bcb", "fifthUser@mail.com", false, false, null, "fifthuser@mail.com", "fifthuser@mail.com", "AQAAAAEAACcQAAAAEEDhlCEW4eaTwkjOQB19ygYEquxT5icsq2sZ9GJW8jYEEzD5Z+DKcluky+U96t/lyw==", null, false, "6f72bc18-4511-4ed9-94f7-0d342513c488", false, "fifthUser@mail.com" },
                    { "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo", 0, "57182430-2609-4219-9f3b-d94d58f756ea", "sixthUser@mail.com", false, false, null, "sixthuser@mail.com", "sixthuser@mail.com", "AQAAAAEAACcQAAAAEEyAB/rIgHaJ5fjpocfGo9KEWITxKaUPZv3BbaF9aYsYaktkjBiP5DcvprMC/Cx5bA==", null, false, "bae3c031-8d6b-473e-83ec-4e9202e8a884", false, "sixthUser@mail.com" },
                    { "d33qwej9-02ap-11mnl-hflp-lpszavr2s588", 0, "7834771d-180b-454a-a082-0c1009087c4f", "fourthUser@mail.com", false, false, null, "fourthuser@mail.com", "fourthuser@mail.com", "AQAAAAEAACcQAAAAEIQ2auWRgiw4HH/p+s7cbWwBUobJhmOjty072XYr32W1aJVswlJRrCOXS1WiiJydsQ==", null, false, "cdaa8c53-752c-4c61-b858-efef37e39ae2", false, "fourthUser@mail.com" },
                    { "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532", 0, "ff4724c4-f236-4948-bad0-68244ee5872a", "eighthUser@mail.com", false, false, null, "eighthuser@mail.com", "eighthuser@mail.com", "AQAAAAEAACcQAAAAEG/qEHy5Wja8oMQpFV1EIsMKXMA0mZthe6hJjDkakn7OT9Gc2dqUfeOI6TMEmfNPAg==", null, false, "899620af-af17-4f44-ae7d-8cb09c667a6d", false, "eighthUser@mail.com" },
                    { "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32", 0, "90422df1-282d-4032-a9e1-f0263825f2c7", "seventhuser@mail.com", false, false, null, "seventhUser@mail.com", "seventhuser@mail.com", "AQAAAAEAACcQAAAAEKXao74RMTfKyHC/ER1TaW0uHohBPUHXQN7co1T7z7GbjnILXa2oFMoBV9Dl11aj4A==", null, false, "aeb71576-6c5e-4319-84d5-518e4e044311", false, "seventhUser@mail.com" },
                    { "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo", 0, "4bba0ea0-1aa4-4301-8915-43354207bef7", "secondUser@mail.com", false, false, null, "seconduser@mail.com", "seconduser@mail.com", "AQAAAAEAACcQAAAAEJiXnBoONGexG5Ji/3FnhhLseoVbpGG9yGj6pbAhCHnBh+3O0UaL6GlZo8z1Ov7RIA==", null, false, "2bbe57bd-b5fc-41fa-ab3e-b8d7e6c8cf9b", false, "secondUser@mail.com" },
                    { "k3fcll56-l458-6871-q3r9-2ve3w9a54s87", 0, "570cd4c8-bb44-45da-85cf-7f9dc31ec7f7", "firstUser@mail.com", false, false, null, "firstuser@mail.com", "firstuser@mail.com", "AQAAAAEAACcQAAAAECqpn3Elw03zlbH8LTEQTF+5h5bYyW24V+AGg4UfLWmI+w660z3D+GCa1smN9O7bpw==", null, false, "51c92ccf-3f0b-4071-b0be-8c943fa66a7f", false, "firstUser@mail.com" },
                    { "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn", 0, "0bced349-6c62-4715-a2d2-a0e4bedf995f", "thirdUser@mail.com", false, false, null, "thirduser@mail.com", "thirduser@mail.com", "AQAAAAEAACcQAAAAEA5+M6LgyCZnidCX7qDulb+g8HFhB4n9jwQmz1sO6mTOz3CoqvlX3k/A+gHMF/DVCg==", null, false, "6a1219f6-50be-48da-8474-40da62d55054", false, "thirdUser@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "RecipientsCompanies",
                columns: new[] { "Id", "Address", "Country", "Name", "OwnerId", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Charleroi, str. Rue de Marcinelle 50", "Belgium", "Global workers", "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo", "+3265689899852" },
                    { 2, "Lyon, str. Rue Domer 12", "France", "LeDecale Boutique", "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32", "+332566985556140" },
                    { 3, "Florence, str. Via Madonna Della Querce 4", "Italy", "SmartSolutions", "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532", "+3900125221287" }
                });

            migrationBuilder.InsertData(
                table: "SuppliersCompanies",
                columns: new[] { "Id", "Address", "Country", "Name", "OwnerId", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Thessaloniki, str. Perdika 10", "Greece", "SmartSolutions", "k3fcll56-l458-6871-q3r9-2ve3w9a54s87", "+0030695422154" },
                    { 2, "Vienna, str. LowelStrasse 69", "Austria", "MDY Tools", "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo", "+4368782664400" },
                    { 3, "Barcelona, str. Carrer Cruspinera 3", "Spain", "Stay Fly", "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn", "+342244501136" }
                });

            migrationBuilder.InsertData(
                table: "TransportsCompanies",
                columns: new[] { "Id", "Address", "Country", "Name", "OwnerId", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Varna, str. Popovi livadi 99", "Bulgaria", "NG TRANS", "d33qwej9-02ap-11mnl-hflp-lpszavr2s588", "+3598897415202" },
                    { 2, "Kostanza, Strada Spiru Haret 42", "Romania", "VIOREL TRANS GROUP", "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n", "+00407775987456." }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "ActionTypeId", "AddressOfDestination", "CountryOfDestination", "DeliveryTime", "IsDelivered", "IsTemperatureControlNeeded", "LoadingAddress", "LoadingCountry", "ProductDescription", "ProductImageURL", "ProductName", "ProductPrice", "ProductQuantity", "PublicationDay", "RecipientId", "SupplierId", "TransporterId" },
                values: new object[,]
                {
                    { 1, 1, null, null, null, false, true, "Badajoz, str. C.Jose.Caldito Ruiz 50", "Spain", "The amount is the purchase price of the goods and is in euros", "~/images/ProductImages/FreshPorkMeat.png", "Pork Meat", 102504m, 19840, new DateTime(2024, 3, 15, 19, 50, 50, 72, DateTimeKind.Local).AddTicks(3405), null, 1, null },
                    { 2, 3, "Burgas,Lozovo district, str.Ruzha 1", "Bulgaria", null, false, false, "Foggia, str. Via Daniele Manin 14", "Italy", "Тhe price is for transport the cargo to the delivery address and is in euros", "~/images/ProductImages/PlasticWaste.png", "Plastic waste", 4200m, 17800, new DateTime(2024, 3, 15, 19, 50, 50, 72, DateTimeKind.Local).AddTicks(3407), null, 2, null },
                    { 3, 2, null, null, null, false, false, "Vienna, str. Sindelargasse 17", "Austria", "Тhe price is for one month of use and is in euros", "~/images/ProductImages/ScaffoldingMaterials.png", "Scaffolding material", 3500m, 19900, new DateTime(2024, 3, 15, 19, 50, 50, 72, DateTimeKind.Local).AddTicks(3409), null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Trailers",
                columns: new[] { "Id", "HasTemperatureControl", "Make", "TrailerImageURL", "TransportCompanyId" },
                values: new object[,]
                {
                    { 1, true, "Kodel", "~/Images/TrailersImages/Kogel", 1 },
                    { 2, false, "Krone", "~/Images/TrailersImages/Krone", 1 },
                    { 3, true, "Schmitz Cargobull", "~/Images/TrailersImages/SchmitzCargobull", 2 }
                });

            migrationBuilder.InsertData(
                table: "Trucks",
                columns: new[] { "Id", "HasCargoSpace", "HasTemperatureControl", "HorsePower", "Make", "Model", "TransportCompanyId", "TruckImageURL" },
                values: new object[,]
                {
                    { 1, false, false, 450, "DAF", "XG+", 1, "~/Images/TrackImages/DAF" },
                    { 2, false, false, 500, "VOLVO", "FX", 2, "~/Images/TrackImages/VOLVO" },
                    { 3, true, false, 510, "SCANIA", "R510", 2, "~/Images/TrackImages/SCANIA" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RecipientsCompanies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RecipientsCompanies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RecipientsCompanies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SuppliersCompanies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trailers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trailers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trailers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ActionsTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ActionsTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ActionsTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn");

            migrationBuilder.DeleteData(
                table: "SuppliersCompanies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SuppliersCompanies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TransportsCompanies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TransportsCompanies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d33qwej9-02ap-11mnl-hflp-lpszavr2s588");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k3fcll56-l458-6871-q3r9-2ve3w9a54s87");
        }
    }
}
