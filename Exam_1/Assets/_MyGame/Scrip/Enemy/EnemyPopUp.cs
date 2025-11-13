using TMPro;
using UnityEngine;

public class EnemyPopUp : MonoBehaviour
{
    [SerializeField] Camera _camera;
    [SerializeField] GameObject PopUp_Prefab;
    [SerializeField] Vector3 offset = new Vector3(0, 0.3f, 0); // popup hiện cao hơn enemy 1 đơn vị

    void Start()
    {
        if (_camera == null)
        {
            _camera = Camera.main; // Tự động lấy camera chính trong scene
        }
    }

    public void PopUpDame(int dame)
    {
        string textDame = dame.ToString();

        // Vị trí popup nằm trên đầu enemy
        Vector3 spawnPos = transform.position + offset;

        // Tạo popup tại vị trí đó
        GameObject popUpObject = Instantiate(PopUp_Prefab, spawnPos, Quaternion.identity);

        // Truyền giá trị chữ vào popup
        popUpObject.GetComponent<PopUp>().text_Value = "-"+textDame;
    }
}
