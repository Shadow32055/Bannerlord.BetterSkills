namespace BetterSkills.Settings {
    public class DefaultSettings : ISettings {
        public float OneHandedSpeedValue { get; set; } = 0.07f;
        public float OneHandedDamageValue { get; set; } = 0.15f;
        public float TwoHandedSpeedValue { get; set; } = 0.06f;
        public float TwoHandedDamageValue { get; set; } = 0.16f;
        public float PolearmSpeedValue { get; set; } = 0.06f;
        public float PolearmDamageValue { get; set; } = 0.07f;
        public float BowLevelValue { get; set; } = 1f;
        public float BowDamageValue { get; set; } = 0.11f;
        public float BowAccuracyValue { get; set; } = 0.09f;
        public float ThrowingSpeedValue { get; set; } = 0.07f;
        public float ThrowingDamageValue { get; set; } = 0.06f;
        public float ThrowingAccuracyValue { get; set; } = 0.06f;
        public float CrossbowReloadSpeedValue { get; set; } = 0.07f;
        public float CrossbowAccuracyValue { get; set; } = 0.05f;
        public float HorseLevelValue { get; set; } = 1f;
        public float HorseSpeedValue { get; set; } = 0.2f;
        public float HorseManeuverValue { get; set; } = 0.04f;
        public float MountWeaponDamagePenaltyValue { get; set; } = -0.2f;
        public float MountWeaponSpeedPenaltyValue { get; set; } = -0.3f;
        public float DismountResistanceValue { get; set; } = 0.1f;
        public float AthleticsSpeedFactorValue { get; set; } = 0.1f;
        public float AthleticsWeightFactorValue { get; set; } = 0.1f;
        public float KnockBackResistanceValue { get; set; } = 0.1f;
        public float KnockDownResistanceValue { get; set; } = 0.1f;
        public float SmithingLevelValue { get; set; } = 1f;
        public float TacticsAdvantageValue { get; set; } = 0.1f;
        public float TacticsTroopSacrificeReductionValue { get; set; } = 0.1f;
        public float TrackingRadiusValue { get; set; } = 0.1f;
        public float TrackingLevelValue { get; set; } = 1f;
        public float TrackingSpottingDistanceValue { get; set; } = 0.06f;
        public float TrackingTrackInformationValue { get; set; } = 0.04f;
        public float RogueryLootBonusValue { get; set; } = 0.25f;
        public float CharmRelationBonusValue { get; set; } = 0.5f;
        public float TradePenaltyReductionValue { get; set; } = 0.2f;
        public float LeadershipMoraleBonusValue { get; set; } = 0.1f;
        public float LeadershipGarrisonSizeBonusValue { get; set; } = 0.2f;
        public float SurgeonSurvivalBonusValue { get; set; } = 0.01f;
        public float HealingRateBonusForHeroesValue { get; set; } = 0.5f;
        public float HealingRateBonusForRegularsValue { get; set; } = 1f;
        public float GovernorHealingRateBonusValue { get; set; } = 0.1f;
        public float SiegeEngineProductionBonusValue { get; set; } = 0.1f;
        public float TownProjectBuildingBonusValue { get; set; } = 0.25f;
        public float StewardPartySizeBonusValue { get; set; } = 0.25f;
        public float EngineerLevelValue { get; set; } = 1f;
    }
}
