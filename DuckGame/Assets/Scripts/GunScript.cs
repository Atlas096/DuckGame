using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    Vector3 movementX = new Vector3(0.01f, 0, 0);
    public GameObject cannon;
    Quaternion rotation = Quaternion.Euler(90, 0, 0);

    public GameObject waterShot;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 origin = cannon.transform.position;
        if(transform.position.x >= -1.5)
        {
            if(Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position -= movementX;
            }
        }

        if(transform.position.x <= 1.5)
        {
            if(Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += movementX;
            }
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(waterShot, origin, rotation);
        }
    }
}
