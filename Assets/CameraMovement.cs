using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed = 1f;
    private bool drag = false;
    private Vector3 origin;
    private Vector3 diff;
    bool forw = false;
    bool back = false;
    bool left = false;
    bool right = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) || Input.GetMouseButtonDown(0)){
            if(forw){
                this.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, speed));
            }
            else if(back){
                this.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, -1 * speed));
            }
            else if(left){
                this.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(-1 * speed, 0, 0));
            }
            else if(right){
                this.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(speed, 0, 0));
            }
            else{
                this.transform.eulerAngles += speed * new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
            }
        }
        else{
            this.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(speed * Input.GetAxis("Horizontal"), 0, speed * Input.GetAxis("Vertical")));
            forw = false;
            back = false;
            left = false;
            right = false;
        }
    }

    public void Forward(){
        forw = true;
    }

    public void Backward(){
        back = true;
    }

    public void Left(){
        left = true;
    }

    public void Right(){
        right = true;
    }
}
