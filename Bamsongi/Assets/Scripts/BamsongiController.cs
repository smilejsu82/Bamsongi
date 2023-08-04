using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    private Rigidbody rBody;
    [SerializeField]
    private float forwardForce = 2000;
    private ParticleSystem effect;

    private void Awake()
    {
        this.rBody = this.GetComponent<Rigidbody>();
        this.effect = this.GetComponent<ParticleSystem>();
        Debug.Log("Awake");
    }

    void Start()
    {
        //this.Shoot();
        Debug.Log("Start");
    }

    public void Shoot(Vector3 force)
    {
        Debug.Log("Shoot");
        //앞으로 힘으로 줘서 이동시킨다 
        //앞 : (0, 0, 1)
        //Vector3.forward (월드좌표)
        //밤송이가 바라보는 앞쪽? (로컬좌표)
        this.rBody.AddForce(force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //충돌한 대상의 게임오브젝트의 이름 
        
        if (collision.gameObject.tag == "Target")
        {
            Debug.Log("과녁에 충돌!");
            this.rBody.isKinematic = true;
            this.effect.Play();
        }
    }
}
