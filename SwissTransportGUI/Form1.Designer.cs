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
            this.btnConnection = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSignOutput = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.listBoxFrom = new System.Windows.Forms.ListBox();
            this.listBoxTo = new System.Windows.Forms.ListBox();
            this.listViewOutput = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBoxSign = new System.Windows.Forms.ListBox();
            this.textBoxSign = new System.Windows.Forms.TextBox();
            this.listViewSign = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMaps = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBoxMaps = new System.Windows.Forms.TextBox();
            this.listBoxMaps = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(371, 258);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(110, 42);
            this.btnConnection.TabIndex = 2;
            this.btnConnection.Text = "Verbindungen suchen";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnconnection_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fahrplan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ab welcher Station:";
            // 
            // btnSignOutput
            // 
            this.btnSignOutput.Location = new System.Drawing.Point(818, 144);
            this.btnSignOutput.Name = "btnSignOutput";
            this.btnSignOutput.Size = new System.Drawing.Size(118, 53);
            this.btnSignOutput.TabIndex = 4;
            this.btnSignOutput.Text = "Abfahrtstafel ausgeben";
            this.btnSignOutput.UseVisualStyleBackColor = true;
            this.btnSignOutput.Click += new System.EventHandler(this.btnSignOutput_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(496, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Abfahrtstafel";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.BackColor = System.Drawing.Color.White;
            this.textBoxFrom.Location = new System.Drawing.Point(66, 90);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(122, 22);
            this.textBoxFrom.TabIndex = 0;
            this.textBoxFrom.TextChanged += new System.EventHandler(this.textBoxFrom_TextChanged);
            this.textBoxFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFrom_KeyDown);
            // 
            // textBoxTo
            // 
            this.textBoxTo.BackColor = System.Drawing.Color.White;
            this.textBoxTo.Location = new System.Drawing.Point(264, 90);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(114, 22);
            this.textBoxTo.TabIndex = 1;
            this.textBoxTo.TextChanged += new System.EventHandler(this.textBoxTo_TextChanged);
            this.textBoxTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTo_KeyDown);
            // 
            // listBoxFrom
            // 
            this.listBoxFrom.FormattingEnabled = true;
            this.listBoxFrom.ItemHeight = 16;
            this.listBoxFrom.Location = new System.Drawing.Point(26, 118);
            this.listBoxFrom.Name = "listBoxFrom";
            this.listBoxFrom.Size = new System.Drawing.Size(162, 132);
            this.listBoxFrom.TabIndex = 17;
            this.listBoxFrom.TabStop = false;
            this.listBoxFrom.Click += new System.EventHandler(this.listBoxFrom_Click);
            // 
            // listBoxTo
            // 
            this.listBoxTo.FormattingEnabled = true;
            this.listBoxTo.ItemHeight = 16;
            this.listBoxTo.Location = new System.Drawing.Point(216, 118);
            this.listBoxTo.Name = "listBoxTo";
            this.listBoxTo.Size = new System.Drawing.Size(162, 132);
            this.listBoxTo.TabIndex = 18;
            this.listBoxTo.TabStop = false;
            this.listBoxTo.Click += new System.EventHandler(this.listBoxTo_Click);
            // 
            // listViewOutput
            // 
            this.listViewOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewOutput.GridLines = true;
            this.listViewOutput.Location = new System.Drawing.Point(26, 306);
            this.listViewOutput.Name = "listViewOutput";
            this.listViewOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listViewOutput.Size = new System.Drawing.Size(455, 244);
            this.listViewOutput.TabIndex = 19;
            this.listViewOutput.UseCompatibleStateImageBehavior = false;
            this.listViewOutput.View = System.Windows.Forms.View.Details;
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
            this.columnHeader3.Text = "Zeit";
            this.columnHeader3.Width = 150;
            // 
            // listBoxSign
            // 
            this.listBoxSign.FormattingEnabled = true;
            this.listBoxSign.ItemHeight = 16;
            this.listBoxSign.Location = new System.Drawing.Point(625, 113);
            this.listBoxSign.Name = "listBoxSign";
            this.listBoxSign.Size = new System.Drawing.Size(173, 84);
            this.listBoxSign.TabIndex = 20;
            this.listBoxSign.Click += new System.EventHandler(this.listBoxSign_Click);
            // 
            // textBoxSign
            // 
            this.textBoxSign.BackColor = System.Drawing.Color.White;
            this.textBoxSign.Location = new System.Drawing.Point(625, 87);
            this.textBoxSign.Name = "textBoxSign";
            this.textBoxSign.Size = new System.Drawing.Size(173, 22);
            this.textBoxSign.TabIndex = 3;
            this.textBoxSign.TextChanged += new System.EventHandler(this.textBoxSign_TextChanged);
            this.textBoxSign.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSign_KeyDown);
            // 
            // listViewSign
            // 
            this.listViewSign.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewSign.GridLines = true;
            this.listViewSign.Location = new System.Drawing.Point(502, 231);
            this.listViewSign.Name = "listViewSign";
            this.listViewSign.Size = new System.Drawing.Size(434, 319);
            this.listViewSign.TabIndex = 22;
            this.listViewSign.UseCompatibleStateImageBehavior = false;
            this.listViewSign.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 132;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nach";
            this.columnHeader5.Width = 223;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "zeit";
            this.columnHeader6.Width = 73;
            // 
            // btnMaps
            // 
            this.btnMaps.Location = new System.Drawing.Point(1519, 148);
            this.btnMaps.Name = "btnMaps";
            this.btnMaps.Size = new System.Drawing.Size(100, 49);
            this.btnMaps.TabIndex = 6;
            this.btnMaps.Text = "Google Maps";
            this.btnMaps.UseVisualStyleBackColor = true;
            this.btnMaps.Click += new System.EventHandler(this.btnMaps_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(1020, 231);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(599, 319);
            this.webBrowser1.TabIndex = 24;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted_1);
            // 
            // textBoxMaps
            // 
            this.textBoxMaps.BackColor = System.Drawing.Color.White;
            this.textBoxMaps.Location = new System.Drawing.Point(1340, 90);
            this.textBoxMaps.Name = "textBoxMaps";
            this.textBoxMaps.Size = new System.Drawing.Size(173, 22);
            this.textBoxMaps.TabIndex = 5;
            this.textBoxMaps.TextChanged += new System.EventHandler(this.textBoxMaps_TextChanged);
            this.textBoxMaps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMaps_KeyDown);
            // 
            // listBoxMaps
            // 
            this.listBoxMaps.FormattingEnabled = true;
            this.listBoxMaps.ItemHeight = 16;
            this.listBoxMaps.Location = new System.Drawing.Point(1340, 113);
            this.listBoxMaps.Name = "listBoxMaps";
            this.listBoxMaps.Size = new System.Drawing.Size(173, 84);
            this.listBoxMaps.TabIndex = 26;
            this.listBoxMaps.Click += new System.EventHandler(this.listBoxMaps_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1187, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Stationsbild anzeigen:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1014, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 32);
            this.label8.TabIndex = 28;
            this.label8.Text = "Google Maps";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1631, 577);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxMaps);
            this.Controls.Add(this.textBoxMaps);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnMaps);
            this.Controls.Add(this.listViewSign);
            this.Controls.Add(this.textBoxSign);
            this.Controls.Add(this.listBoxSign);
            this.Controls.Add(this.listViewOutput);
            this.Controls.Add(this.listBoxTo);
            this.Controls.Add(this.listBoxFrom);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSignOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1649, 624);
            this.MinimumSize = new System.Drawing.Size(1649, 624);
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
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSignOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.ListBox listBoxFrom;
        private System.Windows.Forms.ListBox listBoxTo;
        private System.Windows.Forms.ListView listViewOutput;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListBox listBoxSign;
        private System.Windows.Forms.TextBox textBoxSign;
        private System.Windows.Forms.ListView listViewSign;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnMaps;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBoxMaps;
        private System.Windows.Forms.ListBox listBoxMaps;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

