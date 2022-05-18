using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour
{
    Vector3 movement = new Vector3(0, 20, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movement * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision){
        Destroy(gameObject);
    }
}
