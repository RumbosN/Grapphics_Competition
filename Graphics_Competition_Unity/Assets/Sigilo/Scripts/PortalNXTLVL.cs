using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalNXTLVL : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Player>())
        {

        }
    }
}
