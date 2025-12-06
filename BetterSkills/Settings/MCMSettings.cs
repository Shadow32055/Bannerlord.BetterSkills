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
        [SettingPropertyFloatingInteger(RefValues.OneHandedSpeedText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float OneHandedSpeedValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.VigorText)]
        [SettingPropertyFloatingInteger(RefValues.OneHandedDamageText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float OneHandedDamageValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.VigorText)]
        [SettingPropertyFloatingInteger(RefValues.TwoHandedSpeedText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float TwoHandedSpeedValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.VigorText)]
        [SettingPropertyFloatingInteger(RefValues.TwoHandedDamageText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float TwoHandedDamageValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.VigorText)]
        [SettingPropertyFloatingInteger(RefValues.PolearmSpeedText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float PolearmSpeedValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.VigorText)]
        [SettingPropertyFloatingInteger(RefValues.PolearmDamageText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float PolearmDamageValue { get; set; } = 0.003f;

        // ---------------------- Control SKILLS ---------------------- //

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.BowDmgText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float BowDamageValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.BowAccuracyText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float BowAccuracyValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.ThrowingSpeedText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float ThrowingSpeedValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.ThrowingDamageText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float ThrowingDamageValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.ThrowingAccText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float ThrowingAccuracyValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.CrossbowReloadText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float CrossbowReloadSpeedValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.ControlText)]
        [SettingPropertyFloatingInteger(RefValues.CrossbowAccText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float CrossbowAccuracyValue { get; set; } = 0.003f;

        // ---------------------- Endurance SKILLS ---------------------- //

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.HorseSpeedText, -5f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float HorseSpeedValue { get; set; } = 0.05f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.HorseManeuverText, -5f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float HorseManeuverValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.MountWepDmgPenText, -5f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float MountWeaponDamagePenaltyValue { get; set; } = -0.05f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.MountWepSpeedPenText, -5f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float MountWeaponSpeedPenaltyValue { get; set; } = -0.05f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.DismountResText, -5f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float DismountResistanceValue { get; set; } = 0.02f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.AthleticsSpeedText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float AthleticsSpeedFactorValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.AthleticsWeigthText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float AthleticsWeightFactorValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.KnockbackResText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float KnockBackResistanceValue { get; set; } = 0.02f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.KnockdownResText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float KnockDownResistanceValue { get; set; } = 0.02f;

        [SettingPropertyGroup(RefValues.EnduranceText)]
        [SettingPropertyFloatingInteger(RefValues.SmithingLevelText, 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float SmithingLevelValue { get; set; } = 0.5f;

        // ---------------------- Cunning SKILLS ---------------------- //

        [SettingPropertyGroup(RefValues.CunningText, GroupOrder = 3)]
        [SettingPropertyFloatingInteger(RefValues.TacticsAdvText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float TacticsAdvantageValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.TacticsSacrificeRedText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float TacticsTroopSacrificeReductionValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.TrackingText, -5f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float TrackingRadiusValue { get; set; } = 0.02f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.TrackingSpotText, -5f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float TrackingSpottingDistanceValue { get; set; } = 0.02f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.TrackingInfoText, -5f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float TrackingTrackInformationValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.CunningText)]
        [SettingPropertyFloatingInteger(RefValues.LootBonusText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float RogueryLootBonusValue { get; set; } = 0.02f;

        // ---------------------- Social SKILLS ---------------------- //

        [SettingPropertyGroup(RefValues.SocialText, GroupOrder = 4)]
        [SettingPropertyFloatingInteger(RefValues.CharmRelText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float CharmRelationBonusValue { get; set; } = 0.02f;

        [SettingPropertyGroup(RefValues.SocialText)]
        [SettingPropertyFloatingInteger(RefValues.TradePenText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float TradePenaltyReductionValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.SocialText)]
        [SettingPropertyFloatingInteger(RefValues.LeaderMoralText, -5f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float LeadershipMoraleBonusValue { get; set; } = 0.2f;

        [SettingPropertyGroup(RefValues.SocialText)]
        [SettingPropertyFloatingInteger(RefValues.LeaderGarrisonText, -5f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float LeadershipGarrisonSizeBonusValue { get; set; } = 0.2f;

        // ---------------------- Intelligence SKILLS ---------------------- //

        [SettingPropertyGroup(RefValues.IntelligenceText, GroupOrder = 5)]
        [SettingPropertyFloatingInteger(RefValues.SurviorText, -5f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float SurgeonSurvivalBonusValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.HealingHeroesText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float HealingRateBonusForHeroesValue { get; set; } = 0.02f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.HealingRegularsText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float HealingRateBonusForRegularsValue { get; set; } = 0.02f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.HealingRateText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float GovernorHealingRateBonusValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.SiegeEngineText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float SiegeEngineProductionBonusValue { get; set; } = 0.003f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.TownProjectText, -0.003f, 0.05f, "0.00 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericFactorHintText)]
        public float TownProjectBuildingBonusValue { get; set; } = 0.02f;

        [SettingPropertyGroup(RefValues.IntelligenceText)]
        [SettingPropertyFloatingInteger(RefValues.PartySizeText, -5f, 5f, "0.00", Order = 0, RequireRestart = false, HintText = RefValues.GenericAddHintText)]
        public float StewardPartySizeBonusValue { get; set; } = 0.05f;


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

                    s.BowDamageValue = 0f;
                    s.BowAccuracyValue = 0f;
                    s.ThrowingSpeedValue = 0f;
                    s.ThrowingDamageValue = 0f;
                    s.ThrowingAccuracyValue = 0f;
                    s.CrossbowReloadSpeedValue = 0f;
                    s.CrossbowAccuracyValue = 0f;

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

                    return s;
                }
            );

            // 2) Arcade Preset
            yield return new MemorySettingsPreset(
                Id,
                "arcade",
                "Arcade",
                () =>
                {
                    var s = (MCMSettings)CreateNew();

                    // ---------------------- VIGOR ---------------------- //
                    s.OneHandedSpeedValue = 0.006f;
                    s.OneHandedDamageValue = 0.006f;

                    s.TwoHandedSpeedValue = 0.006f;
                    s.TwoHandedDamageValue = 0.006f;

                    s.PolearmSpeedValue = 0.006f;
                    s.PolearmDamageValue = 0.006f;

                    // ---------------------- CONTROL ---------------------- //
                    s.BowDamageValue = 0.006f;
                    s.BowAccuracyValue = 0.006f;

                    s.ThrowingSpeedValue = 0.006f;
                    s.ThrowingDamageValue = 0.006f;
                    s.ThrowingAccuracyValue = 0.006f;

                    s.CrossbowReloadSpeedValue = 0.006f;
                    s.CrossbowAccuracyValue = 0.006f;

                    // ---------------------- ENDURANCE ---------------------- //
                    s.HorseSpeedValue = 0.10f;           // default 0.05
                    s.HorseManeuverValue = 0.006f;       // default 0.003

                    s.MountWeaponDamagePenaltyValue = -0.10f; // default -0.05
                    s.MountWeaponSpeedPenaltyValue = -0.10f;

                    s.DismountResistanceValue = 0.04f;   // default 0.02

                    s.AthleticsSpeedFactorValue = 0.006f;
                    s.AthleticsWeightFactorValue = 0.006f;

                    s.KnockBackResistanceValue = 0.04f;  // default 0.02
                    s.KnockDownResistanceValue = 0.04f;  // default 0.02

                    s.SmithingLevelValue = 1.0f;         // default 0.5

                    // ---------------------- CUNNING ---------------------- //
                    s.TacticsAdvantageValue = 0.006f;
                    s.TacticsTroopSacrificeReductionValue = 0.006f;

                    s.TrackingRadiusValue = 0.04f;       // default 0.02
                    s.TrackingSpottingDistanceValue = 0.04f;
                    s.TrackingTrackInformationValue = 0.006f;

                    s.RogueryLootBonusValue = 0.04f;     // default 0.02

                    // ---------------------- SOCIAL ---------------------- //
                    s.CharmRelationBonusValue = 0.04f;   // default 0.02
                    s.TradePenaltyReductionValue = 0.006f;

                    s.LeadershipMoraleBonusValue = 0.4f; // default 0.2
                    s.LeadershipGarrisonSizeBonusValue = 0.4f;

                    // ---------------------- INTELLIGENCE ---------------------- //
                    s.SurgeonSurvivalBonusValue = 0.006f;

                    s.HealingRateBonusForHeroesValue = 0.04f;    // default 0.02
                    s.HealingRateBonusForRegularsValue = 0.04f;  // default 0.02
                    s.GovernorHealingRateBonusValue = 0.006f;

                    s.SiegeEngineProductionBonusValue = 0.006f;
                    s.TownProjectBuildingBonusValue = 0.04f;     // default 0.02

                    s.StewardPartySizeBonusValue = 0.10f;        // default 0.05

                    return s;
                }
            );

            // 3) My joints hurt
            yield return new MemorySettingsPreset(
                Id,
                "senior",
                "My joints hurt",
                () =>
                {
                    var s = (MCMSettings)CreateNew();

                    // ---------------------- VIGOR (slow weak attacks) ---------------------- //
                    s.OneHandedSpeedValue = -0.003f;
                    s.OneHandedDamageValue = -0.003f;

                    s.TwoHandedSpeedValue = -0.003f;
                    s.TwoHandedDamageValue = -0.003f;

                    s.PolearmSpeedValue = -0.003f;
                    s.PolearmDamageValue = -0.003f;

                    // ---------------------- CONTROL (sand in the eyes) ---------------------- //
                    s.BowDamageValue = -0.003f;
                    s.BowAccuracyValue = -0.003f;

                    s.ThrowingSpeedValue = -0.003f;
                    s.ThrowingDamageValue = -0.003f;
                    s.ThrowingAccuracyValue = -0.003f;

                    s.CrossbowReloadSpeedValue = -0.003f;
                    s.CrossbowAccuracyValue = -0.003f;

                    // ---------------------- ENDURANCE (slooooow bodies) ---------------------- //
                    s.HorseSpeedValue = -0.003f;         // horses exhausted
                    s.HorseManeuverValue = -0.003f;

                    s.MountWeaponDamagePenaltyValue = 0.02f; // makes mounted worse
                    s.MountWeaponSpeedPenaltyValue = 0.02f;

                    s.DismountResistanceValue = -0.01f; // easier to knock off

                    s.AthleticsSpeedFactorValue = -0.001f;   // walking through molasses
                    s.AthleticsWeightFactorValue = -0.001f;  // armor feels heavier

                    s.KnockBackResistanceValue = -0.01f;
                    s.KnockDownResistanceValue = -0.01f;

                    s.SmithingLevelValue = 0.2f;  // old craftsmen still know some tricks

                    // ---------------------- CUNNING (fading senses) ---------------------- //
                    s.TacticsAdvantageValue = -0.002f;
                    s.TacticsTroopSacrificeReductionValue = -0.001f;

                    s.TrackingRadiusValue = -0.01f;
                    s.TrackingSpottingDistanceValue = -0.01f;
                    s.TrackingTrackInformationValue = -0.002f;

                    s.RogueryLootBonusValue = -0.01f;

                    // ---------------------- SOCIAL (wise elders) ---------------------- //
                    s.CharmRelationBonusValue = 0.04f;  // Elders respected
                    s.TradePenaltyReductionValue = 0.01f;

                    s.LeadershipMoraleBonusValue = 0.1f; // seasoned veterans
                    s.LeadershipGarrisonSizeBonusValue = 0.1f;

                    // ---------------------- INTELLIGENCE (old = wise & tough) ---------------------- //
                    s.SurgeonSurvivalBonusValue = 0.01f;

                    s.HealingRateBonusForHeroesValue = 0.01f;
                    s.HealingRateBonusForRegularsValue = 0.01f;

                    s.GovernorHealingRateBonusValue = 0.01f;

                    s.SiegeEngineProductionBonusValue = -0.002f; // weak backs
                    s.TownProjectBuildingBonusValue = -0.01f;

                    s.StewardPartySizeBonusValue = -0.02f; // fewer helpers

                    return s;
                }
        );
        }
    }
}