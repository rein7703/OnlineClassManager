
namespace Kuliah_Manager
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblHello = new System.Windows.Forms.Label();
            this.tbMatkul = new System.Windows.Forms.TextBox();
            this.lblMatkul = new System.Windows.Forms.Label();
            this.lblMeeting = new System.Windows.Forms.Label();
            this.tbMeeting = new System.Windows.Forms.TextBox();
            this.lblPresensi = new System.Windows.Forms.Label();
            this.tbPresensi = new System.Windows.Forms.TextBox();
            this.lblDrive = new System.Windows.Forms.Label();
            this.tbDrive = new System.Windows.Forms.TextBox();
            this.cbHari = new System.Windows.Forms.ComboBox();
            this.lblHari = new System.Windows.Forms.Label();
            this.lblWaktu = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTitle.Location = new System.Drawing.Point(471, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(263, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Online Class Manager";
            this.lblTitle.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(518, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(608, 450);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(52, 101);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(58, 23);
            this.lblHello.TabIndex = 3;
            this.lblHello.Text = "Hello, ";
            // 
            // tbMatkul
            // 
            this.tbMatkul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatkul.Location = new System.Drawing.Point(181, 145);
            this.tbMatkul.Name = "tbMatkul";
            this.tbMatkul.Size = new System.Drawing.Size(278, 27);
            this.tbMatkul.TabIndex = 4;
            // 
            // lblMatkul
            // 
            this.lblMatkul.AutoSize = true;
            this.lblMatkul.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatkul.Location = new System.Drawing.Point(52, 145);
            this.lblMatkul.Name = "lblMatkul";
            this.lblMatkul.Size = new System.Drawing.Size(113, 23);
            this.lblMatkul.TabIndex = 5;
            this.lblMatkul.Text = "Nama Matkul";
            // 
            // lblMeeting
            // 
            this.lblMeeting.AutoSize = true;
            this.lblMeeting.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeeting.Location = new System.Drawing.Point(52, 189);
            this.lblMeeting.Name = "lblMeeting";
            this.lblMeeting.Size = new System.Drawing.Size(108, 23);
            this.lblMeeting.TabIndex = 7;
            this.lblMeeting.Text = "Link Meeting";
            // 
            // tbMeeting
            // 
            this.tbMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMeeting.Location = new System.Drawing.Point(181, 189);
            this.tbMeeting.Name = "tbMeeting";
            this.tbMeeting.Size = new System.Drawing.Size(278, 27);
            this.tbMeeting.TabIndex = 6;
            // 
            // lblPresensi
            // 
            this.lblPresensi.AutoSize = true;
            this.lblPresensi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresensi.Location = new System.Drawing.Point(52, 231);
            this.lblPresensi.Name = "lblPresensi";
            this.lblPresensi.Size = new System.Drawing.Size(107, 23);
            this.lblPresensi.TabIndex = 9;
            this.lblPresensi.Text = "Link Presensi";
            // 
            // tbPresensi
            // 
            this.tbPresensi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPresensi.Location = new System.Drawing.Point(181, 231);
            this.tbPresensi.Name = "tbPresensi";
            this.tbPresensi.Size = new System.Drawing.Size(278, 27);
            this.tbPresensi.TabIndex = 8;
            // 
            // lblDrive
            // 
            this.lblDrive.AutoSize = true;
            this.lblDrive.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrive.Location = new System.Drawing.Point(52, 278);
            this.lblDrive.Name = "lblDrive";
            this.lblDrive.Size = new System.Drawing.Size(84, 23);
            this.lblDrive.TabIndex = 11;
            this.lblDrive.Text = "Link Drive";
            // 
            // tbDrive
            // 
            this.tbDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDrive.Location = new System.Drawing.Point(181, 278);
            this.tbDrive.Name = "tbDrive";
            this.tbDrive.Size = new System.Drawing.Size(278, 27);
            this.tbDrive.TabIndex = 10;
            // 
            // cbHari
            // 
            this.cbHari.FormattingEnabled = true;
            this.cbHari.Items.AddRange(new object[] {
            "Senin",
            "Selasa",
            "Rabu",
            "Kamis",
            "Jumat"});
            this.cbHari.Location = new System.Drawing.Point(181, 321);
            this.cbHari.Name = "cbHari";
            this.cbHari.Size = new System.Drawing.Size(121, 24);
            this.cbHari.TabIndex = 12;
            // 
            // lblHari
            // 
            this.lblHari.AutoSize = true;
            this.lblHari.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHari.Location = new System.Drawing.Point(52, 322);
            this.lblHari.Name = "lblHari";
            this.lblHari.Size = new System.Drawing.Size(41, 23);
            this.lblHari.TabIndex = 13;
            this.lblHari.Text = "Hari";
            // 
            // lblWaktu
            // 
            this.lblWaktu.AutoSize = true;
            this.lblWaktu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaktu.Location = new System.Drawing.Point(52, 363);
            this.lblWaktu.Name = "lblWaktu";
            this.lblWaktu.Size = new System.Drawing.Size(58, 23);
            this.lblWaktu.TabIndex = 15;
            this.lblWaktu.Text = "Waktu";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.comboBox1.Location = new System.Drawing.Point(181, 362);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(65, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.comboBox2.Location = new System.Drawing.Point(275, 362);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(65, 24);
            this.comboBox2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = ":";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(181, 411);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(285, 411);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 33);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(384, 411);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 572);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblWaktu);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblHari);
            this.Controls.Add(this.cbHari);
            this.Controls.Add(this.lblDrive);
            this.Controls.Add(this.tbDrive);
            this.Controls.Add(this.lblPresensi);
            this.Controls.Add(this.tbPresensi);
            this.Controls.Add(this.lblMeeting);
            this.Controls.Add(this.tbMeeting);
            this.Controls.Add(this.lblMatkul);
            this.Controls.Add(this.tbMatkul);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.TextBox tbMatkul;
        private System.Windows.Forms.Label lblMatkul;
        private System.Windows.Forms.Label lblMeeting;
        private System.Windows.Forms.TextBox tbMeeting;
        private System.Windows.Forms.Label lblPresensi;
        private System.Windows.Forms.TextBox tbPresensi;
        private System.Windows.Forms.Label lblDrive;
        private System.Windows.Forms.TextBox tbDrive;
        private System.Windows.Forms.ComboBox cbHari;
        private System.Windows.Forms.Label lblHari;
        private System.Windows.Forms.Label lblWaktu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}

