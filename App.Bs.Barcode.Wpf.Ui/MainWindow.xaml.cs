using System.Windows;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace App.Bs.Barcode.Wpf.Ui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApplicationThemeManager.Changed += OnThemeChanged;
            Closed += (_, _) => ApplicationThemeManager.Changed -= OnThemeChanged;
            Loaded += (_, _) => UpdateAppIcon();
        }

        private void OnThemeChanged(ApplicationTheme currentApplicationTheme, System.Windows.Media.Color systemAccent)
        {
            WindowBackgroundManager.UpdateBackground(this, currentApplicationTheme, WindowBackdropType.None);
            UpdateAppIcon();
        }


        private void UpdateAppIcon() => appIcon.Source = BrandingHelper.GetThemedLogo();

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Tab_Click(object sender, RoutedEventArgs e)
        {
            if (sender is System.Windows.Controls.RadioButton rb && rb.Tag is string tag)
            {
                var index = int.Parse(tag);
                simulatorPage.Visibility = index == 0 ? Visibility.Visible : Visibility.Collapsed;
                settingsPage.Visibility = index == 1 ? Visibility.Visible : Visibility.Collapsed;
                readmePage.Visibility = index == 2 ? Visibility.Visible : Visibility.Collapsed;
            }
        }
    }
}