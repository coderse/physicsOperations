using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicsCaptureOperations : MonoBehaviour
{
    /*
    //rigitbody yard�m�yla etkile�imi yakalamak

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Etkile�im oldu"); //herhangi bir colliderla herhangi bir objeyle etkile�im oldu�unda haber verir.

    }*/
    
    //spesifik olarak bir objeyle olan etkile�imi yakalamak i�in
    private void OnCollisionEnter(Collision collision)
    {

       

        if(collision.gameObject.name == "2")
        {
            /*Destroy(gameObject); // mesela etkile�im oldu�unda scritin oldu�u obje yokedilebilir..
                                 // �rnek;yap�labilecekler..*/
            Destroy(collision.gameObject); // etkile�im yap�ld��� objeyi yok eder

            Debug.Log("Etkile�im oldu"); //bu �ekilde ismi 2 olan objeye dokundu�unda yakalam�� oluruz
        }

    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "2")
        {
            Debug.Log("Etkile�im s�r�yor"); //etkile�im devam ediyorsa
        }

    }

    private void OnCollisionExit(Collision collision)
    {
            if (collision.gameObject.name == "2")
            {
                Debug.Log("Etkile�im bitti"); //etkile�im bittiyse
            }
          
    }

    /*
   
    //collider yard�m�yla rigitbodysiz ve fizik kurallar� olmadan etkile�im oldu�unu kod taraf�na iletme
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "2")
        {
            Debug.Log("Etkile�im oldu"); //bu �ekilde ismi 2 olan objeye dokundu�unda yakalam�� oluruz
        }

        //tag ile yakalama
        if (other.CompareTag("FizikYakalamaTag"))
        {
            Debug.Log("Etkile�im oldu"); //bu �ekilde ismi 2 olan objeye dokundu�unda yakalam�� oluruz
        }


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "2")
        {
            Debug.Log("Etkile�im s�r�yor"); //etkile�im devam ediyorsa
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "2")
        {
            Debug.Log("Etkile�im bitti"); //etkile�im bittiyse
        }
    }
    */
  







}
