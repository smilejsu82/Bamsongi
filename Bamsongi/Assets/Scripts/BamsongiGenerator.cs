using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    //����� ������ 
    public GameObject bamsongiPrefab;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //ȭ���� ��ġ �ϸ� ����������� Ray�� ������ 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //������ ���̸� �����Ϳ��� ��� 
            Debug.DrawRay(ray.origin, ray.direction * 1000f, Color.red, 1f);

            //ray.direction.normalized (�������ͷ� ����)
            //���̰� 1�� ���� : ���� 
            Vector3 force = ray.direction.normalized * 2000f;
            this.CreateBamsongi(force);
        }
    }

    private void CreateBamsongi(Vector3 force)
    {
        //���ο� ����̸� �����Ѵ� 
        GameObject go = Instantiate(this.bamsongiPrefab);
        BamsongiController controller = go.GetComponent<BamsongiController>();

        //go.transform.position = new Vector3(go.transform.position.x, go.transform.position.y, 361.48f);
        Vector3 tpos = go.transform.position;
        tpos.z = 361.48f;
        go.transform.position = tpos;


        Debug.LogError(go.transform.position);

        //controller.Shoot(force);
    }
}
