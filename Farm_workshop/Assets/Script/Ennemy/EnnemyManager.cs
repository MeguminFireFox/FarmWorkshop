using UnityEngine;

/// <summary>
/// G�re l'apparition et la disparition des ennemies.
/// </summary>
public class EnnemyManager : MonoBehaviour
{
    /// <summary>
    /// On r�cup�re le prefab du zombie pour pouvoir l'instantier.
    /// </summary>
    [SerializeField] private GameObject _zombiePrefab;

    /// <summary>
    /// On r�cup�re le script DayNight pour savoir si il fait nuit.
    /// </summary>
    [SerializeField] private DayNight _dayNight;

    private float _currenttime = 15;

    void Update()
    {
        if (_dayNight.Hour == false)
        {

            _currenttime += Time.deltaTime;

            if (_currenttime >= 15)
            {
                Instantiate(_zombiePrefab, transform.position, transform.rotation);
                _currenttime = 0;
            }
        }
        else
        {
            Destroy(GameObject.Find("Zombie(Clone)"));
        }
    }
}
