using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIInventoryTextBox : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshTop1 = null;
    [SerializeField] private TextMeshProUGUI textMeshTop2 = null;
    [SerializeField] private TextMeshProUGUI textMeshTop3 = null;
    [SerializeField] private TextMeshProUGUI textMeshBottom1 = null;
    [SerializeField] private TextMeshProUGUI textMeshBottom2 = null;
    [SerializeField] private TextMeshProUGUI textMeshBottom3 = null;

    // Set text values
    public void SetTextboxText(string texttop1, string texttop2, string texttop3, string textbottom1, string textbottom2, string textbottom3)
    {
        textMeshTop1.text = texttop1;
        textMeshTop2.text = texttop2;
        textMeshTop3.text = texttop3;
        textMeshBottom1.text = textbottom1;
        textMeshBottom2.text = textbottom2;
        textMeshBottom3.text = textbottom3;
    }
}
