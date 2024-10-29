using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f; // �����뿡�� ���� ��

    private void OnCollisionEnter(Collision collision)
    {
        // ���̾� ����ũ�� �����븦 ����� ���̾� ����
        int playerLayer = LayerMask.NameToLayer("Player"); // "Player" ���̾�

        // �浹�� ��ü�� ���̾ "Player" ���̾����� Ȯ��
        if (collision.gameObject.layer == playerLayer)
        {
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            if (playerRigidbody != null)
            {
                // ForceMode.Impulse�� �������� ���� ����
                playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}