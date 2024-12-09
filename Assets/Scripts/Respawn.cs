using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
       if (other.gameObject.CompareTag("Player"))
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        } 
    }
}
