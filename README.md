## Martian Robots

A **C# console application** that solves the *Martian Robots* coding challenge.  
It simulates multiple robots navigating a rectangular grid on Mars based on command sequences sent from Earth.

### Problem Overview
The surface of Mars is represented by a rectangular grid.  
Each robot starts at a specific coordinate and orientation (`N`, `S`, `E`, `W`) and follows a sequence of commands:

| Command | Action |
|---------|---------|
| `L`     | Turn left 90° |
| `R`     | Turn right 90° |
| `F`     | Move forward one grid point |

If a robot moves off the grid, it becomes **LOST**, but it leaves a **“scent”** on its last valid position to prevent future robots from getting lost the same way.

### Solution Design
- Developed using **C# / .NET Console Application**
- Implements **OOP principles** and follows the **Open/Closed Principle (OCP)**
- Extensible command design using the **IInstruction** interface
- Handles **blank lines** and **edge conditions**
- Clean and simple code

### How to Run

#### Option 1 — From Visual Studio
1. Open the solution (`MartianRobots.sln`)
2. Press **F5** (Run) or **Ctrl + F5** (Run without Debugging)
3. Paste your input in the console
4. Press **Ctrl+Z** then **Enter** to execute (Windows)

#### Option 2 — From Command Prompt / Terminal
1. Clone the repository  
   git clone https://github.com/vivekbannur/MartianRobots.git
   cd MartianRobots

2. Build the project  
   
   dotnet build
   
3. Run the app  
   
   dotnet run
   
4. Paste your input (example below), then press **Ctrl+Z + Enter**.

### Sample Input
5 3
1 1 E
RFRFRFRF

3 2 N
FRRFLLFFRRFLL

0 3 W
LLFFFLFLFL

### Expected Output
1 1 E
3 3 N LOST
2 3 S

### Requirements
- [.NET 6 SDK or later](https://dotnet.microsoft.com/download)

### Author
**Vivek Bannur**  
Software Engineer | .NET & Cloud Developer  

### 🏁 Summary
A clean, object-oriented, and extensible solution to the *Martian Robots* challenge — runnable on any machine with the .NET SDK installed, no Visual Studio required.