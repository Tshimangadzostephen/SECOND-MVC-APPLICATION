using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4_Memo.Models
{
    public class Ellipse:Shape
    {
        private int mX;
        private int mY;
        private int rX;
        private int rY;

        public Ellipse()
        {

        }

        public Ellipse(int _X, int _Y, int cX, int cY, int rX, int rY, string _description, string _fill, string _strokeColour, double _strokeWidth) : base(_description, _fill, _strokeColour, _strokeWidth)
        {

        }

        public override double getArea()
        {
            double area = 0;
            area = (Math.PI * ((rX/2)*(rY/2)));
            return area;
        }

        public override string getSVG()
        {
            return ("<svg style='border: 1pt dashed #333' height='" + base.SvgHeight + "' width='" + base.SvgWidth + "'><ellipse cx='" + mX + "' cy='" + mY + "' rx='" + rX + "' ry='" + rY + "' style='fill:" + base.Fill + ";stroke:" + base.StrokeColour + ";stroke‐width:" + base.StrokeWidth + "'/></svg>");
            
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

        public int _rX
        {
            get { return rX; }
            set { rX = value; }
        }
        public int _ry
        {
            get { return rY; }
            set { rY = value; }
        }
    }
}