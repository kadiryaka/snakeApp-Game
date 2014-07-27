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
    class LineShapeClass
    {
        public void YatayLineShapeOlustur()  //yatay çizgiler oluşturuluyor
        {
            for (int i = 1; i < 29; i++)
            {
                LineShape yeniLineShape = new LineShape();
                yeniLineShape.X1 = 0;
                yeniLineShape.X2 = 880;
                yeniLineShape.Y1 = i * 20;
                yeniLineShape.Y2 = i * 20;
                yeniLineShape.BorderColor = Color.Black;
                yeniLineShape.BorderWidth = 2;
                Form1.frm.shapeContainer1.Shapes.Add(yeniLineShape);
            }
        }
        public void DikeyLineShapeOlustur()  //dikey çizgiler oluşturuluyor
        {
            for (int i = 1; i < 45; i++)
            {
                LineShape yeniLineShape1 = new LineShape();
                yeniLineShape1.X1 = i * 20;
                yeniLineShape1.X2 = i * 20;
                yeniLineShape1.Y1 = 560;
                yeniLineShape1.Y2 = 0;
                yeniLineShape1.BorderColor = Color.Black;
                yeniLineShape1.BorderWidth = 2;
                Form1.frm.shapeContainer1.Shapes.Add(yeniLineShape1);
            }
        }
    }
}
