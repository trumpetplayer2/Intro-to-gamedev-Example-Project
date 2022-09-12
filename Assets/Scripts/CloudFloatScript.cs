using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CloudFloatScript : MonoBehaviour
{
    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello World");
        Debug.Log(this.name);

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Frame");
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (Time.deltaTime * speed));
        Debug.Log(speed * Time.deltaTime);
        

    }
}
