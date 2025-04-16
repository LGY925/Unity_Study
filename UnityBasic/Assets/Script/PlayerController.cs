using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody body;
    public float jumpPower;
    public float movePower;


    private void Start()
    {
        // �����ҋ� ȣ���
        Debug.Log("Start!");
        body.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("���� ������");
            body.AddForce(Vector3.left * movePower, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("������ ������");
            body.AddForce(Vector3.right * movePower, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("�� ������");
            body.AddForce(Vector3.forward * movePower, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("�Ʒ� ������");
            body.AddForce(Vector3.back * movePower, ForceMode.Impulse);
        }

        // �����߿� ��� ȣ���
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("������ ������");
            body.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
}
