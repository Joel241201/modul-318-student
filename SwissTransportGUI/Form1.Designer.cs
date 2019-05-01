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
            this.comboBoxVon = new System.Windows.Forms.ComboBox();
            this.comboBoxNach = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnVerbindung = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxAbfahrtstafel = new System.Windows.Forms.ComboBox();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Von:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nach:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Zeit:";
            // 
            // comboBoxVon
            // 
            this.comboBoxVon.FormattingEnabled = true;
            this.comboBoxVon.Location = new System.Drawing.Point(85, 62);
            this.comboBoxVon.Name = "comboBoxVon";
            this.comboBoxVon.Size = new System.Drawing.Size(121, 24);
            this.comboBoxVon.TabIndex = 4;
            this.comboBoxVon.SelectedIndexChanged += new System.EventHandler(this.comboBoxVon_SelectedIndexChanged);
            this.comboBoxVon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxVon_KeyDown);
            // 
            // comboBoxNach
            // 
            this.comboBoxNach.FormattingEnabled = true;
            this.comboBoxNach.Location = new System.Drawing.Point(264, 62);
            this.comboBoxNach.Name = "comboBoxNach";
            this.comboBoxNach.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNach.TabIndex = 5;
            this.comboBoxNach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxNach_KeyDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // btnVerbindung
            // 
            this.btnVerbindung.Location = new System.Drawing.Point(391, 72);
            this.btnVerbindung.Name = "btnVerbindung";
            this.btnVerbindung.Size = new System.Drawing.Size(112, 53);
            this.btnVerbindung.TabIndex = 7;
            this.btnVerbindung.Text = "Verbindungen suchen";
            this.btnVerbindung.UseVisualStyleBackColor = true;
            this.btnVerbindung.Click += new System.EventHandler(this.btnVerbindung_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(36, 143);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(349, 260);
            this.listBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
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
            this.listBox2.Location = new System.Drawing.Point(567, 110);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(295, 308);
            this.listBox2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(769, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Abfahrtstafel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 430);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnAbfahrtstafel);
            this.Controls.Add(this.comboBoxAbfahrtstafel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnVerbindung);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxNach);
            this.Controls.Add(this.comboBoxVon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxVon;
        private System.Windows.Forms.ComboBox comboBoxNach;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnVerbindung;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxAbfahrtstafel;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label6;
    }
}

