using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

[FriendlyName("Eat", "Fulfill the hunger need.")]
public sealed class Eat : ActionBase
{

    public override void Execute(IAIContext context)
    {
        var c = (PlayerContext)context;

        c.player.FulfillHunger();
    }
}