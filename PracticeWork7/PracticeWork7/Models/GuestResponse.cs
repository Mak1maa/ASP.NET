using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PracticeWork7.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Необходимо ввести своё имя!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Необходимо ввести электронную почту!")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Некорректная электронная почта.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Необходимо ввести личный номер телефона!")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Необходимо указать, ожидать ли тебя на мероприятии.")]
        public bool? WillAttend { get; set; }
    }
}