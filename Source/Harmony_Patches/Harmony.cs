using System.Reflection;
using HarmonyLib;
using Verse;

namespace ProgressRenderer
{

    [StaticConstructorOnStartup]
    class Harmony
    {

        static Harmony()
        {
            var harmony = new HarmonyLib.Harmony("rimworld.lanilor.progressrenderer");
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            //harmony.Patch(AccessTools.Method(AccessTools.TypeByName("RiverMaker"), "ValidatePassage"), null, new HarmonyMethod(typeof(Harmony_RiverMaker_ValidatePassage), "Postfix"));
            
        }

    }

}
