using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireZombie : MonoBehaviour, IAttack
{
    public void OnAttack()
    {
        Debug.Log("Estoy atacando, fiu fiu");
    }
    private void OnEnable()
    {
        OnAttack();
    }
}
