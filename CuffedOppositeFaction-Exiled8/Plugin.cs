using CommandSystem;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CuffedOppositeFaction_Exiled8
{
    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "6hundred9";
        public override string Name { get; } = "Cuffed Opposite Faction";
        public override string Prefix { get; } = "COF";
        public override Version RequiredExiledVersion { get; } = new Version(8, 8, 0);

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.Escaping += PlayerHandler.OnEscape;
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Escaping -= PlayerHandler.OnEscape;
        }

    }
}
