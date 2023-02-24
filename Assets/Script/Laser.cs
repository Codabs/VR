using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] private GameObject Emitter;
    [SerializeField] private GameObject Recepter;


    [SerializeField] private LineRenderer lr;
    [SerializeField] private LayerMask layerMask;

    public bool HitSomething;

    private void FixedUpdate()
    {
        lr.gameObject.transform.position= Vector3.zero;
        lr.SetPosition(0, Emitter.transform.position);
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(Emitter.transform.position, Emitter.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            lr.SetPosition(1, hit.collider.gameObject.transform.position);
            print(hit.collider.gameObject.transform.position);
            Debug.DrawRay(Emitter.transform.position, Emitter.transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
           

            if (hit.collider == Recepter)
            {
                HitSomething = true;
            }
            else HitSomething= false;
        }
        else
        {
            lr.SetPosition(1, transform.forward * 1000);

            Debug.DrawRay(Emitter.transform.position, Emitter.transform.TransformDirection(Vector3.forward) * 1000, Color.red);
            
        }
    }
}
