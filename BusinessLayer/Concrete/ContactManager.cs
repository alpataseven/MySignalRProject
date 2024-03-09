using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact entity)
        {
            _contactDal.Add(entity);
        }

        public void Delete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public Contact GetById(int id)
        {
            return _contactDal.GetById(id); 
        }

        public List<Contact> GetListAll()
        {
            return _contactDal.GetListAll();
        }

        public void TAdd(Contact entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Contact TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
