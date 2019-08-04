using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaturitaChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_bookDataSet18.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter19.Fill(this.db_bookDataSet18.books);
            // TODO: This line of code loads data into the 'db_bookDataSet17.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter18.Fill(this.db_bookDataSet17.books);
            // TODO: This line of code loads data into the 'db_bookDataSet16.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter17.Fill(this.db_bookDataSet16.books);
            // TODO: This line of code loads data into the 'db_bookDataSet15.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter16.Fill(this.db_bookDataSet15.books);
            // TODO: This line of code loads data into the 'db_bookDataSet14.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter15.Fill(this.db_bookDataSet14.books);
            // TODO: This line of code loads data into the 'db_bookDataSet13.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter14.Fill(this.db_bookDataSet13.books);
            // TODO: This line of code loads data into the 'db_bookDataSet12.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter13.Fill(this.db_bookDataSet12.books);
            // TODO: This line of code loads data into the 'db_bookDataSet11.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter12.Fill(this.db_bookDataSet11.books);
            // TODO: This line of code loads data into the 'db_bookDataSet10.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter11.Fill(this.db_bookDataSet10.books);
            // TODO: This line of code loads data into the 'db_bookDataSet9.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter10.Fill(this.db_bookDataSet9.books);
            // TODO: This line of code loads data into the 'db_bookDataSet8.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter9.Fill(this.db_bookDataSet8.books);
            // TODO: This line of code loads data into the 'db_bookDataSet7.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter8.Fill(this.db_bookDataSet7.books);
            // TODO: This line of code loads data into the 'db_bookDataSet6.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter7.Fill(this.db_bookDataSet6.books);
            // TODO: This line of code loads data into the 'db_bookDataSet5.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter6.Fill(this.db_bookDataSet5.books);
            // TODO: This line of code loads data into the 'dataSetComplete.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter5.Fill(this.dataSetComplete.books);
            // TODO: This line of code loads data into the 'db_bookDataSet4.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter4.Fill(this.db_bookDataSet4.books);
            // TODO: This line of code loads data into the 'db_bookDataSet3.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter3.Fill(this.db_bookDataSet3.books);
            // TODO: This line of code loads data into the 'db_bookDataSet2.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter2.Fill(this.db_bookDataSet2.books);
            // TODO: This line of code loads data into the 'db_bookDataSet1.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter1.Fill(this.db_bookDataSet1.books);
            // TODO: This line of code loads data into the 'db_bookDataSet.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.db_bookDataSet.books);
            // TODO: This line of code loads data into the 'db_bookDataSet4.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter4.Fill(this.db_bookDataSet4.books);
            // TODO: This line of code loads data into the 'db_bookDataSet3.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter3.Fill(this.db_bookDataSet3.books);
            // TODO: This line of code loads data into the 'db_bookDataSet2.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter2.Fill(this.db_bookDataSet2.books);
            // TODO: This line of code loads data into the 'db_bookDataSet1.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter1.Fill(this.db_bookDataSet1.books);
            // TODO: This line of code loads data into the 'db_bookDataSet.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.db_bookDataSet.books);
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void buttonKontrola_Click(object sender, EventArgs e)
        {
            int stol18 = 0;
            int stol19 = 0;
            int svet = 0;
            int cesko = 0;
            int poezie = 0;
            int proza = 0;
            int drama = 0;
            List<string> knihyList = new List<string>();
            //nacteni dat z comboboxu
            //vygenerovat pole comboboxu ze kterho potom vyberu dle https://stackoverflow.com/questions/5905791/using-variables-in-object-names, https://stackoverflow.com/questions/50391518/c-sharp-fill-an-array-with-all-the-buttons-being-used-in-windows-form
            List<ComboBox> combobox = new List<ComboBox>();
            foreach (var item in this.Controls) // Looping through all controls in the form
            {
                if (item is ComboBox) // if the current is a button we add it
                {
                    combobox.Add(item as ComboBox);
                }
            }

            string[] knihy = new string[combobox.Count]; // bylo by fajn dát upozornění na 2 stejné knížky
            string[] time = new string[combobox.Count];
            string[] genre = new string[combobox.Count];
            //System.IO.File.Delete(@"E:\boxy.txt");
            //for (int i = 0; i < combobox.Count; i++)
            //{
            //    System.IO.File.AppendAllText(@"E:\boxy.txt", i + "." + Convert.ToString(combobox[i]) + (char)13 + (char)10);
            //}

            //pokus o zjištění dat korespojdujícíh s vybranými knihami
            //System.IO.File.Delete(@"E:\knihy.txt");
            foreach (DataTable thisTable in dataSetComplete.Tables) //https://docs.microsoft.com/cs-cz/dotnet/api/system.data.datatable.rows?view=netframework-4.8
            {
                int i = 0;
                foreach (DataRow row in thisTable.Rows)
                {
                    i++;
                    foreach (DataColumn column in thisTable.Columns)
                    {
                        knihyList.Add(Convert.ToString(row[column])); 
                    }
                }
            }
            //System.IO.File.Delete(@"E:\knihy.txt");
            //foreach (var cislo in knihyList)
            //{
            //    System.IO.File.AppendAllText(@"E:\knihy.txt", cislo + (char)13 + (char)10);
            //}

            for (int i = 0; i < combobox.Count; i++)
            {
                knihy[i] = combobox[i].Text; //zápis knih z komboboxu
                time[i] = knihyList[knihyList.IndexOf(knihy[i])+1] ;
                genre[i] = knihyList[knihyList.IndexOf(knihy[i]) + 2];
                //System.IO.File.AppendAllText(@"E:\knihy.txt", i + "." + knihy[i] + (char)13 + (char)10);
            }
            for (int i = 0; i < time.Length; i++)
            {
                switch (time[i])
                {
                    case "18":
                        stol18++;
                        break;
                    case "19":
                        stol19++;
                        break;
                    case "20c":
                        cesko++;
                        break;
                    case "20s":
                        svet++;
                        break;
                }
                switch (genre[i])
                {
                    case "po":
                        poezie++;
                        break;
                    case "pr":
                        proza++;
                        break;
                    case "dr":
                        drama++;
                        break;
                }
            }
            label18stol.Text = Convert.ToString(stol18);
            label19stol.Text = Convert.ToString(stol19);
            labelSvet.Text = Convert.ToString(svet);
            labelCesko.Text = Convert.ToString(cesko);
            labelPoezie.Text = Convert.ToString(poezie);
            labelProza.Text = Convert.ToString(proza);
            labelDrama.Text = Convert.ToString(drama);
            //test
            if (stol18>1)
            {
                label18stol.ForeColor = Color.Green;
            }
            else
            {
                label18stol.ForeColor = Color.Red;
            }
            if (stol19 > 2)
            {
                label19stol.ForeColor = Color.Green;
            }
            else
            {
                label19stol.ForeColor = Color.Red;
            }
            if (svet > 3)
            {
                labelSvet.ForeColor = Color.Green;
            }
            else
            {
                labelSvet.ForeColor = Color.Red;
            }
            if (cesko > 4)
            {
                labelCesko.ForeColor = Color.Green;
            }
            else
            {
                labelCesko.ForeColor = Color.Red;
            }
            if (poezie > 1)
            {
                labelPoezie.ForeColor = Color.Green;
            }
            else
            {
                labelPoezie.ForeColor = Color.Red;
            }
            if (proza > 1)
            {
                labelProza.ForeColor = Color.Green;
            }
            else
            {
                labelProza.ForeColor = Color.Red;
            }
            if (drama > 1)
            {
                labelDrama.ForeColor = Color.Green;
            }
            else
            {
                labelDrama.ForeColor = Color.Red;
            }
        }
        

    }
}
