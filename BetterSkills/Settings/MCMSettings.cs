using BetterSkills.Localizations;
using MCM.Abstractions;
using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;
using System.Collections.Generic;

namespace BetterSkills.Settings {

    public class MCMSettings : AttributeGlobalSettings<MCMSettings> {

        // ---------------------- VIGOR SKILLS ---------------------- //
        [SettingPropertyGroup(RefValues.VigorText, GroupOrder = 0)]
        [SettingPropertyFloatingInteger(RefValues.OneHandedSpeedText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float OneHandedSpeedValue { get; set; } = 0.001f;

        [SettingPropertyGroup(RefValues.VigorText)]
        [SettingPropertyFloatingInteger(RefValues.OneHandedDamageText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float OneHandedDamageValue { get; set; } = 0.002f;

        [SettingPropertyGroup(RefValues.VigorText)]
        [SettingPropertyFloatingInteger(RefValues.TwoHandedSpeedText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float TwoHandedSpeedValue { get; set; } = 0.001f;

        [SettingPropertyGroup(RefValues.VigorText)]
        [SettingPropertyFloatingInteger(RefValues.TwoHandedDamageText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float TwoHandedDamageValue { get; set; } = 0.002f;

        [SettingPropertyGroup(RefValues.VigorText)]
        [SettingPropertyFloatingInteger(RefValues.PolearmSpeedText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float PolearmSpeedValue { get; set; } = 0.001f;

        [SettingPropertyGroup(RefValues.VigorText)]
        [SettingPropertyFloatingInteger(RefValues.PolearmDamageText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float PolearmDamageValue { get; set; } = 0.001f;

        // ---------------------- Control SKILLS ---------------------- //

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.BowDmgText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float BowDamageValue { get; set; } = 0.0015f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.BowAccuracyText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float BowAccuracyValue { get; set; } = -0.0015f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.ThrowingSpeedText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float ThrowingSpeedValue { get; set; } = 0.001f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.ThrowingDamageText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float ThrowingDamageValue { get; set; } = 0.001f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.ThrowingAccText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float ThrowingAccuracyValue { get; set; } = -0.001f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.CrossbowReloadText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float CrossbowReloadSpeedValue { get; set; } = 0.001f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.CrossbowAccText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float CrossbowAccuracyValue { get; set; } = -0.001f;

        // ---------------------- Endurance SKILLS ---------------------- //

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.HorseSpeedText, -0.25f, 0.25f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float HorseSpeedValue { get; set; } = 0.005f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.HorseManeuverText, -0.25f, 0.25f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float HorseManeuverValue { get; set; } = 0.001f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.MountWepDmgPenText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float MountWeaponDamagePenaltyValue { get; set; } = 0.005f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.MountWepSpeedPenText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float MountWeaponSpeedPenaltyValue { get; set; } = 0.005f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.DismountResText, -0.03f, 0.03f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float DismountResistanceValue { get; set; } = 0.005f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.AthleticsSpeedText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float AthleticsSpeedFactorValue { get; set; } = 0.0015f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.AthleticsWeigthText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float AthleticsWeightFactorValue { get; set; } = -0.0015f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.KnockbackResText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float KnockBackResistanceValue { get; set; } = 0.0015f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.KnockdownResText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float KnockDownResistanceValue { get; set; } = 0.0015f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.SmithingLevelText, -5f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float SmithingLevelValue { get; set; } = 1.5f;

        // ---------------------- Cunning SKILLS ---------------------- //

        [SettingPropertyGroup(RefValues.CunningText, GroupOrder = 3)]
        [SettingPropertyFloatingInteger(RefValues.TacticsAdvText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float TacticsAdvantageValue { get; set; } = 0.002f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.TacticsSacrificeRedText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float TacticsTroopSacrificeReductionValue { get; set; } = -0.002f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.TrackingText, -1.0f, 1.0f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float TrackingRadiusValue { get; set; } = 0.2f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.TrackingSpotText, -1.0f, 1.0f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float TrackingSpottingDistanceValue { get; set; } = 0.1f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.TrackingInfoText, -1.0f, 1.0f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float TrackingTrackInformationValue { get; set; } = 0.1f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.LootBonusText, -0.1f, 0.1f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float RogueryLootBonusValue { get; set; } = 0.005f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.SneakDamageBonusText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float SneakDamageBonusValue { get; set; } = 0.0025f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.CrouchedSpeedBonusText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float CrouchedSpeedBonusValue { get; set; } = 0.001f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.NoiseSuppressionBonusText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float NoiseSuppressionBonusValue { get; set; } = 0.005f;

        // ---------------------- Social SKILLS ---------------------- //

        [SettingPropertyGroup(RefValues.SocialText, GroupOrder = 4)]
        [SettingPropertyFloatingInteger(RefValues.CharmRelText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float CharmRelationBonusValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.SocialText)]
        [SettingPropertyFloatingInteger(RefValues.TradePenText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float TradePenaltyReductionValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.SocialText)]
        [SettingPropertyFloatingInteger(RefValues.LeaderMoralText, -0.25f, 0.25f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float LeadershipMoraleBonusValue { get; set; } = 0.02f;

        [SettingPropertyGroup(RefValues.SocialText)]
        [SettingPropertyFloatingInteger(RefValues.LeaderGarrisonText, -1.0f, 1.0f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float LeadershipGarrisonSizeBonusValue { get; set; } = 0.3f;

        // ---------------------- Intelligence SKILLS ---------------------- //

        [SettingPropertyGroup(RefValues.IntelligenceText, GroupOrder = 5)]
        [SettingPropertyFloatingInteger(RefValues.SurviorText, -0.25f, 0.25f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float SurgeonSurvivalBonusValue { get; set; } = 0.004f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.HealingHeroesText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float HealingRateBonusForHeroesValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.HealingRegularsText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float HealingRateBonusForRegularsValue { get; set; } = 0.02f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.HealingRateText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float GovernorHealingRateBonusValue { get; set; } = 0.002f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.SiegeEngineText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float SiegeEngineProductionBonusValue { get; set; } = 0.002f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.TownProjectText, -0.03f, 0.03f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float TownProjectBuildingBonusValue { get; set; } = 0.004f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.PartySizeText, -5f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float StewardPartySizeBonusValue { get; set; } = 0.4f;

        // ---------------------- Bonus SKILLS ---------------------- //

        [SettingPropertyGroup(RefValues.BonusText, GroupOrder = 6)]
        [SettingPropertyFloatingInteger(RefValues.ScoutingBonusText, -0.1f, 0.1f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float ScoutingBonus { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.BonusText)]
        [SettingPropertyBool(RefValues.ScoutingBonusPlayerText, Order = 0, RequireRestart = false)]
        public bool ScoutingBonusPlayerOnly { get; set; } = false;

        public override string Id { get { return base.GetType().Assembly.GetName().Name; } }
        public override string DisplayName { get { return base.GetType().Assembly.GetName().Name; } }
        public override string FolderName { get { return base.GetType().Assembly.GetName().Name; } }
        public override string FormatType { get; } = "xml";
        public bool LoadMCMConfigFile { get; set; } = true;


        public override IEnumerable<ISettingsPreset> GetBuiltInPresets() {
            // Keep the default preset from BaseSettings
            foreach (var preset in base.GetBuiltInPresets())
                yield return preset;

            // ---- Custom Presets ----

            // 1) Vanilla Preset
            yield return new MemorySettingsPreset(
                Id,
                "vanilla",
                "Vanilla (original)",
                () => {
                    var s = (MCMSettings)CreateNew();

                    // weapon stats
                    s.OneHandedSpeedValue = 0.0007f;
                    s.OneHandedDamageValue = 0.0015f;
                    s.TwoHandedSpeedValue = 0.0006f;
                    s.TwoHandedDamageValue = 0.0016f;
                    s.PolearmSpeedValue = 0.0006f;
                    s.PolearmDamageValue = 0.0007f;

                    s.BowDamageValue = 0.0011f;
                    s.BowAccuracyValue = -0.0009f;
                    s.ThrowingSpeedValue = 0.0007f;
                    s.ThrowingDamageValue = 0.0006f;
                    s.ThrowingAccuracyValue = -0.0006f;
                    s.CrossbowReloadSpeedValue = 0.0007f;
                    s.CrossbowAccuracyValue = -0.0005f;

                    // riding stats
                    s.HorseSpeedValue = 0.002f;
                    s.HorseManeuverValue = 0.0004f;
                    s.MountWeaponDamagePenaltyValue = 0.002f;
                    s.MountWeaponSpeedPenaltyValue = 0.003f;
                    s.DismountResistanceValue = 0.001f;

                    // athletics stats
                    s.AthleticsSpeedFactorValue = 0.001f;
                    s.AthleticsWeightFactorValue = -0.001f;
                    s.KnockBackResistanceValue = 0.001f;
                    s.KnockDownResistanceValue = 0.001f;

                    // crafting
                    s.SmithingLevelValue = 1f;

                    // tactics
                    s.TacticsAdvantageValue = 0.001f;
                    s.TacticsTroopSacrificeReductionValue = -0.001f;

                    // scouting
                    s.TrackingRadiusValue = 0.1f;
                    s.TrackingSpottingDistanceValue = 0.06f;
                    s.TrackingTrackInformationValue = 0.04f;

                    // roguery
                    s.RogueryLootBonusValue = 0.0025f;

                    // charm/trade/leadership
                    s.CharmRelationBonusValue = 0.005f;
                    s.TradePenaltyReductionValue = 0.002f;
                    s.LeadershipMoraleBonusValue = 0.1f;
                    s.LeadershipGarrisonSizeBonusValue = 0.2f;

                    // medicine
                    s.SurgeonSurvivalBonusValue = 0.0025f;
                    s.HealingRateBonusForHeroesValue = 0.005f;
                    s.HealingRateBonusForRegularsValue = 0.01f;
                    s.GovernorHealingRateBonusValue = 0.001f;

                    // engineering
                    s.SiegeEngineProductionBonusValue = 0.001f;
                    s.TownProjectBuildingBonusValue = 0.0025f;

                    // steward
                    s.StewardPartySizeBonusValue = 0.25f;

                    // roguery/stealth
                    s.SneakDamageBonusValue = 0.002f;
                    s.CrouchedSpeedBonusValue = 0.0005f;
                    s.NoiseSuppressionBonusValue = 0.0025f;

                    return s;
                }
            );


            // 2) Arcade Preset (~3× base)
            yield return new MemorySettingsPreset(
                Id,
                "arcade",
                "Arcade",
                () => {
                    var s = (MCMSettings)CreateNew();

                    // ---------------------- VIGOR ---------------------- //
                    s.OneHandedSpeedValue = 0.0021f;
                    s.OneHandedDamageValue = 0.0045f;

                    s.TwoHandedSpeedValue = 0.0018f;
                    s.TwoHandedDamageValue = 0.0048f;

                    s.PolearmSpeedValue = 0.0018f;
                    s.PolearmDamageValue = 0.0021f;

                    // ---------------------- CONTROL ---------------------- //
                    s.BowDamageValue = 0.0033f;
                    s.BowAccuracyValue = -0.0027f;

                    s.ThrowingSpeedValue = 0.0021f;
                    s.ThrowingDamageValue = 0.0018f;
                    s.ThrowingAccuracyValue = -0.0018f;

                    s.CrossbowReloadSpeedValue = 0.0021f;
                    s.CrossbowAccuracyValue = -0.0015f;

                    // ---------------------- ENDURANCE ---------------------- //
                    s.HorseSpeedValue = 0.006f;
                    s.HorseManeuverValue = 0.0012f;

                    s.MountWeaponDamagePenaltyValue = 0.006f;
                    s.MountWeaponSpeedPenaltyValue = 0.009f;

                    s.DismountResistanceValue = 0.003f;

                    s.AthleticsSpeedFactorValue = 0.003f;
                    s.AthleticsWeightFactorValue = -0.003f;

                    s.KnockBackResistanceValue = 0.003f;
                    s.KnockDownResistanceValue = 0.003f;

                    s.SmithingLevelValue = 3f;

                    // ---------------------- CUNNING ---------------------- //
                    s.TacticsAdvantageValue = 0.003f;
                    s.TacticsTroopSacrificeReductionValue = -0.003f;

                    s.TrackingRadiusValue = 0.3f;
                    s.TrackingSpottingDistanceValue = 0.18f;
                    s.TrackingTrackInformationValue = 0.12f;

                    s.RogueryLootBonusValue = 0.0075f;

                    // ---------------------- SOCIAL ---------------------- //
                    s.CharmRelationBonusValue = 0.015f;
                    s.TradePenaltyReductionValue = 0.006f;

                    s.LeadershipMoraleBonusValue = 0.3f;
                    s.LeadershipGarrisonSizeBonusValue = 0.6f;

                    // ---------------------- INTELLIGENCE ---------------------- //
                    s.SurgeonSurvivalBonusValue = 0.0075f;

                    s.HealingRateBonusForHeroesValue = 0.015f;
                    s.HealingRateBonusForRegularsValue = 0.03f;

                    s.GovernorHealingRateBonusValue = 0.003f;

                    s.SiegeEngineProductionBonusValue = 0.003f;
                    s.TownProjectBuildingBonusValue = 0.0075f;

                    s.StewardPartySizeBonusValue = 0.75f;

                    // ---------------------- STEALTH ---------------------- //
                    s.SneakDamageBonusValue = 0.006f;
                    s.CrouchedSpeedBonusValue = 0.0015f;
                    s.NoiseSuppressionBonusValue = 0.0075f;

                    return s;
                }
            );

            // 3) My joints hurt
            yield return new MemorySettingsPreset(
                Id,
                "senior",
                "My joints hurt",
                () => {
                    var s = (MCMSettings)CreateNew();

                    // ---------------------- VIGOR ---------------------- //
                    s.OneHandedSpeedValue = -0.003f;
                    s.OneHandedDamageValue = 0.0002f;

                    s.TwoHandedSpeedValue = -0.003f;
                    s.TwoHandedDamageValue = 0.0003f;

                    s.PolearmSpeedValue = -0.003f;
                    s.PolearmDamageValue = 0.0002f;

                    // ---------------------- CONTROL ---------------------- //
                    s.BowDamageValue = 0.0002f;
                    s.BowAccuracyValue = -0.005f;

                    s.ThrowingSpeedValue = -0.003f;
                    s.ThrowingDamageValue = 0.0002f;
                    s.ThrowingAccuracyValue = -0.004f;

                    s.CrossbowReloadSpeedValue = -0.003f;
                    s.CrossbowAccuracyValue = -0.004f;

                    // ---------------------- ENDURANCE ---------------------- //
                    s.HorseSpeedValue = -0.01f;
                    s.HorseManeuverValue = -0.003f;

                    s.MountWeaponDamagePenaltyValue = 0.0005f;
                    s.MountWeaponSpeedPenaltyValue = 0.001f;

                    s.DismountResistanceValue = 0.0005f;

                    s.AthleticsSpeedFactorValue = -0.001f;
                    s.AthleticsWeightFactorValue = 0.005f;

                    s.KnockBackResistanceValue = 0.0005f;
                    s.KnockDownResistanceValue = 0.0005f;

                    s.SmithingLevelValue = 0.4f;

                    // ---------------------- CUNNING ---------------------- //
                    s.TacticsAdvantageValue = -0.002f;
                    s.TacticsTroopSacrificeReductionValue = -0.002f;

                    s.TrackingRadiusValue = 0.03f;
                    s.TrackingSpottingDistanceValue = 0.05f;
                    s.TrackingTrackInformationValue = 0.01f;

                    s.RogueryLootBonusValue = 0.001f;

                    // ---------------------- SOCIAL ---------------------- //
                    s.CharmRelationBonusValue = 0.005f;
                    s.TradePenaltyReductionValue = 0.001f;

                    s.LeadershipMoraleBonusValue = 0.005f;
                    s.LeadershipGarrisonSizeBonusValue = 0.05f;

                    // ---------------------- INTELLIGENCE ---------------------- //
                    s.SurgeonSurvivalBonusValue = 0.0005f;

                    s.HealingRateBonusForHeroesValue = 0.001f;
                    s.HealingRateBonusForRegularsValue = 0.002f;

                    s.GovernorHealingRateBonusValue = 0.0005f;

                    s.SiegeEngineProductionBonusValue = 0.001f;
                    s.TownProjectBuildingBonusValue = 0.001f;

                    s.StewardPartySizeBonusValue = 0.1f;

                    // ---------------------- STEALTH ---------------------- //
                    s.SneakDamageBonusValue = -0.002f;
                    s.CrouchedSpeedBonusValue = -0.004f;
                    s.NoiseSuppressionBonusValue = -0.002f;

                    return s;
                }
        );
        }
    }
}