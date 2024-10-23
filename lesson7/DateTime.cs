using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateTimeExample : MonoBehaviour
{
    [SerializeField] private DateTime hienTai;
    [SerializeField] private DateTime gioMongMuon;
    void Start()
    {
        hienTai = DateTime.Now;
        gioMongMuon = new DateTime(2024, 8, 18);
        Debug.Log("Current Date and Time: " + hienTai);
        Debug.Log("Specific Date: " + gioMongMuon);

    }

    void private OnEnable{
        Debug.Log("OnEnable");

    }

    void private OnDisable{
                Debug.Log("OnDisable");


    }

    // Update is called once per frame
    void Update()
    {

    }
}
