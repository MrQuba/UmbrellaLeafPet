using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
namespace UmbrellaLeafPet.Content
{
    public class Shop : GlobalNPC
    {
        public override bool AppliesToEntity(NPC npc, bool lateInstantiation)
        {
            return npc.type == NPCID.Dryad;
        }

        public override void ModifyShop(NPCShop shop)
        {
            int type = shop.NpcType;
            if(type == NPCID.Dryad)
            {
		shop.Add(ModContent.ItemType<GreenUmbrella>());
            }
        }
    }
}
