using Microsoft.EntityFrameworkCore;

namespace EditorPriceListExemple.Models
{
    public class AppDBContext :DbContext
    {
        public DbSet<PriceList> PriceLists { get; set; } = null!;
        public DbSet<Goods> Goods { get; set; } = null!;
        public DbSet<TypeAttributeGoods> TypesAttributeGoods { get; set; } = null!;
        public DbSet<AttributeGoods> AttributesGoods { get; set; } = null!;
        public DbSet<AttributeGoodsWithValue> AttributesGoodsWithValue { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeAttributeGoods>().HasData(new TypeAttributeGoods {TypeAttributeID=1, TypeAttribute="Число"},
                                                     new TypeAttributeGoods { TypeAttributeID = 2, TypeAttribute = "Однострочный текст"},
                                                     new TypeAttributeGoods { TypeAttributeID = 3, TypeAttribute = "Многострочный текст"},
                                                     new TypeAttributeGoods { TypeAttributeID = 4, TypeAttribute = "Булевый флаг"});
            modelBuilder.Entity<PriceList>().HasData(new PriceList { PriceListID = 1, PriceListName = "Прайс-лист от 10.06.2024" },
                                                     new PriceList { PriceListID = 2, PriceListName = "Прайс-лист от 11.06.2024" },
                                                     new PriceList { PriceListID = 3, PriceListName = "Прайс-лист от 12.06.2024" },
                                                     new PriceList { PriceListID = 4, PriceListName = "Прайс-лист от 13.06.2024" },
                                                     new PriceList { PriceListID = 5, PriceListName = "Прайс-лист от 14.06.2024" });
        }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
