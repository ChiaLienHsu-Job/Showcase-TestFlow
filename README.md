# Showcase-TestFlow

[![Build](https://github.com/ChiaLienHsu-Job/Showcase-TestFlow/actions/workflows/ci.yml/badge.svg)](https://github.com/ChiaLienHsu-Job/Showcase-TestFlow/actions/workflows/ci.yml)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

一個簡化的 **WinForms 測試工具**，展示如何從 Console App 呼叫 Windows Forms，並透過 GitHub Actions 進行自動化建置。

---

## ✨ 功能

- 顯示 **Welcome 視窗**
- 點擊 **Welcome 按鈕** → 彈出 "Hello World!" 視窗（含 OK 按鈕）

---

## 🔧 技術重點

- .NET 8.0 (Windows)
- Windows Forms (WinForms)
- GitHub Actions CI/CD  
  - 自動化編譯  
  - Build 成功狀態徽章  
  - 未來可擴展加入測試 / 發布流程

---

## ▶️ 如何執行

```bash
cd src/TestFlowApp
dotnet run
