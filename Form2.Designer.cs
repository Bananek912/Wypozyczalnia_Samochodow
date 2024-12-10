namespace Projekt_winforms
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ZapisDaty = new System.Windows.Forms.GroupBox();
            this.RefreshTable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Refresh = new System.Windows.Forms.Button();
            this.Czyscik = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.adding_button = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.ZapisDaty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_date
            // 
            this.timer_date.AutoSize = true;
            this.timer_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timer_date.Location = new System.Drawing.Point(23, 36);
            this.timer_date.Name = "timer_date";
            this.timer_date.Size = new System.Drawing.Size(99, 25);
            this.timer_date.TabIndex = 0;
            this.timer_date.Text = "timer-date";
            this.timer_date.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(45, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATE";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timer_date);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(861, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // ZapisDaty
            // 
            this.ZapisDaty.Controls.Add(this.button1);
            this.ZapisDaty.Controls.Add(this.label3);
            this.ZapisDaty.Controls.Add(this.label2);
            this.ZapisDaty.Controls.Add(this.comboBox1);
            this.ZapisDaty.Controls.Add(this.dateTimePicker1);
            this.ZapisDaty.Controls.Add(this.RefreshTable);
            this.ZapisDaty.Controls.Add(this.groupBox1);
            this.ZapisDaty.Controls.Add(this.dataGridView1);
            this.ZapisDaty.Controls.Add(this.Refresh);
            this.ZapisDaty.Controls.Add(this.Czyscik);
            this.ZapisDaty.Controls.Add(this.Deletebutton);
            this.ZapisDaty.Controls.Add(this.Editbutton);
            this.ZapisDaty.Controls.Add(this.adding_button);
            this.ZapisDaty.Location = new System.Drawing.Point(12, 12);
            this.ZapisDaty.Name = "ZapisDaty";
            this.ZapisDaty.Size = new System.Drawing.Size(1035, 539);
            this.ZapisDaty.TabIndex = 6;
            this.ZapisDaty.TabStop = false;
            this.ZapisDaty.Enter += new System.EventHandler(this.ZapisDaty_Enter);
            // 
            // RefreshTable
            // 
            this.RefreshTable.Font = new System.Drawing.Font("Sarabun", 8.249999F, System.Drawing.FontStyle.Bold);
            this.RefreshTable.Location = new System.Drawing.Point(910, 179);
            this.RefreshTable.Name = "RefreshTable";
            this.RefreshTable.Size = new System.Drawing.Size(119, 25);
            this.RefreshTable.TabIndex = 16;
            this.RefreshTable.Text = "REFRESH TABLE";
            this.RefreshTable.UseVisualStyleBackColor = true;
            this.RefreshTable.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1035, 329);
            this.dataGridView1.TabIndex = 15;
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("Sarabun", 8.249999F, System.Drawing.FontStyle.Bold);
            this.Refresh.Location = new System.Drawing.Point(673, 32);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(163, 26);
            this.Refresh.TabIndex = 14;
            this.Refresh.Text = "EDIT CLIENT DATABASE";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Czyscik
            // 
            this.Czyscik.Font = new System.Drawing.Font("Sarabun", 8.249999F, System.Drawing.FontStyle.Bold);
            this.Czyscik.Location = new System.Drawing.Point(76, 136);
            this.Czyscik.Name = "Czyscik";
            this.Czyscik.Size = new System.Drawing.Size(91, 26);
            this.Czyscik.TabIndex = 13;
            this.Czyscik.Text = "CLEAR AREA";
            this.Czyscik.UseVisualStyleBackColor = true;
            this.Czyscik.Click += new System.EventHandler(this.Czyscik_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Font = new System.Drawing.Font("Sarabun", 8.249999F, System.Drawing.FontStyle.Bold);
            this.Deletebutton.Location = new System.Drawing.Point(379, 179);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(184, 26);
            this.Deletebutton.TabIndex = 9;
            this.Deletebutton.Text = "DELETE RESERVATION";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // adding_button
            // 
            this.adding_button.Font = new System.Drawing.Font("Sarabun", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adding_button.Location = new System.Drawing.Point(-1, 179);
            this.adding_button.Name = "adding_button";
            this.adding_button.Size = new System.Drawing.Size(184, 26);
            this.adding_button.TabIndex = 3;
            this.adding_button.Text = "ADD RESERVATION";
            this.adding_button.UseVisualStyleBackColor = true;
            this.adding_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Editbutton
            // 
            this.Editbutton.Font = new System.Drawing.Font("Sarabun", 8.249999F, System.Drawing.FontStyle.Bold);
            this.Editbutton.Location = new System.Drawing.Point(189, 179);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(184, 26);
            this.Editbutton.TabIndex = 8;
            this.Editbutton.Text = "EDIT RESERVATION";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 20);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2024, 12, 10, 15, 17, 26, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Sarabun", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 42);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 28);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Text = "Rzeszow...";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sarabun", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "CHOSE RESERVATION DATE";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sarabun", 8.249999F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(17, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "CHOSE YOUR BRANCH";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sarabun", 8.249999F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(673, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 26);
            this.button1.TabIndex = 22;
            this.button1.Text = "EDIT CAR DATABASE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 563);
            this.Controls.Add(this.ZapisDaty);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ZapisDaty.ResumeLayout(false);
            this.ZapisDaty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timer_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox ZapisDaty;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button RefreshTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Czyscik;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button adding_button;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}