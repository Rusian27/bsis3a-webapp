using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bsis3a_webapp.Models
{
    public class Type
    {
        public int Id { get; set; }
        [Required]  //[Required(ErrorMessage = "No Item")]
        [StringLength(50)]
        [DisplayName("Type Name")]
        public string Name { get; set; }
        public Item Item { get; set; }
        [RegularExpression("^*[1-9]*$", ErrorMessage = "Please select item.")]
        public int ItemId { get; set; }
    }
}