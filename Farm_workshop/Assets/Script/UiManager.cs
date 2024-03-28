using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _moneyText;
    [SerializeField] private TMP_Text _seed1Text;
    [SerializeField] private TMP_Text _seed2Text;
    [SerializeField] private TMP_Text _seed3Text;
    [SerializeField] private TMP_Text _seed4Text;

    [SerializeField] private Inventory _inventory;


    void Update()
    {
        _moneyText.text = ($"Money : {_inventory.Money}");
        _seed1Text.text = ($"{_inventory.NumberSeed1}");
        _seed2Text.text = ($"{_inventory.NumberSeed2}");
        _seed3Text.text = ($"{_inventory.NumberSeed3}");
        _seed4Text.text = ($"{_inventory.NumberSeed4}");
    }
}
