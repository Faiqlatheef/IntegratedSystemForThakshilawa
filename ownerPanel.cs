﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegratedSystemThakshilawa
{
    public partial class ownerPanel : Form
    {
        public ownerPanel()
        {
            InitializeComponent();
        }

        private void ownerPanel_Load(object sender, EventArgs e)
        {
            labelUsername.Text = session.getUserData;
        }
    }
}
