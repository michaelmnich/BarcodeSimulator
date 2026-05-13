# <img src="App.Bs.Barcode.Wpf.Ui/img/bs.png" alt="Logo" width="26" height="26" /> BarcodeQRCodeSKD

**Emulate a barcode scanner by sending keystrokes to any application.**

Built with WPF + [WPF-UI](https://github.com/lepoco/wpfui) · Fluent / Windows 11 style

[![.NET 10](https://img.shields.io/badge/.NET-10-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![WPF-UI](https://img.shields.io/badge/WPF--UI-3.0-0078D4?logo=windows&logoColor=white)](https://github.com/lepoco/wpfui)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Platform](https://img.shields.io/badge/Platform-Windows-blue?logo=windows&logoColor=white)]()

</div>

<img width="2500" height="1700" alt="Layout" src="https://github.com/user-attachments/assets/34832786-ca10-431b-ac0c-6316c39b332a" />


## ✨ Features

| | Feature | Description |
|---|---|---|
| ⌨️ | **Scanner emulation** | Sends keystrokes to the active window — just like a real scanner |
| 📊 | **Multiple barcode types** | UPC-A, EAN-13, EAN-8, Code39, and free text |
| 📱 | **QR Code generation** | With optional custom icon overlay in the center |
| 👁️ | **Live preview** | Switch between barcode and QR code visualization |
| 🖨️ | **Print support** | Print barcodes / QR codes directly |
| 🎹 | **Configurable hotkey** | Trigger sending with any key combination |
| ⏱️ | **Adjustable delay** | Countdown timer before keystrokes are sent (1–10 s) |
| 🎨 | **Dark / Light theme** | Windows 11 Fluent Design with theme switching |
| 🏷️ | **Custom branding** | Support for custom logos (dark/light) and QR icon overlay |

## 📸 Screenshots

### Main screen

<img width="845" height="466" alt="Main" src="https://github.com/user-attachments/assets/57c7efe2-015d-4e86-a962-1653a215825f" />

### Setting screen

<img width="845" height="466" alt="Settings" src="https://github.com/user-attachments/assets/bf87be37-3966-49ae-90f2-6a12527fac87" />

## 🚀 Getting Started

> **Prerequisites:** Windows 10/11 · [.NET 10 SDK](https://dotnet.microsoft.com/download)

```bash
git clone https://github.com/michaelmnich/BarcodeSimulator.git
cd BarcodeSimulator
dotnet run --project App.Bs.Barcode.Wpf.Ui
```

## 📖 How to Use

```
1 │ Type or paste a barcode string and click Add
2 │ Configure the hotkey (default: Ctrl+\) and click Register
3 │ Switch to the target application (e.g. a form field)
4 │ Press the hotkey — the simulator waits, then types the next code
5 │ Each press sends the next item in the list, cycling back to the first
```

## 🔢 Supported Barcode Types

```
 Type      Example          Description
 ───────── ──────────────── ──────────────────────────────────
 UPC-A     036000291452     12-digit Universal Product Code
 EAN-13    5030917071027    13-digit European Article Number
 EAN-8     73513537          8-digit European Article Number
 Code39    *HELLO*          Alphanumeric, wrapped in asterisks
 Text      anything else    Free text (sent as keystrokes)
```

## ⚙️ Configuration

| Setting | Description |
|:--|:--|
| **Hotkey** | Keyboard shortcut to trigger sending (`Ctrl`/`Alt`/`Shift`/`Win` + key) |
| **Delay (ms)** | Pause between each keystroke in milliseconds |
| **Ends with** | Optional key sent after the barcode (e.g. `Enter`, `Tab`) |
| **Send Delay** | Seconds to wait before typing starts (1–10 s, with countdown) |

## 🎨 Branding

Place custom images in the `Branding/` folder next to the executable:

```
Branding/
├── LogoDark.png    → App icon shown in dark theme
├── LogoLight.png   → App icon shown in light theme
└── QrIcon.png      → Icon overlaid in center of generated QR codes
```

## 🏗️ Project Structure

```
BarcodeSimulator/
│
├── App.Bs.Barcode/                # Core barcode detection library
│   └── Barcode.cs                 #   Type detection (UPC-A, EAN-13, EAN-8, Code39)
│
├── App.Bs.Barcode.Wpf.Ui/        # WPF application (Fluent Design)
│   ├── MainWindow.xaml            #   Custom chrome window with tab bar
│   ├── BarcodeSimulatorControl    #   Main simulator tab
│   ├── SettingsControl            #   Theme & branding settings
│   ├── ReadmeControl              #   In-app documentation
│   └── img/                       #   Embedded icons
│
└── BarcodeSimulator/              # Legacy .NET Framework project
```

## 🛠️ Tech Stack

<table>
  <tr>
    <td align="center"><img src="https://img.shields.io/badge/.NET_10-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt=".NET 10"/></td>
    <td>Runtime & SDK</td>
  </tr>
  <tr>
    <td align="center"><img src="https://img.shields.io/badge/WPF--UI_3.0-0078D4?style=flat-square&logo=windows&logoColor=white" alt="WPF-UI"/></td>
    <td>Fluent / Windows 11 controls</td>
  </tr>
  <tr>
    <td align="center"><img src="https://img.shields.io/badge/QRCoder-333?style=flat-square" alt="QRCoder"/></td>
    <td>QR code generation</td>
  </tr>
  <tr>
    <td align="center"><img src="https://img.shields.io/badge/WindowChrome-555?style=flat-square" alt="WindowChrome"/></td>
    <td>Custom title bar with inline tabs</td>
  </tr>
</table>

## 📄 License

Distributed under the **MIT** License. See [`LICENSE`](LICENSE) for details.

## 👤 Author

**BinarySoft** · [@michaelmnich](https://github.com/michaelmnich)

---

<div align="center">
  <sub>Built with ❤️ by BinarySoft</sub>
</div>
