using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassMovement : MonoBehaviour
{

    public GameObject[] objs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Resume(){
        for(int i = 0; i < objs.Length; i++){
            objs[i].GetComponent<BasicMovement>().start();
        }
    }
    public void Stop(){
        for(int i = 0; i < objs.Length; i++){
            objs[i].GetComponent<BasicMovement>().stop();
        }
    }
    public void Restart(){
        for(int i = 0; i < objs.Length; i++){
            objs[i].GetComponent<BasicMovement>().Restart();
        }
    }
}
