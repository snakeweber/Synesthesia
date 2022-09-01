using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dummy Pulse", menuName = "Skills/Dummy Pulse")]
public class dummyPulse : Skill
{
    public GameObject dummyPulseParticles;

    public void Awake()
    {
        name = "Dummy Pulse";
        baseDMG = 70;
        baseACC = 90;
        isNoise = true;
        range = 2f;
        isRadial = true;
    }

    public override void ActivateSkill(Vector3 loc)
    {
        dummyPulseParticles.transform.localScale = new Vector3 (range, range, range);
        Instantiate(dummyPulseParticles, loc, dummyPulseParticles.transform.rotation);
        /*if(Physics.SphereCast (loc, range, dummyPulseParticles.transform.TransformDirection(Vector3.forward), out RaycastHit hitInfo, 2.0f))
        {
            Debug.Log("got he ass");
            Debug.DrawRay(loc, dummyPulseParticles.transform.TransformDirection(Vector3.forward) * hitInfo.distance, Color.green);
        }
        else
        {
            Debug.Log("ya missed");
            Debug.DrawRay(loc, dummyPulseParticles.transform.TransformDirection(Vector3.forward) * hitInfo.distance, Color.red);
        }*/
        //Debug.Log(Physics.OverlapSphere(loc, range));
    }
}
