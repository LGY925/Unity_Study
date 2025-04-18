using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Transform : MonoBehaviour
{

    /****************************************************************\
     * Ʈ������ (Transform)
     * 
     * ���ӿ�����Ʈ�� ��ġ, ȸ��, ũ�⸦ �����ϴ� ������Ʈ
     * ���ӿ�����Ʈ�� �θ�-�ڽ� ���¸� �����ϴ� ������Ʈ
     * ���ӿ�����Ʈ�� �ݵ�� �ϳ��� Ʈ������ ������Ʈ�� ������ ������ �߰� & ������ �� ����
    \****************************************************************/




    [SerializeField] float moveSpeed;
    [SerializeField] Transform target;
    [SerializeField] float rate;
    [SerializeField] float rotateSpeed;

    private void Start()
    {
        Application.targetFrameRate = 30;
    }
    private void Update()
    {
        #region Position

        // 1. ���͸� �̿��� ��ġ ����
        transform.position = new Vector3(1, 2, 3);

        // 2. �������� �̵���Ű��

        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // 3. �������� �̵��ñ�Ű
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed);

        // 4. �����ؼ� �̵���Ű��
        transform.position = Vector3.Lerp(transform.position, target.position, rate);
        #endregion

        #region rotation

        // 1. ȸ�� ���� ���� : Euler�� �̿��Ͽ� Quaternion���� ��ȯ�Ͽ� ��� ����
        transform.rotation = Quaternion.Euler(0, 60, 0);

        // 1-1. ���Ϸ��� ���ʹϾ����� ��ȯ
        Quaternion a = Quaternion.Euler(0, 60, 0);

        // 1-2. ���ʹϾ��� ���Ϸ��� ��ȯ
        Vector3 v = transform.rotation.eulerAngles;

        // 1-3. ���� ���͸� ���ʹϾ����� ��ȯ
        Quaternion c = Quaternion.LookRotation(Vector3.right);

        // 1-4. ���� ȸ���� ������ͷ� ��ȯ
        Vector3 d = transform.right;

        // 2. ���� �������� ȸ����Ű��
        transform.Rotate(Vector3.forward, rotateSpeed* Time.deltaTime);

        // 3. ������ �������� ȸ��
        transform.RotateAround(target.position, Vector3.up, rotateSpeed * Time.deltaTime);

        // 4. ������ �ٶ󺸵��� ȸ��
        transform.LookAt(target.position);
        #endregion

        #region
        // ���� ����
        Vector3 worldPosition = transform.position;
        Quaternion worldRotation = transform.rotation;

        // ���� ����
        Vector3 localPosition = transform.localPosition;
        Quaternion localRotation = transform.localRotation;

        #endregion
    }


}
