﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien_GUI
{
    public partial class formchinh : Form
    {
        public formchinh()
        {
            InitializeComponent();
        }

        private void formchinh_Load(object sender, EventArgs e)
        {

        }

        private void xemĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formsinhvien f = new formsinhvien();
            f.Show();
        }
    }
}
