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
    public partial class QuanLyTraSach : Form
    {
        public QuanLyTraSach()
        {
            InitializeComponent();
        }

        private void ThemBtn_Click(object sender, EventArgs e)
        {

        }

        private void XoaBtn_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                var menu = new Menu();
                menu.StartPosition = FormStartPosition.Manual;
                menu.Location = this.Location;
                menu.Size = this.Size;
                menu.Show();
            }
        }
    }
}
