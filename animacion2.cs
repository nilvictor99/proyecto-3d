using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacion2 : MonoBehaviour
{
    // Velocidad de salto del personaje
    public float jumpForce = 5f;

    // Referencia al componente Rigidbody del personaje
    private Rigidbody2D rb;

    // Método para inicialización
    void Start()
    {
        // Obtener el componente Rigidbody del personaje
        rb = GetComponent<Rigidbody2D>();
    }

    // Método llamado una vez por frame
    void Update()
    {
        // Verificar si se presiona la tecla de espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Aplicar fuerza vertical al Rigidbody para hacer saltar al personaje
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
