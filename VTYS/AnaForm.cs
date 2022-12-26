using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnBireysel_Click(object sender, EventArgs e)
        {
            BireyselForm bireyselform = new BireyselForm();
            bireyselform.ShowDialog();
        }

        private void lblHg_Click(object sender, EventArgs e)
        {

        }
    }
}
