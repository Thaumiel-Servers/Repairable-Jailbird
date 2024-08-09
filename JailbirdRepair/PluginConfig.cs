using System.ComponentModel;
using Exiled.API.Interfaces;
using Exiled.API.Features;

namespace JailbirdRepair
{
    public class PluginConfig : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; };
        
    }
};