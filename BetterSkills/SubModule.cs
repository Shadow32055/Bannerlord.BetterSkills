using BetterCore.Utils;
using BetterSkills.Settings;
using HarmonyLib;
using TaleWorlds.MountAndBlade;

namespace BetterSkills {
    public class SubModule : MBSubModuleBase {
		public static MCMSettings _settings;
		protected override void OnSubModuleLoad() {
			base.OnSubModuleLoad();

            Harmony h = new("Bannerlord.Shadow.BetterSkills");

            h.PatchAll();
        }

		protected override void OnBeforeInitialModuleScreenSetAsRoot() {
			base.OnBeforeInitialModuleScreenSetAsRoot();

			string modName = base.GetType().Assembly.GetName().Name;

			Helper.SetModName(modName);

            if (MCMSettings.Instance is not null) {
                _settings = MCMSettings.Instance;
            } else {
                Logger.SendMessage("Failed to find settings instance!", Severity.High);
            }
        }
	}
}
