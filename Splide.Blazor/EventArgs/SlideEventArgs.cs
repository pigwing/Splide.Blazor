using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Splide.Blazor.EventArgs
{
    public class SlideEventArgs : EventArgsBase
    {
        public int Index { get; set; }
        public int SlideIndex { get; set; }
        public bool IsClone { get; set; }
    }
}
