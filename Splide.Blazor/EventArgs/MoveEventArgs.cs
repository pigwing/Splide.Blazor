using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splide.Blazor.EventArgs
{
    public class MoveEventArgs : EventArgsBase
    {
        public int NewIndex { get; set; }
        public int PrevIndex { get; set; }
        public int DestIndex { get; set; }
    }
}
