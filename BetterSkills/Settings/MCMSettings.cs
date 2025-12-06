using BetterSkills.Localizations;
using MCM.Abstractions;
using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;
using System.Collections.Generic;

namespace BetterSkills.Settings
{

    public class MCMSettings : AttributeGlobalSettings<MCMSettings>
    {


        // ---------------------- VIGOR SKILLS ---------------------- //
        [SettingPropertyGroup(RefValues.VigorText, GroupOrder = 0)]
        [SettingPropertyFloatingInteger(RefValues.OneHandedSpeedText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float OneHandedSpeedValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.VigorText)]
        [SettingPropertyFloatingInteger(RefValues.OneHandedDamageText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float OneHandedDamageValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.VigorText)]
        [SettingPropertyFloatingInteger(RefValues.TwoHandedSpeedText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float TwoHandedSpeedValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.VigorText)]
        [SettingPropertyFloatingInteger(RefValues.TwoHandedDamageText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float TwoHandedDamageValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.VigorText)]
        [SettingPropertyFloatingInteger(RefValues.PolearmSpeedText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float PolearmSpeedValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.VigorText)]
        [SettingPropertyFloatingInteger(RefValues.PolearmDamageText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float PolearmDamageValue { get; set; } = 0.01f;

        // ---------------------- Control SKILLS ---------------------- //

        [SettingPropertyGroup(RefValues.ControlText, GroupOrder = 1)]
        [SettingPropertyFloatingInteger(RefValues.BowLevelText, 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float BowLevelValue { get; set; } = 0.5f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.BowDmgText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float BowDamageValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.BowAccuracyText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float BowAccuracyValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.ThrowingSpeedText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float ThrowingSpeedValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.ThrowingDamageText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float ThrowingDamageValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.ThrowingAccText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float ThrowingAccuracyValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.CrossbowReloadText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float CrossbowReloadSpeedValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.CrossbowAccText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float CrossbowAccuracyValue { get; set; } = 0.01f;

        // ---------------------- Endurance SKILLS ---------------------- //

        [SettingPropertyGroup(RefValues.EnduranceText, GroupOrder = 2)]
        [SettingPropertyFloatingInteger(RefValues.HorseLevelText, 0f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float HorseLevelValue { get; set; } = 0.5f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.HorseSpeedText, 0f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float HorseSpeedValue { get; set; } = 0.05f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.HorseManeuverText, 0f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float HorseManeuverValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.MountWepDmgPenText, -5f, 0f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float MountWeaponDamagePenaltyValue { get; set; } = -0.05f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.MountWepSpeedPenText, -5f, 0f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float MountWeaponSpeedPenaltyValue { get; set; } = -0.05f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.DismountResText, 0f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float DismountResistanceValue { get; set; } = 0.02f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.AthleticsSpeedText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float AthleticsSpeedFactorValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.AthleticsWeigthText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float AthleticsWeightFactorValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.KnockbackResText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float KnockBackResistanceValue { get; set; } = 0.02f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.KnockdownResText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float KnockDownResistanceValue { get; set; } = 0.02f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.SmithingLevelText, 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float SmithingLevelValue { get; set; } = 0.5f;

        // ---------------------- Cunning SKILLS ---------------------- //

        [SettingPropertyGroup(RefValues.CunningText, GroupOrder = 3)]
        [SettingPropertyFloatingInteger(RefValues.TacticsAdvText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float TacticsAdvantageValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.TacticsSacrificeRedText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float TacticsTroopSacrificeReductionValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.TrackingText, 0f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float TrackingRadiusValue { get; set; } = 0.02f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.TrackingLevel, 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float TrackingLevelValue { get; set; } = 0.5f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.TrackingSpotText, 0f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float TrackingSpottingDistanceValue { get; set; } = 0.02f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.TrackingInfoText, 0f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float TrackingTrackInformationValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.LootBonusText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float RogueryLootBonusValue { get; set; } = 0.02f;

        // ---------------------- Social SKILLS ---------------------- //

        [SettingPropertyGroup(RefValues.SocialText, GroupOrder = 4)]
        [SettingPropertyFloatingInteger(RefValues.CharmRelText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float CharmRelationBonusValue { get; set; } = 0.02f;

        [SettingPropertyGroup(RefValues.SocialText)]
        [SettingPropertyFloatingInteger(RefValues.TradePenText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float TradePenaltyReductionValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.SocialText)]
        [SettingPropertyFloatingInteger(RefValues.LeaderMoralText, 0f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float LeadershipMoraleBonusValue { get; set; } = 0.2f;

        [SettingPropertyGroup(RefValues.SocialText)]
        [SettingPropertyFloatingInteger(RefValues.LeaderGarrisonText, 0f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float LeadershipGarrisonSizeBonusValue { get; set; } = 0.2f;

        // ---------------------- Intelligence SKILLS ---------------------- //

        [SettingPropertyGroup(RefValues.IntelligenceText, GroupOrder = 5)]
        [SettingPropertyFloatingInteger(RefValues.SurviorText, 0f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float SurgeonSurvivalBonusValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.HealingHeroesText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float HealingRateBonusForHeroesValue { get; set; } = 0.02f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.HealingRegularsText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float HealingRateBonusForRegularsValue { get; set; } = 0.02f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.HealingRateText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float GovernorHealingRateBonusValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.SiegeEngineText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float SiegeEngineProductionBonusValue { get; set; } = 0.01f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.TownProjectText, 0f, 5f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float TownProjectBuildingBonusValue { get; set; } = 0.02f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.PartySizeText, 0f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float StewardPartySizeBonusValue { get; set; } = 0.05f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.EngineerText, 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float EngineerLevelValue { get; set; } = 0.5f;



        public override string Id { get { return base.GetType().Assembly.GetName().Name; } }
        public override string DisplayName { get { return base.GetType().Assembly.GetName().Name; } }
        public override string FolderName { get { return base.GetType().Assembly.GetName().Name; } }
        public override string FormatType { get; } = "xml";
        public bool LoadMCMConfigFile { get; set; } = true;


        public override IEnumerable<ISettingsPreset> GetBuiltInPresets()
        {
            // Keep the default preset from BaseSettings
            foreach (var preset in base.GetBuiltInPresets())
                yield return preset;

            // ---- Custom Presets ----

            // 1) Arcade Preset
            yield return new MemorySettingsPreset(
                Id,
                "arcade",
                "Arcade",
                () =>
                {
                    var s = (MCMSettings)CreateNew();

                    // ---------------------- VIGOR ---------------------- //
                    s.OneHandedSpeedValue = 0.20f;
                    s.OneHandedDamageValue = 0.25f;

                    s.TwoHandedSpeedValue = 0.20f;
                    s.TwoHandedDamageValue = 0.25f;

                    s.PolearmSpeedValue = 0.20f;
                    s.PolearmDamageValue = 0.25f;

                    // ---------------------- CONTROL ---------------------- //
                    s.BowLevelValue = 5f;                 // additive
                    s.BowDamageValue = 0.20f;             // factor
                    s.BowAccuracyValue = 0.20f;           // factor

                    s.ThrowingSpeedValue = 0.20f;
                    s.ThrowingDamageValue = 0.25f;
                    s.ThrowingAccuracyValue = 0.20f;

                    s.CrossbowReloadSpeedValue = 0.25f;
                    s.CrossbowAccuracyValue = 0.20f;

                    // ---------------------- ENDURANCE ---------------------- //
                    s.HorseLevelValue = 3f;               // additive
                    s.HorseSpeedValue = 0.50f;            // additive
                    s.HorseManeuverValue = 0.20f;         // additive

                    s.MountWeaponDamagePenaltyValue = -0.00f; // remove penalties completely
                    s.MountWeaponSpeedPenaltyValue = -0.00f;

                    s.DismountResistanceValue = 0.50f;    // additive

                    s.AthleticsSpeedFactorValue = 0.25f;  // factor
                    s.AthleticsWeightFactorValue = 0.20f; // factor
                    s.KnockBackResistanceValue = 0.50f;   // factor
                    s.KnockDownResistanceValue = 0.50f;   // factor

                    s.SmithingLevelValue = 5f;            // additive

                    // ---------------------- CUNNING ---------------------- //
                    s.TacticsAdvantageValue = 0.25f;           // factor
                    s.TacticsTroopSacrificeReductionValue = 0.25f;
                    s.TrackingRadiusValue = 0.20f;
                    s.TrackingLevelValue = 5f;                 // additive
                    s.TrackingSpottingDistanceValue = 0.20f;
                    s.TrackingTrackInformationValue = 0.10f;
                    s.RogueryLootBonusValue = 0.25f;           // factor

                    // ---------------------- SOCIAL ---------------------- //
                    s.CharmRelationBonusValue = 0.25f;         // factor
                    s.TradePenaltyReductionValue = 0.20f;      // factor
                    s.LeadershipMoraleBonusValue = 2f;         // additive
                    s.LeadershipGarrisonSizeBonusValue = 2f;   // additive

                    // ---------------------- INTELLIGENCE ---------------------- //
                    s.SurgeonSurvivalBonusValue = 0.20f;          // additive
                    s.HealingRateBonusForHeroesValue = 0.25f;     // factor
                    s.HealingRateBonusForRegularsValue = 0.25f;   // factor
                    s.GovernorHealingRateBonusValue = 0.20f;
                    s.SiegeEngineProductionBonusValue = 0.25f;     // factor
                    s.TownProjectBuildingBonusValue = 0.25f;       // factor
                    s.StewardPartySizeBonusValue = 0.50f;          // additive
                    s.EngineerLevelValue = 5f;                     // additive

                    return s;
                }
            );

            // 1) Vanilla Preset
            yield return new MemorySettingsPreset(
                Id,
                "vanilla",
                "Vanilla (No Bonuses)",
                () =>
                {
                    var s = (MCMSettings)CreateNew();

                    // everything zero -> behaves like unmodded Bannerlord
                    s.OneHandedSpeedValue = 0f;
                    s.OneHandedDamageValue = 0f;
                    s.TwoHandedSpeedValue = 0f;
                    s.TwoHandedDamageValue = 0f;
                    s.PolearmSpeedValue = 0f;
                    s.PolearmDamageValue = 0f;

                    s.BowLevelValue = 0f;
                    s.BowDamageValue = 0f;
                    s.BowAccuracyValue = 0f;
                    s.ThrowingSpeedValue = 0f;
                    s.ThrowingDamageValue = 0f;
                    s.ThrowingAccuracyValue = 0f;
                    s.CrossbowReloadSpeedValue = 0f;
                    s.CrossbowAccuracyValue = 0f;

                    s.HorseLevelValue = 0f;
                    s.HorseSpeedValue = 0f;
                    s.HorseManeuverValue = 0f;
                    s.MountWeaponDamagePenaltyValue = 0f;
                    s.MountWeaponSpeedPenaltyValue = 0f;
                    s.DismountResistanceValue = 0f;
                    s.AthleticsSpeedFactorValue = 0f;
                    s.AthleticsWeightFactorValue = 0f;
                    s.KnockBackResistanceValue = 0f;
                    s.KnockDownResistanceValue = 0f;
                    s.SmithingLevelValue = 0f;

                    s.TacticsAdvantageValue = 0f;
                    s.TacticsTroopSacrificeReductionValue = 0f;
                    s.TrackingRadiusValue = 0f;
                    s.TrackingLevelValue = 0f;
                    s.TrackingSpottingDistanceValue = 0f;
                    s.TrackingTrackInformationValue = 0f;
                    s.RogueryLootBonusValue = 0f;

                    s.CharmRelationBonusValue = 0f;
                    s.TradePenaltyReductionValue = 0f;
                    s.LeadershipMoraleBonusValue = 0f;
                    s.LeadershipGarrisonSizeBonusValue = 0f;

                    s.SurgeonSurvivalBonusValue = 0f;
                    s.HealingRateBonusForHeroesValue = 0f;
                    s.HealingRateBonusForRegularsValue = 0f;
                    s.GovernorHealingRateBonusValue = 0f;
                    s.SiegeEngineProductionBonusValue = 0f;
                    s.TownProjectBuildingBonusValue = 0f;
                    s.StewardPartySizeBonusValue = 0f;
                    s.EngineerLevelValue = 0f;

                    return s;
                }
            );
        }
    }
}