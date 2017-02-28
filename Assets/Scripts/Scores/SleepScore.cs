﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
using System;
using Apex.Serialization;

public sealed class SleepScore : ContextualScorerBase
{

    public override float Score(IAIContext context)
    {
        var c = (PlayerContext)context;

        float time = c.self.GetComponent<TimeSinceLastX>().rest;

        return this.score * time;
    }
}