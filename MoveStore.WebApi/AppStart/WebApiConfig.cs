using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using Newtonsoft.Json;

namespace MoveStore.WebApi.AppStart
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Services.Replace(typeof(IAssembliesResolver), new AssembliesResolver());
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.JsonFormatter.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
        }
    }

    public class AssembliesResolver:IAssembliesResolver
    {
        public ICollection<Assembly> GetAssemblies()
        {
            return new List<Assembly> {GetType().Assembly};
        }
    }
}
