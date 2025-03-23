using System.ComponentModel.DataAnnotations;

namespace flowers_api.Flowers.Dtos
{
    public class AddFlowerRequest
    {
        [Required(ErrorMessage = "Type este null, trebuie sa il completezi")]
        [StringLength(100, ErrorMessage = "trebuie sa aiba maxim 100 de caractere")]
        public string Type {  get; set; }


        [Required(ErrorMessage = "Price este null, trebuie sa il completezi")]
        [Range(100, double.MaxValue, ErrorMessage = "trebuie sa aiba maxim 100 de caractere")]
        public int Price {  get; set; }


        [Required(ErrorMessage = "Rating este null, trebuie sa il completezi")]
        [Range(100, double.MaxValue, ErrorMessage = "trebuie sa aiba maxim 100 de caractere")]
        public int Rating {  get; set; }
    }
}
