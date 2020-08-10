using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Runtime.Serialization.Formatters.Binary;

namespace MaturitaChecker
{
    public partial class Form1 : Form
    {
        protected string filename = "Data.txt";
        protected string hash = "66CC52784EADF17A696D7E8E9AEB75F2";
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string md5 = GetMD5HashFromFile(filename);
            if (md5 != hash)
            {
                MessageBox.Show("Nesprávný, nebo chybějící datový soubor","Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                List<ComboBox> combobox = AllComboboxes();
                string jsonDataset = System.IO.File.ReadAllText(filename);
                //DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(jsonDataset);
                //for (int i = 0; i < combobox.Count; i++)
                //{
                //    DataSet dataSetCopy = JsonConvert.DeserializeObject<DataSet>(jsonDataset);
                //    dataSets.Add(dataSetCopy);
                //}
                foreach (ComboBox combo in combobox)
                {
                    combo.DataSource = JsonConvert.DeserializeObject<DataSet>(jsonDataset).Tables["books"];
                    combo.DisplayMember = "Name";
                }
                for (int i = 0; i < combobox.Count; i++)
                {
                    combobox[i].SelectedItem = null;
                    combobox[i].SelectedText = "--Zvolte knihu--";
                }
                //combobox[1].SelectedText = md5;
                //List<db_bookDataSetTableAdapters.booksTableAdapter> tableAdapters = new List<db_bookDataSetTableAdapters.booksTableAdapter>();
                //foreach (db_bookDataSetTableAdapters.booksTableAdapter tableAdapter in this)
                //{
                //    tableAdapters.Add(tableAdapter);
                //}
                //SaveData();
            }
        }
        //public void SaveData()
        //{
        //string json = JsonConvert.SerializeObject(this.db_bookDataSet, Formatting.Indented);
        //System.IO.File.Delete(@"E:\jsonDataSet.txt");
        //    System.IO.File.AppendAllText(@"E:\jsonDataSet.txt", json);
        //    json = JsonConvert.SerializeObject(this.dataSetComplete, Formatting.Indented);
        //System.IO.File.Delete(@"E:\jsonDataSetComplete.txt");
        //    System.IO.File.AppendAllText(@"E:\jsonDataSetComplete.txt", json);
        //}
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
            List<ComboBox> combobox = AllComboboxes();

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
            dataSetComplete dataSetComplete = JsonConvert.DeserializeObject<dataSetComplete>(System.IO.File.ReadAllText(this.filename));
            foreach (DataTable thisTable in dataSetComplete.Tables) //https://docs.microsoft.com/cs-cz/dotnet/api/system.data.datatable.rows?view=netframework-4.8
            {
                foreach (DataRow row in thisTable.Rows)
                {
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
                knihy[i] = combobox[i].Text; //zápis knih z comboboxu
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
            List<string> list = new List<string>();
            foreach (ComboBox comboBox in combobox)
            {
                if (list.Contains(comboBox.Text)&& comboBox.Text != "--Zvolte knihu--")
                {
                    MessageBox.Show("Kniha "+comboBox.Text+" je zvolena více než jednou.", "Duplicitní volba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
                else
                {
                    list.Add(comboBox.Text);
                }
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            List<ComboBox> combobox = AllComboboxes();
            string path = null;
            saveFileDialog1.FileName = "seznam cetby"; // Default file name
            saveFileDialog1.DefaultExt = ".txt"; // Default file extension
            saveFileDialog1.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension
            try
            {

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Save document
                    path = saveFileDialog1.FileName;
                }
                System.IO.File.Delete(path);
                for (int i = 0; i < combobox.Count; i++)
                {
                    System.IO.File.AppendAllText(path, combobox[combobox.Count - i - 1].Text + (char)13 + (char)10);
                }
            }
            catch
            {

            }
        }

        private List<ComboBox> AllComboboxes()
        {
            List<ComboBox> combobox = new List<ComboBox>();
            foreach (var item in this.Controls) // Looping through all controls in the form
            {
                if (item is ComboBox) // if the current is a button we add it
                {
                    combobox.Add(item as ComboBox);
                }
            }
            return combobox;
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            List<ComboBox> combobox = AllComboboxes();
            string path = null;

            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog1.FileName;
                }
                string[] lines = File.ReadAllLines(path);
                for (int i = 0; i < combobox.Count; i++)
                {
                    combobox[i].Text = lines[combobox.Count - i - 1];
                }
            }
            catch
            {
            }
            

        }
        //private static void TextFileToBinary(string TexFilePath)
        //{
        //    string fileContents;
        //    using (FileStream fileStream = new FileStream(TexFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
        //    {
        //        using (StreamReader sr = new StreamReader(fileStream))
        //        {
        //            fileContents = sr.ReadToEnd();
        //        }
        //    }
        //    using (FileStream fs = new FileStream(TexFilePath.Replace("txt", "bin"), FileMode.Create))
        //    {
        //        // Construct a BinaryFormatter and use it to serialize the data to the stream.
        //        BinaryFormatter formatter = new BinaryFormatter();
        //        formatter.Serialize(fs, fileContents);
        //    }
        //}
        //private static void BinaryToTextFile(string BinaryFilePath)
        //{
        //    string fileContents;
        //    using (FileStream fileStream = new FileStream(BinaryFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
        //    {
        //        BinaryFormatter formatter = new BinaryFormatter();
        //        fileContents = (string)formatter.Deserialize(fileStream);
        //    }
        //    using (FileStream fs = new FileStream(BinaryFilePath.Replace("bin", "txt"), FileMode.Create))
        //    {
        //        using (StreamWriter sw = new StreamWriter(BinaryFilePath.Replace("bin", "txt")))
        //        {
        //            sw.Write(fileContents);
        //        }
        //    }
        //}
        protected string GetMD5HashFromFile(string fileName)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
        }
    }
}
