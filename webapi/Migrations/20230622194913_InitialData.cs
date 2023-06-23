using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CentrCostos",
                columns: new[] { "id", "CreationDate", "code", "name", "status" },
                values: new object[,]
                {
                    { new Guid("d141691c-112e-11ee-be56-0242ac120002"), new DateTime(2023, 6, 22, 14, 49, 13, 291, DateTimeKind.Local).AddTicks(8017), "Cc1234", "Gerencia TI", true },
                    { new Guid("d141691c-112e-11ee-be56-0242ac120003"), new DateTime(2023, 6, 22, 14, 49, 13, 291, DateTimeKind.Local).AddTicks(8026), "Cc1235", "Gerencia Financier", true },
                    { new Guid("d141691c-112e-11ee-be56-0242ac120004"), new DateTime(2023, 6, 22, 14, 49, 13, 291, DateTimeKind.Local).AddTicks(8030), "Cc1234", "Gerencia Logistica", true }
                });

            migrationBuilder.InsertData(
                table: "Prefesion",
                columns: new[] { "id", "CreationDate", "code", "name", "status" },
                values: new object[,]
                {
                    { new Guid("d241691c-112e-11ee-be56-0242ac120002"), new DateTime(2023, 6, 22, 14, 49, 13, 291, DateTimeKind.Local).AddTicks(6011), "Aut1234", "Desarrollador", true },
                    { new Guid("d241691c-112e-11ee-be56-0242ac120003"), new DateTime(2023, 6, 22, 14, 49, 13, 291, DateTimeKind.Local).AddTicks(6036), "Aut1235", "Coordinador", true },
                    { new Guid("d241691c-112e-11ee-be56-0242ac120004"), new DateTime(2023, 6, 22, 14, 49, 13, 291, DateTimeKind.Local).AddTicks(6040), "Aut1234", "Analista", true },
                    { new Guid("d241691c-112e-11ee-be56-0242ac120005"), new DateTime(2023, 6, 22, 14, 49, 13, 291, DateTimeKind.Local).AddTicks(6044), "Aut1233", "Ingeniero", true },
                    { new Guid("d241691c-112e-11ee-be56-0242ac120006"), new DateTime(2023, 6, 22, 14, 49, 13, 291, DateTimeKind.Local).AddTicks(6047), "Aut1233", "Gerente", true }
                });

            migrationBuilder.InsertData(
                table: "Area",
                columns: new[] { "id", "CreationDate", "code", "costcenterId", "name", "status" },
                values: new object[,]
                {
                    { new Guid("d341691c-112e-11ee-be56-0242ac120002"), new DateTime(2023, 6, 22, 14, 49, 13, 291, DateTimeKind.Local).AddTicks(8940), "Aut1234", new Guid("d141691c-112e-11ee-be56-0242ac120002"), "Tecnología", true },
                    { new Guid("d341691c-112e-11ee-be56-0242ac120004"), new DateTime(2023, 6, 22, 14, 49, 13, 291, DateTimeKind.Local).AddTicks(8951), "Aut1234", new Guid("d141691c-112e-11ee-be56-0242ac120003"), "Nomina", true },
                    { new Guid("d341691c-112e-11ee-be56-0242ac120005"), new DateTime(2023, 6, 22, 14, 49, 13, 291, DateTimeKind.Local).AddTicks(8957), "Aut1233", new Guid("d141691c-112e-11ee-be56-0242ac120004"), "Logistica", true }
                });

            migrationBuilder.InsertData(
                table: "Empelados",
                columns: new[] { "id", "CreationDate", "address", "age", "areaId", "identification", "name", "phone", "professionId", "user" },
                values: new object[,]
                {
                    { new Guid("d441691c-112e-11ee-be56-0242ac120002"), new DateTime(2023, 6, 22, 14, 49, 13, 292, DateTimeKind.Local).AddTicks(1752), "Carrera 54# 34-25", 29, new Guid("d341691c-112e-11ee-be56-0242ac120002"), "12365487", "pepito Perez", "3016590141", new Guid("d241691c-112e-11ee-be56-0242ac120002"), "user1" },
                    { new Guid("d441691c-112e-11ee-be56-0242ac120003"), new DateTime(2023, 6, 22, 14, 49, 13, 292, DateTimeKind.Local).AddTicks(1765), "Carrera 54# 34-25", 30, new Guid("d341691c-112e-11ee-be56-0242ac120004"), "32554544", "Monica Tamayo", "3016590141", new Guid("d241691c-112e-11ee-be56-0242ac120004"), "user2" },
                    { new Guid("d441691c-112e-11ee-be56-0242ac120004"), new DateTime(2023, 6, 22, 14, 49, 13, 292, DateTimeKind.Local).AddTicks(1772), "Carrera 54# 34-25", 25, new Guid("d341691c-112e-11ee-be56-0242ac120005"), "32774544", "Carlos Perez", "3016590141", new Guid("d241691c-112e-11ee-be56-0242ac120004"), "user3" },
                    { new Guid("d441691c-112e-11ee-be56-0242ac120005"), new DateTime(2023, 6, 22, 14, 49, 13, 292, DateTimeKind.Local).AddTicks(1779), "Carrera 54# 34-25", 40, new Guid("d341691c-112e-11ee-be56-0242ac120004"), "125554544", "Mario Castro", "3016590141", new Guid("d241691c-112e-11ee-be56-0242ac120004"), "user4" },
                    { new Guid("d441691c-112e-11ee-be56-0242ac120006"), new DateTime(2023, 6, 22, 14, 49, 13, 292, DateTimeKind.Local).AddTicks(1786), "Carrera 54# 34-25", 20, new Guid("d341691c-112e-11ee-be56-0242ac120005"), "1254895444", "Jose Peña", "3016590141", new Guid("d241691c-112e-11ee-be56-0242ac120004"), "user5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Empelados",
                keyColumn: "id",
                keyValue: new Guid("d441691c-112e-11ee-be56-0242ac120002"));

            migrationBuilder.DeleteData(
                table: "Empelados",
                keyColumn: "id",
                keyValue: new Guid("d441691c-112e-11ee-be56-0242ac120003"));

            migrationBuilder.DeleteData(
                table: "Empelados",
                keyColumn: "id",
                keyValue: new Guid("d441691c-112e-11ee-be56-0242ac120004"));

            migrationBuilder.DeleteData(
                table: "Empelados",
                keyColumn: "id",
                keyValue: new Guid("d441691c-112e-11ee-be56-0242ac120005"));

            migrationBuilder.DeleteData(
                table: "Empelados",
                keyColumn: "id",
                keyValue: new Guid("d441691c-112e-11ee-be56-0242ac120006"));

            migrationBuilder.DeleteData(
                table: "Prefesion",
                keyColumn: "id",
                keyValue: new Guid("d241691c-112e-11ee-be56-0242ac120003"));

            migrationBuilder.DeleteData(
                table: "Prefesion",
                keyColumn: "id",
                keyValue: new Guid("d241691c-112e-11ee-be56-0242ac120005"));

            migrationBuilder.DeleteData(
                table: "Prefesion",
                keyColumn: "id",
                keyValue: new Guid("d241691c-112e-11ee-be56-0242ac120006"));

            migrationBuilder.DeleteData(
                table: "Area",
                keyColumn: "id",
                keyValue: new Guid("d341691c-112e-11ee-be56-0242ac120002"));

            migrationBuilder.DeleteData(
                table: "Area",
                keyColumn: "id",
                keyValue: new Guid("d341691c-112e-11ee-be56-0242ac120004"));

            migrationBuilder.DeleteData(
                table: "Area",
                keyColumn: "id",
                keyValue: new Guid("d341691c-112e-11ee-be56-0242ac120005"));

            migrationBuilder.DeleteData(
                table: "Prefesion",
                keyColumn: "id",
                keyValue: new Guid("d241691c-112e-11ee-be56-0242ac120002"));

            migrationBuilder.DeleteData(
                table: "Prefesion",
                keyColumn: "id",
                keyValue: new Guid("d241691c-112e-11ee-be56-0242ac120004"));

            migrationBuilder.DeleteData(
                table: "CentrCostos",
                keyColumn: "id",
                keyValue: new Guid("d141691c-112e-11ee-be56-0242ac120002"));

            migrationBuilder.DeleteData(
                table: "CentrCostos",
                keyColumn: "id",
                keyValue: new Guid("d141691c-112e-11ee-be56-0242ac120003"));

            migrationBuilder.DeleteData(
                table: "CentrCostos",
                keyColumn: "id",
                keyValue: new Guid("d141691c-112e-11ee-be56-0242ac120004"));
        }
    }
}
