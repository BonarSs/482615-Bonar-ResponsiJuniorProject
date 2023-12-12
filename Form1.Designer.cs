namespace HR_Support
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbNamaKaryawan = new TextBox();
            cbDept = new ComboBox();
            listBox1 = new ListBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            dgvData = new DataGridView();
            tbIdKaryawan = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 89);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Karyawan: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 128);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Dep. Karyawan:";
            // 
            // tbNamaKaryawan
            // 
            tbNamaKaryawan.Location = new Point(178, 86);
            tbNamaKaryawan.Name = "tbNamaKaryawan";
            tbNamaKaryawan.Size = new Size(202, 23);
            tbNamaKaryawan.TabIndex = 2;
            // 
            // cbDept
            // 
            cbDept.FormattingEnabled = true;
            cbDept.Location = new Point(183, 125);
            cbDept.Name = "cbDept";
            cbDept.Size = new Size(201, 23);
            cbDept.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(594, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(174, 169);
            listBox1.TabIndex = 4;
            // 
            // btn1
            // 
            btn1.Location = new Point(64, 200);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 31);
            btn1.TabIndex = 5;
            btn1.Text = "Insert";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(328, 200);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 31);
            btn2.TabIndex = 6;
            btn2.Text = "Edit";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(594, 200);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 31);
            btn3.TabIndex = 7;
            btn3.Text = "Delete";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(19, 241);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(771, 202);
            dgvData.TabIndex = 8;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // tbIdKaryawan
            // 
            tbIdKaryawan.Location = new Point(178, 46);
            tbIdKaryawan.Name = "tbIdKaryawan";
            tbIdKaryawan.Size = new Size(202, 23);
            tbIdKaryawan.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 49);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 9;
            label3.Text = "id_karyawan";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbIdKaryawan);
            Controls.Add(label3);
            Controls.Add(dgvData);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(listBox1);
            Controls.Add(cbDept);
            Controls.Add(tbNamaKaryawan);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbNamaKaryawan;
        private ComboBox cbDept;
        private ListBox listBox1;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private DataGridView dgvData;
        private TextBox tbIdKaryawan;
        private Label label3;
    }
}