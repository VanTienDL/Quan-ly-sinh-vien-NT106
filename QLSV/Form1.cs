using System.ComponentModel;
using System.IO;
using System.Drawing;

namespace QLSV

{

    public partial class Form1 : Form
    {
        int soluong = 0;
        public class Contestant
        {
            public string ID { get; set; }
            public string Ten { get; set; }
            public string GioiTinh { get; set; }
            public double DiemMon1 { get; set; }
            public double DiemMon2 { get; set; }
            public double DiemMon3 { get; set; }

            public double DiemTrungBinh            // Điểm trung bình, làm tròn 2 chữ số
            {
                get
                {
                    return Math.Round((DiemMon1 + DiemMon2 + DiemMon3) / 3, 2);
                }
            }
            public string XepLoai                  // Xếp loại thí sinh
            {
                get
                {
                    if (DiemTrungBinh >= 8 && DiemMon1 >= 6.5 && DiemMon2 >= 6.5 && DiemMon3 >= 6.5)
                        return "Giỏi";
                    else if (DiemTrungBinh >= 6.5 && DiemMon1 >= 5 && DiemMon2 >= 5 && DiemMon3 >= 5)
                        return "Khá";
                    else if (DiemTrungBinh >= 5 && DiemMon1 >= 3.5 && DiemMon2 >= 3.5 && DiemMon3 >= 3.5)
                        return "Trung Bình";
                    else if (DiemTrungBinh >= 3.5 && DiemMon1 >= 2 && DiemMon2 >= 2 && DiemMon3 >= 2)
                        return "Yếu";
                    else
                        return "Kém";
                }
            }
        }

        private BindingList<Contestant> contestants = new BindingList<Contestant>();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu cột được nhấn là cột "Xóa"
            if (e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Xóa thí sinh từ danh sách dữ liệu
                contestants.RemoveAt(e.RowIndex);

                // Cập nhật lại DataGridView
                dataGridView1.DataSource = null; // Loại bỏ liên kết hiện tại
                dataGridView1.DataSource = contestants; // Gán lại danh sách mới
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cấu hình DataGridView
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Thêm cột "ID" với FillWeight là 1 (cột này nhỏ)
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "ID",
                DataPropertyName = "ID",
                FillWeight = 1
            });

            // Thêm cột "Tên" với FillWeight là 4 (cột này lớn gấp 4 lần)
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Tên",
                DataPropertyName = "Ten",
                FillWeight = 4
            });

            // Thêm cột "Giới Tính" với FillWeight là 1
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Giới Tính",
                DataPropertyName = "GioiTinh",
                FillWeight = 1
            });

            // Thêm các cột "Điểm Môn 1", "Điểm Môn 2", "Điểm Môn 3" với FillWeight là 1
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Điểm Môn 1",
                DataPropertyName = "DiemMon1",
                FillWeight = 1
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Điểm Môn 2",
                DataPropertyName = "DiemMon2",
                FillWeight = 1
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Điểm Môn 3",
                DataPropertyName = "DiemMon3",
                FillWeight = 1
            });

            // Thêm cột "Điểm Trung Bình" với FillWeight là 1
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Điểm Trung Bình",
                DataPropertyName = "DiemTrungBinh",
                FillWeight = 1
            });

            // Thêm cột "Xếp Loại" với FillWeight là 1
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Xếp Loại",
                DataPropertyName = "XepLoai",
                FillWeight = 1
            });

            // Thêm cột "Xóa" với FillWeight là 1
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn()
            {
                HeaderText = "Xóa",
                Text = "Xóa",
                UseColumnTextForButtonValue = true,
                FillWeight = 1
            };
            dataGridView1.Columns.Add(btnDelete);

            // Liên kết nguồn dữ liệu với DataGridView
            dataGridView1.DataSource = contestants;

            // Xử lý sự kiện CellContentClick để thực hiện việc xóa
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }






        public Form1()
        {
            InitializeComponent();
            byte[] imageData = Properties.Resources.Logo_UIT_updated_svg; // Thay "TenHinhAnh" bằng tên hình ảnh trong Resources

            using (MemoryStream ms = new MemoryStream(imageData))
            {
                pLogo.Image = Image.FromStream(ms);
            }


            // Cấu hình ComboBox giới tính
            comboGioi.Items.Add("Nam");
            comboGioi.Items.Add("Nữ");

            // Hoặc bạn có thể cấu hình trong thiết kế giao diện (Designer)
            // comboGioi.Items.AddRange(new string[] { "Nam", "Nữ" });

            comboGioi.DropDownStyle = ComboBoxStyle.DropDownList; // Để người dùng không thể nhập giá trị tùy ý
            comboGioi.SelectedIndex = -1; // Không chọn mục nào mặc định
            this.Load += new EventHandler(Form1_Load);
        }

        private void LBone_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LBten_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(tbOne.Text) < 0 || double.Parse(tbOne.Text) > 10)
                {
                    MessageBox.Show("Diem chi tu 0 den 10");
                    return;
                }
                if (double.Parse(tbTwo.Text) < 0 || double.Parse(tbTwo.Text) > 10)
                {
                    MessageBox.Show("Diem chi tu 0 den 10");
                    return;
                }
                if (double.Parse(tbThree.Text) < 0 || double.Parse(tbThree.Text) > 10)
                {
                    MessageBox.Show("Diem chi tu 0 den 10");
                    return;
                }
                if (tbTen.Text == null || tbTen.Text.Length == 0)
                {
                    MessageBox.Show("Hay dien ten");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Oops, somethings went wrong","Bug or error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            try
            {
                string id = $"TS{(++soluong).ToString("D3")}";
                // Parse dữ liệu từ các TextBox và ComboBox
                string ten = tbTen.Text;
                string gioiTinh = comboGioi.SelectedItem.ToString();

                double diemMon1 = double.Parse(tbOne.Text);
                double diemMon2 = double.Parse(tbTwo.Text);
                double diemMon3 = double.Parse(tbThree.Text);

                // Tạo đối tượng Contestant và thêm vào danh sách
                Contestant contestant = new Contestant()
                {
                    ID = id,
                    Ten = ten,
                    GioiTinh = gioiTinh,
                    DiemMon1 = diemMon1,
                    DiemMon2 = diemMon2,
                    DiemMon3 = diemMon3
                };

                contestants.Add(contestant);  // Thêm thí sinh vào danh sách

                // Clear các TextBox và ComboBox để sẵn sàng nhập liệu mới
                tbTen.Clear();
                tbOne.Clear();
                tbTwo.Clear();
                tbThree.Clear();
                comboGioi.SelectedIndex = -1;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho các điểm môn.");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Vui lòng chọn giới tính.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbOne.Clear();
            tbTwo.Clear();
            tbThree.Clear();
            tbTen.Clear();
            comboGioi.SelectedIndex = -1;
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            int soLuongThiSinh = contestants.Count;
            var thiSinhDiemCaoNhat = contestants.OrderByDescending(c => c.DiemTrungBinh).FirstOrDefault();
            string tenThiSinhDiemCaoNhat = thiSinhDiemCaoNhat?.Ten ?? "Không có";

            int soLuongGioi = contestants.Count(c => c.XepLoai == "Giỏi");
            int soLuongKha = contestants.Count(c => c.XepLoai == "Khá");
            int soLuongTrungBinh = contestants.Count(c => c.XepLoai == "Trung Bình");
            int soLuongYeu = contestants.Count(c => c.XepLoai == "Kém");

            MessageBox.Show($"Số lượng thí sinh: {soLuongThiSinh}\n" +
                             $"Tên thí sinh có điểm trung bình cao nhất: {tenThiSinhDiemCaoNhat}\n" +
                             $"Số lượng thí sinh xếp loại giỏi: {soLuongGioi}\n" +
                             $"Số lượng thí sinh xếp loại khá: {soLuongKha}\n" +
                             $"Số lượng thí sinh xếp loại trung bình: {soLuongTrungBinh}\n" +
                             $"Số lượng thí sinh không đạt (xếp loại yếu,kém): {soLuongYeu}",
                             "Thống Kê Thí Sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
