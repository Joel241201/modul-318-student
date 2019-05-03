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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.listViewSign = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxSign = new System.Windows.Forms.TextBox();
            this.listBoxSign = new System.Windows.Forms.ListBox();
            this.listViewOutput = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBoxTo = new System.Windows.Forms.ListBox();
            this.listBoxFrom = new System.Windows.Forms.ListBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSignOutput = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.googleMaps = new System.Windows.Forms.TabPage();
            this.btnStandort = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxMaps = new System.Windows.Forms.ListBox();
            this.textBoxMaps = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnMaps = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            this.googleMaps.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.googleMaps);
            this.tabControl1.Location = new System.Drawing.Point(13, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1001, 566);
            this.tabControl1.TabIndex = 29;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.listViewSign);
            this.Home.Controls.Add(this.textBoxSign);
            this.Home.Controls.Add(this.listBoxSign);
            this.Home.Controls.Add(this.listViewOutput);
            this.Home.Controls.Add(this.listBoxTo);
            this.Home.Controls.Add(this.listBoxFrom);
            this.Home.Controls.Add(this.textBoxTo);
            this.Home.Controls.Add(this.textBoxFrom);
            this.Home.Controls.Add(this.label6);
            this.Home.Controls.Add(this.btnSignOutput);
            this.Home.Controls.Add(this.label5);
            this.Home.Controls.Add(this.label4);
            this.Home.Controls.Add(this.btnConnection);
            this.Home.Controls.Add(this.dateTimePicker1);
            this.Home.Controls.Add(this.label3);
            this.Home.Controls.Add(this.label2);
            this.Home.Controls.Add(this.label1);
            this.Home.Location = new System.Drawing.Point(4, 25);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(993, 537);
            this.Home.TabIndex = 0;
            this.Home.Text = "home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // listViewSign
            // 
            this.listViewSign.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewSign.GridLines = true;
            this.listViewSign.Location = new System.Drawing.Point(520, 210);
            this.listViewSign.Name = "listViewSign";
            this.listViewSign.Size = new System.Drawing.Size(434, 319);
            this.listViewSign.TabIndex = 39;
            this.listViewSign.TabStop = false;
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
            // textBoxSign
            // 
            this.textBoxSign.BackColor = System.Drawing.Color.White;
            this.textBoxSign.Location = new System.Drawing.Point(643, 66);
            this.textBoxSign.Name = "textBoxSign";
            this.textBoxSign.Size = new System.Drawing.Size(173, 22);
            this.textBoxSign.TabIndex = 3;
            this.textBoxSign.TextChanged += new System.EventHandler(this.textBoxSign_TextChanged);
            this.textBoxSign.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSign_KeyDown);
            // 
            // listBoxSign
            // 
            this.listBoxSign.FormattingEnabled = true;
            this.listBoxSign.ItemHeight = 16;
            this.listBoxSign.Location = new System.Drawing.Point(643, 92);
            this.listBoxSign.Name = "listBoxSign";
            this.listBoxSign.Size = new System.Drawing.Size(173, 84);
            this.listBoxSign.TabIndex = 38;
            this.listBoxSign.Click += new System.EventHandler(this.listBoxSign_Click);
            // 
            // listViewOutput
            // 
            this.listViewOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewOutput.GridLines = true;
            this.listViewOutput.Location = new System.Drawing.Point(44, 285);
            this.listViewOutput.Name = "listViewOutput";
            this.listViewOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listViewOutput.Size = new System.Drawing.Size(455, 244);
            this.listViewOutput.TabIndex = 37;
            this.listViewOutput.TabStop = false;
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
            this.columnHeader3.Width = 78;
            // 
            // listBoxTo
            // 
            this.listBoxTo.FormattingEnabled = true;
            this.listBoxTo.ItemHeight = 16;
            this.listBoxTo.Location = new System.Drawing.Point(234, 97);
            this.listBoxTo.Name = "listBoxTo";
            this.listBoxTo.Size = new System.Drawing.Size(162, 132);
            this.listBoxTo.TabIndex = 36;
            this.listBoxTo.TabStop = false;
            this.listBoxTo.Click += new System.EventHandler(this.listBoxTo_Click);
            // 
            // listBoxFrom
            // 
            this.listBoxFrom.FormattingEnabled = true;
            this.listBoxFrom.ItemHeight = 16;
            this.listBoxFrom.Location = new System.Drawing.Point(44, 97);
            this.listBoxFrom.Name = "listBoxFrom";
            this.listBoxFrom.Size = new System.Drawing.Size(162, 132);
            this.listBoxFrom.TabIndex = 35;
            this.listBoxFrom.TabStop = false;
            this.listBoxFrom.Click += new System.EventHandler(this.listBoxFrom_Click);
            // 
            // textBoxTo
            // 
            this.textBoxTo.BackColor = System.Drawing.Color.White;
            this.textBoxTo.Location = new System.Drawing.Point(282, 69);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(114, 22);
            this.textBoxTo.TabIndex = 1;
            this.textBoxTo.TextChanged += new System.EventHandler(this.textBoxTo_TextChanged);
            this.textBoxTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTo_KeyDown);
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.BackColor = System.Drawing.Color.White;
            this.textBoxFrom.Location = new System.Drawing.Point(84, 69);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(122, 22);
            this.textBoxFrom.TabIndex = 0;
            this.textBoxFrom.TextChanged += new System.EventHandler(this.textBoxFrom_TextChanged);
            this.textBoxFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFrom_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(514, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 32);
            this.label6.TabIndex = 34;
            this.label6.Text = "Abfahrtstafel";
            // 
            // btnSignOutput
            // 
            this.btnSignOutput.Location = new System.Drawing.Point(836, 123);
            this.btnSignOutput.Name = "btnSignOutput";
            this.btnSignOutput.Size = new System.Drawing.Size(118, 53);
            this.btnSignOutput.TabIndex = 4;
            this.btnSignOutput.Text = "Abfahrtstafel ausgeben";
            this.btnSignOutput.UseVisualStyleBackColor = true;
            this.btnSignOutput.Click += new System.EventHandler(this.btnSignOutput_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ab welcher Station:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 32);
            this.label4.TabIndex = 32;
            this.label4.Text = "Fahrplan";
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(389, 237);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(110, 42);
            this.btnConnection.TabIndex = 2;
            this.btnConnection.Text = "Verbindungen suchen";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnconnection_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 250);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker1.TabIndex = 31;
            this.dateTimePicker1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Zeit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nach:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Von:";
            // 
            // googleMaps
            // 
            this.googleMaps.Controls.Add(this.btnStandort);
            this.googleMaps.Controls.Add(this.label8);
            this.googleMaps.Controls.Add(this.label7);
            this.googleMaps.Controls.Add(this.listBoxMaps);
            this.googleMaps.Controls.Add(this.textBoxMaps);
            this.googleMaps.Controls.Add(this.webBrowser1);
            this.googleMaps.Controls.Add(this.btnMaps);
            this.googleMaps.Location = new System.Drawing.Point(4, 25);
            this.googleMaps.Name = "googleMaps";
            this.googleMaps.Padding = new System.Windows.Forms.Padding(3);
            this.googleMaps.Size = new System.Drawing.Size(993, 537);
            this.googleMaps.TabIndex = 1;
            this.googleMaps.Text = "googleMaps";
            this.googleMaps.UseVisualStyleBackColor = true;
            // 
            // btnStandort
            // 
            this.btnStandort.Location = new System.Drawing.Point(644, 69);
            this.btnStandort.Name = "btnStandort";
            this.btnStandort.Size = new System.Drawing.Size(128, 37);
            this.btnStandort.TabIndex = 35;
            this.btnStandort.Text = "Mein Standort";
            this.btnStandort.UseVisualStyleBackColor = true;
            this.btnStandort.Click += new System.EventHandler(this.btnStandort_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 32);
            this.label8.TabIndex = 34;
            this.label8.Text = "Google Maps";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Stationsbild anzeigen:";
            // 
            // listBoxMaps
            // 
            this.listBoxMaps.FormattingEnabled = true;
            this.listBoxMaps.ItemHeight = 16;
            this.listBoxMaps.Location = new System.Drawing.Point(179, 92);
            this.listBoxMaps.Name = "listBoxMaps";
            this.listBoxMaps.Size = new System.Drawing.Size(173, 84);
            this.listBoxMaps.TabIndex = 32;
            this.listBoxMaps.TabStop = false;
            this.listBoxMaps.Click += new System.EventHandler(this.listBoxMaps_Click);
            // 
            // textBoxMaps
            // 
            this.textBoxMaps.BackColor = System.Drawing.Color.White;
            this.textBoxMaps.Location = new System.Drawing.Point(179, 69);
            this.textBoxMaps.Name = "textBoxMaps";
            this.textBoxMaps.Size = new System.Drawing.Size(173, 22);
            this.textBoxMaps.TabIndex = 5;
            this.textBoxMaps.TextChanged += new System.EventHandler(this.textBoxMaps_TextChanged);
            this.textBoxMaps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMaps_KeyDown);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(29, 182);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(743, 324);
            this.webBrowser1.TabIndex = 31;
            // 
            // btnMaps
            // 
            this.btnMaps.Location = new System.Drawing.Point(358, 127);
            this.btnMaps.Name = "btnMaps";
            this.btnMaps.Size = new System.Drawing.Size(100, 49);
            this.btnMaps.TabIndex = 6;
            this.btnMaps.Text = "Google Maps";
            this.btnMaps.UseVisualStyleBackColor = true;
            this.btnMaps.Click += new System.EventHandler(this.btnMaps_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1026, 577);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1044, 624);
            this.MinimumSize = new System.Drawing.Size(1044, 624);
            this.Name = "Form1";
            this.Text = "Fahrplan App";
            this.tabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.googleMaps.ResumeLayout(false);
            this.googleMaps.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.ListView listViewSign;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox textBoxSign;
        private System.Windows.Forms.ListBox listBoxSign;
        private System.Windows.Forms.ListView listViewOutput;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListBox listBoxTo;
        private System.Windows.Forms.ListBox listBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSignOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage googleMaps;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxMaps;
        private System.Windows.Forms.TextBox textBoxMaps;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnMaps;
        private System.Windows.Forms.Button btnStandort;
    }
}

