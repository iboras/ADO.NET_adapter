using Common.DataAdapter.Library;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.DataAdapter.Oracle
{
    public class OracleEntityBase : EntityBase
    {
        [NotMapped]
        public int RETURN_VALUE { get; set; }
    }
}
