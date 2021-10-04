using iii_UMVR06_TPSDefenseGame_Subroutines_2;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonShell : MonoBehaviour
{
    public float dmg = 50.0f;
    private float fTime;
    public float shellspeed = 15.0f;

    public GameObject EffectExplo;
    void Start()
    {
        fTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + transform.forward * shellspeed * Time.deltaTime;

    }
    public void CanonShellAttack(Vector3 FirePoint, Vector3 targetposition)
    {

        transform.position = FirePoint;
        transform.forward = targetposition;
        //gameObject.SetActive(true);



    }
    private void OnTriggerEnter(Collider other)
    {

        
        if (other.gameObject.CompareTag("EnemyHit"))
        {

            other.GetComponentInParent<IEnemy_Base>().UnderAttack(dmg);
            other.GetComponentInParent<IEnemy_Base>().PlayGetHit();

        }
        var instance = Instantiate(EffectExplo, transform.position, Quaternion.identity);
        Destroy(instance, 2f);
    }
}
