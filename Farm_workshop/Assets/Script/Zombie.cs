using UnityEngine;

public class Zombie : MonoBehaviour
{
    private float _hp =  5;
    private float _speed = 3;
    private float _distance;
    [SerializeField] private GameObject Joueur;
    [SerializeField] private Bullet _bullet;

    void Start()
    {
        Joueur = GameObject.Find("Circle");
    }

    void Update()
    {
        _distance = Vector2.Distance(transform.position, Joueur.transform.position);
        transform.position = Vector2.MoveTowards(this.transform.position, Joueur.transform.position, _speed * Time.deltaTime);

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
    }
}
