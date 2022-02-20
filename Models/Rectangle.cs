using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4_Memo.Models
{
    public class Rectangle : Shape
    {
        private int mX;
        private int mY;
        private int mWidth;
        private int mHeight;

        public Rectangle()
        {

        }

        public Rectangle(string _description, string _fill, string _strokeColour, double _strokeWidth, int _X, int _Y, int _Width, int _Height) : base(_description, _fill, _strokeColour, _strokeWidth)
        {
            mX = _X;
            mY = _Y;
            mWidth = _Width;
            mHeight = _Height;
        }

        public override double getArea()
        {
            double area = 0;
            area = mWidth * mHeight;
            return area;
        }

        public override string getSVG()
        {
            return "<svg style = 'border: 1pt dashed #333' height = '" + base.SvgHeight + "' width = '" + base.SvgWidth + "'><rect x='" + mX + "' y='" + mY + "' width='" + mWidth + "' height='" + mHeight + "' style = 'fill:" + base.Fill + ";stroke:" + base.StrokeColour + ";stroke‐width:" + base.StrokeWidth + "'/></svg>";
        }


        public int X
        {
            get { return mX; }
            set { mX = value; }
        }

        public int y
        {
            get { return mY; }
            set { mY = value; }
        }

        public int Width
        {
            get { return mWidth; }
            set { mWidth = value; }
        }

        public int Height
        {
            get { return mHeight; }
            set { mHeight = value; }
        }
    }
}