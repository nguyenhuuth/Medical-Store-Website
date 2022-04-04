using MedicalStore.Utils.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MedicalStore.Utils
{
    public class Config : IConfig
    {
        private readonly IWebHostEnvironment ENV;
        public Config(IWebHostEnvironment env)
        {
            this.ENV = env;
        }

        public string GetEnvByKey(string name)
        {
            string currentEnv = this.ENV.EnvironmentName.ToLower();
            string envFileName = "env." + currentEnv + ".json";
            string envPath = Path.Combine(Directory.GetCurrentDirectory(), "config") + "/" + envFileName;

            IConfiguration configs = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(envPath, true, true).Build();
            return configs[name];
        }
    }
}
