# **Sky Adventure**
<p align='center'>
<img src="https://github.com/wahyuwerayana/Side-Scroller/assets/115724777/56f6ff65-2ae2-4eb0-9d27-f047be7e16c7" width="60%">
</p>

# 📖Documentation
- Made using Unity Editor 2022.3.19f1
- All assets are from Itch.io

## 📂File Description
```
├── Sky-Adventure-Side-Scroller                # This folder contains all the project files.
     ├── Assets                                # This folder contains all of the game assets such as code, sprites, scenes, etc.
        ├── Animation                          # This folder contains the animation and animator controller used for the gameobjects.
        ├── Fonts                              # This folder contains all the fonts that are being used for the game.
        ├── Music & Sound                      # This folder contains all the audio files that are being used for the game.
        ├── Prefab                             # This folder contains the gameobject prefab to use in the game scenes.
        ├── Scripts                            # This folder contains all of the game script files.
        ├── Scenes                             # This folder contains scene for the game. You can open these scenes to play the game via Unity.
        ├── Sprites                            # This folder contains all the sprites for the gameobject.
        ├── ....
     ├── ...
```

## 📑Scripts
### **Player**
| **Script Name**    | **Function**                            |
| ------------------ | --------------------------------------- |
| `PlayerMovement.cs` | Handle the movement of the player logic |
| `PlayerPositionHandler.cs` | Manage the player position when saving and loading the game, hitting enemy, checkpoint and finish line  |
### **Enemy**
| **Script Name**    | **Function**                            |
| ------------------ | --------------------------------------- |
| `HorizontalMovement.cs` | Manage the enemy movement to move in the horizontal axis |
### **UI**
| **Script Name**    | **Function**                            |
| ------------------ | --------------------------------------- |
| `UIGameplay.cs` | Manage the UI for Resuming, Pausing and Exiting the game in the Game Scene |
| `UIMenu.cs` | Manage the level selection in the main menu |
### **Other**
| **Script Name**    | **Function**                            |
| ------------------ | --------------------------------------- |
| `BackgroundScroller.cs` | Make the parallax effect on the background |
| `CameraFollow.cs` | Make the camera follow the player on a certain offset |
| `GameManager.cs` | Manage the game flow such as saving, loading, checking save file, etc. |
| `MusicController.cs` | Make the music play through scenes |
| `etc` |  |

<br />

## 📄About
Sky Adventure is an exhilarating side-scroller platformer game set in a vibrant and whimsical sky world. Developed using the Unity Engine, this game invites players on a thrilling journey through floating islands, mystical creatures, and treacherous obstacles. With its captivating visuals and engaging gameplay, Sky Adventure offers a delightful experience for players of all ages.

## 🎯Gameplay
Players goes on a daring adventurer navigating through a series of floating platforms and islands. The objective is to jump, run, and avoid through various obstacles in the game, such as creatures, spikes and water. Go to each stone checkpoint and reach the pillars to finish the level.

## 🕹️Controls
| Key Binding | Function |
| ----------- | -------- |
| A, D, Left Arrow, Right Arrow | Move Character to left or right |
| Space | Jump |

## ⚙️Setup
- Go to the release tab located in the right side of this page.
- Download the .zip file from the latest release available.
- Extract the .zip file containing the game.
- Open the .exe file.
