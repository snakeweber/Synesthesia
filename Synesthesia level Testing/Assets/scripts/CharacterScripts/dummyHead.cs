using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dummyHead : Character
{
    public CharacterController controller;

    public void Awake()
    {
        SetDefaults();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            UseSkill(skillset[1]);
        }

        PlayerMovement();
    }

    public override void SetDefaults()
    {
        name = "Dummy Head";

        baseHP = 90;
        baseATK = 90;
        baseGRD = 90;
        baseVOL = 90;
        baseAGI = 90;
        baseLCK = 90;

        currentHp = baseHP;
    }

    public void PlayerMovement()
    {
        //gets the values of the x and z axis.
        float z = Input.GetAxis("Horizontal");
        float x = Input.GetAxis("Vertical");

        //sets the movement of the player.
        Vector3 move = transform.right * x + transform.forward * -z;

        float moveMultiplier = (float)baseAGI / 100;

        controller.Move(move * (6 * moveMultiplier) * Time.deltaTime);
    }
}
