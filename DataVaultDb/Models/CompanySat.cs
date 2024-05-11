using DataVaultDb.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataVaultDb.Models
{
    public class CompanySat : BaseSat
    {
        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Column("taxpayer_number")]
        public string TaxpayerNumber = string.Empty;

        [Column("company_hub_id")]
        public int CompanyHubId { get; set; }

        public CompanyHub? CompanyHub { get; set; }
    }
}
