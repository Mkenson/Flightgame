
using UnityEngine;
using System.Collections;
 
public class Blinker : MonoBehaviour
{
    private float nextTime;
    public float interval = 1.0f;   // 点滅周期
    new Renderer ren = null;

    // Use this for initialization
    void Start()
    {
        ren = GetComponent<Renderer>();
        nextTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime)
            
        {
            ren.enabled = !ren.enabled;

            nextTime += interval;
        }
    }
}
