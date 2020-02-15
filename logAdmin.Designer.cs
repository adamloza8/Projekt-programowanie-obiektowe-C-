namespace Szpital
{
    partial class logAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dodaj_pielęgniarkeBTN = new System.Windows.Forms.Button();
            this.Dodaj_lekarzaBTN = new System.Windows.Forms.Button();
            this.Dodaj_adminaBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dodaj_pielęgniarkeBTN
            // 
            this.Dodaj_pielęgniarkeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dodaj_pielęgniarkeBTN.Location = new System.Drawing.Point(287, 185);
            this.Dodaj_pielęgniarkeBTN.Name = "Dodaj_pielęgniarkeBTN";
            this.Dodaj_pielęgniarkeBTN.Size = new System.Drawing.Size(113, 105);
            this.Dodaj_pielęgniarkeBTN.TabIndex = 0;
            this.Dodaj_pielęgniarkeBTN.Text = "Edytuj pielęgniarki";
            this.Dodaj_pielęgniarkeBTN.UseVisualStyleBackColor = true;
            this.Dodaj_pielęgniarkeBTN.Click += new System.EventHandler(this.Dodaj_pielęgniarkeBTN_Click);
            // 
            // Dodaj_lekarzaBTN
            // 
            this.Dodaj_lekarzaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dodaj_lekarzaBTN.Location = new System.Drawing.Point(12, 185);
            this.Dodaj_lekarzaBTN.Name = "Dodaj_lekarzaBTN";
            this.Dodaj_lekarzaBTN.Size = new System.Drawing.Size(110, 105);
            this.Dodaj_lekarzaBTN.TabIndex = 2;
            this.Dodaj_lekarzaBTN.Text = "Edytuj lekarzy";
            this.Dodaj_lekarzaBTN.UseVisualStyleBackColor = true;
            this.Dodaj_lekarzaBTN.Click += new System.EventHandler(this.Dodaj_lekarzaBTN_Click);
            // 
            // Dodaj_adminaBTN
            // 
            this.Dodaj_adminaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dodaj_adminaBTN.Location = new System.Drawing.Point(138, 128);
            this.Dodaj_adminaBTN.Name = "Dodaj_adminaBTN";
            this.Dodaj_adminaBTN.Size = new System.Drawing.Size(131, 105);
            this.Dodaj_adminaBTN.TabIndex = 4;
            this.Dodaj_adminaBTN.Text = "Edytuj administratorów";
            this.Dodaj_adminaBTN.UseVisualStyleBackColor = true;
            this.Dodaj_adminaBTN.Click += new System.EventHandler(this.Dodaj_adminaBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(50, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Panel Sterowania";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(138, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 105);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zobacz wszystkich pracowników";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dodaj_adminaBTN);
            this.Controls.Add(this.Dodaj_lekarzaBTN);
            this.Controls.Add(this.Dodaj_pielęgniarkeBTN);
            this.Name = "logAdmin";
            this.Text = "ZalogowanoAdmina";
            this.Load += new System.EventHandler(this.ZalogowanoAdmina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dodaj_pielęgniarkeBTN;
        private System.Windows.Forms.Button Dodaj_lekarzaBTN;
        private System.Windows.Forms.Button Dodaj_adminaBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}