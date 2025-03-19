# Blender

- [Blender](#blender)
  - [Shortcuts](#shortcuts)
  - [Areas](#areas)
  - [Modifiers](#modifiers)
  - [Knowledge](#knowledge)
    - [Shade smooth \& shade flat](#shade-smooth--shade-flat)
    - [Proportional editing](#proportional-editing)
    - [Snapping](#snapping)
    - [Rendering](#rendering)
      - [GPU rendering: Changing settigns to render on GPU](#gpu-rendering-changing-settigns-to-render-on-gpu)
      - [Viewport shading](#viewport-shading)
        - [Wireframe](#wireframe)
        - [Solid](#solid)
        - [Material preview](#material-preview)
        - [Rendered](#rendered)
      - [Eevee](#eevee)
        - [Improving Eevee rendering](#improving-eevee-rendering)
          - [Change shadow](#change-shadow)
          - [Ambient occlusion](#ambient-occlusion)
          - [Screen space reflections](#screen-space-reflections)
      - [Cycles](#cycles)
        - [Samples](#samples)
  - [Camera](#camera)
  - [Materials - Textures - UV mapping](#materials---textures---uv-mapping)
  - [Geometry nodes](#geometry-nodes)
  - [Combining colors with Mix](#combining-colors-with-mix)
  - [Double PI](#double-pi)
  - [Weight painting](#weight-painting)
  - [Adding parent](#adding-parent)
  - [Keyframes](#keyframes)
  - [Animation pane](#animation-pane)
  - [Use frame value as input for geometry nodes](#use-frame-value-as-input-for-geometry-nodes)
  - [Creating frames for nodes](#creating-frames-for-nodes)
  - [Rendering on transparent by changing film to transparent](#rendering-on-transparent-by-changing-film-to-transparent)
  - [Render pass](#render-pass)
  - [Color grading with color balance](#color-grading-with-color-balance)
  - [Persistent data](#persistent-data)
  - [Improving render by playing with noise threshold, samples](#improving-render-by-playing-with-noise-threshold-samples)
  - [Changing clamping and caustics](#changing-clamping-and-caustics)
  - [F-stop](#f-stop)
  - [Openexr](#openexr)
  - [Opening a new blender file to stitch the renders together](#opening-a-new-blender-file-to-stitch-the-renders-together)
  - [Adding back colors](#adding-back-colors)

## Shortcuts

> See: [Shortcuts](shortcuts)

## [Areas](https://docs.blender.org/manual/en/latest/interface/window_system/areas.html)

Windows inside blender are called areas.

> Place the cursor in the corner of an area to create a new area. E.g. to split the view.

## Modifiers

> See: [Modifiers](modifiers)

## Knowledge

### [Shade smooth & shade flat](https://docs.blender.org/manual/en/latest/modeling/meshes/editing/face/shading.html)

The shading of an object can be change by **right-clicking**. When using "shade-smooth", the meshes are not rendered individually, making the object appear more smooth. When using "shade-flat", individual meshes are visible.

### [Proportional editing](https://docs.blender.org/manual/en/latest/editors/3dview/controls/proportional_editing.html)

Proportional editing is done in edit mode and can be turned on with **O**. When selecting a vertice, vertices around it are also selected. E.g. when moving a single vertice, the vertice around move in the same direction proportionally.

> Change the proportional size by **scrolling up**

### [Snapping](https://docs.blender.org/manual/en/latest/editors/3dview/controls/snapping.html)

![Snapping](images/Snapping.png)

Snapping lets you easily align objects and mesh elements to others. It can be toggled by clicking the magnet icon in the 3D Viewport’s header, or more temporarily by holding `ctrl`.

> If snapping is enabled, a vertice might not move and cause confusion, keep this in mind to check if snapping is enabled.

### [Rendering]()

#### [GPU rendering](https://docs.blender.org/manual/en/latest/render/cycles/gpu_rendering.html): Changing settigns to render on GPU

Use GPU for Cycles: **Preferences** -> **System** -> Switch Cycles Render Devices to use **Metal**(on Mac).

![Change to GPU rendering on Mac](images/GPU%20rendering%20MAC.png)

In **scene settings**, change the device to **GPU compute**.

![Cycles GPU rendering](images/Cycles%20GPU%20rendering.png)

#### [Viewport shading](https://docs.blender.org/manual/en/latest/editors/3dview/display/shading.html)

![Viewport shading](images/Viewport%20shading.png)

##### Wireframe

Only displays the edges (wireframes) of the objects in the scene.

##### Solid

It shows solid geometry but uses simplified shading and lighting without the use of shader nodes. Solid mode is good for modeling and sculpting, and is really useful with the multitude of options to emphasize certain geometric features.

##### Material preview

This mode is particularly suited for previewing materials and painting textures. You can select different lighting conditions to test your materials.

> Change settings to use scene lights and scene world

##### Rendered

Render the 3D Viewport using the scene’s Render Engine, for interactive rendering. This gives you a preview of the final result, including scene lighting effects.

#### [Eevee](https://docs.blender.org/manual/en/latest/render/eevee/index.html)

Eevee is the built-in realtime render engine which focuses on speed and interactivity.

Unlike Cycles, Eevee is not a raytrace render engine. Instead of computing each ray of light, Eevee uses a process called rasterization. Therefore Cycles will provide more physically accurate renders.

##### Improving Eevee rendering

Eevee rendering can be improved by applied various techniques listed below.

###### Change shadow

> Change cube size to improve shadow resolution
>
> ![Eevee shadows](images/Eevee%20shadows.png)

> Select light -> Light settings -> Shadow -> Reduce/increase bias according to size of object
>
> ![Light shadows](images/Light%20shadow.png)

###### Ambient occlusion

Turn on ambient occlusion to improve dark parts of image and achieve more realistic result.

###### Screen space reflections

To get reflections, turn on scren space reflection.

#### [Cycles](https://docs.blender.org/manual/en/latest/render/cycles/index.html)

##### Samples

Reduce samples to increase render time based on the size of the object. To counter the effect of less samples, denoising can be activated. Denoising will slow the render duration, to make it more performant, the start sample can be changed.

TODO: adaptive sampling

## Camera

> See: [Camera](camera)

## Materials - Textures - UV mapping

> See: [Materials](materials)

## Geometry nodes

> See: [Geometry nodes](geometrynodes)


## Combining colors with Mix
https://docs.blender.org/manual/en/latest/compositing/types/color/mix/mix_color.html
TODO: Add how to achieve the different colored sprinkles using Mix Node

## Double PI

## Weight painting

TODO: explain donut weight painting for density of sprinkles

## Adding parent

TODO: Show how adding an object as a parent of an object

## Keyframes

TODO: Show how keyframing works and how to adjust the easing

## Animation pane

## Use frame value as input for geometry nodes

## Creating frames for nodes

bpy.context.scene.frame_end

## Lighting

## Changing color managemengt settings

TODO: change look to high contrast
TODO: change view transform to false color and change exposure

TODO: spot problem by rendering first/last/middle frame

## Rendering on transparent by changing film to transparent

## Compositing

ctrl shift click -> focus on node

## Render pass

## Color grading with color balance

## Persistent data

## Improving render by playing with noise threshold, samples

## Adding motion blur

## Setting max bounces for light paths

## Changing clamping and caustics

## Todo EVEE render settings for rendering

## F-stop

## Openexr

## Opening a new blender file to stitch the renders together

## Adding back colors