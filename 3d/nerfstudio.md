# Nerfstudio useful tips

- [Nerfstudio useful tips](#nerfstudio-useful-tips)
  - [Installation](#installation)
    - [Getting splatfacto to work on windows](#getting-splatfacto-to-work-on-windows)
  - [Set target number of frames for training with video](#set-target-number-of-frames-for-training-with-video)
  - [Training NeRF model example](#training-nerf-model-example)
  - [Training splatfacto model example](#training-splatfacto-model-example)
  - [Splat Examples](#splat-examples)
    - [Office H6 B8](#office-h6-b8)
      - [Render](#render)
      - [Create gaussian splatting ply](#create-gaussian-splatting-ply)
  - [NeRF examples](#nerf-examples)
    - [Office H6 B8](#office-h6-b8-1)
      - [Render](#render-1)
      - [Point cloud](#point-cloud)
      - [Mesh](#mesh)


## Installation

- Setup
- Install VS specific version
- install ffmpeg
- install colmap
- add colmap to path
- add ffmpeg to path

### Getting splatfacto to work on windows

Some steps that helped getting splatfacto to work:
- Activate C++ env
  - Navigate to installed C++ folder `cd `
- Reinstall gsplat from github source
  - Uninstall gsplat `pip uninstall gsplat`
  - `pip install git+https://github.com/nerfstudio-project/gsplat.git`

## Set target number of frames for training with video

When working with video, the `ns-process-data` only selects a limited amount of frames from a video. If you want it to use all frames, look up the amount of frames that a video has with ffmpeg:

```
ffprobe -v error -select_streams v:0 -show_entries stream=nb_frames -of default=nokey=1:noprint_wrappers=1 input.mp4
```

E.g.:

```
ffprobe -v error -select_streams v:0 -show_entries stream=nb_frames -of default=nokey=1:noprint_wrappers=1 "C:\Users\User\Documents\Nerfstudio\superstar\superstar.mp4"
```

The amount of frames then can be passed on to the training command:

```
ns-process-data {images, video} --data {DATA_PATH} --output-dir {PROCESSED_DATA_DIR} --num-frames-target {FRAME_AMOUNT}
```

E.g:

```
ns-process-data video --data "C:\Users\User\Documents\Nerfstudio\superstar\superstar.mp4" --output-dir "C:\Users\User\Documents\Nerfstudio\superstar\processeddata" --num-frames-target 1393
```

## Training NeRF model example

```
ns-train nerfacto --data "C:\Users\User\Documents\Nerfstudio\superstar\processeddata" 
```

## Training splatfacto model example

```
ns-train splatfacto --data "C:\Users\User\Documents\Nerfstudio\superstar\processeddata" 
```



## Splat Examples

### Office H6 B8

#### Render

```
ns-render camera-path --load-config outputs\processeddata\splatfacto\2025-03-07_091755\config.yml --camera-path-filename C:\Users\User\Documents\Nerfstudio\officeh6b8_2\processeddata\camera_paths\officeh6b8-render1.json --output-path renders/processeddata/officeh6b8-render1.mp4
```

#### Create gaussian splatting ply

```
ns-export gaussian-splat --load-config outputs\processeddata\splatfacto\2025-03-07_091755\config.yml --output-dir exports/splat/ 
```

## NeRF examples

### Office H6 B8

#### Render

```
ns-render camera-path --load-config outputs\processeddata\nerfacto\2025-03-07_104720\config.yml --camera-path-filename C:\Users\User\Documents\Nerfstudio\officeh6b8_2\processeddata\camera_paths\2025-03-07-10-47-24.json --output-path renders/processeddata/2025-03-07-10-47-24.mp4
```

#### Point cloud

```
ns-export pointcloud --load-config outputs\processeddata\nerfacto\2025-03-07_104720\config.yml --output-dir exports/pcd/ --num-points 1000000 --remove-outliers True --normal-method open3d --save-world-frame False 
```

#### Mesh

```
ns-export poisson --load-config outputs\processeddata\nerfacto\2025-03-07_104720\config.yml --output-dir exports/mesh/ --target-num-faces 50000 --num-pixels-per-side 2048 --num-points 1000000 --remove-outliers True --normal-method open3d 
```