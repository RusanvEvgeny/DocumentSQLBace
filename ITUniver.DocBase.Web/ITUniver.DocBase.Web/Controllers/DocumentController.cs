using ITUniver.DocBase.Web.Models;
using ITUniver.DocBase.Web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITUniver.DocBase.Web.Controllers
{
    [Authorize]
    public class DocumentController : Controller
    {
        private NHDocumentRepository DocumentRepository { get; set; }

        public DocumentController()
        {
            DocumentRepository = new NHDocumentRepository();
        }

        public ActionResult Index()
        {
            var Documents = DocumentRepository.Find("");

            return View(Documents);
        }
        
        [HttpPost]
        public ActionResult AddDocument(DocumentModel model)
        {
            if (DocumentRepository.Save(model))
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Не получилось сохранить");

            return View(model);
        }
    }
}