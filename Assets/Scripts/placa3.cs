using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placa3 : MonoBehaviour
{
    public ControlJugador controlJugador;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("caja2"))
        {
            controlJugador.cont +=1;
            controlJugador.abrirPuerta();
        }
        
        
    }
}
