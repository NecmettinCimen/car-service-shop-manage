using System;
using System.Collections.Generic;
using System.Linq;
using aracyonetim.entities.Dtos;
using aracyonetim.entities.Tables;
using Microsoft.EntityFrameworkCore;

namespace aracyonetim.database
{
    public class AracYonetimContext:DbContext
    {
        public AracYonetimContext(DbContextOptions<AracYonetimContext> options) : base(options)   {  }
        
        public DbSet<Firma> Firma { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Arac> Arac { get; set; }
        public DbSet<LookupList> LookupList { get; set; }
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<BakimTalebi> BakimTalebi { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<RolMenu> RolMenu { get; set; }
        
        public DbQuery<ChartDto> ChartDto { get; set; }
        
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
                id++;
                var adminrolid = id++;
                builder.Entity<Rol>().HasData(
                    new Rol(){Id = adminrolid, Isim = "Admin"}
                );
                builder.Entity<RolMenu>().HasData(
                    new RolMenu{Id = id++, RolId = adminrolid, MenuNo = 1},
                    new RolMenu{Id = id++, RolId = adminrolid, MenuNo = 2},
                    new RolMenu{Id = id++, RolId = adminrolid, MenuNo = 3},
                    new RolMenu{Id = id++, RolId = adminrolid, MenuNo = 4},
                    new RolMenu{Id = id++, RolId = adminrolid, MenuNo = 5},
                    new RolMenu{Id = id++, RolId = adminrolid, MenuNo = 6},
                    new RolMenu{Id = id++, RolId = adminrolid, MenuNo = 7}
                );
                
                var kullanicirolid = id++;
                builder.Entity<Rol>().HasData(
                    new Rol(){Id = kullanicirolid, Isim = "Kullanıcı"}
                );
                builder.Entity<RolMenu>().HasData(
                    new RolMenu{Id = id++, RolId = kullanicirolid, MenuNo = 1},
                    new RolMenu{Id = id++, RolId = kullanicirolid, MenuNo = 2},
                    new RolMenu{Id = id++, RolId = kullanicirolid, MenuNo = 3},
                    new RolMenu{Id = id++, RolId = kullanicirolid, MenuNo = 4}
                );
                
                var yetkiliservisrolid = id++;
                builder.Entity<Rol>().HasData(
                    new Rol(){Id = yetkiliservisrolid, Isim = "Yetkili Servis"}
                );
                builder.Entity<RolMenu>().HasData(
                    new RolMenu{Id = id++, RolId = yetkiliservisrolid, MenuNo = 1},
                    new RolMenu{Id = id++, RolId = yetkiliservisrolid, MenuNo = 5}
                );
                
                var musterirolid = id++;
                builder.Entity<Rol>().HasData(
                    new Rol(){Id = musterirolid, Isim = "Müşteri"}
                );
                builder.Entity<RolMenu>().HasData(
                    new RolMenu{Id = id++, RolId = musterirolid, MenuNo = 4}
                );


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost\\sekiz;Initial Catalog=dbaracyonetim;User ID=sa;Password=Nebula21;");
        }
    }
}