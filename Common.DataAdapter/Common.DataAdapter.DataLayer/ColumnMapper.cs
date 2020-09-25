using System.Reflection;

namespace Common.DataAdapter.DataLayer
{
    public class ColumnMapper
    {
        public string ColumnName { get; set; }
        public PropertyInfo ColumnProperty { get; set; }
    }
}
