﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Splide.Blazor
{
    public partial class SplideSlide
    {
        protected override string GetComponentCssClass()
        {
            return "splide__slide";
        }
    }
}
