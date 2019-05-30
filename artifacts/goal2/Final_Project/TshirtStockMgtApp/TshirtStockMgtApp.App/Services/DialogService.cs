using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TshirtStockMgtApp.App.View;

namespace TshirtStockMgtApp.App.Services
{
    public class DialogService
    {
        Window _tshirtDetailView = null;
        public void ShowDialog()
        {
            _tshirtDetailView = new TshirtDetailView();
            _tshirtDetailView.ShowDialog();
        }
        public void CloseDialog()
        {
            if (_tshirtDetailView != null)
                _tshirtDetailView.Close();
        }
    }
}
