using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class PopUp : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMeshProUGUI;
    public string text_Value;

    private void Start()
    {
        text_Value = textMeshProUGUI.text;
        Destroy(gameObject, 1.5f);
    }
}
