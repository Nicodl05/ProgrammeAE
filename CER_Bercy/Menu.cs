namespace CER_Bercy
{
    public partial class Menu : Form
    {
        public Menu() {
            InitializeComponent();
        }

        private void btn_RMensuel_Click(object sender, EventArgs e) {
            this.Hide();
            Resume_Mensuel resume_Mensuel = new Resume_Mensuel();
            resume_Mensuel.Show();
        }

        private void CA_Click(object sender, EventArgs e) {
            this.Hide();
            CA chiffres=new CA();
            chiffres.Show();
        }

        private void btn_ResumeM_Click(object sender, EventArgs e) {
            this.Hide();
            Resume_Moniteur resume_Moniteur = new Resume_Moniteur();
            resume_Moniteur.Show();
        }
   

        private void button1_Click_1(object sender, EventArgs e) {
            this.Hide();
            Credits credits = new Credits();
            credits.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
            Autres_heures autres = new Autres_heures();
            autres.Show();
        }
    }
}