using Terraria;
using Terraria.ModLoader;

namespace UmbrellaLeafPet.Content
{
	public class LeafBuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			Main.buffNoSave[Type] = false;
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}
		public override void Update(Player player, ref int buffIndex)
		{ 
			bool unused = false;
			player.BuffHandle_SpawnPetIfNeededAndSetTime(buffIndex, ref unused, ModContent.ProjectileType<UmbrellaLeaf>());
		}
	}
}
