using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Bar : MonoBehaviour
{
    public Hit_Points hit_Points;
    public float value;
    [HideInInspector] public Player character;
    public Image meter_Image;
    public Text health_Text;
    private float max_Hit_Points;

    private void Start()
    {
        max_Hit_Points = character.max_Hit_Points;
    }
    private void Update()
    {
        if (character != null)
        {
            meter_Image.fillAmount = hit_Points.value / max_Hit_Points;
            health_Text.text = "HP" + (meter_Image.fillAmount * 100);
        }
    }
}
