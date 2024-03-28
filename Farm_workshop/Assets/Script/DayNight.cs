using UnityEngine;
using TMPro;

public class DayNight : MonoBehaviour
{
    
    [SerializeField] private TMP_Text _timeText;
    [field : SerializeField] public GameObject _panelStart {  get; set; }
    [field : SerializeField] public GameObject _panelEnd {  get; set; }
    [field : SerializeField] public bool Hour { get; set; }
    [field: SerializeField] public bool Hour2 { get; set; }
    [SerializeField] public float CurrentTime { get; set; }
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
            
            if (_wait >= 1) 
            {
                CurrentTime = 1;
                Hour2 = false;
            }
        }
    }
}
