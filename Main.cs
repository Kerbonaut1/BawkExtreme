using MelonLoader;
using UnityEngine;

namespace BawkExtreme
{
    public static class BuildInfo
    {
        public const string Name = "BawkExtreme"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "BawkExtreme replaces the hardest difficulty to a stupid fast speed"; // Description for the Mod.  (Set as null if none)
        public const string Author = "Kerbonaut"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "0.1.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class TestMod : MelonMod
    {
        public override void OnInitializeMelon() {
            MelonLogger.Msg("Get ready mother clucker!");
        }

        public float MoveSpeed = 2.5f;

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            MelonLogger.Msg("Reset Speed");
            // set time scale to 10
            Time.timeScale = MoveSpeed;

            // set fixed time step to 0.02
            Time.fixedDeltaTime = 0.02f;
            MoveSpeed = 2.5f;
            MelonLogger.Msg($"Move speed: {MoveSpeed}");
            MelonLogger.Msg($"Time Scale: {Time.timeScale}");
        }

        // every 60 frames
        public override void OnFixedUpdate()
        {
            // every 60 frames up the speed
            MoveSpeed += 0.01f * Time.deltaTime;
            // print move speed
            //MelonLogger.Msg($"Move speed: {MoveSpeed}");
        }


        // pre physics update
        public override void OnUpdate() {

            //MelonLogger.Msg($"MoveSpeed: {MoveSpeed}");

            if (Time.timeScale > 2)
            {
                // set time scale to 10
                Time.timeScale = MoveSpeed;

                // set fixed time step to 0.02
                Time.fixedDeltaTime = 0.02f;
            }
        }

        // end of the frame unlock the time scale
        public override void OnLateUpdate() {
            if (Time.timeScale > 2)
            {
                // set time scale to 1
                Time.timeScale = MoveSpeed;

                // set fixed time step to 0.02
                Time.fixedDeltaTime = 0.02f;
            }
        }
    }
}