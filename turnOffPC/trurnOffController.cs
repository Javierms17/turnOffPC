using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnOffPC
{
    internal class trurnOffController
    {
        public void turnOffPC(int hours)
        {
            int seconds = hours*3600;
            Process.Start("shutdown", $"/s /t {seconds}");

        }
        public void cancelTurnOffPC()
        {
            Process.Start("shutdown", "-a");
        }
    }
}
