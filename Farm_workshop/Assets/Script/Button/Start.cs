using UnityEngine;

/// <summary>
/// Permet de commencer la nuit.
/// </summary>
public class Start : MonoBehaviour
{
    /// <summary>
    /// Récupère le script DayNight pour pouvoir activer la nuit. 
    /// </summary>
    [SerializeField] private DayNight _dayNight;

    public void OnTimeStart()
    {
        _dayNight.CurrentTime = 60;
        _dayNight.Hour = false;
        _dayNight.Hour2 = false; 
        _dayNight.PanelStart.SetActive(false);
        _dayNight.PanelEnd.SetActive(true);
    }
}
