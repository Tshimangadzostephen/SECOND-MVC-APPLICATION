using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW4_Memo.Models;

namespace HW4_Memo.Controllers
{
    public class HomeController : Controller
    {
        public static List<Shape> shapes = new List<Shape>();

        public ActionResult Index()
        {
            return View(shapes);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(string desc, string fill, string outline, double stroke, int type, int xCoord, int yCoord, int? width, int? height, int? radius, int? topx, int? topy, int? rightx, int? righty, int? leftx, int? lefty, int? rx, int? ry)
        {
            if (type == 1)
            {
                // Create new Rectangle instance and add to list
                Rectangle newR = new Rectangle()
                {
                    Description = desc,
                    Fill = fill,
                    StrokeColour = outline,
                    StrokeWidth = stroke,
                    X = xCoord,
                    y = yCoord,
                    Width = Convert.ToInt32(width),
                    Height = Convert.ToInt32(height),
                };
                shapes.Add(newR);
            }
            else if (type == 2)
            {
                // Create new Circle instance and add to list
                Circle newC = new Circle()
                {
                    Description = desc,
                    Fill = fill,
                    StrokeColour = outline,
                    StrokeWidth = stroke,
                    X = xCoord,
                    Y = yCoord,
                    Radius = Convert.ToInt32(radius),
                };
                shapes.Add(newC);
            }
            else if (type == 3)
            {
                // Create new Circle instance and add to list
                Triangle newT = new Triangle()
                {
                    Description = desc,
                    Fill = fill,
                    StrokeColour = outline,
                    StrokeWidth = stroke,
                    X = xCoord,
                    y = yCoord,
                    leftx = Convert.ToInt32(leftx),
                    lefty = Convert.ToInt32(lefty),
                    topx = Convert.ToInt32(topx),
                    topy = Convert.ToInt32(topy),
                    rightx = Convert.ToInt32(rightx),
                    righty = Convert.ToInt32(righty),
                };
                shapes.Add(newT);
            }
            else if (type == 4)
            {
                // Create new Circle instance and add to list
                Ellipse newE = new Ellipse()
                {
                    Description = desc,
                    Fill = fill,
                    StrokeColour = outline,
                    StrokeWidth = stroke,
                    X = xCoord,
                    Y = yCoord,
                    _rX = Convert.ToInt32(rx),
                    _ry = Convert.ToInt32(ry),
                };
                shapes.Add(newE);
            }
            return RedirectToAction("Index");
        }
    }
}