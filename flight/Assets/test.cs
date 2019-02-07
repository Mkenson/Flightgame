using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    public void click()
    {
        GameObject.Find("Text").SetActive(false);
    }
}
