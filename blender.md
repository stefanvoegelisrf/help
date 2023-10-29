# Blender

- [Blender](#blender)
  - [Shortcuts](#shortcuts)
    - [Move, scale, rotate, panning](#move-scale-rotate-panning)
    - [Change view](#change-view)
    - [Add objects](#add-objects)
    - [Edit mode(\& other modes)](#edit-mode-other-modes)
  - [Knowledge](#knowledge)
    - [Subdivision surface modifier](#subdivision-surface-modifier)
    - [Shade smooth \& shade flat](#shade-smooth--shade-flat)
    - [Proportional editing](#proportional-editing)


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

### Edit mode(& other modes)

| Shortcut           | Command                        |
| ------------------ | ------------------------------ |
| Tab                | switch to edit mode            |
| **Control** + tab  | open mode selector             |
| O                  | switch to proportional editing |
| **option/alt** + S | shrink and fatten tool         |

## Knowledge

### [Subdivision surface modifier](https://docs.blender.org/manual/en/latest/modeling/modifiers/generate/subdivision_surface.html)

The Subdivision Surface modifier is used to split the faces of a mesh into smaller faces, giving it a smooth appearance.

> Keep the viewport subdivision low for better editing performance. Viewport subdivision surface modifier can also be turned off in blender.

### [Shade smooth & shade flat](https://docs.blender.org/manual/en/latest/modeling/meshes/editing/face/shading.html)

The shading of an object can be change by **right-clicking**. When using "shade-smooth", the meshes are not rendered individually, making the object appear more smooth. When using "shade-flat", individual meshes are visible.

### [Proportional editing](https://docs.blender.org/manual/en/latest/editors/3dview/controls/proportional_editing.html)

Proportional editing is done in edit mode and can be turned on with **O**. When selecting a vertice, vertices around it are also selected. E.g. when moving a single vertice, the vertice around move in the same direction proportionally.

> Change the proportional size by **scrolling up**