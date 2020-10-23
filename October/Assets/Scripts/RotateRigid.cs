using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRigid : MonoBehaviour
{
    private bool holding;

    private void Awake()
    {
        holding = false;
    }

    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            holding = true;
        }
        else
        {
            holding = false;
        }
    }

    private void FixedUpdate()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        difference.Normalize();

        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        if(rotationZ >= -100f && rotationZ <= 10f && holding)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
        }
    }
}
