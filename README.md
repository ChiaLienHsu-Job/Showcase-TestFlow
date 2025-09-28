# Showcase-TestFlow

[![Build](https://github.com/ChiaLienHsu-Job/Showcase-TestFlow/actions/workflows/ci.yml/badge.svg)](https://github.com/ChiaLienHsu-Job/Showcase-TestFlow/actions/workflows/ci.yml)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

A simplified **WinForms test tool**, demonstrating how to launch Windows Forms from a Console App, integrated with GitHub Actions for continuous integration (CI).

---

## ✨ Features
- Display a **Welcome window**
- Clicking the **Welcome button** → shows a "Hello World!" dialog (with OK button)

---

## 🔧 Tech Highlights
- .NET 8.0 (Windows)
- Windows Forms (WinForms)
- GitHub Actions CI/CD  
  - Automated build  
  - Build status badge  
  - Extensible for testing and release workflows

---

## ▶️ How to Run
```bash
cd src/TestFlowApp
dotnet run
```

When executed, a window with a **Welcome button** will appear.  
Clicking the button will pop up a **Hello World!** dialog.

---

## 📂 Project Structure
```
Showcase-TestFlow/
├── .github/workflows/ci.yml   # GitHub Actions workflow (CI)
├── src/TestFlowApp/           # Source code
│   └── Program.cs             # Main entry point
├── tests/                     # (Reserved) Unit tests
├── README.md                  # Project documentation
├── CHANGELOG.md               # Version history
└── LICENSE                    # MIT License
```

---

## 🚀 CI/CD Workflow
This repository includes a simple **build workflow**:  

- **Trigger**: on `push` to `master`  
- **Steps**:
  1. Use `windows-latest` runner  
  2. Install .NET 8.0  
  3. Build the project  

You can check the latest build results in the [Actions tab](https://github.com/ChiaLienHsu-Job/Showcase-TestFlow/actions).

---

## 📸 Screenshots (Optional)
Add screenshots or demo images here for better visualization, e.g.:

```
docs/screenshot.png
```

---

## 📜 Changelog
See [CHANGELOG.md](CHANGELOG.md) for version history.

---

## 📄 License
This project is licensed under the [MIT License](LICENSE).
