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
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialmediaDal;

        public SocialMediaManager(ISocialMediaDal socialmediaDal)
        {
            _socialmediaDal = socialmediaDal;
        }

        public void TAdd(SocialMedia entity)
        {
            _socialmediaDal.Add(entity);
        }

        public void TDelete(SocialMedia entity)
        {
            _socialmediaDal.Delete(entity);
        }

        public SocialMedia TGetById(int id)
        {
            return _socialmediaDal.GetById(id);
        }

        public List<SocialMedia> TGetListAll()
        {
            return _socialmediaDal.GetListAll();
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialmediaDal.Update(entity);
        }
    }
}
