using UnityEngine;

/// <summary>
/// Gère la quantité d'argent et la quantité de graine différente qu'a le joueur.
/// </summary>
public class Inventory : MonoBehaviour
{
    /// <summary>
    /// Création d'un nombre entier pour faire largent du jeu.
    /// </summary>
    [field : SerializeField] public int Money { get; set; }

    /// <summary>
    /// Création d'un nombre entier pour savoir combien de graine de ce type nous avons.
    /// </summary>
    [field : SerializeField] public int NumberSeed1 { get; set; }

    /// <summary>
    /// Création d'un nombre entier pour savoir combien de graine de ce type nous avons.
    /// </summary>
    [field : SerializeField] public int NumberSeed2 { get; set; }

    /// <summary>
    /// Création d'un nombre entier pour savoir combien de graine de ce type nous avons.
    /// </summary>
    [field : SerializeField] public int NumberSeed3 { get; set; }

    /// <summary>
    /// Création d'un nombre entier pour savoir combien de graine de ce type nous avons.
    /// </summary>
    [field : SerializeField] public int NumberSeed4 { get; set; }

    /// <summary>
    /// On récupère le script DayNight pour savoir si la nuit est passer et donc si les plant peuvent être vendue.
    /// </summary>
    [SerializeField] private DayNight _dayNight;

    /// <summary>
    /// on récupère le script SeedDirectory pour connaitre les différentes valeurs mises dans les scriptableObjects.
    /// </summary>
    [SerializeField] private SeedDirectory _seedDirectory;

    /// <summary>
    /// On fait une variable pouvant contenir un games objects.
    /// </summary>
    private GameObject _object;

    /// <summary>
    /// On fait une variable pouvant contenir un games objects.
    /// </summary>
    private GameObject _object2;

    /// <summary>
    /// On fait une variable pouvant contenir un games objects.
    /// </summary>
    private GameObject _object3;

    /// <summary>
    /// On fait une variable pouvant contenir un games objects.
    /// </summary>
    private GameObject _object4;

    void Update()
    {
        _object = GameObject.Find("Square(Clone)");
        _object2 = GameObject.Find("Square 1(Clone)");
        _object3 = GameObject.Find("Square 2(Clone)");
        _object4 = GameObject.Find("Square 3(Clone)");

        if (_dayNight.Hour2 == true)
        {
            if (_object != null)
            {
                Money += _seedDirectory.Seed1._sellValue;
                Destroy(_object);
            }
            if (_object2 != null)
            {
                Money += _seedDirectory.Seed2._sellValue;
                Destroy(_object2);
            }
            if (_object3 != null)
            {
                Money += _seedDirectory.Seed3._sellValue;
                Destroy(_object3);
            }
            if (_object4 != null)
            {
                Money += _seedDirectory.Seed4._sellValue;
                Destroy(_object4);
            }
        }
    }
}
