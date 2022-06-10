namespace ReproductionProjectBug_7877;

public partial class App : Application
{
   
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();

#if ANDROID
        Application.Current.RequestedThemeChanged += Android_ThemeChanged;
#endif

    }

    private void Android_ThemeChanged(object sender, AppThemeChangedEventArgs args)
    {
        if (MainActivity.AndroidInstance == null) return;

        bool darkState = Application.Current.RequestedTheme == AppTheme.Dark ? true : false;
        MainActivity.AndroidInstance.OnNightModeChangedManual(darkState);
    }


}
