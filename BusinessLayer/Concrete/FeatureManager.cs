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
	public class FeatureManager : IFeatureService
	{
		private readonly IFeatureDal featureDal;
		public FeatureManager(IFeatureDal _featureDal)
		{
			this.featureDal = _featureDal;
		}

		public void TAdd(Feature t)
		{
			featureDal.Insert(t);
		}

		public void TDelete(Feature t)
		{
			featureDal.Delete(t);
		}

		public Feature TGetById(int id)
		{
			 return	featureDal.GetById(id);
		}

		public List<Feature> TGetList()
		{
			return featureDal.GetList();
		}

		public void TUpdate(Feature t)
		{
			featureDal.Update(t);	
		}
	}
}
