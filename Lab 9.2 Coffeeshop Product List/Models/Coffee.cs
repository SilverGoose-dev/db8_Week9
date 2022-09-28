using Dapper;
using MySql.Data.MySqlClient.Authentication;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Lab_9._2_Coffeeshop_Product_List.Models
{
    [Table("product")]
    public class Coffee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Description} {Price} {Category}";
        }
    }
}
