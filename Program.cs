using library_management_system.src.entry_controls;
using library_management_system.src.startup;

internal class Program
{
    private static void Main(string[] args)
    {
        Startup startup = new Startup();
        ShouldExit shouldExit = new ShouldExit();
        shouldExit.ShouldTerminate = false;

        startup.WelcomeMessage();
        startup.DisplayOptions();

        while(!shouldExit.ShouldTerminate){
            
        }
    }
}