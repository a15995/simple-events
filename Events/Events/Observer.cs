using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Events
{
    class Observer
    {
        public void HandleEvent(object sender, EventArgs args)
        {
            Debug.WriteLine("Something happened to " + sender);
        }
    }
}
