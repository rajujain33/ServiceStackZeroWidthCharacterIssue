using ServiceStack;
using WebApplication1.ServiceModel;

namespace WebApplication1.ServiceInterface
{
    public class MyServices : Service
    {
        public object Post(Hello request)
        {
            string str = request.Name as string;
            char s = str[0];
            return string.IsNullOrWhiteSpace(str);
        }
    }
}