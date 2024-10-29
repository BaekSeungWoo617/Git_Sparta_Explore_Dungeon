using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f; // 점프대에서 가할 힘

    private void OnCollisionEnter(Collision collision)
    {
        // 레이어 마스크로 점프대를 사용할 레이어 설정
        int playerLayer = LayerMask.NameToLayer("Player"); // "Player" 레이어

        // 충돌한 객체의 레이어가 "Player" 레이어인지 확인
        if (collision.gameObject.layer == playerLayer)
        {
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            if (playerRigidbody != null)
            {
                // ForceMode.Impulse로 순간적인 힘을 가함
                playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}