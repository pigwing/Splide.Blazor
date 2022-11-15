using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Splide.Blazor
{
    public class ComponentBaseWithChildren : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, object>? Attributes { get; set; }
        [Parameter]
        public virtual string? Style { get; set; }
        [Inject]
        [NotNull]
        protected IJSRuntime? JsRuntime { get; set; }

        public string? UniqueId { get; set; }

        protected string GetCssClass()
        {
            if (Attributes != null && Attributes.TryGetValue("class", out var @class) && !string.IsNullOrEmpty(Convert.ToString(@class)))
            {
                string classes = $"{GetComponentCssClass()} {@class}";
                return classes;
            }

            return GetComponentCssClass();
        }

        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        protected virtual string GetComponentCssClass()
        {
            return "";
        }
        protected string? GetId()
        {
            if (Attributes != null && Attributes.TryGetValue("id", out var id) && !string.IsNullOrEmpty(Convert.ToString(@id)))
            {
                return $"{@id}";
            }

            return UniqueId;
        }
    }
}
