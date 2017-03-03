using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
using System;
using Apex.Serialization;

public sealed class ToiletScore : ContextualScorerBase
{
    public override float Score(IAIContext context)
    {
        var c = (PlayerContext)context;

        float time = c.self.GetComponent<TimeSinceLastX>().toilet;

        var newScore = this.score * time;

        c.needScores[4] = newScore;

        return newScore;
    }
}
