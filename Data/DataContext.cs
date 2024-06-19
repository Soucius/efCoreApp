using Microsoft.EntityFrameworkCore;

namespace efCoreApp.Data {
    public class DataContext: DbContext {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        public DbSet<Kurs> Kurslar => Set<Kurs>();
        public DbSet<Ogrenci> Ogrenciler => Set<Ogrenci>();
        public DbSet<KursKayit> KursKayitlari => Set<KursKayit>();
    }
}