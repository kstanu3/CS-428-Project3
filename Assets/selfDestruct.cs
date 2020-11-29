using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfDestruct : MonoBehaviour
{
    public float lifetime = 20.0f; // seconds

    // Update is called once per frame
    void Update()
    {
        if (lifetime > 0)
        {
            lifetime -= Time.deltaTime;
            if (lifetime <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}