using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using aracyonetim.database;
using aracyonetim.entities.Dtos;
using aracyonetim.services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace aracyonetim.services.Services
{
    public interface IRaporService
    {
        public Task<SayilarDto> Sayilar(int firmaid);
        public Task<DataGridDto<ChartDto>> TarihlereGoreBakimTalepleri(int firmaid);
        public Task<DataGridDto<ChartDto>> AracMarkalari(int firmaid);
    }
    public class RaporService:IRaporService
    {
        private readonly IAracRepository _aracRepository;
        private readonly IKullaniciRepository _kullaniciRepository;
        private readonly IBakimTalebiRepository _bakimTalebiRepository;
        private readonly IMusteriRepository _musteriRepository;
        private readonly IChartDtoRepository _chartRepository;

        public RaporService(IAracRepository aracRepository,
            IKullaniciRepository kullaniciRepository,
            IBakimTalebiRepository bakimTalebiRepository,
            IMusteriRepository musteriRepository,
            IChartDtoRepository chartRepository
            )
        {
            _aracRepository = aracRepository;
            _kullaniciRepository = kullaniciRepository;
            _bakimTalebiRepository = bakimTalebiRepository;
            _musteriRepository = musteriRepository;
            _chartRepository = chartRepository;
        }
        
        public async Task<SayilarDto> Sayilar(int firmaid)
        {
            return new SayilarDto
            {
                AracSayisi = await _aracRepository.All(firmaid).CountAsync(),
                BakimTalebi =await _bakimTalebiRepository.All(firmaid).CountAsync(),
                KullaniciSayisi =await _kullaniciRepository.All(firmaid).CountAsync(),
                MusteriSayisi =await _musteriRepository.All(firmaid).CountAsync(),
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
            var result = await _chartRepository.FromSql(DateSql(
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
            var result = await _chartRepository.FromSql(
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