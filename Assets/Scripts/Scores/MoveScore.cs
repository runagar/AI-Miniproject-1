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

        float minDist = 1;

        var c = (PlayerContext)context;

        float highestScore = 0;
        int highestNeed = 0;

        float[] thresholds = new float[5] { 20f, 18f, 36f, 24f, 44.8f };

        for (int i = 0; i < 5; i++)
        {
            if (c.needScores[i] > thresholds[i] && c.needScores[i] > highestScore)
            {
                highestScore = c.needScores[i];
                highestNeed = i;
            }
        }

        Debug.Log("[" + c.needScores[0]+ ", " + c.needScores[1] +", " + c.needScores[2] +", " + c.needScores[3] +", " + c.needScores[4] + ", " + c.needScores[5] + "]" + "\n Highest Need = " + highestNeed);

        GameObject target = null;

        switch (highestNeed)
        {

            case 0:
                foreach (GameObject o in c.observations)
                {
                    if (o.name == "Fridge") target = o;

                }

                if (target != null && Vector3.Distance(c.self.transform.position, target.transform.position) > minDist)
                {
                    c.target = target.transform.position;
                    Debug.Log("Setting target to: " + target.name);
                    return 20000f;
                }
     
                else return 0f;

            case 1:
                foreach (GameObject o in c.observations)
                {
                    if (o.name == "Sink") target = o;
                }

                if (target != null && Vector3.Distance(c.self.transform.position, target.transform.position) > minDist)
                {
                    c.target = target.transform.position;

                    return 20000f;
                }
                else return 0f;

            case 2:
                foreach (GameObject o in c.observations)
                {
                    if (o.name == "Bed") target = o;
                }

                if (target != null && Vector3.Distance(c.self.transform.position, target.transform.position) > minDist + 1)
                {
                    c.target = target.transform.position;
                    return 20000f;
                }
                else return 0f;

            case 3:
                foreach (GameObject o in c.observations)
                {
                    if (o.name == "Bathtub") target = o;
                }

                if (target != null && Vector3.Distance(c.self.transform.position, target.transform.position) > minDist)
                {
                    c.target = target.transform.position;
                    return 20000f;
                }
                else
                {
                    return 0f;
                } 

            case 4:
                foreach (GameObject o in c.observations)
                {
                    if (o.name == "Loo") target = o;
                }

                if (target != null && Vector3.Distance(c.self.transform.position, target.transform.position) > minDist)
                {
                    c.target = target.transform.position;
                    Debug.Log("Setting target to: " + target.name);

                    return 20000f;
                }
                else return 0f;

            default:
                return 0f;
        }
    }
}
