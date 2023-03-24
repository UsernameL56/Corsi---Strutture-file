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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Corsi___Strutture_file
{
    public partial class Form1 : Form
    {
        public struct prodotto
        {
            public string nome;
            public float prezzo;
            public bool presente;
        }
        string file, appoggio;
        string line;
        public prodotto P;
        StreamReader reader = null;
        StreamWriter writer = null;
        StreamWriter writerApp = null;
        public Form1()
        {
            InitializeComponent();
            file = @"File.csv";
            appoggio = @"FileAppoggio.csv";
        }

        private void Salva_Click(object sender, EventArgs e)
        {
            P.nome = textBox1.Text;
            P.prezzo = float.Parse(textBox2.Text);
            P.presente = true;
            StreamWriter writer = new StreamWriter(file, true);
            writer.WriteLine(P.nome + ";" + P.prezzo);
            writer.Close();

        }

        private void Svuotamento_Click(object sender, EventArgs e)
        {
            writer = new StreamWriter(file, false);
            writer.Close();
        }
        private void salvataggio_Click(object sender, EventArgs e)
        {

            StreamReader reader = new StreamReader(file, false);
            line = reader.ReadLine();
            listView1.Clear();
            while (line != null)
            {
                if (P.presente == true)
                {
                    listView1.Items.Add(line);
                }

                line = reader.ReadLine();
            }
            reader.Close();

        }

        private void cancellazione_Click(object sender, EventArgs e)
        {
            writerApp = new StreamWriter(appoggio, false);
            Cancella();
            writerApp.Close();
            Sosituzione();
        }

        private void cancMomentanea_Click(object sender, EventArgs e)
        {
            writerApp = new StreamWriter(appoggio, false);
            CancellazioneMomentanea();
            writerApp.Close();
            Sosituzione();
        }

        private void modifica_Click(object sender, EventArgs e)
        {
            writerApp = new StreamWriter(appoggio, false);
            Modifica();
            writerApp.Close();
            Sosituzione();
        }

        public void Cancella()
        {
            reader = new StreamReader(file, false);
            line = reader.ReadLine();
            while (line != null)
            {
                String[] splitter = line.Split(';');
                if (splitter[0] != textBox1.Text)
                {
                    writerApp.WriteLine(line);
                }
                else
                    P.presente = false;

                line = reader.ReadLine();
            }
            reader.Close();
        }

        public void CancellazioneMomentanea()
        {
            reader = new StreamReader(file);
            line = reader.ReadLine();
            while (line != null)
            {
                String[] splitter = line.Split(';');
                if (splitter[0] != textBox1.Text)
                {
                    writerApp.WriteLine(line);
                }
                else
                {
                    writerApp.WriteLine(line);
                    P.presente = false;
                }

                line = reader.ReadLine();
            }
            reader.Close();
        }

        public void Modifica()
        {
            reader = new StreamReader(file);
            line = reader.ReadLine();
            while (line != null)
            {
                String[] splitter = line.Split(';');
                if (splitter[0] != textBox1.Text)
                {
                    writerApp.WriteLine(line);
                }
                else if (splitter[0] == textBox1.Text)
                {
                    writerApp.WriteLine("nome: " + textBox3.Text + ";" + "prezzo: " + textBox2.Text);
                }

                line = reader.ReadLine();

            }
            reader.Close();
        }

        public void Sosituzione()
        {
            File.Delete(file);
            File.Move(appoggio, file);
            listView1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}










