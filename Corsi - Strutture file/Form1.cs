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

namespace Corsi___Strutture_file
{
    public partial class Form1 : Form
    {
        string file, appoggio;
        int indice;
        string line;
        public Form1()
        {
            InitializeComponent();
            file = @"File.csv";
            appoggio = @"FileAppoggio.csv";
            indice = 0;
        }

        private void Salva_Click(object sender, EventArgs e)
        {

            StreamWriter writer = new StreamWriter(file, true);
            writer.WriteLine("nome: " + textBox1.Text + " ; " + "prezzo: " + textBox2.Text);
            writer.Close();

        }

        private void Svuotamento_Click(object sender, EventArgs e)
        {
            StreamWriter f = new StreamWriter(file, false);
            f.Close();
        }

        private void salvataggio_Click(object sender, EventArgs e)
        {

            StreamReader reader = new StreamReader(file);
            line = reader.ReadLine();
            while (line != null)
            {
                listView1.Items.Add(line);
                line = reader.ReadLine();
            }
            reader.Close();

        }

        private void cancellazione_Click(object sender, EventArgs e)
        {
        }

    }
}