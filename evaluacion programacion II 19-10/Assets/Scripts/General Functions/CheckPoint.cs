
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private GameObject whiteFlag;
    [SerializeField] private GameObject greenFlag;

    public static Vector3 respawnPosition;
    public static bool hasCheckpoint;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    private static void ResetCheckpoint()
    {
        respawnPosition = Vector3.zero;
        hasCheckpoint = false;
    }

    private void Start()
    {
        whiteFlag.SetActive(true);
        greenFlag.SetActive(false);
    }

    public void ActivateCheckpoint()
    {
        respawnPosition = respawnPoint.position;
        hasCheckpoint = true;

        whiteFlag.SetActive(false);
        greenFlag.SetActive(true);
    }
}
