using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chasecamera : MonoBehaviour {
    public GameObject player;
    public Vector3 offset;
    public 
    // Use this for initialization
    void Start(){
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update () {
        Vector3 exPosition;
        exPosition.x = player.transform.position.x + offset.x;
        exPosition.y = player.transform.position.y + offset.y;
        exPosition.z = player.transform.position.z + offset.z - 10;
        transform.rotation = Quaternion.Euler(player.transform.localEulerAngles.x, player.transform.localEulerAngles.y, player.transform.localEulerAngles.z);
        transform.position = exPosition;
	}
}
