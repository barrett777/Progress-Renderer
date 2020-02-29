using HarmonyLib;
using Verse;
using RimWorld;

namespace ProgressRenderer
{

    [HarmonyPatch(typeof(OverlayDrawHandler), "ShouldDrawPowerGrid", MethodType.Getter)]
    public class Harmony_OverlayDrawHandler_ShouldDrawPowerGrid
    {

        public static bool Prefix()
        {
            if (Find.CurrentMap.GetComponent<MapComponent_RenderManager>().Rendering)
            {
                return false;
            }
            return true;
        }

    }

}
