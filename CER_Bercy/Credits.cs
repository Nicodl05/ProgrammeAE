using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CER_Bercy
{
    public partial class Credits : Form
    {
        public Credits() {
            InitializeComponent();
        }

        private void Credits_Load(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void menu_Click(object sender, EventArgs e) {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
                   
        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
