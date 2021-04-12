using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstExample : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    Vector2 vel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Controll();
        Controll2();
    }

    private void Controll()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Movement(Vector3.forward);      
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Movement(Vector3.back);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Movement(Vector3.left);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Movement(Vector3.right);  
        }
    }

    private void Controll2()
    {
        vel.y = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        vel.x = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        transform.Translate(vel.x, 0, vel.y);

    }
    private void Movement(Vector3 direction)
    {

        transform.position += direction * _speed * Time.deltaTime;
        
    }
}
