using ITUniver.DocBase.Web.Interfaces;
using ITUniver.DocBase.Web.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using NHibernate;

namespace ITUniver.DocBase.Web.Repositories
{
    public class NHDocumentRepository : IRepository<DocumentModel>
    {
        public bool Delete(DocumentModel obj)
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            using (ITransaction tx = session.BeginTransaction())
            {
                session.Delete(obj);
                tx.Commit();
            }

            return true;
        }

        public IEnumerable<DocumentModel> Find(string condition)
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            var criteria = session.CreateCriteria<DocumentModel>();

            return criteria.List<DocumentModel>();
        }

        public DocumentModel Load(int id)
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            return session.Load<DocumentModel>(id);
        }

        public bool Save(DocumentModel obj)
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            using (ITransaction tx = session.BeginTransaction())
            {
                session.SaveOrUpdate(obj);
                tx.Commit();
            }

            return true;
        }
    }
}