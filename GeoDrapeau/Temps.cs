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
<<<<<<< HEAD
            timer.Tick += tick;
=======
            timer.Tick += Tick0;
>>>>>>> 2d6e4962c8dc883de375af27dfcf32ad65a5b73c
        }
        public void start()
        {
            timer.Start();
        }
        public void stop()
        {
            timer.Stop();
        }
<<<<<<< HEAD
        public void tick(object sender, object e)
=======
        public void Tick0(object sender, object e)
>>>>>>> 2d6e4962c8dc883de375af27dfcf32ad65a5b73c
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
