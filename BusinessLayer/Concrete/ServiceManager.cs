using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ServiceManager : IServiceService
	{
		private readonly IServiceDal serviceDal;
		
		public ServiceManager(IServiceDal _serviceDal)
		{
			this.serviceDal = _serviceDal; 	
		}
		public void TAdd(Service t)
		{
			serviceDal.Insert(t);
		}

		public void TDelete(Service t)
		{
			serviceDal.Delete(t);
		}

		public Service TGetById(int id)
		{
			return serviceDal.GetById(id);
		}

		public List<Service> TGetList()
		{
			return serviceDal.GetList();
		}

		public void TUpdate(Service t)
		{
			serviceDal.Update(t);
		}
	}
}
