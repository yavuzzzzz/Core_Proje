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
	public class ExperienceManager : IExperienceService
	{
		private readonly IExperienceDal experienceDal;

		public ExperienceManager(IExperienceDal _experienceDal)
		{
			this.experienceDal = _experienceDal;
		}

		public void TAdd(Experience t)
		{
			experienceDal.Insert(t);
		}

		public void TDelete(Experience t)
		{
			experienceDal.Delete(t);
		}

		public Experience TGetById(int id)
		{
			return experienceDal.GetById(id);
		}

		public List<Experience> TGetList()
		{
			return experienceDal.GetList();
		}

		public void TUpdate(Experience t)
		{
			experienceDal.Update(t);
		}
	}
}
