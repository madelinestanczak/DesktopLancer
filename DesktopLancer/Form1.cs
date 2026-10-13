namespace DesktopLancer
{
    public partial class Form1 : Form
    {

        bool mouseDown;
        private Point offset;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Lime;
            this.TransparencyKey = Color.Lime;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
            this.BackColor = Color.Red;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
                this.TransparencyKey = Color.Lime;
            }
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            this.TransparencyKey = Color.Red;
        }
    }
}
