﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Are_u_dumb_
{
    public partial class areudumb : Form
    {
        public areudumb()
        {
            InitializeComponent();
        }

        private void areudumb_Load(object sender, EventArgs e)
        {
            // in startup
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            // button click "yes" event
            lblareudumb.Text = "I knew it! :3";

            // buttons hide
            btnyes.Hide();
            btnno.Hide();
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            // generate random coordinates to position the button
            Random rnd = new Random();

            int x = rnd.Next(200, 270);
            int y = rnd.Next(220, 280);

            btnno.Location = new Point(x, y);
        }
    }
}
