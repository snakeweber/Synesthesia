using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu]
public class Skill : ScriptableObject
{
    //public string name;

    public int baseDMG;
    public int baseACC;
    public bool isPhysical;
    public bool isNoise;
    public bool isStatus;
    public int mpCost;
    public float range;
    public bool isRadial;
    public bool isDirectional;
    public bool isTargetSelf;
    public int statusChance;

    public virtual void SetDefaults()
    {

    }

    public virtual void ActivateSkill(Vector3 loc)
    {
        if(isRadial)
        {
            Debug.Log("use radial skill: " + name + " at " + loc);
        }
        else if(isDirectional)
        {
            Debug.Log("use directional skill: " + name + " at " + loc);
        }
        else if(isTargetSelf)
        {
            Debug.Log("use self targeting skill: " + name + " at " + loc);
        }
    }
}
