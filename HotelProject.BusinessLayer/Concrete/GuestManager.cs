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
    public class GuestManager : IGuestService
    {
        private readonly IGuestDal _GuestDal;

        public GuestManager(IGuestDal GuestDal)
        {
            _GuestDal = GuestDal;
        }

        public void TDelete(Guest t)
        {
            _GuestDal.Delete(t);
        }

        public Guest TGetByID(int id)
        {
            return _GuestDal.GetByID(id);
        }

        public List<Guest> TGetList()
        {
            return _GuestDal.GetList();
        }

        public void TInsert(Guest t)
        {
            _GuestDal.Insert(t);
        }

        public void TUpdate(Guest t)
        {
            _GuestDal.Update(t);
        }
    }
}
