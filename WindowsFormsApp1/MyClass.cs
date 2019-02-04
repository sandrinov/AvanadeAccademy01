using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public delegate void ItsSnowingEventHandler(String s, int cm);
    public class MyClass
    {
        public event ItsSnowingEventHandler ItsSnowing;

        public void Snow()
        {
            if (ItsSnowing != null)
                ItsSnowing("Milan", 12);
        }
    }
}
