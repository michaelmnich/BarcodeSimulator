using System;
using System.Windows.Forms;

namespace App.Bs.Barcode.Wpf.Ui;

/// <summary>
/// A hidden WinForms control that forwards WM_HOTKEY messages 
/// to the WinForms IMessageFilter infrastructure.
/// Required because WPF does not run the WinForms message pump,
/// so IMessageFilter.PreFilterMessage is never called.
/// </summary>
internal sealed class HotkeyMessageControl : Control
{
    private const int WM_HOTKEY = 0x0312;

    public event Action<Message>? HotkeyMessageReceived;

    protected override void WndProc(ref Message m)
    {
        if (m.Msg == WM_HOTKEY)
        {
            HotkeyMessageReceived?.Invoke(m);
        }
        base.WndProc(ref m);
    }
}
