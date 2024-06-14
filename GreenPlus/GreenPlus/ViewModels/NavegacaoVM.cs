using GreenPlus.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GreenPlus.ViewModels
{
    class NavegacaoVM : ViewModelBase
    {
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand ProdutoCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeVM();
        private void Produto(object obj) => CurrentView = new ProdutoVM();

        public NavegacaoVM()
        {
            HomeCommand = new RelayCommand(Home);
            ProdutoCommand = new RelayCommand(Produto);

            CurrentView = new HomeVM();

        }
    }
}
