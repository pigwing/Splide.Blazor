using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splide.Blazor
{
    public abstract class Base : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, object>? Attributes { get; set; }
        [Parameter]
        public virtual string? Style { get; set; }
        [Inject]
        [NotNull]
        protected IJSRuntime? JsRuntime { get; set; }
    }
}
