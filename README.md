# <img src="App.Bs.Barcode.Wpf.Ui/img/bs.png" alt="Logo" width="26" height="26" /> BarcodeQRCodeSKD

<p align="center">
  <strong>Emulate a barcode scanner by sending keystrokes to any application.</strong><br/>
  Built with WPF + WPF-UI (Fluent / Windows 11 style)
</p>

---

## ✨ Features

- **Barcode scanner emulation** — sends keystrokes to the active window, just like a real scanner
- **Multiple barcode types** — UPC-A, EAN-13, EAN-8, Code39, and free text
- **QR Code generation** — with optional custom icon overlay in the center
- **Live preview** — switch between barcode and QR code visualization
- **Print support** — print barcodes/QR codes directly
- **Configurable hotkey** — trigger sending with any key combination
- **Adjustable send delay** — countdown timer before keystrokes are sent (1–10 seconds)
- **Dark / Light theme** — Windows 11 Fluent Design with theme switching
- **Custom branding** — support for custom logos (dark/light) and QR icon overlay

## 📸 Screenshots

<!-- Add screenshots here -->

## 🚀 Getting Started

### Prerequisites

- Windows 10/11
- [.NET 10 SDK](https://dotnet.microsoft.com/download)

### Build & Run

```bash
git clone https://github.com/AdrianBinarysoft/barcode-simulator.git
cd barcode-simulator
dotnet run --project App.Bs.Barcode.Wpf.Ui
```

## 📖 How to Use

1. **Add barcodes** — type or paste a barcode string and click **Add**
2. **Configure hotkey** — set the key combination (default: `Ctrl+\`) and click **Register**
3. **Switch to target app** — click into the field where you want the barcode typed
4. **Press the hotkey** — the simulator waits the configured delay, then types the next code
5. **Repeat** — each press sends the next item in the list, cycling back to the first

## 🔢 Supported Barcode Types

| Type | Example | Description |
|------|---------|-------------|
| **UPC-A** | `036000291452` | 12-digit Universal Product Code |
| **EAN-13** | `5030917071027` | 13-digit European Article Number |
| **EAN-8** | `73513537` | 8-digit European Article Number |
| **Code39** | `*HELLO*` | Alphanumeric, wrapped in asterisks |
| **Text** | `anything else` | Free text (sent as keystrokes) |

## ⚙️ Configuration

| Setting | Description |
|---------|-------------|
| **Hotkey** | Keyboard shortcut to trigger sending (Ctrl/Alt/Shift/Win + key) |
| **Delay (ms)** | Pause between each keystroke in milliseconds |
| **Ends with** | Optional key sent after the barcode (e.g. Enter, Tab) |
| **Send Delay** | Seconds to wait before typing starts (1–10s, with countdown) |

## 🎨 Branding

Place custom images in the `Branding/` folder in the application directory:

| File | Purpose |
|------|---------|
| `LogoDark.png` | App icon shown in dark theme |
| `LogoLight.png` | App icon shown in light theme |
| `QrIcon.png` | Icon overlaid in the center of generated QR codes |

## 🏗️ Project Structure

```
barcode-simulator/
├── App.Bs.Barcode/              # Core barcode detection library
│   └── Barcode.cs               # Type detection (UPC-A, EAN-13, EAN-8, Code39)
├── App.Bs.Barcode.Wpf.Ui/      # WPF application (WPF-UI / Fluent Design)
│   ├── MainWindow.xaml          # Custom chrome window with tab bar
│   ├── BarcodeSimulatorControl  # Main simulator tab
│   ├── SettingsControl          # Theme & branding settings
│   ├── ReadmeControl            # In-app documentation
│   └── img/                     # Embedded icons
└── BarcodeSimulator/            # Legacy .NET Framework project
```

## 🛠️ Tech Stack

- **.NET 10** (Windows)
- **WPF** with [WPF-UI 3.0](https://github.com/lepoco/wpfui) (Fluent / Windows 11 controls)
- **QRCoder** for QR code generation
- **Custom WindowChrome** title bar with inline tabs

## 📄 License

<!-- Add your license here -->

## 👤 Author

**BinarySoft**

- GitHub: [@michaelmnich](https://github.com/michaelmnich/BarcodeSimulator)
