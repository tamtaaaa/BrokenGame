using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    
    void Start()
    {
        InvokeRepeating("CreateBall", 2f, 2f);
    }

    void CreateBoll()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
