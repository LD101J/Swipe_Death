using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    
    HealthBar healthBar;
    [SerializeField] private Image meter_Image;
    [SerializeField] private Text hp_Text;
    [SerializeField] private float max_Hit_Points = 100;
    [SerializeField] private float current_Hit_Points;
    [HideInInspector] public Player character;
    private Hit_Points hit_Points;
    private void Start()
    {
        current_Hit_Points = max_Hit_Points;
    }
    private void Update()
    {
        if(character != null)
        {
            meter_Image.fillAmount = hit_Points.value / max_Hit_Points;
            hp_Text.text = "HP:" + (meter_Image.fillAmount * 100);
        }
    }
}
