using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem finishEffect;
    [SerializeField] float ChangeScene = 2f;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            finishEffect.Play();
            Invoke("ReloadScene", ChangeScene);
            GetComponent<AudioSource>().Play();
            // SceneManager.LoadScene();
            // Debug.Log("You Finished!");
        }
    }

    void ReloadScene()
    {

            SceneManager.LoadScene(0);
    }
}
