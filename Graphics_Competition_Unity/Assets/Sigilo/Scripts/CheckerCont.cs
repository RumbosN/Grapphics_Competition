using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerCont : MonoBehaviour
{
    public Material _materialContaminado;

    public void ContamidadoCheck()
    {
        this.GetComponent<Renderer>().sharedMaterial = _materialContaminado;
        GameManager.Instance.AddCheck();
    }
}