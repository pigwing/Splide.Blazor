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
        public bool AutoMount { get; set; } = true;
        public string Type { get; set; } = "slide";
        public string Role { get; set; } = "region";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Label { get; set; }
        public bool Rewind { get; set; }
        public int Speed { get; set; } = 400;
        public int RewindSpeed { get; set; } = 400;
        public bool RewindByDrag { get; set; }
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
        public bool AutoWidth { get; set; }
        public bool AutoHeight { get; set; }
        public int Start { get; set; }
        public int PerPage { get; set; } = 1;
        public int PerMove { get; set; } = 1;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Clones { get; set; }
        public bool CloneStatus { get; set; }
        public string Focus { get; set; } = "center";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Gap { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Padding { get; set; }

        public bool Arrows { get; set; } = true;
        public bool Pagination { get; set; } = true;
        public bool PaginationKeyboard { get; set; } = true;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PaginationDirection { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Easing { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object? Drag { get; set; }
        public bool Snap { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? NoDrag { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object? DragMinThreshold { get; set; }

        public int FlickPower { get; set; } = 600;
        public int FlickMaxPages { get; set; } = 1;
        public bool WaitForTransition { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ArrowPath { get; set; }
        public bool Autoplay { get; set; }
        public int Interval { get; set; } = 5000;
        public bool PauseOnHover { get; set; } = true;
        public bool PauseOnFocus { get; set; } = true;
        public bool ResetProgress { get; set; } = true;
        public object? LazyLoad { get; set; }
        public int PreloadPages { get; set; } = 1;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object? Keyboard { get; set; }
        public bool Wheel { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? WheelMinThreshold { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? WheelSleep { get; set; }
        public bool ReleaseWheel { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Direction { get; set; }
        public bool Cover { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? SlideFocus { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? FocusableNodes { get; set; }
        public bool IsNavigation { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object? TrimSpace { get; set; }
        public bool OmitEnd { get; set; }
        public bool UpdateOnMove { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object? Destroy { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? MediaQuery { get; set; }

        public bool Live { get; set; } = true;
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
        public int Speed { get; set; }
        public int RewindSpeed { get; set; }
        public string Autoplay { get; set; } = "pause";
    }

    public class ClassesOption
    {
        public string Arrows { get; set; } = "splide__arrows";
        public string Arrow { get; set; } = "splide__arrow";
        public string Prev { get; set; } = "splide__arrow--prev";
        public string Next { get; set; } = "splide__arrow--next";
        public string Pagination { get; set; } = "splide__pagination";
        public string Page { get; set; } = "splide__pagination__page";
    }

    public class I18nOption
    {
        public string Prev { get; set; } = "Previous slide";
        public string Next { get; set; } = "Next slide";
        public string First { get; set; } = "Go to first slide";
        public string Last { get; set; } = "Go to last slide";
        public string SlideX { get; set; } = "Go to slide %s";
        public string PageX { get; set; } = "Go to page %s";
        public string Play { get; set; } = "Start autoplay";
        public string Pause { get; set; } = "Pause autoplay";
        public string Carousel { get; set; } = "carousel";
        public string Select { get; set; } = "Select a slide to show";
        public string Slide { get; set; } = "slide";
        public string SlideLabel { get; set; } = "%s of %s";
    }
}
