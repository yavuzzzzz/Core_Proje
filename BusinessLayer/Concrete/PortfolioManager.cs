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
	public class PortfolioManager : IPortfolioService
	{
		private readonly IPortfolioDal portfolioDal;
		public PortfolioManager(IPortfolioDal _portfolioDal)
		{
			this.portfolioDal = _portfolioDal;
		}

		public void TAdd(Portfolio t)
		{
			portfolioDal.Insert(t);
		}

		public void TDelete(Portfolio t)
		{
			portfolioDal.Delete(t);
		}

		public Portfolio TGetById(int id)
		{
			return portfolioDal.GetById(id);
		}

		public List<Portfolio> TGetList()
		{
			return portfolioDal.GetList();
		}

		public void TUpdate(Portfolio t)
		{
			portfolioDal.Update(t);
		}
	}
}
