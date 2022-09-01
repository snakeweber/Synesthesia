using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetingManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Debug.Log(Physics.OverlapSphere(transform.position, 2.0f));
    }
}
