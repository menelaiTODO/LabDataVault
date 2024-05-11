using DataVaultDb.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataVaultDb.Models
{
    public class OrderGoodsLinkSat : BaseSat
    {
        [Column("order_goods_link_id")]
        public int OrderGoodsLinkId { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        public OrderGoodsLink? OrderGoodsLink { get; set; }
    }
}
