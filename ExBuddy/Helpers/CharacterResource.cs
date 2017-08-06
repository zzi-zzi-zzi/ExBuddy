using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ff14bot.Enums;
using ff14bot.Managers;
using ff14bot.NeoProfiles;
using ff14bot.Objects;

namespace ExBuddy.Helpers
{
    public static class CharacterResource
    {
        public static int GetGpPerTick()
        {
            return (Me.CurrentJob == ClassJobType.Miner && ConditionParser.IsQuestCompleted(68094))
                || (Me.CurrentJob == ClassJobType.Botanist && ConditionParser.IsQuestCompleted(68160))
                || (Me.CurrentJob == ClassJobType.Fisher && ConditionParser.IsQuestCompleted(68435))
                ? 6
                : 5;
        }

        public static int GetEffectiveGp(int ticksTillGather)
        {
            return GetEffectiveGp(ticksTillGather, GetGpPerTick());
        }

        public static int GetEffectiveGp(int ticksTillGather, int gpPerTick)
        {
            if (ticksTillGather <= 0)
            {
                return Me.CurrentGP;
            }

            return Math.Min(Me.CurrentGP + (ticksTillGather * gpPerTick), Me.MaxGP);
        }

        private static LocalPlayer Me
        {
            get { return GameObjectManager.LocalPlayer; }
        }
    }
}
