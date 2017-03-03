using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

[FriendlyName("Sleep", "Fulfill the need for rest.")]
public sealed class Sleep : ActionBase
{

    public override void Execute(IAIContext context)
    {
        var c = (PlayerContext)context;

        c.player.FulfillRest();
    }
}