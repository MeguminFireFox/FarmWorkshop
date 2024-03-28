using UnityEngine;

/// <summary>
/// Permet de planter quand on click
/// </summary>
public class Interact : MonoBehaviour
{
    [SerializeField] private GameObject _plant;
    [SerializeField] private GameObject _plant2;
    [SerializeField] private GameObject _plant3;
    [SerializeField] private GameObject _plant4;
    [SerializeField] private DayNight _dayNight;

    private Hotbar _hotbar;
    private Inventory _inventory;

    void Start()
    {
        _hotbar = GetComponent<Hotbar>();
        _inventory = GetComponent<Inventory>();
    }

    void Update()
    {
        if (Time.timeScale > 0)
        {
            if (_dayNight.Hour == true)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Vector2 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                    switch (_hotbar.Choice)
                    {
                        case 1:
                            if (_inventory.NumberSeed1 >= 1)
                            {
                                Instantiate(_plant, mouseposition, transform.rotation);
                                _inventory.NumberSeed1 -= 1;
                            }
                            break;
                        case 2:
                            if (_inventory.NumberSeed2 >= 1)
                            {
                                Instantiate(_plant2, mouseposition, transform.rotation);
                                _inventory.NumberSeed2 -= 1;
                            }
                            break;
                        case 3:
                            if (_inventory.NumberSeed3 >= 1)
                            {
                                Instantiate(_plant3, mouseposition, transform.rotation);
                                _inventory.NumberSeed3 -= 1;
                            }
                            break;
                        case 4:
                            if (_inventory.NumberSeed4 >= 1)
                            {
                                Instantiate(_plant4, mouseposition, transform.rotation);
                                _inventory.NumberSeed4 -= 1;
                            }
                            break;
                    }
                }
            }
        }
    }
}
