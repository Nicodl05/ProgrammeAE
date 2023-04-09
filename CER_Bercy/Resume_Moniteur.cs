using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CER_Bercy
{
    public partial class Resume_Moniteur : Form
    {


        public Resume_Moniteur() {

            InitializeComponent();
            totl.Text = syl_auto.Text;
            syl_auto.Text = Load_data("syl", "auto") + " h";
            syl_manu.Text = Load_data("syl", "manu") + " h";
            syl_moto.Text = Load_data("syl", "moto") + " h";
            syl_oscar.Text = Load_data("syl", "Oscar") + " h";
            bil_syl.Text = Load_data("syl", "bilan") + " h";
            dom_auto.Text = Load_data("dom", "auto") + " h";
            dom_manu.Text = Load_data("dom", "manu") + " h";
            dom_moto.Text = Load_data("dom", "moto") + " h";
            dom_oscar.Text = Load_data("dom", "Oscar") + " h";
            bil_dom.Text = Load_data("dom", "bilan") + " h";
            l_auto.Text = Load_data("jer", "auto") + " h";
            l_manu.Text = Load_data("jer", "manu") + " h";
            l_moto.Text = Load_data("jer", "moto") + " h";
            l_oscar.Text = Load_data("jer", "Oscar") + " h";
            l_bilan.Text = Load_data("jer", "bilan") + " h";
            l_tot.Text = Load_data("jer", "nb") + " h";
            l_dep.Text = Load_data("jer", "dep") + " h";
            syl_tot.Text = Load_data("syl", "nb") + " h";
            dom_tot.Text = Load_data("dom", "nb") + " h";
            depd.Text = Load_data("dom", "dep") + " h";
            deps.Text = Load_data("syl", "dep") + " h";
            l_dep.Text = Load_data("jer", "dep") + " h";
            dept.Text = Convert.ToString(Convert.ToDouble(Convert.ToDouble(Load_data("dom", "dep")) + Convert.ToDouble(Load_data("jer", "dep"))+ Convert.ToDouble(Load_data("syl", "dep")))) + " h";
            totl.Text = Convert.ToString(Convert.ToDouble(Load_data("syl", "nb")) + Convert.ToDouble(Load_data("jer", "nb"))+ Convert.ToDouble(Load_data("dom", "nb"))) + " h";
            bilanbilan.Text = Convert.ToString(Convert.ToDouble(Load_data("syl", "bilan")) + Convert.ToDouble(Load_data("dom", "bilan")) + Convert.ToDouble(Load_data("jer", "bilan"))) + " h";
            autoauto.Text = Convert.ToString(Convert.ToDouble(Load_data("syl", "auto")) + Convert.ToDouble(Load_data("dom", "auto")) + Convert.ToDouble(Load_data("jer", "auto"))) + " h";
            manumanu.Text = Convert.ToString(Convert.ToDouble(Load_data("syl", "manu")) + Convert.ToDouble(Load_data("dom", "manu")) + Convert.ToDouble(Load_data("jer", "manu"))) + " h";
            motomoto.Text = Convert.ToString(Convert.ToDouble(Load_data("syl", "moto")) + Convert.ToDouble(Load_data("dom", "moto")) + Convert.ToDouble(Load_data("jer", "moto"))) + " h";
            oscaroscar.Text = Convert.ToString(Convert.ToDouble(Load_data("syl", "Oscar")) + Convert.ToDouble(Load_data("dom", "Oscar")) + Convert.ToDouble(Load_data("jer", "Oscar"))) + " h";
        }



        static double get_precision(string chemin, string type) {
            List<string> test = new List<string>();
            int cpt = 0;
            string line = "";
            double total_abs = 0;
            List<string> heures = new List<string>();
            heures.Add("00:00");
            string file = chemin;    // path  
            using (StreamReader sr = new StreamReader(file))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    cpt++;
                    string[] lignes;
                    if (cpt != 1)
                    {
                        lignes = line.Split(";");
                        if (lignes[3] != "ATT_DureeCum")
                        {
                            heures.Add(lignes[7]);
                            if (type == "[EXC]")
                            {
                                if (lignes[3].Contains(type) || lignes[3].Contains("[EXP]"))
                                {
                                    string bfr = heures[heures.Count - 2];    // heure précédente
                                    string afr = lignes[7];
                                    string[] hours_bfr = bfr.Split(':');
                                    string[] hours_afr = afr.Split(':');
                                    string br_hour = hours_bfr[0];
                                    string br_min = hours_bfr[1];
                                    string ar_hour = hours_afr[0];
                                    string ar_min = hours_afr[1];
                                    double f_hour = double.Parse(ar_hour) - double.Parse(br_hour);
                                    double f_min = double.Parse(ar_min) - double.Parse(br_min);
                                    string real_time = f_hour + ":" + f_min;
                                    test.Add(real_time);
                                }
                            }
                            else
                            {
                                if (lignes[3].Contains(type))
                                {
                                    string bfr = heures[heures.Count - 2];    // heure précédente
                                    string afr = lignes[7];
                                    string[] hours_bfr = bfr.Split(':');
                                    string[] hours_afr = afr.Split(':');
                                    string br_hour = hours_bfr[0];
                                    string br_min = hours_bfr[1];
                                    string ar_hour = hours_afr[0];
                                    string ar_min = hours_afr[1];
                                    double f_hour = double.Parse(ar_hour) - double.Parse(br_hour);
                                    double f_min = double.Parse(ar_min) - double.Parse(br_min);
                                    string real_time = f_hour + ":" + f_min;
                                    test.Add(real_time);
                                }
                            }

                        }
                    }
                }
            }
            for (int i = 0; i < test.Count; i++)
            {
                string final = test[i];
                string[] hours = final.Split(':');
                double heure_totale = double.Parse(hours[0]) + ((double.Parse(hours[1])) / 100);
                total_abs += heure_totale;
            }
            return total_abs;
        }   //Retourne le nb d'heures précises en cas d'absences ou examen 

        static double get_total(string chemin)    //Compte le nb d'heures total
        {
            double time = 0;
            string line = "";
            string heures_total = "";
            string file = chemin;    // path
            try
            {
                using (StreamReader sr = new StreamReader(chemin))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lignes;
                        lignes = line.Split(";");
                        heures_total = lignes[7];
                    }
                }
                string[] final = heures_total.Split(':');
                time = double.Parse(final[0]);
                double minutes = double.Parse(final[1]);
                time = time + (minutes / 100);
                Console.WriteLine("Avec absences:" + time);
                double abs = get_precision(chemin, "[_ABS]");
                time = time - abs;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }



            return time;
        }

        static double getter(string chemin, string type)     //Compte le nb d'heures en fonction du type
        {
            string line = "";
            double total_moto = 0;
            string file = chemin;    // path  
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lignes;
                        lignes = line.Split(";");
                        if (lignes[3].Contains(type))
                        {

                            total_moto++;

                        }
                    }
                }
            }

            catch (Exception e)
            {
                Console.Write(e);
            }
            return total_moto;
        }

        #region help
        static void EnregistrementdeDonnes(string[,] mat, string fileName)      //programme permetannt d'enregistrer des donnes dans une matrice
        {
            if (mat != null && fileName != null)
            {
                try
                {
                    StreamWriter Sw = new StreamWriter(fileName);       //on ouvre un flux
                    for (int i = 0; i < mat.GetLength(0); i++)
                    {
                        string str = mat[i, 0];     // on va prendre le contenu de chaque case que l'on va faire en un str
                        for (int j = 0; j < mat.GetLength(1); j++)
                        {
                            str += "," + mat[i, j];
                        }
                        Sw.WriteLine(str);      // ecriture de str dans le fichier  
                    }
                    Sw.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        static string[,] ChargementDonnees(string fileName) {
            string[,] mat = null;
            if (fileName != null)
            {
                try
                {
                    StreamReader sr = new StreamReader(fileName);
                    int nb = 0;
                    string ligne = "";
                    while (sr.EndOfStream == false)
                    {
                        nb++;       //augmentation du cpt pour la création de la matrice (colonne)
                        ligne = sr.ReadLine();      // lecture de ligne
                    }
                    mat = new string[nb, 9];
                    sr.Close();
                    int i = 0;
                    StreamReader sr1 = new StreamReader(fileName);      // ouverture du 2ème flux reader
                    while (sr1.EndOfStream == false)
                    {
                        ligne = sr1.ReadLine();
                        string[] temp = ligne.Split(',');   // on sépare chaque case du tableau par rapport au sép de ,
                        for (int j = 0; j < 3; j++)
                        {
                            mat[i, j] = temp[j];        // chaque case de matrice sera complétée
                        }
                        i++;
                    }
                }//try
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }//if
            return mat;
        }
        #endregion


        public static double get_precision2(string chemin, string mona) {
            double ret = 0;
            List<string> test = new List<string>();

            List<string> _list_acro_np = new List<string> { "_ABS", "_FER", "_MAL", "_PR", "_VHL", "_REC" };

            int cpt = 0;
            string line = "";
            double total_abs = 0;
            List<string> heures = new List<string>();
            heures.Add("00:00");
            string type = "";

            chemin = @"C:\Users\Nicolas\Documents\";

            chemin = @"C:\Users\nicol\Documents\";

            chemin = @"C:\Users\CER Bercy\OneDrive\Bureau\Programme Nico\Moniteurs\";
            string file = chemin + mona;    // path  
            using (StreamReader sr = new StreamReader(file))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    cpt++;
                    string[] lignes;
                    if (cpt != 1)
                    {
                        lignes = line.Split(";");
                        if (lignes[3] != "ATT_DureeCum")
                        {

                            heures.Add(lignes[7]);
                            for (int i = 0; i < _list_acro_np.Count; i++)
                            {

                                if (lignes[3].Contains(_list_acro_np[i]))
                                {
                                    string bfr = heures[heures.Count - 2];    // heure précédente
                                    string afr = lignes[7];
                                    string[] hours_bfr = bfr.Split(':');
                                    string[] hours_afr = afr.Split(':'); // splitting le string vers hh::min
                                    string br_hour = hours_bfr[0];
                                    string br_min = hours_bfr[1];
                                    string ar_hour = hours_afr[0];
                                    string ar_min = hours_afr[1];
                                    double f_hour = double.Parse(ar_hour) - double.Parse(br_hour);
                                    double f_min = double.Parse(ar_min) - double.Parse(br_min);
                                    string real_time = f_hour + ":" + f_min;
                                    test.Add(real_time);
                                }
                            }

                        }
                    }

                }
            }
            for (int i = 0; i < test.Count; i++)
            {
                string final = test[i];
                string[] hours = final.Split(':');
                double heure_totale = double.Parse(hours[0]) + ((double.Parse(hours[1])) / 100);
                ret += heure_totale;
            }
            return ret;
        }
        public static double get_precision3(string chemin, string moniteur) {

            double ret = 0;
            List<string> test = new List<string>();
            chemin += moniteur;
            List<string> _list_acro_np2 = new List<string> { "_BUR", "_CEP", "_CP", "_DEP", "_FOR", "_PRO", "_REU", "_COD", "_TEA" };
            int cpt = 0;
            string line = "";
            double total_abs = 0;
            List<string> heures = new List<string>();
            heures.Add("00:00");
            string type = "";
            // chemin= @"C:\Users\CER Bercy\OneDrive\Bureau\Programme Nico\" + moniteur + ".csv";
            chemin = @"C:\Users\Nicolas\Documents\" + moniteur;

            chemin = @"C:\Users\nicol\Documents\" + moniteur;

            chemin= @"C:\Users\CER Bercy\OneDrive\Bureau\Programme Nico\Moniteurs\" + moniteur;
            string file = chemin;    // path  
            using (StreamReader sr = new StreamReader(file))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    cpt++;
                    string[] lignes;
                    if (cpt != 1)
                    {
                        lignes = line.Split(";");
                        if (lignes[3] != "ATT_DureeCum")
                        {

                            heures.Add(lignes[7]);
                            for (int i = 0; i < _list_acro_np2.Count; i++)
                            {
                                if (lignes[3].Contains(_list_acro_np2[i]))
                                {
                                    string bfr = heures[heures.Count - 2];    // heure précédente
                                    string afr = lignes[7];
                                    string[] hours_bfr = bfr.Split(':');
                                    string[] hours_afr = afr.Split(':');
                                    string br_hour = hours_bfr[0];
                                    string br_min = hours_bfr[1];
                                    string ar_hour = hours_afr[0];
                                    string ar_min = hours_afr[1];
                                    double f_hour = double.Parse(ar_hour) - double.Parse(br_hour);
                                    double f_min = double.Parse(ar_min) - double.Parse(br_min);
                                    string real_time = f_hour + ":" + f_min;
                                    test.Add(real_time);
                                }
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < test.Count; i++)
            {
                string final = test[i];
                string[] hours = final.Split(':');
                double heure_totale = double.Parse(hours[0]) + ((double.Parse(hours[1])) / 100);
                ret += heure_totale;
            }
            return ret;
        }
        public static string Load_data(string value, string vehicule) {   //Sélection du programme à utiliser
            double temps_total = 0;   // temps total correspond au nb d'heures comptant absences         
            string moniteur = "";
            string valeurf = "";
            if (value.Contains("dom"))
            {
                moniteur = "Dominique";
            }
            if (value.Contains("syl"))
            {
                moniteur = "Sylvain";
            }
            if (value.Contains("jer"))
            {
                moniteur = "Jerome";
            }
            string chemin = @"C:\Users\nicol\OneDrive - Groupe INSEEC (POCE)\ING3\stage\Stage CER Bercy\Code C#\Programme Ecriture Excel\" + moniteur + ".csv";         //chemin d'accès du fichier                                                                                                                                           //chemin = moniteur + ".csv";
                                                                                                                                                                        //  chemin = @"C:\Users\CER Bercy\Desktop\Programme_recap\" + moniteur + ".csv";
                                                                                                                                                                        //  chemin = @"C:\Users\Nicolas\Documents\" + moniteur + ".csv";

            chemin = @"C:\Users\nicol\Documents\" + moniteur + ".csv";
            //chemin = @"C:\Users\nicol\Documents"
            //chemin = @"C:\Users\nicol\OneDrive\Documents\" + moniteur + ".csv";

            chemin= @"C:\Users\CER Bercy\OneDrive\Bureau\Programme Nico\Moniteurs\" + moniteur + ".csv";
            double temps_auto, temps_manu, temps_moto = 0, temps_pres = 0, dep = 0, eva = 0;
            string type = "";
            switch (vehicule)
            {
                case "auto":
                    type = "[LCA]";
                    temps_total = getter(chemin, type);
                    break;
                case "manu":
                    type = "[LC]";
                    temps_total = getter(chemin, type);
                    break;
                case "moto":
                    type = "[LCM]";
                    temps_total = getter(chemin, type);
                    type = "[LP]";
                    temps_total += getter(chemin, type);
                    break;
                case "nb":
                    temps_total = get_total(chemin);
                    break;
                case "Oscar":
                    type = "[LT]"; // oscar 5h 
                    temps_total = getter(chemin, type);
                    break;
                case "bilan":
                    type = "[BIL]";
                    temps_total = getter(chemin, type);
                    break;
                case "dep":
                    type = "[_DEP]";
                    temps_total = get_precision(chemin, "[_DEP]");
                    break;
                case "c125":
                    type = "[C125]";
                    temps_total = getter(chemin, type);
                    break;
                case "ebea":    // eval initiale permis b automatique
                    type = "[EBEA]";
                    temps_total = getter(chemin, type);
                    break;
                case "lt1":
                    type = "[LT1]";
                    temps_total = getter(chemin, type);
                    break;
                case "p125":
                    type = "[P125]";
                    temps_total = getter(chemin, type);
                    break;
                case "rdvpp":
                    type = "[RPP]";
                    temps_total = getter(chemin, type);
                    break;
                case "rdvt":
                    type = "[RVP]";
                    temps_total = getter(chemin, type);
                    break;

                case "prea":
                    type = "[PREA]";
                    temps_total = getter(chemin, type);
                    break;
                case "preb":
                    type = "[PREB]";
                    temps_total = getter(chemin, type);
                    break;
                case "t125":
                    type = "[T125]";
                    temps_total = getter(chemin, type);
                    break;
                default:
                    //     temps_total = get_precision2(chemin);
                    break;


            }
            valeurf = Convert.ToString(temps_total);
            return valeurf;
        }



        private void back_Click(object sender, EventArgs e) {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

      /*  public void writing_excel(double temps_auto, double temps_manu, double temps_total, double temps_moto, double temps_pres, double dep, double eva, string chemin, string moniteur) {
            DateTime now = DateTime.Now;
            int month = now.Month;
            int year = now.Year;
            StreamWriter sw = new StreamWriter(chemin, true);
            sw.WriteLine(month + "/" + year + ";" + moniteur + ";" + temps_manu + ";" + temps_auto + ";" + temps_moto + ";" + eva + ";" + dep + ";" + temps_pres + ";" + temps_total);
            sw.Close();
        }*/

        private void button2_Click(object sender, EventArgs e) {

            label5.Show();
            //chemin= @"C:\Users\CER Bercy\OneDrive\Bureau\Programme Nico\" + moniteur + ".csv";
            
            string dominique = "dom";
            string sylvain = "syl";
            string jerome = "jer";            
            List<string> lines = new List<string>();
            for (int i = 0; i < 3; i++) {
                switch (i) {
                    case 0:
                        lines.Add(Load_data(sylvain, "auto"));
                        lines.Add(Load_data(sylvain, "manu"));
                        lines.Add(Load_data(sylvain, "Oscar"));
                        lines.Add(Load_data(sylvain, "moto"));
                        lines.Add(Load_data(sylvain, "bilan"));
                        lines.Add(Load_data(sylvain, "dep"));
                        int total3 = Convert.ToInt32(Load_data(sylvain, "auto")) + Convert.ToInt32(Load_data(sylvain, "manu")) + Convert.ToInt32(Load_data(sylvain, "Oscar")) + Convert.ToInt32(Load_data(sylvain, "moto")) + Convert.ToInt32(Load_data(sylvain, "bilan")) + Convert.ToInt32(Load_data(sylvain, "dep"));
                        lines.Add(Convert.ToString(total3)); 
                        break;
                    case 1:
                        lines.Add(Load_data(dominique, "auto"));
                        lines.Add(Load_data(dominique, "manu"));
                        lines.Add(Load_data(dominique, "Oscar"));
                        lines.Add(Load_data(dominique, "moto"));
                        lines.Add(Load_data(dominique, "bilan"));
                        lines.Add(Load_data(dominique, "dep"));
                        int total2 = Convert.ToInt32(Load_data(dominique, "auto")) + Convert.ToInt32(Load_data(dominique, "manu")) + Convert.ToInt32(Load_data(dominique, "Oscar")) + Convert.ToInt32(Load_data(dominique, "moto")) + Convert.ToInt32(Load_data(dominique, "bilan")) + Convert.ToInt32(Load_data(dominique, "dep"));
                        lines.Add(Convert.ToString(total2));
                        break;
                    case 2:
                        lines.Add(Load_data(jerome, "auto"));
                        lines.Add(Load_data(jerome, "manu"));
                        lines.Add(Load_data(jerome, "Oscar"));
                        lines.Add(Load_data(jerome, "moto"));
                        lines.Add(Load_data(jerome, "bilan"));
                        lines.Add(Load_data(jerome, "dep"));
                        int total= Convert.ToInt32(Load_data(jerome, "auto")) + Convert.ToInt32(Load_data(jerome, "manu")) + Convert.ToInt32(Load_data(jerome, "Oscar")) + Convert.ToInt32(Load_data(jerome, "moto")) + Convert.ToInt32(Load_data(jerome, "bilan")) + Convert.ToInt32(Load_data(jerome, "dep"));
                        lines.Add(Convert.ToString(total));

                        break;
                }
            }
            String file_tosave = @"C:\Users\nicol\OneDrive\Documents\save.csv";
            file_tosave = "C:\\Users\\Nicolas\\Documents\\save.csv";
            file_tosave = "C:\\Users\\nicol\\Documents\\save.csv";
            file_tosave= @"C:\Users\CER Bercy\OneDrive\Bureau\Programme Nico\save.csv";
            bool test = false;
            string[] tab = { "Sylvain", "Dominique", "Luiguy" };
            
        
            string[] tab_syl = new string[7];
            string[] tab_dom = new string[7];
            string[] tab_lui = new string[7];
            for (int i = 0; i < 7; i++)
                tab_syl[i] = lines[i]; // remplissage prog des tableaux mon
            for (int i = 7; i < 14; i++)
                tab_dom[i - 7] = lines[i];
            for (int i = 14; i < 21; i++)
                tab_lui[i - 14] = lines[i];
            try
            {
                StreamWriter sw = new StreamWriter(file_tosave, true);
                sw.AutoFlush = true;
                int i = 0;
                sw.WriteLine("Sylvain" + ";" + tab_syl[i] + ";" + tab_syl[i + 1] + ";" + tab_syl[i + 2] + ";" + tab_syl[i + 3] + ";" + tab_syl[i + 4] + ";" + tab_syl[i + 5] + ";" + tab_syl[i + 6] + ";" + System.DateTime.Now.ToString("Y"));
                sw.WriteLine("Dominique" + ";" + tab_dom[i] + ";" + tab_dom[i + 1] + ";" + tab_dom[i + 2] + ";" + tab_dom[i + 3] + ";" + tab_dom[i + 4] + ";" + tab_dom[i + 5]+ ";" + tab_dom[i + 6] + ";" + System.DateTime.Now.ToString("Y"));
                sw.WriteLine("Jerome" + ";" + tab_lui[i] + ";" + tab_lui[i + 1] + ";" + tab_lui[i + 2] + ";" + tab_lui[i + 3] + ";" + tab_lui[i + 4] + ";" + tab_lui[i + 5] + ";" + tab_lui[i + 6] + ";" + System.DateTime.Now.ToString("Y"));
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private void Resume_Moniteur_Load(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void luig_Click(object sender, EventArgs e) {

        }

        private void totl_Click(object sender, EventArgs e) {

        }
    }
}





