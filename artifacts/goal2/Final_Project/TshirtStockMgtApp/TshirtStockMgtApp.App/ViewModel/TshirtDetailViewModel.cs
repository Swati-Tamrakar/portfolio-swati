using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TshirtStockMgtApp.App.Messages;
using TshirtStockMgtApp.App.Services;
using TshirtStockMgtApp.App.Utility;
using TshirtStockMgtApp.Model;

namespace TshirtStockMgtApp.App.ViewModel
{
    public class TshirtDetailViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        private Tshirt _selectedTshirt;
        private TshirtDataService _tshirtDataService;
        //public ObservableCollection<Category> Categories { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public Tshirt SelectedTshirt
        {
            get { return _selectedTshirt; }
            set
            {
                _selectedTshirt = value;
                RaisePropertyChanged("SelectedTshirt");
            }
        }

        public TshirtDetailViewModel()
        {
            SaveCommand = new CustomCommand(SaveTshirt, CanSaveTshirt);
            DeleteCommand = new CustomCommand(DeleteTshirt, CanDeleteTshirt);
            Messenger.Default.Register<Tshirt>(this, OnTshirtReceived);
            _tshirtDataService = new TshirtDataService();
            //LoadCategories();
        }

        //private void LoadCategories()
        //{
        //    Categories = _categoryDataService.GetCategories().ToObservableCollection();
        //}

        private void OnTshirtReceived(Tshirt tshirt)
        {
            SelectedTshirt = tshirt;
            //SelectedCategory = _categoryDataService.GetCategory(SelectedTshirt.CategoryID);
        }

        private bool CanDeleteTshirt(object obj)
        {
            return true;
        }

        private void DeleteTshirt(object obj)
        {
            _tshirtDataService.DeleteTshirt(SelectedTshirt);
            Messenger.Default.Send<UpdateListMessage>(new UpdateListMessage());
        }

        private bool CanSaveTshirt(object obj)
        {
            return true;
        }

        private void SaveTshirt(object obj)
        {
            //SelectedTshirt.CategoryID = SelectedCategory.CategoryID;
            _tshirtDataService.UpdateTshirt(SelectedTshirt);
            Messenger.Default.Send<UpdateListMessage>(new UpdateListMessage());
        }
    }
}
