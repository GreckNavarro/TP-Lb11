using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryNatureZombie : BaseFactory
{
    public override GameObject CreateEnemy()
    {
        return Instantiate(zombie, transform.position, Quaternion.identity);
    }
}
