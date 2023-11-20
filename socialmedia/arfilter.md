# AR Filters

- [Spark AR (for Instagram)](#spark-ar-for-instagram)
  - [Parameters in Spark AR](#parameters-in-spark-ar)
    - [Getting Started with Spark AR](#getting-started-with-spark-ar)
- [TikTok Effect House (for TikTok)](#tiktok-effect-house-for-tiktok)
  - [Parameters in TikTok Effect House](#parameters-in-tiktok-effect-house)
  - [Getting Started with TikTok Effect House](#getting-started-with-tiktok-effect-house)
- [Step-by-Step Guide: Creating a Face Overlay Effect](#step-by-step-guide-creating-a-face-overlay-effect)
  - [Concept](#concept)
  - [Implementation Steps](#implementation-steps)
  - [Improvement and Publishing](#improvement-and-publishing)
- [General Tips for Creating Popular Filters](#general-tips-for-creating-popular-filters)

## Spark AR (for Instagram)

### Parameters in Spark AR
Spark AR offers various parameters for creating filters:

1. **[Face Tracker](https://sparkar.facebook.com/ar-studio/learn/documentation/fundamentals/face-tracking/)**: Tracks facial movements and expressions.
2. **[3D Objects](https://sparkar.facebook.com/ar-studio/learn/documentation/fundamentals/3d-objects/)**: Integration and manipulation of 3D models.
3. **[Materials and Textures](https://sparkar.facebook.com/ar-studio/learn/documentation/fundamentals/materials/)**: Customize appearances with textures and shaders.
4. **[Lighting and Environment](https://sparkar.facebook.com/ar-studio/learn/documentation/fundamentals/lighting-and-environment/)**: Adjust lighting settings and environmental effects.
5. **[Particle Systems](https://sparkar.facebook.com/ar-studio/learn/documentation/fundamentals/particle-systems/)**: Create dynamic visual elements.
6. **[Audio Playback and Reactive](https://sparkar.facebook.com/ar-studio/learn/documentation/fundamentals/audio/)**: Incorporate and react to audio.
7. **[Animation](https://sparkar.facebook.com/ar-studio/learn/documentation/fundamentals/animation/)**: Animate objects within your filter.

#### Getting Started with Spark AR
Follow the [official guide](https://sparkar.facebook.com/ar-studio/learn/documentation/getting-started/) to download, explore, and start creating with Spark AR.

1. **Download Spark AR Studio**: [Official Download Link](https://sparkar.facebook.com/ar-studio/download/).
2. **Explore the Interface**: Familiarize yourself with the layout and tools.
3. **Start a New Project**: Choose from templates or start from scratch.
4. **Experiment with Assets**: Add 3D objects, effects, and customize them.
5. **Preview and Test**: Use the Spark AR Player app to test on your device.


## TikTok Effect House (for TikTok)

### Parameters in TikTok Effect House
TikTok Effect House provides a similar range of functionalities:

1. **Face and Body Tracking**: Detects and tracks facial and body movements.
2. **Segmentation and Texture Replacement**: Separate background from the foreground.
3. **3D Models and Animation**: Integrate and animate 3D objects.
4. **Interactive Elements**: Create effects that respond to user interactions.
5. **Audio Analysis**: Integrate and respond to music or sound.

### Getting Started with TikTok Effect House
Begin with the [TikTok Effect House guide](https://effecthouse.tiktok.com/docs/guides/getting-started/) for downloading and learning the basics of creating effects.

1. **Download TikTok Effect House**: [Official Download Link](https://www.tiktok.com/business/en-US/effect-house).
2. **Learn the Basics**: Familiarize yourself with the toolset.
3. **Create a New Effect**: Start building your effect.
4. **Add and Customize Features**: Incorporate tracking, 3D models, etc.
5. **Test and Preview**: Use TikTok to preview your effect.

## Step-by-Step Guide: Creating a Face Overlay Effect

### Concept
Create an effect where each point of the face mesh is represented by an ellipse. The color intensity of the ellipse varies based on its location (e.g., eyes, eyebrows, nose, mouth, outlines).

Implement this effect by following the documentation for [face mesh](https://sparkar.facebook.com/ar-studio/learn/documentation/fundamentals/face-tracking/#face-mesh) in Spark AR or the equivalent in TikTok Effect House. Use scripting (JavaScript in Spark AR) to differentiate facial regions and apply color intensity.

### Implementation Steps
1. **Face Mesh**: Start by importing the face mesh in Spark AR or TikTok Effect House.
2. **Vertices Mapping**: Each vertex of the face mesh corresponds to an ellipse.
3. **Color Intensity Logic**: Program the intensity based on the facial region. Use scripting to differentiate parts like eyes, eyebrows, etc.
4. **Visual Testing**: Test the effect to ensure accurate mapping and intensity variation.

### Improvement and Publishing
- **Optimization**: Ensure the effect runs smoothly without lag.
- **Compliance**: Adhere to platform guidelines.
- **Publishing**: Submit the effect for review through the respective platform.

## General Tips for Creating Popular Filters
- **Creativity and Uniqueness**: Stand out with original ideas.
- **Trend Awareness**: Keep up with current trends and incorporate them into your designs.
- **User Engagement**: Design interactive and fun filters that encourage sharing.
- **Cross-Platform Promotion**: Share your filters across social media to gain visibility.
- **Feedback and Iteration**: Take user feedback into account for improvements.

Incorporate these best practices, keeping abreast of trends and user engagement strategies. Regularly consult the [Spark AR documentation](https://sparkar.facebook.com/ar-studio/learn/documentation/) and [TikTok Effect House resources](https://effecthouse.tiktok.com/docs/) for updates and new features. 