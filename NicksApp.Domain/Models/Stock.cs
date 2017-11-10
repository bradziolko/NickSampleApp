using NicksApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicksApp.Domain.Models
{
    public class Stock : IStock
    {
        public Stock()
        {

        }

        public IEnumerable<string> Stocks
        {
            get
            {
                return new List<string>
                {
                    "AAPL",
                    "GOOG",
                    "MSFT",
                    "FB",
                    "TWTR"
                };
            }
        }

        public string GetStockOrThrowException(int id)
        {
            return Stocks.ElementAt(id);
        }

        public void UpdateStock(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteStock(int id)
        {
            throw new NotImplementedException();
        }
    }
}
