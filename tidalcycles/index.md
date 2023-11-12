# Tidal cycles

- [Tidal cycles](#tidal-cycles)
  - [Creating Patterns in TidalCycles](#creating-patterns-in-tidalcycles)
  - [Ports to Other Programming Languages](#ports-to-other-programming-languages)


[Tidal Cycles](https://tidalcycles.org/) is an innovative software for creating sound patterns through code, offering unique capabilities for both improvisation and composition. It is a domain-specific language embedded in [Haskell](https://www.haskell.org/), a functional programming language.

## Creating Patterns in TidalCycles

To give an idea of how patterns are created in TidalCycles, here are a few examples:

1. **Basic Patterns**:  
   - `d1 $ sound "bd*3"`: This plays the "bd" sample three times each cycle.
   - `d1 $ sound "bd/3"`: This plays the "bd" sample once every third cycle.

2. **Applying * and / on Groups**:  
   - `d1 $ sound "[bd sn]*2 cp"`: This pattern repeats a group of "bd" and "sn" sounds, followed by "cp".
   - `d1 $ sound "[bd sn sn*3]/2 [bd sn*3 bd*4]/3"`: This demonstrates using these symbols on nested groups for complex rhythms. [Source](https://tidalcycles.org/docs/getting-started/tutorial/)

3. **Using Functions for Variation**:  
   - `d1 $ every 4 (rev) (sound "bd*2 [bd [sn sn*2 sn] sn]")`: This reverses the pattern every fourth repetition. [Source](https://tidalcycles.org/docs/getting-started/tutorial/)
   - `d1 $ slow 4 $ sound "bd*2 [bd [sn sn*2 sn] sn]"`: This slows down the pattern to a quarter of its speed. [Source](https://tidalcycles.org/docs/getting-started/tutorial/)

4. **Adding Effects**:  
   - `d1 $ sound "bd*4" # crush "4"`: Applies a "crush" effect to the pattern. [Source](https://tidalcycles.org/docs/getting-started/tutorial/)
   - `d1 $ sound "bd*4" # gain "1 0.8 0.5 0.7"`: Adjusts the gain of each sound in the pattern. [Source](https://tidalcycles.org/docs/getting-started/tutorial/)

## Ports to Other Programming Languages

Efforts have been made to port TidalCycles to other programming languages, though these are typically in experimental stages:

1. **Python**: A Python 'port' exists, focusing on implementing basic Tidal types for patterns and functionality for combining patterns. See: [Vortex](https://github.com/tidalcycles/vortex)
2. **JavaScript**: There is an intention to try out TidalCycles in JavaScript, though this effort is still in the preliminary stage. See: [Strudel](https://strudel.cc/)