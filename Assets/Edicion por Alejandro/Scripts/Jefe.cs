using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jefe : MonoBehaviour
{
    public int vidaMax = 3;
    int vidaActual;

    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaMax;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RecibirDaño(int daño)
    {
        vidaActual -= daño;

        if (vidaActual <= 0)
        {
            Muere();
        }
    }
    void Muere()
    {
        Destroy(this.gameObject);
        puertadesbloqueable.enemigosenlazona -= 1;
    }
}
