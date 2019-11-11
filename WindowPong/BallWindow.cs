using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowPong
{
    public partial class BallWindow : Form
    {
        private LPaddle Player1;
        private RPaddle Player2;
        Random Random = new Random();
        public int XVelocity = 5;
        public int YVelocity = 0;
        public int P1Score = 0;
        public int P2Score = 0;
        int XRes;
        int YRes;
        public bool p1movesUp = false, p1movesDown = false, p2movesUp = false, p2movesDown = false;


        public BallWindow()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public void BallWindow_Shown(object sender, EventArgs e)
        {
            Rectangle Resolution = Screen.PrimaryScreen.Bounds;
            XRes = Resolution.Width;
            YRes = Resolution.Height;

            Player1 = new LPaddle();
            Player1.Show();
            Player1.Location = new Point(0, ((YRes / 2) - 242));

            Player2 = new RPaddle();
            Player2.Show();
            Player2.Location = new Point((XRes - 77), (YRes / 2 - 242));
            Focus();
        }

        private void BallWindow_Load(object sender, EventArgs e)
        {
            ballPhysics.RunWorkerAsync();
        }

        private void BallPhysics_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1000);
            while (true)
            {
                Location = new Point(Location.X + (XVelocity), Location.Y + (YVelocity));
                BallBounce();
            }

        }

        private void BallWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'i':
                    p2movesUp = true;
                    break;

                case 'k':
                    p2movesDown = true;
                    break;

                case 'w':
                    p1movesUp = true;
                    break;

                case 's':
                    p1movesDown = true;
                    break;
            }
            CheckIfMoving();

        }

        public void CheckIfMoving()
        {
            if (p2movesUp == true)
                Player2.Location = new Point(Player2.Location.X, Player2.Location.Y - 60);
            if (p2movesDown == true)
                Player2.Location = new Point(Player2.Location.X, Player2.Location.Y + 60);
            if (p1movesUp == true)
                Player1.Location = new Point(Player1.Location.X, Player1.Location.Y - 60);
            if (p1movesDown == true)
                Player1.Location = new Point(Player1.Location.X, Player1.Location.Y + 60);
            p1movesUp = false; p1movesDown = false; p2movesUp = false; p2movesDown = false;
        }

        private void BallBounce()
        {
            if(Location.X <= 0)
            {
                XVelocity = 0;
                YVelocity = 0;
                ++P2Score;
                Player2.Score.Text = P2Score.ToString();
                Location = new Point((XRes / 2)-56, (YRes / 2)-56);
                XVelocity = 3;
            }

            if (Location.X >= XRes)
            {
                XVelocity = 0;
                YVelocity = 0;
                ++P1Score;
                Player1.Score.Text = P1Score.ToString();
                Location = new Point((XRes / 2) - 56, (YRes / 2) - 56);
                XVelocity = -3;
            }

            if (Location.Y <= 0)
            {
                YVelocity = Random.Next(1, 3);
            }

            if (Location.Y >= YRes - 56)
            {
                YVelocity = -Random.Next(1, 3);
            }
            try
            {
                if (Bounds.IntersectsWith(Player1.Bounds))
                {
                    XVelocity = Random.Next(1, 3);
                    YVelocity = Random.Next(1, 3);
                }

                if (Bounds.IntersectsWith(Player2.Bounds))
                {
                    XVelocity = -Random.Next(1, 3);
                    YVelocity = -Random.Next(1, 3);
                }
            }
            catch (Exception) { }
 
            Location = new Point(Location.X + XVelocity, Location.Y + YVelocity);
        }

    }
}
