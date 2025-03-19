# Lighting

- [Lighting](#lighting)
  - [Lumen](#lumen)
    - [Settings for optimizing reflections](#settings-for-optimizing-reflections)
  - [Sky Light](#sky-light)
  - [Use env. light mixer](#use-env-light-mixer)

## Lumen

### Settings for optimizing reflections

## Sky Light

> Official documentation: [epicgames.com - Sky Lights in Unreal Engine](https://dev.epicgames.com/documentation/en-us/unreal-engine/sky-lights-in-unreal-engine)

HDRIs can be applied using the sky light. To do so, change the source type to "SLS Specificed Cubemap" and set the cubemap to the HDRI.

To create a texture cube automatically, make sure that the HDRI is a ".hdr" file.

To disable a sky light, uncheck "Affects World" in the details panel.

Movable sky lights update when either "Real Time Capture" is enabled or "Recapture" is triggered.

When the ground is blocking the sky, it makes sense to set "Lower Hemisphere Is Solid Color".

The "Sky Distance Threshold" defines what to capture relative to where it is located. If the value is small, the objects surrounding the sky light will be captured. If it is high, the objects within the threshold distance of the sky light will be ignored.

## Use env. light mixer
To easily add lights, use the env. light mixer by choosing `Window` -> `Env. light mixer` and then add the needed lights. For more info, see: [epicgames.com - Environment light mixer in Unreal Engine](https://dev.epicgames.com/documentation/en-us/unreal-engine/environment-light-mixer-in-unreal-engine)