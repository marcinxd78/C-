using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;

using System.Threading.Tasks;
using System.Windows.Input;


using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AplikacajaBaz
{
    public partial class Form1 : Form
    {
        public Form1()
        { //scalenie widoku aplikacji
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void logowanieBtn_Click(object sender, EventArgs e)
        {
            pobierzDane();
        }

        public void pobierzDane()
        {
            //pobierz dane logowania z formularza i przypisz
            //tworzenie nowego połączenia
            string mojePolaczenie =
            "SERVER=" + nazwaServeratb1.Text + ";" +
            "DATABASE=" + nazwaBazytb.Text + ";" +
            "UID=" + uzytkowniktb.Text + ";" +
            "PASSWORD=" + haslotb.Text + ";";

            //wykonaj polecenie języka SQL, zapytanie sql
            string sql = "SELECT * FROM " + lista.Text +";" ;

            

            //ustanowienie obiektu połączenia z bazą danych wykorzystjąc connection oraz wcześniej stworzonego płączenia podanego w string
            MySqlConnection polaczenie = new MySqlConnection(mojePolaczenie);
            //blok try-catch przechwytuje błędy
            try
            {
                //otwórz połączenie z bazą danych
                polaczenie.Open();
                //wykonaj polecenie języka SQL na danych połączeniu, zarezerwowanie pamięci do wykonania danej operacji, wykonanie operacji, zwolnienie pamięci, obiekt dostepny tylko w bloku using 
                using (MySqlCommand cmdSel = new MySqlCommand(sql, polaczenie))
                {
                    DataTable dt = new DataTable();
                    //Pobierz dane i zapisz w strukturze DataTable
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                    da.Fill(dt);
                    //wpisz dane do kontrolki DATAGRID
                    dataGrid1.DataSource = dt.DefaultView;
                }


                


                }
                //Jeżeli wystąpi wyjątek wyrzuć go i pokaż informacje obłędach połączenia, bazy danych itd.,błąd wynikający z mysqlconnection
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show("Błąd logowania do bazy danych MySQL", "Błąd");
                }
                //Zamknij połączenie po wyświetleniu danych
               polaczenie.Close();









            
    }
        private void button1_Click(object sender, EventArgs e)
        {
            wyszukaj();
            kol.Clear();
        }

        public void wyszukaj()
        {
            string mojePolaczenie2 =
           "SERVER=" + nazwaServeratb1.Text + ";" +
           "DATABASE=" + nazwaBazytb.Text + ";" +
           "UID=" + uzytkowniktb.Text + ";" +
           "PASSWORD=" + haslotb.Text + ";";

            //wykonaj polecenie języka SQL
            string sql2 = "SELECT * FROM " + lista.Text + " WHERE " + atrybut.Text + "=" + kol.Text + ";";
            

        
           //string mojePolaczenie2 = null;
           MySqlConnection polaczenie2 = new MySqlConnection(mojePolaczenie2);
            //blok try-catch przechwytuje błędy
            try
            {
                //otwórz połączenie z bazą danych
                polaczenie2.Open();
                //wykonaj polecenie języka SQL na danych połączeniu
                using (MySqlCommand cmdSel2 = new MySqlCommand(sql2, polaczenie2))
                {
                    DataTable dt = new DataTable();
                    //Pobierz dane i zapisz w strukturze DataTable
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel2);
                    da.Fill(dt);
                    //wpisz dane do kontrolki DATAGRID
                    dataGrid1.DataSource = dt.DefaultView;
                }





            }
            //Jeżeli wystąpi wyjątek wyrzuć go i pokaż informacje
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Wprowadź wartości", "Błąd");
            }
            //Zamknij połączenie po wyświetleniu danych
           polaczenie2.Close();










        }

        public void dodaj()
        {
            string mojePolaczenie3 =
           "SERVER=" + nazwaServeratb1.Text + ";" +
           "DATABASE=" + nazwaBazytb.Text + ";" +
           "UID=" + uzytkowniktb.Text + ";" +
           "PASSWORD=" + haslotb.Text + ";";

            //wykonaj polecenie języka SQL
            string sql3 = "INSERT INTO pacjent (nr_ubez, imie, nazwisko,adres,numer)  VALUES('" +nr_ubez.Text+"', '"+ Imie.Text+"','" + Nazwisko.Text+"','" + Adres.Text+"' ,'"+ Numer.Text +"' )" ;



            //string mojePolaczenie2 = null;
            MySqlConnection polaczenie3 = new MySqlConnection(mojePolaczenie3);
            //blok try-catch przechwytuje błędy
            try
            {
                //otwórz połączenie z bazą danych
                polaczenie3.Open();
                //wykonaj polecenie języka SQL na danych połączeniu
                using (MySqlCommand cmdSel3 = new MySqlCommand(sql3, polaczenie3))
                {
                    DataTable dt = new DataTable();
                    //Pobierz dane i zapisz w strukturze DataTable
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel3);
                    da.Fill(dt);
                    //wpisz dane do kontrolki DATAGRID
                    dataGrid1.DataSource = dt.DefaultView;
                }





            }
            //Jeżeli wystąpi wyjątek wyrzuć go i pokaż informacje
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Błąd dodawania", "Błąd");
            }
            //Zamknij połączenie po wyświetleniu danych
            polaczenie3.Close();

        }

        public void uaktual()
        {
            string mojePolaczenie5 =
           "SERVER=" + nazwaServeratb1.Text + ";" +
           "DATABASE=" + nazwaBazytb.Text + ";" +
           "UID=" + uzytkowniktb.Text + ";" +
           "PASSWORD=" + haslotb.Text + ";";

            //wykonaj polecenie języka SQL
            //string sql5 = "UPDATE pacjent SET imie, nazwisko,adres,numer  " WHERE nr_ubez "     " = " + nr_ubez.Text + ";";
           // " WHERE " + atrybut.Text + "=" + kol.Text + ";";

            //string mojePolaczenie2 = null;
            MySqlConnection polaczenie5 = new MySqlConnection(mojePolaczenie5);
            //blok try-catch przechwytuje błędy
            try
            {
                //otwórz połączenie z bazą danych
                polaczenie5.Open();
                //wykonaj polecenie języka SQL na danych połączeniu
                using (MySqlCommand cmdSel5 = new MySqlCommand(sql5, polaczenie5))
                {
                    DataTable dt = new DataTable();
                    //Pobierz dane i zapisz w strukturze DataTable
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel5);
                    da.Fill(dt);
                    //wpisz dane do kontrolki DATAGRID
                    dataGrid1.DataSource = dt.DefaultView;
                }





            }
            //Jeżeli wystąpi wyjątek wyrzuć go i pokaż informacje
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Błąd dodawania", "Błąd");
            }
            //Zamknij połączenie po wyświetleniu danych
            polaczenie5.Close();

        }


        public void cleen()
        {
            string mojePolaczenie4 =
           "SERVER=" + nazwaServeratb1.Text + ";" +
           "DATABASE=" + nazwaBazytb.Text + ";" +
           "UID=" + uzytkowniktb.Text + ";" +
           "PASSWORD=" + haslotb.Text + ";";

            //wykonaj polecenie języka SQL
            string sql4 = "DELETE  FROM " + lista.Text + " WHERE " + atrybut.Text + "=" + kol.Text + ";";



            //string mojePolaczenie2 = null;
            MySqlConnection polaczenie4 = new MySqlConnection(mojePolaczenie4);
            //blok try-catch przechwytuje błędy
            try
            {
                //otwórz połączenie z bazą danych
                polaczenie4.Open();
                //wykonaj polecenie języka SQL na danych połączeniu
                using (MySqlCommand cmdSel4 = new MySqlCommand(sql4, polaczenie4))
                {
                    DataTable dt = new DataTable();
                    //Pobierz dane i zapisz w strukturze DataTable
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel4);
                    da.Fill(dt);
                    //wpisz dane do kontrolki DATAGRID
                    dataGrid1.DataSource = dt.DefaultView;
                }





            }
            //Jeżeli wystąpi wyjątek wyrzuć go i pokaż informacje
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Błąd wprowadz dane", "Błąd");
            }
            //Zamknij połączenie po wyświetleniu danych
            polaczenie4.Close();

        }


        private void kol_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            pobierzDane();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dodaj();
           
            pobierzDane();
            nr_ubez.Clear();
            Imie.Clear();
            Nazwisko.Clear();
            Adres.Clear();
            Numer.Clear();
        }

        private void usunBtn_Click(object sender, EventArgs e)
        {
            cleen();
            pobierzDane();
            kol.Clear();
        }

        private void uakt_Click(object sender, EventArgs e)
        {
            uaktual();
            pobierzDane();
        }
    }
}
