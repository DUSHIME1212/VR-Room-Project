# VR Room Project

This is a Unity VR project designed as an interactive VR environment. It utilizes Unity's **XR Interaction Toolkit** to provide VR interactions such as grabbing objects, teleporting, and interacting with UI elements.

This project appears to be based on the **"Create by Unity"** VR course modules, featuring a central room environment with potentially several "challenge" areas.

## 📂 Project Structure

- **Scene**: `Assets/Scenes/VR Room.unity` - The main entry point for the experience.
- **Challenges**:
  - `01_Architecture`: Mini-project focused on architectural visualization or interaction.
  - `02_3DPainting`: Mini-project likely involving creative tools or 3D painting mechanics.
  - `03_Training`: Training area for VR mechanics.
- **\_Course Library**: Contains reusable scripts and prefabs from the course curriculum used to drive interactions (e.g., `ApplyPhysics`, `ChangeMaterial`, `PlaySound`).

## 🛠️ Technology Stack

- **Unity Version**: `6000.3.5f2`
- **XR Interaction Toolkit**: Version `3.0.8` (approx.)
- **Platform**: Designed for VR headsets (can be tested using XR Device Simulator).

## 🚀 Getting Started

1.  **Open Project**:
    - Open Unity Hub.
    - Add this project folder.
    - Ensure you are using Unity `6000.3.5f2` or a compatible version.

2.  **Open Scene**:
    - Navigate to `Assets > Scenes`.
    - Double-click `VR Room.unity` to open the main scene.

3.  **Run in Editor**:
    - Press the **Play** button.
    - Use the **XR Device Simulator** (if enabled) to simulate headset and controller movement with mouse and keyboard.

4.  **Build & Run**: (Optional)
    - Go to `File > Build Settings`.
    - Select your target platform (Android for Quest, Windows/Mac for PCVR).
    - ensure **XR Plug-in Management** is set up for your device (Project Settings > XR Plug-in Management).
    - Click **Build And Run** to deploy to your connected headset.

## 🎮 Controls

Standard XR Interaction Toolkit controls apply:

- **Move**: Joystick (Left controller) or Teleport Ray.
- **Turn**: Joystick (Right controller).
- **Grab/Interact**: Grip button.
- **Select/UI**: Trigger button.
