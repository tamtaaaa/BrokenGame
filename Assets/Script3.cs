using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector2.right * 2);
    
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Enmy")
        {
            Destroy(col.gameObject);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
