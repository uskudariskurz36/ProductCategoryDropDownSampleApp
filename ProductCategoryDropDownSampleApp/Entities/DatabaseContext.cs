using MFramework.Services.FakeData;
using Microsoft.EntityFrameworkCore;

namespace ProductCategoryDropDownSampleApp.Entities
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        public DatabaseContext(DbContextOptions options) : base(options)
        {
            if (Database.EnsureCreated())
            {
                for (int i = 0; i < 10; i++)
                {
                    Category category = new Category()
                    {
                        Name = NameData.GetCompanyName(),
                        Description = TextData.GetSentence()
                    };

                    Categories.Add(category);
                }

                SaveChanges();
            }
        }
    }
}
