using BepInEx;

namespace AbelMuak.ExpressYourself
{
    [BepInPlugin(ey_guid, ey_name, ey_version)]
    public class ExpressYourself : BaseUnityPlugin
    {
        public const string ey_guid = "abelmuak.expressyourself";
        public const string ey_name = "abelmuak.expressyourself";
        public const string ey_version = "abelmuak.expressyourself";

        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {ey_guid} is loaded!");
        }
    }
}