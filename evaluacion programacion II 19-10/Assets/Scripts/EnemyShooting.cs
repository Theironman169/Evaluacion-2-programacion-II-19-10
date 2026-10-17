using UnityEngine;

public class DisparoEnemigo : MonoBehaviour
{
    [Header("Configuración del disparo")]
    [SerializeField] private GameObject proyectilPrefab;
    [SerializeField] private Transform puntoDisparo;
    [SerializeField] private float velocidadProyectil = 5f;
    [SerializeField] private float tiempoEntreDisparos = 2f;

    [Header("Detección del jugador")]
    [SerializeField] private float distanciaAtaque = 5f;

    private Transform jugador;
    private float temporizador;

    private void Start()
    {
        GameObject objetoJugador = GameObject.FindGameObjectWithTag("Player");

        if (objetoJugador != null)
        {
            jugador = objetoJugador.transform;
        }
    }

    private void Update()
    {
        if (jugador == null || proyectilPrefab == null || puntoDisparo == null)
        {
            return;
        }

        float distancia = Vector2.Distance(transform.position, jugador.position);

        if (distancia <= distanciaAtaque)
        {
            temporizador += Time.deltaTime;

            if (temporizador >= tiempoEntreDisparos)
            {
                Disparar();
                temporizador = 0f;
            }
        }
        else
        {
            temporizador = 0f;
        }
    }

    private void Disparar()
    {
        GameObject proyectil = Instantiate(
            proyectilPrefab,
            puntoDisparo.position,
            Quaternion.identity
        );

        Vector2 direccion = (jugador.position - puntoDisparo.position).normalized;

        Rigidbody2D rb = proyectil.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.linearVelocity = direccion * velocidadProyectil;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, distanciaAtaque);
    }
}