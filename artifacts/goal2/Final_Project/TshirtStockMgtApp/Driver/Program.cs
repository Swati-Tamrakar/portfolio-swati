using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TshirtStockMgtApp;
using TshirtStockMgtApp.DAL;
using TshirtStockMgtApp.Model;


namespace Driver
{
    class Program
    {
        private static TshirtRepository _tshirtRepository = new TshirtRepository();
        static void Main(string[] args)
        {
            List<Tshirt> _list = new List<TshirtStockMgtApp.Model.Tshirt>();
            _list = _tshirtRepository.GetTshirts();
            foreach (var item in _list)
            {
                Console.WriteLine(item.TshirtID);
            }
            Console.ReadKey();
        }
    }
}
