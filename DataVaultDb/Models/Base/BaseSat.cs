namespace DataVaultDb.Models.Base
{
    public abstract class BaseSat : BaseModel
    {
        public DateTime LoadDate { get; set; }

        public string SourceName { get; set; } = string.Empty;
    }
}
