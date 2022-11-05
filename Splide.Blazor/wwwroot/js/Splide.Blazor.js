import '/_content/Splide.Blazor/js/splide.min.js';

var Splides = {};

export function init(id, options, ref, eventsBinding) {
    let el = document.getElementById(id);

    let splide;
    if (options !== null && options !== undefined) {
        splide = new Splide('#' + id, options);
    } else {
        splide = new Splide('#' + id);
    }
    Splides[id] = splide;
    if (eventsBinding.mounted) {
        splide.on('mounted', function () {
            ref.invokeMethodAsync('Splide.Mounted');
        });
    }

    if (eventsBinding.ready) {
        splide.on('ready', function () {
            ref.invokeMethodAsync('Splide.Ready');
        });
    }

    if (eventsBinding.click) {
        splide.on('click', function (slide, e) {
            ref.invokeMethodAsync('Splide.Click', slide.index, slide.slideIndex, slide.isClone);
        });
    }

    if (eventsBinding.move) {
        splide.on('move', function (newIndex, prevIndex, destIndex) {
            ref.invokeMethodAsync('Splide.Move', newIndex, prevIndex, destIndex);
        });
    }

    if (eventsBinding.moved) {
        splide.on('moved', function (newIndex, prevIndex, destIndex) {
            ref.invokeMethodAsync('Splide.Moved', newIndex, prevIndex, destIndex);
        });
    }

    if (eventsBinding.active) {
        splide.on('active', function (newIndex, prevIndex, destIndex) {
            ref.invokeMethodAsync('Splide.Active', newIndex, prevIndex, destIndex);
        });
    }

    if (eventsBinding.inActive) {
        splide.on('inactive', function (newIndex, prevIndex, destIndex) {
            ref.invokeMethodAsync('Splide.InActive', newIndex, prevIndex, destIndex);
        });
    }

    if (eventsBinding.visible) {
        splide.on('visible', function (newIndex, prevIndex, destIndex) {
            ref.invokeMethodAsync('Splide.Visible', newIndex, prevIndex, destIndex);
        });
    }

    if (eventsBinding.hidden) {
        splide.on('hidden', function (newIndex, prevIndex, destIndex) {
            ref.invokeMethodAsync('Splide.Hidden', newIndex, prevIndex, destIndex);
        });
    }

    if (eventsBinding.refresh) {
        splide.on('refresh', function () {
            ref.invokeMethodAsync('Splide.Refresh');
        });
    }

    if (eventsBinding.refresh) {
        splide.on('refresh', function () {
            ref.invokeMethodAsync('Splide.Updated');
        });
    }

    if (eventsBinding.resize) {
        splide.on('resize', function () {
            ref.invokeMethodAsync('Splide.Resize');
        });
    }

    if (eventsBinding.resized) {
        splide.on('resized', function () {
            ref.invokeMethodAsync('Splide.Resized');
        });
    }

    if (eventsBinding.drag) {
        splide.on('drag', function () {
            ref.invokeMethodAsync('Splide.Drag');
        });
    }

    if (eventsBinding.dragging) {
        splide.on('dragging', function () {
            ref.invokeMethodAsync('Splide.Dragging');
        });
    }

    if (eventsBinding.dragged) {
        splide.on('dragged', function () {
            ref.invokeMethodAsync('Splide.Dragged');
        });
    }

    if (eventsBinding.scroll) {
        splide.on('scroll', function () {
            ref.invokeMethodAsync('Splide.Scroll');
        });
    }

    if (eventsBinding.scrolled) {
        splide.on('scrolled', function () {
            ref.invokeMethodAsync('Splide.Scrolled');
        });
    }

    if (eventsBinding.overflow) {
        splide.on('overflow', function () {
            ref.invokeMethodAsync('Splide.Overflow');
        });
    }

    if (eventsBinding.destroy) {
        splide.on('destroy', function () {
            ref.invokeMethodAsync('Splide.Destroy');
        });
    }

    if (eventsBinding.arrows) {
        splide.on('arrows:mounted', function (prev, next) {
            ref.invokeMethodAsync('Splide.Arrows');
        });
    }

    if (options == null || options == undefined || options.autoMount) {
        splide.mount();
    }
}

export function sync(primaryId, secondaryId) {
    let primarySplide = Splides[primaryId];
    let secondarySplide = Splides[secondaryId];

    primarySplide.sync(secondarySplide);
    primarySplide.mount();
    secondarySplide.mount();
}