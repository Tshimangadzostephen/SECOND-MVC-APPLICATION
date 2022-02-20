using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4_Memo.Models
{
    public abstract class Shape
    {
        private string mDescription;
        private string mFill;
        private string mStrokeColour;
        private double mStrokeWidth;
        private int mSvgWidth = 450;
        private int mSvgHeight = 450;

        public Shape()
        {

        }

        public Shape(string _description, string _fill, string _strokeColour, double _strokeWidth)
        {
            mDescription = _description;
            mFill = _fill;
            mStrokeColour = _strokeColour;
            StrokeWidth = _strokeWidth;
        }

        public abstract double getArea();

        public abstract string getSVG();

        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }

        public string Fill
        {
            get { return mFill; }
            set { mFill = value; }
        }

        public string StrokeColour
        {
            get { return mStrokeColour; }
            set { mStrokeColour = value; }
        }

        public double StrokeWidth
        {
            get { return mStrokeWidth; }
            set { mStrokeWidth = value; }
        }

        public int SvgWidth
        {
            get { return mSvgWidth; }
        }

        public int SvgHeight
        {
            get { return mSvgHeight; }
        }
    }
}