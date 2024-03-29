using UnityEngine;

/// <summary>
/// Empêche de planter sur la zone du shop.
/// </summary>
public class Wall : MonoBehaviour
{
    /// <summary>
    /// On récupère le script Inventory pour pouboir remettre dans l'inventaire la grain mise sur le shop.
    /// </summary>
    [SerializeField] private Inventory _inventory;

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Plant")
        {
            _inventory.NumberSeed1 += 1;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Plant2")
        {
            _inventory.NumberSeed2 += 1;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Plant3")
        {
            _inventory.NumberSeed3 += 1;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Plant4")
        {
            _inventory.NumberSeed4 += 1;
            Destroy(collision.gameObject);
        }
    }
}
