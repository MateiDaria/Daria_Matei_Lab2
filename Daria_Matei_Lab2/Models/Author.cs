using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Daria_Matei_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public String FirstName { get; set; }
        [Display(Name = "Last Name")]
        public String LastName { get; set; }
        [Display(Name = "Author Name")]
        public String FullName => FirstName + " " + LastName;

        public ICollection <Book> Books { get; set; }
    }
}
