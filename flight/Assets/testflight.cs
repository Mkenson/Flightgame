using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testflight : MonoBehaviour
{
    public float maxPower;
    public float accel;
    public float toruque;
    [SerializeField]
    private float power;
    private Rigidbody body;


    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)) // 初期位置へスポーン
        {
            transform.position = new Vector3(0, 50f, 0);
            transform.rotation = Quaternion.identity;
            power = 0;
            body.velocity = Vector3.zero;
            body.angularVelocity = Vector3.zero;
        }
        var v = Input.GetAxis("Vertical");
        var h = Input.GetAxis("Horizontal");
        var mouseY = Input.GetAxis("Pitch");
        var mouseX = Input.GetAxis("Yaw");

        // トルクベクトルの計算
        var rotate = (-mouseY * transform.right + mouseX * transform.up + -h * transform.forward).normalized;
        // 与える力の計算（線形補間）
        if (v >= 0) power = Mathf.Lerp(power, maxPower, v * accel * Time.deltaTime);
        else power = Mathf.Lerp(power, 0, -v * accel * Time.deltaTime);

        // 力を与える
        body.AddForce(transform.forward * power);
        body.AddTorque(rotate * toruque);
    }
}
