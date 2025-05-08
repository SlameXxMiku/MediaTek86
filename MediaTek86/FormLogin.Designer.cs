namespace MediaTek86
    {
    partial class FormLogin
        {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
            {
            this.Login = new System.Windows.Forms.TextBox();
            this.Label_Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Se_connecter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(516, 153);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(211, 20);
            this.Login.TabIndex = 0;
            // 
            // Label_Login
            // 
            this.Label_Login.AutoSize = true;
            this.Label_Login.Location = new System.Drawing.Point(599, 137);
            this.Label_Login.Name = "Label_Login";
            this.Label_Login.Size = new System.Drawing.Size(33, 13);
            this.Label_Login.TabIndex = 1;
            this.Label_Login.Text = "Login";
            this.Label_Login.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(516, 240);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(211, 20);
            this.Password.TabIndex = 2;
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(599, 224);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(53, 13);
            this.Label_Password.TabIndex = 3;
            this.Label_Password.Text = "Password";
            // 
            // Se_connecter
            // 
            this.Se_connecter.Location = new System.Drawing.Point(577, 358);
            this.Se_connecter.Name = "Se_connecter";
            this.Se_connecter.Size = new System.Drawing.Size(92, 23);
            this.Se_connecter.TabIndex = 4;
            this.Se_connecter.Text = "Se connecter";
            this.Se_connecter.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Se_connecter);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Label_Login);
            this.Controls.Add(this.Login);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label Label_Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.Button Se_connecter;
        }
    }

