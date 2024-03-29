using UnityEngine;
using TMPro;

/// <summary>
/// Permet d'activer et de gèrer le jour et la nuit.
/// </summary>
public class DayNight : MonoBehaviour
{
    /// <summary>
    /// On prend un textmesh pour afficher le temps qu'il reste avant le jour.
    /// </summary>
    [SerializeField] private TMP_Text _timeText;

    /// <summary>
    /// On récupère un Panel pour l'activer ou le désactiver en fonction du jour et de la nuit.
    /// </summary>
    [field : SerializeField] public GameObject _panelStart {  get; set; }

    /// <summary>
    /// On récupère un Panel pour l'activer ou le désactiver en fonction du jour et de la nuit.
    /// </summary>
    [field : SerializeField] public GameObject _panelEnd {  get; set; }

    /// <summary>
    /// On fait un bool pour activer ou désactiver différentes chose dans différents script en fonction du jour ou de la nuit.
    /// </summary>
    [field : SerializeField] public bool Hour { get; set; }

    /// <summary>
    /// On fait un bool pour activer ou désactiver différentes chose dans différents script en fonction du jour ou de la nuit.
    /// </summary>
    [field: SerializeField] public bool Hour2 { get; set; }

    /// <summary>
    /// On crée un float qui va s'incrémanter avec le temps.
    /// </summary>
    [SerializeField] public float CurrentTime { get; set; }

    /// <summary>
    /// On crée un float qui va s'incrémanter avec le temps.
    /// </summary>
    [SerializeField] public float _wait { get; set; }

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
            _wait = 0;
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
            _panelEnd.SetActive(false);
            _panelStart.SetActive(true);
        }

        if (Hour == true)
        {
            _wait += Time.deltaTime;
            
            if (_wait >= 6) 
            {
                CurrentTime = 1;
                Hour2 = false;
            }
        }
    }
}
