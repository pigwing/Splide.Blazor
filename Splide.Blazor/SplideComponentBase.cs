using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Splide.Blazor
{
    public class SplideComponentBase : ComponentBaseWithChildren, IAsyncDisposable
    {

        public ElementReference Element { get; internal set; }

        protected IJSObjectReference? module;

        protected override void OnInitialized()
        {
            UniqueId = $"Q{Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace("/", "-").Replace("+", "-").Substring(0, 10)}";
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
            if (firstRender)
            {
                module = await JsRuntime.InvokeAsync<IJSObjectReference>("import",
                    "./_content/Splide.Blazor/js/Splide.Blazor.js");
            }
        }

        private DotNetObjectReference<SplideComponentBase>? _reference;

        /// <summary>
        /// Gets the reference for the current component.
        /// </summary>
        /// <value>The reference.</value>
        protected DotNetObjectReference<SplideComponentBase> Reference
        {
            get
            {
                if (_reference == null)
                {
                    _reference = DotNetObjectReference.Create(this);
                }

                return _reference;
            }
        }

        public ValueTask DisposeAsync()
        {
            _reference?.Dispose();
            _reference = null;
            module = null;
            return ValueTask.CompletedTask;
        }
    }
}
