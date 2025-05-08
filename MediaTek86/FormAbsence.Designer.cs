namespace MediaTek86
    {
    partial class FormAbsence
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
            this.btn_personnel = new System.Windows.Forms.Button();
            this.btn_Absence = new System.Windows.Forms.Button();
            this.dataGriedViewAbsence = new System.Windows.Forms.DataGridView();
            this.btn_add_personnel = new System.Windows.Forms.Button();
            this.btn_del_personnel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriedViewAbsence)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_personnel
            // 
            this.btn_personnel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_personnel.Location = new System.Drawing.Point(0, 0);
            this.btn_personnel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_personnel.Name = "btn_personnel";
            this.btn_personnel.Size = new System.Drawing.Size(640, 130);
            this.btn_personnel.TabIndex = 2;
            this.btn_personnel.Text = "Personnel";
            this.btn_personnel.UseVisualStyleBackColor = false;
            // 
            // btn_Absence
            // 
            this.btn_Absence.BackColor = System.Drawing.Color.Maroon;
            this.btn_Absence.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Absence.Location = new System.Drawing.Point(640, 0);
            this.btn_Absence.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Absence.Name = "btn_Absence";
            this.btn_Absence.Size = new System.Drawing.Size(624, 130);
            this.btn_Absence.TabIndex = 3;
            this.btn_Absence.Text = "Absence";
            this.btn_Absence.UseVisualStyleBackColor = false;
            // 
            // dataGriedViewAbsence
            // 
            this.dataGriedViewAbsence.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGriedViewAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGriedViewAbsence.Location = new System.Drawing.Point(210, 131);
            this.dataGriedViewAbsence.Name = "dataGriedViewAbsence";
            this.dataGriedViewAbsence.Size = new System.Drawing.Size(1054, 550);
            this.dataGriedViewAbsence.TabIndex = 5;
            this.dataGriedViewAbsence.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGriedViewAbsence_CellContentClick);
            // 
            // btn_add_personnel
            // 
            this.btn_add_personnel.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_add_personnel.Location = new System.Drawing.Point(0, 131);
            this.btn_add_personnel.Name = "btn_add_personnel";
            this.btn_add_personnel.Size = new System.Drawing.Size(210, 183);
            this.btn_add_personnel.TabIndex = 6;
            this.btn_add_personnel.Text = "Ajouter Absence";
            this.btn_add_personnel.UseVisualStyleBackColor = false;
            // 
            // btn_del_personnel
            // 
            this.btn_del_personnel.BackColor = System.Drawing.Color.Red;
            this.btn_del_personnel.Location = new System.Drawing.Point(0, 314);
            this.btn_del_personnel.Name = "btn_del_personnel";
            this.btn_del_personnel.Size = new System.Drawing.Size(210, 183);
            this.btn_del_personnel.TabIndex = 7;
            this.btn_del_personnel.Text = "Supprimer Absence";
            this.btn_del_personnel.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(0, 497);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 183);
            this.button3.TabIndex = 8;
            this.button3.Text = "Modifier Absence";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // FormAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_del_personnel);
            this.Controls.Add(this.btn_add_personnel);
            this.Controls.Add(this.dataGriedViewAbsence);
            this.Controls.Add(this.btn_Absence);
            this.Controls.Add(this.btn_personnel);
            this.Name = "FormAbsence";
            this.Text = "FormAbsence";
            ((System.ComponentModel.ISupportInitialize)(this.dataGriedViewAbsence)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.Button btn_personnel;
        private System.Windows.Forms.Button btn_Absence;
        private System.Windows.Forms.DataGridView dataGriedViewAbsence;
        private System.Windows.Forms.Button btn_add_personnel;
        private System.Windows.Forms.Button btn_del_personnel;
        private System.Windows.Forms.Button button3;
        }
    }