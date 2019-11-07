

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;



public class GGPlayer : MonoBehaviour
{

    [Header("速度")]

    [Range(10, 255)]

    public float speed = 15;

    [Header("高度")]

    [Range(10, 150)]

    public int jump = 20;

    Rigidbody r3d;

    public bool isGround;



    // Use this for initialization

    void Start()

    {

        r3d = this.GetComponent<Rigidbody>();

    }



    // Update is called once per frame

    void Update()

    {

        Walk();

        Jump();

    }



    private void OnCollisionEnter(Collision collision)

    {

        isGround = true;

        if (collision.transform.tag == "ground")

        {

            isGround = true;

            Debug.Log("GG");



        }



    }





    private void Walk()

    {

        r3d.AddForce(new Vector3(speed * Input.GetAxis("Horizontal"), 0, speed * Input.GetAxis("Vertical")));

        //r3d.AddForce(new Vector3(0, 0, speed * Input.GetAxis("Vertical")));



    }



    private void Jump()

    {

        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)

        {

            isGround = false;

            r3d.AddForce(new Vector3(0, jump, 0));

        }



    }

}