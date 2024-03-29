using UnityEngine;

/// <summary>
/// Permet au prefab balle d'aller en direction de la souris.
/// </summary>
public class Bullet : MonoBehaviour
{
    /// <summary>
    /// On crée un float pour indiquer la vitesse de déplacement de la balle. 
    /// </summary>
    [SerializeField] private float _speed;
    
    /// <summary>
    /// On récupère le rigidbody2D de la balle pour pouvoir la propulser.
    /// </summary>
    [SerializeField] private Rigidbody2D _rb2d;

    /// <summary>
    /// On crée un Vector2 pour connaitre la direction dans laquel la balle va partir.
    /// </summary>
    [SerializeField] public Vector2 Direction { get; set; }

    /// <summary>
    /// On crée un float pour mettre les dégat que fait la balle.
    /// </summary>
    [field : SerializeField] public float Dammage { get; private set; }

    void Start()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.forward, Direction);

        Invoke(nameof(AutoDestroy), 2f);
    }

    private void FixedUpdate()
    {
        _rb2d.velocity = Direction * _speed;
    }

    /// <summary>
    /// Détruit le gameObject.
    /// </summary>
    private void AutoDestroy()
    {
        Destroy(gameObject);
    }
}
