# Touchdesigner

- [Touchdesigner](#touchdesigner)
  - [Resources](#resources)
  - [Shortcuts](#shortcuts)
  - [Noise](#noise)
  - [Operators](#operators)
    - [Generators](#generators)
    - [Filters](#filters)
    - [Texture operators(TOP)](#texture-operatorstop)
    - [Channel operators(CHOP)](#channel-operatorschop)
    - [Surface operators(SOP)](#surface-operatorssop)
    - [Materials(MAT)](#materialsmat)
    - [Data operators(DAT)](#data-operatorsdat)
    - [Components(COMP)](#componentscomp)


## Resources

- [SimonAA - Looping Noise in TouchDesigner](https://www.simonaa.media/tutorials/looping-noise-part-1)
- [SimonAA - Noise Displacement in TouchDesigner](https://www.simonaa.media/tutorials/noisedisplacement)
- [SimonAA - Tutorials & Articles](https://www.simonaa.media/tutorials-articles)
- [Touch Designer Workshop Resources](https://github.com/kratadata/TD-Workshop)
- [TouchDesigner - Fundamentals](https://learn.derivative.ca/courses/100-fundamentals/)

## Shortcuts

| Shortcut                    | Command                   |
| --------------------------- | ------------------------- |
| **double click** or **Tab** | Open **OP Dreate Dialog** |

## Noise

[Noise](../noise) is easily generated in TouchDesigner through the native noise operators (Noise TOP, Noise CHOP and Noise SOP). For more variation beyond the noise types found in the Noise TOP check out the noise component found in the generators section of the palette.

> Examples: TouchDesigner [Generative Design Examples](https://www.derivative.ca/wiki088/index.php?title=Generative_Design) (specifically M.1. Randomness and Noise).

## [Operators](https://derivative.ca/UserGuide/Operator)

Operators are nodes in TouchDesigner networks. They output data to other operators and have parameters and flags.

### [Generators](https://derivative.ca/UserGuide/Generator)

Operators that do not need any inputs connected (to create a meaningful output) are called Generators in TouchDesigner. They are darker shaded in the OP Create Dialog.

### [Filters](https://derivative.ca/UserGuide/Filter)

Operators that need 1 or more inputs (to create a meaningful output) are called Filters in TouchDesigner. They are lighter shaded in the OP Create Dialog.

### [Texture operators(TOP)](https://docs.derivative.ca/TOP)

![Texture operators](images/OP_TOP.png)

Texture operators are used for images and pixel data. They provide real-time compositing and image manipulation. It can be used for textures, images, movies, control panel elements and more. 

### [Channel operators(CHOP)](https://docs.derivative.ca/CHOP)

![Channel operators](images/OP_CHOP.png)

Channel operators enable the processing of motion, audio, math, logic, MIDI data, numeric info and data streamed from/to devices and protocols. They operate on channels which is a sequence of numbers.

### [Surface operators(SOP)](https://docs.derivative.ca/SOP)

![Surface operators](images/OP_SOP.png)

Surface operator generate, import, modify and combine 3D surfaces(geometry).

### [Materials(MAT)](https://docs.derivative.ca/MAT)

![Materials](images/OP_MAT.png)

Materials apply a Shader to surface operators or 3D geometry.

### [Data operators(DAT)](https://docs.derivative.ca/DAT)

![Data operators](images/OP_DAT.png)

Data operators hold data(strings, scrips, XML). They can either be a table or lines of texts.

### [Components(COMP)](https://docs.derivative.ca/Component)

Components contain their own networks and are therefore reusable networks.