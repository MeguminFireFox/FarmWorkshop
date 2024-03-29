using UnityEngine;

/// <summary>
/// Permet de suivre le joueur.
/// </summary>
public class Follow : MonoBehaviour
{
    /// <summary>
    /// Un float pour définir la vitesse du Zombie.
    /// </summary>
    [SerializeField] private float _speed;

    /// <summary>
    /// Prend la le joueur pour aller a sa position.
    /// </summary>
    [SerializeField] private GameObject Joueur;

    void Start()
    {
        Joueur = GameObject.Find("Player");
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(this.transform.position, Joueur.transform.position, _speed * Time.deltaTime);
    }
}
