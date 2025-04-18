using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectTest : MonoBehaviour
{
    
    /****************************************************************\
     * ���ӿ�����Ʈ (GameObject)
     * 
     * ���� �����ϴ� ������Ʈ�̸� ���ӿ� �����ϴ� ��� ������Ʈ�� ���ӿ�����Ʈ
     * ���� �����Ͽ� ���ȿ� ���̴� ��ü �Ǵ� �������� ������ �ʴ� ����� ���� ����ǰ
     * ���ӿ�����Ʈ�����δ� �������� ����� ����
     * �������� ����� ������Ʈ���� ����
     * ���ӿ�����Ʈ�� ������Ʈ���� ������ ���� �����̳�
    \****************************************************************/

    /****************************************************************\
     * ������Ʈ (Component)
     * 
     * Ư���� ����� ������ �� �ֵ��� ������ ���� ����� ����
     * ���ӿ�����Ʈ�� �۵��� ������ ��ǰ
     * ���ӿ�����Ʈ�� �߰�, �����ϴ� ����� ������ ��ǰ
    \****************************************************************/



    /****************************************************************\
     * MonoBehaviour
     * 
     * ������Ʈ�� �⺻Ŭ������ �ϴ� Ŭ������ ����Ƽ ��ũ��Ʈ�� �Ļ��Ǵ� �⺻ Ŭ����
     * ���ӿ�����Ʈ�� ��ũ��Ʈ�� ������Ʈ�μ� ������ �� �ִ� ������ ����
    \****************************************************************/

    public GameObject target;
    public Transform camTransform;
    public Camera camComponent;


    void Start()
    {
        Debug.Log($"�� ���ӿ�����Ʈ�� �̸�{gameObject.name}");
        Debug.Log($"�� ���ӿ�����Ʈ�� Ȱ��ȭ ����{gameObject.activeSelf}");
        Debug.Log($"�� ���ӿ�����Ʈ�� ���̾� Ȱ��ȭ ����{gameObject.layer}");
        Debug.Log($"�� ���ӿ�����Ʈ�� �±�{gameObject.tag}");
        Debug.Log($"�� ���ӿ�����Ʈ�� �������� ���� ����{gameObject.isStatic}");

        target = GameObject.FindGameObjectWithTag("MainCamera");
        camTransform = target.transform;
        camComponent = target.GetComponent<Camera>();

        target.AddComponent<Rigidbody>();

        Destroy(gameObject);
        Destroy(camComponent);
    }


}

