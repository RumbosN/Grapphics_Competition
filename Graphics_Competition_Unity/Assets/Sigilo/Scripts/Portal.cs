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
            GameManager.Instance.NextLVL(_nextLVL);
        }
    }
}
