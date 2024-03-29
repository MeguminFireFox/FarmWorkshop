using UnityEngine;

/// <summary>
/// Ouvre le menu du Shop et emp�che de planter sur la zone du shop.
/// </summary>
public class Shop : MonoBehaviour
{
    /// <summary>
    /// On r�cup�re un panel pour pouvoir l'activer.
    /// </summary>
    [SerializeField] private GameObject _panelShop;

    /// <summary>
    /// On r�cup�re le script Inventory pour pouboir remettre dans l'inventaire la grain mise sur le shop.
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

        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Time.timeScale = 0;
                _panelShop.SetActive(true);
            }
        }
    }
}
