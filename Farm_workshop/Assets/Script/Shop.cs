using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Ouvre le menu du Shop
/// </summary>
public class Shop : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private Inventory _inventory;

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Plant")
        {
            _inventory.NumberSeed1 += 1;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Plant2")
        {
            _inventory.NumberSeed2 += 1;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Plant3")
        {
            _inventory.NumberSeed3 += 1;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Plant4")
        {
            _inventory.NumberSeed4 += 1;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Time.timeScale = 0;
                panel.SetActive(true);
            }
        }
    }
}
