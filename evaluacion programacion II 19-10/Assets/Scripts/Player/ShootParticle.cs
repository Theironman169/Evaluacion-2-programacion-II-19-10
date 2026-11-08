using UnityEngine;
using System.Collections;

public class ShootParticles : MonoBehaviour
{
    [Header("Particle Settings")]
    public ParticleSystem particles;
    public Transform shootPoint;
    public float particleDuration = 0.15f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StopAllCoroutines();
            StartCoroutine(PlayParticles());
        }
    }

    IEnumerator PlayParticles()
    {
        particles.transform.position = shootPoint.position;

        float direction = shootPoint.lossyScale.x;

        particles.transform.rotation = Quaternion.Euler(
            0f,
            direction < 0 ? 180f : 0f,
            shootPoint.eulerAngles.z
        );

        particles.Play();

        yield return new WaitForSeconds(particleDuration);

        particles.Stop();
    }
}