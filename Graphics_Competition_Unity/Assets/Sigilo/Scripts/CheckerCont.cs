using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerCont : MonoBehaviour
{
    public Material _materialContaminado;
    public ParticleSystem PS_VirusCompleted;

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<HandInteraction>())
        {
            ContamidadoCheck();
        }
    }
    public void ContamidadoCheck()
    {
        this.GetComponent<Renderer>().sharedMaterial = _materialContaminado;

        //Set particle System
        var emission = PS_VirusCompleted.emission;
        emission.enabled = true;
        
        GameManager.Instance.AddCheck();
    }
}