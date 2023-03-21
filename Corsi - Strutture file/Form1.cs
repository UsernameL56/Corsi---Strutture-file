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
        string file, appoggio;
        string line;
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
            writer = new StreamWriter(file, true);
            writer.WriteLine("nome: " + textBox1.Text + " ; " + "prezzo: " + textBox2.Text);
            writer.Close();
        }

        private void Svuotamento_Click(object sender, EventArgs e)
        {
            writer = new StreamWriter(file, false);
            writer.Close();
        }

        private void salvataggio_Click(object sender, EventArgs e)
        {
            reader = new StreamReader(file);
            line = reader.ReadLine();
            while (line != null)
            {
                listView1.Clear();
                listView1.Items.Add(line);
                line = reader.ReadLine();
            }
            reader.Close();
        }

        private void cancellazione_Click(object sender, EventArgs e)
        {
            writerApp = new StreamWriter(appoggio, false);
            Cancella();
            writerApp.Close();
            Sosituzione()
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
            reader = new StreamReader(file);
            line = reader.ReadLine();
            
            while (line != null)
            {
                String[] splitter = line.Split(';');
                String[] splitter2 = splitter[0].Split(' ');
                if (splitter2[1] != textBox1.Text)
                {
                    writerApp.WriteLine(line);
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
                String[] splitter2 = splitter[0].Split(' ');
                if (splitter2[1] != textBox1.Text)
                {
                    writerApp.WriteLine(line);
                }
                else if(splitter2[1] == textBox1.Text)
                {
                    writerApp.WriteLine("nome: " + textBox3.Text + " ; " + "prezzo: " + textBox2.Text);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}