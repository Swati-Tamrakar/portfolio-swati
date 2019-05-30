using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TshirtStockMgtApp.DAL;
using TshirtStockMgtApp.Model;

namespace TshirtStockMgtApp.App.Services
{
    class TshirtDataService : ITshirtDataService
    {
        ITshirtRepository _repository = new TshirtRepository();
        public void DeleteTshirt(Tshirt tshirt)
        {
             _repository.DeleteTshirt(tshirt);
        }

        public List<Tshirt> GetAllTshirts()
        {
            return _repository.GetTshirts();
        }

        public Tshirt GetTshirtDetail(string tshirtID)
        {
            return _repository.GetByTshirtID(tshirtID);
        }

        public void UpdateTshirt(Tshirt tshirt)
        {
            _repository.UpdateTshirts(tshirt);
        }
    }
}
