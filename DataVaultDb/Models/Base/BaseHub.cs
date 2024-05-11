namespace DataVaultDb.Models.Base
{
    public abstract class BaseHub : BaseModel
    {
        public string BKHash { get; set; } = string.Empty;
        
        public DateTime LoadDate { get; set; }

        public string SourceName { get; set; } = string.Empty;
    }
}
