using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upadate.Model
{
    public class Zlecenie : INotifyPropertyChanged
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

        private int zlecenie_IdErp;
        public int Zlecenie_IdErp
        {
            get { return zlecenie_IdErp; }
            set
            {
                zlecenie_IdErp = value;
                OnPropertyChanged(nameof(Zlecenie_IdErp));
            }
        }
        private string zlecenie_Numer;
        public string Zlecenie_Numer
        {
            get { return zlecenie_Numer; }
            set
            {
                zlecenie_Numer = value;
                OnPropertyChanged(nameof(Zlecenie_Numer));
            }
        }
        private int zlecenie_IdPozycji;
        public int Zlecenie_IdPozycji
        {
            get { return zlecenie_IdPozycji; }
            set
            {
                zlecenie_IdPozycji = value;
                OnPropertyChanged(nameof(Zlecenie_IdPozycji));
            }
        }
        private decimal zlecenie_Ilosc;
        public decimal Zlecenie_Ilosc
        {
            get { return zlecenie_Ilosc; }
            set
            {
                zlecenie_Ilosc = value;
                OnPropertyChanged(nameof(Zlecenie_Ilosc));
            }
        }
        private DateTime zlecenie_WymaganaDataProdukcji;
        public DateTime Zlecenie_WymaganaDataProdukcji
        {
            get { return zlecenie_WymaganaDataProdukcji; }
            set
            {
                zlecenie_WymaganaDataProdukcji = value;
                OnPropertyChanged(nameof(Zlecenie_WymaganaDataProdukcji));
            }
        }
        private DateTime dataWstawieniaERP;
        public DateTime DataWstawieniaERP
        {
            get { return dataWstawieniaERP; }
            set
            {
                dataWstawieniaERP = value;
                OnPropertyChanged(nameof(DataWstawieniaERP));
            }

        }
        private DateTime dataPobraniaMES;
        public DateTime DataPobraniaMES
        {
            get { return dataPobraniaMES; }
            set
            {
                dataPobraniaMES = value;
                OnPropertyChanged(nameof(DataPobraniaMES));
            }
        }
        private short statusMES;
        public short StatusMES
        {
            get { return statusMES; }
            set
            {
                statusMES = value;
                OnPropertyChanged(nameof(StatusMES));
            }
        }
        private short aktywny;
        public short Aktywny
        {
            get { return aktywny; }
            set
            {
                aktywny = value;
                OnPropertyChanged(nameof(Aktywny));
            }
        }
        private string zlecenie_Kod;
        public string Zlecenie_Kod
        {
            get { return zlecenie_Kod; }
            set
            {
                zlecenie_Kod = value;
                OnPropertyChanged(nameof(Zlecenie_Kod));
            }
        }

    }
}