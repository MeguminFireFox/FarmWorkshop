using UnityEngine;

/// <summary>
/// Ouvre le menu du Shop et empêche de planter sur la zone du shop.
/// </summary>
public class Shop : MonoBehaviour
{
    /// <summary>
    /// On récupère un panel pour pouvoir l'activer.
    /// </summary>
    [SerializeField] private GameObject _panelShop;

    void OnTriggerStay2D(Collider2D collision)
    {
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
