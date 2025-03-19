# Materials

To create a basic material, change the color and adjust the roughness.

## Light scattering

To add scattering, add subsurface and and change subsurface radius and color.

## Shading and texturing

> Official documentation: [blender.org - Textures](https://docs.blender.org/manual/en/latest/render/shader_nodes/textures/index.html)

Texturing adds texture to objects. Texturing is achieved with shaders. The most common shader is the [Principled BSDF](https://docs.blender.org/manual/en/latest/render/shader_nodes/shader/principled.html) shader. The Principled BSDF that combines multiple layers into a single easy to use node. It is based on the Disney principled model also known as the “PBR”(See: [Physically based rendering](../pbr/physicallybasedrendering)).

![Principled BSDF Shader](images/Principled%20BSDF.png)

### Noise texture

> Use a **noise texture** combined with a **color ramp** to create color variation. This can further be combined with a **bump** so that the bump can be connected to the **normal of the Shader**(E.g. Principaled BSDF) Add **texture coordinate** to **Vector input** of noise texture to change the mapping.

![Noise with Bump as normal map](images/Noise%20with%20Bump%20as%20normal.png)

### [Bump node](https://docs.blender.org/manual/en/latest/render/shader_nodes/vector/bump.html)
The Bump node generates a perturbed normal from a height texture, for bump mapping. The height value will be sampled at the shading point and two nearby points on the surface to determine the local direction of the normal.y

### [Texture coordinate](https://docs.blender.org/manual/en/latest/render/shader_nodes/input/texture_coordinate.html)

Texture coordinates can be used in several ways and help with mapping procedural textures on objects.

#### Creating a basic wave pattern

1. Go to shading workspace
2. Add [texture coordinate](#texture-coordinate)
3. Create a **Separate XYZ** node and connect the **UV** from **Texture coordinate** to **Vector** of Separate XYZ.
   - This allows us to access the coordinates from **Texure coordinate** separately. E.g. the coordinate X
   - See: [UV Mapping](#uv-mapping)
4. The **X coordinate** then can be used as **Vector** input for a **Math converter** of type **Sine** to create a wave, based on the X coordinate.
5. To get greater or less variation, add another **Math converter** of type **Multiply** to multiply the X coordinate by a factor. This node has to be between **Separate XYZ** and **Sine**
6. **Sine** will give us a value between -1 and 1 which will result in all values below 0 to be treated as 0 when converting the **Sine** output value to color.
   1. Therefore, we need to map the output value from **Sine** from the range(-1 to 1) to the range (0,1) whch can be achiever with the **Map Range converter**.
7. Connect the output of the **Map Range converter** to the **Base color** of the shader which will give us the wave pattern.

![Wave pattern with nodes](images/wave%20pattern%20with%20nodes.png)

#### Creating generated coordinates
Using generated coordinates allows use automatically-generated texture coordinates from the vertex positions of the mesh without deformation, keeping them sticking to the surface under animation. The coordinates range from 0.0 to 1.0 over the bounding box of the undeformed mesh.

1. Go to shading workspace and add [texture coordinate](#texture-coordinate)
2. Use the **generated** value to use the generated texture coordinates


### Image texture

Create a new **image texture** in the node editor. The texture then can be edit in the **texture paint workspace**.
The settings of texture drawing, open the **active tool** tab in the properties panel/window.

> Keep the resolution as low as possible to save render time.

## UV Mapping

The UV mapping defines how a texture is mapped to a object. For this to work, the faces of an object are unwrapped onto a square. This can be changed in several ways by using the UV menu.

![UV menu](images/UV%20menu.png)

E.g. a cube is by default unwrapped in the following way:

![UV default unwrapping of cube](images/UV%20default%20cupe%20unwrapping.png)