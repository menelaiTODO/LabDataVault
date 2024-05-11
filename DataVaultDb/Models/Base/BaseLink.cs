namespace DataVaultDb.Models.Base
{
    public abstract class BaseLink : BaseModel
    {
        public DateTime LoadDate { get; set; }

        public string SourceName { get; set; } = string.Empty;
    }
}
