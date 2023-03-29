using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseChildScript : MonoBehaviour
{
    public Vector3 Pos;
    private void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;
        gameObject.transform.position = pos;
    }
}
