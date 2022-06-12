using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bsis3a_webapp.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        //[Required(ErrorMessage = "No Item")]
        [StringLength(50)]
        public string Name { get; set; }
    }
}