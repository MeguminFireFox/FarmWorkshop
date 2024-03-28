using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Permet de quitter un panel
/// </summary>
public class Back : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    public void OnBack()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }
}
