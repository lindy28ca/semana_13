using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{
    Rigidbody2D Movimiento;
    public GameObject balita;
    public GameObject spauneo;
    public float Velocidad;
    float vertical;
    float horizontal;
    private void Awake()
    {
        Movimiento = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(balita, spauneo.transform.position, transform.rotation);
        }
    }
    private void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Movimiento.velocity = new Vector2(Velocidad * horizontal, vertical * Velocidad);
    }

}
