using System;
using System.Collections.Generic;
using System.Linq;
using aracyonetim.entities.Tables;
using Microsoft.EntityFrameworkCore;

namespace aracyonetim.database
{
    public class AracYonetimContext:DbContext
    {
        public AracYonetimContext(DbContextOptions<AracYonetimContext> options) : base(options)   {  }
        
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Arac> Arac { get; set; }
        public DbSet<LookupList> LookupList { get; set; }
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<BakimTalebi> BakimTalebi { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            var id = 0;
            for (id = 0; id < Seeds.Markalar.Length; id++)
            {
                builder.Entity<LookupList>().HasData(
                    new LookupList(){Id = id+1,Tip = Lookup.Marka,Isim = Seeds.Markalar[id]}
                );   
            }

            id++;
            builder.Entity<LookupList>().HasData(
                new LookupList(){Id = id++,Tip = Lookup.Yakit,Isim = "Dizel"},
                new LookupList(){Id = id++,Tip = Lookup.Yakit,Isim = "Benzin"},
                new LookupList(){Id = id++,Tip = Lookup.Yakit,Isim = "LPG"},
                new LookupList(){Id = id++,Tip = Lookup.Yakit,Isim = "Elektrik"}
            );
                
                id++;
                var illist = Seeds.IlIlce.Select(s => s.Split("-")[0]).Distinct().ToArray();
                var illookup = new List<LookupList>();
                for (var i = 0; i < illist.Length; i++)
                {
                    id += i;
                    var item =
                        new LookupList() {Id = id, Tip = Lookup.Il, Isim = illist[i]};
                    builder.Entity<LookupList>().HasData(
                        item
                    );  
                    illookup.Add(item);
                }
            
                id++;
                for (var i=0; i < Seeds.IlIlce.Length; i++)
                {
                    var item = Seeds.IlIlce[i];
                    var ililce = item.Split("-");
                    string il = ililce[0], ilce =ililce[1];
                    id += i;
                    builder.Entity<LookupList>().HasData(
                        new LookupList(){Id = id++,Tip = Lookup.Ilce,Isim = ilce, ParentId = illookup.Find(s=>s.Isim == il).Id}
                    );
                }
                
                id++;
                builder.Entity<LookupList>().HasData(
                    new LookupList(){Id = id++,Tip = Lookup.Bakim,Isim = "Bekliyor"},
                    new LookupList(){Id = id++,Tip = Lookup.Bakim,Isim = "Onaylandı"},
                    new LookupList(){Id = id++,Tip = Lookup.Bakim,Isim = "Red Edildi"},
                    new LookupList(){Id = id++,Tip = Lookup.Bakim,Isim = "Tamamlandı"}
                );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=necmettincimen.com,51433;Initial Catalog=dbaracyonetim;User ID=sa;Password=Nebula21;");
        }
    }
}