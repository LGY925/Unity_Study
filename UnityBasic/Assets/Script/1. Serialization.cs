using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;

public class Serialization : MonoBehaviour
{

    /****************************************************************\
     * ����ȭ (Serialization)
     * 
     * ������ ���� �Ǵ� ���ӿ�����Ʈ ���¸� �����ϰ� �����ϴ� ���
     * �ν����� â���� ������Ʈ�� ����ȭ�� ������� ���� ������
     * �̸� �̿��Ͽ� �ҽ��ڵ��� ���� ���� ����Ƽ �����Ϳ��� ���� ���� ����
    \****************************************************************/
    
    // C# Type
    public bool boolValue;
    public int intValue;
    public float floatValue;
    public string stringValue;

    // Unity Type
    public Vector3 vector3;
    public Vector3Int vector3Int;
    public Vector2 vector2;
    public Vector2Int vector2Int;
    public Color color;
    public Rect rect;
    public LayerMask layerMask;
    public AnimationCurve curve;
    public Gradient gradient;
    
    // ������
    public ForceMode mode;

    // ����ȭ ������ �ʵ��� �迭 �� List<T>
    public int[] array;
    public List<int> list;

    [Header("Reference")]
    // Object Type
    public new GameObject gameObject;
    public new Transform transform;
    public new Rigidbody rigidbody;
    public new Collider collider;

    // <��Ʈ����Ʈ>
    // Ŭ����, �Ӽ� �Ǵ� �Լ� ���� ����Ͽ� Ư���� ������ ��Ÿ�� �� �ִ� ��Ŀ

    [Space(30)]

    [Header("Unity Attribute")]

    [SerializeField]
    private int privateValue;

    [HideInInspector]
    public int publicValue;

    [Range(0, 10)]
    public float rangeValue;

    [TextArea(3, 5)]
    public string textField;

    [Serializable] // ����ü�� ����ȭ ���� �Ӽ��� ����
    public struct StructType
    {
        public int value1;
        public string value2;
    }
    public StructType structField;

    [Serializable] // Ŭ������ ����ȭ ���� �Ӽ��� ����
    public class ClassType
    {
        public int value1;
        public string value2;
    }
    public ClassType classField;
    
    

    /****************************************************************\
     * ����Ƽ �޽��� �Լ�
     * 
     * ����Ƽ�� ������ �޽����� �����ϴ� �Լ�
     * MonoBehaviour Ŭ������ �޽����� ���� �̸��� �Լ��� ����
     * ��ũ��Ʈ�� ����Ƽ ������ ������ �޽����� �޾� ��� Ÿ�̹��� Ȯ��
     * �޽��� �Լ����� �ڽ��� �ൿ�� �����Ͽ� ����� ����
    \****************************************************************/

    // �Լ� : ���



    private void Awake()
    {
        // ��ũ��Ʈ�� ���� ���ԵǾ��� �� 1ȸ ȣ��
        // ��ũ��Ʈ�� ��Ȱ��ȭ �Ǿ� �ִ� ��쿡�� ȣ���

        // ���� : ��ũ��Ʈ�� �ʿ�� �ϴ� �ʱ�ȭ �۾� ����
        //        (�ܺ� ���ӻ�Ȳ�� ������ �ʱ�ȭ �۾�)

        Debug.Log("Awake");
    }

    private void Start()
    {
        // ��ũ��Ʈ�� ���� ó������ Update�ϱ� ������ 1ȸ ȣ��
        // ��ũ��Ʈ�� ��Ȱ��ȭ �Ǿ� �ִ� ��� ȣ����� ����

        // ���� : ��ũ��Ʈ�� �ʿ�� �ϴ� �ʱ�ȭ �۾� ����
        //        (�ܺ� ���ӻ�Ȳ�� �ʿ��� �ʱ�ȭ �۾�)

       Debug.Log("Start");
    }

    private void OnEnable()
    {
        // ��ũ��Ʈ�� Ȱ��ȭ�� ������ ȣ��

        // ���� : ��ũ��Ʈ�� Ȱ��ȭ �Ǿ��� �� �۾� ����

        Debug.Log("OnEnable");
    }

    private void OnDisable()
    {
        // ��ũ��Ʈ�� ��Ȱ��ȭ�� ������ ȣ��

        // ���� : ��ũ��Ʈ�� ��Ȱ��ȭ �Ǿ��� �� �۾� ����

        Debug.Log("OnDisable");
    }

    private void Update()
    {
        // ������ ������ ó������ ȣ��

        // ���� : �ٽ� ���� ���� ����

        Debug.Log("Udpate");
    }

    private void LateUpdate()
    {
        // ������ ������ ���������� ȣ��
        // ���� ��� ���ӿ�����Ʈ�� Update�� ����� �� ȣ��

        // ���� : ������������ ���� ����� �ʿ��� ������ �ִ� ��� ����

        Debug.Log("LateUpdate");
    }

    private void FixedUpdate()
    {
        // ������ �ð�(�⺻ 1�ʿ� 50��) ���� ȣ��
        // Update�� �ٸ��� �����Ӵ� ����� �����ð��� ����
        // ���������� ���� ������ �����Ӱ� �����ϰ� �����ؾ� �ϴ� �۾��� ���
        // ���ӷ��� �� ������ ���� �۾��� FixedUpdate�� �������� �ʾƾ� ��

        // ���� : �������� �۾� ����

        Debug.Log("FixedUdpate");
    }

    private void OnDestroy()
    {
        // ��ũ��Ʈ�� ������ �����Ǿ��� �� 1ȸ ȣ��

        // ���� : ��ũ��Ʈ�� �ʿ�� �ϴ� ������ �۾� ����

        Debug.Log("OnDestroy");
    }


}
