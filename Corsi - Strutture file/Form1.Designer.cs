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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(226, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // Salva
            // 
            this.Salva.Location = new System.Drawing.Point(47, 199);
            this.Salva.Name = "Salva";
            this.Salva.Size = new System.Drawing.Size(75, 23);
            this.Salva.TabIndex = 2;
            this.Salva.Text = "Salva";
            this.Salva.UseVisualStyleBackColor = true;
            this.Salva.Click += new System.EventHandler(this.Salva_Click);
            // 
            // salvataggio
            // 
            this.salvataggio.Location = new System.Drawing.Point(149, 199);
            this.salvataggio.Name = "salvataggio";
            this.salvataggio.Size = new System.Drawing.Size(75, 23);
            this.salvataggio.TabIndex = 3;
            this.salvataggio.Text = "Salvataggio";
            this.salvataggio.UseVisualStyleBackColor = true;
            this.salvataggio.Click += new System.EventHandler(this.salvataggio_Click);
            // 
            // Svuotamento
            // 
            this.Svuotamento.Location = new System.Drawing.Point(47, 382);
            this.Svuotamento.Name = "Svuotamento";
            this.Svuotamento.Size = new System.Drawing.Size(75, 23);
            this.Svuotamento.TabIndex = 4;
            this.Svuotamento.Text = "Svuota file";
            this.Svuotamento.UseVisualStyleBackColor = true;
            this.Svuotamento.Click += new System.EventHandler(this.Svuotamento_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(491, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(224, 354);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // cancellazione
            // 
            this.cancellazione.Location = new System.Drawing.Point(47, 249);
            this.cancellazione.Name = "cancellazione";
            this.cancellazione.Size = new System.Drawing.Size(85, 23);
            this.cancellazione.TabIndex = 6;
            this.cancellazione.Text = "Cancellazione";
            this.cancellazione.UseVisualStyleBackColor = true;
            this.cancellazione.Click += new System.EventHandler(this.cancellazione_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancellazione);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Svuotamento);
            this.Controls.Add(this.salvataggio);
            this.Controls.Add(this.Salva);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
    }
}

