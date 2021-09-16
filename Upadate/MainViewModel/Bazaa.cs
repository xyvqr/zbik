using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Upadate.Model;

namespace Upadate.MainViewModel
{
    public static class Bazaa
    {

        private static string UserDB = "Michal";
        private static string PassDB = "1234";
        public static string AdressDB = @"DESKTOP-QCKQLBB\SQLEXPRESS";
        public static string NameDB = "ZbikIntegracja";
        private static string PolaczenieSQL = PolaczenieSQL = @"Server=" + AdressDB + ";user=" + UserDB + ";password=" + PassDB + ";database=" + NameDB + "";
        private static SqlConnection polaczsql;

        public static BindingList<Model.Zlecenie> SQL_SelectZlecenie_id()
        {
            BindingList<Model.Zlecenie> lista_zlecenie = new BindingList<Model.Zlecenie>();
            try
            {
                string zapytanie = @"SELECT TOP 1000 [Zlecenie_IdErp]
,[Zlecenie_Numer]
,[Zlecenie_IdPozycji]
,[Zlecenie_Ilosc]
,[Zlecenie_WymaganaDataProdukcji]
,[DataWstawieniaERP]
,[DataPobraniaMES]
,[StatusMES]
,[Aktywny]
,[Zlecenie_Kod]
FROM [ut_erp_zlecenia]";
                polaczsql = new SqlConnection(PolaczenieSQL);
                using (polaczsql)
                {
                    SqlCommand pobierz_zlecenia = new SqlCommand();
                    pobierz_zlecenia.Connection = polaczsql;
                    pobierz_zlecenia.CommandText = zapytanie;
                    polaczsql.Open();
                    SqlDataReader reader = pobierz_zlecenia.ExecuteReader();
                    while (reader.Read())
                    {
                        Model.Zlecenie zlecc = new Model.Zlecenie();
                        zlecc.Zlecenie_IdErp = (int)reader["zlecenie_IdErp"];
                        zlecc.Zlecenie_Numer = reader["zlecenie_Numer"].ToString();
                        zlecc.Zlecenie_IdPozycji = (int)reader["zlecenie_IdPozycji"];
                        zlecc.Zlecenie_Ilosc = (decimal)reader["zlecenie_Ilosc"];
                        zlecc.Zlecenie_WymaganaDataProdukcji = (DateTime)reader["zlecenie_WymaganaDataProdukcji"];
                        zlecc.DataWstawieniaERP = (DateTime)reader["dataWstawieniaERP"];
                        zlecc.DataPobraniaMES = (DateTime)reader["dataPobraniaMES"];
                        zlecc.StatusMES = (short)reader["statusMES"];
                        zlecc.Aktywny = (short)reader["aktywny"];
                        zlecc.Zlecenie_Kod = reader["zlecenie_Kod"].ToString();
                        lista_zlecenie.Add(zlecc);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            polaczsql.Close();
            return lista_zlecenie;

        }

    
        public static BindingList<Model.Bom> SQL_SelectBom(int Id_zlecenia)
        {
            BindingList<Model.Bom> lista_bom = new BindingList<Model.Bom>();
            try
            {
                string zapytanie = @"SELECT TOP (100) [Bom_Id]
      ,[Bom_IdErp]
      ,[Bom_IdZlecenia]
      ,[Bom_IdOperacji]
      ,[Bom_IdPozycji]
	  ,isnull(isnull([Pozycja_Indeks], Zasob_Kod), Gniazdo_Kod) as TypUslugi
      ,[Bom_Ilosc]
      ,[Bom_TypPozycji]
      ,[Bom_WielkoscPartii]
      ,[Bom_IloscWCyklu]
  FROM [ZbikIntegracja].[dbo].[ut_erp_bom_zp]
left join[ZbikIntegracja].[dbo].[ut_erp_kartoteki_mag] on[Pozycja_IdErp] =[Bom_IdPozycji] and[Bom_TypPozycji] in (1, 5)
left join[ZbikIntegracja].[dbo].ut_erp_zasoby on[Bom_IdPozycji] =[Zasob_IdErp] and[Bom_TypPozycji] in (2)
left join[ZbikIntegracja].[dbo].ut_erp_gniazda on[Bom_IdPozycji] =[Gniazdo_IdErp] and[Bom_TypPozycji] in (3) where Bom_IdZlecenia = " + Id_zlecenia;
                polaczsql = new SqlConnection(PolaczenieSQL);
                using (polaczsql)
                {
                    SqlCommand pobierz_zlecenia = new SqlCommand();
                    pobierz_zlecenia.Connection = polaczsql;
                    pobierz_zlecenia.CommandText = zapytanie;
                    polaczsql.Open();
                    SqlDataReader reader = pobierz_zlecenia.ExecuteReader();
                    while (reader.Read())
                    {
                        Model.Bom zlecc = new Model.Bom();
                        zlecc.Bom_Id = (int)reader["bom_Id"];
                        zlecc.Bom_IdErp = (int)reader["bom_IdErp"];
                        zlecc.Bom_IdZlecenia = (int)reader["bom_IdZlecenia"];
                        zlecc.Bom_IdOperacji = (int)reader["bom_IdOperacji"];
                        zlecc.Bom_IdPozycji = (int)reader["bom_IdPozycji"];
                        zlecc.Bom_TypUslugi = (string)reader["TypUslugi"];
                        zlecc.Bom_Ilosc = (decimal)reader["bom_Ilosc"];
                        zlecc.Bom_TypPozycji = (int)reader["bom_TypPozycji"];
                        zlecc.Bom_WielkoscPartii = (decimal)reader["bom_WielkoscPartii"];
                        zlecc.Bom_IloscWCyklu = (decimal)reader["bom_IloscWCyklu"];
                        lista_bom.Add(zlecc);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            polaczsql.Close();
            return lista_bom;

        }
        public static BindingList<Model.Marszrut> SQL_SelectMarszrut(int Id_zlecenia)
        {
            BindingList<Model.Marszrut> lista_marsz = new BindingList<Model.Marszrut>();
            try
            {
                string zapytanie = @"select Top 50  [Marszruta_Id]
      ,[Marszruta_IdZlecenia]
      ,[Marszruta_IdOperacji]
      ,[Marszruta_NrOperacji]
      ,[Marszruta_KodOperacji]
      ,[Marszruta_IndeksPozycji]
      ,[Marszruta_Ilosc]
      ,[Marszruta_IdPozycji]
      ,[DataWstawieniaERP]
      ,[DataPobraniaMES]
      ,[StatusMES]
      ,[Aktywny]
From ut_erp_marszruta_zp where [Marszruta_IdZlecenia] =" + Id_zlecenia.ToString();


                polaczsql = new SqlConnection(PolaczenieSQL);
                using (polaczsql)
                {
                    SqlCommand pobierz_zlecenia = new SqlCommand();
                    pobierz_zlecenia.Connection = polaczsql;
                    pobierz_zlecenia.CommandText = zapytanie;
                    polaczsql.Open();
                    SqlDataReader reader = pobierz_zlecenia.ExecuteReader();
                    while (reader.Read())
                    {
                        Model.Marszrut zlecc = new Model.Marszrut();
                        zlecc.Marszruta_Id = (int)reader["Marszruta_Id"];
                        zlecc.Marszruta_IdZlecenia = (int)reader["marszruta_IdZlecenia"];
                        zlecc.Marszruta_IdOperacji = (int)reader["marszruta_IdOperacji"];
                        zlecc.Marszruta_NrOperacji = (int)reader["marszruta_NrOperacji"];
                        zlecc.Marszruta_KodOperacji = reader["marszruta_KodOperacji"].ToString();
                        zlecc.Marszruta_IndeksPozycji = reader["marszruta_IndeksPozycji"].ToString();
                        zlecc.Marszruta_Ilosc = (decimal)reader["marszruta_Ilosc"];
                        zlecc.Marszruta_IdPozycji = (int)reader["marszruta_IdPozycji"];
                        zlecc.DataWstawieniaERP = (DateTime)reader["dataWstawieniaERP"];
                        zlecc.DataPobraniaMES = (DateTime)reader["DataPobraniaMES"];
                        zlecc.StatusMES = (short)reader["statusMES"];
                        zlecc.Aktywny = (short)reader["aktywny"];
                        lista_marsz.Add(zlecc);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            polaczsql.Close();
            return lista_marsz;


        }

    }
}

