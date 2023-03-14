using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konstruqtori_the_Sivrce_1
{
    class Samkutxedi
    {
       public int gverdi_1, gverdi_2, gverdi_3;
        private int perimetri;
        double fartobi;
        public Samkutxedi(int gverdi_1 , int gverdi_2, int gverdi_3)
        {
            this.gverdi_1 = gverdi_1;
            this.gverdi_2 = gverdi_2;
            this.gverdi_3 = gverdi_3;
            perimetri = this.gverdi_1 + this.gverdi_2 + this.gverdi_3;
            fartobi = this.gverdi_1 * this.gverdi_2 / 2.0;
        }
        public void Gamotana_1(Label par_1)
        {
            par_1.Text = "პერიმეტრი = " + perimetri.ToString() + "\n" +
                "ფართობი = " + fartobi.ToString();
        }
    }
}
