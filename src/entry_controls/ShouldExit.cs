using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_management_system.src.entry_controls
{
    public class ShouldExit
    {
        private bool shouldTerminate;
        public bool ShouldTerminate{
            get { return shouldTerminate; }
            set { shouldTerminate = value; }
        }
    }
}