using DataVaultDb.Models.Base;

namespace DataVaultDb.Models
{
    public class OrderHub : BaseHub
    {
        public IEnumerable<OrderSat>? OrderSats { get; set; }
    }
}
