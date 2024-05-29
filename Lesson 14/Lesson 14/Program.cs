namespace Lesson_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PluginManager pluginManager = new PluginManager();
            IPlug calculatorPlugin = new CalculatorPlugin();
            IPlug greetingPlugin = new GreetingPlugin();
            pluginManager.LoadPlugin(calculatorPlugin);
            pluginManager.LoadPlugin(greetingPlugin);
            pluginManager.ExecutePlugins();
        }
    }
}
