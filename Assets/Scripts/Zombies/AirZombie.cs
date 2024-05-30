using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirZombie : MonoBehaviour, IAttack
{
    public void OnAttack()
    {
        Debug.Log("Estoy atacando, fufufu");
    }
    private void OnEnable()
    {
        OnAttack();
    }
}
