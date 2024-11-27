namespace Xml_vozila
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.textBoxKilometraza = new System.Windows.Forms.TextBox();
            this.Marka = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.BtnSpremiXml = new System.Windows.Forms.Button();
            this.BtnLoadXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(113, 40);
            this.textBoxMarka.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(68, 20);
            this.textBoxMarka.TabIndex = 0;
            this.textBoxMarka.TextChanged += new System.EventHandler(this.textBoxMarka_TextChanged);
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(113, 88);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(68, 20);
            this.textBoxModel.TabIndex = 1;
            // 
            // textBoxGodinaProizvodnje
            // 
            this.textBoxGodinaProizvodnje.Location = new System.Drawing.Point(113, 132);
            this.textBoxGodinaProizvodnje.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGodinaProizvodnje.Name = "textBoxGodinaProizvodnje";
            this.textBoxGodinaProizvodnje.Size = new System.Drawing.Size(68, 20);
            this.textBoxGodinaProizvodnje.TabIndex = 2;
            // 
            // textBoxKilometraza
            // 
            this.textBoxKilometraza.Location = new System.Drawing.Point(113, 168);
            this.textBoxKilometraza.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKilometraza.Name = "textBoxKilometraza";
            this.textBoxKilometraza.Size = new System.Drawing.Size(68, 20);
            this.textBoxKilometraza.TabIndex = 3;
            // 
            // Marka
            // 
            this.Marka.AutoSize = true;
            this.Marka.Location = new System.Drawing.Point(16, 40);
            this.Marka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(36, 13);
            this.Marka.TabIndex = 4;
            this.Marka.Text = "marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "G.Proizvodnje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kilometraza";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(11, 227);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(51, 21);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(260, 186);
            this.btnSortiraj.Margin = new System.Windows.Forms.Padding(2);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(51, 21);
            this.btnSortiraj.TabIndex = 9;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(113, 228);
            this.ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(82, 21);
            this.ComboBox.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(308, 28);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 121);
            this.listBox1.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(350, 168);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(205, 81);
            this.textBox5.TabIndex = 12;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(215, 8);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(50, 28);
            this.btnObrisi.TabIndex = 13;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // BtnSpremiXml
            // 
            this.BtnSpremiXml.Location = new System.Drawing.Point(183, 299);
            this.BtnSpremiXml.Name = "BtnSpremiXml";
            this.BtnSpremiXml.Size = new System.Drawing.Size(101, 23);
            this.BtnSpremiXml.TabIndex = 14;
            this.BtnSpremiXml.Text = "Spremi Xmla";
            this.BtnSpremiXml.UseVisualStyleBackColor = true;
            this.BtnSpremiXml.Click += new System.EventHandler(this.BtnSpremiXml_Click);
            // 
            // BtnLoadXml
            // 
            this.BtnLoadXml.Location = new System.Drawing.Point(335, 299);
            this.BtnLoadXml.Name = "BtnLoadXml";
            this.BtnLoadXml.Size = new System.Drawing.Size(87, 23);
            this.BtnLoadXml.TabIndex = 15;
            this.BtnLoadXml.Text = "Load Xml";
            this.BtnLoadXml.UseVisualStyleBackColor = true;
            this.BtnLoadXml.Click += new System.EventHandler(this.BtnLoadXml_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 350);
            this.Controls.Add(this.BtnLoadXml);
            this.Controls.Add(this.BtnSpremiXml);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Marka);
            this.Controls.Add(this.textBoxKilometraza);
            this.Controls.Add(this.textBoxGodinaProizvodnje);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxMarka);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxGodinaProizvodnje;
        private System.Windows.Forms.TextBox textBoxKilometraza;
        private System.Windows.Forms.Label Marka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button BtnSpremiXml;
        private System.Windows.Forms.Button BtnLoadXml;
    }
}

