namespace ConsoleAppWithDependancyInjection.services
{

    public interface IApplication
    {
        public void Run();
    }

    internal class Application : IApplication
    {
        public void Run()
        {
            Console.WriteLine("Hello, World from the Application class!");
        }
    }
}