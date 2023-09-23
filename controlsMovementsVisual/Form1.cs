namespace controlsMovementsVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<List<vctrl>> matrixlist = new List<List<vctrl>>();
        public List<int> xypairs = new List<int>();

        public int X = 0;
        public int Y = 0;
        public int PX = 0;
        public int PY = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

            //create and load and load controls int oform and show
            for (int i = 0; i < 50; i++)
            {
                matrixlist.Add(new List<vctrl>());
                for (int j = 0; j < 50; j++)
                {
                    matrixlist[i].Add(new vctrl());

                    matrixlist[i][j].Left = 100 + (j * 5);
                    matrixlist[i][j].Top = 100 + (i * 5);
                    matrixlist[i][j].Width = 4;
                    matrixlist[i][j].Height = 4;
                    this.Controls.Add(matrixlist[i][j]);
                    matrixlist[i][j].Visible = true;
                    matrixlist[i][j].Enabled = false;

                    matrixlist[i][j].setXYos(i, j);
                    matrixlist[i][j].addXYinListXY();
                }
            }

            matrixlist[0][0].BackColor = Color.White;
            xypairs.Add(0);
            xypairs.Add(0);
            this.Focus();
        }

        public void showCurrentMouseSelectedSQuare(List<int> xy)
        {
            this.label1.Text = xy[0].ToString() + " : " + xy[1].ToString();
        }

        public void coloringAllPositionsPasted()
        {
            int a;
            int b;
            for (int i = 0; i < xypairs.Count; i += 2)
            {
                try
                {
                    a = xypairs[i];
                    b = xypairs[i + 1];
                    //create a degrade list of colors in blue , red , yellow, green and subcolors between them and then colorate this
                    //you can select a number of last n vctrl's
                    matrixlist[a][b].BackColor = Color.Blue;
                }
                catch { }
            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {


        }
        public void rc()
        {
            matrixlist[PX][PY].BackColor = Color.Red;
            matrixlist[PX][PY].BackColor = Color.Blue;
            matrixlist[X][Y].BackColor = Color.White;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Text = e.KeyValue.ToString();
            PY = Y;
            PX = X;
            if (e.KeyValue.ToString() == "37") { if (Y > 0) { Y = Y - 1; rc(); } }//left
            else if (e.KeyValue.ToString() == "38") { if (X > 0) { X = X - 1; rc(); } }//up
            else if (e.KeyValue.ToString() == "39") { if (Y < 49) { Y = Y + 1; rc(); } }//right
            else if (e.KeyValue.ToString() == "40") { if (X < 49) { X = X + 1; rc(); } }//down
            else if (e.KeyValue.ToString() == "32") { enableall(); } //space
            else if (e.KeyValue.ToString() == "13") { disableall(); } //enter
            else { Text = e.KeyValue.ToString() + " : "; }
            xypairs.Add(X);
            xypairs.Add(Y);
            Text += X.ToString() + " : " + Y.ToString() + " || " + PX.ToString() + " : " + PY.ToString();
            //coloringAllPositionsPasted();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {

                for (int j = 0; j < 50; j++)
                {
                    matrixlist[i][j].Enabled = true;
                }
            }
        }
        public void enableall()
        {
            for (int i = 0; i < 50; i++)
            {

                for (int j = 0; j < 50; j++)
                {
                    matrixlist[i][j].Enabled = true;
                }
            }
            button2.Enabled = true;
        }

        public void disableall()
        {
            for (int i = 0; i < 50; i++)
            {

                for (int j = 0; j < 50; j++)
                {
                    matrixlist[i][j].Enabled = false;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {

                for (int j = 0; j < 50; j++)
                {
                    matrixlist[i][j].Enabled = false;
                }
            }
            button2.Enabled = false;
        }
    }
}