using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    private int fuel = 0;

    [SerializeField] private Text fuelText;

    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fuel"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            fuel++;
            fuelText.text = "Fuel: " + fuel;
        }
    }
}
