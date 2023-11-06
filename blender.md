# Blender

- [Blender](#blender)
  - [Shortcuts](#shortcuts)
    - [Move, scale, rotate, panning](#move-scale-rotate-panning)
    - [Duplicate](#duplicate)
    - [X-Ray mode](#x-ray-mode)
    - [Separating](#separating)
    - [Change view](#change-view)
    - [Add objects](#add-objects)
    - [Edit mode(\& other object modes)](#edit-mode-other-object-modes)
    - [Extruding](#extruding)
  - [Knowledge](#knowledge)
    - [Subdivision surface modifier](#subdivision-surface-modifier)
    - [Solidify modifier](#solidify-modifier)
    - [Shade smooth \& shade flat](#shade-smooth--shade-flat)
    - [Proportional editing](#proportional-editing)
    - [Shrinkwrap modifier](#shrinkwrap-modifier)
    - [Snapping](#snapping)


## Shortcuts

[Shortcut PDF from Blender Guru](Blender_3.0_Shortcuts_v1.2.pdf)

### Move, scale, rotate, panning

| Shortcut                        | Command                                   |
| ------------------------------- | ----------------------------------------- |
| **G** (with object selected)    | Move object                               |
|                                 | press x,y,z to move along axis            |
|                                 | click middle mouse button to snap to axis |
| **S** (with object selected)    | Scale object                              |
|                                 | press x,y,z to scale along axis           |
| **R** (with object selected)    | Rotate object                             |
|                                 | press x,y,z to roate along axis           |
|                                 | click middle mouse button to snap to axis |
| **Shift** + middle mouse button | Pan                                       |

> Press ```esc``` or right click to cancel the command


> These commands are also used to modify meshes, vertices and so on

### Duplicate

| Shortcut      | Command   |
| ------------- | --------- |
| **Shift** + D | duplicate |

### X-Ray mode

| Shortcut           | Command           |
| ------------------ | ----------------- |
| **Option/Alt** + Z | toggle X-Ray mode |

### Separating

| Shortcut | Command              |
| -------- | -------------------- |
| P        | open separation menu |

### Change view

| Shortcut            | Command                  |
| ------------------- | ------------------------ |
| **<** + 1           | camera                   |
| **<** + 2           | bottom                   |
| **<** + 3           | selected                 |
| **<** + 4           | left                     |
| **<** + 6           | right                    |
| **<** + 7           | front                    |
| **<** + 8           | top                      |
| **<** + 9           | back                     |
| middle mouse button | orbit                    |
|                     | hold alt to snap to axis |


### Add objects

| Shortcut      | Command       |
| ------------- | ------------- |
| **Shift** + A | open add menu |

> There is a panel to customize the added shape. If it has been closed, it can be restored by pressing **F9**

### [Edit mode(& other object modes)](https://docs.blender.org/manual/en/latest/editors/3dview/modes.html)

| Shortcut           | Command                        |
| ------------------ | ------------------------------ |
| Tab                | switch to edit mode            |
| **Control** + tab  | open mode selector             |
| O                  | switch to proportional editing |
| **option/alt** + S | shrink and fatten tool         |

### [Extruding](https://docs.blender.org/manual/en/latest/modeling/meshes/editing/mesh/extrude.html)

| Shortcut                           | Command                  |
| ---------------------------------- | ------------------------ |
| E(with vertices or faces selected) | extrude new vertice/face |

## Knowledge

### [Subdivision surface modifier](https://docs.blender.org/manual/en/latest/modeling/modifiers/generate/subdivision_surface.html)

The Subdivision Surface modifier is used to split the faces of a mesh into smaller faces, giving it a smooth appearance.

> Keep the viewport subdivision low for better editing performance. Viewport subdivision surface modifier can also be turned off in blender.

### [Solidify modifier](https://docs.blender.org/manual/en/latest/modeling/modifiers/generate/solidify.html)

The Solidify modifier takes the surface of any mesh and adds depth, thickness to it.

### [Shade smooth & shade flat](https://docs.blender.org/manual/en/latest/modeling/meshes/editing/face/shading.html)

The shading of an object can be change by **right-clicking**. When using "shade-smooth", the meshes are not rendered individually, making the object appear more smooth. When using "shade-flat", individual meshes are visible.

### [Proportional editing](https://docs.blender.org/manual/en/latest/editors/3dview/controls/proportional_editing.html)

Proportional editing is done in edit mode and can be turned on with **O**. When selecting a vertice, vertices around it are also selected. E.g. when moving a single vertice, the vertice around move in the same direction proportionally.

> Change the proportional size by **scrolling up**

### [Shrinkwrap modifier](https://docs.blender.org/manual/en/latest/modeling/modifiers/deform/shrinkwrap.html)

The Shrinkwrap modifier allows an object to “shrink” to the surface of another object. It moves each vertex of the object being modified to the closest position on the surface of the given mesh (using one of the four methods available).

> E.g. for a donut, this enables us to wrap the icing around the donut.


### [Snapping](https://docs.blender.org/manual/en/latest/editors/3dview/controls/snapping.html)

Snapping lets you easily align objects and mesh elements to others. It can be toggled by clicking the magnet icon in the 3D Viewport’s header, or more temporarily by holding ```ctrl```.

> If snapping is enabled, a vertice might not move and cause confusion, keep this in mind to check if snapping is enabled.