using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyTest : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;
    [SerializeField] float xInput;
    [SerializeField] float power;
    private void Update()
    {
        xInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        // 1. �� �����ֱ� : ���ӽ�Ű��
        rigid.AddForce(Vector3.right * xInput * power, ForceMode.Force);

        // 2. �ӵ� �����ϱ� : �ӵ��� ���ϴ� ��� ����
        rigid.velocity = Vector3.right * power * xInput;

        // 3. ȸ���� �����ֱ� : ���ӽ�Ű��
        rigid.AddTorque(Vector3.up * xInput * power, ForceMode.Force);
        
        // 4. ȸ���ӵ� �����ϱ�
        rigid.angularVelocity = Vector3.up * power * xInput;

    }
}