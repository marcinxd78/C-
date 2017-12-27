namespace AplikacajaBaz
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
            this.Serwer = new System.Windows.Forms.Label();
            this.Baza = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.Haslo = new System.Windows.Forms.Label();
            this.nazwaServeratb1 = new System.Windows.Forms.TextBox();
            this.nazwaBazytb = new System.Windows.Forms.TextBox();
            this.uzytkowniktb = new System.Windows.Forms.TextBox();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.logowanieBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ComboBox();
            this.haslotb = new System.Windows.Forms.MaskedTextBox();
            this.wstaw = new System.Windows.Forms.Button();
            this.kol = new System.Windows.Forms.TextBox();
            this.atrybut = new System.Windows.Forms.ComboBox();
            this.delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nr_ubez = new System.Windows.Forms.TextBox();
            this.Imie = new System.Windows.Forms.TextBox();
            this.Nazwisko = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.TextBox();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.Numer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.usunBtn = new System.Windows.Forms.Button();
            this.uakt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // Serwer
            // 
            this.Serwer.AutoSize = true;
            this.Serwer.Location = new System.Drawing.Point(7, 9);
            this.Serwer.Name = "Serwer";
            this.Serwer.Size = new System.Drawing.Size(40, 13);
            this.Serwer.TabIndex = 0;
            this.Serwer.Text = "Serwer";
            this.Serwer.Click += new System.EventHandler(this.label1_Click);
            // 
            // Baza
            // 
            this.Baza.AutoSize = true;
            this.Baza.Location = new System.Drawing.Point(7, 35);
            this.Baza.Name = "Baza";
            this.Baza.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Baza.Size = new System.Drawing.Size(31, 13);
            this.Baza.TabIndex = 1;
            this.Baza.Text = "Baza";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(7, 58);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(33, 13);
            this.Login.TabIndex = 2;
            this.Login.Text = "Login";
            // 
            // Haslo
            // 
            this.Haslo.AutoSize = true;
            this.Haslo.Location = new System.Drawing.Point(7, 84);
            this.Haslo.Name = "Haslo";
            this.Haslo.Size = new System.Drawing.Size(36, 13);
            this.Haslo.TabIndex = 4;
            this.Haslo.Text = "Hasło";
            // 
            // nazwaServeratb1
            // 
            this.nazwaServeratb1.Location = new System.Drawing.Point(53, 6);
            this.nazwaServeratb1.Name = "nazwaServeratb1";
            this.nazwaServeratb1.Size = new System.Drawing.Size(100, 20);
            this.nazwaServeratb1.TabIndex = 5;
            this.nazwaServeratb1.Text = "localhost";
            // 
            // nazwaBazytb
            // 
            this.nazwaBazytb.Location = new System.Drawing.Point(53, 32);
            this.nazwaBazytb.Name = "nazwaBazytb";
            this.nazwaBazytb.Size = new System.Drawing.Size(100, 20);
            this.nazwaBazytb.TabIndex = 6;
            this.nazwaBazytb.Text = "proj";
            // 
            // uzytkowniktb
            // 
            this.uzytkowniktb.Location = new System.Drawing.Point(53, 58);
            this.uzytkowniktb.Name = "uzytkowniktb";
            this.uzytkowniktb.Size = new System.Drawing.Size(100, 20);
            this.uzytkowniktb.TabIndex = 7;
            this.uzytkowniktb.Text = "root";
            // 
            // dataGrid1
            // 
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(68, 212);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(579, 192);
            this.dataGrid1.TabIndex = 9;
            // 
            // logowanieBtn
            // 
            this.logowanieBtn.Location = new System.Drawing.Point(10, 145);
            this.logowanieBtn.Name = "logowanieBtn";
            this.logowanieBtn.Size = new System.Drawing.Size(76, 24);
            this.logowanieBtn.TabIndex = 10;
            this.logowanieBtn.Text = "Logowanie";
            this.logowanieBtn.UseVisualStyleBackColor = true;
            this.logowanieBtn.Click += new System.EventHandler(this.logowanieBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Wyświetl tabele";
            // 
            // lista
            // 
            this.lista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lista.FormattingEnabled = true;
            this.lista.Items.AddRange(new object[] {
            "pacjent",
            "lekarz",
            "wizyta",
            "choroba",
            "leczy",
            "diagnoza",
            "lekarstwo",
            "przepisuje"});
            this.lista.Location = new System.Drawing.Point(94, 116);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(121, 21);
            this.lista.TabIndex = 13;
            // 
            // haslotb
            // 
            this.haslotb.Location = new System.Drawing.Point(53, 84);
            this.haslotb.Name = "haslotb";
            this.haslotb.Size = new System.Drawing.Size(100, 20);
            this.haslotb.TabIndex = 14;
            this.haslotb.Text = "root";
            this.haslotb.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.haslotb.UseSystemPasswordChar = true;
            // 
            // wstaw
            // 
            this.wstaw.Location = new System.Drawing.Point(181, 78);
            this.wstaw.Name = "wstaw";
            this.wstaw.Size = new System.Drawing.Size(131, 26);
            this.wstaw.TabIndex = 15;
            this.wstaw.Text = "Szukaj";
            this.wstaw.UseVisualStyleBackColor = true;
            this.wstaw.Click += new System.EventHandler(this.button1_Click);
            // 
            // kol
            // 
            this.kol.Location = new System.Drawing.Point(181, 52);
            this.kol.Name = "kol";
            this.kol.Size = new System.Drawing.Size(108, 20);
            this.kol.TabIndex = 16;
            this.kol.TextChanged += new System.EventHandler(this.kol_TextChanged);
            // 
            // atrybut
            // 
            this.atrybut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.atrybut.FormattingEnabled = true;
            this.atrybut.Items.AddRange(new object[] {
            "nr_ubez",
            "idlekarz",
            "idchoroby",
            "idlekarstwo",
            "nr_wizyty"});
            this.atrybut.Location = new System.Drawing.Point(181, 25);
            this.atrybut.Name = "atrybut";
            this.atrybut.Size = new System.Drawing.Size(121, 21);
            this.atrybut.TabIndex = 17;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(94, 146);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 18;
            this.delete.Text = "Wyczyść";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Wyszukaj lub usuń:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nr_ubez
            // 
            this.nr_ubez.Location = new System.Drawing.Point(430, 25);
            this.nr_ubez.Name = "nr_ubez";
            this.nr_ubez.Size = new System.Drawing.Size(100, 20);
            this.nr_ubez.TabIndex = 20;
            this.nr_ubez.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Imie
            // 
            this.Imie.Location = new System.Drawing.Point(430, 51);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(100, 20);
            this.Imie.TabIndex = 21;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Location = new System.Drawing.Point(430, 78);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(100, 20);
            this.Nazwisko.TabIndex = 22;
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(430, 104);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(100, 20);
            this.Adres.TabIndex = 23;
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(430, 156);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajBtn.TabIndex = 24;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Numer
            // 
            this.Numer.Location = new System.Drawing.Point(430, 130);
            this.Numer.Name = "Numer";
            this.Numer.Size = new System.Drawing.Size(100, 20);
            this.Numer.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Numer ubezpieczenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Imię";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nazwisko";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Adres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Numer telefonu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Dodaj pacjenta:";
            // 
            // usunBtn
            // 
            this.usunBtn.Location = new System.Drawing.Point(227, 114);
            this.usunBtn.Name = "usunBtn";
            this.usunBtn.Size = new System.Drawing.Size(75, 23);
            this.usunBtn.TabIndex = 32;
            this.usunBtn.Text = "Usuń";
            this.usunBtn.UseVisualStyleBackColor = true;
            this.usunBtn.Click += new System.EventHandler(this.usunBtn_Click);
            // 
            // uakt
            // 
            this.uakt.Location = new System.Drawing.Point(511, 156);
            this.uakt.Name = "uakt";
            this.uakt.Size = new System.Drawing.Size(75, 23);
            this.uakt.TabIndex = 33;
            this.uakt.Text = "Aktualizuj";
            this.uakt.UseVisualStyleBackColor = true;
            this.uakt.Click += new System.EventHandler(this.uakt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 457);
            this.Controls.Add(this.uakt);
            this.Controls.Add(this.usunBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Numer);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Nazwisko);
            this.Controls.Add(this.Imie);
            this.Controls.Add(this.nr_ubez);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.atrybut);
            this.Controls.Add(this.kol);
            this.Controls.Add(this.wstaw);
            this.Controls.Add(this.haslotb);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logowanieBtn);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.uzytkowniktb);
            this.Controls.Add(this.nazwaBazytb);
            this.Controls.Add(this.nazwaServeratb1);
            this.Controls.Add(this.Haslo);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Baza);
            this.Controls.Add(this.Serwer);
            this.Name = "Form1";
            this.Text = "Aplikacja Marcin Nieznalski";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Serwer;
        private System.Windows.Forms.Label Baza;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Haslo;
        private System.Windows.Forms.TextBox nazwaServeratb1;
        private System.Windows.Forms.TextBox nazwaBazytb;
        private System.Windows.Forms.TextBox uzytkowniktb;
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.Button logowanieBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lista;
        private System.Windows.Forms.MaskedTextBox haslotb;
        private System.Windows.Forms.Button wstaw;
        private System.Windows.Forms.TextBox kol;
        private System.Windows.Forms.ComboBox atrybut;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nr_ubez;
        private System.Windows.Forms.TextBox Imie;
        private System.Windows.Forms.TextBox Nazwisko;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.TextBox Numer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button usun;
        private System.Windows.Forms.Button usunBtn;
        private System.Windows.Forms.Button uakt;
    }
}

