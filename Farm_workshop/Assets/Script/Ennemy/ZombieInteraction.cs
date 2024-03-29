using UnityEngine;

/// <summary>
/// Les point de vie des zombies
/// </summary>
public class ZombieInteraction : MonoBehaviour
{
    /// <summary>
    /// Un float pour les dégat fait par le zombie.
    /// </summary>
    [field : SerializeField] public float Dammage { get; set; }

    /// <summary>
    /// Un float pour les point de vie du zombie.
    /// </summary>
    private float _hp =  3;

    [SerializeField] private Bullet _bullet;

    void Update()
    {
        if (_hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        _bullet = collision.GetComponent<Bullet>();

        if (_bullet != null)
        {
            _hp -= _bullet.Dammage;
            Destroy(_bullet.gameObject);
        }

        if (collision.gameObject.tag == "Plant")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Plant2")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Plant3")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Plant4")
        {
            Destroy(collision.gameObject);
        }
    }
}
