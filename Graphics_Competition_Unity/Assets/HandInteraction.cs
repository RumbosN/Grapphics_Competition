using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandInteraction : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ENTER");
        collision.collider.GetComponent<CheckerCont>()?.ContamidadoCheck();
    }
}
