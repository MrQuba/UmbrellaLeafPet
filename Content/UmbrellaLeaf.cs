using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UmbrellaLeafPet.Content
{
	public class UmbrellaLeaf : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			Main.projPet[Projectile.type] = true;
			Main.projFrames[Projectile.type] = 4;
			ProjectileID.Sets.CharacterPreviewAnimations[Projectile.type] = ProjectileID.Sets.SimpleLoop(0, Main.projFrames[Projectile.type], 6)
				.WithOffset(-100f, -50f)
				.WithSpriteDirection(-1)
				.WithCode(DelegateMethods.CharacterPreview.Float);

		}
		public override void SetDefaults()
		{
			Projectile.CloneDefaults(ProjectileID.ZephyrFish);
			Projectile.scale = 0.25f;
			AIType = ProjectileID.ZephyrFish;
		}
		public override bool PreAI()
		{
			Player player = Main.player[Projectile.owner];
			player.zephyrfish = false;
			return true;
		}
		public override void AI()
		{
			Player player = Main.player[Projectile.owner];

			if (!player.dead && player.HasBuff(ModContent.BuffType<LeafBuff>()))
			{
				Projectile.timeLeft = 2;
			}
		}
	}
}
