using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Splide.Blazor
{
    public class Options
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? AutoMount { get; set; } = true;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; } //= "slide";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Role { get; set; } //= "region";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Label { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Rewind { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Speed { get; set; } //= 400;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? RewindSpeed { get; set; } //= 400;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? RewindByDrag { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Width { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Height { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? FixedWidth { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? FixedHeight { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? HeightRatio { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? AutoWidth { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? AutoHeight { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Start { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? PerPage { get; set; } //= 1;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? PerMove { get; set; } //= 1;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Clones { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? CloneStatus { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Focus { get; set; } //= "center";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Gap { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Padding { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Arrows { get; set; } //= true;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Pagination { get; set; } //= true;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? PaginationKeyboard { get; set; } //= true;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PaginationDirection { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Easing { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object? Drag { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Snap { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? NoDrag { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object? DragMinThreshold { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? FlickPower { get; set; } //= 600;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? FlickMaxPages { get; set; } //= 1;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? WaitForTransition { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ArrowPath { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Autoplay { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Interval { get; set; } //= 5000;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? PauseOnHover { get; set; } //= true;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? PauseOnFocus { get; set; } //= true;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ResetProgress { get; set; } //= true;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object? LazyLoad { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? PreloadPages { get; set; } //= 1;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object? Keyboard { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Wheel { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? WheelMinThreshold { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? WheelSleep { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ReleaseWheel { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Direction { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Cover { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? SlideFocus { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? FocusableNodes { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsNavigation { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object? TrimSpace { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? OmitEnd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? UpdateOnMove { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object? Destroy { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? MediaQuery { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Live { get; set; } //= true;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Breakpoints { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ReducedMotionOption? ReducedMotion { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ClassesOption? Classes { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public I18nOption? I18n { get; set; }
    }

    public class ReducedMotionOption
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Speed { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? RewindSpeed { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Autoplay { get; set; } //= "pause";
    }

    public class ClassesOption
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Arrows { get; set; } //= "splide__arrows";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Arrow { get; set; } //= "splide__arrow";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Prev { get; set; } //= "splide__arrow--prev";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Next { get; set; } //= "splide__arrow--next";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Pagination { get; set; } //= "splide__pagination";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Page { get; set; } //= "splide__pagination__page";
    }

    public class I18nOption
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Prev { get; set; } //= "Previous slide";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Next { get; set; } //= "Next slide";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? First { get; set; } //= "Go to first slide";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Last { get; set; } //= "Go to last slide";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SlideX { get; set; } //= "Go to slide %s";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PageX { get; set; } //= "Go to page %s";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Play { get; set; } //= "Start autoplay";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Pause { get; set; } //= "Pause autoplay";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Carousel { get; set; } //= "carousel";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Select { get; set; } //= "Select a slide to show";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Slide { get; set; } //= "slide";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SlideLabel { get; set; } //= "%s of %s";
    }
}
