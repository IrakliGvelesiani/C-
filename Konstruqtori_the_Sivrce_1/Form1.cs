using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konstruqtori_the_Sivrce_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gverdi_1, gverdi_2, gverdi_3;
            int perimetri; 
            double fartobi;
            gverdi_1 = int.Parse(textBox1.Text);
            gverdi_2 = int.Parse(textBox2.Text);
            gverdi_3 = int.Parse(textBox3.Text);
            Samkutxedi obj_samkutxedi = new Samkutxedi(gverdi_1, gverdi_2, gverdi_3);
            obj_samkutxedi.Gamotana_1(label1);

        }

    }
}
