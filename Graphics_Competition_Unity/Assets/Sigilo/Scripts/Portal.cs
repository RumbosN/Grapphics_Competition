using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public int _nextLVL = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<HandInteraction>())
        {
            /*
            int puntuacionMaxima = PlayerPrefs.GetInt("puntuacionMaxima");
            if (Puntuacion.Instance.puntuacionActual > puntuacionMaxima)
            {
                PlayerPrefs.SetInt("puntuacionMaxima", Puntuacion.Instance.puntuacionActual);
            }
            */
            Debug.Log("llego aqui");
            GameManager.Instance.NextLVL(_nextLVL);
        }
    }
}
