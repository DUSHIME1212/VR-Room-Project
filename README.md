# 🥽 VR Room Project

Welcome to the **VR Room Project**, an interactive virtual reality environment built with Unity. This project serves as a sandbox for exploring VR interaction design, featuring high-quality scripts and modular components.

---

## ✨ Key Features

### 🔦 Interactive Flashlight

A custom-built flashlight system designed for immersive VR gameplay.

- **Dynamic Lighting**: Real-time spotlight toggling.
- **Visual Feedback**: The flashlight lens features emission mapping that turns on/off with the light.
- **Sound Effects**: satisfying click sounds for a tactile feel.
- **XR Ready**: Optimized for use with the `XRGrabInteractable` component.

### 🕰️ Analog Clock System

A precise, real-time analog clock that syncs with your system time.

- **Smooth Seconds**: Optional smooth rotation for a premium look.
- **Configurable Axis**: Supports any orientation (X, Y, or Z).
- **Inversion Logic**: Easy toggle for clockwise/anti-clockwise rotation.

### 🏗️ Explorable Environments

- **Architecture Room**: Explore high-fidelity architectural visualizations.
- **3D Painting**: Get creative with immersive tools.
- **Training Grounds**: Master VR locomotive and interaction mechanics.

---

## 📂 Project Structure

- **`Assets/Scenes/VR Room.unity`**: The main entry point.
- **`Assets/_Course Library/Scripts/Actions`**: Home to core logic like `Flashlight.cs`, `AnalogClock.cs`, and `PlayVideo.cs`.
- **`Assets/_Course Library/_Prefabs`**: Pre-configured VR objects ready for placement.

---

## 🛠️ Technology Stack

- **Engine**: Unity `6000.3.5f2`
- **Frontend**: XR Interaction Toolkit `3.0.x`
- **Render Pipeline**: Universal Render Pipeline (URP)
- **Input**: OpenXR with XR Device Simulator support.

---

## 🚀 Getting Started

1.  **Open Project**: Load the folder in Unity Hub (Unity `6000.3.x` recommended).
2.  **Open Scene**: Go to `Assets > Scenes > VR Room.unity`.
3.  **Play**: Hit the **Play** button and use the **XR Device Simulator** to move and interact.

### 💡 Adding the Flashlight to a New Object

1. Create a 3D object (e.g., a Cylinder) or use a prefab.
2. Add the `Flashlight` script.
3. Assign a `Light` child object to the **Flashlight Light** field.
4. Assign the object's `MeshRenderer` to **Lens Renderer**.
5. Map **Toggle On/Off** sounds to the audio fields.
6. (Optional) Add an `XRGrabInteractable` and link `Flashlight.Toggle()` to the **Activated** event.

---

## 🎮 Controls

| Action        | Left Controller | Right Controller |
| :------------ | :-------------- | :--------------- |
| **Move**      | Joystick        | -                |
| **Turn**      | -               | Joystick         |
| **Grab Item** | Grip            | Grip             |
| **Use Item**  | Trigger         | Trigger          |
| **Teleport**  | Ray Cast        | -                |

---

_Happy Coding and Exploring!_ 🚀
