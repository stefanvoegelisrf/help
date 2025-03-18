# Unreal Engine

## Unreal Engine specific terms
This section covers Enreal Engine specific terms with further references to the official documentation. 

### Project
An Unreal Engine project holds all content of a project.

### Blueprint
Blueprint is a visual scripting system inside of Unreal Engine with a node-based interface.

### Object
Objects(basic classes) are building blocks for assets inside of Unreal Engine and contain essential functionality.

### Class
Classed define behavior and properties of Actors or Object in Unreal Engine. They are created in C++ or with Blueprints.

### Actor
An actor is an object that is placed into a level, like a camera or a mesh and has transformation data like translation, rotation and scaling.

### Casting
With casting, we treat an objects as if it were another object and then use the objects functionality, that we cast it to.

### Component
Components are functionality, that we add to an actor. They don't exist by themselves.

### Pawns
Pawns are the base class of Actors like characters in a game and are controlled(possessed) by the player or game AI. The pawn is the physical representation of a player or or AI within the world, meaning the visual appearance, interactions, location, rotation and so on.

#### Characters
Characters are a type of pawns that can walk around and are intended to use as player character, which includes collision, movement and other code for player-controlled movement.

#### Player controller
The player controller uses player input and translates it to interactions and is often used for possessing Pawns or Characters.

#### AI controller
This is similar to the player controller, but is used for NPCs.

### Player state
The player state representes tha state of a human player or a bot simulating a player. State could be: Name, health, level, score, ...

### Game mode
The game mode are the rules of the game.

### Game state
The game state determines e.g. if a game has started, score and other things.

### Brush
A brush is an Actor for a 3D-shape and is mostly used for defining the rough layout of a level.

### Volume
Volumes are 3D saces with different effects like blocking Actors, causing damage or triggering functionality.

### Level
Levels are gameplay areas defined and contain what is visible and what is interactable.

### World
The world is the container for all levels.

### Use env. light mixer
To easily add lights, use the env. light mixer by choosing `Window` -> `Env. light mixer` and then add the needed lights. For more info, see: [epicgames.com - Environment light mixer in Unreal Engine](https://dev.epicgames.com/documentation/en-us/unreal-engine/environment-light-mixer-in-unreal-engine)

### Kit bashing

### LOD - Level of detail
Meshes can have different levels of detail, depending on how close we are to the mesh. We don't need to render a completely detailed mesh when the mesh is not really visible.
In Unreal Engine, we can configure different LODs depending on how much space they take on the screen - see: [epicgames.com - Creating and using LODs in Unreal Engine](https://dev.epicgames.com/documentation/en-us/unreal-engine/creating-and-using-lods-in-unreal-engine)

### Volumetric Fog

### Sky Light

### Runtime Virtual Textures


### Niagara

## MetaSound

## Control Rig

## Lumen

### Settings for optimizing reflections

## Worldpartition

## Live link