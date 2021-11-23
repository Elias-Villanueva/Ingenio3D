using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta3 : MonoBehaviour
{
    public GameObject door;
    public int cont;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void abrirPuerta(){
        if (cont >= 9)
        {
            door.transform.position += new Vector3 (0, 5, 0);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
