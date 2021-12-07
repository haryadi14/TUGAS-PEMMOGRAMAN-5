﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumTb
{
    public partial class UserControl1 : TextBox
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public delegate void InvalidUserEntryEvent(object sender, KeyPressEventArgs e);
        public event InvalidUserEntryEvent InvalidUserEntry;
        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            int asciiInteger = Convert.ToInt32(e.KeyChar);
            if (!(asciiInteger >= 47 && asciiInteger <= 57))
            {
                e.Handled = false;
                return;
            }
            if (asciiInteger == 0)
            {
                e.Handled = false;
            }

            e.Handled = true;

            if (InvalidUserEntry != null)
            {
                InvalidUserEntry(this, e);
            }
        }
    }
}
