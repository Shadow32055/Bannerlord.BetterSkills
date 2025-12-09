using BetterCore.Utils;
using BetterSkills.Patches;
using BetterSkills.Settings;
using HarmonyLib;
using System;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BetterSkills {
    public class BetterSkills : MBSubModuleBase {
        public static MCMSettings Settings { get; private set; } = new MCMSettings();
        public static string ModName { get; private set; } = "BetterSkills";

        private bool isInitialized = false;
        private bool isLoaded = false;
        private Harmony _harmony;

        //FIRST
        protected override void OnSubModuleLoad() {
            try {
                base.OnSubModuleLoad();

                if (isInitialized)
                    return;

                _harmony = new("Bannerlord.Shadow." + ModName);
                _harmony.PatchAll();

                isInitialized = true;
            } catch (Exception e) {
                NotifyHelper.WriteError(ModName, "OnSubModuleLoad threw exception " + e);
            }
        }

        //SECOND
        protected override void OnBeforeInitialModuleScreenSetAsRoot() {
            try {
                base.OnBeforeInitialModuleScreenSetAsRoot();

                if (isLoaded)
                    return;

                ModName = base.GetType().Assembly.GetName().Name;

                Settings = MCMSettings.Instance ?? throw new NullReferenceException("Settings are null");

                if (isInitialized)
                    NotifyHelper.WriteMessage(ModName + " Loaded.", MsgType.Good);
                else
                    NotifyHelper.WriteMessage(ModName + " failed to load.", MsgType.Warning);

                Integrations.BetterSkillsLoaded = true;

                isLoaded = true;
            } catch (Exception e) {
                NotifyHelper.WriteError(ModName, "OnBeforeInitialModuleScreenSetAsRoot threw exception " + e);
            }
        }

        // On game start 
        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);

            if (game.GameType is Campaign)
            {
                CampaignEvents.OnGameLoadedEvent.AddNonSerializedListener(this, OnCampaignReady);
            }
        }

        // On game loaded
        private void OnCampaignReady(CampaignGameStarter starter)
        {
            if (!PartySpeedPatch.PatchPartySpeedModel(_harmony))
            {
                NotifyHelper.WriteError(ModName, "PartySpeedPatch failed to patch");
            }
        }
    }
}
