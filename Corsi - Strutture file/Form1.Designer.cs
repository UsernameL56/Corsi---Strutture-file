namespace Corsi___Strutture_file
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Salva = new System.Windows.Forms.Button();
            this.salvataggio = new System.Windows.Forms.Button();
            this.Svuotamento = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cancellazione = new System.Windows.Forms.Button();
            this.modifica = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancMomentanea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 122);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(301, 122);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 1;
            // 
            // Salva
            // 
            this.Salva.Location = new System.Drawing.Point(63, 245);
            this.Salva.Margin = new System.Windows.Forms.Padding(4);
            this.Salva.Name = "Salva";
            this.Salva.Size = new System.Drawing.Size(100, 28);
            this.Salva.TabIndex = 2;
            this.Salva.Text = "Salva";
            this.Salva.UseVisualStyleBackColor = true;
            this.Salva.Click += new System.EventHandler(this.Salva_Click);
            // 
            // salvataggio
            // 
            this.salvataggio.Location = new System.Drawing.Point(199, 245);
            this.salvataggio.Margin = new System.Windows.Forms.Padding(4);
            this.salvataggio.Name = "salvataggio";
            this.salvataggio.Size = new System.Drawing.Size(100, 28);
            this.salvataggio.TabIndex = 3;
            this.salvataggio.Text = "Salvataggio";
            this.salvataggio.UseVisualStyleBackColor = true;
            this.salvataggio.Click += new System.EventHandler(this.salvataggio_Click);
            // 
            // Svuotamento
            // 
            this.Svuotamento.Location = new System.Drawing.Point(63, 470);
            this.Svuotamento.Margin = new System.Windows.Forms.Padding(4);
            this.Svuotamento.Name = "Svuotamento";
            this.Svuotamento.Size = new System.Drawing.Size(100, 28);
            this.Svuotamento.TabIndex = 4;
            this.Svuotamento.Text = "Svuota file";
            this.Svuotamento.UseVisualStyleBackColor = true;
            this.Svuotamento.Click += new System.EventHandler(this.Svuotamento_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(655, 63);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(297, 435);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // cancellazione
            // 
            this.cancellazione.Location = new System.Drawing.Point(306, 306);
            this.cancellazione.Margin = new System.Windows.Forms.Padding(4);
            this.cancellazione.Name = "cancellazione";
            this.cancellazione.Size = new System.Drawing.Size(171, 28);
            this.cancellazione.TabIndex = 6;
            this.cancellazione.Text = "Cancella Definitivamente";
            this.cancellazione.UseVisualStyleBackColor = true;
            this.cancellazione.Click += new System.EventHandler(this.cancellazione_Click);
            // 
            // modifica
            // 
            this.modifica.Location = new System.Drawing.Point(66, 351);
            this.modifica.Name = "modifica";
            this.modifica.Size = new System.Drawing.Size(113, 28);
            this.modifica.TabIndex = 7;
            this.modifica.Text = "modifica";
            this.modifica.UseVisualStyleBackColor = true;
            this.modifica.Click += new System.EventHandler(this.modifica_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(63, 189);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Input";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prezzo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Parola modificata";
            // 
            // cancMomentanea
            // 
            this.cancMomentanea.Location = new System.Drawing.Point(65, 306);
            this.cancMomentanea.Name = "cancMomentanea";
            this.cancMomentanea.Size = new System.Drawing.Size(234, 28);
            this.cancMomentanea.TabIndex = 12;
            this.cancMomentanea.Text = "Cancella Momentaneamente";
            this.cancMomentanea.UseVisualStyleBackColor = true;
            this.cancMomentanea.Click += new System.EventHandler(this.cancMomentanea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cancMomentanea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.modifica);
            this.Controls.Add(this.cancellazione);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Svuotamento);
            this.Controls.Add(this.salvataggio);
            this.Controls.Add(this.Salva);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Salva;
        private System.Windows.Forms.Button salvataggio;
        private System.Windows.Forms.Button Svuotamento;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button cancellazione;
        private System.Windows.Forms.Button modifica;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancMomentanea;
    }
}

