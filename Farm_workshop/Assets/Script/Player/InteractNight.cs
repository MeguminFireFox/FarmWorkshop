using UnityEngine;

/// <summary>
/// Permet de tirer quand on click la nuit.
/// </summary>
public class InteractNight : MonoBehaviour
{
    /// <summary>
    /// On récupère le prefab de la balle pour pouvoir l'instantier.
    /// </summary>
    [SerializeField] private GameObject _bulletPrefab;

    /// <summary>
    /// On récupère le script DayNight pour savoir si il fait nuit.
    /// </summary>
    [SerializeField] private DayNight _dayNight;

    void Update()
    {
        if (Time.timeScale > 0)
        {
            if (_dayNight.Hour == false)
            {
                if (!Input.GetMouseButtonDown(0)) return;
                
                Vector3 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mouseposition.z = 0;

                Vector3 shootDirection = mouseposition - transform.position;

                GameObject bullet = Instantiate(_bulletPrefab);

                bullet.transform.position = transform.position;

                Bullet bulletBehaviour = bullet.GetComponent<Bullet>();
                bulletBehaviour.Direction = shootDirection;
            }
        }
    }
}
