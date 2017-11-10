using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicksApp.Domain.Interfaces
{
    public interface IStock
    {
        IEnumerable<string> Stocks { get; }

        string GetStockOrThrowException(int id);

        void UpdateStock(int id);

        void DeleteStock(int id);
    }
}
