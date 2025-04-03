namespace NewProject.Services
{
    public class SingletonService: ISingletonService
    {
        void DOWork() 
        {
            Console.WriteLine("Singleton called...");
        }

        void ISingletonService.DOWork()
        {
            DOWork();
        }
    }
}
