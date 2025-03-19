# Geometry nodes

TODO: Add setup of donut geometry nodes
TODO: Add tutorial on how to create plants with geometry nodes
TODO: Add tutorial on how to create grid

## [Node groups](https://docs.blender.org/manual/en/latest/interface/controls/nodes/groups.html)
With node groups, repetitive parts can be reused and they provide a way to achieve a cleaner setups.
Navigate into node groups by using **Tab** and exit them using **CTRL** + **Tab**.

## [Set curve radius](https://docs.blender.org/manual/en/latest/modeling/geometry_nodes/curve/write/set_curve_radius.html)
With the set curve radius node, the radius of a curve can be set. This value is then used e.g. in the curve to mesh node.

## [Resample curve node](https://docs.blender.org/manual/en/latest/modeling/geometry_nodes/curve/operations/resample_curve.html)
With the resample curve node, points on a curve will be spread according to the resample curve node. This can be either a specified amount of points or a specified length.

## [Instances](https://docs.blender.org/manual/en/latest/modeling/geometry_nodes/instances.html)
An geometry can store instances. Like that, a geometry can hold more geometry without duplicating it. An instance itself can have more geometry, objects or collections in it.

## [Realize instance node](https://docs.blender.org/manual/en/latest/modeling/geometry_nodes/instances/realize_instances.html)
The realize instance node will make instances into a real geometry. Like that, each geometry can be modified individually.

## [Instance on points node](https://docs.blender.org/manual/en/latest/modeling/geometry_nodes/instances/instance_on_points.html)
With instance on points node, instances can be placed on the position of points in a geometry.

## [Sample index node](https://docs.blender.org/manual/en/latest/modeling/geometry_nodes/geometry/sample/sample_index.html)
The Sample Index node retrieves values from a source geometry at a specific index.

## [Curve to mesh node](https://docs.blender.org/manual/en/latest/modeling/geometry_nodes/curve/operations/curve_to_mesh.html)
The curve to mesh node converts a curve to a mesh. A profile curve can be specified to serve as the shape of the mesh.

## [Bounding box node](https://docs.blender.org/manual/en/latest/modeling/geometry_nodes/geometry/operations/bounding_box.html)
The bounding box node computes the bounding box of the input geometry.

## [Noise texture node](https://docs.blender.org/manual/en/latest/render/shader_nodes/textures/noise.html)
The Noise Texture node evaluates a fractal Perlin noise at the input texture coordinates.