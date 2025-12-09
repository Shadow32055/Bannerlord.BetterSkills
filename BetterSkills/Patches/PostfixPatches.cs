using BetterCore.Utils;
using BetterSkills.Localizations;
using HarmonyLib;
using System;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using static HarmonyLib.AccessTools;

namespace BetterSkills.Patches
{

    [HarmonyPatch]
    class PostfixPatches
    {

        /*
		[HarmonyPrefix]
		[HarmonyPatch(typeof(SkillEffect), "GetPrimaryValue")]
		public static bool GetPrimaryValue(ref float __result, int skillLevel, ref float PrimaryBaseValue, ref float PrimaryBonus) {
			__result = Math.Max(0f, PrimaryBaseValue + PrimaryBonus * (float)skillLevel) * 100;

			return false;
		}*/

        static FieldRef<DefaultSkillEffects, SkillEffect> _effectOneHandedSpeed = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectOneHandedSpeed");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectOneHandedDamage = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectOneHandedDamage");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectTwoHandedSpeed = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectTwoHandedSpeed");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectTwoHandedDamage = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectTwoHandedDamage");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectPolearmSpeed = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectPolearmSpeed");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectPolearmDamage = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectPolearmDamage");

        static FieldRef<DefaultSkillEffects, SkillEffect> _effectBowDamage = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectBowDamage");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectBowAccuracy = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectBowAccuracy");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectThrowingSpeed = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectThrowingSpeed");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectThrowingDamage = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectThrowingDamage");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectThrowingAccuracy = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectThrowingAccuracy");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectCrossbowReloadSpeed = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectCrossbowReloadSpeed");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectCrossbowAccuracy = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectCrossbowAccuracy");

        static FieldRef<DefaultSkillEffects, SkillEffect> _effectHorseSpeed = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectHorseSpeed");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectHorseManeuver = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectHorseManeuver");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectMountedWeaponDamagePenalty = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectMountedWeaponDamagePenalty");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectMountedWeaponSpeedPenalty = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectMountedWeaponSpeedPenalty");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectDismountResistance = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectDismountResistance");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectAthleticsSpeedFactor = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectAthleticsSpeedFactor");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectAthleticsWeightFactor = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectAthleticsWeightFactor");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectKnockBackResistance = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectKnockBackResistance");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectKnockDownResistance = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectKnockDownResistance");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectSmithingLevel = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectSmithingLevel");

        static FieldRef<DefaultSkillEffects, SkillEffect> _effectTacticsAdvantage = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectTacticsAdvantage");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectTacticsTroopSacrificeReduction = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectTacticsTroopSacrificeReduction");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectTrackingRadius = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectTrackingRadius");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectTrackingSpottingDistance = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectTrackingSpottingDistance");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectTrackingTrackInformation = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectTrackingTrackInformation");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectRogueryLootBonus = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectRogueryLootBonus");

        static FieldRef<DefaultSkillEffects, SkillEffect> _effectCharmRelationBonus = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectCharmRelationBonus");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectTradePenaltyReduction = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectTradePenaltyReduction");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectLeadershipMoraleBonus = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectLeadershipMoraleBonus");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectLeadershipGarrisonSizeBonus = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectLeadershipGarrisonSizeBonus");

        static FieldRef<DefaultSkillEffects, SkillEffect> _effectSurgeonSurvivalBonus = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectSurgeonSurvivalBonus");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectHealingRateBonusForHeroes = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectHealingRateBonusForHeroes");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectHealingRateBonusForRegulars = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectHealingRateBonusForRegulars");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectGovernorHealingRateBonus = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectGovernorHealingRateBonus");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectSiegeEngineProductionBonus = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectSiegeEngineProductionBonus");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectTownProjectBuildingBonus = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectTownProjectBuildingBonus");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectStewardPartySizeBonus = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectStewardPartySizeBonus");


        static FieldRef<DefaultSkillEffects, SkillEffect> _effectSneakDamage = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectSneakDamage");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectCrouchedSpeed = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectCrouchedSpeed");
        static FieldRef<DefaultSkillEffects, SkillEffect> _effectNoiseSuppression = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectNoiseSuppression");

        private static SkillEffect _effectScoutingPartySpeed;
        //private static readonly SkillEffect _effectScoutingPartySpeed = NewSkillEffect();

        [HarmonyPostfix]
        [HarmonyPatch(typeof(DefaultSkillEffects), "InitializeAll")]
        public static void InitializeAll(DefaultSkillEffects __instance)
        {
            try
            {
                float minimumFactorClamp = -0.75f;          // limit min value to -0.75 (-75%), just to avoid negative numbers shenanigans 
                float minimumAddClamp = float.MinValue;     // limit min value for adding operation (needed?) 

                _effectOneHandedSpeed(__instance).Initialize(
                    new TextObject("{=hjxRvb9l}One handed weapon speed: +{a0}%", null),
                    DefaultSkills.OneHanded,
                    PartyRole.Personal,
                    BetterSkills.Settings.OneHandedSpeedValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectOneHandedDamage(__instance).Initialize(
                    new TextObject("{=baUFKAbd}One handed weapon damage: +{a0}%", null),
                    DefaultSkills.OneHanded,
                    PartyRole.Personal,
                    BetterSkills.Settings.OneHandedDamageValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectTwoHandedSpeed(__instance).Initialize(
                    new TextObject("{=Np94rYMz}Two handed weapon speed: +{a0}%", null),
                    DefaultSkills.TwoHanded,
                    PartyRole.Personal,
                    BetterSkills.Settings.TwoHandedSpeedValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectTwoHandedDamage(__instance).Initialize(
                    new TextObject("{=QkbbLb4v}Two handed weapon damage: +{a0}%", null),
                    DefaultSkills.TwoHanded,
                    PartyRole.Personal,
                    BetterSkills.Settings.TwoHandedDamageValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectPolearmSpeed(__instance).Initialize(
                    new TextObject("{=2ATI9qVM}Polearm weapon speed: +{a0}%", null),
                    DefaultSkills.Polearm,
                    PartyRole.Personal,
                    BetterSkills.Settings.PolearmSpeedValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectPolearmDamage(__instance).Initialize(
                    new TextObject("{=17cIGVQE}Polearm weapon damage: +{a0}%", null),
                    DefaultSkills.Polearm,
                    PartyRole.Personal,
                    BetterSkills.Settings.PolearmDamageValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectBowDamage(__instance).Initialize(
                    new TextObject("{=RUZHJMQO}Bow Damage: +{a0}%", null),
                    DefaultSkills.Bow,
                    PartyRole.Personal,
                    BetterSkills.Settings.BowDamageValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectBowAccuracy(__instance).Initialize(
                    new TextObject("{=sQCS90Wq}Bow Accuracy: +{a0}%", null),
                    DefaultSkills.Bow,
                    PartyRole.Personal,
                    BetterSkills.Settings.BowAccuracyValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);


                _effectThrowingSpeed(__instance).Initialize(
                    new TextObject("{=Z0CoeojG}Thrown weapon speed: +{a0}%", null),
                    DefaultSkills.Throwing,
                    PartyRole.Personal,
                    BetterSkills.Settings.ThrowingSpeedValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectThrowingDamage(__instance).Initialize(
                    new TextObject("{=TQMGppEk}Thrown weapon damage: +{a0}%", null),
                    DefaultSkills.Throwing,
                    PartyRole.Personal,
                    BetterSkills.Settings.ThrowingDamageValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectThrowingAccuracy(__instance).Initialize(
                    new TextObject("{=SfKrjKuO}Thrown weapon accuracy: +{a0}%", null),
                    DefaultSkills.Throwing,
                    PartyRole.Personal,
                    BetterSkills.Settings.ThrowingAccuracyValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectCrossbowReloadSpeed(__instance).Initialize(
                    new TextObject("{=W0Zu4iDz}Crossbow reload speed: +{a0}%", null),
                    DefaultSkills.Crossbow,
                    PartyRole.Personal,
                    BetterSkills.Settings.CrossbowReloadSpeedValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectCrossbowAccuracy(__instance).Initialize(
                    new TextObject("{=JwWnpD40}Crossbow accuracy: +{a0}%", null),
                    DefaultSkills.Crossbow,
                    PartyRole.Personal,
                    BetterSkills.Settings.CrossbowAccuracyValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectHorseSpeed(__instance).Initialize(
                    new TextObject("{=Y07OcP1T}Horse speed: +{a0}", null),
                    DefaultSkills.Riding,
                    PartyRole.Personal,
                    BetterSkills.Settings.HorseSpeedValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectHorseManeuver(__instance).Initialize(
                    new TextObject("{=AahNTeXY}Horse maneuver: +{a0}", null),
                    DefaultSkills.Riding,
                    PartyRole.Personal,
                    BetterSkills.Settings.HorseManeuverValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectMountedWeaponDamagePenalty(__instance).Initialize(
                    new TextObject("{=0dbwEczK}Mounted weapon damage penalty: {a0}%", null),
                    DefaultSkills.Riding,
                    PartyRole.Personal,
                    BetterSkills.Settings.MountWeaponDamagePenaltyValue,
                    EffectIncrementType.AddFactor,
                    -0.2f,
                    minimumFactorClamp, 
                    0.99f);

                _effectMountedWeaponSpeedPenalty(__instance).Initialize(
                    new TextObject("{=oE5etyy0}Mounted weapon speed & reload penalty: {a0}%", null),
                    DefaultSkills.Riding,
                    PartyRole.Personal,
                    BetterSkills.Settings.MountWeaponSpeedPenaltyValue,
                    EffectIncrementType.AddFactor,
                    -0.3f,
                    minimumFactorClamp,
                    0.99f);

                _effectDismountResistance(__instance).Initialize(
                    new TextObject("{=kbHJVxAo}Dismount resistance: {a0}% of max. hitpoints", null),
                    DefaultSkills.Riding,
                    PartyRole.Personal,
                    BetterSkills.Settings.DismountResistanceValue,
                    EffectIncrementType.AddFactor,
                    0.4f,
                    minimumFactorClamp);

                _effectAthleticsSpeedFactor(__instance).Initialize(
                    new TextObject("{=rgb6vdon}Running speed increased by {a0}%", null),
                    DefaultSkills.Athletics,
                    PartyRole.Personal,
                    BetterSkills.Settings.AthleticsSpeedFactorValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectAthleticsWeightFactor(__instance).Initialize(
                    new TextObject("{=WaUuhxwv}Weight penalty reduced by: {a0}%", null),
                    DefaultSkills.Athletics,
                    PartyRole.Personal,
                    BetterSkills.Settings.AthleticsWeightFactorValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectKnockBackResistance(__instance).Initialize(
                    new TextObject("{=TyjDHQUv}Knock back resistance: {a0}% of max. hitpoints", null),
                    DefaultSkills.Athletics,
                    PartyRole.Personal,
                    BetterSkills.Settings.KnockBackResistanceValue,
                    EffectIncrementType.AddFactor,
                    0.15f,
                    minimumFactorClamp);

                _effectKnockDownResistance(__instance).Initialize(
                    new TextObject("{=tlNZIH3l}Knock down resistance: {a0}% of max. hitpoints", null),
                    DefaultSkills.Athletics,
                    PartyRole.Personal,
                    BetterSkills.Settings.KnockDownResistanceValue,
                    EffectIncrementType.AddFactor,
                    0.4f,
                    minimumFactorClamp);

                _effectSmithingLevel(__instance).Initialize(
                    new TextObject("{=ImN8Cfk6}Max difficulty of weapon that can be smithed without penalty: {a0}%", null),
                    DefaultSkills.Crafting,
                    PartyRole.Personal,
                    BetterSkills.Settings.SmithingLevelValue,
                    EffectIncrementType.Add,
                    limitMin: minimumAddClamp);

                _effectTacticsAdvantage(__instance).Initialize(
                    new TextObject("{=XO3SOlZx}Simulation advantage: +{a0}%", null),
                    DefaultSkills.Tactics,
                    PartyRole.Personal,
                    BetterSkills.Settings.TacticsAdvantageValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectTacticsTroopSacrificeReduction(__instance).Initialize(
                    new TextObject("{=VHdyQYKI}Decrease the sacrificed troop number when trying to get away +{a0}%", null),
                    DefaultSkills.Tactics,
                    PartyRole.Personal,
                    BetterSkills.Settings.TacticsTroopSacrificeReductionValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectTrackingRadius(__instance).Initialize(
                    new TextObject("{=kqJipMqc}Track detection radius +{a0}%", null),
                    DefaultSkills.Scouting,
                    PartyRole.Scout,
                    BetterSkills.Settings.TrackingRadiusValue,
                    EffectIncrementType.Add,
                    limitMin: minimumAddClamp);

                _effectTrackingSpottingDistance(__instance).Initialize(
                    new TextObject("{=lbrOAvKj}Spotting distance +{a0}%", null),
                    DefaultSkills.Scouting,
                    PartyRole.Scout,
                    BetterSkills.Settings.TrackingSpottingDistanceValue,
                    EffectIncrementType.Add,
                    limitMin: minimumAddClamp);

                _effectTrackingTrackInformation(__instance).Initialize(
                    new TextObject("{=uNls3bOP}Track information level: {a0}", null),
                    DefaultSkills.Scouting,
                    PartyRole.Scout,
                    BetterSkills.Settings.TrackingTrackInformationValue,
                    EffectIncrementType.Add,
                    limitMin: minimumAddClamp);

                // new skill bonus
                try
                {
                    if (_effectScoutingPartySpeed == null)
                    {
                        _effectScoutingPartySpeed = Game.Current.ObjectManager
                            .RegisterPresumedObject<SkillEffect>(new SkillEffect("ScoutingPartySpeed"));
                    }

                    _effectScoutingPartySpeed.Initialize(
                        new TextObject(RefValues.ScoutingSkillBonusText + ": {a0}"),
                        DefaultSkills.Scouting,
                        PartyRole.Scout,
                        BetterSkills.Settings.ScoutingBonus,
                        EffectIncrementType.Add,
                        0f
                    );
                }
                catch (Exception e)
                {
                    NotifyHelper.WriteError(nameof(DefaultSkillEffects), $"writing to skills failed: {e}");
                }

                _effectRogueryLootBonus(__instance).Initialize(
                    new TextObject("{=bN3bLDb2}Battle Loot +{a0}%", null),
                    DefaultSkills.Roguery,
                    PartyRole.PartyLeader,
                    BetterSkills.Settings.RogueryLootBonusValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectCharmRelationBonus(__instance).Initialize(
                    new TextObject("{=c5dsio8Q}Relation increase with NPCs +{a0}%", null),
                    DefaultSkills.Charm,
                    PartyRole.Personal,
                    BetterSkills.Settings.CharmRelationBonusValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectTradePenaltyReduction(__instance).Initialize(
                    new TextObject("{=uq7JwT1Z}Trade penalty Reduction +{a0}%", null),
                    DefaultSkills.Trade,
                    PartyRole.PartyLeader,
                    BetterSkills.Settings.TradePenaltyReductionValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectLeadershipMoraleBonus(__instance).Initialize(
                    new TextObject("{=n3bFiuVu}Increase morale of the parties under your command +{a0}", null),
                    DefaultSkills.Leadership,
                    PartyRole.Personal,
                    BetterSkills.Settings.LeadershipMoraleBonusValue,
                    EffectIncrementType.Add,
                    limitMin: minimumAddClamp);

                _effectLeadershipGarrisonSizeBonus(__instance).Initialize(
                    new TextObject("{=cSt26auo}Increase garrison size by +{a0}", null),
                    DefaultSkills.Leadership,
                    PartyRole.Personal,
                    BetterSkills.Settings.LeadershipGarrisonSizeBonusValue,
                    EffectIncrementType.Add,
                    limitMin: minimumAddClamp);

                _effectSurgeonSurvivalBonus(__instance).Initialize(
                    new TextObject("{=w4BzNJYl}Casualty survival chance +{a0}%", null),
                    DefaultSkills.Medicine,
                    PartyRole.Surgeon,
                    BetterSkills.Settings.SurgeonSurvivalBonusValue,
                    EffectIncrementType.Add,
                    limitMin: minimumAddClamp);

                _effectHealingRateBonusForHeroes(__instance).Initialize(
                    new TextObject("{=fUvs4g40}Healing rate increase for heroes +{a0}%", null),
                    DefaultSkills.Medicine,
                    PartyRole.Surgeon,
                    BetterSkills.Settings.HealingRateBonusForHeroesValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectHealingRateBonusForRegulars(__instance).Initialize(
                    new TextObject("{=A310vHqJ}Healing rate increase for troops +{a0}%", null),
                    DefaultSkills.Medicine,
                    PartyRole.Surgeon,
                    BetterSkills.Settings.HealingRateBonusForRegularsValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectGovernorHealingRateBonus(__instance).Initialize(
                    new TextObject("{=6mQGst9s}Healing rate increase +{a0}%", null),
                    DefaultSkills.Medicine,
                    PartyRole.Governor,
                    BetterSkills.Settings.GovernorHealingRateBonusValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectSiegeEngineProductionBonus(__instance).Initialize(
                    new TextObject("{=spbYlf0y}Faster siege engine production +{a0}%", null),
                    DefaultSkills.Engineering,
                    PartyRole.Engineer,
                    BetterSkills.Settings.SiegeEngineProductionBonusValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectTownProjectBuildingBonus(__instance).Initialize(
                    new TextObject("{=2paRqO8u}Faster building production +{a0}%", null),
                    DefaultSkills.Engineering,
                    PartyRole.Governor,
                    BetterSkills.Settings.TownProjectBuildingBonusValue,
                    EffectIncrementType.AddFactor,
                    limitMin: minimumFactorClamp);

                _effectStewardPartySizeBonus(__instance).Initialize(
                    new TextObject("{=jNDUXetG}Increase party size by +{a0}", null),
                    DefaultSkills.Steward,
                    PartyRole.Quartermaster,
                    BetterSkills.Settings.StewardPartySizeBonusValue,
                    EffectIncrementType.Add,
                    limitMin: minimumAddClamp);

                _effectSneakDamage(__instance).Initialize(
                    new TextObject("{=vDieFIKM}Sneak attack damage +{a0}%", null),
                    DefaultSkills.Steward,
                    PartyRole.Personal,
                    BetterSkills.Settings.SneakDamageBonusValue,
                    EffectIncrementType.AddFactor,
                    0.5f,
                    minimumFactorClamp);

                _effectCrouchedSpeed(__instance).Initialize(
                   new TextObject("{=sTgjLrPX}Crouched speed +{a0}%", null),
                   DefaultSkills.Steward,
                   PartyRole.Personal,
                   BetterSkills.Settings.CrouchedSpeedBonusValue,
                   EffectIncrementType.AddFactor,
                   minimumFactorClamp);

                _effectNoiseSuppression(__instance).Initialize(
                   new TextObject("{=GzLd3ca9}Noise suppression -{a0}%", null),
                   DefaultSkills.Steward,
                   PartyRole.Personal,
                   BetterSkills.Settings.NoiseSuppressionBonusValue,
                   EffectIncrementType.AddFactor,
                   minimumFactorClamp);

#if DEBUG
        NotifyHelper.WriteMessage($"{nameof(DefaultSkillEffects)} Initialize skills", MsgType.Notify);
#endif
            }
            catch (Exception e)
            {
                NotifyHelper.WriteError(nameof(DefaultSkillEffects), $"writing to skills failed: {e}");
            }
        }
    }
}