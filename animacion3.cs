using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacion1 : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f; // Corregido el nombre de la variable y eliminado el espacio
    private Animator anim;
    public float x, y;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0); // Corregido el nombre de la variable
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento); // Añadido * antes de velocidadMovimiento

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY",y);
            }
}