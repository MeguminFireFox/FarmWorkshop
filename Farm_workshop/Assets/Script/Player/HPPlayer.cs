using TMPro;
using UnityEngine;

/// <summary>
/// Les point de vie du joueur.
/// </summary>
public class HPPlayer : MonoBehaviour
{
    /// <summary>
    /// Un float pour défénir le nombre de point de vie.
    /// </summary>
    [field : SerializeField] public float HP { get; set; }

    /// <summary>
    /// On prend un textmesh pour afficher la vie du joueur.
    /// </summary>
    [SerializeField] private TMP_Text _hpText;

    /// <summary>
    /// On récupère un panel pour l'activer à la mort.
    /// </summary>
    [SerializeField] private GameObject _panelGameOver;

    /// <summary>
    /// récupère le script ZombieInteraction modifier les PV.
    /// </summary>
    [SerializeField] private ZombieInteraction _zombie;

    void Update()
    {
        _hpText.text = ($"HP : {HP}");

        if (HP <= 0)
        {
            Time.timeScale = 0;
            _panelGameOver.SetActive(true);
            Destroy(gameObject);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        _zombie = other.GetComponent<ZombieInteraction>();

        if (_zombie != null)
        {
            HP -= _zombie.Dammage;
            Destroy(other.gameObject);
        }
    }
}
