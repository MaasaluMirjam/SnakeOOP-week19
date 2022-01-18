using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class HorizontalLine : Figure
    {       
        public HorizontalLine(int xLeft, int xright, int y, char symb)
        {            
           pointList = new List<Point>();

           for (int i = xLeft; i <= xright; i++)
           {
              Point p = new Point(i, y, symb);
              pointList.Add(p);
           }          
        }
    }
}
