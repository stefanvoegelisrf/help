# Unreal Engine

Unreal engine is a powerful game engine used for developing games, creating cinematic renders and virtual production.

- [Unreal Engine](#unreal-engine)
  - [Lighting](#lighting)
  - [Materials](#materials)
  - [Terminology](#terminology)
    - [Kit bashing](#kit-bashing)
    - [LOD - Level of detail](#lod---level-of-detail)
    - [Volumetric Fog](#volumetric-fog)
      - [Creating a custom volumetric material for volumetric clouds](#creating-a-custom-volumetric-material-for-volumetric-clouds)
    - [Runtime Virtual Textures](#runtime-virtual-textures)
    - [Niagara](#niagara)
  - [MetaSound](#metasound)
  - [Control Rig](#control-rig)
  - [Worldpartition](#worldpartition)
  - [Live link](#live-link)

## Lighting

> See: [Lighting](lighting)

## Materials

> See: [Materials](materials)

## Terminology

> See: [Terminology](terminology)


### Kit bashing

### LOD - Level of detail
Meshes can have different levels of detail, depending on how close we are to the mesh. We don't need to render a completely detailed mesh when the mesh is not really visible.
In Unreal Engine, we can configure different LODs depending on how much space they take on the screen.

> Official documentation: [epicgames.com - Creating and using LODs in Unreal Engine](https://dev.epicgames.com/documentation/en-us/unreal-engine/creating-and-using-lods-in-unreal-engine)

### Volumetric Fog



#### Creating a custom volumetric material for volumetric clouds

- Create material
- Set "Material Domain" to "Volume"
- Set "Blend Mode" to "Additive"
- Set "Used With Volumetric Cloud" to true

### Runtime Virtual Textures


### Niagara

## MetaSound

## Control Rig

## Worldpartition

## Live link