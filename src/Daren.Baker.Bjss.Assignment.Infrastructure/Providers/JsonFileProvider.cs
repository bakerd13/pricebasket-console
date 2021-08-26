using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daren.Baker.Bjss.Assignment.Infrastructure.Providers
{
    internal class JsonFileProvider<T> : IJsonFileProvider<T> where T : new()
    {
        private readonly IHostEnvironment _environment;
        public JsonFileProvider(IHostEnvironment environment)
        {
            _environment = environment;
        }

        public T Get(string file, string section)
        {
            var fileProvider = _environment.ContentRootFileProvider;
            var fileInfo = fileProvider.GetFileInfo(file);
            var physicalPath = fileInfo.PhysicalPath;

            var jObject = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(physicalPath));

            return jObject.TryGetValue(section, out JToken sectionObject) ?
                JsonConvert.DeserializeObject<T>(sectionObject.ToString()) : new T();
        }
    }
}
