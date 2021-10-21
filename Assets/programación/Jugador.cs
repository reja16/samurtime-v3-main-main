using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] float speed;
    public int ataqueDeEspada = 1;

    public Transform puntoDeAtaque;
    public float rangoDeAtaque = 0.5f;
    public LayerMask objetivos;


    public static bool llave1;
    public static bool llave2;
    public static bool llave3;
    public static bool llave4;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        atacar();
        
            float movH = Input.GetAxis("Horizontal");
            float movV = Input.GetAxis("Vertical");

            Vector2 movimiento = new Vector2(movH * Time.deltaTime * speed, movV * Time.deltaTime * speed);

            transform.Translate(movimiento);
        

        if(llave1 == true)
        {
            Debug.Log("tengo la llave1");

            //Esta es solo la primera llave. Se puede copiar para configurar las otras llaves para VERIFICAR que estan guardadas.
        }
    }

    void atacar()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Collider2D[] golpearEnemigos = Physics2D.OverlapCircleAll(puntoDeAtaque.position, rangoDeAtaque, objetivos);

            foreach(Collider2D enemigo in golpearEnemigos)
            {
                Debug.Log("Te acuchillo");
                enemigo.GetComponent<enemigos>().RecibirDaño(ataqueDeEspada);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (puntoDeAtaque == null)
            return;

        Gizmos.DrawWireSphere(puntoDeAtaque.position, rangoDeAtaque);
    }
}
