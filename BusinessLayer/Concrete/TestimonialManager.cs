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
	public class TestimonialManager : ITestimonialService
	{
		private readonly ITestimonialDal testimonialDal;
		public TestimonialManager(ITestimonialDal _testimonialDal)
		{
			this.testimonialDal = _testimonialDal;
		}

		public void TAdd(Testimonial t)
		{
			testimonialDal.Insert(t);
		}

		public void TDelete(Testimonial t)
		{
			testimonialDal.Delete(t);
		}

		public Testimonial TGetById(int id)
		{
			return testimonialDal.GetById(id);
		}

		public List<Testimonial> TGetList()
		{
			return testimonialDal.GetList();
		}

		public void TUpdate(Testimonial t)
		{
			testimonialDal.Update(t);
		}
	}
}
