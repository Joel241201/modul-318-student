namespace SwissTransportGUI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnVerbindung = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxAbfahrtstafel = new System.Windows.Forms.ComboBox();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxVon = new System.Windows.Forms.TextBox();
            this.textBoxNach = new System.Windows.Forms.TextBox();
            this.listBoxVon = new System.Windows.Forms.ListBox();
            this.listBoxNach = new System.Windows.Forms.ListBox();
            this.listViewAusgabe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Von:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nach:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Zeit:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(66, 271);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // btnVerbindung
            // 
            this.btnVerbindung.Location = new System.Drawing.Point(371, 258);
            this.btnVerbindung.Name = "btnVerbindung";
            this.btnVerbindung.Size = new System.Drawing.Size(110, 42);
            this.btnVerbindung.TabIndex = 7;
            this.btnVerbindung.Text = "Verbindungen suchen";
            this.btnVerbindung.UseVisualStyleBackColor = true;
            this.btnVerbindung.Click += new System.EventHandler(this.btnVerbindung_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fahrplan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ab welcher Station:";
            // 
            // comboBoxAbfahrtstafel
            // 
            this.comboBoxAbfahrtstafel.FormattingEnabled = true;
            this.comboBoxAbfahrtstafel.Location = new System.Drawing.Point(699, 62);
            this.comboBoxAbfahrtstafel.Name = "comboBoxAbfahrtstafel";
            this.comboBoxAbfahrtstafel.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAbfahrtstafel.TabIndex = 11;
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(827, 51);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(118, 53);
            this.btnAbfahrtstafel.TabIndex = 12;
            this.btnAbfahrtstafel.Text = "Abfahrtstafel ausgeben";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(685, 118);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(295, 308);
            this.listBox2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(769, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Abfahrtstafel";
            // 
            // textBoxVon
            // 
            this.textBoxVon.BackColor = System.Drawing.Color.White;
            this.textBoxVon.Location = new System.Drawing.Point(66, 90);
            this.textBoxVon.Name = "textBoxVon";
            this.textBoxVon.Size = new System.Drawing.Size(122, 22);
            this.textBoxVon.TabIndex = 15;
            this.textBoxVon.TextChanged += new System.EventHandler(this.textBoxVon_TextChanged);
            // 
            // textBoxNach
            // 
            this.textBoxNach.BackColor = System.Drawing.Color.White;
            this.textBoxNach.Location = new System.Drawing.Point(264, 90);
            this.textBoxNach.Name = "textBoxNach";
            this.textBoxNach.Size = new System.Drawing.Size(114, 22);
            this.textBoxNach.TabIndex = 16;
            this.textBoxNach.TextChanged += new System.EventHandler(this.textBoxNach_TextChanged);
            // 
            // listBoxVon
            // 
            this.listBoxVon.FormattingEnabled = true;
            this.listBoxVon.ItemHeight = 16;
            this.listBoxVon.Location = new System.Drawing.Point(26, 118);
            this.listBoxVon.Name = "listBoxVon";
            this.listBoxVon.Size = new System.Drawing.Size(162, 132);
            this.listBoxVon.TabIndex = 17;
            this.listBoxVon.Click += new System.EventHandler(this.listBoxVon_Click);
            // 
            // listBoxNach
            // 
            this.listBoxNach.FormattingEnabled = true;
            this.listBoxNach.ItemHeight = 16;
            this.listBoxNach.Location = new System.Drawing.Point(216, 118);
            this.listBoxNach.Name = "listBoxNach";
            this.listBoxNach.Size = new System.Drawing.Size(162, 132);
            this.listBoxNach.TabIndex = 18;
            this.listBoxNach.Click += new System.EventHandler(this.listBoxNach_Click);
            // 
            // listViewAusgabe
            // 
            this.listViewAusgabe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewAusgabe.GridLines = true;
            this.listViewAusgabe.Location = new System.Drawing.Point(26, 306);
            this.listViewAusgabe.Name = "listViewAusgabe";
            this.listViewAusgabe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listViewAusgabe.Size = new System.Drawing.Size(455, 244);
            this.listViewAusgabe.TabIndex = 19;
            this.listViewAusgabe.UseCompatibleStateImageBehavior = false;
            this.listViewAusgabe.View = System.Windows.Forms.View.Details;
            this.listViewAusgabe.SelectedIndexChanged += new System.EventHandler(this.listViewAusgabe_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Von";
            this.columnHeader1.Width = 145;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nach";
            this.columnHeader2.Width = 157;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Departure";
            this.columnHeader3.Width = 149;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1010, 577);
            this.Controls.Add(this.listViewAusgabe);
            this.Controls.Add(this.listBoxNach);
            this.Controls.Add(this.listBoxVon);
            this.Controls.Add(this.textBoxNach);
            this.Controls.Add(this.textBoxVon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnAbfahrtstafel);
            this.Controls.Add(this.comboBoxAbfahrtstafel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVerbindung);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Fahrplan App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnVerbindung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxAbfahrtstafel;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxVon;
        private System.Windows.Forms.TextBox textBoxNach;
        private System.Windows.Forms.ListBox listBoxVon;
        private System.Windows.Forms.ListBox listBoxNach;
        private System.Windows.Forms.ListView listViewAusgabe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

