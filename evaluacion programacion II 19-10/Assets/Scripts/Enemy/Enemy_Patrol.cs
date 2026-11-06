
using UnityEngine;
using UnityEngine.Serialization;

public class EnemyPatrol : MonoBehaviour
{
    [FormerlySerializedAs("velocidad")]
    public float speed = 2f;

    [SerializeField] private SpriteRenderer sprite;

    private int direction = 1;

    private void Update()
    {
        transform.Translate(new Vector2(direction * speed * Time.deltaTime, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            direction *= -1;
            sprite.flipX = !sprite.flipX;
        }
    }
}
