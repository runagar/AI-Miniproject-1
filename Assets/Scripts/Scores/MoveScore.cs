using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
using System;
using Apex.Serialization;

public sealed class MoveScore : ContextualScorerBase
{

    public override float Score(IAIContext context)
    {
        return 0f;
    }
}
