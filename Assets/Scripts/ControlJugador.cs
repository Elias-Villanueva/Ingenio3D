using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlJugador : MonoBehaviour
{
    public float rapidezDesplazamiento = 10.0f;
    public Camera camaraPrimeraPersona;
    public float hitDistance;
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    public int cont;



    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void abrirPuerta(){
        if (cont == 1)
        {
            door1.transform.position += new Vector3 (0, 5, 0);
        }
        if (cont == 4)
        {
            door2.transform.position += new Vector3 (0, 5, 0);
        }
        if (cont == 10)
        {
            door3.transform.position += new Vector3 (0, 5, 0);
        }
    }


    void Update()
    {
        float movimientoAdelanteAtras = Input.GetAxis("Vertical") * rapidezDesplazamiento;
        float movimientoCostados = Input.GetAxis("Horizontal") * rapidezDesplazamiento;

        movimientoAdelanteAtras *= Time.deltaTime;
        movimientoCostados *= Time.deltaTime;

        transform.Translate(movimientoCostados, 0, movimientoAdelanteAtras);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }      

        if (Input.GetMouseButtonDown(0))
 {
       Ray ray = camaraPrimeraPersona.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
       RaycastHit hit;

       if ((Physics.Raycast(ray, out hit) == true) && hit.distance < hitDistance)
       {
            Debug.Log("El rayo tocó al objeto: " + hit.collider.name);

            if (hit.collider.name.Substring(0, 3) == "bot")
            {
                GameObject objetoTocado = hit.collider.gameObject;
                ControlBot scriptObjetoTocado = (ControlBot)objetoTocado.GetComponentInParent((typeof(ControlBot)));

                if (scriptObjetoTocado != null)
                {
                    scriptObjetoTocado.recibirDaño();
                }
            }
       }
 }
    
    }
}