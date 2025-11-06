# 🫀 Week 2 – Part A – Bonus Task  
**Unity Project – Pulsating “Toy Bone” (Beating Heart Effect)**

🎮 **Play the game on Itch.io:**  
👉 https://alpha444rt.itch.io/game03

---

## ✅ Description
implements a **ball-shaped “toy bone”** that **gradually grows and shrinks**, mimicking a **beating heart**.  
The object scales up and down smoothly over time to create a rhythmic pulse effect.

---

## ✅ What it demonstrates
- Smooth scaling animation over time (pulsing/heartbeat behavior)  
- Time-based updates with `Time.deltaTime`  
- Clean separation of parameters (speed, min/max scale) for easy tuning  
- Basic scene setup and component scripting in Unity

---

## ✅ How it works (concept)
A simple C# script updates the object’s `transform.localScale` every frame using a periodic function (e.g., sine/lerp), clamped between **Min Scale** and **Max Scale** and driven by a **Pulse Speed** value.
