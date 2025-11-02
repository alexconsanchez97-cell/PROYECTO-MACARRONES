using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class ECUACIONES_LIN : Form
    {
        public ECUACIONES_LIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EL1 el1 = new EL1();
            el1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EL2 el2 = new EL2();
            el2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EL3 el3 = new EL3();
            el3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EL4 el4 = new EL4();
            el4.Show();
        }
    }
}
