using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renk_değiştirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbRed_Scroll(object sender, EventArgs e)
        {
            int r, g, b;

            r = tbRed.Value;
            g = tbGreen.Value;
            b = tbBlue.Value;

            lblRed.Text=r.ToString();

            this.BackColor=System.Drawing.Color.FromArgb(r,g,b);
        }

        private void tbGreen_Scroll(object sender, EventArgs e)
        {
            int r, g, b;

            r = tbRed.Value;
            g = tbGreen.Value;
            b = tbBlue.Value;

            lblGreen.Text = g.ToString();

            this.BackColor = System.Drawing.Color.FromArgb(r, g, b);

        }

        private void tbBlue_Scroll(object sender, EventArgs e)
        {
            int r, g, b;

            r = tbRed.Value;
            g = tbGreen.Value;
            b = tbBlue.Value;

            lblBlue.Text = b.ToString();

            this.BackColor = System.Drawing.Color.FromArgb(r, g, b);
        }
    }
}
