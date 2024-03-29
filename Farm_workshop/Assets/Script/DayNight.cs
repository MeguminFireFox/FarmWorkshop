using UnityEngine;
using TMPro;

/// <summary>
/// Permet d'activer et de g�rer le jour et la nuit.
/// </summary>
public class DayNight : MonoBehaviour
{
    /// <summary>
    /// On prend un textmesh pour afficher le temps qu'il reste avant le jour.
    /// </summary>
    [SerializeField] private TMP_Text _timeText;

    /// <summary>
    /// On r�cup�re un Panel pour l'activer ou le d�sactiver en fonction du jour et de la nuit.
    /// </summary>
    [field : SerializeField] public GameObject PanelStart {  get; set; }

    /// <summary>
    /// On r�cup�re un Panel pour l'activer ou le d�sactiver en fonction du jour et de la nuit.
    /// </summary>
    [field : SerializeField] public GameObject PanelEnd {  get; set; }

    /// <summary>
    /// On fait un bool pour activer ou d�sactiver diff�rentes chose dans diff�rents script en fonction du jour ou de la nuit.
    /// </summary>
    [field : SerializeField] public bool Hour { get; set; }

    /// <summary>
    /// On fait un bool pour activer ou d�sactiver diff�rentes chose dans diff�rents script en fonction du jour ou de la nuit.
    /// </summary>
    [field: SerializeField] public bool Hour2 { get; set; }

    /// <summary>
    /// On cr�e un float qui va s'incr�manter avec le temps.
    /// </summary>
    [SerializeField] public float CurrentTime { get; set; }

    /// <summary>
    /// On cr�e un float qui va s'incr�manter avec le temps.
    /// </summary>
    [SerializeField] public float Wait { get; set; }

    void Start()
    {
        CurrentTime = 1;
        Hour = true;
        Hour2 = false;
    }

    void Update()
    {
        if (Hour == false)
        {
            Wait = 0;
            CurrentTime -= Time.deltaTime;

            if (CurrentTime > 0)
            {
                float min = Mathf.FloorToInt(CurrentTime / 60);
                float sec = Mathf.FloorToInt(CurrentTime % 60);

                if (sec < 10)
                {
                    _timeText.text = ($"0{min} : 0{sec}");
                    return;
                }
                else
                {
                    _timeText.text = ($"0{min} : {sec}");
                }
            }
        }

        if (CurrentTime <= 0)
        {
            Hour = true;
            Hour2 = true;
            PanelEnd.SetActive(false);
            PanelStart.SetActive(true);
        }

        if (Hour == true)
        {
            Wait += Time.deltaTime;
            
            if (Wait >= 6) 
            {
                CurrentTime = 1;
                Hour2 = false;
            }
        }
    }
}
