using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NatureZombie : MonoBehaviour, IAttack
{
    public void OnAttack()
    {
        Debug.Log("Estoy atacando, plum plum");
    }
    private void OnEnable()
    {
        OnAttack();
    }
}
