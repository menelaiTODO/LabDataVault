using DataVaultDb.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataVaultDb.Models
{
    public class OrderGoodsLink : BaseLink
    {
        [Column("order_hub_id")]
        public int OrderHubId { get; set; }

        public OrderHub? OrderHub { get; set; }

        [Column("goods_hub_id")]
        public int GoodsHubId { get; set; }

        public GoodsHub? GoodsHub { get; set; }

        public IEnumerable<OrderGoodsLinkSat>? OrderGoodsLinkSats { get; set; }
    }
}
