using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Third_Person_Movement : MonoBehaviour
{

    public CharacterController controller;

    [SerializeField] private float speed = 6f;
    //плавность поворота
    [SerializeField] private float turnSmoothTime = 0.1f;
    [SerializeField] private float turnSmoothVelocity; 


    void Start()
    {
    }
 
    void FixedUpdate()
    {
        Controll();
    }
    private void Controll()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical);

        if (direction.magnitude >= 0.1f)
        {
            //поворот
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            //плавность поворота
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

            controller.Move(direction * speed * Time.deltaTime);
        }

    }


}
