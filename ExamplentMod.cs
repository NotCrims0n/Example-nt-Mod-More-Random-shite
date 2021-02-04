using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ExamplentMod
{
	public class ExamplentMod : Mod
	{
		public static ModHotKey KillYourselfButton;
		public override void Load()
		{
			Logger.InfoFormat("{0} examplent logging", Name);
			SkillOneHotKey = RegisterHotKey("Kill Yourself Button", "L"); //registers hotkey in the Controls settings.
			//keep in mind players have to assign the hotkey for it to work, you cannot do it automatically.
		}
	}
}
