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
        textMeshProUGUI.text = text_Value;
        Destroy(gameObject, 1.5f);
    }
}
