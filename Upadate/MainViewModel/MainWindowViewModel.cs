using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Upadate.MainViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(params string[] nazwyWlasciwosci)
        {
            if (PropertyChanged != null)
            {
                foreach (string nazwaWlasciwosci in nazwyWlasciwosci) PropertyChanged(this, new PropertyChangedEventArgs(nazwaWlasciwosci));
            }
        }
        #endregion //PropertyChanged
        private BindingList<Model.Zlecenie> lista_zlecen;
        public BindingList<Model.Zlecenie> Lista_zlecen
        {
            get
            {
                return lista_zlecen;
            }
            set
            {
                if (lista_zlecen != value)
                {
                    lista_zlecen = value;
                    OnPropertyChanged(nameof(Lista_zlecen));
                }
            }

        }
        public MainWindowViewModel()
        {
            lista_zlecen = Bazaa.SQL_SelectZlecenie_id();
            //lista_bom = Bazaa.SQL_SelectBom(69839);
            //lista_marsz = Bazaa.SQL_SelectMarszrut(69839);
        }
        private Model.Zlecenie wybraneZlecenie;
        public Model.Zlecenie WybraneZlecenie
        {
            get
            {
                return wybraneZlecenie;
            }
            set
            {
                if (wybraneZlecenie != value)
                {
                    wybraneZlecenie = value;
                    OnPropertyChanged(nameof(WybraneZlecenie));
                }
            }
        }
        private BindingList<Model.Bom> lista_bom;
        public BindingList<Model.Bom> Lista_bom
        {
            get
            {
                return lista_bom;
            }
            set
            {
                if (lista_bom != value)
                {
                    lista_bom = value;
                    OnPropertyChanged(nameof(Lista_bom));
                }
            }

        }
        //private ICommand infoCommand;
        //public ICommand InfoCommand
        //{
        //    get
        //    {
        //        if (infoCommand == null)
        //        {
        //            infoCommand = new RelayCommand(parametr => Wyswietl(), parametr =>
        //            {
        //                return true;
        //            });
        //        }
        //        return infoCommand;
        //    }
        //}




        //private void Wyswietl()
        //{
        //    int Id_zlecenia = WybraneZlecenie.Zlecenie_IdErp;
        //    Lista_marsz = Bazaa.SQL_SelectMarszrut(Id_zlecenia);
        //    Lista_bom = Bazaa.SQL_SelectBom(Id_zlecenia);
           
        //  //  OnPropertyChanged(nameof(Lista_marsz));
        //}

        //private bool otworzDialogBom;
        //public bool OtworzDialogBom
        //{
        //    get { return otworzDialogBom; }
        //    set
        //    {
        //        otworzDialogBom = value;
        //        OnPropertyChanged(nameof(OtworzDialogBom));
        //    }
        //}
        private BindingList<Model.Marszrut> lista_marsz;
        public BindingList<Model.Marszrut> Lista_marsz
        {
            get
            {
                return lista_marsz;
            }
            set
            {
                if (lista_marsz != value)
                {
                    lista_marsz = value;
                    OnPropertyChanged(nameof(Lista_marsz));
                }
            }

        }
        //private void WyswietlMarsz()
        //{
        //    int Id_zlecenia = WybraneZlecenie.Zlecenie_IdErp;
        //    Lista_bom = Bazaa.SQL_SelectBom(Id_zlecenia);
        //    Lista_marsz = Bazaa.SQL_SelectMarszrut(Id_zlecenia);
        //    OtworzDialogMarsz = true;
        //}

        //private bool otworzDialogMarsz;
        //public bool OtworzDialogMarsz
        //{
        //    get { return otworzDialogMarsz; }
        //    set
        //    {
        //        otworzDialogBom = value;
        //        OnPropertyChanged(nameof(OtworzDialogMarsz));
        //    }
        //}
        //private BindingList<Model.Marszrut> lista_marsz;
        //public BindingList<Model.Marszrut> Lista_marsz
        //{
        //    get
        //    {
        //        return lista_marsz;
        //    }
        //    set
        //    {
        //        if (lista_marsz != value)
        //        {
        //            lista_marsz = value;
        //            OnPropertyChanged(nameof(Lista_marsz));
        //        }
        //    }



    }
    
}
