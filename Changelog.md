# Changelog
All notable changes to this project will be documented in this file.

The format follows [Semantic Versioning](https://semver.org/) and is inspired by [Keep a Changelog](https://keepachangelog.com/).

---

## [Unreleased]

### Added
- 

### Changed
- 

### Deprecated
- 

### Removed
- 

### Fixed
- 

---

## [1.5] - 2025-12-08

### Fixed

* Fixed several localization texts that shared IDs.
* Fixed incorrect strings for certain skills.
* Fixed incorrect default modifiers for some skills (e.g., **DismountResistance** should start at 40%).
* Fixed an issue where some skill penalties could reach invalid values (i.e., penalties becoming bonuses).

### Added

* Added a Changelog.md
* Introduced a new party speed `skillEffect` based on the Scouting skill:
  * Party speed bonus per skill level (default: **0.003**).
  * Player-only option available.
  * Applies only on land (sea movement should be affected by NavalSkills).
* Added the new Roguery `skillEffects` from Bannerlord **1.3.9**:
  * Sneak damage bonus.
  * Crouched movement speed bonus.
  * Noise suppression bonus.
* Added several min/max limits to `skillEffects` to prevent unrealistic or extreme values.

### Changed

* Minor fixes for presets and default settings.
* Adjusted most sliders to be more symmetrical.

## [1.4] - 2025-12-06

### Fixed
- minor .proj fixes

### Added
- Support for bannerlord **1.3.9**

### Changed
- updated Bannerlord.ReferenceAssemblies to **1.3.9.103334**
- updated Bannerlord.ButterLib to **2.10.3**
- updated Bannerlord.MCM to **5.11.3**
- updated Bannerlord.UIExtenderEx to **2.13.2**
- updated Bannerlord.Harmony to **2.4.2**

### Removed
- removed deprecated `SkillEffects`
  - _effectBowLevel
  - _effectHorseLevel 
  - _effectTrackingLevel
  - _effectEngineerLevel 
