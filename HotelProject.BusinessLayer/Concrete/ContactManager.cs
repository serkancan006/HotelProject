using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _ContactDal;

        public ContactManager(IContactDal ContactDal)
        {
            _ContactDal = ContactDal;
        }

        public void TDelete(Contact t)
        {
            _ContactDal.Delete(t);
        }

        public Contact TGetByID(int id)
        {
            return _ContactDal.GetByID(id);
        }

        public int TGetContactCount()
        {
            return _ContactDal.GetContactCount();
        }

        public List<Contact> TGetList()
        {
            return _ContactDal.GetList();
        }

        public void TInsert(Contact t)
        {
            _ContactDal.Insert(t);
        }

        public void TUpdate(Contact t)
        {
            _ContactDal.Update(t);
        }
    }
}
