using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
using System;
using Apex.Serialization;

public sealed class HygineScore : ContextualScorerBase
{

    public override float Score(IAIContext context)
    {
        var c = (PlayerContext)context;

        float score = 1;

        float time = c.self.GetComponent<TimeSinceLastX>().shower;

        float newScore = score * time;

        c.needScores[3] = newScore;

        return newScore;
    }
}
