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
    public partial class Form1 : Form
    {
        public static Form1 frm; 

        public Form1()
        {
            InitializeComponent();
            frm = this;
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);

            
        }
        Boolean yatay = true, dikey = true, sag = true, sol = false, asagi = false, yukari = false;
        OvalShapeClass kadir = new OvalShapeClass();
        LineShapeClass kadir2 = new LineShapeClass();
        
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            kadir.HucreIlerlet(sag, sol, asagi, yukari,timer1,ovalShape7); //her timer tickinde yumurtalar 1 ilerliyor
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kadir.IlkDegerAtama(ovalShape1, ovalShape2, ovalShape3, ovalShape4, ovalShape5, ovalShape6); //ilk dehger atamaları yapılıyor
            timer1.Start();
            frm = this;
            kadir2.YatayLineShapeOlustur();
            kadir2.DikeyLineShapeOlustur();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)                       
            {
                sag = true;
                sol = false;
                asagi = false;
                yukari = false;
                if (yatay == true || sol == false) { }
                else
                {
                    kadir.ClickRight();
                }
            }

            else if (e.KeyCode == Keys.A)                      
            {
                sag = false;
                sol = true;
                asagi = false;
                yukari = false;
                if (yatay == true) { }
                else
                {
                    kadir.ClickLeft();
                }
            }
            else if (e.KeyCode == Keys.S)//aşağı
            {
                sag = false;
                sol = false;
                asagi = true;
                yukari = false;
                if (dikey == true) {}
                else
                {
                    kadir.ClickDown();
                }
            }
            else if (e.KeyCode == Keys.W)
            {
                sag = false;
                sol = false;
                asagi = false;
                yukari = true;
                if (dikey == true) { }
                else
                {
                    kadir.ClickUp();
                }
            }
        }
    }
}
