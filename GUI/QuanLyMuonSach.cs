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
    public partial class QuanLyMuonSach : Form
    {
        public QuanLyMuonSach()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.StartPosition = FormStartPosition.Manual;
            menu.Location = this.Location;
            menu.Size = this.Size;
            menu.Show();
        }

        private void TabMuonSach_Click(object sender, EventArgs e)
        {

        }
    }
}
