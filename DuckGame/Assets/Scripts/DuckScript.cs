using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckScript : MonoBehaviour
{
    //Ducks move from left -18 to right 1.8 and change direction

    //Vector to rotate the duck 90º when hit
    Vector3 hit = new Vector3(0, 0, 90);

    //Vector to move the duck, default LTR
    Vector3 move = new Vector3(0, 0, 1);

    //Vector to change rotation when reach position
    Vector3 rotateDuck = new Vector3(0, 180, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(move * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision){
        transform.Rotate(hit, Space.Self);
    }

    private void OnTriggerEnter(Collider other)
    {
        transform.Rotate(rotateDuck, Space.Self);
    }
}
