using System;
using System.Collections;
using ShapeLib;
using System.Text;

namespace ShapesApp
{
    class ShapeManager
    {
        ArrayList myAL = new ArrayList();
        
        public void Add(Shape sh)
        {
            myAL.Add(sh);
        }

        public void DisplayAll()
        {
            foreach (Shape a in myAL)
            {
                a.Display();
                Console.WriteLine("The Area is :  "+a.Area);
                Console.WriteLine();
            }
        }

        public Shape this[int i]
        {
            get
            {
                return (Shape)myAL[i];
            }
            set { myAL[i] = value; }
        }

        public int Count {
            get { return myAL.Count; }
        }

        public void Save(StringBuilder sb)
        {
            foreach (IPersist a in myAL)
            {
                a.Write(sb);
            }
        }

    }
}
