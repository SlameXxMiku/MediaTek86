﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86
    {
    ///
    ///Formulaire de gestion des Absences
    ///
    public partial class FormAbsence : Form
        {
        ///
        ///Formulaire de gestion des Absences
        ///
        public FormAbsence()
            {
            InitializeComponent();
            Absence(); // Charge les données dans le DataGridView
            }

        private void TextBox1_TextChanged(object sender, EventArgs e)
            {

            }

        private void DataGriedViewAbsence_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }
        }
    }
