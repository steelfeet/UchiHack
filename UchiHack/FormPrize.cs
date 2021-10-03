using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchiHack
{
    public partial class FormPrize : Form
    {
        public FormPrize(string best_command)
        {
            InitializeComponent();
            label1.Text = best_command;
        }

        private void FormPrize_Load(object sender, EventArgs e)
        {

        }
    }
}
