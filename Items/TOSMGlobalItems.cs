using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TOSM.Items
{
	public class TOSMGlobalNPC : GlobalNPC
	{
		public override void SetupShop(int type, Chest shop, ref int nextSlot)
		{
			if (type == NPCID.Wizard)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("Cookie"));
				nextSlot++;
			}
		}
	}
}