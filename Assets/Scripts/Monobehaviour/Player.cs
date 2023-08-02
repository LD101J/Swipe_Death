using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public Health_Bar health_Bar_Prefab;
    private Health_Bar health_Bar;

    private void Start()
    {
        hit_Points.value = starting_Hit_Points;
        health_Bar = Instantiate(health_Bar_Prefab);
        health_Bar.character = this;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            Item hit_Object = other.gameObject.GetComponent<Consumable>().item;
            if(hit_Object != null)
            {
                print("it:" + hit_Object.object_Name);
                other.gameObject.SetActive(false);
            }
        }
    }
}
