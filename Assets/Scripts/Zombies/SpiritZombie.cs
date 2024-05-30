using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritZombie : MonoBehaviour, IAttack
{
    public void OnAttack()
    {
        Debug.Log("Estoy atacando, cuchao");
    }
    private void OnEnable()
    {
        OnAttack();
    }
}
