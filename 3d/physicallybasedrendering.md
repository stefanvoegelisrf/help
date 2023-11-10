# Physically Based Rendering(PBR)

- [Physically Based Rendering(PBR)](#physically-based-renderingpbr)
  - [1. **Diffuse Reflection**](#1-diffuse-reflection)
  - [2. **Specular Reflection**](#2-specular-reflection)
  - [3. **Fresnel Effect**](#3-fresnel-effect)
  - [4. **Normal Mapping**](#4-normal-mapping)
  - [5. **Microfacet Model**](#5-microfacet-model)
  - [6. **Energy Conservation**](#6-energy-conservation)
  - [7. **Metalness**](#7-metalness)
  - [8. **Roughness**](#8-roughness)


Physically Based Shading is a technique used in 3D computer graphics to achieve more realistic lighting and material appearances. Here are its key components:

## 1. **Diffuse Reflection**
   - **Description:** This is how light scatters when it hits a non-shiny surface.
   - **Effect:** It creates the soft, matte look on surfaces where light is evenly distributed.

## 2. **Specular Reflection**
   - **Description:** This refers to the mirror-like reflection of light from a surface.
   - **Effect:** It is responsible for the shiny spots on objects, like the reflection on a polished car or a wet surface.

## 3. **Fresnel Effect**
   - **Description:** This effect describes how the amount of reflected light changes depending on the viewing angle.
   - **Effect:** It makes surfaces appear more reflective at grazing angles, like how a road looks wet and reflective when viewed from a distance.

## 4. **Normal Mapping**
   - **Description:** A technique used to fake the lighting of bumps and dents on surfaces.
   - **Effect:** It adds texture and detail to surfaces without increasing the number of polygons.

## 5. **Microfacet Model**
   - **Description:** This is a model that represents the surface as a collection of tiny facets.
   - **Effect:** It helps in calculating how light interacts with rough surfaces, affecting both diffuse and specular reflection.

## 6. **Energy Conservation**
   - **Description:** In PBS, the total amount of light reflected and absorbed by a surface must equal the amount of light that hits it.
   - **Effect:** This ensures that objects do not appear unnaturally bright or dark and maintain realistic light interaction.

## 7. **Metalness**
   - **Description:** A parameter that defines whether a surface is metallic or non-metallic.
   - **Effect:** Metallic surfaces reflect all incident light as specular, while non-metallic surfaces reflect light as both specular and diffuse.

## 8. **Roughness**
   - **Description:** This parameter controls how rough or smooth a surface is.
   - **Effect:** A smoother surface leads to sharper, clearer reflections, while a rougher surface scatters light, leading to duller reflections.