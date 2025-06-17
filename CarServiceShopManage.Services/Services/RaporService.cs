using System;
using System.Threading.Tasks;
using CarServiceShopManage.Entities.Dtos;
using CarServiceShopManage.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarServiceShopManage.Services.Services
{
    public interface IRaporService
    {
        public Task<SayilarDto> Sayilar(int firmaid);
        public Task<DataGridDto<ChartDto>> TarihlereGoreBakimTalepleri(int firmaid);
        public Task<DataGridDto<ChartDto>> AracMarkalari(int firmaid);
    }
    public class RaporService(
        IAracRepository aracRepository,
        IKullaniciRepository kullaniciRepository,
        IBakimTalebiRepository bakimTalebiRepository,
        IMusteriRepository musteriRepository,
        IChartDtoRepository chartRepository)
        : IRaporService
    {
        public async Task<SayilarDto> Sayilar(int firmaid)
        {
            return new SayilarDto
            {
                AracSayisi = await aracRepository.All(firmaid).CountAsync(),
                BakimTalebi = await bakimTalebiRepository.All(firmaid).CountAsync(),
                KullaniciSayisi = await kullaniciRepository.All(firmaid).CountAsync(),
                MusteriSayisi = await musteriRepository.All(firmaid).CountAsync(),
            };
        }

        private string DateSql(string sql, DateTime baslangic, DateTime bitis) => $@"set language  turkish;
                        DECLARE @i date = '{baslangic.ToString("yyyy-MM-dd")}';
                        DECLARE @length date = dateadd(week,1,@i);

                        CREATE TABLE #Temporary(Isim varchar(100),
                                                Sayi int,
                                                CreateDate date default getdate(),
                                                IsDeleted bit default 0,
                                                Id int default 0,
                                                FirmaId int default 0,
                                                Status smallint default 0,
                                                CreatorId int default 0);

                        WHILE 0<datediff(day,@i,@length) 
                            BEGIN
                                insert into #Temporary (Isim, Sayi) values (convert(varchar,@i,104),0);
                                update #Temporary set Sayi=l.Sayi from 
                                ({sql}) l where #Temporary.Isim =  l.Isim;
                                SET @i = dateadd(day,1,@i);
                            END;
                            
                            select * from #Temporary;
                        drop table  #Temporary;";


        public async Task<DataGridDto<ChartDto>> TarihlereGoreBakimTalepleri(int firmaid)
        {
            var result = await chartRepository.FromSql(DateSql(
                $@"select convert(varchar,BakimTarihi,104) Isim, count(*) Sayi from BakimTalebi
                         where FirmaId={firmaid} and datepart(dayofyear ,BakimTarihi) = datepart(dayofyear,@i)
                         group by convert(varchar,BakimTarihi,104)",
                DateTime.Now.StartOfWeek(DayOfWeek.Monday),
                DateTime.Now.StartOfWeek(DayOfWeek.Sunday)));

            return new DataGridDto<ChartDto>
            {
                data = result
            };
        }

        public async Task<DataGridDto<ChartDto>> AracMarkalari(int firmaid)
        {
            var result = await chartRepository.FromSql(
                $@"select isnull(LL.Isim, 'Belirsiz') Isim,
       Count(*) Sayi,
       getdate() CreateDate,
        Convert(bit,0) IsDeleted,
        0 Id,
        0 FirmaId,
        Convert(smallint,0) Status,
        0 CreatorId
from Arac A
left join LookupList LL on A.MarkaId = LL.Id
where A.FirmaId = {firmaid}
group by LL.Isim");

            return new DataGridDto<ChartDto>
            {
                data = result
            };
        }
    }
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            var diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}