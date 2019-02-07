using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine;
using UnityStandardAssets.Vehicles.Aeroplane;
using UnityStandardAssets.CrossPlatformInput;

public class Controller : MonoBehaviour
{

    AeroplaneController controller;

    private void Awake()
    {
        controller = GetComponent<AeroplaneController>();
    }

    void FixedUpdate()
    {
        var pitch = Input.GetAxis("Vertical");
        var roll = Input.GetAxis("Horizontal");

        // ロール, ピッチ, ヨー, スロットル, エアブレーキ
        controller.Move(roll, pitch, 0, 1, false);
    }
}