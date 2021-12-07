using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    [ToolboxBitmap(typeof(NumTb))]
    public partial class NumTb : TextBox
    {
        public NumTb()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get
            {
                return base.Text;
            

                }
            set
            {
                try
                {
                    int.Parse(value);
                    base.Text = value;
                    return;
                }
                catch
                { }
                if (value == null )
                {
                    base.Text = value;
                    return;
                }
            }
            
        }
        public delegate void InvalidUserEntryEvent(object sender, KeyPressEventArgs e);
        public event InvalidUserEntryEvent invalidUserEntry;

        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            int asciiInterger = Convert.ToInt32(e.KeyChar);
            if (asciiInterger >= 47 && asciiInterger <= 57)
            {
                e.Handled = false;
                return;
            }
            if (asciiInterger == 8)
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
            if (invalidUserEntry != null)
                invalidUserEntry(this, e);
        }
    }
}
