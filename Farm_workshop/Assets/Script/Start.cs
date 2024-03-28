using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{
    [SerializeField] private DayNight _dayNight;

    public void OnTimeStart()
    {
        _dayNight.CurrentTime = 90;
        _dayNight.Hour = false;
        _dayNight.Hour2 = false; 
        _dayNight._panelStart.SetActive(false);
        _dayNight._panelEnd.SetActive(true);
    }
}
