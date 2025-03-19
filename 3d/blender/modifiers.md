# Modifiers

Modifiers are automatic operations that affect an object’s geometry in a non-destructive way.

> Official documentation: [blender.org - Modifiers](https://docs.blender.org/manual/en/latest/modeling/modifiers/index.html)

- [Modifiers](#modifiers)
  - [Subdivision surface modifier](#subdivision-surface-modifier)
  - [Solidify modifier](#solidify-modifier)
  - [Shrinkwrap modifier](#shrinkwrap-modifier)


## Subdivision surface modifier

![Subdivision surface modifier](images/subdivision%20surface%20modifier.png)

The Subdivision Surface modifier is used to split the faces of a mesh into smaller faces, giving it a smooth appearance.

> Keep the viewport subdivision low for better editing performance. Viewport subdivision surface modifier can also be turned off in blender.

> Official documentation: [blender.org - Subdivision surface modifier](https://docs.blender.org/manual/en/latest/modeling/modifiers/generate/subdivision_surface.html)

## Solidify modifier

The Solidify modifier takes the surface of any mesh and adds depth, thickness to it.

> Official documentation: [blender.org - Solidify modifier](https://docs.blender.org/manual/en/latest/modeling/modifiers/generate/solidify.html)


## Shrinkwrap modifier

The Shrinkwrap modifier allows an object to “shrink” to the surface of another object. It moves each vertex of the object being modified to the closest position on the surface of the given mesh (using one of the four methods available).

> E.g. for a donut, this enables us to wrap the icing around the donut.

> Official documentation: [blender.org - Shrinkwrap modifier](https://docs.blender.org/manual/en/latest/modeling/modifiers/deform/shrinkwrap.html)