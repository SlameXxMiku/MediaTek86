﻿using System;
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
    public partial class FormPersonnel : Form
        {



        public FormPersonnel()
            {
            InitializeComponent();
            Personnel(); // Charge les données dans le DataGridView
            }
        }
    }
