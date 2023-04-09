using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Fonction abdonnée */
namespace CER_Bercy
{
    public partial class CA : Form
    {
        public CA() {
            InitializeComponent();
            List<double> list_syl = new List<double>();
            List<double> list_dom = new List<double>();
            List<double> list_lui = new List<double>();
            // faire les totaux
            // Resume_Moniteur resume_Moniteur = new Resume_Moniteur();
            double result = 0;
            syl_auto.Text = Resume_Moniteur.Load_data("syl", "auto");
            list_syl.Add(Convert.ToDouble(syl_auto.Text)*65);
            autoauto.Text=Convert.ToString((Convert.ToDouble(syl_auto.Text) * 65));
            syl_auto.Text = Convert.ToString(Convert.ToDouble(syl_auto.Text) * 65)+" €";



            syl_manu.Text = Resume_Moniteur.Load_data("syl", "manu");
            list_syl.Add(Convert.ToDouble(syl_manu.Text) * 60);
            manumanu.Text= Convert.ToString((Convert.ToDouble(syl_manu.Text) * 60));    // label bilan manu
            syl_manu.Text= Convert.ToString(Convert.ToDouble(syl_manu.Text) * 60) + " €";// label manu 

            syl_moto.Text = Resume_Moniteur.Load_data("syl", "moto");
            list_syl.Add(Convert.ToDouble(syl_moto.Text) * 56);
            motomoto.Text= Convert.ToString((Convert.ToDouble(syl_moto.Text) * 56));    // label bilan moto
            syl_moto.Text = Convert.ToString(Convert.ToDouble(syl_moto.Text) * 56) + " €";

            dom_auto.Text = Resume_Moniteur.Load_data("dom", "auto");
            list_dom.Add(Convert.ToDouble(dom_auto.Text) * 65);
            autoauto.Text = Convert.ToString(Convert.ToDouble(autoauto.Text) + Convert.ToDouble(dom_auto.Text) * 65) ;  // label bilan manu
            dom_auto.Text = Convert.ToString(Convert.ToDouble(dom_auto.Text) * 65) + " €";

            dom_manu.Text = Resume_Moniteur.Load_data("dom", "manu");
            list_dom.Add(Convert.ToDouble(dom_manu.Text) * 60);
            manumanu.Text = Convert.ToString(Convert.ToDouble(manumanu.Text) + Convert.ToDouble(dom_manu.Text) * 60);
            dom_manu.Text = Convert.ToString(Convert.ToDouble(dom_manu.Text) * 60) + " €";
            

            dom_moto.Text = Resume_Moniteur.Load_data("dom", "moto");
            list_dom.Add(Convert.ToDouble(dom_moto.Text) * 56);
            motomoto.Text = Convert.ToString(Convert.ToDouble(motomoto.Text) + Convert.ToDouble(dom_moto.Text) * 56) ;
            dom_moto.Text = Convert.ToString(Convert.ToDouble(dom_moto.Text) * 56) + " €";

            bil_dom.Text = Resume_Moniteur.Load_data("dom", "bilan");
            list_dom.Add(Convert.ToDouble(bil_dom.Text) * 112);
            bilanbilan.Text = Convert.ToString((Convert.ToDouble(bil_dom.Text) * 112));
            bil_dom.Text = Convert.ToString(Convert.ToDouble(bil_dom.Text) * 112) + " €";
            
            bil_syl.Text = Resume_Moniteur.Load_data("syl", "bilan");
            list_syl.Add(Convert.ToDouble(bil_syl.Text) * 112);
            bilanbilan.Text = Convert.ToString(Convert.ToDouble(bilanbilan.Text) + Convert.ToDouble(bil_syl.Text) * 112);
            bil_syl.Text = Convert.ToString(Convert.ToDouble(bil_syl.Text) * 112) + " €";

            syl_oscar.Text = Resume_Moniteur.Load_data("syl", "Oscar");
            list_syl.Add(Convert.ToDouble(syl_oscar.Text) * 20);
            oscaroscar.Text= Convert.ToString((Convert.ToDouble(syl_oscar.Text) * 20));
            syl_oscar.Text= Convert.ToString(Convert.ToDouble(syl_oscar.Text) * 20) + " €";

            dom_oscar.Text = Resume_Moniteur.Load_data("dom", "Oscar");
            list_dom.Add(Convert.ToDouble(dom_oscar.Text) * 20);
            oscaroscar.Text= Convert.ToString(Convert.ToDouble(oscaroscar.Text) + Convert.ToDouble(dom_oscar.Text) * 20) ;
            dom_oscar.Text = Convert.ToString(Convert.ToDouble(dom_oscar.Text) * 20) + " €";
            
            depd.Text = Resume_Moniteur.Load_data("dom", "dep");
            list_dom.Add(Convert.ToDouble(depd.Text) * 60);
           // dept.Text = Convert.ToString((Convert.ToDouble(depd.Text) * 60));
            depd.Text = Convert.ToString(Convert.ToDouble(depd.Text) * 60)+ " €";
                
            deps.Text = Resume_Moniteur.Load_data("syl", "dep");
            l_dep.Text = Resume_Moniteur.Load_data("lui", "dep");
            list_syl.Add(Convert.ToDouble(deps.Text) * 60);
           dept.Text= Convert.ToString(Convert.ToDouble(Convert.ToDouble(Resume_Moniteur.Load_data("syl", "dep"))+Convert.ToDouble(Resume_Moniteur.Load_data("dom","dep"))+Convert.ToDouble(Resume_Moniteur.Load_data("lui","dep")))*60)+" €";
            deps.Text = Convert.ToString(Convert.ToDouble(deps.Text) * 60)+" €";

          
            list_lui.Add(Convert.ToDouble(l_dep.Text) * 60);

            // dept.Text = Convert.ToString(Convert.ToDouble(Resume_Moniteur.Load_data("dom", "dep")) + Convert.ToDouble(Resume_Moniteur.Load_data("syl", "dep"))) + " h";
            l_auto.Text = Resume_Moniteur.Load_data("lui", "auto");
            list_lui.Add(Convert.ToDouble(l_auto.Text) * 65);
            autoauto.Text = Convert.ToString(Convert.ToDouble(autoauto.Text) + Convert.ToDouble(l_auto.Text) * 65) + " €";
            l_auto.Text= Convert.ToString(Convert.ToDouble(l_auto.Text)*65)+" €";


            l_manu.Text = Resume_Moniteur.Load_data("lui", "manu") ;
            list_lui.Add(Convert.ToDouble(l_manu.Text) * 60);
            manumanu.Text = Convert.ToString(Convert.ToDouble(manumanu.Text) + Convert.ToDouble(l_manu.Text) * 60) + " €";
            l_manu.Text = Convert.ToString(Convert.ToDouble(l_manu.Text) * 60) + " €";



            l_moto.Text = Resume_Moniteur.Load_data("lui", "moto") ;
            list_lui.Add(Convert.ToDouble(l_moto.Text) * 56);
            motomoto.Text = Convert.ToString((Convert.ToDouble(l_moto.Text) * 56));    // label bilan moto
            l_moto.Text = Convert.ToString(Convert.ToDouble(l_moto.Text) * 56) + " €";



            l_oscar.Text = Resume_Moniteur.Load_data("lui", "Oscar") ;
            list_lui.Add(Convert.ToDouble(l_oscar.Text) * 20);
            oscaroscar.Text = Convert.ToString(Convert.ToDouble(oscaroscar.Text) + Convert.ToDouble(l_oscar.Text) * 20) + " €";
            l_oscar.Text = Convert.ToString(Convert.ToDouble(l_oscar.Text) * 20) + " €";


            l_bilan.Text = Resume_Moniteur.Load_data("lui", "bilan");
            list_lui.Add(Convert.ToDouble(l_bilan.Text) * 112);
            bilanbilan.Text = Convert.ToString(Convert.ToDouble(bilanbilan.Text) + Convert.ToDouble(l_bilan.Text) * 112) + " €";
            l_bilan.Text = Convert.ToString(Convert.ToDouble(l_bilan.Text) * 112) + " €";

          

            double total_syl = list_syl.Sum();
            double total_dom=list_dom.Sum();
            double total_lui = list_lui.Sum();
            syl_tot.Text =Convert.ToString(total_syl)+" €";
            dom_tot.Text = Convert.ToString(total_dom)+" €";
            l_tot.Text = Convert.ToString(total_lui) + " €";
            double total = total_dom + total_syl+total_lui;
            totl.Text = Convert.ToString(total) + " € ";           
        }

        private void CA_Load(object sender, EventArgs e) {

        }

        private void Total_Click(object sender, EventArgs e) {

        }

        private void bil_syl_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void dept_Click(object sender, EventArgs e) {

        }

        private void syl_tot_Click(object sender, EventArgs e) {

        }

        private void dom_oscar_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void l_dep_Click(object sender, EventArgs e) {

        }
    }
}
