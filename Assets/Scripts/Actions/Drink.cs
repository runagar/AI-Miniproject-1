using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

[FriendlyName("Drink", "Fulfill the thirst need.")]
public sealed class Drink : ActionBase
{

    public override void Execute(IAIContext context)
    {
        var c = (PlayerContext)context;

        c.player.FulfillThirst();
    }
}
