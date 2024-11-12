using System.ComponentModel.DataAnnotations;

namespace CrudWithPostgresMVC.Models
{
    public class User
    {
        //todo: add attributes
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Введите имя")]
        [MaxLength(50,ErrorMessage ="Не более 50ти символов")]
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; } = null!;

        [Range(1, 120, ErrorMessage = "Недопустимый возраст")]
        public byte Age { get; set; }

    }
}
