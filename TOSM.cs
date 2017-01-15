using Terraria.ModLoader;
using TOSM.Items;
using TOSM;

namespace TOSM
{
	class TOSM : Mod
	{
		public TOSM()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}