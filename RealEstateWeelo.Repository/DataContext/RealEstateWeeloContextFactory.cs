using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RealEstateWeelo.Repository.DataContext
{
    public class RealEstateWeeloContextFactory : IDesignTimeDbContextFactory<RealEstateWeeloContext>
    {
        public RealEstateWeeloContext CreateDbContext(string[] args)
        {
            var OptionsBuilder = new DbContextOptionsBuilder<RealEstateWeeloContext>();
            OptionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=RealEstateWeelo;User Id=pruebas;Password=pruebas;");
            return new RealEstateWeeloContext(OptionsBuilder.Options);
        }
    }
}
