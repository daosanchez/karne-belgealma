using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDurumGöster_Click(object sender, EventArgs e)
        {
            double ortalama, devamsizlik;
            int zayif;

            ortalama = Convert.ToDouble(txtOrtalama.Text);
            devamsizlik = Convert.ToDouble(txtDevamsizlik.Text);
            zayif = Convert.ToInt32 (txtZayif.Text);

            if (ortalama >= 70 && ortalama > 85 && devamsizlik < 5 && zayif == 0)
            {
                lblDurum.Text = "Teşekkür Belgesi Aldınız";
            }

            else if (ortalama >= 85 && ortalama > 100 && devamsizlik < 5 && zayif == 0)
            {
                lblDurum.Text = "Takdir Belgesi Aldınız";
            }
            
            else if (devamsizlik > 5)
            {
                lblDurum.Text = "Devamsızlık Fazla";
            }
            
            else if (zayif != 0)
            {
                lblDurum.Text = "Zayıf Var";
            }
        }
    }
}
