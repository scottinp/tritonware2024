using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class winScript : MonoBehaviour
{

    private void OnCollisionEnter(Collision collsion){
        if (collsion.gameObject.tag == "Player"){
                    SceneManager.LoadScene(4);

            
        }
    }
}
