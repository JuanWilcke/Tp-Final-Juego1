using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraScript : MonoBehaviour
{
    public Camera cam;
    public float speedH;
    public float speedV;

    float ejeV, ejeH;

        public float rotmax;
        public float rotmin;

    CharacterController cc;
    public float speedMov;
        public float jump;
    public float gravity;

    Vector3 mov = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        //Para Controlar al player.
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        ejeH = speedH * Input.GetAxis("Mouse X");
        ejeV += speedV * Input.GetAxis("Mouse Y");

        cam.transform.localEulerAngles = new Vector3(-ejeV, 0, 0.0f);
        transform.Rotate(0, ejeH, 0);
        ejeV = Mathf.Clamp(ejeV, rotmin, rotmax);

        //Para controlar el Movimiento.
        if (cc.isGrounded)
        {
            mov = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            mov = transform.TransformDirection(mov) * speedMov;

            if (Input.GetKey(KeyCode.Space))
            {
                mov.y = jump;
            }
        }
        mov.y -= gravity * Time.deltaTime;
        cc.Move(mov * Time.deltaTime);
    }
}
