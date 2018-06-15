using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Marionet : MonoBehaviour
{
    public bool TriggerAttack1;
    public bool TriggerDamage;
    public bool TriggerJump;

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

        if (TriggerAttack1)
        {
            animator_.SetTrigger("Attack1");
            TriggerAttack1 = false;
        }

        if (TriggerDamage)
        {
            animator_.SetTrigger("Damage");
            TriggerDamage = false;
        }
    }
}
