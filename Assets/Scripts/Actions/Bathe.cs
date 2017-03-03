using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

[FriendlyName("Bathe", "Fulfill the need for a bath.")]
public sealed class Bathe : ActionBase {

    public override void Execute(IAIContext context)
    {
        var c = (PlayerContext)context;

        c.player.FulfillHygiene();
    }
}
