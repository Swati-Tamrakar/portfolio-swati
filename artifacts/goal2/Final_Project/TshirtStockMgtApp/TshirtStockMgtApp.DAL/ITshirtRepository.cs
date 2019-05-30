using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TshirtStockMgtApp;
using TshirtStockMgtApp.Model;

namespace TshirtStockMgtApp.DAL
{
    public interface ITshirtRepository
    {
        //define interface for tshirt
        void DeleteTshirt(Tshirt tshirt);
        Tshirt GetATshirt();
        Tshirt GetByTshirtID(string tshirtID);
        List<Tshirt> GetTshirts();
        void UpdateTshirts(Tshirt tshirt);
    }
}
