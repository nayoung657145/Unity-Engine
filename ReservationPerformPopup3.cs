using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ReservationPerformPopup3 : MonoBehaviour
{
    [Header("- Stage 03")]
    public GameObject performInfoPanel3;
    public GameObject performReservePanel3;

    public static bool isReserve = false;   // 임시방편


    // Start is called before the first frame update
    void Awake()
    {
        performInfoPanel3.SetActive(false);
        performReservePanel3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PerformInfo () //공연정보 버튼 클릭 시
    {
        performReservePanel3.SetActive(false);
        performInfoPanel3.SetActive(true);

    }

     public void performReserve () //공연예약 버튼 클릭 시
    {
        performInfoPanel3.SetActive(false);
        performReservePanel3.SetActive(true);

        ReservationPerformPopup3.isReserve = true;
    }
}
