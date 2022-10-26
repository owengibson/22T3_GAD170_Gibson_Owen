using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipColourChanger : MonoBehaviour
{
    private GameObject ship;

    private void SetColour(GameObject ship)
    {
        SpriteRenderer spriteRenderer = ship.GetComponent<SpriteRenderer>();
        // if the cube is < 0 it is red
        if (ship.transform.position.x < 0)
        {
            spriteRenderer.color = Color.red;
        }
        // if the cube is > 0 then it's green
        else
        {
            spriteRenderer.color = Color.green;
        }

    }

    private void Update()
    {
        SetColour(ship);
    }

    private void Start()
    {
        ship = gameObject;
    }
}
