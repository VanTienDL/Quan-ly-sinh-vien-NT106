namespace QLSV
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
            dataGridView1 = new DataGridView();
            LBthisinh = new Label();
            LBten = new Label();
            LBgioi = new Label();
            LBone = new Label();
            LBtwo = new Label();
            LBthree = new Label();
            tbTen = new TextBox();
            tbOne = new TextBox();
            tbTwo = new TextBox();
            tbThree = new TextBox();
            btnLuu = new Button();
            btnXoa = new Button();
            LBds = new Label();
            comboGioi = new ComboBox();
            pLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pLogo).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 238);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(797, 272);
            dataGridView1.TabIndex = 0;
            // 
            // LBthisinh
            // 
            LBthisinh.BorderStyle = BorderStyle.FixedSingle;
            LBthisinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBthisinh.Location = new Point(12, 19);
            LBthisinh.Name = "LBthisinh";
            LBthisinh.Size = new Size(622, 179);
            LBthisinh.TabIndex = 1;
            LBthisinh.Text = "Nhập thí sinh";
            // 
            // LBten
            // 
            LBten.AutoSize = true;
            LBten.Location = new Point(29, 58);
            LBten.Name = "LBten";
            LBten.Size = new Size(58, 15);
            LBten.TabIndex = 2;
            LBten.Text = "Họ và tên";
            LBten.Click += LBten_Click;
            // 
            // LBgioi
            // 
            LBgioi.AutoSize = true;
            LBgioi.Location = new Point(30, 102);
            LBgioi.Name = "LBgioi";
            LBgioi.Size = new Size(54, 15);
            LBgioi.TabIndex = 3;
            LBgioi.Text = "Giới Tính";
            // 
            // LBone
            // 
            LBone.AutoSize = true;
            LBone.Location = new Point(400, 61);
            LBone.Name = "LBone";
            LBone.Size = new Size(72, 15);
            LBone.TabIndex = 4;
            LBone.Text = "Điểm môn 1";
            LBone.Click += LBone_Click;
            // 
            // LBtwo
            // 
            LBtwo.AutoSize = true;
            LBtwo.Location = new Point(400, 97);
            LBtwo.Name = "LBtwo";
            LBtwo.Size = new Size(72, 15);
            LBtwo.TabIndex = 5;
            LBtwo.Text = "Điểm môn 2";
            // 
            // LBthree
            // 
            LBthree.AutoSize = true;
            LBthree.Location = new Point(400, 135);
            LBthree.Name = "LBthree";
            LBthree.Size = new Size(72, 15);
            LBthree.TabIndex = 6;
            LBthree.Text = "Điểm môn 3";
            // 
            // tbTen
            // 
            tbTen.Location = new Point(93, 53);
            tbTen.Name = "tbTen";
            tbTen.Size = new Size(287, 23);
            tbTen.TabIndex = 7;
            tbTen.TextChanged += textBox1_TextChanged;
            // 
            // tbOne
            // 
            tbOne.Location = new Point(488, 58);
            tbOne.Name = "tbOne";
            tbOne.Size = new Size(100, 23);
            tbOne.TabIndex = 9;
            // 
            // tbTwo
            // 
            tbTwo.Location = new Point(488, 91);
            tbTwo.Name = "tbTwo";
            tbTwo.Size = new Size(100, 23);
            tbTwo.TabIndex = 10;
            // 
            // tbThree
            // 
            tbThree.Location = new Point(488, 127);
            tbThree.Name = "tbThree";
            tbThree.Size = new Size(100, 23);
            tbThree.TabIndex = 11;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(30, 161);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(126, 161);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // LBds
            // 
            LBds.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBds.Location = new Point(12, 213);
            LBds.Name = "LBds";
            LBds.Size = new Size(148, 22);
            LBds.TabIndex = 14;
            LBds.Text = "Danh sách thí sinh";
            // 
            // comboGioi
            // 
            comboGioi.FormattingEnabled = true;
            comboGioi.Location = new Point(93, 97);
            comboGioi.Name = "comboGioi";
            comboGioi.Size = new Size(121, 23);
            comboGioi.TabIndex = 15;
            // 
            // pLogo
            // 
            pLogo.Location = new Point(640, 19);
            pLogo.Name = "pLogo";
            pLogo.Size = new Size(169, 179);
            pLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pLogo.TabIndex = 16;
            pLogo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 512);
            Controls.Add(pLogo);
            Controls.Add(comboGioi);
            Controls.Add(LBds);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(tbThree);
            Controls.Add(tbTwo);
            Controls.Add(tbOne);
            Controls.Add(tbTen);
            Controls.Add(LBthree);
            Controls.Add(LBtwo);
            Controls.Add(LBone);
            Controls.Add(LBgioi);
            Controls.Add(LBten);
            Controls.Add(LBthisinh);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label LBthisinh;
        private Label LBten;
        private Label LBgioi;
        private Label LBone;
        private Label LBtwo;
        private Label LBthree;
        private TextBox tbTen;
        private TextBox tbOne;
        private TextBox tbTwo;
        private TextBox tbThree;
        private Button btnLuu;
        private Button btnXoa;
        private Label LBds;
        private ComboBox comboGioi;
        private PictureBox pLogo;
    }
}
