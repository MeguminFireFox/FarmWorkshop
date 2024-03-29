using UnityEngine;
using TMPro;

/// <summary>
/// Gère tout l'affichage de l'inventaire
/// </summary>
public class UiManager : MonoBehaviour
{
    /// <summary>
    /// Un Textmesh pour afficher l'argent.
    /// </summary>
    [SerializeField] private TMP_Text _moneyText;

    /// <summary>
    /// Un Textmesh pour afficher le nombre de graine.
    /// </summary>
    [SerializeField] private TMP_Text _seed1Text;

    /// <summary>
    /// Un Textmesh pour afficher le nombre de graine.
    /// </summary>
    [SerializeField] private TMP_Text _seed2Text;

    /// <summary>
    /// Un Textmesh pour afficher le nombre de graine.
    /// </summary>
    [SerializeField] private TMP_Text _seed3Text;

    /// <summary>
    /// Un Textmesh pour afficher le nombre de graine.
    /// </summary>
    [SerializeField] private TMP_Text _seed4Text;

    /// <summary>
    /// Récupère le script Inventory pour avoir connaissance des différents chiffres
    /// </summary>
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
