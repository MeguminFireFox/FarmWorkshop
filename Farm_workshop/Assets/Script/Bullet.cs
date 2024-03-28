using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private Rigidbody2D _rb2d;

    [SerializeField] public Vector2 Direction { get; set; }
    [field : SerializeField] public float Dammage { get; private set; }

    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.forward, Direction);

        Invoke(nameof(AutoDestroy), 2f);
    }

    private void FixedUpdate()
    {
        _rb2d.velocity = Direction * _speed;
    }

    private void AutoDestroy()
    {
        Destroy(gameObject);
    }
}
