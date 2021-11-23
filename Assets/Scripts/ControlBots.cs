using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBots : MonoBehaviour
{
    private int hp;
    
       
    void Start()      
    {
        hp = 100;
    }

    public void recibirDaño()
    {
        hp = hp - 25;

        if (hp<=0)
        {
            this.desaparecer();
        }
    }

    private void desaparecer()
    {
        Destroy(gameObject);
        
    }


}