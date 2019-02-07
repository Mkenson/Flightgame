using UnityEngine;
using System.Collections;

public class FlyingObject : MonoBehaviour
{
    private const float G = 9.9f;

    private Animator animator;

    private bool isGrounded;

    // Use this for initialization
    void Start()
    {
        this.animator = this.GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var velocity = new Vector3(0, 0, 0);
        velocity.x += Input.GetAxis("Horizontal");
        velocity.y += Input.GetAxis("Vertical");
        if (Input.GetButton("Fire1"))
        {
            velocity.z += 1.0f;
        }
        if (Input.GetButton("Fire2"))
        {
            velocity.z += -1.0f;
        }

        this.GetComponent<Rigidbody>().velocity = velocity * 500 * Time.deltaTime;
        var originalRotation = this.GetComponent<Rigidbody>().rotation;
        var zEular = 0.0f;
        if (this.GetComponent<Rigidbody>().velocity.x > 0)
        {
            zEular = -5.0f;
        }
        else if (this.GetComponent<Rigidbody>().velocity.x < 0)
        {
            zEular = 5.0f;
        }

        var xEular = 0.0f;
        if (this.GetComponent<Rigidbody>().velocity.z > 0)
        {
            xEular = 5.0f;
        }
        else if (this.GetComponent<Rigidbody>().velocity.z < 0)
        {
            xEular = -5.0f;
        }
        var eular = new Vector3(xEular, 0, zEular);
        this.GetComponent<Rigidbody>().rotation = Quaternion.Euler(eular);

        this.animator.SetBool("Flying", !this.isGrounded);
    }

    public void OnCollisionEnter(Collision collision)
    {
        var g = (GetComponent<Collider>().gameObject.layer & (1 << LayerMask.NameToLayer("Ground"))) != 0;
        this.isGrounded = !g;
    }

    public void OnCollisionExit(Collision collision)
    {
        var g = (GetComponent<Collider>().gameObject.layer & (1 << LayerMask.NameToLayer("Ground"))) != 0;
        this.isGrounded = g;
    }


}
