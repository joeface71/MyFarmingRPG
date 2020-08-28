
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="so_ItemList", menuName ="Scriptable Objects/Item/Item List")]
public class SOItemList : ScriptableObject
{
    [SerializeField]
    public List<ItemDetails> itemDetails;
    
}
