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
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
