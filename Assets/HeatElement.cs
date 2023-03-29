using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatElement : MonoBehaviour
{
    public int HeatingElementTempreture;

    private string ThermometerTag = "Thermometer";
    private PhysicsEngine PE;

    private void OnTriggerEnter(Collider Enter)
    {
        if(Enter.tag == ThermometerTag)
        {
            PE.AddTemrature(HeatingElementTempreture);
        }
    }

    private void OnTriggerExit(Collider Exit)
    {
        if (Exit.tag == ThermometerTag)
        {
            PE.SubtractTemrature(PE.RoomTemp);
        }
    }
}
