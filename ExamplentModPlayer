using Terraria.DataStructures;
using Terraria.ModLoader;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Initializers;
using Terraria.IO;
using Terraria.GameContent;

namespace ExamplentMod
{
    //How do i add custom death messages for my projectile and NPC?
    public class ExamplentModPlayer : ModPlayer //this is a mod player class.
    {
        public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
            //Projectile:
            if (damageSource.SourceProjectileType == mod.ProjectileType("ExamplentProjectile"))
            {
                damageSource = PlayerDeathReason.ByCustomReason(player.name + "seems to die to a projectile."); // changes death message
            }
            //NPC:
            if (damageSource.SourceNPCIndex >= 0 && Main.npc[damageSource.SourceNPCIndex].type == mod.NPCType("ExamplentModNPC"))
            {
                damageSource = PlayerDeathReason.ByCustomReason(player.name + " was killed by an example npc.");
            }
            return true; //don't forget this or ur tmod detects it as an error
        }
    }
}
