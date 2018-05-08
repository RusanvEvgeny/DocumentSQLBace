using ITUniver.DocBase.Web.Interfaces;
using ITUniver.DocBase.Web.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using NHibernate;

namespace ITUniver.DocBase.Web.Repositories
{
    public class NHUserRepository : IRepository<UserModel>
    {
        public bool Delete(UserModel obj)
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            using (ITransaction tx = session.BeginTransaction())
            {
                session.Delete(obj);
                tx.Commit();
            }

            return true;
        }

        public IEnumerable<UserModel> Find(string condition)
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            var criteria = session.CreateCriteria<UserModel>();

            return criteria.List<UserModel>();
        }

        public UserModel Load(int id)
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            return session.Load<UserModel>(id);
        }

        public bool Save(UserModel obj)
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