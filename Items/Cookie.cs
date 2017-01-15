using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TOSM.Items
{
	public class Cookie : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Cookie";
			item.width = 15;
			item.height = 15;
			item.toolTip = "Have a cookie";
			item.toolTip2 = "These are Happy Days";
			item.useTurn = true;
			item.consumable = true;
			item.useAnimation = 17;
			item.useTime = 17;
			item.useStyle = 2;
			item.useTurn = true;
			item.rare = 1;
			item.autoReuse = true;
			item.maxStack = 30;
			item.buffType = 26;
			item.buffTime = 3600;
			item.value = 10000;
		}
		Player player = Main.player[Main.myPlayer];

		public override bool CanUseItem(Player player)
		{
			return true;
		}
	}
}
// by imkSushi