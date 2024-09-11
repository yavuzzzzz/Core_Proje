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
	public class SocialMediaManager : ISocialMediaService
	{
		private readonly ISocialMediaDal socialMediaDal;
		public SocialMediaManager(ISocialMediaDal _socialMediaDal)
		{
			this.socialMediaDal = _socialMediaDal;
		}

		public void TAdd(SocialMedia t)
		{
			socialMediaDal.Insert(t);
		}

		public void TDelete(SocialMedia t)
		{
			socialMediaDal.Delete(t);
		}

		public SocialMedia TGetById(int id)
		{
			return socialMediaDal.GetById(id);
		}

		public List<SocialMedia> TGetList()
		{
			return socialMediaDal.GetList();
		}

		public void TUpdate(SocialMedia t)
		{
			socialMediaDal.Update(t);
		}
	}
}
