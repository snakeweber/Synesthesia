using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    //public string name;
    public Transform pos;
    public LayerMask battleMask;

    public int baseHP;
    public int baseATK;
    public int baseGRD;
    public int baseVOL;
    public int baseAGI;
    public int baseLCK;

    public int currentHp;

    public enum SOUND_TYPE { Sine, Wind, Fire, Metal, Orch, Synth, Sensual, Flow, Harmony, Discord, Ultra}
    public SOUND_TYPE soundType;

    public Skill[] skillset;

    public bool isPlayerTeam;

    public virtual void SetDefaults()
    {
        baseHP = 1;
        baseATK = 1;
        baseGRD = 1;
        baseVOL = 1;
        baseAGI = 1;
        baseLCK = 1;

        currentHp = baseHP;
    }

    public void ShowSkills()
    {
        foreach(Skill s in skillset)
        {
            Debug.Log(s.name);
        }
    }

    public virtual void UseSkill(Skill s)
    {
        //Debug.Log(Physics.CheckSphere(transform.position, s.range * 3, battleMask));
        s.ActivateSkill(transform.position);
        /*Debug.Log(Physics.SphereCast(SetCastPoint(transform.position, s.range), s.range, Vector3.down, out hit, s.range, battleMask));
        Debug.Log(hit);*/
        Collider[] enemyColliders = Physics.OverlapSphere(transform.position, s.range, battleMask);
        foreach( Collider c in enemyColliders)
        {
            Debug.Log("The Enemy");

            if(c.GetComponent<Character>())
            {
                Character tar = c.GetComponent<Character>();

                DealDamage(tar, s);
            }
        }

    }

    public void DealDamage(Character targetCharacter, Skill s)
    {
        targetCharacter.TakeDamage(((s.baseDMG * baseATK / targetCharacter.baseGRD) / 50) + 5);
    }

    public void TakeDamage(int damage)
    {
        currentHp -= damage;
        Debug.Log("Take " + damage + "Damage.");
    }

    public Vector3 SetCastPoint(Vector3 pos, float r)
    {
        return new Vector3(
            pos.x,
            pos.y + r,
            pos.z);
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, 2f);
    }



    /*public void AddSkill(Skill skillName)
    {
        int i = skillset.Length;
        skillset[i] = skillName;
        foreach (Skill s in skillset)
        {
            Debug.Log(s.name);
        }
    }*/
}
