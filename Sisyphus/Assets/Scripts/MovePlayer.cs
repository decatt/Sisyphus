using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float movespeed = 1;
    private Rigidbody2D _rigidbody;
    private int force=200;
    private int maxForce=500;
    private int minForce=200;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(new Vector3(-1*force, 0, 0) * movespeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(new Vector3(force, 0, 0) * movespeed);
        }
        if(Input.GetKey(KeyCode.Space))
        {
            if(force<maxForce)
            {
                force+=10;
            }
        }
        else if(force>minForce){
            force-=10;
        }
    }
}
