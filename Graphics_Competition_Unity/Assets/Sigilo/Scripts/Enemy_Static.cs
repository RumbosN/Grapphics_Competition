using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Static : MonoBehaviour
{
    public int _damage = 5;

    private void OnCollisionStay(Collision collision)
    {
        collision.collider.GetComponent<Player>().ReceiveDMG(_damage);
    }
}