using HarmonyLib;
using BetterSkills.Utils;
using BetterSkills.Settings;
using TaleWorlds.MountAndBlade;
using TaleWorlds.Core;

namespace BetterSkills {
	public class SubModule : MBSubModuleBase {

		protected override void OnSubModuleLoad() {
			base.OnSubModuleLoad();
		}

		protected override void OnBeforeInitialModuleScreenSetAsRoot() {
			base.OnBeforeInitialModuleScreenSetAsRoot();

			string modName = base.GetType().Assembly.GetName().Name;

			Helper.SetModName(modName);
			Helper.settings = SettingsManager.Instance;
		}

		protected override void OnGameStart(Game g, IGameStarter ig) {
			base.OnGameStart(g, ig);
			new Harmony("Bannerlord.Shadow.BetterSkills").PatchAll();
		}
	}
}
