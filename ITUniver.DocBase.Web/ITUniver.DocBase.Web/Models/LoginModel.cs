using ITUniver.DocBase.Web.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITUniver.DocBase.Web.Models
{
    public class LoginModel
    {
        [DisplayName("Имя пользователя")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Введите логин")]
        public string Login { get; set; }

        [DisplayName("Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}