using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryRandomZombie : BaseFactory
{
    public List<GameObject> enemigos = new List<GameObject>();
    public override GameObject CreateEnemy()
    {
        int random = Random.Range(0,enemigos.Count);
        return Instantiate(enemigos[random], transform.position, Quaternion.identity);
    }
}
