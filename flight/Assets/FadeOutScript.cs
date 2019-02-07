using UnityEngine;

using System.Collections;



public class FadeOutScript : MonoBehaviour
{

    float a = 1.0f;
    public float d = 0.2f;
    Renderer renderer;
    //Color alpha;

    // Use this for initialization

    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material.color = new Color(1f, 1f, 1f,a);
    }

    // Update is called once per frame

  void Update()
    {
        
            a -= d;
        if (a >= 0)
            renderer.material.color = new Color(1f, 1f, 1f, a);
        else
            d *= -1;
        if (a >=1)
            d *= -1;
       
    }

}
