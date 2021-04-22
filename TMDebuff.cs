using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TM.Buffs 
{
    class TMDebuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("TM debuff");
            
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            
            for (int i = 0; i <=100; i++ )
            {
                //float velXMult = 1f;

                //npc.velocity.X *= velXMult;

                float velYmult = 5f;

                npc.velocity.Y -= velYmult;
            }
            
            
        }
    }
}
