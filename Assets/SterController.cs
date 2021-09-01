using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SterController : MonoBehaviour
{
    private float rotspeed = 0.5f;
    void Start()
    {
        this.transform.Rotate(0, Random.Range(0, 360), 0);
            


    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, this.rotspeed,0);
    }
}
