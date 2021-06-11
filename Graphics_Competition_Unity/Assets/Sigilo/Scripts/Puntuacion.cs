using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : Singleton<Puntuacion>
{
    public static int PUNTUACION = 0;

    public int puntuacionActual
    {
        get
        {
            return PUNTUACION;
        }
    }

    public static void AddPoints(int value)
    {
        PUNTUACION += value;
    }
}
