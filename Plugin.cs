using BepInEx;
using BepInEx.Logging;
using UnityEngine;


namespace ModTemplate
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        // Until I make this a nuget package please replace the path in Directory.Build.props with your own game path
        // Also go to PluginInfo.cs and put your mods info in it
        void Awake()
        {
            // This is called once when the game is started
            Logger.LogInfo("Get ready mother clucker!");
        }

        public float MoveSpeed = 2.5f;


        // when a new scene is loaded
        void OnLevelWasLoaded(int level)
        {
            // This is called when a new scene is loaded
            Time.timeScale = MoveSpeed;

            // set fixed time step to 0.02
            Time.fixedDeltaTime = 0.02f;
            MoveSpeed = 2.5f;
        }

        // On fixed update is called every frame
        void FixedUpdate()
        {
            if (Time.timeScale > 2.0f)
            {
                MoveSpeed += 0.01f * Time.deltaTime;
            }
        }

        // On update is called every frame
        void Update()
        {
            // This is called every frame
            if (Time.timeScale > 2.0f)
            {
                // set time scale to 10
                Time.timeScale = MoveSpeed;

                // set fixed time step to 0.02
                Time.fixedDeltaTime = 0.02f;
            }
        }
    }
}
