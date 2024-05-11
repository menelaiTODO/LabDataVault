using DataVaultDb.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataVaultDb.Models
{
    public class OrderCompanyLink : BaseLink
    {
        [Column("order_hub_id")]
        public int OrderHubId { get; set; }

        public OrderHub? OrderHub { get; set; }

        [Column("company_hub_id")]
        public int CompanyHubId { get; set; }

        public CompanyHub? CompanyHub { get; set; }

        public IEnumerable<OrderCompanyLinkSat>? OrderCompanyLinkSats { get; set; }
    }
}
