using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Input;

namespace App.Bs.Barcode.Wpf.Ui
{
    public partial class ReadmeControl : System.Windows.Controls.UserControl
    {
        public ReadmeControl()
        {
            InitializeComponent();
        }

        private void GithubLink_Click(object sender, MouseButtonEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/AdrianBinarysoft/barcode-simulator",
                UseShellExecute = true
            });
        }
    }
}
