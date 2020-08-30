using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(ItemCodeDescriptionAttribute))]
public class ItemCodeDescriptionDrawer : PropertyDrawer
{

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        // Change returned property height to double for the additional line for the description
        return EditorGUI.GetPropertyHeight(property) * 2;
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        // BeginProperty EndProperty on the parent property ensures that the prefab override logic works on the entire property
        EditorGUI.BeginProperty(position, label, property);

        if (property.propertyType == SerializedPropertyType.Integer)
        {

            EditorGUI.BeginChangeCheck(); // Starts check for changed values

            // Draw Item Code
            var newValue = EditorGUI.IntField(new Rect(position.x, position.y, position.width, position.height / 2), label, property.intValue);

            // Draw Item Description
            EditorGUI.LabelField(new Rect(position.x, position.y + position.height / 2, position.width, position.height / 2), "Item Description", GetItemDescription(property.intValue));



            // If item code value has changed, then set value to new value
            if (EditorGUI.EndChangeCheck())
            {
                property.intValue = newValue;
            }

        }

        EditorGUI.EndProperty();
    }

    private string GetItemDescription(int itemCode)
    {
        SOItemList soITemList;

        soITemList = AssetDatabase.LoadAssetAtPath("Assets/Scriptable Object Assets/item/so_ItemList.asset", typeof(SOItemList)) as SOItemList;

        List<ItemDetails> itemDetailsList = soITemList.itemDetails;

        ItemDetails itemDetail = itemDetailsList.Find(x => x.itemCode == itemCode);

        if (itemDetail != null)
        {
            return itemDetail.itemDescription;
        }
        else
        {
            return "";
        }
    }
}
