using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Rotation : MonoBehaviour
{
    [SerializeField] private float rotation_Speed;

    private void Update()
    {
        transform.Rotate(0, rotation_Speed, 0);
    }
}
