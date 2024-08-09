    using Exiled.API.Features;
    using Exiled.API.Enums;
    using System.Collections.Generic;
    using PlayerRoles;
    using System.Runtime.InteropServices;
    using System;
    using MEC;
    using Exiled.Events.Handlers;
    using Exiled.CustomItems.API.Features;

namespace JailbirdRepair
{
    public abstract class JailbirdRepair : Plugin<PluginConfig>
    {
        public override string Author { get; } = "Mr. Baguetter";
        public override string Name { get; } = "JailbirdRepair";
        public override string Prefix { get; } = "JailbirdRepairing";
        public override Version Version { get; } = new(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new(8, 11, 0);
        public override PluginPriority Priority => PluginPriority.Default;
        public EventHandler EventHandlers;
        public List<CoroutineHandle> Coroutines = new List<CoroutineHandle>();    

        
        public static JailbirdRepair Instance;


        public override void OnEnabled()
        {
            Instance = this;
            EventHandlers = new EventHandler();
            Exiled.Events.Handlers.Server.RoundStarted += EventHandlers.OnStart;
            Exiled.Events.Handlers.Server.RoundEnded += EventHandlers.OnRoundEnd;

            CustomItem.RegisterItems();
        }

        public override void OnDisabled()
        {
            EventHandlers = null;
            Instance = null;
            Exiled.Events.Handlers.Server.RoundStarted -= EventHandlers.OnStart;
            Exiled.Events.Handlers.Server.RoundEnded += EventHandlers.OnRoundEnd; ///:3
            CustomItem.UnregisterItems();
        }
    }
}
        
        

