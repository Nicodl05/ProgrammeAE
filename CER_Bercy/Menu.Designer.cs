namespace CER_Bercy
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btn_RMensuel = new System.Windows.Forms.Button();
            this.btn_ResumeM = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_RMensuel
            // 
            this.btn_RMensuel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_RMensuel.Location = new System.Drawing.Point(410, 217);
            this.btn_RMensuel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_RMensuel.Name = "btn_RMensuel";
            this.btn_RMensuel.Size = new System.Drawing.Size(304, 77);
            this.btn_RMensuel.TabIndex = 0;
            this.btn_RMensuel.Text = "Fonctionnement du programme";
            this.btn_RMensuel.UseVisualStyleBackColor = false;
            this.btn_RMensuel.Click += new System.EventHandler(this.btn_RMensuel_Click);
            // 
            // btn_ResumeM
            // 
            this.btn_ResumeM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ResumeM.Location = new System.Drawing.Point(410, 328);
            this.btn_ResumeM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ResumeM.Name = "btn_ResumeM";
            this.btn_ResumeM.Size = new System.Drawing.Size(304, 77);
            this.btn_ResumeM.TabIndex = 2;
            this.btn_ResumeM.Text = "Résumé Moniteur";
            this.btn_ResumeM.UseVisualStyleBackColor = false;
            this.btn_ResumeM.Click += new System.EventHandler(this.btn_ResumeM_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 470);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 240);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(483, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 74);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bercy";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(986, 660);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 70);
            this.button1.TabIndex = 5;
            this.button1.Text = "Crédits";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(410, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(304, 67);
            this.button2.TabIndex = 6;
            this.button2.Text = "Autres heures";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ResumeM);
            this.Controls.Add(this.btn_RMensuel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_RMensuel;
        private Button btn_ResumeM;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}