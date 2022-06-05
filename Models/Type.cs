using System.ComponentModel.DataAnnotations;

namespace bsis3a_webapp.Models
{
    public class Type
    {
        public int Id { get; set; }
        [Required]
        //[Required(ErrorMessage = "No Item")]
        [StringLength(50)]
        public string Name { get; set; }

        public Item item { get; set; }
        public object Item { get; internal set; }
       // public object Item { get; internal set; } error
        public int ItemId { get; set; }
    }
}