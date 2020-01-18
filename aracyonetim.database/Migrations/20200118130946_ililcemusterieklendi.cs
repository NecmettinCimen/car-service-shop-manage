using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aracyonetim.database.Migrations
{
    public partial class ililcemusterieklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "Kullanici");

            migrationBuilder.AlterColumn<string>(
                name: "Isim",
                table: "LookupList",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "LookupList",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IlceId",
                table: "Kullanici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "LookupList",
                columns: new[] { "Id", "CreateDate", "CreatorId", "IsDeleted", "Isim", "ParentId", "Status", "Tip" },
                values: new object[,]
                {
                    { 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Adana", null, (short)0, 2 },
                    { 201433, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yazıhan", 1004, (short)0, 3 },
                    { 202063, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Akhisar", 1048, (short)0, 3 },
                    { 202694, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Alaşehir", 1048, (short)0, 3 },
                    { 203326, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Demirci", 1048, (short)0, 3 },
                    { 203959, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gördes", 1048, (short)0, 3 },
                    { 204593, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kırkağaç", 1048, (short)0, 3 },
                    { 205228, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kula", 1048, (short)0, 3 },
                    { 205864, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Manisa Merkez", 1048, (short)0, 3 },
                    { 206501, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Salihli", 1048, (short)0, 3 },
                    { 207139, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sarıgöl", 1048, (short)0, 3 },
                    { 207778, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Saruhanlı", 1048, (short)0, 3 },
                    { 208418, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Selendi", 1048, (short)0, 3 },
                    { 209059, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Soma", 1048, (short)0, 3 },
                    { 209701, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Turgutlu", 1048, (short)0, 3 },
                    { 210344, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ahmetli", 1048, (short)0, 3 },
                    { 210988, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gölmarmara", 1048, (short)0, 3 },
                    { 211633, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Köprübaşı / Manisa", 1048, (short)0, 3 },
                    { 212279, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şehzadeler", 1048, (short)0, 3 },
                    { 212926, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yunusemre", 1048, (short)0, 3 },
                    { 213574, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Afşin", 1093, (short)0, 3 },
                    { 214223, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Andırın", 1093, (short)0, 3 },
                    { 214873, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Elbistan", 1093, (short)0, 3 },
                    { 215524, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Göksun", 1093, (short)0, 3 },
                    { 216176, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kahramanmaraş Merkez", 1093, (short)0, 3 },
                    { 216829, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Pazarcık", 1093, (short)0, 3 },
                    { 217483, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Türkoğlu", 1093, (short)0, 3 },
                    { 218138, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çağlayancerit", 1093, (short)0, 3 },
                    { 218794, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ekinözü", 1093, (short)0, 3 },
                    { 219451, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Nurhak", 1093, (short)0, 3 },
                    { 200804, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kuluncak", 1004, (short)0, 3 },
                    { 200176, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kale / Malatya", 1004, (short)0, 3 },
                    { 199549, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Doğanyol", 1004, (short)0, 3 },
                    { 198923, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Battalgazi", 1004, (short)0, 3 },
                    { 180608, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ahırlı", 919, (short)0, 3 },
                    { 181204, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çeltik", 919, (short)0, 3 },
                    { 181801, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Derbent", 919, (short)0, 3 },
                    { 182399, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Emirgazi", 919, (short)0, 3 },
                    { 182998, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Güneysınır", 919, (short)0, 3 },
                    { 183598, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Halkapınar", 919, (short)0, 3 },
                    { 184199, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tuzlukçu", 919, (short)0, 3 },
                    { 184801, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yalıhüyük", 919, (short)0, 3 },
                    { 185404, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Altıntaş", 961, (short)0, 3 },
                    { 186008, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Domaniç", 961, (short)0, 3 },
                    { 186613, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Emet", 961, (short)0, 3 },
                    { 187219, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gediz", 961, (short)0, 3 },
                    { 187826, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kütahya Merkez", 961, (short)0, 3 },
                    { 188434, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Simav", 961, (short)0, 3 },
                    { 220109, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Dulkadiroğlu", 1093, (short)0, 3 },
                    { 189043, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tavşanlı", 961, (short)0, 3 },
                    { 190264, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Dumlupınar", 961, (short)0, 3 },
                    { 190876, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hisarcık", 961, (short)0, 3 },
                    { 191489, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şaphane", 961, (short)0, 3 },
                    { 192103, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çavdarhisar", 961, (short)0, 3 },
                    { 192718, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Pazarlar", 961, (short)0, 3 },
                    { 193334, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Akçadağ", 1004, (short)0, 3 },
                    { 193951, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Arapgir", 1004, (short)0, 3 },
                    { 194569, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Arguvan", 1004, (short)0, 3 },
                    { 195188, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Darende", 1004, (short)0, 3 },
                    { 195808, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Doğanşehir", 1004, (short)0, 3 },
                    { 196429, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hekimhan", 1004, (short)0, 3 },
                    { 197051, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Malatya Merkez", 1004, (short)0, 3 },
                    { 197674, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Pütürge", 1004, (short)0, 3 },
                    { 198298, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yeşilyurt / Malatya", 1004, (short)0, 3 },
                    { 189653, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Aslanapa", 961, (short)0, 3 },
                    { 180013, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Taşkent", 919, (short)0, 3 },
                    { 220768, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Onikişubat", 1093, (short)0, 3 },
                    { 222089, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kızıltepe", 1139, (short)0, 3 },
                    { 245854, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Nevşehir Merkez", 1283, (short)0, 3 },
                    { 246551, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ürgüp", 1283, (short)0, 3 },
                    { 247249, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Acıgöl", 1283, (short)0, 3 },
                    { 247948, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bor", 1333, (short)0, 3 },
                    { 248648, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çamardı", 1333, (short)0, 3 },
                    { 249349, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Niğde Merkez", 1333, (short)0, 3 },
                    { 250051, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ulukışla", 1333, (short)0, 3 },
                    { 250754, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Altunhisar", 1333, (short)0, 3 },
                    { 251458, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çiftlik", 1333, (short)0, 3 },
                    { 252163, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Akkuş", 1384, (short)0, 3 },
                    { 252869, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Aybastı", 1384, (short)0, 3 },
                    { 253576, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Fatsa", 1384, (short)0, 3 },
                    { 254284, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gölköy", 1384, (short)0, 3 },
                    { 254993, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Korgan", 1384, (short)0, 3 },
                    { 255703, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kumru", 1384, (short)0, 3 },
                    { 256414, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mesudiye", 1384, (short)0, 3 },
                    { 257126, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ordu Merkez", 1384, (short)0, 3 },
                    { 257839, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Perşembe", 1384, (short)0, 3 },
                    { 258553, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ulubey / Ordu", 1384, (short)0, 3 },
                    { 259268, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ünye", 1384, (short)0, 3 },
                    { 259984, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gülyalı", 1384, (short)0, 3 },
                    { 260701, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gürgentepe", 1384, (short)0, 3 },
                    { 261419, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çamaş", 1384, (short)0, 3 },
                    { 262138, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çatalpınar", 1384, (short)0, 3 },
                    { 262858, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çaybaşı", 1384, (short)0, 3 },
                    { 263579, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İkizce", 1384, (short)0, 3 },
                    { 264301, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kabadüz", 1384, (short)0, 3 },
                    { 265024, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kabataş", 1384, (short)0, 3 },
                    { 265748, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Altınordu", 1384, (short)0, 3 },
                    { 245158, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kozaklı", 1283, (short)0, 3 },
                    { 244463, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hacıbektaş", 1283, (short)0, 3 },
                    { 243769, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gülşehir", 1283, (short)0, 3 },
                    { 243076, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Derinkuyu", 1283, (short)0, 3 },
                    { 222751, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mardin Merkez", 1139, (short)0, 3 },
                    { 223414, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mazıdağı", 1139, (short)0, 3 },
                    { 224078, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Midyat", 1139, (short)0, 3 },
                    { 224743, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Nusaybin", 1139, (short)0, 3 },
                    { 225409, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ömerli", 1139, (short)0, 3 },
                    { 226076, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Savur", 1139, (short)0, 3 },
                    { 226744, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Dargeçit", 1139, (short)0, 3 },
                    { 227413, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yeşilli", 1139, (short)0, 3 },
                    { 228083, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Artuklu", 1139, (short)0, 3 },
                    { 228754, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bodrum", 1186, (short)0, 3 },
                    { 229426, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Datça", 1186, (short)0, 3 },
                    { 230099, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Fethiye", 1186, (short)0, 3 },
                    { 230773, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Köyceğiz", 1186, (short)0, 3 },
                    { 231448, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Marmaris", 1186, (short)0, 3 },
                    { 221428, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Derik", 1139, (short)0, 3 },
                    { 232124, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Milas", 1186, (short)0, 3 },
                    { 233479, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ula", 1186, (short)0, 3 },
                    { 234158, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yatağan", 1186, (short)0, 3 },
                    { 234838, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Dalaman", 1186, (short)0, 3 },
                    { 235519, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ortaca", 1186, (short)0, 3 },
                    { 236201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kavaklıdere", 1186, (short)0, 3 },
                    { 236884, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Menteşe", 1186, (short)0, 3 },
                    { 237568, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Seydikemer", 1186, (short)0, 3 },
                    { 238253, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bulanık", 1234, (short)0, 3 },
                    { 238939, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Malazgirt", 1234, (short)0, 3 },
                    { 239626, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Muş Merkez", 1234, (short)0, 3 },
                    { 240314, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Varto", 1234, (short)0, 3 },
                    { 241003, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hasköy", 1234, (short)0, 3 },
                    { 241693, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Korkut", 1234, (short)0, 3 },
                    { 242384, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Avanos", 1283, (short)0, 3 },
                    { 232801, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Muğla Merkez", 1186, (short)0, 3 },
                    { 179419, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Selçuklu", 919, (short)0, 3 },
                    { 178826, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Meram", 919, (short)0, 3 },
                    { 178234, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karatay", 919, (short)0, 3 },
                    { 125563, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çiğli", 653, (short)0, 3 },
                    { 126058, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gaziemir", 653, (short)0, 3 },
                    { 126554, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Narlıdere", 653, (short)0, 3 },
                    { 127051, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Güzelbahçe", 653, (short)0, 3 },
                    { 127549, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bayraklı", 653, (short)0, 3 },
                    { 128048, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karabağlar", 653, (short)0, 3 },
                    { 128548, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Arpaçay", 688, (short)0, 3 },
                    { 129049, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Digor", 688, (short)0, 3 },
                    { 129551, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kağızman", 688, (short)0, 3 },
                    { 130054, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kars Merkez", 688, (short)0, 3 },
                    { 130558, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sarıkamış", 688, (short)0, 3 },
                    { 131063, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Selim", 688, (short)0, 3 },
                    { 131569, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Susuz", 688, (short)0, 3 },
                    { 132076, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Akyaka", 688, (short)0, 3 },
                    { 132584, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Abana", 724, (short)0, 3 },
                    { 133093, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Araç", 724, (short)0, 3 },
                    { 133603, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Azdavay", 724, (short)0, 3 },
                    { 134114, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bozkurt / Kastamonu", 724, (short)0, 3 },
                    { 134626, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Cide", 724, (short)0, 3 },
                    { 135139, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çatalzeytin", 724, (short)0, 3 },
                    { 135653, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Daday", 724, (short)0, 3 },
                    { 136168, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Devrekani", 724, (short)0, 3 },
                    { 136684, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İnebolu", 724, (short)0, 3 },
                    { 137201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kastamonu Merkez", 724, (short)0, 3 },
                    { 137719, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Küre", 724, (short)0, 3 },
                    { 138238, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Taşköprü", 724, (short)0, 3 },
                    { 138758, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tosya", 724, (short)0, 3 },
                    { 139279, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İhsangazi", 724, (short)0, 3 },
                    { 139801, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Pınarbaşı / Kastamonu", 724, (short)0, 3 },
                    { 125069, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Balçova", 653, (short)0, 3 },
                    { 124576, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Menderes", 653, (short)0, 3 },
                    { 124084, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Konak", 653, (short)0, 3 },
                    { 123593, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Buca", 653, (short)0, 3 },
                    { 109328, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tuzla", 619, (short)0, 3 },
                    { 109789, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Esenler", 619, (short)0, 3 },
                    { 110251, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Arnavutköy", 619, (short)0, 3 },
                    { 110714, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ataşehir", 619, (short)0, 3 },
                    { 111178, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Başakşehir", 619, (short)0, 3 },
                    { 111643, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Beylikdüzü", 619, (short)0, 3 },
                    { 112109, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çekmeköy", 619, (short)0, 3 },
                    { 112576, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Esenyurt", 619, (short)0, 3 },
                    { 113044, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sancaktepe", 619, (short)0, 3 },
                    { 113513, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sultangazi", 619, (short)0, 3 },
                    { 113983, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Aliağa", 653, (short)0, 3 },
                    { 114454, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bayındır", 653, (short)0, 3 },
                    { 114926, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bergama", 653, (short)0, 3 },
                    { 115399, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bornova", 653, (short)0, 3 },
                    { 140324, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şenpazar", 724, (short)0, 3 },
                    { 115873, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çeşme", 653, (short)0, 3 },
                    { 116824, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Foça", 653, (short)0, 3 },
                    { 117301, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karaburun", 653, (short)0, 3 },
                    { 117779, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karşıyaka", 653, (short)0, 3 },
                    { 118258, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kemalpaşa / İzmir", 653, (short)0, 3 },
                    { 118738, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kınık", 653, (short)0, 3 },
                    { 119219, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kiraz", 653, (short)0, 3 },
                    { 119701, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Menemen", 653, (short)0, 3 },
                    { 120184, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ödemiş", 653, (short)0, 3 },
                    { 120668, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Seferihisar", 653, (short)0, 3 },
                    { 121153, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Selçuk", 653, (short)0, 3 },
                    { 121639, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tire", 653, (short)0, 3 },
                    { 122126, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Torbalı", 653, (short)0, 3 },
                    { 122614, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Urla", 653, (short)0, 3 },
                    { 123103, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Beydağ", 653, (short)0, 3 },
                    { 116348, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Dikili", 653, (short)0, 3 },
                    { 140848, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ağlı", 724, (short)0, 3 },
                    { 141373, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Doğanyurt", 724, (short)0, 3 },
                    { 141899, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hanönü", 724, (short)0, 3 },
                    { 160939, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kandıra", 878, (short)0, 3 },
                    { 161501, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karamürsel", 878, (short)0, 3 },
                    { 162064, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kocaeli Merkez", 878, (short)0, 3 },
                    { 162628, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Körfez", 878, (short)0, 3 },
                    { 163193, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Derince", 878, (short)0, 3 },
                    { 163759, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Başiskele", 878, (short)0, 3 },
                    { 164326, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çayırova", 878, (short)0, 3 },
                    { 164894, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Darıca", 878, (short)0, 3 },
                    { 165463, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Dilovası", 878, (short)0, 3 },
                    { 166033, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İzmit", 878, (short)0, 3 },
                    { 166604, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kartepe", 878, (short)0, 3 },
                    { 167176, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Akşehir", 919, (short)0, 3 },
                    { 167749, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Beyşehir", 919, (short)0, 3 },
                    { 168323, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bozkır", 919, (short)0, 3 },
                    { 160378, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gölcük", 878, (short)0, 3 },
                    { 168898, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Cihanbeyli", 919, (short)0, 3 },
                    { 170051, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Doğanhisar", 919, (short)0, 3 },
                    { 170629, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ereğli / Konya", 919, (short)0, 3 },
                    { 171208, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hadim", 919, (short)0, 3 },
                    { 171788, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ilgın", 919, (short)0, 3 },
                    { 172369, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kadınhanı", 919, (short)0, 3 },
                    { 172951, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karapınar", 919, (short)0, 3 },
                    { 173534, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kulu", 919, (short)0, 3 },
                    { 174118, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sarayönü", 919, (short)0, 3 },
                    { 174703, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Seydişehir", 919, (short)0, 3 },
                    { 175289, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yunak", 919, (short)0, 3 },
                    { 175876, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Akören", 919, (short)0, 3 },
                    { 176464, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Altınekin", 919, (short)0, 3 },
                    { 177053, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Derebucak", 919, (short)0, 3 },
                    { 177643, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hüyük", 919, (short)0, 3 },
                    { 169474, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çumra", 919, (short)0, 3 },
                    { 266473, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ardeşen", 1436, (short)0, 3 },
                    { 159818, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gebze", 878, (short)0, 3 },
                    { 158701, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Akçakent", 838, (short)0, 3 },
                    { 142426, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Seydiler", 724, (short)0, 3 },
                    { 142954, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bünyan", 761, (short)0, 3 },
                    { 143483, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Develi", 761, (short)0, 3 },
                    { 144013, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Felahiye", 761, (short)0, 3 },
                    { 144544, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İncesu", 761, (short)0, 3 },
                    { 145076, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Pınarbaşı / Kayseri", 761, (short)0, 3 },
                    { 145609, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sarıoğlan", 761, (short)0, 3 },
                    { 146143, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sarız", 761, (short)0, 3 },
                    { 146678, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tomarza", 761, (short)0, 3 },
                    { 147214, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yahyalı", 761, (short)0, 3 },
                    { 147751, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yeşilhisar", 761, (short)0, 3 },
                    { 148289, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Akkışla", 761, (short)0, 3 },
                    { 148828, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Talas", 761, (short)0, 3 },
                    { 149368, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kocasinan", 761, (short)0, 3 },
                    { 159259, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Boztepe", 838, (short)0, 3 },
                    { 149909, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Melikgazi", 761, (short)0, 3 },
                    { 150994, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Özvatan", 761, (short)0, 3 },
                    { 151538, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Babaeski", 799, (short)0, 3 },
                    { 152083, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Demirköy", 799, (short)0, 3 },
                    { 152629, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kırklareli Merkez", 799, (short)0, 3 },
                    { 153176, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kofçaz", 799, (short)0, 3 },
                    { 153724, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Lüleburgaz", 799, (short)0, 3 },
                    { 154273, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Pehlivanköy", 799, (short)0, 3 },
                    { 154823, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Pınarhisar", 799, (short)0, 3 },
                    { 155374, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Vize", 799, (short)0, 3 },
                    { 155926, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çiçekdağı", 838, (short)0, 3 }
                });

            migrationBuilder.InsertData(
                table: "LookupList",
                columns: new[] { "Id", "CreateDate", "CreatorId", "IsDeleted", "Isim", "ParentId", "Status", "Tip" },
                values: new object[,]
                {
                    { 156479, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kaman", 838, (short)0, 3 },
                    { 157033, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kırşehir Merkez", 838, (short)0, 3 },
                    { 157588, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mucur", 838, (short)0, 3 },
                    { 158144, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Akpınar", 838, (short)0, 3 },
                    { 150451, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hacılar", 761, (short)0, 3 },
                    { 108868, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sultanbeyli", 619, (short)0, 3 },
                    { 267199, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çamlıhemşin", 1436, (short)0, 3 },
                    { 268654, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Fındıklı", 1436, (short)0, 3 },
                    { 406949, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yozgat Merkez", 2203, (short)0, 3 },
                    { 407848, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Aydıncık / Yozgat", 2203, (short)0, 3 },
                    { 408748, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çandır", 2203, (short)0, 3 },
                    { 409649, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kadışehri", 2203, (short)0, 3 },
                    { 410551, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Saraykent", 2203, (short)0, 3 },
                    { 411454, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yenifakılı", 2203, (short)0, 3 },
                    { 412358, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çaycuma", 2269, (short)0, 3 },
                    { 413263, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Devrek", 2269, (short)0, 3 },
                    { 414169, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ereğli / Zonguldak", 2269, (short)0, 3 },
                    { 415076, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Zonguldak Merkez", 2269, (short)0, 3 },
                    { 415984, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Alaplı", 2269, (short)0, 3 },
                    { 416893, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gökçebey", 2269, (short)0, 3 },
                    { 417803, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kilimli", 2269, (short)0, 3 },
                    { 418714, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kozlu", 2269, (short)0, 3 },
                    { 419626, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Aksaray Merkez", 2336, (short)0, 3 },
                    { 420539, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ortaköy / Aksaray", 2336, (short)0, 3 },
                    { 421453, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ağaçören", 2336, (short)0, 3 },
                    { 422368, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Güzelyurt", 2336, (short)0, 3 },
                    { 423284, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sarıyahşi", 2336, (short)0, 3 },
                    { 424201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Eskil", 2336, (short)0, 3 },
                    { 425119, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gülağaç", 2336, (short)0, 3 },
                    { 426038, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sultanhanı", 2336, (short)0, 3 },
                    { 426958, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bayburt Merkez", 2404, (short)0, 3 },
                    { 427879, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Aydıntepe", 2404, (short)0, 3 },
                    { 428801, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Demirözü", 2404, (short)0, 3 },
                    { 429724, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ermenek", 2473, (short)0, 3 },
                    { 430648, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karaman Merkez", 2473, (short)0, 3 },
                    { 431573, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ayrancı", 2473, (short)0, 3 },
                    { 432499, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kazımkarabekir", 2473, (short)0, 3 },
                    { 406051, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yerköy", 2203, (short)0, 3 },
                    { 405154, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şefaatli", 2203, (short)0, 3 },
                    { 404258, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sorgun", 2203, (short)0, 3 },
                    { 403363, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sarıkaya", 2203, (short)0, 3 },
                    { 376978, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şanlıurfa Merkez", 2011, (short)0, 3 },
                    { 377843, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Viranşehir", 2011, (short)0, 3 },
                    { 378709, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Harran", 2011, (short)0, 3 },
                    { 379576, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Eyyübiye", 2011, (short)0, 3 },
                    { 380444, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Haliliye", 2011, (short)0, 3 },
                    { 381313, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karaköprü", 2011, (short)0, 3 },
                    { 382183, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Banaz", 2074, (short)0, 3 },
                    { 383054, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Eşme", 2074, (short)0, 3 },
                    { 383926, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karahallı", 2074, (short)0, 3 },
                    { 384799, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sivaslı", 2074, (short)0, 3 },
                    { 385673, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ulubey / Uşak", 2074, (short)0, 3 },
                    { 386548, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Uşak Merkez", 2074, (short)0, 3 },
                    { 387424, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Başkale", 2138, (short)0, 3 },
                    { 388301, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çatak", 2138, (short)0, 3 },
                    { 433426, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Başyayla", 2473, (short)0, 3 },
                    { 389179, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Erciş", 2138, (short)0, 3 },
                    { 390938, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gürpınar", 2138, (short)0, 3 },
                    { 391819, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Muradiye", 2138, (short)0, 3 },
                    { 392701, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Özalp", 2138, (short)0, 3 },
                    { 393584, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Van Merkez", 2138, (short)0, 3 },
                    { 394468, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bahçesaray", 2138, (short)0, 3 },
                    { 395353, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çaldıran", 2138, (short)0, 3 },
                    { 396239, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Edremit / Van", 2138, (short)0, 3 },
                    { 397126, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Saray / Van", 2138, (short)0, 3 },
                    { 398014, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İpekyolu", 2138, (short)0, 3 },
                    { 398903, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tuşba", 2138, (short)0, 3 },
                    { 399793, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Akdağmadeni", 2203, (short)0, 3 },
                    { 400684, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Boğazlıyan", 2203, (short)0, 3 },
                    { 401576, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çayıralan", 2203, (short)0, 3 },
                    { 402469, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çekerek", 2203, (short)0, 3 },
                    { 390058, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gevaş", 2138, (short)0, 3 },
                    { 376114, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Suruç", 2011, (short)0, 3 },
                    { 434354, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sarıveliler", 2473, (short)0, 3 },
                    { 436213, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Keskin", 2543, (short)0, 3 },
                    { 469393, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yalova Merkez", 2984, (short)0, 3 },
                    { 470359, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Altınova", 2984, (short)0, 3 },
                    { 471326, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Armutlu", 2984, (short)0, 3 },
                    { 472294, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çınarcık", 2984, (short)0, 3 },
                    { 473263, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çiftlikköy", 2984, (short)0, 3 },
                    { 474233, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Termal", 2984, (short)0, 3 },
                    { 475204, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Eflani", 3061, (short)0, 3 },
                    { 476176, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Eskipazar", 3061, (short)0, 3 },
                    { 477149, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karabük Merkez", 3061, (short)0, 3 },
                    { 478123, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ovacık / Karabük", 3061, (short)0, 3 },
                    { 479098, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Safranbolu", 3061, (short)0, 3 },
                    { 480074, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yenice / Karabük", 3061, (short)0, 3 },
                    { 481051, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kilis Merkez", 3139, (short)0, 3 },
                    { 482029, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Elbeyli", 3139, (short)0, 3 },
                    { 483008, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Musabeyli", 3139, (short)0, 3 },
                    { 483988, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Polateli", 3139, (short)0, 3 },
                    { 484969, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bahçe", 3218, (short)0, 3 },
                    { 485951, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kadirli", 3218, (short)0, 3 },
                    { 486934, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Osmaniye Merkez", 3218, (short)0, 3 },
                    { 487918, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Düziçi", 3218, (short)0, 3 },
                    { 488903, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hasanbeyli", 3218, (short)0, 3 },
                    { 489889, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sumbas", 3218, (short)0, 3 },
                    { 490876, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Toprakkale", 3218, (short)0, 3 },
                    { 491864, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Akçakoca", 3298, (short)0, 3 },
                    { 492853, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Düzce Merkez", 3298, (short)0, 3 },
                    { 493843, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yığılca", 3298, (short)0, 3 },
                    { 494834, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Cumayeri", 3298, (short)0, 3 },
                    { 495826, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gölyaka", 3298, (short)0, 3 },
                    { 496819, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çilimli", 3298, (short)0, 3 },
                    { 468428, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karakoyunlu", 2908, (short)0, 3 },
                    { 467464, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tuzluca", 2908, (short)0, 3 },
                    { 466501, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Iğdır Merkez", 2908, (short)0, 3 },
                    { 465539, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Aralık", 2908, (short)0, 3 },
                    { 437144, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kırıkkale Merkez", 2543, (short)0, 3 },
                    { 438076, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sulakyurt", 2543, (short)0, 3 },
                    { 439009, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bahşili", 2543, (short)0, 3 },
                    { 439943, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Balışeyh", 2543, (short)0, 3 },
                    { 440878, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çelebi", 2543, (short)0, 3 },
                    { 441814, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karakeçili", 2543, (short)0, 3 },
                    { 442751, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yahşihan", 2543, (short)0, 3 },
                    { 443689, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Batman Merkez", 2614, (short)0, 3 },
                    { 444628, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Beşiri", 2614, (short)0, 3 },
                    { 445568, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gercüş", 2614, (short)0, 3 },
                    { 446509, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kozluk", 2614, (short)0, 3 },
                    { 447451, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sason", 2614, (short)0, 3 },
                    { 448394, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hasankeyf", 2614, (short)0, 3 },
                    { 449338, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Beytüşşebap", 2686, (short)0, 3 },
                    { 435283, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Delice", 2543, (short)0, 3 },
                    { 450283, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Cizre", 2686, (short)0, 3 },
                    { 452176, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Silopi", 2686, (short)0, 3 },
                    { 453124, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şırnak Merkez", 2686, (short)0, 3 },
                    { 454073, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Uludere", 2686, (short)0, 3 },
                    { 455023, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Güçlükonak", 2686, (short)0, 3 },
                    { 455974, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bartın Merkez", 2759, (short)0, 3 },
                    { 456926, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kurucaşile", 2759, (short)0, 3 },
                    { 457879, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ulus", 2759, (short)0, 3 },
                    { 458833, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Amasra", 2759, (short)0, 3 },
                    { 459788, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ardahan Merkez", 2833, (short)0, 3 },
                    { 460744, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çıldır", 2833, (short)0, 3 },
                    { 461701, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Göle", 2833, (short)0, 3 },
                    { 462659, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hanak", 2833, (short)0, 3 },
                    { 463618, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Posof", 2833, (short)0, 3 },
                    { 464578, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Damal", 2833, (short)0, 3 },
                    { 451229, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İdil", 2686, (short)0, 3 },
                    { 375251, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Siverek", 2011, (short)0, 3 },
                    { 374389, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hilvan", 2011, (short)0, 3 },
                    { 373528, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Halfeti", 2011, (short)0, 3 },
                    { 294764, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Asarcık", 1543, (short)0, 3 },
                    { 295528, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "19 Mayıs", 1543, (short)0, 3 },
                    { 296293, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Salıpazarı", 1543, (short)0, 3 },
                    { 297059, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tekkeköy", 1543, (short)0, 3 },
                    { 297826, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ayvacık / Samsun", 1543, (short)0, 3 },
                    { 298594, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yakakent", 1543, (short)0, 3 },
                    { 299363, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Atakum", 1543, (short)0, 3 },
                    { 300133, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Canik", 1543, (short)0, 3 },
                    { 300904, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İlkadım", 1543, (short)0, 3 },
                    { 301676, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Baykan", 1598, (short)0, 3 },
                    { 302449, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Eruh", 1598, (short)0, 3 },
                    { 303223, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kurtalan", 1598, (short)0, 3 },
                    { 303998, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Pervari", 1598, (short)0, 3 },
                    { 304774, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Siirt Merkez", 1598, (short)0, 3 },
                    { 305551, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şirvan", 1598, (short)0, 3 },
                    { 306329, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tillo", 1598, (short)0, 3 },
                    { 307108, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ayancık", 1654, (short)0, 3 },
                    { 307888, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Boyabat", 1654, (short)0, 3 },
                    { 308669, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Durağan", 1654, (short)0, 3 },
                    { 309451, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Erfelek", 1654, (short)0, 3 },
                    { 310234, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gerze", 1654, (short)0, 3 },
                    { 311018, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sinop Merkez", 1654, (short)0, 3 },
                    { 311803, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Türkeli", 1654, (short)0, 3 },
                    { 312589, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Dikmen", 1654, (short)0, 3 },
                    { 313376, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Saraydüzü", 1654, (short)0, 3 },
                    { 314164, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Divriği", 1711, (short)0, 3 },
                    { 314953, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gemerek", 1711, (short)0, 3 },
                    { 315743, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gürün", 1711, (short)0, 3 },
                    { 316534, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hafik", 1711, (short)0, 3 },
                    { 294001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Vezirköprü", 1543, (short)0, 3 },
                    { 293239, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Terme", 1543, (short)0, 3 },
                    { 292478, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Samsun Merkez", 1543, (short)0, 3 },
                    { 291718, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ladik", 1543, (short)0, 3 },
                    { 269383, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İkizdere", 1436, (short)0, 3 },
                    { 270113, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kalkandere", 1436, (short)0, 3 },
                    { 270844, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Pazar / Rize", 1436, (short)0, 3 },
                    { 271576, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Rize Merkez", 1436, (short)0, 3 },
                    { 272309, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Güneysu", 1436, (short)0, 3 },
                    { 273043, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Derepazarı", 1436, (short)0, 3 },
                    { 273778, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hemşin", 1436, (short)0, 3 },
                    { 274514, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İyidere", 1436, (short)0, 3 },
                    { 275251, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Akyazı", 1489, (short)0, 3 },
                    { 275989, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Geyve", 1489, (short)0, 3 },
                    { 276728, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hendek", 1489, (short)0, 3 },
                    { 277468, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karasu", 1489, (short)0, 3 },
                    { 278209, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kaynarca", 1489, (short)0, 3 },
                    { 278951, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sakarya Merkez", 1489, (short)0, 3 },
                    { 317326, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İmranlı", 1711, (short)0, 3 },
                    { 279694, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sapanca", 1489, (short)0, 3 },
                    { 281183, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Pamukova", 1489, (short)0, 3 },
                    { 281929, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Taraklı", 1489, (short)0, 3 },
                    { 282676, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ferizli", 1489, (short)0, 3 },
                    { 283424, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karapürçek", 1489, (short)0, 3 },
                    { 284173, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Söğütlü", 1489, (short)0, 3 },
                    { 284923, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Adapazarı", 1489, (short)0, 3 },
                    { 285674, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Arifiye", 1489, (short)0, 3 },
                    { 286426, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Erenler", 1489, (short)0, 3 },
                    { 287179, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Serdivan", 1489, (short)0, 3 },
                    { 287933, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Alaçam", 1543, (short)0, 3 },
                    { 288688, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bafra", 1543, (short)0, 3 },
                    { 289444, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çarşamba", 1543, (short)0, 3 },
                    { 290201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Havza", 1543, (short)0, 3 },
                    { 290959, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kavak", 1543, (short)0, 3 },
                    { 280438, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kocaali", 1489, (short)0, 3 },
                    { 318119, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kangal", 1711, (short)0, 3 },
                    { 318913, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Koyulhisar", 1711, (short)0, 3 },
                    { 319708, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sivas Merkez", 1711, (short)0, 3 },
                    { 348163, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Araklı", 1888, (short)0, 3 },
                    { 348994, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Arsin", 1888, (short)0, 3 },
                    { 349826, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çaykara", 1888, (short)0, 3 },
                    { 350659, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Maçka", 1888, (short)0, 3 },
                    { 351493, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Of", 1888, (short)0, 3 },
                    { 352328, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sürmene", 1888, (short)0, 3 },
                    { 353164, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tonya", 1888, (short)0, 3 },
                    { 354001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Trabzon Merkez", 1888, (short)0, 3 },
                    { 354839, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Vakfıkebir", 1888, (short)0, 3 },
                    { 355678, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yomra", 1888, (short)0, 3 },
                    { 356518, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Beşikdüzü", 1888, (short)0, 3 },
                    { 357359, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şalpazarı", 1888, (short)0, 3 },
                    { 358201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çarşıbaşı", 1888, (short)0, 3 },
                    { 359044, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Dernekpazarı", 1888, (short)0, 3 },
                    { 347333, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Akçaabat", 1888, (short)0, 3 },
                    { 359888, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Düzköy", 1888, (short)0, 3 },
                    { 361579, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Köprübaşı / Trabzon", 1888, (short)0, 3 },
                    { 362426, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ortahisar", 1888, (short)0, 3 },
                    { 363274, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çemişgezek", 1949, (short)0, 3 },
                    { 364123, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hozat", 1949, (short)0, 3 },
                    { 364973, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mazgirt", 1949, (short)0, 3 },
                    { 365824, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Nazımiye", 1949, (short)0, 3 },
                    { 366676, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ovacık / Tunceli", 1949, (short)0, 3 },
                    { 367529, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Pertek", 1949, (short)0, 3 },
                    { 368383, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Pülümür", 1949, (short)0, 3 },
                    { 369238, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tunceli Merkez", 1949, (short)0, 3 },
                    { 370094, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Akçakale", 2011, (short)0, 3 },
                    { 370951, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Birecik", 2011, (short)0, 3 },
                    { 371809, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bozova", 2011, (short)0, 3 },
                    { 372668, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ceylanpınar", 2011, (short)0, 3 },
                    { 360733, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hayrat", 1888, (short)0, 3 },
                    { 267926, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çayeli", 1436, (short)0, 3 },
                    { 346504, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sulusaray", 1828, (short)0, 3 },
                    { 344849, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yeşilyurt / Tokat", 1828, (short)0, 3 },
                    { 320504, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Suşehri", 1711, (short)0, 3 },
                    { 321301, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şarkışla", 1711, (short)0, 3 },
                    { 322099, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yıldızeli", 1711, (short)0, 3 },
                    { 322898, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Zara", 1711, (short)0, 3 },
                    { 323698, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Akıncılar", 1711, (short)0, 3 },
                    { 324499, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Altınyayla / Sivas", 1711, (short)0, 3 },
                    { 325301, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Doğanşar", 1711, (short)0, 3 },
                    { 326104, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gölova", 1711, (short)0, 3 },
                    { 326908, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ulaş", 1711, (short)0, 3 },
                    { 327713, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çerkezköy", 1769, (short)0, 3 },
                    { 328519, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çorlu", 1769, (short)0, 3 },
                    { 329326, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hayrabolu", 1769, (short)0, 3 },
                    { 330134, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Malkara", 1769, (short)0, 3 },
                    { 330943, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Muratlı", 1769, (short)0, 3 },
                    { 345676, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Başçiftlik", 1828, (short)0, 3 },
                    { 331753, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Saray / Tekirdağ", 1769, (short)0, 3 },
                    { 333376, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tekirdağ Merkez", 1769, (short)0, 3 },
                    { 334189, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Marmaraereğlisi", 1769, (short)0, 3 },
                    { 335003, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ergene", 1769, (short)0, 3 }
                });

            migrationBuilder.InsertData(
                table: "LookupList",
                columns: new[] { "Id", "CreateDate", "CreatorId", "IsDeleted", "Isim", "ParentId", "Status", "Tip" },
                values: new object[,]
                {
                    { 335818, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kapaklı", 1769, (short)0, 3 },
                    { 336634, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Süleymanpaşa", 1769, (short)0, 3 },
                    { 337451, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Almus", 1828, (short)0, 3 },
                    { 338269, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Artova", 1828, (short)0, 3 },
                    { 339088, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Erbaa", 1828, (short)0, 3 },
                    { 339908, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Niksar", 1828, (short)0, 3 },
                    { 340729, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Reşadiye", 1828, (short)0, 3 },
                    { 341551, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tokat Merkez", 1828, (short)0, 3 },
                    { 342374, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Turhal", 1828, (short)0, 3 },
                    { 343198, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Zile", 1828, (short)0, 3 },
                    { 344023, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Pazar / Tokat", 1828, (short)0, 3 },
                    { 332564, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şarköy", 1769, (short)0, 3 },
                    { 108409, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Maltepe", 619, (short)0, 3 },
                    { 107951, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Güngören", 619, (short)0, 3 },
                    { 107494, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bahçelievler", 619, (short)0, 3 },
                    { 7393, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kaş", 79, (short)0, 3 },
                    { 7484, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Korkuteli", 79, (short)0, 3 },
                    { 7576, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kumluca", 79, (short)0, 3 },
                    { 7669, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Manavgat", 79, (short)0, 3 },
                    { 7763, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Serik", 79, (short)0, 3 },
                    { 7858, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Demre", 79, (short)0, 3 },
                    { 7954, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İbradı", 79, (short)0, 3 },
                    { 8051, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kemer / Antalya", 79, (short)0, 3 },
                    { 8149, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Aksu / Antalya", 79, (short)0, 3 },
                    { 8248, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Döşemealtı", 79, (short)0, 3 },
                    { 8348, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kepez", 79, (short)0, 3 },
                    { 8449, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Konyaaltı", 79, (short)0, 3 },
                    { 8551, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Muratpaşa", 79, (short)0, 3 },
                    { 8654, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ardanuç", 86, (short)0, 3 },
                    { 8758, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Arhavi", 86, (short)0, 3 },
                    { 8863, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Artvin Merkez", 86, (short)0, 3 },
                    { 8969, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Borçka", 86, (short)0, 3 },
                    { 9076, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hopa", 86, (short)0, 3 },
                    { 9184, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şavşat", 86, (short)0, 3 },
                    { 9293, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yusufeli", 86, (short)0, 3 },
                    { 9403, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Murgul", 86, (short)0, 3 },
                    { 9514, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kemalpaşa / Artvin", 86, (short)0, 3 },
                    { 9626, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Aydın Merkez", 94, (short)0, 3 },
                    { 9739, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bozdoğan", 94, (short)0, 3 },
                    { 9853, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çine", 94, (short)0, 3 },
                    { 9968, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Germencik", 94, (short)0, 3 },
                    { 10084, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karacasu", 94, (short)0, 3 },
                    { 10201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Koçarlı", 94, (short)0, 3 },
                    { 10319, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kuşadası", 94, (short)0, 3 },
                    { 7303, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gündoğmuş", 79, (short)0, 3 },
                    { 7214, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gazipaşa", 79, (short)0, 3 },
                    { 7126, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Finike", 79, (short)0, 3 },
                    { 7039, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Elmalı", 79, (short)0, 3 },
                    { 4894, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Taşova", 68, (short)0, 3 },
                    { 4951, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hamamözü", 68, (short)0, 3 },
                    { 5009, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Altındağ", 73, (short)0, 3 },
                    { 5068, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ayaş", 73, (short)0, 3 },
                    { 5128, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bala", 73, (short)0, 3 },
                    { 5189, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Beypazarı", 73, (short)0, 3 },
                    { 5251, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çamlıdere", 73, (short)0, 3 },
                    { 5314, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çankaya", 73, (short)0, 3 },
                    { 5378, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çubuk", 73, (short)0, 3 },
                    { 5443, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Elmadağ", 73, (short)0, 3 },
                    { 5509, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Güdül", 73, (short)0, 3 },
                    { 5576, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Haymana", 73, (short)0, 3 },
                    { 5644, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kalecik", 73, (short)0, 3 },
                    { 5713, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kızılcahamam", 73, (short)0, 3 },
                    { 10438, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kuyucak", 94, (short)0, 3 },
                    { 5783, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Nallıhan", 73, (short)0, 3 },
                    { 5926, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şereflikoçhisar", 73, (short)0, 3 },
                    { 5999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yenimahalle", 73, (short)0, 3 },
                    { 6073, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gölbaşı / Ankara", 73, (short)0, 3 },
                    { 6148, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Keçiören", 73, (short)0, 3 },
                    { 6224, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mamak", 73, (short)0, 3 },
                    { 6301, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sincan", 73, (short)0, 3 },
                    { 6379, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kazan", 73, (short)0, 3 },
                    { 6458, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Akyurt", 73, (short)0, 3 },
                    { 6538, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Etimesgut", 73, (short)0, 3 },
                    { 6619, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Evren", 73, (short)0, 3 },
                    { 6701, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Pursaklar", 73, (short)0, 3 },
                    { 6784, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Akseki", 79, (short)0, 3 },
                    { 6868, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Alanya", 79, (short)0, 3 },
                    { 6953, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Antalya Merkez", 79, (short)0, 3 },
                    { 5854, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Polatlı", 73, (short)0, 3 },
                    { 4838, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Suluova", 68, (short)0, 3 },
                    { 10558, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Nazilli", 94, (short)0, 3 },
                    { 10801, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sultanhisar", 94, (short)0, 3 },
                    { 15701, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yenipazar / Bilecik", 113, (short)0, 3 },
                    { 15859, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İnhisar", 113, (short)0, 3 },
                    { 16018, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bingöl Merkez", 124, (short)0, 3 },
                    { 16178, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Genç", 124, (short)0, 3 },
                    { 16339, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karlıova", 124, (short)0, 3 },
                    { 16501, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kiğı", 124, (short)0, 3 },
                    { 16664, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Solhan", 124, (short)0, 3 },
                    { 16828, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Adaklı", 124, (short)0, 3 },
                    { 16993, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yayladere", 124, (short)0, 3 },
                    { 17159, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yedisu", 124, (short)0, 3 },
                    { 17326, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Adilcevaz", 136, (short)0, 3 },
                    { 17494, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ahlat", 136, (short)0, 3 },
                    { 17663, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bitlis Merkez", 136, (short)0, 3 },
                    { 17833, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hizan", 136, (short)0, 3 },
                    { 18004, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mutki", 136, (short)0, 3 },
                    { 18176, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tatvan", 136, (short)0, 3 },
                    { 18349, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Güroymak", 136, (short)0, 3 },
                    { 18523, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bolu Merkez", 149, (short)0, 3 },
                    { 18698, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gerede", 149, (short)0, 3 },
                    { 18874, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Göynük", 149, (short)0, 3 },
                    { 19051, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kıbrıscık", 149, (short)0, 3 },
                    { 19229, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mengen", 149, (short)0, 3 },
                    { 19408, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mudurnu", 149, (short)0, 3 },
                    { 19588, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Seben", 149, (short)0, 3 },
                    { 19769, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Dörtdivan", 149, (short)0, 3 },
                    { 19951, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yeniçağa", 149, (short)0, 3 },
                    { 20134, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ağlasun", 163, (short)0, 3 },
                    { 20318, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bucak", 163, (short)0, 3 },
                    { 20503, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Burdur Merkez", 163, (short)0, 3 },
                    { 15544, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Söğüt", 113, (short)0, 3 },
                    { 15388, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Pazaryeri", 113, (short)0, 3 },
                    { 15233, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Osmaneli", 113, (short)0, 3 },
                    { 15079, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gölpazarı", 113, (short)0, 3 },
                    { 10924, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yenipazar / Aydın", 94, (short)0, 3 },
                    { 11048, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Buharkent", 94, (short)0, 3 },
                    { 11173, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İncirliova", 94, (short)0, 3 },
                    { 11299, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karpuzlu", 94, (short)0, 3 },
                    { 11426, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Köşk", 94, (short)0, 3 },
                    { 11554, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Didim", 94, (short)0, 3 },
                    { 11683, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Efeler", 94, (short)0, 3 },
                    { 11813, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ayvalık", 103, (short)0, 3 },
                    { 11944, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Balıkesir Merkez", 103, (short)0, 3 },
                    { 12076, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Balya", 103, (short)0, 3 },
                    { 12209, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bandırma", 103, (short)0, 3 },
                    { 12343, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bigadiç", 103, (short)0, 3 },
                    { 12478, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Burhaniye", 103, (short)0, 3 },
                    { 12614, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Dursunbey", 103, (short)0, 3 },
                    { 10679, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Söke", 94, (short)0, 3 },
                    { 12751, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Edremit / Balıkesir", 103, (short)0, 3 },
                    { 13028, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gönen / Balıkesir", 103, (short)0, 3 },
                    { 13168, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Havran", 103, (short)0, 3 },
                    { 13309, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İvrindi", 103, (short)0, 3 },
                    { 13451, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kepsut", 103, (short)0, 3 },
                    { 13594, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Manyas", 103, (short)0, 3 },
                    { 13738, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Savaştepe", 103, (short)0, 3 },
                    { 13883, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sındırgı", 103, (short)0, 3 },
                    { 14029, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Susurluk", 103, (short)0, 3 },
                    { 14176, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Marmara", 103, (short)0, 3 },
                    { 14324, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gömeç", 103, (short)0, 3 },
                    { 14473, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Altıeylül", 103, (short)0, 3 },
                    { 14623, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karesi", 103, (short)0, 3 },
                    { 14774, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bilecik Merkez", 113, (short)0, 3 },
                    { 14926, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bozüyük", 113, (short)0, 3 },
                    { 12889, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Erdek", 103, (short)0, 3 },
                    { 4783, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Merzifon", 68, (short)0, 3 },
                    { 4729, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gümüşhacıköy", 68, (short)0, 3 },
                    { 4676, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Göynücek", 68, (short)0, 3 },
                    { 688, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kars", null, (short)0, 2 },
                    { 724, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kastamonu", null, (short)0, 2 },
                    { 761, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kayseri", null, (short)0, 2 },
                    { 799, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kırklareli", null, (short)0, 2 },
                    { 838, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kırşehir", null, (short)0, 2 },
                    { 878, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kocaeli", null, (short)0, 2 },
                    { 919, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Konya", null, (short)0, 2 },
                    { 961, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kütahya", null, (short)0, 2 },
                    { 1004, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Malatya", null, (short)0, 2 },
                    { 1048, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Manisa", null, (short)0, 2 },
                    { 1093, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kahramanmaraş", null, (short)0, 2 },
                    { 1139, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mardin", null, (short)0, 2 },
                    { 1186, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Muğla", null, (short)0, 2 },
                    { 1234, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Muş", null, (short)0, 2 },
                    { 1283, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Nevşehir", null, (short)0, 2 },
                    { 1333, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Niğde", null, (short)0, 2 },
                    { 1384, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ordu", null, (short)0, 2 },
                    { 1436, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Rize", null, (short)0, 2 },
                    { 1489, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sakarya", null, (short)0, 2 },
                    { 1543, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Samsun", null, (short)0, 2 },
                    { 1598, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Siirt", null, (short)0, 2 },
                    { 1654, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sinop", null, (short)0, 2 },
                    { 1711, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sivas", null, (short)0, 2 },
                    { 1769, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tekirdağ", null, (short)0, 2 },
                    { 1828, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tokat", null, (short)0, 2 },
                    { 1888, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Trabzon", null, (short)0, 2 },
                    { 1949, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tunceli", null, (short)0, 2 },
                    { 2011, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şanlıurfa", null, (short)0, 2 },
                    { 2074, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Uşak", null, (short)0, 2 },
                    { 653, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İzmir", null, (short)0, 2 },
                    { 619, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İstanbul", null, (short)0, 2 },
                    { 586, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mersin", null, (short)0, 2 },
                    { 554, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Isparta", null, (short)0, 2 },
                    { 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Adıyaman", null, (short)0, 2 },
                    { 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Afyonkarahisar", null, (short)0, 2 },
                    { 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ağrı", null, (short)0, 2 },
                    { 68, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Amasya", null, (short)0, 2 },
                    { 73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ankara", null, (short)0, 2 },
                    { 79, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Antalya", null, (short)0, 2 },
                    { 86, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Artvin", null, (short)0, 2 },
                    { 94, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Aydın", null, (short)0, 2 },
                    { 103, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Balıkesir", null, (short)0, 2 },
                    { 113, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bilecik", null, (short)0, 2 },
                    { 124, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bingöl", null, (short)0, 2 },
                    { 136, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bitlis", null, (short)0, 2 },
                    { 149, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bolu", null, (short)0, 2 },
                    { 163, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Burdur", null, (short)0, 2 },
                    { 2138, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Van", null, (short)0, 2 },
                    { 178, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bursa", null, (short)0, 2 },
                    { 211, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çankırı", null, (short)0, 2 },
                    { 229, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çorum", null, (short)0, 2 },
                    { 248, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Denizli", null, (short)0, 2 },
                    { 268, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Diyarbakır", null, (short)0, 2 },
                    { 289, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Edirne", null, (short)0, 2 },
                    { 311, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Elazığ", null, (short)0, 2 },
                    { 334, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Erzincan", null, (short)0, 2 },
                    { 358, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Erzurum", null, (short)0, 2 },
                    { 383, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Eskişehir", null, (short)0, 2 },
                    { 409, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gaziantep", null, (short)0, 2 },
                    { 436, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Giresun", null, (short)0, 2 },
                    { 464, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gümüşhane", null, (short)0, 2 },
                    { 493, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hakkari", null, (short)0, 2 },
                    { 523, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hatay", null, (short)0, 2 },
                    { 194, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çanakkale", null, (short)0, 2 },
                    { 2203, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yozgat", null, (short)0, 2 },
                    { 2269, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Zonguldak", null, (short)0, 2 },
                    { 2336, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Aksaray", null, (short)0, 2 },
                    { 3551, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Samsat", 59, (short)0, 3 },
                    { 3574, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sincik", 59, (short)0, 3 },
                    { 3598, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tut", 59, (short)0, 3 },
                    { 3623, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Afyonkarahisar Merkez", 61, (short)0, 3 },
                    { 3649, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bolvadin", 61, (short)0, 3 },
                    { 3676, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çay", 61, (short)0, 3 },
                    { 3704, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Dazkırı", 61, (short)0, 3 },
                    { 3733, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Dinar", 61, (short)0, 3 },
                    { 3763, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Emirdağ", 61, (short)0, 3 },
                    { 3794, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İhsaniye", 61, (short)0, 3 },
                    { 3826, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sandıklı", 61, (short)0, 3 },
                    { 3859, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sinanpaşa", 61, (short)0, 3 },
                    { 3893, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sultandağı", 61, (short)0, 3 },
                    { 3928, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şuhut", 61, (short)0, 3 },
                    { 3529, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kahta", 59, (short)0, 3 },
                    { 3964, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Başmakçı", 61, (short)0, 3 },
                    { 4039, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İscehisar", 61, (short)0, 3 },
                    { 4078, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çobanlar", 61, (short)0, 3 },
                    { 4118, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Evciler", 61, (short)0, 3 },
                    { 4159, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hocalar", 61, (short)0, 3 },
                    { 4201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kızılören", 61, (short)0, 3 },
                    { 4244, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ağrı Merkez", 64, (short)0, 3 },
                    { 4288, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Diyadin", 64, (short)0, 3 },
                    { 4333, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Doğubayazıt", 64, (short)0, 3 },
                    { 4379, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Eleşkirt", 64, (short)0, 3 },
                    { 4426, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hamur", 64, (short)0, 3 },
                    { 4474, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Patnos", 64, (short)0, 3 },
                    { 4523, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Taşlıçay", 64, (short)0, 3 },
                    { 4573, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tutak", 64, (short)0, 3 },
                    { 4624, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Amasya Merkez", 68, (short)0, 3 },
                    { 4001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bayat / Afyonkarahisar", 61, (short)0, 3 },
                    { 20689, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gölhisar", 163, (short)0, 3 },
                    { 3508, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gölbaşı / Adıyaman", 59, (short)0, 3 },
                    { 3469, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çelikhan", 59, (short)0, 3 },
                    { 2404, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bayburt", null, (short)0, 2 },
                    { 2473, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karaman", null, (short)0, 2 },
                    { 2543, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kırıkkale", null, (short)0, 2 },
                    { 2614, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Batman", null, (short)0, 2 },
                    { 2686, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şırnak", null, (short)0, 2 },
                    { 2759, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bartın", null, (short)0, 2 },
                    { 2833, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ardahan", null, (short)0, 2 },
                    { 2908, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Iğdır", null, (short)0, 2 },
                    { 2984, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yalova", null, (short)0, 2 },
                    { 3061, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karabük", null, (short)0, 2 },
                    { 3139, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kilis", null, (short)0, 2 },
                    { 3218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Osmaniye", null, (short)0, 2 }
                });

            migrationBuilder.InsertData(
                table: "LookupList",
                columns: new[] { "Id", "CreateDate", "CreatorId", "IsDeleted", "Isim", "ParentId", "Status", "Tip" },
                values: new object[,]
                {
                    { 3298, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Düzce", null, (short)0, 2 },
                    { 3299, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Seyhan", 58, (short)0, 3 },
                    { 3488, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gerger", 59, (short)0, 3 },
                    { 3301, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ceyhan", 58, (short)0, 3 },
                    { 3308, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karaisalı", 58, (short)0, 3 },
                    { 3313, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karataş", 58, (short)0, 3 },
                    { 3319, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kozan", 58, (short)0, 3 },
                    { 3326, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Pozantı", 58, (short)0, 3 },
                    { 3334, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Saimbeyli", 58, (short)0, 3 },
                    { 3343, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tufanbeyli", 58, (short)0, 3 },
                    { 3353, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yumurtalık", 58, (short)0, 3 },
                    { 3364, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yüreğir", 58, (short)0, 3 },
                    { 3376, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Aladağ", 58, (short)0, 3 },
                    { 3389, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İmamoğlu", 58, (short)0, 3 },
                    { 3403, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sarıçam", 58, (short)0, 3 },
                    { 3418, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çukurova", 58, (short)0, 3 },
                    { 3434, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Adıyaman Merkez", 59, (short)0, 3 },
                    { 3451, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Besni", 59, (short)0, 3 },
                    { 3304, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Feke", 58, (short)0, 3 },
                    { 20876, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tefenni", 163, (short)0, 3 },
                    { 21064, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yeşilova", 163, (short)0, 3 },
                    { 21253, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karamanlı", 163, (short)0, 3 },
                    { 67918, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karkamış", 409, (short)0, 3 },
                    { 68278, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Nurdağı", 409, (short)0, 3 },
                    { 68639, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Alucra", 436, (short)0, 3 },
                    { 69001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bulancak", 436, (short)0, 3 },
                    { 69364, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Dereli", 436, (short)0, 3 },
                    { 69728, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Espiye", 436, (short)0, 3 },
                    { 70093, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Eynesil", 436, (short)0, 3 },
                    { 70459, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Giresun Merkez", 436, (short)0, 3 },
                    { 70826, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Görele", 436, (short)0, 3 },
                    { 71194, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Keşap", 436, (short)0, 3 },
                    { 71563, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şebinkarahisar", 436, (short)0, 3 },
                    { 71933, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tirebolu", 436, (short)0, 3 },
                    { 72304, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Piraziz", 436, (short)0, 3 },
                    { 72676, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yağlıdere", 436, (short)0, 3 },
                    { 73049, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çamoluk", 436, (short)0, 3 },
                    { 73423, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çanakçı", 436, (short)0, 3 },
                    { 73798, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Doğankent", 436, (short)0, 3 },
                    { 74174, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Güce", 436, (short)0, 3 },
                    { 74551, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gümüşhane Merkez", 464, (short)0, 3 },
                    { 74929, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kelkit", 464, (short)0, 3 },
                    { 75308, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şiran", 464, (short)0, 3 },
                    { 75688, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Torul", 464, (short)0, 3 },
                    { 76069, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Köse", 464, (short)0, 3 },
                    { 76451, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kürtün", 464, (short)0, 3 },
                    { 76834, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çukurca", 493, (short)0, 3 },
                    { 77218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hakkari Merkez", 493, (short)0, 3 },
                    { 77603, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şemdinli", 493, (short)0, 3 },
                    { 77989, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yüksekova", 493, (short)0, 3 },
                    { 78376, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Altınözü", 523, (short)0, 3 },
                    { 67559, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şehitkamil", 409, (short)0, 3 },
                    { 67201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şahinbey", 409, (short)0, 3 },
                    { 66844, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yavuzeli", 409, (short)0, 3 },
                    { 66488, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Oğuzeli", 409, (short)0, 3 },
                    { 56273, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Olur", 358, (short)0, 3 },
                    { 56599, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Pasinler", 358, (short)0, 3 },
                    { 56926, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şenkaya", 358, (short)0, 3 },
                    { 57254, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tekman", 358, (short)0, 3 },
                    { 57583, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tortum", 358, (short)0, 3 },
                    { 57913, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karaçoban", 358, (short)0, 3 },
                    { 58244, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Uzundere", 358, (short)0, 3 },
                    { 58576, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Pazaryolu", 358, (short)0, 3 },
                    { 58909, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Aziziye", 358, (short)0, 3 },
                    { 59243, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Köprüköy", 358, (short)0, 3 },
                    { 59578, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Palandöken", 358, (short)0, 3 },
                    { 59914, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yakutiye", 358, (short)0, 3 },
                    { 60251, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çifteler", 383, (short)0, 3 },
                    { 60589, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Eskişehir Merkez", 383, (short)0, 3 },
                    { 78764, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Dörtyol", 523, (short)0, 3 },
                    { 60928, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mahmudiye", 383, (short)0, 3 },
                    { 61609, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sarıcakaya", 383, (short)0, 3 },
                    { 61951, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Seyitgazi", 383, (short)0, 3 },
                    { 62294, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sivrihisar", 383, (short)0, 3 },
                    { 62638, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Alpu", 383, (short)0, 3 },
                    { 62983, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Beylikova", 383, (short)0, 3 },
                    { 63329, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İnönü", 383, (short)0, 3 },
                    { 63676, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Günyüzü", 383, (short)0, 3 },
                    { 64024, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Han", 383, (short)0, 3 },
                    { 64373, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mihalgazi", 383, (short)0, 3 },
                    { 64723, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Odunpazarı", 383, (short)0, 3 },
                    { 65074, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tepebaşı", 383, (short)0, 3 },
                    { 65426, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Araban", 409, (short)0, 3 },
                    { 65779, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İslahiye", 409, (short)0, 3 },
                    { 66133, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Nizip", 409, (short)0, 3 },
                    { 61268, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mihalıççık", 383, (short)0, 3 },
                    { 79153, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hassa", 523, (short)0, 3 },
                    { 79543, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hatay Merkez", 523, (short)0, 3 },
                    { 79934, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İskenderun", 523, (short)0, 3 },
                    { 94249, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Akdeniz", 586, (short)0, 3 },
                    { 94676, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mezitli", 586, (short)0, 3 },
                    { 95104, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Toroslar", 586, (short)0, 3 },
                    { 95533, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yenişehir / Mersin", 586, (short)0, 3 },
                    { 95963, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Adalar", 619, (short)0, 3 },
                    { 96394, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bakırköy", 619, (short)0, 3 },
                    { 96826, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Beşiktaş", 619, (short)0, 3 },
                    { 97259, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Beykoz", 619, (short)0, 3 },
                    { 97693, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Beyoğlu", 619, (short)0, 3 },
                    { 98128, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çatalca", 619, (short)0, 3 },
                    { 98564, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Eminönü", 619, (short)0, 3 },
                    { 99001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Eyüp", 619, (short)0, 3 },
                    { 99439, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Fatih", 619, (short)0, 3 },
                    { 99878, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gaziosmanpaşa", 619, (short)0, 3 },
                    { 93823, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çamlıyayla", 586, (short)0, 3 },
                    { 100318, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kadıköy", 619, (short)0, 3 },
                    { 101201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sarıyer", 619, (short)0, 3 },
                    { 101644, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Silivri", 619, (short)0, 3 },
                    { 102088, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şile", 619, (short)0, 3 },
                    { 102533, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şişli", 619, (short)0, 3 },
                    { 102979, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Üsküdar", 619, (short)0, 3 },
                    { 103426, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Zeytinburnu", 619, (short)0, 3 },
                    { 103874, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Büyükçekmece", 619, (short)0, 3 },
                    { 104323, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kağıthane", 619, (short)0, 3 },
                    { 104773, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Küçükçekmece", 619, (short)0, 3 },
                    { 105224, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Pendik", 619, (short)0, 3 },
                    { 105676, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ümraniye", 619, (short)0, 3 },
                    { 106129, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bayrampaşa", 619, (short)0, 3 },
                    { 106583, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Avcılar", 619, (short)0, 3 },
                    { 107038, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bağcılar", 619, (short)0, 3 },
                    { 100759, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kartal", 619, (short)0, 3 },
                    { 55948, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Oltu", 358, (short)0, 3 },
                    { 93398, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bozyazı", 586, (short)0, 3 },
                    { 92551, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tarsus", 586, (short)0, 3 },
                    { 80326, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kırıkhan", 523, (short)0, 3 },
                    { 80719, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Reyhanlı", 523, (short)0, 3 },
                    { 81113, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Samandağ", 523, (short)0, 3 },
                    { 81508, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yayladağı", 523, (short)0, 3 },
                    { 81904, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Erzin", 523, (short)0, 3 },
                    { 82301, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Belen", 523, (short)0, 3 },
                    { 82699, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kumlu", 523, (short)0, 3 },
                    { 83098, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Antakya", 523, (short)0, 3 },
                    { 83498, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Arsuz", 523, (short)0, 3 },
                    { 83899, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Defne", 523, (short)0, 3 },
                    { 84301, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Payas", 523, (short)0, 3 },
                    { 84704, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Atabey", 554, (short)0, 3 },
                    { 85108, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Eğirdir", 554, (short)0, 3 },
                    { 85513, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gelendost", 554, (short)0, 3 },
                    { 92974, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Aydıncık / Mersin", 586, (short)0, 3 },
                    { 85919, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Isparta Merkez", 554, (short)0, 3 },
                    { 86734, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Senirkent", 554, (short)0, 3 },
                    { 87143, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sütçüler", 554, (short)0, 3 },
                    { 87553, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şarkikaraağaç", 554, (short)0, 3 },
                    { 87964, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Uluborlu", 554, (short)0, 3 },
                    { 88376, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yalvaç", 554, (short)0, 3 },
                    { 88789, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Aksu / Isparta", 554, (short)0, 3 },
                    { 89203, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gönen / Isparta", 554, (short)0, 3 },
                    { 89618, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yenişarbademli", 554, (short)0, 3 },
                    { 90034, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Anamur", 586, (short)0, 3 },
                    { 90451, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Erdemli", 586, (short)0, 3 },
                    { 90869, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gülnar", 586, (short)0, 3 },
                    { 91288, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mersin Merkez", 586, (short)0, 3 },
                    { 91708, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mut", 586, (short)0, 3 },
                    { 92129, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Silifke", 586, (short)0, 3 },
                    { 86326, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Keçiborlu", 554, (short)0, 3 },
                    { 497813, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gümüşova", 3298, (short)0, 3 },
                    { 55624, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Narman", 358, (short)0, 3 },
                    { 54979, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İspir", 358, (short)0, 3 },
                    { 28498, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çerkeş", 211, (short)0, 3 },
                    { 28723, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Eldivan", 211, (short)0, 3 },
                    { 28949, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ilgaz", 211, (short)0, 3 },
                    { 29176, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kurşunlu", 211, (short)0, 3 },
                    { 29404, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Orta", 211, (short)0, 3 },
                    { 29633, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Şabanözü", 211, (short)0, 3 },
                    { 29863, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yapraklı", 211, (short)0, 3 },
                    { 30094, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Atkaracalar", 211, (short)0, 3 },
                    { 30326, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kızılırmak", 211, (short)0, 3 },
                    { 30559, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bayramören", 211, (short)0, 3 },
                    { 30793, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Korgun", 211, (short)0, 3 },
                    { 31028, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Alaca", 229, (short)0, 3 },
                    { 31264, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bayat / Çorum", 229, (short)0, 3 },
                    { 31501, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çorum Merkez", 229, (short)0, 3 },
                    { 31739, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İskilip", 229, (short)0, 3 },
                    { 31978, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kargı", 229, (short)0, 3 },
                    { 32218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mecitözü", 229, (short)0, 3 },
                    { 32459, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ortaköy / Çorum", 229, (short)0, 3 },
                    { 32701, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Osmancık", 229, (short)0, 3 },
                    { 32944, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sungurlu", 229, (short)0, 3 },
                    { 33188, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Boğazkale", 229, (short)0, 3 },
                    { 33433, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Uğurludağ", 229, (short)0, 3 },
                    { 33679, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Dodurga", 229, (short)0, 3 },
                    { 33926, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Laçin", 229, (short)0, 3 },
                    { 34174, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Oğuzlar", 229, (short)0, 3 },
                    { 34423, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Acıpayam", 248, (short)0, 3 },
                    { 34673, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Buldan", 248, (short)0, 3 },
                    { 34924, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çal", 248, (short)0, 3 },
                    { 35176, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çameli", 248, (short)0, 3 },
                    { 28274, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çankırı Merkez", 211, (short)0, 3 },
                    { 28051, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yenice / Çanakkale", 194, (short)0, 3 },
                    { 27829, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Lapseki", 194, (short)0, 3 },
                    { 27608, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gökçeada", 194, (short)0, 3 },
                    { 21443, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kemer / Burdur", 163, (short)0, 3 },
                    { 21634, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Altınyayla / Burdur", 163, (short)0, 3 },
                    { 21826, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çavdır", 163, (short)0, 3 },
                    { 22019, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çeltikçi", 163, (short)0, 3 },
                    { 22213, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gemlik", 178, (short)0, 3 },
                    { 22408, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İnegöl", 178, (short)0, 3 },
                    { 22604, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İznik", 178, (short)0, 3 },
                    { 22801, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karacabey", 178, (short)0, 3 },
                    { 22999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Keles", 178, (short)0, 3 },
                    { 23198, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mudanya", 178, (short)0, 3 },
                    { 23398, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mustafakemalpaşa", 178, (short)0, 3 },
                    { 23599, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Orhaneli", 178, (short)0, 3 },
                    { 23801, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Orhangazi", 178, (short)0, 3 },
                    { 24004, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yenişehir / Bursa", 178, (short)0, 3 },
                    { 35429, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çardak", 248, (short)0, 3 },
                    { 24208, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Büyükorhan", 178, (short)0, 3 },
                    { 24619, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Nilüfer", 178, (short)0, 3 },
                    { 24826, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Osmangazi", 178, (short)0, 3 },
                    { 25034, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yıldırım", 178, (short)0, 3 },
                    { 25243, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gürsu", 178, (short)0, 3 },
                    { 25453, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kestel", 178, (short)0, 3 },
                    { 25664, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ayvacık / Çanakkale", 194, (short)0, 3 },
                    { 25876, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bayramiç", 194, (short)0, 3 },
                    { 26089, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Biga", 194, (short)0, 3 },
                    { 26303, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bozcaada", 194, (short)0, 3 },
                    { 26518, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çan", 194, (short)0, 3 },
                    { 26734, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çanakkale Merkez", 194, (short)0, 3 },
                    { 26951, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Eceabat", 194, (short)0, 3 },
                    { 27169, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ezine", 194, (short)0, 3 },
                    { 27388, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Gelibolu", 194, (short)0, 3 },
                    { 24413, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Harmancık", 178, (short)0, 3 },
                    { 35683, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çivril", 248, (short)0, 3 },
                    { 35938, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Denizli Merkez", 248, (short)0, 3 },
                    { 36194, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Güney", 248, (short)0, 3 },
                    { 45784, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Keşan", 289, (short)0, 3 },
                    { 46076, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Lalapaşa", 289, (short)0, 3 },
                    { 46369, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Meriç", 289, (short)0, 3 },
                    { 46663, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Uzunköprü", 289, (short)0, 3 },
                    { 46958, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Süloğlu", 289, (short)0, 3 },
                    { 47254, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ağın", 311, (short)0, 3 },
                    { 47551, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Baskil", 311, (short)0, 3 },
                    { 47849, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Elazığ Merkez", 311, (short)0, 3 },
                    { 48148, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karakoçan", 311, (short)0, 3 },
                    { 48448, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Keban", 311, (short)0, 3 },
                    { 48749, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Maden", 311, (short)0, 3 },
                    { 49051, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Palu", 311, (short)0, 3 },
                    { 49354, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sivrice", 311, (short)0, 3 },
                    { 49658, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Arıcak", 311, (short)0, 3 },
                    { 45493, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İpsala", 289, (short)0, 3 },
                    { 49963, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kovancılar", 311, (short)0, 3 },
                    { 50576, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çayırlı", 334, (short)0, 3 },
                    { 50884, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Erzincan Merkez", 334, (short)0, 3 },
                    { 51193, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "İliç", 334, (short)0, 3 },
                    { 51503, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kemah", 334, (short)0, 3 },
                    { 51814, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kemaliye", 334, (short)0, 3 },
                    { 52126, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Refahiye", 334, (short)0, 3 },
                    { 52439, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tercan", 334, (short)0, 3 },
                    { 52753, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Üzümlü", 334, (short)0, 3 },
                    { 53068, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Otlukbeli", 334, (short)0, 3 },
                    { 53384, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Aşkale", 358, (short)0, 3 },
                    { 53701, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çat", 358, (short)0, 3 },
                    { 54019, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Erzurum Merkez", 358, (short)0, 3 },
                    { 54338, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hınıs", 358, (short)0, 3 },
                    { 54658, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Horasan", 358, (short)0, 3 },
                    { 50269, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Alacakaya", 311, (short)0, 3 },
                    { 55301, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Karayazı", 358, (short)0, 3 },
                    { 45203, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Havsa", 289, (short)0, 3 },
                    { 44626, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Edirne Merkez", 289, (short)0, 3 },
                    { 36451, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kale / Denizli", 248, (short)0, 3 },
                    { 36709, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sarayköy", 248, (short)0, 3 },
                    { 36968, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tavas", 248, (short)0, 3 },
                    { 37228, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Babadağ", 248, (short)0, 3 }
                });

            migrationBuilder.InsertData(
                table: "LookupList",
                columns: new[] { "Id", "CreateDate", "CreatorId", "IsDeleted", "Isim", "ParentId", "Status", "Tip" },
                values: new object[,]
                {
                    { 37489, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bekilli", 248, (short)0, 3 },
                    { 37751, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Honaz", 248, (short)0, 3 },
                    { 38014, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Serinhisar", 248, (short)0, 3 },
                    { 38278, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Pamukkale", 248, (short)0, 3 },
                    { 38543, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Baklan", 248, (short)0, 3 },
                    { 38809, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Beyağaç", 248, (short)0, 3 },
                    { 39076, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bozkurt / Denizli", 248, (short)0, 3 },
                    { 39344, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Merkezefendi", 248, (short)0, 3 },
                    { 39613, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bismil", 268, (short)0, 3 },
                    { 39883, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çermik", 268, (short)0, 3 },
                    { 44914, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Enez", 289, (short)0, 3 },
                    { 40154, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çınar", 268, (short)0, 3 },
                    { 40699, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Dicle", 268, (short)0, 3 },
                    { 40973, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Diyarbakır Merkez", 268, (short)0, 3 },
                    { 41248, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Ergani", 268, (short)0, 3 },
                    { 41524, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hani", 268, (short)0, 3 },
                    { 41801, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Hazro", 268, (short)0, 3 },
                    { 42079, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kulp", 268, (short)0, 3 },
                    { 42358, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Lice", 268, (short)0, 3 },
                    { 42638, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Silvan", 268, (short)0, 3 },
                    { 42919, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Eğil", 268, (short)0, 3 },
                    { 43201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kocaköy", 268, (short)0, 3 },
                    { 43484, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bağlar", 268, (short)0, 3 },
                    { 43768, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kayapınar", 268, (short)0, 3 },
                    { 44053, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Sur", 268, (short)0, 3 },
                    { 44339, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yenişehir / Diyarbakır", 268, (short)0, 3 },
                    { 40426, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Çüngüş", 268, (short)0, 3 },
                    { 498808, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Kaynaşlı", 3298, (short)0, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arac_MarkaId",
                table: "Arac",
                column: "MarkaId");

            migrationBuilder.CreateIndex(
                name: "IX_Arac_YakitId",
                table: "Arac",
                column: "YakitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arac_LookupList_MarkaId",
                table: "Arac",
                column: "MarkaId",
                principalTable: "LookupList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Arac_LookupList_YakitId",
                table: "Arac",
                column: "YakitId",
                principalTable: "LookupList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arac_LookupList_MarkaId",
                table: "Arac");

            migrationBuilder.DropForeignKey(
                name: "FK_Arac_LookupList_YakitId",
                table: "Arac");

            migrationBuilder.DropIndex(
                name: "IX_Arac_MarkaId",
                table: "Arac");

            migrationBuilder.DropIndex(
                name: "IX_Arac_YakitId",
                table: "Arac");

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 1436);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 1489);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 1543);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 1598);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 1654);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 1711);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 1769);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 1828);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 1888);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 1949);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 2074);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 2138);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 2203);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 2269);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 2336);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 2404);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 2473);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 2543);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 2614);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 2686);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 2759);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 2833);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 2908);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 2984);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3061);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3139);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3218);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3298);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3299);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3301);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3304);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3308);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3313);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3319);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3326);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3334);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3343);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3353);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3364);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3376);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3389);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3403);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3418);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3434);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3451);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3469);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3488);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3508);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3529);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3551);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3574);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3598);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3623);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3649);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3676);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3704);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3733);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3763);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3794);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3826);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3859);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3893);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3928);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 3964);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4001);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4039);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4078);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4118);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4159);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4201);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4244);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4288);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4333);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4379);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4426);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4474);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4523);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4573);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4624);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4676);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4729);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4783);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4838);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4894);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 4951);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 5009);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 5068);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 5128);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 5189);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 5251);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 5314);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 5378);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 5443);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 5509);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 5576);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 5644);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 5713);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 5783);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 5854);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 5926);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 5999);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 6073);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 6148);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 6224);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 6301);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 6379);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 6458);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 6538);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 6619);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 6701);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 6784);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 6868);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 6953);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 7039);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 7126);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 7214);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 7303);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 7393);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 7484);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 7576);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 7669);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 7763);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 7858);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 7954);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 8051);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 8149);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 8248);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 8348);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 8449);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 8551);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 8654);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 8758);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 8863);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 8969);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 9076);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 9184);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 9293);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 9403);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 9514);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 9626);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 9739);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 9853);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 9968);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 10084);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 10201);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 10319);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 10438);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 10558);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 10679);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 10801);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 10924);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 11048);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 11173);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 11299);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 11426);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 11554);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 11683);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 11813);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 11944);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 12076);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 12209);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 12343);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 12478);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 12614);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 12751);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 12889);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 13028);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 13168);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 13309);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 13451);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 13594);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 13738);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 13883);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 14029);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 14176);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 14324);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 14473);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 14623);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 14774);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 14926);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 15079);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 15233);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 15388);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 15544);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 15701);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 15859);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 16018);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 16178);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 16339);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 16501);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 16664);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 16828);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 16993);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 17159);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 17326);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 17494);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 17663);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 17833);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 18004);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 18176);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 18349);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 18523);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 18698);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 18874);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 19051);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 19229);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 19408);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 19588);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 19769);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 19951);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 20134);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 20318);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 20503);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 20689);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 20876);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 21064);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 21253);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 21443);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 21634);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 21826);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 22019);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 22213);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 22408);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 22604);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 22801);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 22999);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 23198);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 23398);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 23599);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 23801);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 24004);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 24208);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 24413);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 24619);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 24826);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 25034);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 25243);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 25453);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 25664);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 25876);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 26089);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 26303);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 26518);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 26734);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 26951);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 27169);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 27388);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 27608);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 27829);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 28051);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 28274);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 28498);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 28723);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 28949);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 29176);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 29404);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 29633);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 29863);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 30094);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 30326);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 30559);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 30793);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 31028);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 31264);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 31501);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 31739);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 31978);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 32218);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 32459);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 32701);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 32944);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 33188);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 33433);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 33679);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 33926);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 34174);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 34423);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 34673);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 34924);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 35176);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 35429);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 35683);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 35938);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 36194);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 36451);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 36709);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 36968);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 37228);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 37489);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 37751);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 38014);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 38278);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 38543);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 38809);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 39076);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 39344);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 39613);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 39883);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 40154);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 40426);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 40699);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 40973);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 41248);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 41524);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 41801);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 42079);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 42358);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 42638);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 42919);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 43201);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 43484);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 43768);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 44053);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 44339);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 44626);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 44914);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 45203);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 45493);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 45784);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 46076);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 46369);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 46663);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 46958);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 47254);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 47551);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 47849);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 48148);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 48448);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 48749);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 49051);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 49354);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 49658);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 49963);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 50269);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 50576);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 50884);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 51193);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 51503);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 51814);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 52126);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 52439);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 52753);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 53068);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 53384);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 53701);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 54019);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 54338);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 54658);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 54979);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 55301);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 55624);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 55948);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 56273);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 56599);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 56926);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 57254);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 57583);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 57913);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 58244);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 58576);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 58909);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 59243);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 59578);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 59914);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 60251);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 60589);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 60928);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 61268);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 61609);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 61951);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 62294);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 62638);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 62983);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 63329);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 63676);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 64024);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 64373);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 64723);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 65074);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 65426);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 65779);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 66133);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 66488);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 66844);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 67201);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 67559);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 67918);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 68278);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 68639);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 69001);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 69364);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 69728);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 70093);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 70459);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 70826);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 71194);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 71563);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 71933);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 72304);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 72676);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 73049);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 73423);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 73798);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 74174);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 74551);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 74929);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 75308);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 75688);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 76069);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 76451);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 76834);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 77218);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 77603);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 77989);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 78376);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 78764);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 79153);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 79543);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 79934);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 80326);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 80719);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 81113);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 81508);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 81904);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 82301);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 82699);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 83098);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 83498);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 83899);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 84301);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 84704);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 85108);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 85513);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 85919);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 86326);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 86734);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 87143);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 87553);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 87964);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 88376);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 88789);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 89203);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 89618);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 90034);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 90451);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 90869);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 91288);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 91708);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 92129);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 92551);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 92974);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 93398);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 93823);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 94249);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 94676);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 95104);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 95533);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 95963);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 96394);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 96826);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 97259);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 97693);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 98128);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 98564);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 99001);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 99439);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 99878);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 100318);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 100759);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 101201);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 101644);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 102088);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 102533);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 102979);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 103426);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 103874);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 104323);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 104773);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 105224);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 105676);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 106129);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 106583);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 107038);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 107494);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 107951);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 108409);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 108868);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 109328);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 109789);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 110251);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 110714);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 111178);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 111643);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 112109);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 112576);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 113044);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 113513);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 113983);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 114454);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 114926);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 115399);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 115873);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 116348);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 116824);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 117301);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 117779);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 118258);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 118738);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 119219);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 119701);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 120184);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 120668);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 121153);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 121639);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 122126);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 122614);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 123103);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 123593);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 124084);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 124576);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 125069);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 125563);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 126058);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 126554);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 127051);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 127549);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 128048);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 128548);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 129049);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 129551);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 130054);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 130558);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 131063);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 131569);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 132076);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 132584);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 133093);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 133603);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 134114);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 134626);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 135139);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 135653);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 136168);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 136684);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 137201);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 137719);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 138238);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 138758);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 139279);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 139801);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 140324);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 140848);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 141373);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 141899);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 142426);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 142954);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 143483);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 144013);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 144544);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 145076);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 145609);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 146143);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 146678);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 147214);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 147751);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 148289);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 148828);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 149368);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 149909);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 150451);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 150994);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 151538);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 152083);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 152629);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 153176);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 153724);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 154273);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 154823);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 155374);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 155926);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 156479);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 157033);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 157588);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 158144);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 158701);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 159259);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 159818);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 160378);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 160939);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 161501);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 162064);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 162628);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 163193);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 163759);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 164326);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 164894);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 165463);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 166033);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 166604);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 167176);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 167749);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 168323);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 168898);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 169474);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 170051);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 170629);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 171208);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 171788);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 172369);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 172951);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 173534);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 174118);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 174703);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 175289);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 175876);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 176464);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 177053);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 177643);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 178234);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 178826);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 179419);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 180013);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 180608);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 181204);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 181801);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 182399);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 182998);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 183598);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 184199);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 184801);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 185404);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 186008);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 186613);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 187219);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 187826);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 188434);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 189043);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 189653);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 190264);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 190876);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 191489);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 192103);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 192718);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 193334);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 193951);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 194569);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 195188);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 195808);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 196429);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 197051);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 197674);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 198298);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 198923);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 199549);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 200176);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 200804);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 201433);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 202063);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 202694);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 203326);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 203959);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 204593);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 205228);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 205864);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 206501);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 207139);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 207778);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 208418);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 209059);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 209701);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 210344);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 210988);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 211633);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 212279);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 212926);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 213574);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 214223);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 214873);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 215524);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 216176);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 216829);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 217483);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 218138);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 218794);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 219451);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 220109);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 220768);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 221428);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 222089);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 222751);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 223414);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 224078);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 224743);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 225409);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 226076);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 226744);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 227413);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 228083);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 228754);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 229426);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 230099);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 230773);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 231448);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 232124);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 232801);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 233479);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 234158);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 234838);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 235519);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 236201);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 236884);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 237568);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 238253);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 238939);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 239626);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 240314);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 241003);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 241693);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 242384);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 243076);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 243769);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 244463);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 245158);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 245854);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 246551);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 247249);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 247948);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 248648);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 249349);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 250051);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 250754);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 251458);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 252163);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 252869);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 253576);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 254284);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 254993);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 255703);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 256414);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 257126);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 257839);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 258553);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 259268);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 259984);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 260701);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 261419);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 262138);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 262858);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 263579);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 264301);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 265024);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 265748);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 266473);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 267199);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 267926);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 268654);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 269383);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 270113);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 270844);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 271576);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 272309);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 273043);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 273778);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 274514);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 275251);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 275989);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 276728);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 277468);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 278209);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 278951);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 279694);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 280438);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 281183);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 281929);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 282676);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 283424);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 284173);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 284923);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 285674);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 286426);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 287179);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 287933);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 288688);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 289444);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 290201);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 290959);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 291718);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 292478);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 293239);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 294001);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 294764);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 295528);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 296293);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 297059);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 297826);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 298594);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 299363);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 300133);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 300904);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 301676);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 302449);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 303223);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 303998);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 304774);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 305551);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 306329);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 307108);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 307888);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 308669);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 309451);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 310234);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 311018);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 311803);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 312589);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 313376);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 314164);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 314953);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 315743);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 316534);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 317326);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 318119);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 318913);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 319708);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 320504);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 321301);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 322099);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 322898);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 323698);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 324499);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 325301);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 326104);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 326908);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 327713);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 328519);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 329326);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 330134);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 330943);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 331753);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 332564);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 333376);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 334189);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 335003);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 335818);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 336634);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 337451);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 338269);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 339088);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 339908);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 340729);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 341551);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 342374);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 343198);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 344023);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 344849);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 345676);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 346504);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 347333);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 348163);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 348994);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 349826);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 350659);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 351493);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 352328);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 353164);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 354001);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 354839);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 355678);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 356518);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 357359);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 358201);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 359044);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 359888);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 360733);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 361579);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 362426);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 363274);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 364123);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 364973);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 365824);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 366676);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 367529);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 368383);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 369238);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 370094);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 370951);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 371809);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 372668);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 373528);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 374389);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 375251);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 376114);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 376978);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 377843);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 378709);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 379576);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 380444);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 381313);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 382183);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 383054);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 383926);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 384799);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 385673);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 386548);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 387424);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 388301);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 389179);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 390058);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 390938);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 391819);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 392701);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 393584);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 394468);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 395353);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 396239);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 397126);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 398014);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 398903);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 399793);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 400684);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 401576);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 402469);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 403363);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 404258);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 405154);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 406051);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 406949);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 407848);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 408748);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 409649);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 410551);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 411454);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 412358);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 413263);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 414169);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 415076);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 415984);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 416893);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 417803);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 418714);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 419626);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 420539);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 421453);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 422368);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 423284);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 424201);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 425119);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 426038);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 426958);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 427879);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 428801);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 429724);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 430648);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 431573);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 432499);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 433426);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 434354);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 435283);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 436213);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 437144);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 438076);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 439009);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 439943);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 440878);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 441814);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 442751);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 443689);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 444628);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 445568);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 446509);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 447451);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 448394);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 449338);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 450283);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 451229);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 452176);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 453124);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 454073);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 455023);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 455974);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 456926);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 457879);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 458833);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 459788);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 460744);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 461701);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 462659);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 463618);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 464578);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 465539);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 466501);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 467464);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 468428);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 469393);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 470359);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 471326);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 472294);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 473263);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 474233);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 475204);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 476176);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 477149);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 478123);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 479098);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 480074);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 481051);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 482029);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 483008);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 483988);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 484969);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 485951);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 486934);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 487918);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 488903);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 489889);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 490876);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 491864);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 492853);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 493843);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 494834);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 495826);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 496819);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 497813);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 498808);

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "LookupList");

            migrationBuilder.DropColumn(
                name: "IlceId",
                table: "Kullanici");

            migrationBuilder.AlterColumn<string>(
                name: "Isim",
                table: "LookupList",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "Kullanici",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
