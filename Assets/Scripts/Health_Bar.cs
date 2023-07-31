using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Bar : MonoBehaviour
{
    [SerializeField] private Slider slider;

    private void Set_Health(int health)
    {
        slider.value = health;
    }
}
