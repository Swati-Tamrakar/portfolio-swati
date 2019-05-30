using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TshirtStockMgtApp.Model;

namespace TshirtStockMgtApp.App.Services
{
     public interface ITshirtDataService
    {
        List<Tshirt> GetAllTshirts();
        Tshirt GetTshirtDetail(string tshirtID);
        void UpdateTshirt(Tshirt tshirt);
        void DeleteTshirt(Tshirt tshirt);
    }
}
