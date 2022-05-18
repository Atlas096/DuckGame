using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public static int puntuacion = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Empieza el juego... Pulsa la tecla escape para terminar... \n Puntuación = " + puntuacion);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            if(puntuacion == 1)
            {
                Debug.Log("Has matado " + puntuacion +  " pato...");
            }
            else
            {
                Debug.Log("Has matado " + puntuacion + " patos...");
            }
            Debug.Log("FIN DEL JUEGO");
        }
    }
}
