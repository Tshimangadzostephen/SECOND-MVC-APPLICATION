using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4_Memo.Models
{
    public class Triangle : Shape
    {
        private int mX;
        private int mY;
        private int rightX;
        private int rightY;
        private int leftX;
        private int leftY;
        private int topX;
        private int topY;

        public Triangle()
        {

        }

        public Triangle(int _X, int _Y, int _rightX, int _rightY, int _leftX, int _leftY, int _topX, int _topY, string _description, string _fill, string _strokeColour, double _strokeWidth) : base(_description, _fill, _strokeColour, _strokeWidth)
        {
            mX = _X;
            mY = _Y;
            rightX = _rightX;
            rightY = _rightY;
            leftX = _leftX;
            leftY = _leftY;
            topX = _topX;
            topY = _topY;
        }

        public override double getArea()
        {
            double area = 0;
            area = 0.5 * (rightX - leftX) * (((rightY + leftY) / 2)-topY);
            return area;
        }

        public override string getSVG()
        {
            return $"<svg style = 'border: 1pt dashed #333' height = '{base.SvgHeight}' width = '{base.SvgWidth}'><polygon points='{topX},{topY} {rightX},{rightY} {leftX},{leftY}' style = 'fill:{base.Fill} ;stroke:{base.StrokeColour};stroke‐width:{base.StrokeWidth}'/></svg>";
            //return "<svg style = 'border: 1pt dashed #333' height = '" + base.SvgHeight + "' width = '" + base.SvgWidth + "'>< polygon points = '" + topX + "','" + topY + "' '" + rightX + "','" + rightY + "' '" + leftX + "','" + leftY + "' style = 'fill:lime;stroke:purple;stroke-width:1' /></ svg >";
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

        public int topx
        {
            get { return topX; }
            set { topX = value; }
        }
        public int topy
        {
            get { return topY; }
            set { topY = value; }
        }
        public int rightx
        {
            get { return rightX; }
            set { rightX = value; }
        }
        public int righty
        {
            get { return rightY; }
            set { rightY = value; }
        }
        public int leftx
        {
            get { return leftX; }
            set { leftX = value; }
        }
        public int lefty
        {
            get { return leftY; }
            set { leftY = value; }
        }
    }
}