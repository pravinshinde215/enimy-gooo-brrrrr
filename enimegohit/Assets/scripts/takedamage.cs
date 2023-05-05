using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takedamage : MonoBehaviour
{
    private float health = 100f;
    public void TakeDamage(float amount)
    {
        health -= amount;

        Debug.Log(transform.name.ToString() + health.ToString());
    }   
}
