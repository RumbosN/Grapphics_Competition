using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public string _nextLVL = "";

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Player>())
        {
            int puntuacionMaxima = PlayerPrefs.GetInt("puntuacionMaxima");
            if(Puntuacion.Instance.puntuacionActual > puntuacionMaxima)
            {
                PlayerPrefs.SetInt("puntuacionMaxima", Puntuacion.Instance.puntuacionActual);
            }
            GameManager.Instance.NextLVL(_nextLVL);
        }
    }
}
