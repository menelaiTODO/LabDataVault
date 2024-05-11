using DataVaultDb.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataVaultDb.Models
{
    public class OrderSat : BaseSat
    {
        [Column("company_id")]
        public int CompanyId { get; set; }

        [Column("shipment_date")]
        public DateTime ShipmentDate { get; set; }

        [Column("status")]
        public string Status { get; set; } = string.Empty;

        public int? OrderHubId { get; set; }

        public OrderHub? OrderHub { get; set; }
    }
}
