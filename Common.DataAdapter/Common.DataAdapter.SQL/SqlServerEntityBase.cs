using Common.DataAdapter.Library;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.DataAdapter.SQL
{
    public class SqlServerEntityBase : EntityBase
    {
        [NotMapped]
        public int RETURN_VALUE { get; set; }
    }
}
