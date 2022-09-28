using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace DapperConsole
{
    [Table ("Department")]
    public class Department
    {
        [ExplicitKey]
        public string id { get; set; }
        public string name { get; set; }
        public string location { get; set; }

        public override string ToString()
        {
            return $"{id} {name} {location}";
        }
    }
}
