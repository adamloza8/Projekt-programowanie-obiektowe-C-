namespace Szpital
{
    partial class Logowanie
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.login_text = new System.Windows.Forms.Label();
            this.haslo_text = new System.Windows.Forms.Label();
            this.zaloguj_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_box
            // 
            this.login_box.Location = new System.Drawing.Point(222, 68);
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(100, 20);
            this.login_box.TabIndex = 0;
            this.login_box.TextChanged += new System.EventHandler(this.login_box_TextChanged);
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(222, 117);
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '*';
            this.password_box.Size = new System.Drawing.Size(100, 20);
            this.password_box.TabIndex = 1;
            this.password_box.TextChanged += new System.EventHandler(this.password_box_TextChanged);
            // 
            // login_text
            // 
            this.login_text.AutoSize = true;
            this.login_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_text.Location = new System.Drawing.Point(112, 68);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(65, 25);
            this.login_text.TabIndex = 2;
            this.login_text.Text = "Login";
            this.login_text.Click += new System.EventHandler(this.login_text_Click);
            // 
            // haslo_text
            // 
            this.haslo_text.AutoSize = true;
            this.haslo_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.haslo_text.Location = new System.Drawing.Point(112, 111);
            this.haslo_text.Name = "haslo_text";
            this.haslo_text.Size = new System.Drawing.Size(67, 25);
            this.haslo_text.TabIndex = 3;
            this.haslo_text.Text = "Hasło";
            // 
            // zaloguj_button
            // 
            this.zaloguj_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zaloguj_button.Location = new System.Drawing.Point(164, 173);
            this.zaloguj_button.Name = "zaloguj_button";
            this.zaloguj_button.Size = new System.Drawing.Size(109, 38);
            this.zaloguj_button.TabIndex = 4;
            this.zaloguj_button.Text = "zaloguj";
            this.zaloguj_button.UseVisualStyleBackColor = true;
            this.zaloguj_button.Click += new System.EventHandler(this.zaloguj_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(42, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wprowadź dane do zalogowania";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 236);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zaloguj_button);
            this.Controls.Add(this.haslo_text);
            this.Controls.Add(this.login_text);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.login_box);
            this.Name = "Logowanie";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label login_text;
        private System.Windows.Forms.Label haslo_text;
        private System.Windows.Forms.Button zaloguj_button;
        private System.Windows.Forms.Label label1;
    }
}

