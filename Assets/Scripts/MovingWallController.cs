using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWallController : MonoBehaviour
{
    private Vector3 targetpos;
    // Start is called before the first frame update
    void Start()
    {
        targetpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(targetpos.x, Mathf.Sin(Time.time) + targetpos.y + 1, targetpos.z);
    }
}
