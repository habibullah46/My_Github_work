﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_calculator
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }
        public void LoadList(List<string>myList)
    {
        listBox1 .DataSource=myList;
        this.ShowDialog();
    }
    }
}
