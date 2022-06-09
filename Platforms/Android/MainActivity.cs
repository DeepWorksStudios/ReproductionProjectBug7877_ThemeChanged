using Android.App;
using Android.Content.PM;
using Android.OS;
using System.Diagnostics;

namespace ReproductionProjectBug_7877;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnNightModeChanged(int mode)
    {
        base.OnNightModeChanged(mode);
        System.Diagnostics.Debug.WriteLine("OnNightMode Changed Call");
    }
}
