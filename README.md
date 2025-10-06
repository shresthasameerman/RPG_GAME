# RPG_GAME

[![GitHub Repository](https://img.shields.io/badge/GitHub-RPG_GAME-blue?logo=github)](https://github.com/shresthasameerman/RPG_GAME)

## Overview

**RPG_GAME** is an open-source role-playing game project developed primarily in **C++** and **C#** for Unreal Engine. This repository serves as a foundation for building an RPG with custom logic, dynamic content, and modular architecture.

---

## Repository Explanation

This repository is structured for Unreal Engine game development and contains:

- **Game Logic (`Source/`):**  
  The core gameplay mechanics, character management, combat systems, and other features are implemented in native C++ and C#. This allows for high performance and deep customization.

- **Assets (`Content/`):**  
  All visual, audio, and interactive assets such as models, textures, animations, and sound effects are stored here following Unreal Engine conventions.

- **Configuration (`Config/`):**  
  Contains game configuration files that control aspects like input bindings, game rules, and engine settings.

- **Project & Build Files:**  
  - `RPG_GAME.uproject` — Unreal Engine project descriptor. Open this in Unreal Engine to start developing or playing.
  - `Makefile` — Automates build steps for developers who prefer command-line workflows.
  - `.gitignore`, `.ignore` — Files specifying what should be excluded from version control.
  - `.vscode/`, `.idea/` — Project and editor configuration for VS Code and JetBrains IDEs (including Rider).

---

## Technologies Used

- **C++:** Main language for game logic and performance-critical features.
- **C#:** Used where appropriate for scripting and tooling.
- **Unreal Engine:** Provides the engine core, editor, and asset pipeline.
- **Makefile:** For build automation.
- **JetBrains Rider:** Supported editors/IDEs for programming.  
  - JetBrains Rider support is included via `.idea/` for a seamless C++/C# Unreal development experience.

---

## Getting Started

1. **Clone the Repository**
   ```bash
   git clone https://github.com/shresthasameerman/RPG_GAME.git
   ```
2. **Open in Unreal Engine**
   - Double-click `RPG_GAME.uproject` or open it from the Unreal Engine editor.

3. **Build the Project**
   - Use Unreal Engine’s build tools or the included `Makefile`.
   - For code editing, open the provided VS Code workspace (`RPG_GAME.code-workspace`) or use JetBrains Rider or your preferred IDE.

---



## License

**No explicit license is currently specified.**

---

## Maintainer

- [shresthasameerman](https://github.com/shresthasameerman)

---

*This README provides an explanation and usage instructions for the RPG_GAME repository. For more details on the game, its story, or gameplay mechanics, please refer to additional documentation or reach out to the maintainer.*
