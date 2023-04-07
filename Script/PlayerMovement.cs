using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private LayerMask groundMask;
    Rigidbody rb;
    public float movementSpeed = 5f;
    public float jumpForce = 4f;
    public Camera mainCam;
    public Vector3 mousePos;
    float TowerAngle;
    public float TowerSpeed;
    public Transform Tower;
    private Camera mainCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Hero";
        rb = GetComponent<Rigidbody>();
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
       float horizontalInput = Input.GetAxis("Horizontal");
       float verticalInput = Input.GetAxis("Vertical");

        //=========Start PlayerMovement===========//
       rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput*movementSpeed);

       if(Input.GetButtonDown("Jump"))
       {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
       }
       //=========End PlayerMovement===========//

       Aim();


    }


    //=========Start Rotation===========//     
       private (bool success, Vector3 position) GetMousePosition()
       {
        var ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        
        if(Physics.Raycast(ray, out var hitInfo, Mathf.Infinity, groundMask))
        {
            return (success: true, position: hitInfo.point);
        }
        else
        {
            return(success: false, position: Vector3.zero);
        }
       }

       private void Aim()
       {
            var (success, position) = GetMousePosition();
            if(success)
            {
                var direction = position - transform.position;

                direction.y = 0;
                
                transform.forward = direction;
            }
       }
    //=========End Rotation===========//
}
