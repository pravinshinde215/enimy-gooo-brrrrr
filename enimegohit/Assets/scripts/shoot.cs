using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    Transform cam;
    private void Start()
    {
        cam = Camera.main.transform;
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.position, cam.forward , out hit, range))
        {
            if (hit.transform.tag == "enime")
            {
                takedamage tk = hit.transform.GetComponent<takedamage>();
                tk.TakeDamage(10f);
            }
        }
    }
}
