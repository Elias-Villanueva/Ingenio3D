using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta2 : MonoBehaviour
{
    public GameObject door;
    public int cont;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void abrirPuerta(){
        if (cont >= 3)
        {
            door.transform.position += new Vector3 (0, 5, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
