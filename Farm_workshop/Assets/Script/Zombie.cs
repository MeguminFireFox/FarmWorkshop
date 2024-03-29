using UnityEngine;

public class Zombie : MonoBehaviour
{
    /// <summary>
    /// Un float pour les dégat fait par le zombie
    /// </summary>
    private float _dammage = 1;

    /// <summary>
    /// 
    /// </summary>
    private float _hp =  3;
    private float _speed = 3;
    
    [SerializeField] private GameObject Joueur;
    [SerializeField] private Bullet _bullet;
    [SerializeField] private HPPlayer _hPPplayer;

    void Start()
    {
        Joueur = GameObject.Find("Player");
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(this.transform.position, Joueur.transform.position, _speed * Time.deltaTime);

        if (_hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        _bullet = collision.GetComponent<Bullet>();
        _hPPplayer = collision.GetComponent<HPPlayer>();

        if (_bullet != null)
        {
            _hp -= _bullet.Dammage;
            Destroy(_bullet.gameObject);
        }

        if (_hPPplayer != null)
        {
            _hPPplayer.HP -= _dammage;
            Destroy(gameObject);
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
