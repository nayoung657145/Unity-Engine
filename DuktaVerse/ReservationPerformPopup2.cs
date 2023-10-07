using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ReservationPerformPopup2 : MonoBehaviour
{
    [Header("- Stage 02")]
    public GameObject performInfoPanel2;
    public GameObject performReservePanel2;



    // Start is called before the first frame update
    void Awake()
    {
        performInfoPanel2.SetActive(false);
        performReservePanel2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PerformInfo () //공연정보 버튼 클릭 시
    {
        performReservePanel2.SetActive(false);
        performInfoPanel2.SetActive(true);

    }

     public void performReserve () //공연예약 버튼 클릭 시
    {
        performInfoPanel2.SetActive(false);
        performReservePanel2.SetActive(true);
    }
}
