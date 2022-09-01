using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dummy Punch", menuName = "Skills/Dummy Punch")]
public class dummyPunch : Skill
{
    public void Awake()
    {
        name = "Dummy Punch";
        baseDMG = 50;
        baseACC = 100;
        isPhysical = true;
        range = 1.5f;
        isDirectional = true;
    }
}
