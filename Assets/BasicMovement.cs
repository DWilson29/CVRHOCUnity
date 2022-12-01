using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public Vector3 movement;
    public float runTime = 10;
    float time = 0;
    public Vector3 initPos;
    // Start is called before the first frame update
    void Start()
    {
        initPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time < runTime){
            this.transform.position += Time.deltaTime * movement;
        }
    }

    public void Restart(){
        time = 0;
        this.transform.position = initPos;
    }
}
