using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upadate.Model
{
    public class Marszrut : INotifyPropertyChanged
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

        private int marszruta_Id;
        public int Marszruta_Id
        {
            get { return marszruta_Id; }
            set
            {
                marszruta_Id = value;
                OnPropertyChanged(nameof(Marszruta_Id));
            }
        }

        private int marszruta_IdZlecenia;
        public int Marszruta_IdZlecenia
        {
            get { return marszruta_IdZlecenia; }
            set
            {
                marszruta_IdZlecenia = value;
                OnPropertyChanged(nameof(Marszruta_IdZlecenia));
            }
        }
        private int marszruta_IdOperacji;
        public int Marszruta_IdOperacji
        {
            get { return marszruta_IdOperacji; }
            set
            {
                marszruta_IdOperacji = value;
                OnPropertyChanged(nameof(Marszruta_IdOperacji));
            }
        }
        private int marszruta_NrOperacji;
        public int Marszruta_NrOperacji
        {
            get { return marszruta_NrOperacji; }
            set
            {
                marszruta_NrOperacji = value;
                OnPropertyChanged(nameof(Marszruta_NrOperacji));
            }
        }
        private string marszruta_KodOperacji;
        public string Marszruta_KodOperacji
        {
            get { return marszruta_KodOperacji; }
            set
            {
                marszruta_KodOperacji = value;
                OnPropertyChanged(nameof(Marszruta_KodOperacji));
            }
        }
        private string marszruta_IndeksPozycji;
        public string Marszruta_IndeksPozycji
        {
            get { return marszruta_IndeksPozycji; }
            set
            {
                marszruta_IndeksPozycji = value;
                OnPropertyChanged(nameof(Marszruta_IndeksPozycji));
            }
        }
        private decimal marszruta_Ilosc;
        public decimal Marszruta_Ilosc
        {
            get { return marszruta_Ilosc; }
            set
            {
                marszruta_Ilosc = value;
                OnPropertyChanged(nameof(Marszruta_Ilosc));
            }
        }
        private int marszruta_IdPozycji;
        public int Marszruta_IdPozycji
        {
            get { return marszruta_IdPozycji; }
            set
            {
                marszruta_IdPozycji = value;
                OnPropertyChanged(nameof(Marszruta_IdPozycji));
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



    }
}
