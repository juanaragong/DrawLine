namespace Dibujos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g=this.CreateGraphics();
            Pen Lapiz = new Pen(Color.Black,10);

            g.DrawLine(Lapiz,400,0,400,400);
            g.DrawLine(Lapiz, 0, 200, 800, 200);

            Pen lapis = new Pen(Color.Red, 10);
            g.DrawLine(lapis, 400, 200, 800, 0);

            Pen lapes = new Pen(Color.Yellow, 10);
            g.DrawLine(lapes, 400, 200, 0, 400);

            Pen lpas=new Pen(Color.Blue, 10);
            g.DrawLine(lpas, 0, 0, 400, 200);
        }
    }
}
