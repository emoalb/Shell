﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shell
{
    public partial class Form1 : Form
    {
        String input = String.Empty;
        public Form1()
        {        
            InitializeComponent();
            label1.Text = "Please type path:";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start($@"{textBox1.Text.ToString()}");
            }catch(Exception exp)
            {

                textBox1.Text = "Error";
            }
        }


    
    }
}
