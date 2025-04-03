namespace NewProject.Services
{
    public class ScopedService : IScopedService
    {
        void DOWork()
        {
            Console.WriteLine("Scoped called...");
        }

        void IScopedService.DOWork()
        {
            DOWork();
        }
    }
}
