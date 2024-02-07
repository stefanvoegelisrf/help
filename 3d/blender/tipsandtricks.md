# Blender tips and tricks
- [Blender tips and tricks](#blender-tips-and-tricks)
  - [Setting origin to specific point](#setting-origin-to-specific-point)
  - [Assigning materials to specific faces](#assigning-materials-to-specific-faces)
  - [Randomize noise texture in material](#randomize-noise-texture-in-material)
  - [Creating generative trees](#creating-generative-trees)
  - [Setting up isometric view](#setting-up-isometric-view)


## Setting origin to specific point
- Select vertice to which the origin should be set
- In **edit mode** go to **mesh** -> **snap** -> **cursor to selected**
- Leave **edit mode** and go to **object** -> **set origin** -> **origin to 3D cursor**

> Alternatively, just set the 3D cursor and then move the origin to the 3D cursor

## Assigning materials to specific faces
- Add materials to object
- Go to **edit mode**
- Select faces to assign materials to
- Select the material to assign and then click **assign**

## Randomize noise texture in material
When using a noise texture, the material always has the same texture for each object that it is applied to. To randomize this to get variation, we can use the **random** value from the object like so:

![Randomize noise texture](images/Randomize%20noise%20texture.png)

## Creating generative trees
![Generative trees node setup](images/generative%20trees%20node%20setup.jpeg)

## Setting up isometric view
- Set camera type to orthographic
- Set z rotation to 45 degrees
- Set y rotation to 0 degrees
- Set x rotation to 54.7 degrees