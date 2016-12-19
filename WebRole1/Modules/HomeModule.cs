using Nancy;

namespace WebRole1.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = parameters => "Hello world!";
        }
    }
}