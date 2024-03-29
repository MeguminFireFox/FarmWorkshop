using UnityEngine;

/// <summary>
/// Permet de planter quand on click le jour.
/// </summary>
public class Interact : MonoBehaviour
{
    /// <summary>
    /// On récupère le préfab d'une plante pour l'instantier.
    /// </summary>
    [SerializeField] private GameObject _plant1Prefab;

    /// <summary>
    /// On récupère le préfab d'une plante pour l'instantier.
    /// </summary>
    [SerializeField] private GameObject _plant2Prefab;

    /// <summary>
    /// On récupère le préfab d'une plante pour l'instantier.
    /// </summary>
    [SerializeField] private GameObject _plant3Prefab;

    /// <summary>
    /// On récupère le préfab d'une plante pour l'instantier.
    /// </summary>
    [SerializeField] private GameObject _plant4Prefab;

    /// <summary>
    /// On récupère le script DayNight pour savoir si il fait jour.
    /// </summary>
    [SerializeField] private DayNight _dayNight;

    /// <summary>
    /// On récupère le script Hotbar pour savoir quel graine de l'inventaire doit être instantier si on click.
    /// </summary>
    [SerializeField]private Hotbar _hotbar;

    /// <summary>
    /// On récupère le script Inventory pour pouvoir modifier le nombre de graine dans l'inventaire.
    /// </summary>
    [SerializeField]private Inventory _inventory;

    void Update()
    {
        if (Time.timeScale > 0)
        {
            if (_dayNight.Hour == true)
            {
                if (!Input.GetMouseButtonDown(0)) return;

                Vector2 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                switch (_hotbar.Choice)
                {
                    case 1:
                        if (_inventory.NumberSeed1 >= 1)
                        {
                            Instantiate(_plant1Prefab, mouseposition, transform.rotation);
                            _inventory.NumberSeed1 -= 1;
                        }
                        break;
                    case 2:
                        if (_inventory.NumberSeed2 >= 1)
                        {
                            Instantiate(_plant2Prefab, mouseposition, transform.rotation);
                            _inventory.NumberSeed2 -= 1;
                        }
                        break;
                    case 3:
                        if (_inventory.NumberSeed3 >= 1)
                        {
                            Instantiate(_plant3Prefab, mouseposition, transform.rotation);
                            _inventory.NumberSeed3 -= 1;
                        }
                        break;
                    case 4:
                        if (_inventory.NumberSeed4 >= 1)
                        {
                            Instantiate(_plant4Prefab, mouseposition, transform.rotation);
                            _inventory.NumberSeed4 -= 1;
                        }
                        break;
                }
            }
        }
    }
}
