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

        float score = 4;

        float time = c.self.GetComponent<TimeSinceLastX>().toilet;

        float newScore = score * time;

        Debug.Log(newScore);

        c.needScores[4] = newScore;

        return newScore;
    }
}
