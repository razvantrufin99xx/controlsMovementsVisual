using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlsMovementsVisual
{
    public partial class vctrl : UserControl
    {
        public vctrl()
        {
            InitializeComponent();
        }
        public Form1 f;

        public int aXpos = 0;
        public int aYpos = 0;

        public void setXYos(int a, int b)
        { 
            this.aXpos = a;
            this.aYpos = b;
        }
        public  List<int> listXY = new List<int>();
        public List<int> returnListaXY()
        {
            return this.listXY;
        }
        public void addXYinListXY()
        {
            listXY.Add(this.aXpos);
            listXY.Add(this.aYpos);
        }
        private void vctrl_Load(object sender, EventArgs e)
        {
            try
            {
                f = (Form1)Parent;
            }
            catch { }
        }

        private void vctrl_MouseDown(object sender, MouseEventArgs e)
        {
            
            f.showCurrentMouseSelectedSQuare(this.listXY);
        }
    }
}
