using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReStart : MonoBehaviour
{
    [Header("プレイヤーゲームオブジェクト")] public GameObject playerObj;
    [Header("コンティニュー位置")] public GameObject[] continuePoint;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //SceneManager.LoadScene("Title");
            playerObj.transform.position = continuePoint[0].transform.position;
        }

        if (other.gameObject.tag == "Ball" || other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
    }
}
