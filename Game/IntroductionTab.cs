﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class IntroductionTab : Form
    {
        public IntroductionTab()
        {
            InitializeComponent();
        }

        private void btnProceedToGame_Click(object sender, EventArgs e)
        {
            DifficultySelection difficultyselection= new DifficultySelection();
            difficultyselection.Show();
        }
    }
}
