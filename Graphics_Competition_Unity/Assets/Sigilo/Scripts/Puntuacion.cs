using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{
    public static int PUNTUACION = 0;

    public static void AddPoints(int value)
    {
        PUNTUACION += value;
    }
}
