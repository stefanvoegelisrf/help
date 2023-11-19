# 3D

- [3D](#3d)
  - [Blender](#blender)
  - [Physically based rendering](#physically-based-rendering)
  - [3D Model from photographies](#3d-model-from-photographies)
  - [3D scene/model viewer](#3d-scenemodel-viewer)

## [Blender](blender)

Blender is the free and open source 3D creation suite. It supports the entirety of the 3D pipeline—modeling, rigging, animation, simulation, rendering, compositing and motion tracking, even video editing and game creation.

## [Physically based rendering](physicallybasedrendering)

Physically based rendering (PBR) is a computer graphics approach that seeks to render images in a way that models the lights and surfaces with optics in the real world. It is often referred to as "Physically Based Lighting" or "Physically Based Shading".

## 3D Model from photographies

Create a 3D model from a series of photos using **Adobe Substance 3D sampler** and **Blender**.

- Take a series of pictures from different angles and different distances. Take more than 50
  - Ideal lighting condition is cloudy day light.
- Import the data set into Adobe Substance 3D sampler and let it analyze it and create the model.
- Save the model to a project.
- Export the model inside the project.
- Open Blender and create a new scene.
- Import the .USD file into the scene and position it correctly.
- Export the scene as a glb
- The model can now be viewed by using [model-viewer](https://modelviewer.dev/)

## 3D scene/model viewer

Google provides a web component called [Web Viewer](https://modelviewer.dev/) which can easily be integrated into websites to display 3D models. It is very easy to use with `.glb` files.

> See [Google developer documentation](https://developers.google.com/ar/develop/scene-viewer)