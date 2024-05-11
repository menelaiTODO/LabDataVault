using DataVaultDb.Models.Base;

namespace DataVaultDb.Models
{
    public class CompanyHub : BaseHub
    {
        public IEnumerable<CompanySat>? CompanySats { get; set; }
    }
}
