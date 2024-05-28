using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI : MonoBehaviour
{
    private bool isShooting;
    public void GetButtonCurrentInUI()
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
    }
    public void PressButton()
    {
        if (!isShooting)
        {
            StartCoroutine(TimeShoot());
        }
    }
    private IEnumerator TimeShoot()
    {
        isShooting = true;

        Debug.Log("Shoot");

        yield return new WaitForSeconds(1f);

        isShooting = false;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (!IsPointerOverUIObject())// Kiểm tra xem tia có chạm vào một UI object không
                {
                    Debug.Log("CUBECUBE");
                }
            }
        }
    }
    private bool IsPointerOverUIObject()
    {
        // Tạo một đối tượng PointerEventData để chứa thông tin về sự kiện con trỏ hiện tại
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);

        // Đặt vị trí của con trỏ hiện tại (chuột) vào đối tượng PointerEventData
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        // Tạo một danh sách để lưu trữ các kết quả raycast từ EventSystem
        List<RaycastResult> results = new List<RaycastResult>();

        // Thực hiện raycast để kiểm tra xem có bất kỳ đối tượng UI nào ở vị trí con trỏ hiện tại hay không
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);

        // Trả về true nếu có bất kỳ đối tượng UI nào được tìm thấy (results.Count > 0), ngược lại trả về false
        return results.Count > 0;
    }

}
