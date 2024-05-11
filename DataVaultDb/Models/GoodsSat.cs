using DataVaultDb.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataVaultDb.Models
{
    public class GoodsSat : BaseSat
    {
        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Column("sale_price")]
        public double SalePrice { get; set; }

        [Column("goods_hub_id")]
        public int GoodsHubId { get; set; }

        public GoodsHub? GoodsHub { get; set; }
    }
}
