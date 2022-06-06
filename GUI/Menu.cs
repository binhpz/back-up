using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Menu : Form
    {
        private TheLoaiBus theLoaiBus = new TheLoaiBus();

        private long selectedTheLoai = -1;
        public Menu()
        {
            InitializeComponent();
            loadTableTheLoai();
            MaTheLoaiTb.ReadOnly = true;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void TabQuanLySach_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void siticoneDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TableDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TableTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ThemTLBtn_Click(object sender, EventArgs e)
        {
            var tenTheLoai = this.TenTheLoaiTb.Text;
            if (tenTheLoai == "")
            {
                MessageBox.Show("Nhập tên thể loại");
            }else if (!theLoaiBus.add(tenTheLoai))
            {
                MessageBox.Show("Thể loại đã tồn tại");
            } else
            {
                MessageBox.Show("Thêm thành công");
                loadTableTheLoai();
            }
        
        }

        private void TenTheLoaiTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void TableTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            /*
            DataGridViewRow row = TableTheLoai.Rows[e.RowIndex];
            var data1 = row.Cells[0].Value.ToString();
            var data2 = row.Cells[1].Value.ToString();
            Console.WriteLine("-----------------> ", data1);
            Console.WriteLine("-----------------> ", data2);
            */ 

            var dvg = sender as DataGridView;
            //Get the current row's data, if any
            var row = dvg.Rows[e.RowIndex];
            //This works if you data bound the DGV as normal
            var loaisach= row.DataBoundItem as LoaiSach;  //Or DataRow if you're using a Dataset
            if (loaisach != null)
            {
                selectedTheLoai = loaisach.MaLoaiSach;
                MaTheLoaiTb.Text = loaisach.MaLoaiSach.ToString();
                TenTheLoaiTb.Text = loaisach.TenLoaiSach;
            } 
        }

        private void XoaTLBtn_Click(object sender, EventArgs e)
        {
            if (selectedTheLoai >= 0)
            {
                theLoaiBus.delete(selectedTheLoai);
                loadTableTheLoai();
            }
        }

        private void gundfhugkdui_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                var menu = new QuanLyMuonSach();
                menu.StartPosition = FormStartPosition.Manual;
                menu.Location = this.Location;
                menu.Size = this.Size;
                menu.Show();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                var menu = new QuanLyTraSach();
                menu.StartPosition = FormStartPosition.Manual;
                menu.Location = this.Location;
                menu.Size = this.Size;
                menu.Show();
            }
        }

        private void MaTheLoaiTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimTheLoaiTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel15_Click(object sender, EventArgs e)
        {

        }

        private void SuaTLBtn_Click(object sender, EventArgs e)
        {
            if(TenTheLoaiTb.Text == "")
            {
                MessageBox.Show("yêu cầu nhập tên thể loại!");
            } else
            {
                var errors = theLoaiBus.edit(long.Parse(MaTheLoaiTb.Text), TenTheLoaiTb.Text);
                if(errors.Count > 0)
                {
                    var errText = string.Join("\n", errors);
                    MessageBox.Show(errText);
                }else
                {
                    MessageBox.Show("Sửa thành công");
                    loadTableTheLoai();
                }
               
            }
        }

        private void clearTheLoai_Click(object sender, EventArgs e)
        {
            TenTheLoaiTb.Text = "";
            MaTheLoaiTb.Text = "";
            TimTheLoaiTb.Text = "";
            loadTableTheLoai();

            TimTheLoaiTb.Enabled = true;
        }

        private void TimTLBtn_Click(object sender, EventArgs e)
        {
            var id = long.Parse(TimTheLoaiTb.Text);
            var list = theLoaiBus.findById(id);
            var source = new BindingSource(list, null);
            TableTheLoai.DataSource = source;
            TimTheLoaiTb.Enabled = false;
        }

        private void TimTheLoaiTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Back)
                e.SuppressKeyPress = !int.TryParse(Convert.ToString((char)e.KeyData), out int _);
        }


        private void loadTableTheLoai()
        {
            TableTheLoai.DataSource = null;
            var bindingList = theLoaiBus.getList();
            var source = new BindingSource(bindingList, null);
            TableTheLoai.DataSource = source;
        }
    }
}
