# p5.js

- [p5.js](#p5js)
  - [Resources](#resources)
  - [About p5.js](#about-p5js)
  - [Important p5.js reference](#important-p5js-reference)
    - [map](#map)
  - [Common use cases](#common-use-cases)
    - [Use p5 canvas as site background](#use-p5-canvas-as-site-background)
    - [How to use p5.js with Nuxt/Vue](#how-to-use-p5js-with-nuxtvue)
      - [Example Nuxt page](#example-nuxt-page)

## Resources

- [Processing - Tutorials](https://processing.org/tutorials/)
- [The Coding Train](https://thecodingtrain.com/)
- [Fun programming](https://funprogramming.org/)
- [Processing](https://www.plethora-project.com/education/2017/5/31/processing-java-programming)

## About p5.js

p5.js is a creative coding library for JavaScript. p5.js originates from the [Processing](https://processing.org/) Java library.

## Important p5.js reference

Below is documentation on important p5.js functionality, with references to the official documentation.

### map

> See: [p5js - map](https://p5js.org/reference/#/p5/map)

To convert a value from a a specified source range into a value at the same position of a destination range, we can use `map`.

```
map(
    value,
    sourceRangeStart,
    sourceRangeEnd,
    destinationRangeStart,
    destinationRangeEnd
)
```

## Common use cases

Below are some use cases that I use often.

### Use p5 canvas as site background

> See: [YouTube - The Coding Train - Sketch as background](https://www.youtube.com/watch?v=OIfEHD3KqCg&ab_channel=TheCodingTrain)

To use a sketch as a background, make sure to set it's **position** to absolute and set the **z-index** to a value below all other elements(e.g. -1).

### How to use p5.js with Nuxt/Vue

> See: [Medium - Mitsuya Watanabe - p5.js with Vue](https://medium.com/js-dojo/experiment-with-p5-js-on-vue-7ebc05030d33)

1. Install p5 `npm install --save p5`
2. p5.js is ready to be used. Make sure to use it with instance mode, instead of global mode, see: [GitHub - p5.js global and instance mode](https://github.com/processing/p5.js/wiki/Global-and-instance-mode)

#### Example Nuxt page

This example uses Typescript and [script setup](https://vuejs.org/api/sfc-script-setup.html) with the Vue [composition API](https://vuejs.org/guide/extras/composition-api-faq.html).

```vue
<template>
  <div ref="canvasRef"></div>
</template>
<script setup lang="ts" >
import p5 from "p5";
import { ref, onMounted, onBeforeUnmount } from 'vue';
let p5Instance: p5 | undefined = undefined;
const canvasRef = ref(null);
onMounted(() => {
  p5Instance = new p5((sketch: p5) => {
    sketch.setup = () => {
      sketch.createCanvas(sketch.windowWidth, sketch.windowHeight);

    };
    sketch.draw = () => {
      
    };
    sketch.windowResized = () => {
      sketch.resizeCanvas(sketch.windowWidth, sketch.windowHeight);
    };
  }, canvasRef.value);
});

onBeforeUnmount(() => {
  if (p5Instance) {
    p5Instance.remove();
  }
});
</script>
```