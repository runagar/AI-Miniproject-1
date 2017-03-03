using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
using System;

public sealed class ScanArea : ActionBase {

    public float scanningRange;

    public override void Execute(IAIContext context)
    {
        var scanLayer = LayerMask.NameToLayer("scanLayer");

        var c = (PlayerContext)context;

        var player =  c.self;
        c.observations.Clear();

        //find stuff based on a overlapSphere
        var colliders = Physics.OverlapSphere(player.transform.position, scanningRange, scanLayer);
        
        for (int i = 0; i < colliders.Length; i++)
        {
            var col = colliders[i];

            var furniture = col.GetComponent<GameObject>();

            c.observations.Add(furniture);
        }
    }
}
