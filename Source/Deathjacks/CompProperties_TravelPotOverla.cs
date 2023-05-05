using UnityEngine;
using Verse;

namespace Deathjacks;

public class CompProperties_TravelPotOverlay : CompProperties
{
    public float fireSize = 1f;

    public Vector3 offset;

    public CompProperties_TravelPotOverlay()
    {
        compClass = typeof(CompTravelPotOverlay);
    }

    public void DrawGhost(IntVec3 center, Rot4 rot, ThingDef thingDef, Color ghostCol, AltitudeLayer drawAltitude)
    {
        var graphic = GhostUtility.GhostGraphicFor(CompTravelPotOverlay.FirePotGraphic, thingDef, ghostCol);
        graphic.DrawFromDef(center.ToVector3ShiftedWithAltitude(drawAltitude), rot, thingDef);
    }
}