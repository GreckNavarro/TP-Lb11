using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseFactory : MonoBehaviour
{
    public GameObject zombie;
    public abstract GameObject CreateEnemy();

}
