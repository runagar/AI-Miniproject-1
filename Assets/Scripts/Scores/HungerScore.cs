using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
using System;
using Apex.Serialization;

public sealed class HungerScore : ContextualScorerBase {

    public override float Score(IAIContext context)
    {
        var c = (PlayerContext)context;

        float score = 2.5f;

        float time = c.self.GetComponent<TimeSinceLastX>().meal;

        float newScore = score * time;

        c.needScores[0] = newScore;

        return newScore;
    }
}
