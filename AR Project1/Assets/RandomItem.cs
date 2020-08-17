using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomItem : MonoBehaviour
{
    private GameObject obj;
    private int random;
    Camera mainCam = null;
   
    Image fillImg;
    float time;
    float timeAmt = 60;
    //public Text timeText;

    void Start()
    {
        mainCam = Camera.main;
        fillImg = this.GetComponent<Image>();
        time = timeAmt;
    }

   
        void OnCollisionEnter(Collision other)
        {
            Debug.Log("실행");
            if (other.transform.tag=="Item")
            {
            Debug.Log("실행1");
            Destroy(other.gameObject);
                random = Random.Range(0, 5);
            }

            //switch(random){
            //case 0: break; // 목숨 증가
            //case 1: break;// 목숨 감소
            //case 2: // 시간 증가
              /*  if (time > 0)
                    {
                        time += 5;
                        fillImg.fillAmount = time / timeAmt;
                        timeText.text = "Time : " + time.ToString("F");
                    }*/
            //        break;
            //case 3: break;// 시간 감소
            /*case 4: // 벽 부수기
                if (Input.GetMouseButtonDown(0))
                {
                obj = GetClickedObject();
                Destroy(obj);
                }
            break;*/

    }




    private GameObject GetClickedObject()
    {
        RaycastHit hit;
        GameObject target = null;
        Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
        if (true == (Physics.Raycast(ray.origin, ray.direction * 10, out hit)))
        {
            target = hit.collider.gameObject;
        }
        return target;
    }
}