using RimWorld;
using UnityEngine;
using Verse;

namespace Deathjacks;

[StaticConstructorOnStartup]
public class CompTravelPotOverlay : ThingComp
{
    public static readonly Graphic FirePotGraphic = GraphicDatabase.Get<Graphic_Single>(
        "Things/Building/Production/DeathjackTravelPotOn", ShaderDatabase.TransparentPostLight, Vector2.one,
        Color.white);

    protected CompRefuelable refuelableComp;

    public CompProperties_TravelPotOverlay Props => (CompProperties_TravelPotOverlay)props;

    public override void PostDraw()
    {
        base.PostDraw();
        if (refuelableComp is { HasFuel: false })
        {
            return;
        }

        var drawPos = parent.DrawPos;
        drawPos.y += 3f / 64f;
        FirePotGraphic.Draw(drawPos, Rot4.North, parent);
    }

    public override void PostSpawnSetup(bool respawningAfterLoad)
    {
        base.PostSpawnSetup(respawningAfterLoad);
        refuelableComp = parent.GetComp<CompRefuelable>();
    }
}