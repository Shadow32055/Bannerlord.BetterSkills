using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace BetterSkills.Settings {

    internal class MCMSettings : AttributeGlobalSettings<MCMSettings>, ISettings {

        const string genericHintText = "Increase of value per skill level (value of 1%, means 300% increase at skill level 300 )";


        [SettingPropertyGroup("Vigor")]
        [SettingPropertyFloatingInteger("One handed weapon speed", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float OneHandedSpeedValue { get; set; } = 0.07f;

        [SettingPropertyGroup("Vigor")]
        [SettingPropertyFloatingInteger("One handed weapon damage", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float OneHandedDamageValue { get; set; } = 0.15f;

        [SettingPropertyGroup("Vigor")]
        [SettingPropertyFloatingInteger("Two handed weapon speed", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float TwoHandedSpeedValue { get; set; } = 0.06f;

        [SettingPropertyGroup("Vigor")]
        [SettingPropertyFloatingInteger("Two handed weapon damage", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float TwoHandedDamageValue { get; set; } = 0.16f;

        [SettingPropertyGroup("Vigor")]
        [SettingPropertyFloatingInteger("Polearm weapon speed", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float PolearmSpeedValue { get; set; } = 0.06f;

        [SettingPropertyGroup("Vigor")]
        [SettingPropertyFloatingInteger("Polearm weapon damage", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float PolearmDamageValue { get; set; } = 0.07f;

        [SettingPropertyGroup("Control")]
        [SettingPropertyFloatingInteger("Max usable bow difficulty", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float BowLevelValue { get; set; } = 1f;

        [SettingPropertyGroup("Control")]
        [SettingPropertyFloatingInteger("Bow Damage", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float BowDamageValue { get; set; } = 0.11f;

        [SettingPropertyGroup("Control")]
        [SettingPropertyFloatingInteger("Bow Accuracy", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float BowAccuracyValue { get; set; } = 0.09f;

        [SettingPropertyGroup("Control")]
        [SettingPropertyFloatingInteger("Thrown weapon speed", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float ThrowingSpeedValue { get; set; } = 0.07f;

        [SettingPropertyGroup("Control")]
        [SettingPropertyFloatingInteger("Thrown weapon damage", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float ThrowingDamageValue { get; set; } = 0.06f;

        [SettingPropertyGroup("Control")]
        [SettingPropertyFloatingInteger("Thrown weapon accuracy", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float ThrowingAccuracyValue { get; set; } = 0.06f;

        [SettingPropertyGroup("Control")]
        [SettingPropertyFloatingInteger("Crossbow reload speed", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float CrossbowReloadSpeedValue { get; set; } = 0.07f;

        [SettingPropertyGroup("Control")]
        [SettingPropertyFloatingInteger("Crossbow accuracy", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float CrossbowAccuracyValue { get; set; } = 0.05f;

        [SettingPropertyGroup("Endurance")]
        [SettingPropertyFloatingInteger("Max mount difficulty", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float HorseLevelValue { get; set; } = 1f;

        [SettingPropertyGroup("Endurance")]
        [SettingPropertyFloatingInteger("Horse speed", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float HorseSpeedValue { get; set; } = 0.2f;

        [SettingPropertyGroup("Endurance")]
        [SettingPropertyFloatingInteger("Horse maneuver", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float HorseManeuverValue { get; set; } = 0.04f;

        [SettingPropertyGroup("Endurance")]
        [SettingPropertyFloatingInteger("Mounted weapon damage penalty", -100f, 0f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float MountWeaponDamagePenaltyValue { get; set; } = -0.2f;

        [SettingPropertyGroup("Endurance")]
        [SettingPropertyFloatingInteger("Mounted weapon speed & reload penalty", -100f, 0f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float MountWeaponSpeedPenaltyValue { get; set; } = -0.3f;

        [SettingPropertyGroup("Endurance")]
        [SettingPropertyFloatingInteger("Dismount resistance", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float DismountResistanceValue { get; set; } = 0.1f;

        [SettingPropertyGroup("Endurance")]
        [SettingPropertyFloatingInteger("Running speed increased by", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float AthleticsSpeedFactorValue { get; set; } = 0.1f;

        [SettingPropertyGroup("Endurance")]
        [SettingPropertyFloatingInteger("Weight penalty reduced by", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float AthleticsWeightFactorValue { get; set; } = 0.1f;

        [SettingPropertyGroup("Endurance")]
        [SettingPropertyFloatingInteger("Knock back resistance", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float KnockBackResistanceValue { get; set; } = 0.1f;

        [SettingPropertyGroup("Endurance")]
        [SettingPropertyFloatingInteger("Knock down resistance", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float KnockDownResistanceValue { get; set; } = 0.1f;

        [SettingPropertyGroup("Endurance")]
        [SettingPropertyFloatingInteger("Max difficulty of weapon that can be smithed without penalty", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float SmithingLevelValue { get; set; } = 1f;

        [SettingPropertyGroup("Cunning")]
        [SettingPropertyFloatingInteger("Simulation advantage", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float TacticsAdvantageValue { get; set; } = 0.1f;

        [SettingPropertyGroup("Cunning")]
        [SettingPropertyFloatingInteger("Decrease the sacrificed troop number when trying to get away", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float TacticsTroopSacrificeReductionValue { get; set; } = 0.1f;

        [SettingPropertyGroup("Cunning")]
        [SettingPropertyFloatingInteger("Track detection radius", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float TrackingRadiusValue { get; set; } = 0.1f;

        [SettingPropertyGroup("Cunning")]
        [SettingPropertyFloatingInteger("Max track difficulty that can be detected", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float TrackingLevelValue { get; set; } = 1f;

        [SettingPropertyGroup("Cunning")]
        [SettingPropertyFloatingInteger("Spotting distance", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float TrackingSpottingDistanceValue { get; set; } = 0.06f;

        [SettingPropertyGroup("Cunning")]
        [SettingPropertyFloatingInteger("Track information level", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float TrackingTrackInformationValue { get; set; } = 0.04f;

        [SettingPropertyGroup("Cunning")]
        [SettingPropertyFloatingInteger("Battle Loot", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float RogueryLootBonusValue { get; set; } = 0.25f;

        [SettingPropertyGroup("Social")]
        [SettingPropertyFloatingInteger("Relation increase with NPCs", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float CharmRelationBonusValue { get; set; } = 0.5f;

        [SettingPropertyGroup("Social")]
        [SettingPropertyFloatingInteger("Trade penalty Reduction", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float TradePenaltyReductionValue { get; set; } = 0.2f;

        [SettingPropertyGroup("Social")]
        [SettingPropertyFloatingInteger("Increase morale of the parties under your command", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float LeadershipMoraleBonusValue { get; set; } = 0.1f;

        [SettingPropertyGroup("Social")]
        [SettingPropertyFloatingInteger("Increase garrison size by", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float LeadershipGarrisonSizeBonusValue { get; set; } = 0.2f;

        [SettingPropertyGroup("Intelligence")]
        [SettingPropertyFloatingInteger("Casualty survival chance", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float SurgeonSurvivalBonusValue { get; set; } = 0.01f;

        [SettingPropertyGroup("Intelligence")]
        [SettingPropertyFloatingInteger("Healing rate increase for heroes", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float HealingRateBonusForHeroesValue { get; set; } = 0.5f;

        [SettingPropertyGroup("Intelligence")]
        [SettingPropertyFloatingInteger("Healing rate increase for troops", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float HealingRateBonusForRegularsValue { get; set; } = 1f;

        [SettingPropertyGroup("Intelligence")]
        [SettingPropertyFloatingInteger("Healing rate increase", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float GovernorHealingRateBonusValue { get; set; } = 0.1f;

        [SettingPropertyGroup("Intelligence")]
        [SettingPropertyFloatingInteger("Faster siege engine production", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float SiegeEngineProductionBonusValue { get; set; } = 0.1f;

        [SettingPropertyGroup("Intelligence")]
        [SettingPropertyFloatingInteger("Faster building production", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float TownProjectBuildingBonusValue { get; set; } = 0.25f;

        [SettingPropertyGroup("Intelligence")]
        [SettingPropertyFloatingInteger("Increase party size by", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float StewardPartySizeBonusValue { get; set; } = 0.25f;

        [SettingPropertyGroup("Intelligence")]
        [SettingPropertyFloatingInteger("Max difficulty of siege engine that can be built", 0f, 100f, "0.00", Order = 0, RequireRestart = false, HintText = genericHintText)]
        public float EngineerLevelValue { get; set; } = 1f;



        public override string Id { get { return base.GetType().Assembly.GetName().Name; } }
        public override string DisplayName { get; } = "Better Skills";
        public override string FolderName { get { return base.GetType().Assembly.GetName().Name; } }
        public override string FormatType { get; } = "xml";
        public bool LoadMCMConfigFile { get; set; } = true;

    }
}