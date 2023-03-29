using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsEngine
{
    private float TermoMetertemp;
    public int RoomTemp;

    

    public void AddTemrature(int Temp)
    {
        if(TermoMetertemp < Temp)
        {
            TermoMetertemp++;
        }
    }

    public void SubtractTemrature(int Temp)
    {
        if (TermoMetertemp > Temp)
        {
            TermoMetertemp--;
        }
    }
}
