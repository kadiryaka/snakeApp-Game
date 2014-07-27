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
    class OvalShapeClass
    {
        OvalShape oval1, oval2, oval3, oval4, oval5, oval6;
        Boolean sag, sol, asagi, yukari;
        List<OvalShape> dizi = new List<OvalShape>();
        Kurbaga kurbaga = new Kurbaga();
        Random rnd = new Random();

        Point yer1 = new Point();
        Point yer2 = new Point();
        Point yer3 = new Point();
        Point yeniOvalKonum = new Point();
        Point YilanBasiKonumu = new Point();
        public int puan;

        public OvalShapeClass()
        {
        }

        public void IlkDegerAtama(OvalShape oval1, OvalShape oval2, OvalShape oval3, OvalShape oval4, OvalShape oval5, OvalShape oval6)
        {
            this.oval1 = oval1;
            this.oval2 = oval2;
            this.oval3 = oval3;
            this.oval4 = oval4;
            this.oval5 = oval5;
            this.oval6 = oval6;
            
            dizi.Add(this.oval1);             
            dizi.Add(this.oval2);
            dizi.Add(this.oval3);
            dizi.Add(this.oval4);
            dizi.Add(this.oval5);
            dizi.Add(this.oval6);
            puan = 0;
        }

        public void ClickUp()
        {
            yer1.X = dizi[0].Location.X;            //yukarı tuşuna yani w YE BASILINCA YILANIN BAŞININ POZİSYONUNUN DEĞİŞİMİ YANSITILMIŞ
            yer1.Y = dizi[0].Location.Y - 20;
            dizi[0].Location = yer1;
        }
        public void ClickDown()
        {
            yer1.X = dizi[0].Location.X;
            yer1.Y = dizi[0].Location.Y + 20;
            dizi[0].Location = yer1;
        }
        public void ClickRight()
        {
            yer1.X = dizi[0].Location.X + 20;
            yer1.Y = dizi[0].Location.Y;
            dizi[0].Location = yer1;
        }
        public void ClickLeft()
        {
            yer1.X = dizi[0].Location.X - 20;
            yer1.Y = dizi[0].Location.Y;
            dizi[0].Location = yer1;
        }
        public void YilanVucutCarpisma(Timer timer)
        {
                for (int i = 2; i < dizi.Count; i++)
                { 
                    if (dizi[0].Location == dizi[i].Location)   //yılanın başının vücuduna çarpıp çarpmadığı kontrol ediliyor
                    {
                        timer.Stop();
                        MessageBox.Show("OGame Over");
                    }
                }
        }
        public void HucreIlerlet(Boolean sag, Boolean sol, Boolean asagi, Boolean yukari,Timer timer,OvalShape ovalKurbaga)
        {
            this.sag = sag;
            this.sol = sol;
            this.asagi = asagi;
            this.yukari = yukari;
            
            if (sag)  //sağa doğru gidiyorsa
            {
                
                
                yer2 = dizi[0].Location;
                Boolean kontrol = true;
                ClickRight();
                for (int i = 1; i < dizi.Count; i++)
                {
                    yer1 = yer3;
                    yer3 = dizi[i].Location;                 //yılanın vücudu 1 birim öteye kaydırılıyor
                    if (kontrol)
                    {
                        dizi[i].Location = yer2;
                        kontrol = false;
                    }
                    else
                    {
                        dizi[i].Location = yer1;
                    }
                }
                YilanVucutCarpisma(timer);
                if (dizi[0].Location.X == Form1.frm.Width - 20)  //sınırlara çarpıp çarpmadığı kontrol ediliyor
                {
                    YilanBasiKonumu.X = 0;
                    YilanBasiKonumu.Y=dizi[0].Location.Y;
                    dizi[0].Location = YilanBasiKonumu;
                    
                }
            }
            else if (sol)
            {
                yer2 = dizi[0].Location;
                Boolean kontrol = true;
                ClickLeft();
                for (int i = 1; i < dizi.Count; i++)
                {
                    yer1 = yer3;
                    yer3 = dizi[i].Location;
                    if (kontrol)
                    {
                        dizi[i].Location = yer2;
                        kontrol = false;
                    }
                    else
                    {
                        dizi[i].Location = yer1;
                    }
                }
                if (dizi[0].Location.X == -20)  //sınırlara çarpıp çarpmadığı kontrol ediliyor
                {
                    YilanBasiKonumu.X = 880;
                    YilanBasiKonumu.Y = dizi[0].Location.Y;
                    dizi[0].Location = YilanBasiKonumu;
                }
                YilanVucutCarpisma(timer);
            }
            else if (asagi)
            {
                

                yer2 = dizi[0].Location;
                Boolean kontrol = true;
                ClickDown();

                for (int i = 1; i < dizi.Count; i++)
                {
                    yer1 = yer3;
                    yer3 = dizi[i].Location;
                    if (kontrol)
                    {
                        dizi[i].Location = yer2;
                        kontrol = false;
                    }
                    else
                    {
                        dizi[i].Location = yer1;
                    }
                }
                if (dizi[0].Location.Y == Form1.frm.Height-40)  //sınırlara çarpıp çarpmadığı kontrol ediliyor
                {
                    YilanBasiKonumu.Y = 0;
                    YilanBasiKonumu.X = dizi[0].Location.X;
                    dizi[0].Location = YilanBasiKonumu;
                }
                YilanVucutCarpisma(timer);
            }
            else if (yukari)
            {
                YilanVucutCarpisma(timer);

                yer2 = dizi[0].Location;
                Boolean kontrol = true;
                ClickUp();
                for (int i = 1; i < dizi.Count; i++)
                {
                    yer1 = yer3;
                    yer3 = dizi[i].Location;
                    if (kontrol)
                    {
                        dizi[i].Location = yer2;
                        kontrol = false;
                    }
                    else
                    {
                        dizi[i].Location = yer1;
                    }
                }
                if (dizi[0].Location.Y == -20 )  //sınırlara çarpıp çarpmadığı kontrol ediliyor
                {
                    YilanBasiKonumu.Y = 560;
                    YilanBasiKonumu.X = dizi[0].Location.X;
                    dizi[0].Location = YilanBasiKonumu;
                }
                YilanVucutCarpisma(timer); //yılanın vücuduna çarpıp çarpmadığı kontrol ediliyor

            }

            if (dizi[0].Location == ovalKurbaga.Location) //yılanın kurbağayı yeyip yemediği kontrol ediliyor
            {
                puan++;
                Form1.frm.lblPuan.Text = ""+puan * 10;
                kurbaga.KurbagaRandom(ovalKurbaga);
                YilaniUzat();
            }
        }

        public void YilaniUzat()     //yılanın geldiği yöne bağlı olarak kuyruğun hangi sona ekleneceği belirleniyor
        { 
            OvalShape yeniOval = new OvalShape();
            yeniOval.Size = new System.Drawing.Size(20, 20);
            yeniOval.BackStyle = BackStyle.Opaque;
            yeniOval.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            Form1.frm.shapeContainer1.Shapes.Add(yeniOval);    //çizim alanı içerisine ekleniyor

            

            if (sag)
            {
                yeniOvalKonum.X = dizi[dizi.Count - 1].Location.X-20;
                yeniOvalKonum.Y = dizi[dizi.Count - 1].Location.Y;
                yeniOval.Location = yeniOvalKonum;
                dizi.Add(yeniOval);
                
            }
            else if (sol)
            {
                yeniOvalKonum.X = dizi[dizi.Count - 1].Location.X + 20;
                yeniOvalKonum.Y = dizi[dizi.Count - 1].Location.Y;
                yeniOval.Location = yeniOvalKonum;
                
                dizi.Add(yeniOval);
            }
            else if (asagi)
            {
                yeniOvalKonum.X = dizi[dizi.Count - 1].Location.X;
                yeniOvalKonum.Y = dizi[dizi.Count - 1].Location.Y-20;
                yeniOval.Location = yeniOvalKonum;
                dizi.Add(yeniOval);
            }
            else if (yukari)
            {
                yeniOvalKonum.X = dizi[dizi.Count - 1].Location.X;
                yeniOvalKonum.Y = dizi[dizi.Count - 1].Location.Y + 20;
                yeniOval.Location = yeniOvalKonum;
                dizi.Add(yeniOval);
            }
            
        }
    }
}
