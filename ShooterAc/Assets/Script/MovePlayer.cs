using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Variables
{
    public float xMin, xMax, zMin, zMax;
}
public class MovePlayer : MonoBehaviour
{
    [Header("Movimiento")]
    public Variables var;
    private Rigidbody rig;
    public float speed;
    [Header("Disparo")]
    public GameObject shot;
    public Transform shoot;
    public float firerate;
    private float nextfire;

    void Start()
    {
        rig = GetComponent<Rigidbody>();

    }
    void Update()
    {
        float MoveHo = Input.GetAxis("Horizontal");
        float MoveVe = Input.GetAxis("Vertical");
        Vector3 mov = new Vector3(MoveHo, MoveVe, 0f);
        rig.velocity = mov * speed;
        rig.position = new Vector3(Mathf.Clamp(rig.position.x, var.xMin, var.xMax), Mathf.Clamp(rig.position.y, var.zMin, var.zMax), 0f);
        rig.rotation = Quaternion.Euler(4.205f, 0.168f, 88.73901f);
        if (Input.GetButton("Fire1") && Time.time >  nextfire)
        {
            nextfire = Time.time + firerate;
            Instantiate(shot, shoot.position, Quaternion.identity);
        }
    }
}
