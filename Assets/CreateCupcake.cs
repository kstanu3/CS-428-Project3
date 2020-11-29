// Taken from CS 426 Class
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCupcake : MonoBehaviour
{
    public GameObject cannon;
    public GameObject bullet;
    public int max_cupcakes = 2;

    public void Spawn()
    {
        for(int i = 0; i < max_cupcakes; i++)
        {
            GameObject newBullet = GameObject.Instantiate(bullet, cannon.transform.position, cannon.transform.rotation) as GameObject;
        }
    }

}
