using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.System.Threading;
using Windows.UI.Xaml;

namespace GeoDrapeau
{
    class Temps
    {
        private int tempsDepart = 90;
        private bool estFini = false;
        private static DispatcherTimer dispatcherTimer;

        public int TempsDepart { get => tempsDepart; set => tempsDepart = value; }
        public bool EstFini { get => estFini; set => estFini = value; }
        public static DispatcherTimer timer { get => dispatcherTimer; set => dispatcherTimer = value; }

        public Temps()
        {
            timer = new DispatcherTimer();
            timer.Interval = new System.TimeSpan(0,0,1);

            timer.Tick += tick;

        }
        public void start()
        {
            timer.Start();
        }
        public void stop()
        {
            timer.Stop();
        }
        public void tick(object sender, object e)
        {
            if (TempsDepart > 0)
            {
                TempsDepart -= 1;
            }
            else
            {
                timer.Stop();
                EstFini = true;
            }
        }
    }
}
