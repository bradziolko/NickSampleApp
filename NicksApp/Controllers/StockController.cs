using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NicksApp.Domain.Interfaces;
using NicksApp.Domain.Models;

namespace NicksApp.Controllers
{
    public class StockController : Controller
    {
        private IStock _stock;

        public StockController()
        {
            _stock = new Stock();
        }

        public ActionResult GetStockTable()
        {
            List<string> stocks = _stock.Stocks.ToList();

            return PartialView("StockTable", stocks);
        }
    }
}
