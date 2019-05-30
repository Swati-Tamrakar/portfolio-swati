using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TshirtStockMgtApp.Model;

namespace TshirtStockMgtApp.DAL
{
    public class TshirtRepository : ITshirtRepository
    {
        private static List<Tshirt> _lstTshirts;

        public TshirtRepository()
        {

        }
        public void DeleteTshirt(Tshirt tshirt)
        {
            _lstTshirts.Remove(tshirt);
            using (connTshirtsEntities ctx = new connTshirtsEntities())
            {
                try
                {
                    string qry = "DELETE FROM Tshirts WHERE tshirtID={0}";
                    var rows = ctx.Database.ExecuteSqlCommand(qry, tshirt.TshirtID);
                }
                catch (System.Exception)
                {


                }
            }
        }

        public Tshirt GetATshirt()
        {
            if (_lstTshirts == null)
             LoadTshirts();
            return _lstTshirts.FirstOrDefault();
        }

        public Tshirt GetByTshirtID(string tshirtID)
        {
            if (_lstTshirts == null)
                LoadTshirts();
            return _lstTshirts.Where(t => t.TshirtID == tshirtID).FirstOrDefault();
        }

        public List<Tshirt> GetTshirts()
        {
            if (_lstTshirts == null)
                LoadTshirts();
            return _lstTshirts;
        }

        private void LoadTshirts()
        {
            using (connTshirtsEntities ctx = new connTshirtsEntities())
            {
                _lstTshirts = ctx.Tshirts.ToList();
            }
        }

        public void UpdateTshirts(Tshirt tshirt)
        {
            Tshirt tshirtToUpdate = _lstTshirts.Where(p => p.TshirtID== tshirt.TshirtID).FirstOrDefault();
            tshirtToUpdate = tshirt;

            using (connTshirtsEntities ctx = new connTshirtsEntities())
            {
                try
                {
                    string qry = "UPDATE Tshirts SET TshirtID={0}, ShortDescription={1}, Longdescription={2}, Image={3}, Size={4}, Color={5}, UnitPrice={6}, InStock={7} ";
                    var rows = ctx.Database.ExecuteSqlCommand(qry, tshirt.TshirtID, tshirt.ShortDescription, tshirt.LongDescription, tshirt.Image, tshirt.Size, tshirt.Color, tshirt.UnitPrice, tshirt.InStock);
                }
                catch (System.Exception)
                {


                }
            }
        }

    }
}
