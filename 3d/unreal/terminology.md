# Unreal Engine terminology
This section covers Enreal Engine specific terms with further references to the official documentation.

- [Unreal Engine terminology](#unreal-engine-terminology)
  - [Project](#project)
  - [Blueprint](#blueprint)
  - [Object](#object)
  - [Class](#class)
  - [Actor](#actor)
  - [Casting](#casting)
  - [Component](#component)
  - [Pawns](#pawns)
    - [Characters](#characters)
    - [Player controller](#player-controller)
    - [AI controller](#ai-controller)
  - [Player state](#player-state)
  - [Game mode](#game-mode)
  - [Game state](#game-state)
  - [Brush](#brush)
  - [Volume](#volume)
  - [Level](#level)
  - [World](#world)


## Project
An Unreal Engine project holds all content of a project.

## Blueprint
Blueprint is a visual scripting system inside of Unreal Engine with a node-based interface.

## Object
Objects(basic classes) are building blocks for assets inside of Unreal Engine and contain essential functionality.

## Class
Classed define behavior and properties of Actors or Object in Unreal Engine. They are created in C++ or with Blueprints.

## Actor
An actor is an object that is placed into a level, like a camera or a mesh and has transformation data like translation, rotation and scaling.

## Casting
With casting, we treat an objects as if it were another object and then use the objects functionality, that we cast it to.

## Component
Components are functionality, that we add to an actor. They don't exist by themselves.

## Pawns
Pawns are the base class of Actors like characters in a game and are controlled(possessed) by the player or game AI. The pawn is the physical representation of a player or or AI within the world, meaning the visual appearance, interactions, location, rotation and so on.

### Characters
Characters are a type of pawns that can walk around and are intended to use as player character, which includes collision, movement and other code for player-controlled movement.

### Player controller
The player controller uses player input and translates it to interactions and is often used for possessing Pawns or Characters.

### AI controller
This is similar to the player controller, but is used for NPCs.

## Player state
The player state representes tha state of a human player or a bot simulating a player. State could be: Name, health, level, score, ...

## Game mode
The game mode are the rules of the game.

## Game state
The game state determines e.g. if a game has started, score and other things.

## Brush
A brush is an Actor for a 3D-shape and is mostly used for defining the rough layout of a level.

## Volume
Volumes are 3D saces with different effects like blocking Actors, causing damage or triggering functionality.

## Level
Levels are gameplay areas defined and contain what is visible and what is interactable.

## World
The world is the container for all levels.