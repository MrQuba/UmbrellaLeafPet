using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UmbrellaLeafPet.Content
{ 
	public class GreenUmbrella : ModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.BoneKey);	
			Item.value = Item.sellPrice(gold: 1);
			Item.buffType = ModContent.BuffType<LeafBuff>();
			Item.shoot = ModContent.ProjectileType<UmbrellaLeaf>();
		}
		public override bool? UseItem(Player player)
		{
			if (player.whoAmI == Main.myPlayer)
			{
				player.AddBuff(Item.buffType, 3600);
			}
			return true;
		}
	}
}
