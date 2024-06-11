using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlenemy : MonoBehaviour
{
    public GameObject enemigos;
    public float intervaloGeneracion = 2.0f;

    void Start()
    {
        InvokeRepeating(nameof(Enemigo), 0f, intervaloGeneracion);
    }

    void Enemigo()
    {
        Vector2 posicionAleatoria = new Vector2(Random.Range(-7.8f, 7.97f), 8.05f);
        Instantiate(enemigos, posicionAleatoria, transform.rotation);
    }
}
