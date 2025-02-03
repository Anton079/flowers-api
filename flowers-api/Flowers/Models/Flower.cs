using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace flowers_api.Flowers.Models
{
    [Table("flower")]
    public class Flower
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }

        [Required]
        [Column("type")]
        public string type { get; set; }

        [Required]
        [Column("price")]
        public int price { get; set; }

        [Required]
        [Column("rating")]
        public int rating { get; set; }
    }
}
