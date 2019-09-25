using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAAAAAAAAAAAAAAAAA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);

        StartCoroutine(RemoveAfterSeconds(10));


        IEnumerator RemoveAfterSeconds(int seconds)
        {
            yield return new WaitForSeconds(seconds);
            gameObject.SetActive(false);
        }


    }
}
