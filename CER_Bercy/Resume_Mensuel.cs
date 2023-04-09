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
    public partial class Resume_Mensuel : Form
    {
        public Resume_Mensuel() {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {

        }

        private void menu_Click(object sender, EventArgs e) {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
                    
        }
    }
}
