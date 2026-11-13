
using UnityEngine;

public class CheckpointDetector : MonoBehaviour
{
    [SerializeField] private Checkpoint checkpoint;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Checkpoint detectó contacto con: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Jugador detectado correctamente");

            checkpoint.ActivateCheckpoint();
        }
    }
}
