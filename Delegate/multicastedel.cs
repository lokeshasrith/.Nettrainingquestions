using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Multicast Delegates
A multicast delegate is a type of delegate that can hold references to more than one method. When you invoke the delegate, it calls all the methods in its list, in the order they were added.

Why Use Multicast Delegates?
Useful when you want to perform multiple actions with a single event or action (e.g., click a button and update the UI and log data).
How It Works:
You can add multiple methods to a multicast delegate using the += operator.
The methods should have the same signature as the delegate.  */

namespace c_training
{
    public delegate void RectDelegate(double width, double height);
    public class multicastedel
    {
        public void Getarea(double width, double height)
        {
            Console.WriteLine("Area of rectangle : " + width * height);
        }
        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine("Perimeter of rectangle : " + 2 * (width * height));
        }
    }
}

// object 
multicastedel Rect = new multicastedel();
RectDelegate obj = Rect.Getarea;
obj += Rect.GetPerimeter;
obj.Invoke(122.03, 190.27);
