using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4_Memo.Models
{
    public class Circle : Shape
    {
        private int mX;
        private int mY;
        private int mRadius;

        public Circle()
        {

        }

        public Circle(string _description, string _fill, string _strokeColour, double _strokeWidth, int _X, int _Y, int _Radius) : base(_description, _fill, _strokeColour, _strokeWidth)
        {

        }

        public override double getArea()
        {
            double area = 0;
            area = (Math.PI * (Math.Sqrt(mRadius)));
            return area;
        }

        public override string getSVG()
        {
            return ("<svg style='border: 1pt dashed #333' height='" + base.SvgHeight + "' width='" + base.SvgWidth + "'><circle cx='" + mX + "' cy='" + mY + "' r='" + mRadius + "' style='fill:" + base.Fill + ";stroke:" + base.StrokeColour + ";stroke‐width:" + base.StrokeWidth + "'/></svg>");
        }

        public int X
        {
            get { return mX; }
            set { mX = value; }
        }

        public int Y
        {
            get { return mY; }
            set { mY = value; }
        }

        public int Radius
        {
            get { return mRadius; }
            set { mRadius = value; }
        }

    }
}