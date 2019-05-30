using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TshirtStockMgtApp.App.Extensions;
using TshirtStockMgtApp.App.Messages;
using TshirtStockMgtApp.App.Services;
using TshirtStockMgtApp.App.Utility;
using TshirtStockMgtApp.Model;

namespace TshirtStockMgtApp.App.ViewModel
{
    public class TshirtOverviewViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private TshirtDataService _tshirtDataService;
        private DialogService _dialogService;

        public ICommand EditCommand { get; set; }
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        private ObservableCollection<Tshirt> _tshirt;
        public ObservableCollection<Tshirt> Tshirt
        {
            get
            {
                return _tshirt;
            }
            set
            {
                _tshirt = value;
                RaisePropertyChanged("Tshirts");
            }
        }
        private Tshirt _selectedTshirt;
        public Tshirt SelectedTshirt
        {
            get
            {
                return _selectedTshirt;
            }
            set
            {
                _selectedTshirt = value;
                RaisePropertyChanged("SelectedTshirt");
            }
        }
        public TshirtOverviewViewModel()
        {
            _tshirtDataService = new TshirtDataService();
            LoadData();
            LoadCommands();
            Messenger.Default.Register<UpdateListMessage>(this, OnUpdateListMessage);
            _dialogService = new DialogService();
        }

        private void OnUpdateListMessage(UpdateListMessage obj)
        {
            LoadData();
            _dialogService.CloseDialog();
        }

        private void LoadCommands()
        {
            //initialize my command
            //Action is the code to invoke when the command is invoked
            //CanExecute is the predicate that determines if the command can be executed.
            EditCommand = new CustomCommand(EditTshirt, CanEditTshirt);
        }

        private bool CanEditTshirt(object obj)
        {
            if (SelectedTshirt != null)
                return true;
            return false;
        }

        private void EditTshirt(object obj)
        {
            Messenger.Default.Send<Tshirt>(SelectedTshirt);
            _dialogService.ShowDialog();
        }

        private void LoadData()
        {
            Tshirt = _tshirtDataService.GetAllTshirts().ToObservableCollection();
        }
    
    }
}
