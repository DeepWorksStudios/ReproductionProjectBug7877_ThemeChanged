using Android.App;
using Android.Content.PM;
using Android.OS;
using System.Diagnostics;

namespace ReproductionProjectBug_7877;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    #region Singleton
    private static MainActivity _androidInstance;
    public static MainActivity AndroidInstance { get { return _androidInstance; } }
    #endregion

    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        _androidInstance = new MainActivity();
    }
  
    //Not Working Nativ Call
    protected override void OnNightModeChanged(int mode)
    {
        base.OnNightModeChanged(mode);
        System.Diagnostics.Debug.WriteLine("OnNightMode Changed Call");
    }
    //Manual Call
    public void OnNightModeChangedManual(bool darkMode)
    {
        
        System.Diagnostics.Debug.WriteLine("OnNightModeChanged Manual Call");
    }
}
