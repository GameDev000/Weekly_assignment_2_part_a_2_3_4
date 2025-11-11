# Weekly_Assignment_2_Part_B_Transformations  

### What this project is  
This Unity task demonstrates three custom scripts — **Rotator**, **Ball**, and **Display**. 

- **Rotator** – rotates an object continuously around its axis.  
- **Ball** – makes an object grow and shrink between two defined scales.  
- **Display** – allows toggling an object’s visibility using a keyboard key (Space).  

### How it works  
- **Rotator:**  
  Continuously rotates the object around the Z-axis using `transform.Rotate(0, 0, SpeedRotation * Time.deltaTime)`.  
  The rotation speed can be changed via the public variable **SpeedRotation**.  

- **Ball:**  
  Changes the object’s scale gradually between two limits (**Min** and **Max**) using a boolean flag `isGrowing`.  
  When the object reaches its maximum size, it reverses direction and shrinks back.  

- **Display:**  
  Uses the new **Input System** (`InputAction`) to detect when the Space key is pressed.  
  On each key press, it toggles the active state of a **targetObject** (`SetActive(true/false)`),  
  with a short cooldown (0.4s) to prevent rapid toggling.  

### Adjustable parameters  
- **Rotator:**  
  - `SpeedRotation` – rotation speed in degrees per second.  
  - `CenterPoint` – stores the object’s initial position.  

- **Ball:**  
  - `Max` / `Min` – maximum and minimum allowed scale sizes.  
  - `CenterPoint` – the initial position reference.  

- **Display:**  
  - `targetObject` – the GameObject to show or hide.  
  - `swichAction` – defines the input used to toggle visibility (spacee).  
  - `isHidden` – tracks the object’s visibility state.  
  - `lastSwich` – limits toggle frequency using time intervals.  

### Demonstration  
In the Unity scene:  
- **Triangle (Rotator):** spins continuously around its Z-axis.  
- **Circle (Ball):** grows and shrinks smoothly in a repeating loop.  
- **Square (Display):** disappears and reappears when pressing Space.  

Each script can be attached independently to any GameObject,  
allowing you to combine transformations (for example, a rotating and pulsating ball).  

<a href="https://itch.io">itch.io</a>
