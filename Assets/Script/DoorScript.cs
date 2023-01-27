using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoorScript : ActivatableObject
{
    [SerializeField] private float doorLeftEnding;
    [SerializeField] private float doorRightEnding;
    private float doorLeftStartingPosition;
    private float doorRightStartingPosition;
    [SerializeField] private Transform doorLeft;
    [SerializeField] private Transform doorRight;
    private void Awake()
    {
        doorRightStartingPosition = doorRight.position.x;
        doorLeftStartingPosition = doorLeft.position.x;
    }
    public override void Activate()
    {
        doorLeft.DOMoveX(doorLeftEnding, 1);
        doorRight.DOMoveX(doorRightEnding, 1);
        print("open");
    }

    public override void Deactivate()
    {
        doorLeft.DOMoveX(doorLeftStartingPosition, 1);
        doorRight.DOMoveX(doorRightStartingPosition, 1);
        print("unopen");
    }
}
