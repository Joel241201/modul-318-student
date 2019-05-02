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
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.btnConnection.TabIndex = 7;
            this.btnConnection.Text = "Verbindungen suchen";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnconnection_Click);
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
            this.label5.Location = new System.Drawing.Point(499, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ab welcher Station:";
            // 
            // btnSignOutput
            // 
            this.btnSignOutput.Location = new System.Drawing.Point(818, 59);
            this.btnSignOutput.Name = "btnSignOutput";
            this.btnSignOutput.Size = new System.Drawing.Size(118, 53);
            this.btnSignOutput.TabIndex = 12;
            this.btnSignOutput.Text = "Abfahrtstafel ausgeben";
            this.btnSignOutput.UseVisualStyleBackColor = true;
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
            // textBoxFrom
            // 
            this.textBoxFrom.BackColor = System.Drawing.Color.White;
            this.textBoxFrom.Location = new System.Drawing.Point(66, 90);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(122, 22);
            this.textBoxFrom.TabIndex = 15;
            this.textBoxFrom.TextChanged += new System.EventHandler(this.textBoxFrom_TextChanged);
            // 
            // textBoxTo
            // 
            this.textBoxTo.BackColor = System.Drawing.Color.White;
            this.textBoxTo.Location = new System.Drawing.Point(264, 90);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(114, 22);
            this.textBoxTo.TabIndex = 16;
            this.textBoxTo.TextChanged += new System.EventHandler(this.textBoxTo_TextChanged);
            // 
            // listBoxFrom
            // 
            this.listBoxFrom.FormattingEnabled = true;
            this.listBoxFrom.ItemHeight = 16;
            this.listBoxFrom.Location = new System.Drawing.Point(26, 118);
            this.listBoxFrom.Name = "listBoxFrom";
            this.listBoxFrom.Size = new System.Drawing.Size(162, 132);
            this.listBoxFrom.TabIndex = 17;
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
            this.listViewOutput.SelectedIndexChanged += new System.EventHandler(this.listViewOutput_SelectedIndexChanged);
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
            this.columnHeader3.Text = "Abfahrtszeit";
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
            this.listBoxSign.SelectedIndexChanged += new System.EventHandler(this.listBoxSign_SelectedIndexChanged);
            // 
            // textBoxSign
            // 
            this.textBoxSign.BackColor = System.Drawing.Color.White;
            this.textBoxSign.Location = new System.Drawing.Point(625, 87);
            this.textBoxSign.Name = "textBoxSign";
            this.textBoxSign.Size = new System.Drawing.Size(173, 22);
            this.textBoxSign.TabIndex = 21;
            this.textBoxSign.TextChanged += new System.EventHandler(this.textBoxSign_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(502, 249);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(434, 301);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1010, 577);
            this.Controls.Add(this.listView1);
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
        private System.Windows.Forms.ListView listView1;
    }
}

