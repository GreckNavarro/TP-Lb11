using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BaseFactory currentfactory;
    private void Awake()
    {
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            currentfactory = GetComponent<FactoryNatureZombie>();
            currentfactory.CreateEnemy();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            currentfactory = GetComponent<FactoryFireZombie>();
            currentfactory.CreateEnemy();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            currentfactory = GetComponent<FactoryRandomZombie>();
            currentfactory.CreateEnemy();
        }
    }

}
