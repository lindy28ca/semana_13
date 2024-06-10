using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balitacontrol : MonoBehaviour
{
    public GameObject Explocion;
    public float velocidad;
    Rigidbody2D movimientovalita;
    private void Awake()
    {
        movimientovalita = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        movimientovalita.velocity = new Vector2(0, velocidad);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        GameObject obj = Instantiate(Explocion, transform.position, transform.rotation);
        Destroy(obj, 0.5f);
        Destroy(gameObject);
    }
}
