<h1 align="center">Yummy Fruits</h1>

<p align="center">
A 3D fruit-collection arcade game developed with Unity and C#.<br>
Control an animated log character, catch falling fruits, and collect as many items as possible before time runs out.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/Engine-Unity%202022.3.7f1-black"/>
  <img src="https://img.shields.io/badge/Language-C%23-purple"/>
  <img src="https://img.shields.io/badge/UI-TextMeshPro-blue"/>
  <img src="https://img.shields.io/badge/UI-Unity%20UI-0E7FBF"/>
  <img src="https://img.shields.io/badge/Physics-Unity%20Physics-orange"/>
  <img src="https://img.shields.io/badge/Audio-Unity%20Audio-yellow"/>
  <img src="https://img.shields.io/badge/Platform-PC-green"/>
  <img src="https://img.shields.io/badge/Mode-Single%20Player-red"/>
  <img src="https://img.shields.io/badge/Status-Completed-brightgreen"/>
</p>

---

## Project Overview

**Yummy Fruits** is a single-player arcade game where the player catches falling fruits and vegetables in a limited-time round.

The gameplay loop is simple:

- fruits and vegetables fall from above,
- the player moves horizontally and jumps to catch them,
- each collected item increases the score,
- the game tracks individual counts for each fruit type,
- the round lasts 60 seconds,
- when the timer reaches zero, the final result screen is shown.

The project includes a complete menu flow, map selection, controls screen, settings scenes, statistics scene, in-game pause flow, sound effects, music, and multiple themed gameplay maps.

<img width="1920" height="1080" alt="yummyfruitsgame" src="https://github.com/user-attachments/assets/0e2c1b78-497c-4f76-bda7-b0220e874145" />

---

## Supported Platform

Yummy Fruits is organized as a Unity PC project.

- **PC Version** - keyboard-based single-player gameplay.

Compiled builds are not stored in the source repository. The repository contains the Unity project files required to open, inspect, and build the game from the Unity Editor.

---

## Project Structure

```text
Yummy_Fruits/
|-- Assets/
|   |-- codes/
|   |   |-- buttoncode.cs
|   |   |-- maincode.cs
|   |   `-- planecode.cs
|   |-- Scenes/
|   |   |-- mainmenu.unity
|   |   |-- maps.unity
|   |   |-- forestgame.unity
|   |   |-- desertgame.unity
|   |   |-- polargame.unity
|   |   |-- terriblejunglegame.unity
|   |   |-- controls.unity
|   |   |-- lightsettings.unity
|   |   |-- soundsettings.unity
|   |   |-- information.unity
|   |   `-- statistics.unity
|   |-- 2Dfruits(mydrawing)/
|   |-- Assets_AngryLog/
|   |-- FarlandSkies/
|   |-- Free 2D Cartoon Parallax Background/
|   |-- Fruit Blocks/
|   |-- JellyIcons/
|   |-- Leohpaz/
|   |-- Low Poly Environment/
|   |-- Skybox/
|   |-- Stylized Nature Environment/
|   |-- Tavern Music Free Pack/
|   `-- TextMesh Pro/
|-- Packages/
|   |-- manifest.json
|   `-- packages-lock.json
|-- ProjectSettings/
|-- LICENSE
|-- README.md
`-- .gitignore
```

---

## Core Systems

### Player Movement

- Rigidbody-based player movement.
- Horizontal movement with keyboard input.
- Jump control with ground-height limitation.
- Character rotation changes based on movement direction.

### Fruit Collection

- Multiple collectible item types:
  - red apple,
  - green apple,
  - pineapple,
  - eggplant,
  - pomegranate,
  - tomato,
  - orange.
- Collected items temporarily disappear.
- Items respawn at randomized horizontal positions.
- Each fruit type has its own score counter.

### Timer and Score Flow

- 60-second match duration.
- Countdown timer displayed through TextMeshPro UI.
- Clock image fill updates as time decreases.
- Total collected fruit count is shown during gameplay.
- End panel appears when time runs out.

### Scene and Menu Flow

- Main menu scene.
- Map selection scene.
- Four playable map scenes:
  - Forest,
  - Desert,
  - Polar,
  - Terrible Jungle.
- Controls, information, light settings, sound settings, and statistics scenes.
- Pause, restart, return-to-menu, and quit confirmation support.

---

## Features

### Fast Arcade Gameplay

- Short 60-second sessions.
- Simple movement and collection rules.
- Score-focused gameplay loop.
- Designed for quick replayability.

### Multiple Map Themes

- Forest map.
- Desert map.
- Polar map.
- Terrible Jungle map.

Each map keeps the same core gameplay while changing the visual environment.

<img width="1920" height="1080" alt="yummyfruitsmaps" src="https://github.com/user-attachments/assets/16949755-3468-4fca-8d8b-9bb804a1d698" />

### Menu and Settings Flow

- Icon-based main menu.
- Controls screen.
- Light settings scene.
- Sound settings scene.
- Information/credits scene.
- Statistics scene using PlayerPrefs-based saved values.

---

## Game Mechanics

### Collecting

When the player collides with a fruit or vegetable, the item is counted, hidden, and respawned after a short delay.

### Respawning

Collected or missed items are repositioned above the play area with randomized horizontal placement. Different item types use different respawn delays.

### Scoring

The game tracks both the total collected item count and the individual count for each fruit or vegetable type.

### Round End

When the countdown reaches zero, gameplay pauses and the end-of-round result panel is displayed.

---

## How to Play

1. Start the game from the main menu.
2. Open the map selection screen.
3. Choose one of the available maps.
4. Move the character left and right to catch falling items.
5. Jump when needed to reach items.
6. Collect as many fruits and vegetables as possible before the 60-second timer ends.

---

## Controls

| Action | Controls |
|---|---|
| Move Left | `A` or Left Arrow |
| Move Right | `D` or Right Arrow |
| Jump | `W`, Up Arrow, or Space |
| Pause / Menu Actions | In-game UI buttons |

---

## Technologies Used

- **Unity Engine 2022.3.7f1** - game development engine.
- **C#** - gameplay, UI, menu, and scene logic.
- **TextMeshPro** - score, timer, and menu text rendering.
- **Unity UI (UGUI)** - menu buttons, panels, controls, and in-game interface.
- **Unity Physics** - Rigidbody movement, collisions, and item interaction.
- **Unity Audio** - music and sound effects.
- **PlayerPrefs** - lightweight local statistics storage.

---

## Assets and Audio

### Visual Assets

- 3D Character Model: Free Animated Angry Log - Revenge of the Tree  
  https://assetstore.unity.com/packages/3d/characters/creatures/free-animated-angry-log-revenge-of-the-tree-150947

- 3D Fruit Models: Fruit Blocks  
  https://assetstore.unity.com/packages/3d/props/food/fruit-blocks-128327

- 2D Background Models: Free 2D Cartoon Parallax Background  
  https://assetstore.unity.com/packages/2d/environments/free-2d-cartoon-parallax-background-205812

- 2D Icons: Jelly Icons  
  https://assetstore.unity.com/packages/2d/gui/icons/jelly-icons-99749

- Sky Texture: Farland Skies - Cloudy Crown  
  https://assetstore.unity.com/packages/2d/textures-materials/sky/farland-skies-cloudy-crown-60004

### Audio

- Sound Effects: RPG Essentials Sound Effects Free  
  https://assetstore.unity.com/packages/audio/sound-fx/rpg-essentials-sound-effects-free-227708

- Game Music: Fantasy Tavern Music Free Pack  
  https://assetstore.unity.com/packages/audio/music/fantasy-tavern-music-free-pack-118847

---

## Installation and Play

1. Clone the repository:

```bash
git clone https://github.com/KayzerFurkan04/Yummy_Fruits.git
```

2. Open the project folder with Unity Hub:

```text
Yummy_Fruits
```

3. Use **Unity 2022.3.7f1** or a compatible Unity 2022.3 LTS version.

4. Open the main menu scene:

```text
Assets/Scenes/mainmenu.unity
```

5. Press **Play** in the Unity Editor.

### Builds

Compiled builds are not included in this repository. Release builds should be distributed through GitHub Releases, itch.io, or another download page.

---

## Credits

### Game Development

**A. Furkan ÖCEL**

GitHub: https://github.com/KayzerFurkan04

---

## License

This project is licensed under the terms included in the repository's `LICENSE` file.
