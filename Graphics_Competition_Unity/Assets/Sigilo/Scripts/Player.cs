using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    protected int _hp = 100;
    private Transform _transform;
    private void Awake()
    {
        _transform = this.GetComponent<Transform>();
    }

    void Update()
    {
        if (_hp <= 0)
        {
            GameManager.Instance.deadPlayer();
        }
    }

    public void ReceiveDMG(int value)
    {
        _hp -= value;
    }
}
