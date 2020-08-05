using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;  //이동에 사용할 리지드바디 컴포넌트
    public float speed = 8f;  //이동 속력

    void Start()
    {
        
    }

    //사용자의 입력을 감지하는 메서드 : Update(), Input 클래스
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            playerRigidbody.AddForce(0f, 0f, speed);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
    }

    //자신의 게임 오브젝트를 비활성화
    public void Die()
    {
        gameObject.SetActive(false);
    }
    
}
