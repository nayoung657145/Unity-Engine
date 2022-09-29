using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ReservationPerformPopup : MonoBehaviour
{
    public Button performInfoBtn;
    public Button performReserveBtn;

    public GameObject performInfoPanel;
    public GameObject performReservePanel;
    public GameObject semipopup;

    // Start is called before the first frame update
    void Awake()
    {
        semipopup.SetActive(false);
        performInfoPanel.SetActive(false);
        performReservePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void init() //시간표 버튼 클릭 시
    {
        float btnY = 0f;
        semipopup.SetActive(true);

        btnY = EventSystem.current.currentSelectedGameObject.transform.localPosition.y;

        semipopup.transform.localPosition = new Vector2(528, btnY);
    }
    public void PerformInfo () //공연정보 버튼 클릭 시
    {
        performReservePanel.SetActive(false);
        semipopup.SetActive(false);
        performInfoPanel.SetActive(true);

    }

     public void performReserve () //공연예약 버튼 클릭 시
    {
        performInfoPanel.SetActive(false);
        semipopup.gameObject.SetActive(false);
        performReservePanel.SetActive(true);
    }
}
