using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TshirtStockMgtApp.App.ViewModel;

namespace TshirtStockMgtApp.App
{
    public class ViewModelLocator
    {
     
        private static TshirtOverviewViewModel _tshirtOverviewViewModel = new TshirtOverviewViewModel();
        private static TshirtDetailViewModel _tshirtDetailViewModel = new TshirtDetailViewModel();

        public static TshirtOverviewViewModel TshirtOverviewViewModelInstance
        {
            get
            {
                return _tshirtOverviewViewModel;
            }
        }

        public static TshirtDetailViewModel TshirtDetailViewModel
        {
            get
            {
                return _tshirtDetailViewModel;
            }
        }
    }
}
