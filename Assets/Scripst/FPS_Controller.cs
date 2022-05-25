using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Controller : MonoBehaviour
{
    [SerializeField]
    Camera camera;
    [SerializeField]
    Vector3 move;
    [SerializeField]
    CharacterController chc;
    const float MOVEMENT_SPEED = 15f;
    const float ROTATION_SPEED = 400f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move.z = Input.GetAxis("Horizontal");
        move.x = Input.GetAxis("Vertical");

        if (!chc.isGrounded)
        {
            move.y -= 9.8f * Time.deltaTime;
        }
        else
        {
            move.y = 0;
        }

        if (Input.GetAxis("Jump")==1f && chc.isGrounded == true)
        {
            move.y = 2f;
        }
        /*
        if (Input.GetAxis("Sprint") == 1f && chc.isGrounded == true)
        {
            
        }*/

        float x_rotation = Input.GetAxis("Mouse X") * Time.deltaTime * ROTATION_SPEED;
        transform.eulerAngles += new Vector3(0, x_rotation, 0);

        move = transform.TransformDirection(move);
        chc.Move(move * Time.deltaTime * MOVEMENT_SPEED);

        float y_rotation = Input.GetAxis("Mouse Y") * Time.deltaTime * ROTATION_SPEED;
        if (camera.transform.eulerAngles.x > 45f && camera.transform.eulerAngles.x < 100f)
        {
            camera.transform.eulerAngles = new Vector3(45f, camera.transform.eulerAngles.y, 0);
        }
        else if (camera.transform.eulerAngles.x < 45f && camera.transform.eulerAngles.x > 100f)
        {
            camera.transform.eulerAngles = new Vector3(315f, camera.transform.eulerAngles.y, 0);
        }
        camera.transform.eulerAngles += new Vector3(-y_rotation, 0, 0);
    }
}
