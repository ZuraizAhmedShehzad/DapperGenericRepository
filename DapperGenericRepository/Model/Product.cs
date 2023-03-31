using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperGenericRepository.Model
{
    [Table("tbl_Product")]
    public class Product
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("product_name")]
        public string Name { get; set; }

        [Column("product_description")]
        public string Description { get; set; }

        [Column("product_price")]
        public decimal Price { get; set; }
    }
}
