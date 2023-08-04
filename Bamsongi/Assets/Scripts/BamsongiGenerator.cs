using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    //밤송이 프리팹 
    public GameObject bamsongiPrefab;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //화면을 터치 하면 월드공간에서 Ray를 생성함 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //생성된 레이를 에디터에서 출력 
            Debug.DrawRay(ray.origin, ray.direction * 1000f, Color.red, 1f);

            //ray.direction.normalized (단위벡터로 변경)
            //길이가 1인 벡터 : 방향 
            Vector3 force = ray.direction.normalized * 2000f;
            this.CreateBamsongi(force);
        }
    }

    private void CreateBamsongi(Vector3 force)
    {
        //새로운 밤송이를 생성한다 
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
