using System.ComponentModel.DataAnnotations.Schema;

namespace DataVaultDb.Models.Base
{
    public abstract class BaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
    }
}
