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
        IPortfolioDal _portfoiloDal;

        public PortfolioManager(IPortfolioDal portfoiloDal)
        {
            _portfoiloDal = portfoiloDal;
        }

        public List<Portfolio> GetListByFilter(string p)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Portfolio t)
        {
            _portfoiloDal.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            _portfoiloDal.Delete(t);
        }

        public Portfolio TGetById(int id)
        {
            return _portfoiloDal.GetById(id);
        }

        public List<Portfolio> TGetList()
        {
            return _portfoiloDal.GetList();
        }

        public void TUpdate(Portfolio t)
        {
            _portfoiloDal.Update(t);
        }
    }
}
