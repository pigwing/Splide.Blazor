using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splide.Blazor.EventArgs
{
    public class ArrowsEventArgs : EventArgsBase
    {
        public int PrevIndex { get; set; }
        public int NextIndex { get; set; }

    }
}
