using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
using System;
using Apex.Serialization;

public sealed class ThirstScore : ContextualScorerBase {

    public override float Score(IAIContext context)
    {
        var c = (PlayerContext)context;

        float score = 3;

        float time = c.self.GetComponent<TimeSinceLastX>().drink;

        float newScore = score * time;

        c.needScores[1] = newScore;

        return newScore;
    }
}
