using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Marionet : MonoBehaviour
{
    public bool TriggerAttack1;
    public bool TriggerDamage;
    public bool TriggerJump;

    bool prevTriggerAttack1;
    bool prevTriggerDamage;

    Animator animator_;

    void Awake()
    {
        animator_ = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (animator_ == null)
        {
            return;
        }

        if (TriggerAttack1 != prevTriggerAttack1 && TriggerAttack1)
        {
            animator_.SetTrigger("Attack1");
        }
        prevTriggerAttack1 = TriggerAttack1;

        if (prevTriggerDamage != TriggerDamage && TriggerDamage)
        {
            animator_.SetTrigger("Damage");
        }
        prevTriggerDamage = TriggerDamage;
    }
}
