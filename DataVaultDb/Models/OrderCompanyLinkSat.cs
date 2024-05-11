using DataVaultDb.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataVaultDb.Models
{
    public class OrderCompanyLinkSat : BaseSat
    {
        [Column("order_company_link_id")]
        public int OrderCompanyLinkId { get; set; }

        public OrderCompanyLink? OrderCompanyLink { get; set; }
    }
}
