using System;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Wpf.Ui.Appearance;

namespace App.Bs.Barcode.Wpf.Ui;

internal static class BrandingHelper
{
    private static readonly string BrandingFolder =
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Branding");

    /// <summary>
    /// Returns the appropriate logo <see cref="ImageSource"/> for the current theme,
    /// using the Branding folder if available, otherwise the embedded default.
    /// </summary>
    internal static ImageSource GetThemedLogo()
    {
        var isDark = ApplicationThemeManager.IsMatchedDark();
        var brandingFile = isDark ? "LogoDark.png" : "LogoLight.png";
        var brandingPath = Path.Combine(BrandingFolder, brandingFile);

        if (File.Exists(brandingPath))
        {
            var bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(brandingPath, UriKind.Absolute);
            bitmap.CacheOption = BitmapCacheOption.OnLoad;
            bitmap.EndInit();
            bitmap.Freeze();
            return bitmap;
        }

        var fallback = isDark ? "img/bsDark.png" : "img/bs.png";
        return new BitmapImage(new Uri($"pack://application:,,,/{fallback}"));
    }
}
