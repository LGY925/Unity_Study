using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RaycastTester : MonoBehaviour
{
    private void Update()
    {
        // ����ĳ��Ʈ : ������ġ���� �������� �������� �߻��Ͽ� �΋H���� �浹ü�� ����
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, 10f))
        {
            // �������� ���� �浹ü�� �ִ�
            Debug.Log(hitInfo.collider.gameObject.name);
            Debug.DrawLine(transform.position, hitInfo.point, Color.green);
        }
        else
        {
            // �������� ���� �浹ü�� ����
            Debug.Log("Lost Collider");
            Debug.DrawLine(transform.position, transform.position + transform.forward * 10f, Color.red);
        }
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 3f);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.forward * 10);
    }

}