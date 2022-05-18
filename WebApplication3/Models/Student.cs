using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Student
    {
        public int Id { get; set; }
        [DisplayName("الاسم الأول")]
        [Required(ErrorMessage ="Please insert first name")]
        // [RegularExpression("^[a-zA-Z]\\w{3,14}$",ErrorMessage ="Regex")]
        [EmailAddress (ErrorMessage ="Email is wrong")]
        [DataType(DataType.Text,ErrorMessage ="must string")]
        [StringLength(maximumLength:50,ErrorMessage ="Must be at lest 3 and max 50 ",MinimumLength =3)]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }

    }
}
