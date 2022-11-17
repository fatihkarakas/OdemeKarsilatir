using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdemeKarsilatir
{
    public partial class AcilisEkran : Form
    {
        public AcilisEkran()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 8;
            if(panel2.Width >= 684)
            {
                timer1.Stop();
                OdemeDosyasi o = new OdemeDosyasi();
                o.Show();
                this.Hide();
            }
        }
    }
}
