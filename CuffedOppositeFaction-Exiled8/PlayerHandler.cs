using Exiled.API.Features.Roles;
using Exiled.Events.EventArgs.Player;
using PluginAPI.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuffedOppositeFaction_Exiled8
{
    internal class PlayerHandler
    {

        public static void OnEscape(EscapingEventArgs ev)
        {
            if (ev.Player.IsNTF && ev.Player.IsCuffed)
            {
                ev.NewRole = PlayerRoles.RoleTypeId.ChaosConscript;
            }
            if (ev.Player.IsCHI && ev.Player.IsCuffed)
            {
                ev.NewRole = PlayerRoles.RoleTypeId.NtfSpecialist;
            }
        }

    }
}
