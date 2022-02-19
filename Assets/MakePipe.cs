using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    float timer = 0;
    public float timeDiff;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer +=Time.deltaTime;
        if (timer > timeDiff)
        {
            Instantiate(pipe);
            timer = 0;
        }
    }
}
