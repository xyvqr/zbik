using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upadate.Model
{
    public class Bom : INotifyPropertyChanged
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


        private int bom_Id;
        public int Bom_Id
        {
            get { return bom_Id; }
            set
            {
                bom_Id = value;
                OnPropertyChanged(nameof(Bom_Id));
            }

        }
        private int bom_IdErp;
        public int Bom_IdErp
        {
            get { return bom_IdErp; }
            set
            {
                bom_IdErp = value;
                OnPropertyChanged(nameof(Bom_IdErp));
            }

        }
        private int bom_IdZlecenia;
        public int Bom_IdZlecenia
        {
            get { return bom_IdZlecenia; }
            set
            {
                bom_IdZlecenia = value;
                OnPropertyChanged(nameof(Bom_IdZlecenia));
            }
        }
        private int bom_IdOperacji;
        public int Bom_IdOperacji
        {
            get { return bom_IdOperacji; }
            set
            {
                bom_IdOperacji = value;
                OnPropertyChanged(nameof(Bom_IdOperacji));
            }

        }
        private int bom_IdPozycji;
        public int Bom_IdPozycji
        {
            get { return bom_IdPozycji; }
            set
            {
                bom_IdPozycji = value;
                OnPropertyChanged(nameof(Bom_IdPozycji));
            }

        }
        private string bom_TypUslugi;
        public string Bom_TypUslugi
        {
            get { return bom_TypUslugi; }
            set
            {
                bom_TypUslugi = value;
                OnPropertyChanged(nameof(Bom_TypUslugi));
            }

        }
        private decimal bom_Ilosc;
        public decimal Bom_Ilosc
        {
            get { return bom_Ilosc; }
            set
            {
                bom_Ilosc = value;
                OnPropertyChanged(nameof(Bom_Ilosc));
            }

        }
        private int bom_TypPozycji;
        public int Bom_TypPozycji
        {
            get { return bom_TypPozycji; }
            set
            {
                bom_TypPozycji = value;
                OnPropertyChanged(nameof(Bom_TypPozycji));
            }

        }
        private decimal bom_WielkoscPartii;
        public decimal Bom_WielkoscPartii
        {
            get { return bom_WielkoscPartii; }
            set
            {
                bom_WielkoscPartii = value;
                OnPropertyChanged(nameof(Bom_WielkoscPartii));
            }

        }
        private decimal bom_IloscWCyklu;
        public decimal Bom_IloscWCyklu
        {
            get { return bom_IloscWCyklu; }
            set
            {
                bom_IloscWCyklu = value;
                OnPropertyChanged(nameof(Bom_IloscWCyklu));
            }

        }

    }
}
