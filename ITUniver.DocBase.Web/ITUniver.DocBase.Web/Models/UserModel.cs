using ITUniver.DocBase.Web.Interfaces;
using System;
using System.ComponentModel;

namespace ITUniver.DocBase.Web.Models
{
    public class UserModel : IEntity
    {
        public virtual int Id { get; set; }

        [DisplayName("Логин")]
        public virtual string Login { get; set; }

        [DisplayName("Имя")]
        public virtual string FullName { get; set; }

        [DisplayName("Пароль")]
        public virtual string Password { get; set; }
    }
}