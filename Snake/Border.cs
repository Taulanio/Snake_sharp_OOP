using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Border
    {

        //устанавливаем размер окна и рамки
        
        public Border(int width, int height, char sym)
        {
            Console.SetBufferSize(width, height); 
         
            HorizontalLine linH1 = new HorizontalLine(0, width-2, 0, sym);
            linH1.DrawLine();
            HorizontalLine linH2 = new HorizontalLine(0, width - 2, height-1, sym);
            linH2.DrawLine();
            VerticalLine linV1 = new VerticalLine(0, 0, height - 1, sym);
            linV1.DrawLine();
            VerticalLine linV2 = new VerticalLine(width - 2, 0, height - 1, sym);
            linV2.DrawLine();
        }
    }
}
