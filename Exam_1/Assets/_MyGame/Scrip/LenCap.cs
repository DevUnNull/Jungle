using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LenCap : MonoBehaviour
{
    public static LenCap Instance
    {
        get; 
        private set; 
    }

    [SerializeField] GameObject lenCap;

    private void Start()
    {
        //lenCap.SetActive(false); // Ẩn popup lúc đầu
    }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void ManHinhCho()
    {
        Time.timeScale = 0;
        lenCap.SetActive(true);  
    }
    public void Them1Chieu()
    {

        Time.timeScale = 1;
        lenCap.SetActive(false);
    }
    public void Them1DuongBan()
    {

        Time.timeScale = 1;
        lenCap.SetActive(false);
    }
}

