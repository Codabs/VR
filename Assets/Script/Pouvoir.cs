using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pouvoir : MonoBehaviour
{
    public GameObject shield;
    public float test;

    void Start()
    {
        shield.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Bouclier();
        }
    }

    public void Bouclier ()
    {
        shield.SetActive(true);
    }
}
