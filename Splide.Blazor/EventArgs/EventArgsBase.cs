using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Splide.Blazor.EventArgs
{
    public abstract class EventArgsBase
    {
        public ElementReference Element{ get; set; }
    }
}
