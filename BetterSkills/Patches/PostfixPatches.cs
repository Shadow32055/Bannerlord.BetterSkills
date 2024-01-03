using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using static HarmonyLib.AccessTools;

namespace BetterSkills.Patches {

    [HarmonyPatch]
    class PostfixPatches {

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

		static FieldRef<DefaultSkillEffects, SkillEffect> _effectBowLevel = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectBowLevel");
		static FieldRef<DefaultSkillEffects, SkillEffect> _effectBowDamage = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectBowDamage");
		static FieldRef<DefaultSkillEffects, SkillEffect> _effectBowAccuracy = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectBowAccuracy");
		static FieldRef<DefaultSkillEffects, SkillEffect> _effectThrowingSpeed = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectThrowingSpeed");
		static FieldRef<DefaultSkillEffects, SkillEffect> _effectThrowingDamage = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectThrowingDamage");
		static FieldRef<DefaultSkillEffects, SkillEffect> _effectThrowingAccuracy = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectThrowingAccuracy");
		static FieldRef<DefaultSkillEffects, SkillEffect> _effectCrossbowReloadSpeed = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectCrossbowReloadSpeed");
		static FieldRef<DefaultSkillEffects, SkillEffect> _effectCrossbowAccuracy = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectCrossbowAccuracy");

		static FieldRef<DefaultSkillEffects, SkillEffect> _effectHorseLevel = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectHorseLevel");
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
		static FieldRef<DefaultSkillEffects, SkillEffect> _effectTrackingLevel = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectTrackingLevel");
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
		static FieldRef<DefaultSkillEffects, SkillEffect> _effectEngineerLevel = AccessTools.FieldRefAccess<DefaultSkillEffects, SkillEffect>("_effectEngineerLevel");


		[HarmonyPostfix]
        [HarmonyPatch(typeof(DefaultSkillEffects), "InitializeAll")]
        public static void InitializeAll(DefaultSkillEffects __instance) {

			_effectOneHandedSpeed(__instance).Initialize(new TextObject("{=hjxRvb9l}One handed weapon speed: +{a0} %", null), new SkillObject[]
			{
				DefaultSkills.OneHanded
			}, SkillEffect.PerkRole.Personal, SubModule._settings.OneHandedSpeedValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectOneHandedDamage(__instance).Initialize(new TextObject("{=baUFKAbd}One handed weapon damage: +{a0} %", null), new SkillObject[]
			{
				DefaultSkills.OneHanded
			}, SkillEffect.PerkRole.Personal, SubModule._settings.OneHandedDamageValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectTwoHandedSpeed(__instance).Initialize(new TextObject("{=Np94rYMz}Two handed weapon speed: +{a0} %", null), new SkillObject[]
			{
				DefaultSkills.TwoHanded
			}, SkillEffect.PerkRole.Personal, SubModule._settings.TwoHandedSpeedValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectTwoHandedDamage(__instance).Initialize(new TextObject("{=QkbbLb4v}Two handed weapon damage: +{a0} %", null), new SkillObject[]
			{
				DefaultSkills.TwoHanded
			}, SkillEffect.PerkRole.Personal, SubModule._settings.TwoHandedDamageValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectPolearmSpeed(__instance).Initialize(new TextObject("{=2ATI9qVM}Polearm weapon speed: +{a0} %", null), new SkillObject[]
			{
				DefaultSkills.Polearm
			}, SkillEffect.PerkRole.Personal, SubModule._settings.PolearmSpeedValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectPolearmDamage(__instance).Initialize(new TextObject("{=17cIGVQE}Polearm weapon damage: +{a0} %", null), new SkillObject[]
			{
				DefaultSkills.Polearm
			}, SkillEffect.PerkRole.Personal, SubModule._settings.PolearmDamageValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);



			_effectBowLevel(__instance).Initialize(new TextObject("{=XN7BX0qP}Max usable bow difficulty: {a0}", null), new SkillObject[]
			{
				DefaultSkills.Bow
			}, SkillEffect.PerkRole.Personal, SubModule._settings.BowLevelValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectBowDamage(__instance).Initialize(new TextObject("{=RUZHJMQO}Bow Damage: +{a0} %", null), new SkillObject[]
			{
				DefaultSkills.Bow
			}, SkillEffect.PerkRole.Personal, SubModule._settings.BowDamageValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectBowAccuracy(__instance).Initialize(new TextObject("{=sQCS90Wq}Bow Accuracy: +{a0} %", null), new SkillObject[]
			{
				DefaultSkills.Bow
			}, SkillEffect.PerkRole.Personal, SubModule._settings.BowAccuracyValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectThrowingSpeed(__instance).Initialize(new TextObject("{=Z0CoeojG}Thrown weapon speed: +{a0} %", null), new SkillObject[]
			{
				DefaultSkills.Throwing
			}, SkillEffect.PerkRole.Personal, SubModule._settings.ThrowingSpeedValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectThrowingDamage(__instance).Initialize(new TextObject("{=TQMGppEk}Thrown weapon damage: +{a0} %", null), new SkillObject[]
			{
				DefaultSkills.Throwing
			}, SkillEffect.PerkRole.Personal, SubModule._settings.ThrowingDamageValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectThrowingAccuracy(__instance).Initialize(new TextObject("{=SfKrjKuO}Thrown weapon accuracy: +{a0} %", null), new SkillObject[]
			{
				DefaultSkills.Throwing
			}, SkillEffect.PerkRole.Personal, SubModule._settings.ThrowingAccuracyValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectCrossbowReloadSpeed(__instance).Initialize(new TextObject("{=W0Zu4iDz}Crossbow reload speed: +{a0} %", null), new SkillObject[]
			{
				DefaultSkills.Crossbow
			}, SkillEffect.PerkRole.Personal, SubModule._settings.CrossbowReloadSpeedValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectCrossbowAccuracy(__instance).Initialize(new TextObject("{=JwWnpD40}Crossbow accuracy: +{a0} %", null), new SkillObject[]
			{
				DefaultSkills.Crossbow
			}, SkillEffect.PerkRole.Personal, SubModule._settings.CrossbowAccuracyValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);



			_effectHorseLevel(__instance).Initialize(new TextObject("{=8uBbbwY9}Max mount difficulty: {a0}", null), new SkillObject[]
			{
				DefaultSkills.Riding
			}, SkillEffect.PerkRole.Personal, SubModule._settings.HorseLevelValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectHorseSpeed(__instance).Initialize(new TextObject("{=Y07OcP1T}Horse speed: +{a0}", null), new SkillObject[]
			{
				DefaultSkills.Riding
			}, SkillEffect.PerkRole.Personal, SubModule._settings.HorseSpeedValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectHorseManeuver(__instance).Initialize(new TextObject("{=AahNTeXY}Horse maneuver: +{a0}", null), new SkillObject[]
			{
				DefaultSkills.Riding
			}, SkillEffect.PerkRole.Personal, SubModule._settings.HorseManeuverValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
            _effectMountedWeaponDamagePenalty(__instance).Initialize(new TextObject("{=0dbwEczK}Mounted weapon damage penalty: {a0} %", null), new SkillObject[]
			{
				DefaultSkills.Riding
			}, SkillEffect.PerkRole.Personal, SubModule._settings.MountWeaponDamagePenaltyValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.Add, 20f, 0f);
            _effectMountedWeaponSpeedPenalty(__instance).Initialize(new TextObject("{=oE5etyy0}Mounted weapon speed & reload penalty: {a0} %", null), new SkillObject[]
			{
				DefaultSkills.Riding
			}, SkillEffect.PerkRole.Personal, SubModule._settings.MountWeaponSpeedPenaltyValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.Add, 30f, 0f);
            _effectDismountResistance(__instance).Initialize(new TextObject("{= kbHJVxAo }Dismount resistance: { a0}% of max. hitpoints", null), new SkillObject[]
           {
                DefaultSkills.Riding
           }, SkillEffect.PerkRole.Personal, SubModule._settings.DismountResistanceValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.Add, 40f, 0f);
            _effectAthleticsSpeedFactor(__instance).Initialize(new TextObject("{=rgb6vdon}Running speed increased by {a0} %", null), new SkillObject[]
			{
				DefaultSkills.Athletics
			}, SkillEffect.PerkRole.Personal, SubModule._settings.AthleticsSpeedFactorValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectAthleticsWeightFactor(__instance).Initialize(new TextObject("{=WaUuhxwv}Weight penalty reduced by: {a0} %", null), new SkillObject[]
			{
				DefaultSkills.Athletics
			}, SkillEffect.PerkRole.Personal, SubModule._settings.AthleticsWeightFactorValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
            _effectKnockBackResistance(__instance).Initialize(new TextObject("{=TyjDHQUv}Knock back resistance: {a0}% of max. hitpoints", null), new SkillObject[]
            {
                DefaultSkills.Athletics
            }, SkillEffect.PerkRole.Personal, SubModule._settings.KnockBackResistanceValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.Add, 15f, 0f);
            _effectKnockDownResistance(__instance).Initialize(new TextObject("{=tlNZIH3l}Knock down resistance: {a0}% of max. hitpoints", null), new SkillObject[]
            {
                DefaultSkills.Athletics
            }, SkillEffect.PerkRole.Personal, SubModule._settings.KnockDownResistanceValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.Add, 40f, 0f);
            _effectSmithingLevel(__instance).Initialize(new TextObject("{=ImN8Cfk6}Max difficulty of weapon that can be smithed without penalty: {a0}", null), new SkillObject[]
			{
				DefaultSkills.Crafting
			}, SkillEffect.PerkRole.Personal, SubModule._settings.SmithingLevelValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);



			_effectTacticsAdvantage(__instance).Initialize(new TextObject("{=XO3SOlZx}Simulation advantage: +{a0} %", null), new SkillObject[]
			{
				DefaultSkills.Tactics
			}, SkillEffect.PerkRole.Personal, SubModule._settings.TacticsAdvantageValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectTacticsTroopSacrificeReduction(__instance).Initialize(new TextObject("{=VHdyQYKI}Decrease the sacrificed troop number when trying to get away +{a0} %", null), new SkillObject[]
			{
				DefaultSkills.Tactics
			}, SkillEffect.PerkRole.Personal, SubModule._settings.TacticsTroopSacrificeReductionValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectTrackingRadius(__instance).Initialize(new TextObject("{=kqJipMqc}Track detection radius +{a0} %", null), new SkillObject[]
			{
				DefaultSkills.Scouting
			}, SkillEffect.PerkRole.Scout, SubModule._settings.TrackingRadiusValue, SkillEffect.PerkRole.None, 0.05f, SkillEffect.EffectIncrementType.Add, 0f, 0f);
			_effectTrackingLevel(__instance).Initialize(new TextObject("{=aGecGUub}Max track difficulty that can be detected:  {a0}", null), new SkillObject[]
			{
				DefaultSkills.Scouting
			}, SkillEffect.PerkRole.Scout, SubModule._settings.TrackingLevelValue, SkillEffect.PerkRole.None, 1f, SkillEffect.EffectIncrementType.Add, 0f, 0f);
			_effectTrackingSpottingDistance(__instance).Initialize(new TextObject("{=lbrOAvKj}Spotting distance +{a0} %", null), new SkillObject[]
			{
				DefaultSkills.Scouting
			}, SkillEffect.PerkRole.Scout, SubModule._settings.TrackingSpottingDistanceValue, SkillEffect.PerkRole.None, 0.03f, SkillEffect.EffectIncrementType.Add, 0f, 0f);
			_effectTrackingTrackInformation(__instance).Initialize(new TextObject("{=uNls3bOP}Track information level: {a0}", null), new SkillObject[]
			{
				DefaultSkills.Scouting
			}, SkillEffect.PerkRole.Scout, SubModule._settings.TrackingTrackInformationValue, SkillEffect.PerkRole.None, 0.03f, SkillEffect.EffectIncrementType.Add, 0f, 0f);
			_effectRogueryLootBonus(__instance).Initialize(new TextObject("{=bN3bLDb2}Battle Loot +{a0}%", null), new SkillObject[]
			{
				DefaultSkills.Roguery
			}, SkillEffect.PerkRole.PartyLeader, SubModule._settings.RogueryLootBonusValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);



			_effectCharmRelationBonus(__instance).Initialize(new TextObject("{=c5dsio8Q}Relation increase with NPCs +{a0}%", null), new SkillObject[]
			{
				DefaultSkills.Charm
			}, SkillEffect.PerkRole.Personal, SubModule._settings.CharmRelationBonusValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectTradePenaltyReduction(__instance).Initialize(new TextObject("{=uq7JwT1Z}Trade penalty Reduction +{a0}%", null), new SkillObject[]
			{
				DefaultSkills.Trade
			}, SkillEffect.PerkRole.PartyLeader, SubModule._settings.TradePenaltyReductionValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectLeadershipMoraleBonus(__instance).Initialize(new TextObject("{=n3bFiuVu}Increase morale of the parties under your command +{a0}", null), new SkillObject[]
			{
				DefaultSkills.Leadership
			}, SkillEffect.PerkRole.Personal, SubModule._settings.LeadershipMoraleBonusValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.Add, 0f, 0f);
			_effectLeadershipGarrisonSizeBonus(__instance).Initialize(new TextObject("{=cSt26auo}Increase garrison size by +{a0}", null), new SkillObject[]
			{
				DefaultSkills.Leadership
			}, SkillEffect.PerkRole.Personal, SubModule._settings.LeadershipGarrisonSizeBonusValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.Add, 0f, 0f);



			_effectSurgeonSurvivalBonus(__instance).Initialize(new TextObject("{=w4BzNJYl}Casualty survival chance +{a0}%", null), new SkillObject[]
			{
				DefaultSkills.Medicine
			}, SkillEffect.PerkRole.Surgeon, SubModule._settings.SurgeonSurvivalBonusValue, SkillEffect.PerkRole.None, 0.01f, SkillEffect.EffectIncrementType.Add, 0f, 0f);
			_effectHealingRateBonusForHeroes(__instance).Initialize(new TextObject("{=fUvs4g40}Healing rate increase for heroes +{a0}%", null), new SkillObject[]
			{
				DefaultSkills.Medicine
			}, SkillEffect.PerkRole.Surgeon, SubModule._settings.HealingRateBonusForHeroesValue, SkillEffect.PerkRole.None, 0.05f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectHealingRateBonusForRegulars(__instance).Initialize(new TextObject("{=A310vHqJ}Healing rate increase for troops +{a0}%", null), new SkillObject[]
			{
				DefaultSkills.Medicine
			}, SkillEffect.PerkRole.Surgeon, SubModule._settings.HealingRateBonusForRegularsValue, SkillEffect.PerkRole.None, 0.05f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectGovernorHealingRateBonus(__instance).Initialize(new TextObject("{=6mQGst9s}Healing rate increase +{a0}%", null), new SkillObject[]
			{
				DefaultSkills.Medicine
			}, SkillEffect.PerkRole.Governor, SubModule._settings.GovernorHealingRateBonusValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectSiegeEngineProductionBonus(__instance).Initialize(new TextObject("{=spbYlf0y}Faster siege engine production +{a0}%", null), new SkillObject[]
			{
				DefaultSkills.Engineering
			}, SkillEffect.PerkRole.Engineer, SubModule._settings.SiegeEngineProductionBonusValue, SkillEffect.PerkRole.None, 0.05f, SkillEffect.EffectIncrementType.AddFactor, 0f, 0f);
			_effectTownProjectBuildingBonus(__instance).Initialize(new TextObject("{=2paRqO8u}Faster building production +{a0}%", null), new SkillObject[]
			{
				DefaultSkills.Engineering
			}, SkillEffect.PerkRole.Governor, SubModule._settings.TownProjectBuildingBonusValue, SkillEffect.PerkRole.None, 0.05f, SkillEffect.EffectIncrementType.Add, 0f, 0f);
			_effectStewardPartySizeBonus(__instance).Initialize(new TextObject("{=jNDUXetG}Increase party size by +{a0}", null), new SkillObject[]
			{
				DefaultSkills.Steward
			}, SkillEffect.PerkRole.Quartermaster, SubModule._settings.StewardPartySizeBonusValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.Add, 0f, 0f);
			_effectEngineerLevel(__instance).Initialize(new TextObject("{=aQduWCrg}Max difficulty of siege engine that can be built: {a0}", null), new SkillObject[]
			{
				DefaultSkills.Engineering
			}, SkillEffect.PerkRole.Engineer, SubModule._settings.EngineerLevelValue, SkillEffect.PerkRole.None, 0f, SkillEffect.EffectIncrementType.Add, 0f, 0f);
		}
	}
}
