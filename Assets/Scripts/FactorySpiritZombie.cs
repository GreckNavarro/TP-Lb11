using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactorySpiritZombie : BaseFactory
{
    public override GameObject CreateEnemy()
    {
        return Instantiate(zombie, transform.position, Quaternion.identity);
    }
}
