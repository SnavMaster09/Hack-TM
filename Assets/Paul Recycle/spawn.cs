using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject pipe;
    public float timer=2;
    public float spawntimer = 2;
    public float off=10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer<spawntimer)
        {
            timer += Time.deltaTime;
        }
        else
        {
        float lowest = transform.position.y - off;
        float high =transform.position.y + off;
        Instantiate(pipe, new Vector3 (transform.position.x,Random.Range(lowest,high),0),   transform.rotation);
            timer = 0;
        }
    }
}

