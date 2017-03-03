using System;
using Apex.AI;
using UnityEngine;

[FriendlyName("Move", "Move to a desired Location.")]
public sealed class Move : ActionWithOptions<Vector3>{

    public override void Execute(IAIContext context)
    {

        var c = (PlayerContext)context;

        c.player.MoveTo(c.target);
    }
}
