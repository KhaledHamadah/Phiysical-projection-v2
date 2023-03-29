using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    private GameObject mouseChild;
    public bool IsObjectSelected;

    private void Start()
    {
        mouseChild = GameObject.Find("MouseChild");
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && !IsObjectSelected)
        {
            this.transform.parent = mouseChild.transform;
            IsObjectSelected = true;
            Debug.Log("pp");
        }

        if (Input.GetMouseButtonDown(0) && IsObjectSelected)
        {
            this.transform.parent = null;
            IsObjectSelected = false;
        }
    }
}
