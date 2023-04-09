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
    public partial class Autres_heures : Form
    {
        static string mona = "";

        //string chemin = @"C:\Users\nicol\OneDrive - Groupe INSEEC (POCE)\ING3\stage\Stage CER Bercy\Code C#\Programme Ecriture Excel\" + mon + ".csv";         
        // string chemin = @"C:\Users\Nicolas\Documents\";

        //string chemin = @"C:\Users\nicol\OneDrive\Documents\";
        // chemin = @"C:\Users\nicol\OneDrive\Documents\" + moniteur + ".csv";
      //  string chemin = @"C:\Users\CER Bercy\OneDrive\Bureau\Programme Nico\";
       // string chemin = @"C:\Users\nicol\Documents\" ;

       // string chemin = @"C:\Users\CER Bercy\OneDrive\Bureau\Programme Nico\Resume\";

        string chemin  = @"C:\Users\CER Bercy\OneDrive\Bureau\Programme Nico\Moniteurs\" ;
        public List<string> _list_acro_np = new List<string> {"_ABS","_FER","_MAL","_PR","_VHL","_REC" };
        public List<string> _list_acro_np2 = new List<string> { "_BUR", "_CEP", "_CP", "_DEP", "_FOR", "_PRO", "_REU", "_COD", "_TEA" };

        public Autres_heures() {
            InitializeComponent();
            s_p.Text = Convert.ToString(Resume_Moniteur.get_precision3(chemin,"Sylvain.csv"));
            d_p.Text= Convert.ToString(Resume_Moniteur.get_precision3(chemin, "Dominique.csv"));
            l_p.Text= Convert.ToString(Resume_Moniteur.get_precision3(chemin, "Jerome.csv"));
            l_np.Text= Convert.ToString(Resume_Moniteur.get_precision2(chemin, "Jerome.csv"));        
            s_np.Text = Convert.ToString(Resume_Moniteur.get_precision2(chemin, "Sylvain.csv"));
            d_np.Text=Convert.ToString(Resume_Moniteur.get_precision2(chemin, "Dominique.csv"));

        }

        private void Autres_heures_Load(object sender, EventArgs e) {
            
        }

        private void s_p_Click(object sender, EventArgs e) {

        }

        private void menu_Click(object sender, EventArgs e) {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void d_p_Click(object sender, EventArgs e) {

        }

        private void luig_Click(object sender, EventArgs e) {

        }
    }
}
