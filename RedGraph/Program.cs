using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedGraph
{
    public static class Program
    {
        [STAThread]
        public static int Main()
        {
            UserInterface.Start();

            return 0;
        }
    }
}