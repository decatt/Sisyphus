using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float movespeed = 1;
    private Rigidbody2D _rigidbody;
    private int force;
    private int maxForce;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        force = 2;
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(new Vector3(-1*force, 0, 0) * movespeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(new Vector3(force, 0, 0) * movespeed);
        }
    }
}
