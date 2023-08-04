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
        //������ ������ �༭ �̵���Ų�� 
        //�� : (0, 0, 1)
        //Vector3.forward (������ǥ)
        //����̰� �ٶ󺸴� ����? (������ǥ)
        this.rBody.AddForce(force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //�浹�� ����� ���ӿ�����Ʈ�� �̸� 
        
        if (collision.gameObject.tag == "Target")
        {
            Debug.Log("���ῡ �浹!");
            this.rBody.isKinematic = true;
            this.effect.Play();
        }
    }
}
