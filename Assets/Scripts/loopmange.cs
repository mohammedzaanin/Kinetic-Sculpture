using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopmange : MonoBehaviour
{
    public float speed = 40f;
    public GameObject firstlayer;
    public GameObject secondlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        firstlayer.transform.Rotate(Vector3.right, speed * Time.deltaTime, Space.Self);
        secondlayer.transform.Rotate(Vector3.left, speed * Time.deltaTime, Space.Self);   
    }

    
}