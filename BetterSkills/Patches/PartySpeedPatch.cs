using BetterCore.Utils;
using HarmonyLib;
using System;
using System.Linq;
using System.Reflection;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.ComponentInterfaces;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;

namespace BetterSkills.Patches
{
    class PartySpeedPatch {
        private static bool patched = false;

        public static bool PatchPartySpeedModel(Harmony harmonyInstance) {
            try {
                var targetType = typeof(DefaultPartySpeedCalculatingModel);
                var methodName = nameof(DefaultPartySpeedCalculatingModel.CalculateFinalSpeed);
                var parameterTypes = new Type[]
                {
                    typeof(MobileParty),
                    typeof(ExplainedNumber)
                };
                MethodInfo postfixMethod = typeof(PartySpeedPatch).GetMethod("CalculateFinalSpeedPostfix");
                BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

                MethodInfo methodInfo = (parameterTypes != null) ? targetType.GetMethod(methodName, flags, null, parameterTypes, null) : targetType.GetMethod(methodName);
                bool flag = methodInfo == null;
                if (flag) {
                    NotifyHelper.WriteError("PartySpeedPatch", "Harmony Patch Failed: " + targetType.Name + "." + methodName);
                }
                else {
                    HarmonyMethod postfix = new HarmonyMethod(postfixMethod);
                    harmonyInstance.Patch(methodInfo, null, postfix, null, null);
#if DEBUG
                     NotifyHelper.WriteMessage("PartySpeedPatch: Harmony Patch Completed: " + targetType.Name, MsgType.Notify);
#endif
                }
            }
            catch (Exception e) {
                NotifyHelper.WriteError("PartySpeedPatch", $"Failed to patch PartySpeedModel: {e} \nInner: {e.InnerException}");
            }
            return true;
        }

        public static void CalculateFinalSpeedPostfix(MobileParty mobileParty, ref ExplainedNumber __result, ref DefaultPartySpeedCalculatingModel __instance) {
            try {
                if (mobileParty == null)
                    return;

                if (!mobileParty.IsActive)
                    return;

                // Only main party? (optional)
                if (!mobileParty.IsMainParty && BetterSkills.Settings.ScoutingBonusPlayerOnly)
                    return;

                Hero scout = mobileParty.EffectiveScout; // the assigned scout or best scout hero

                if (scout == null)
                    return;

                // Don't apply if on sea? or should it be based on an diffrent skill?
                if (mobileParty.IsCurrentlyAtSea)
                    return;

                int scouting = scout.GetSkillValue(DefaultSkills.Scouting);
                float bonus = scouting * BetterSkills.Settings.ScoutingBonus;

                // add both value and a tooltip line
                __result.Add(bonus, new TextObject("Scouting Skill Bonus"));
                __result.LimitMin(__instance.MinimumSpeed);
            }
            catch (Exception e) {
                NotifyHelper.WriteError("CalculateFinalSpeed", "threw exception " + e);
            }
        }
    }
}
