using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocas : MonoBehaviour
{
    [SerializeField] public int vidaMax = 3;
    int vidaActual;

    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaMax;
    }

    public void romperse(int daño)
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
        
    }
}
