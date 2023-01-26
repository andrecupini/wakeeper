using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace wakeeper
{
    internal class ConfigManager
    {
        private string fileName;
        private Dictionary<string, string> config;
        private Serializer serializer;
        private Deserializer deserializer;

        public ConfigManager(string fileName)
        {
            this.fileName = fileName;
            config = new Dictionary<string, string>();
            serializer = new Serializer();
            deserializer = new Deserializer();
        }

        public void Load()
        {
            if (!File.Exists(fileName))
            {
                config["idleTimeout"] = "60";
                File.Create(fileName).Dispose();
                var serializer = new Serializer();
                File.WriteAllText(fileName, serializer.Serialize(config));
            }

            config = deserializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(fileName));
        }

        public void Save()
        {
            File.WriteAllText(fileName, serializer.Serialize(config));
        }

        public string GetValue(string key)
        {
            return config[key];
        }

        public void SetValue(string key, string value)
        {
            config[key] = value;
        }
    }
}
