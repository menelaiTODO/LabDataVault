using DataVaultDb.Models.Base;

namespace DataVaultDb.Models
{
    public class GoodsHub : BaseHub
    {
        public IEnumerable<GoodsSat>? GoodsSats { get; set; }
    }
}
