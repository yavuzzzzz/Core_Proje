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
	public class MessageManager : IMessageService
	{
		private readonly IMessageDal messageDal;
		public MessageManager(IMessageDal _messageDal)
		{
			this.messageDal = _messageDal;
		}

		public void TAdd(Message t)
		{
			messageDal.Insert(t);
		}

		public void TDelete(Message t)
		{
			messageDal.Delete(t);
		}

		public Message TGetById(int id)
		{
			return messageDal.GetById(id);
		}

		public List<Message> TGetList()
		{
			return messageDal.GetList();
		}

		public void TUpdate(Message t)
		{
			messageDal.Update(t);
		}
	}
}
