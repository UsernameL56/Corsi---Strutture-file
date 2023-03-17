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
        public Form1()
        {
            InitializeComponent();
            file = @"File.csv";
            appoggio = @"FileAppoggio.csv";
            indice = 0;
        }

        private void Salva_Click(object sender, EventArgs e)
        {
            
            StreamWriter f = new StreamWriter(file, true);
            f.WriteLine("nome: " + textBox1.Text + " ; " + "prezzo: " + textBox2.Text);
            f.Close();
            
        }

        private void Svuotamento_Click(object sender, EventArgs e)
        {
            StreamWriter f = new StreamWriter(file, false);
            f.Close();
        }

        private void salvataggio_Click(object sender, EventArgs e)
        {
        }

        private void cancellazione_Click(object sender, EventArgs e)
        {
        }

    }
}
