using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace SnakeApp
{
    class Kurbaga
    {
        Random rnd = new Random();
        Point KurbagaYeri = new Point();
        

        public void KurbagaRandom(OvalShape ovalKurbaga)
        {
            KurbagaYeri.X = rnd.Next(1,42)*20;
            KurbagaYeri.Y = rnd.Next(1,28)*20;
            ovalKurbaga.BackColor = Color.Red;
            ovalKurbaga.Location = KurbagaYeri;

        }
    }
}
