using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicsCaptureOperations : MonoBehaviour
{
    /*
    //rigitbody yardýmýyla etkileþimi yakalamak

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Etkileþim oldu"); //herhangi bir colliderla herhangi bir objeyle etkileþim olduðunda haber verir.

    }*/
    
    //spesifik olarak bir objeyle olan etkileþimi yakalamak için
    private void OnCollisionEnter(Collision collision)
    {

       

        if(collision.gameObject.name == "2")
        {
            /*Destroy(gameObject); // mesela etkileþim olduðunda scritin olduðu obje yokedilebilir..
                                 // örnek;yapýlabilecekler..*/
            Destroy(collision.gameObject); // etkileþim yapýldýðý objeyi yok eder

            Debug.Log("Etkileþim oldu"); //bu þekilde ismi 2 olan objeye dokunduðunda yakalamýþ oluruz
        }

    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "2")
        {
            Debug.Log("Etkileþim sürüyor"); //etkileþim devam ediyorsa
        }

    }

    private void OnCollisionExit(Collision collision)
    {
            if (collision.gameObject.name == "2")
            {
                Debug.Log("Etkileþim bitti"); //etkileþim bittiyse
            }
          
    }

    /*
   
    //collider yardýmýyla rigitbodysiz ve fizik kurallarý olmadan etkileþim olduðunu kod tarafýna iletme
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "2")
        {
            Debug.Log("Etkileþim oldu"); //bu þekilde ismi 2 olan objeye dokunduðunda yakalamýþ oluruz
        }

        //tag ile yakalama
        if (other.CompareTag("FizikYakalamaTag"))
        {
            Debug.Log("Etkileþim oldu"); //bu þekilde ismi 2 olan objeye dokunduðunda yakalamýþ oluruz
        }


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "2")
        {
            Debug.Log("Etkileþim sürüyor"); //etkileþim devam ediyorsa
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "2")
        {
            Debug.Log("Etkileþim bitti"); //etkileþim bittiyse
        }
    }
    */
  







}
