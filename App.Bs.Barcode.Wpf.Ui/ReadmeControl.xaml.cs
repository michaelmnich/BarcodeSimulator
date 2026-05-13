using System.Diagnostics;
using System.Windows.Input;
using Wpf.Ui.Appearance;

namespace App.Bs.Barcode.Wpf.Ui
{
    public partial class ReadmeControl : System.Windows.Controls.UserControl
    {
        public ReadmeControl()
        {
            InitializeComponent();
            ApplicationThemeManager.Changed += OnThemeChanged;
            Unloaded += (_, _) => ApplicationThemeManager.Changed -= OnThemeChanged;
            Loaded += (_, _) => UpdateLogos();
        }

        private void OnThemeChanged(ApplicationTheme currentApplicationTheme, System.Windows.Media.Color systemAccent)
        {
            UpdateLogos();
        }

        private void UpdateLogos()
        {
            headerLogo.Source = BrandingHelper.GetThemedLogo();
            footerLogo.Source = headerLogo.Source;
        }

        private void GithubLink_Click(object sender, MouseButtonEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/michaelmnich/BarcodeSimulator",
                UseShellExecute = true
            });
        }
    }
}
