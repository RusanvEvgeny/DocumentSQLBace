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
    public class DocumentModel : IEntity
    {
        public virtual int Id { get; set; }

        [DisplayName("Имя документа")]
        public virtual string DocumentName { get; set; }

        [DisplayName("Дата добавления")]
        public virtual DateTime DocAddDate { get; set; }

        [DisplayName("Автор")]
        public virtual int DocAutorId { get; set; }
        
        [DisplayName("Файл")]
        public virtual string File { get; set; }
    }
}