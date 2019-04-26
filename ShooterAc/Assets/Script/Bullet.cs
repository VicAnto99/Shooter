using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rig;
    public float speed;
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rig.velocity = transform.right * speed;
    }
}
