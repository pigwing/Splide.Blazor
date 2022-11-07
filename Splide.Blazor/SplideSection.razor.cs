using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Splide.Blazor.EventArgs;

namespace Splide.Blazor
{
    public partial class SplideSection
    {
        private const string ConsoleLogMethod = "console.log";
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Parameter]
        public Options? Options { get; set; }

        [Parameter]
        public EventCallback<ElementReference> Mounted { get; set; }


        private readonly List<Func<IJSObjectReference, ValueTask>> _funcs = new List<Func<IJSObjectReference, ValueTask>>();

        #region Events



        public async Task OnMounted()
        {
            await Mounted.InvokeAsync(Element);
        }

        [JSInvokable("Splide.Mounted")]
        public async Task RaiseMounted()
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger mounted event");
            if (Mounted.HasDelegate)
            {
                await OnMounted();
            }
        }

        [Parameter]
        public EventCallback<ElementReference> Ready { get; set; }

        public async Task OnReady()
        {
            await Ready.InvokeAsync(Element);
        }

        [JSInvokable("Splide.Ready")]
        public async Task RaiseReady()
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger ready event");
            if (Ready.HasDelegate)
            {
                await OnReady();
            }
        }

        [Parameter]
        public EventCallback<SlideEventArgs> Click { get; set; }

        public async Task OnClick(SlideEventArgs slideEventArgs)
        {
            await Click.InvokeAsync(slideEventArgs);
        }

        [JSInvokable("Splide.Click")]
        public async Task RaiseClick(int index, int slideIndex, bool isClone)
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger click event");
            if (Click.HasDelegate)
            {
                await OnClick(new SlideEventArgs(){Element = Element, Index = index, SlideIndex = slideIndex, IsClone = isClone});
            }
        }

        [Parameter]
        public EventCallback<MoveEventArgs> Move { get; set; }

        public async Task OnMove(MoveEventArgs moveEventArgs)
        {
            await Move.InvokeAsync(moveEventArgs);
        }

        [JSInvokable("Splide.Move")]
        public async Task RaiseMove(int newIndex, int prevIndex, int destIndex)
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger move event");
            if (Move.HasDelegate)
            {
                await OnMove(new MoveEventArgs(){Element = Element, NewIndex = newIndex, PrevIndex = prevIndex, DestIndex = destIndex });
            }
        }

        [Parameter]
        public EventCallback<MoveEventArgs> Moved { get; set; }

        public async Task OnMoved(MoveEventArgs moveEventArgs)
        {
            await Moved.InvokeAsync(moveEventArgs);
        }

        [JSInvokable("Splide.Moved")]
        public async Task RaiseMoved(int newIndex, int prevIndex, int destIndex)
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger moved event");
            if (Moved.HasDelegate)
            {
                await OnMoved(new MoveEventArgs() { Element = Element, NewIndex = newIndex, PrevIndex = prevIndex, DestIndex = destIndex });
            }
        }

        [Parameter]
        public EventCallback<SlideEventArgs> Active { get; set; }

        public async Task OnActive(SlideEventArgs slideEventArgs)
        {
            await Active.InvokeAsync(slideEventArgs);
        }

        [JSInvokable("Splide.Active")]
        public async Task RaiseActive(int index, int slideIndex, bool isClone)
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger active event");
            if (Active.HasDelegate)
            {
                await OnActive(new SlideEventArgs() { Element = Element, Index = index, SlideIndex = slideIndex, IsClone = isClone });
            }
        }

        [Parameter]
        public EventCallback<SlideEventArgs> InActive { get; set; }

        public async Task OnInActive(SlideEventArgs slideEventArgs)
        {
            await InActive.InvokeAsync(slideEventArgs);
        }

        [JSInvokable("Splide.InActive")]
        public async Task RaiseInActive(int index, int slideIndex, bool isClone)
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger inactive event");
            if (InActive.HasDelegate)
            {
                await OnInActive(new SlideEventArgs() { Element = Element, Index = index, SlideIndex = slideIndex, IsClone = isClone });
            }
        }

        [Parameter]
        public EventCallback<SlideEventArgs> Visible { get; set; }

        public async Task OnVisible(SlideEventArgs slideEventArgs)
        {
            await Visible.InvokeAsync(slideEventArgs);
        }

        [JSInvokable("Splide.Visible")]
        public async Task RaiseVisible(int index, int slideIndex, bool isClone)
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger visible event");
            if (Visible.HasDelegate)
            {
                await OnVisible(new SlideEventArgs() { Element = Element, Index = index, SlideIndex = slideIndex, IsClone = isClone });
            }
        }

        [Parameter]
        public EventCallback<SlideEventArgs> Hidden { get; set; }

        public async Task OnHidden(SlideEventArgs slideEventArgs)
        {
            await Hidden.InvokeAsync(slideEventArgs);
        }

        [JSInvokable("Splide.Hidden")]
        public async Task RaiseHidden(int index, int slideIndex, bool isClone)
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger hidden event");
            if (Hidden.HasDelegate)
            {
                await OnHidden(new SlideEventArgs() { Element = Element, Index = index, SlideIndex = slideIndex, IsClone = isClone });
            }
        }

        [Parameter]
        public EventCallback<ElementReference> Refresh { get; set; }

        public async Task OnRefresh()
        {
            await Refresh.InvokeAsync(Element);
        }

        [JSInvokable("Splide.Refresh")]
        public async Task RaiseRefresh()
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger refresh event");
            if (Refresh.HasDelegate)
            {
                await OnRefresh();
            }
        }

        [Parameter]
        public EventCallback<ElementReference> Updated { get; set; }

        public async Task OnUpdated()
        {
            await Updated.InvokeAsync(Element);
        }

        [JSInvokable("Splide.Updated")]
        public async Task RaiseUpdated()
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger updated event");
            if (Updated.HasDelegate)
            {
                await OnUpdated();
            }
        }

        [Parameter]
        public EventCallback<ElementReference> Resize { get; set; }

        public async Task OnResize()
        {
            await Resize.InvokeAsync(Element);
        }

        [JSInvokable("Splide.Resize")]
        public async Task RaiseResize()
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger resize event");
            if (Resize.HasDelegate)
            {
                await OnResize();
            }
        }

        [Parameter]
        public EventCallback<ElementReference> Resized { get; set; }

        public async Task OnResized()
        {
            await Resized.InvokeAsync(Element);
        }

        [JSInvokable("Splide.Resized")]
        public async Task RaiseResized()
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger resized event");
            if (Resized.HasDelegate)
            {
                await OnResized();
            }
        }

        [Parameter]
        public EventCallback<ElementReference> Drag { get; set; }

        public async Task OnDrag()
        {
            await Drag.InvokeAsync(Element);
        }

        [JSInvokable("Splide.Drag")]
        public async Task RaiseDrag()
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger drag event");
            if (Drag.HasDelegate)
            {
                await OnDrag();
            }
        }

        [Parameter]
        public EventCallback<ElementReference> Dragging { get; set; }

        public async Task OnDragging()
        {
            await Dragging.InvokeAsync(Element);
        }

        [JSInvokable("Splide.Dragging")]
        public async Task RaiseDragging()
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger dragging event");
            if (Dragging.HasDelegate)
            {
                await OnDragging();
            }
        }

        [Parameter]
        public EventCallback<ElementReference> Dragged { get; set; }

        public async Task OnDragged()
        {
            await Dragged.InvokeAsync(Element);
        }

        [JSInvokable("Splide.Dragged")]
        public async Task RaiseDragged()
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger dragged event");
            if (Dragged.HasDelegate)
            {
                await OnDragged();
            }
        }

        [Parameter]
        public EventCallback<ElementReference> Scroll { get; set; }

        public async Task OnScroll()
        {
            await Scroll.InvokeAsync(Element);
        }

        [JSInvokable("Splide.Scroll")]
        public async Task RaiseScroll()
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger scroll event");
            if (Scroll.HasDelegate)
            {
                await OnScroll();
            }
        }

        [Parameter]
        public EventCallback<ElementReference> Scrolled { get; set; }

        public async Task OnScrolled()
        {
            await Scrolled.InvokeAsync(Element);
        }

        [JSInvokable("Splide.Scrolled")]
        public async Task RaiseScrolled()
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger scrolled event");
            if (Scrolled.HasDelegate)
            {
                await OnScrolled();
            }
        }

        [Parameter]
        public EventCallback<ElementReference> Overflow { get; set; }

        public async Task OnOverflow()
        {
            await Overflow.InvokeAsync(Element);
        }

        [JSInvokable("Splide.Overflow")]
        public async Task RaiseOverflow()
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger overflow event");
            if (Overflow.HasDelegate)
            {
                await OnOverflow();
            }
        }

        [Parameter]
        public EventCallback<ElementReference> Destroy { get; set; }

        public async Task OnDestroy()
        {
            await Destroy.InvokeAsync(Element);
        }

        [JSInvokable("Splide.Destroy")]
        public async Task RaiseDestroy()
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger destroy event");
            if (Destroy.HasDelegate)
            {
                await OnDestroy();
            }
        }

        [Parameter]
        public EventCallback<ElementReference> Arrows { get; set; }

        public async Task OnArrows()
        {
            await Arrows.InvokeAsync(Element);
        }

        [JSInvokable("Splide.Arrows")]
        public async Task RaiseArrows()
        {
            await JsRuntime.InvokeVoidAsync(ConsoleLogMethod, "trigger arrows:mounted event");
            if (Arrows.HasDelegate)
            {
                await OnArrows();
            }
        }

        #endregion


        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
            if (firstRender)
            {
                await module!.InvokeVoidAsync("init", GetId(), Options, Reference, GetEventsBinding());
                foreach(Func<IJSObjectReference, ValueTask> func in _funcs)
                {
                    await func(module!);
                }
            }
        }

        #region method

        public async ValueTask Sync(SplideSection splideSection)
        {
            ValueTask Func(IJSObjectReference jsModule) =>
                jsModule.InvokeVoidAsync("sync", GetId(), splideSection.GetId());
            if (module != null)
            {
                await Func(module);
            }
            else
            {
                _funcs.Add(Func);
            }

            await ValueTask.CompletedTask;
        }

        public async ValueTask Go(string pageCondition)
        {
            if (module != null)
            {
                if (int.TryParse(pageCondition, out int pageNumber))
                {
                    await module.InvokeVoidAsync("go", GetId(), pageNumber);
                }
                else
                {
                    await module.InvokeVoidAsync("go", GetId(), pageCondition);
                }
            }
        }

        public async ValueTask Mount()
        {
            if (module != null)
            {
                await module.InvokeVoidAsync("mount", GetId());
            }
        }

        #endregion

        private Dictionary<string, bool> GetEventsBinding()
        {
            Dictionary<string, bool> dic = new Dictionary<string, bool>();
            Type current = GetType();
            PropertyInfo[] propertyInfos = current.GetProperties();
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                if (propertyInfo.PropertyType == typeof(EventCallback<ElementReference>) ||
                    propertyInfo.PropertyType == typeof(EventCallback<MoveEventArgs>) ||
                    propertyInfo.PropertyType == typeof(EventCallback<SlideEventArgs>) ||
                    propertyInfo.PropertyType == typeof(EventCallback<ArrowsEventArgs>))
                {
                    string propertyName = propertyInfo.Name.ToLower();
                    if (propertyName.Equals("move") || propertyName.Equals("moved"))
                    {
                        EventCallback<MoveEventArgs> e = (EventCallback<MoveEventArgs>)propertyInfo.GetValue(this)!;
                        dic.Add(propertyName, e.HasDelegate);
                    }
                    else if (propertyName.Equals("click") || propertyName.Equals("active") ||
                             propertyName.Equals("inactive") || propertyName.Equals("visible") ||
                             propertyName.Equals("hidden"))
                    {
                        EventCallback<SlideEventArgs> e = (EventCallback<SlideEventArgs>) propertyInfo.GetValue(this)!;
                        dic.Add(propertyName, e.HasDelegate);
                    }
                    else if (propertyName.Equals("arrowsupdated"))
                    {
                        EventCallback<ArrowsEventArgs> e = (EventCallback<ArrowsEventArgs>)propertyInfo.GetValue(this)!;
                        dic.Add(propertyName, e.HasDelegate);
                    }
                    else
                    {
                        EventCallback<ElementReference> e = (EventCallback<ElementReference>)propertyInfo.GetValue(this)!;
                        dic.Add(propertyName, e.HasDelegate);
                    }
                    
                }

            }

            return dic;
        }
    }
}
