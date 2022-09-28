using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;


namespace BusinessPortal.Models
{
    [Table("department")]
    public class Department
    {
        [ExplicitKey]
        public string ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

    }
}
