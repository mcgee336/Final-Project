using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private int collectScore;

    private ScoreControl _scoreController;


    private void Awake()
    {
        _scoreController = FindFirstObjectByType<ScoreControl>();
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AllocateScore();
            Destroy(gameObject);
        }
    }
    

    public void AllocateScore()
    {
        _scoreController.AddScore(collectScore);
    }

}
