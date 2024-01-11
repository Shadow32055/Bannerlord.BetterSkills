using BetterSkills.Localizations;
using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace BetterSkills.Settings {

    public class MCMSettings : AttributeGlobalSettings<MCMSettings> {

        [SettingPropertyGroup(RefValues.VigorText, GroupOrder = 0)]
        [SettingPropertyFloatingInteger(RefValues.OneHandedSpeedText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float OneHandedSpeedValue { get; set; } = 0.07f;

        [SettingPropertyGroup(RefValues.VigorText)]
        [SettingPropertyFloatingInteger(RefValues.OneHandedDamageText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float OneHandedDamageValue { get; set; } = 0.15f;

        [SettingPropertyGroup(RefValues.VigorText)]
        [SettingPropertyFloatingInteger(RefValues.TwoHandedSpeedText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float TwoHandedSpeedValue { get; set; } = 0.06f;

        [SettingPropertyGroup(RefValues.VigorText)]
        [SettingPropertyFloatingInteger(RefValues.TwoHandedDamageText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float TwoHandedDamageValue { get; set; } = 0.16f;

        [SettingPropertyGroup(RefValues.VigorText)]
        [SettingPropertyFloatingInteger(RefValues.PolearmSpeedText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float PolearmSpeedValue { get; set; } = 0.06f;

        [SettingPropertyGroup(RefValues.VigorText)]
        [SettingPropertyFloatingInteger(RefValues.PolearmDamageText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float PolearmDamageValue { get; set; } = 0.07f;

        [SettingPropertyGroup(RefValues.ControlText, GroupOrder = 1)]
        [SettingPropertyFloatingInteger(RefValues.BowLevelText, 0f, 100f, "0", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float BowLevelValue { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.BowDmgText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float BowDamageValue { get; set; } = 0.11f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.BowAccuracyText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float BowAccuracyValue { get; set; } = 0.09f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.ThrowingSpeedText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float ThrowingSpeedValue { get; set; } = 0.07f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.ThrowingDamageText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float ThrowingDamageValue { get; set; } = 0.06f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.ThrowingAccText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float ThrowingAccuracyValue { get; set; } = 0.06f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.CrossbowReloadText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float CrossbowReloadSpeedValue { get; set; } = 0.07f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.CrossbowAccText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float CrossbowAccuracyValue { get; set; } = 0.05f;

        [SettingPropertyGroup(RefValues.EnduranceText, GroupOrder = 2)]
        [SettingPropertyFloatingInteger(RefValues.HorseLevelText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float HorseLevelValue { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.HorseSpeedText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float HorseSpeedValue { get; set; } = 0.2f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.HorseManeuverText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float HorseManeuverValue { get; set; } = 0.04f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.MountWepDmgPenText, -5f, 0f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float MountWeaponDamagePenaltyValue { get; set; } = -0.2f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.MountWepSpeedPenText, -5f, 0f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float MountWeaponSpeedPenaltyValue { get; set; } = -0.3f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.DismountResText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float DismountResistanceValue { get; set; } = 0.1f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.AthleticsSpeedText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float AthleticsSpeedFactorValue { get; set; } = 0.1f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.AthleticsWeigthText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float AthleticsWeightFactorValue { get; set; } = 0.1f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.KnockbackResText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float KnockBackResistanceValue { get; set; } = 0.1f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.KnockdownResText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float KnockDownResistanceValue { get; set; } = 0.1f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.SmithingLevelText, 0f, 100f, "0", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float SmithingLevelValue { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.CunningText, GroupOrder = 3)]
        [SettingPropertyFloatingInteger(RefValues.TacticsAdvText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float TacticsAdvantageValue { get; set; } = 0.1f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.TacticsSacrificeRedText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float TacticsTroopSacrificeReductionValue { get; set; } = 0.1f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.TrackingText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float TrackingRadiusValue { get; set; } = 0.1f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.TrackingLevel, 0f, 100f, "0", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float TrackingLevelValue { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.TrackingSpotText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float TrackingSpottingDistanceValue { get; set; } = 0.06f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.TrackingInfoText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float TrackingTrackInformationValue { get; set; } = 0.04f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.LootBonusText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float RogueryLootBonusValue { get; set; } = 0.25f;

        [SettingPropertyGroup(RefValues.SocialText, GroupOrder = 4)]
        [SettingPropertyFloatingInteger(RefValues.CharmRelText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float CharmRelationBonusValue { get; set; } = 0.5f;

        [SettingPropertyGroup(RefValues.SocialText)]
        [SettingPropertyFloatingInteger(RefValues.TradePenText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float TradePenaltyReductionValue { get; set; } = 0.2f;

        [SettingPropertyGroup(RefValues.SocialText)]
        [SettingPropertyFloatingInteger(RefValues.LeaderMoralText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float LeadershipMoraleBonusValue { get; set; } = 0.1f;

        [SettingPropertyGroup(RefValues.SocialText)]
        [SettingPropertyFloatingInteger(RefValues.LeaderGarrisonText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float LeadershipGarrisonSizeBonusValue { get; set; } = 0.2f;

        [SettingPropertyGroup(RefValues.IntelligenceText, GroupOrder = 5)]
        [SettingPropertyFloatingInteger(RefValues.SurviorText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float SurgeonSurvivalBonusValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.HealingHeroesText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float HealingRateBonusForHeroesValue { get; set; } = 0.5f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.HealingRegularsText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float HealingRateBonusForRegularsValue { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.HealingRateText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float GovernorHealingRateBonusValue { get; set; } = 0.1f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.SiegeEngineText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float SiegeEngineProductionBonusValue { get; set; } = 0.1f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.TownProjectText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float TownProjectBuildingBonusValue { get; set; } = 0.25f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.PartySizeText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float StewardPartySizeBonusValue { get; set; } = 0.25f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.EngineerText, 0f, 100f, "0", Order = 0, RequireRestart = false, HintText = RefValues.GenericHintText)]
        public float EngineerLevelValue { get; set; } = 1f;



        public override string Id { get { return base.GetType().Assembly.GetName().Name; } }
        public override string DisplayName { get { return base.GetType().Assembly.GetName().Name; } }
        public override string FolderName { get { return base.GetType().Assembly.GetName().Name; } }
        public override string FormatType { get; } = "xml";
        public bool LoadMCMConfigFile { get; set; } = true;

    }
}