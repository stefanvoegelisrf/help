# Geometry nodes

TODO: Add setup of donut geometry nodes
TODO: Add tutorial on how to create plants with geometry nodes
TODO: Add tutorial on how to create grid

## Node groups
With node groups, repetitive parts can be reused and they provide a way to achieve a cleaner setups.
Navigate into node groups by using **Tab** and exit them using **CTRL** + **Tab**.

> Official documentation: [blender.org - Node groups](https://docs.blender.org/manual/en/latest/interface/controls/nodes/groups.html)

## Set curve radius
With the set curve radius node, the radius of a curve can be set. This value is then used e.g. in the curve to mesh node.

> Official documentation: [blender.org - Set curve radius](https://docs.blender.org/manual/en/latest/modeling/geometry_nodes/curve/write/set_curve_radius.html)

## Resample curve
With the resample curve node, points on a curve will be spread according to the resample curve node. This can be either a specified amount of points or a specified length.

> Official documentation: [blender.org - Resample curve node](https://docs.blender.org/manual/en/latest/modeling/geometry_nodes/curve/operations/resample_curve.html)

## Instances
An geometry can store instances. Like that, a geometry can hold more geometry without duplicating it. An instance itself can have more geometry, objects or collections in it.

> Official documentation: [blender.org - Instances](https://docs.blender.org/manual/en/latest/modeling/geometry_nodes/instances.html)

## Realize instance
The realize instance node will make instances into a real geometry. Like that, each geometry can be modified individually.

> Official documentation: [blender.org - Realize instance node](https://docs.blender.org/manual/en/latest/modeling/geometry_nodes/instances/realize_instances.html)

## Instance on points
With instance on points node, instances can be placed on the position of points in a geometry.

> Official documentation: [blender.org - Instance on points node](https://docs.blender.org/manual/en/latest/modeling/geometry_nodes/instances/instance_on_points.html)

## Sample index
The Sample Index node retrieves values from a source geometry at a specific index.

> Official documentation: [blender.org - Sample index node](https://docs.blender.org/manual/en/latest/modeling/geometry_nodes/geometry/sample/sample_index.html)

## Curve to mesh
The curve to mesh node converts a curve to a mesh. A profile curve can be specified to serve as the shape of the mesh.

> Official documentation: [blender.org - Curve to mesh node](https://docs.blender.org/manual/en/latest/modeling/geometry_nodes/curve/operations/curve_to_mesh.html)

## Bounding box
The bounding box node computes the bounding box of the input geometry.

> Official documentation: [blender.org - Bounding box node](https://docs.blender.org/manual/en/latest/modeling/geometry_nodes/geometry/operations/bounding_box.html)

## Noise texture
The Noise Texture node evaluates a fractal Perlin noise at the input texture coordinates.

> Official documentation: [blender.org - Noise texture node](https://docs.blender.org/manual/en/latest/render/shader_nodes/textures/noise.html)