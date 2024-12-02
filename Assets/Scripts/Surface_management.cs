using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surface_management : MonoBehaviour
{
    public GameObject [] gameObjects;
    public float speed = 20f;
    float displacement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        displacement = 1.5f;        
        foreach(GameObject gameobj in gameObjects)
        {
            displacement += 0.01f;
            float yNew = Mathf.Cos(Time.time*displacement);
            gameobj.transform.Rotate(new Vector3(0, yNew, 0), speed * Time.deltaTime, Space.Self);
        }
        
        

    }
}
