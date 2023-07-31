using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item")]
public class Item : ScriptableObject
{
    public string object_Name;
    public Sprite sprite;
    public int quantity;
    public bool stackable;
    public enum Item_Type
    {
        COIN,
        HEALTH
    }
    public Item_Type item_Type;
}
