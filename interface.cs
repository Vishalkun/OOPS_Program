using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    internal class @interface
    {
        public interface Drawable
        {
            void draw();
        }
        public class Rectangle : Drawable
        {
            public void draw()
            {
                Console.WriteLine("drawing rectangle...");
            }
        }
        public class Circle : Drawable
        {
            public void draw()
            {
                Console.WriteLine("drawing circle...");
            }
        }
    }
}
