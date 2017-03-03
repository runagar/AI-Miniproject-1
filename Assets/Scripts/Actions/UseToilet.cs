using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

[FriendlyName("Use the Toilet", "Fulfill the need for a toilet break.")]
public sealed class UseToilet : ActionBase
{

    public override void Execute(IAIContext context)
    {
        var c = (PlayerContext)context;

        c.player.FulfillToilet();
    }
}