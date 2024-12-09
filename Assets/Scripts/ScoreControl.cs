using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreControl : MonoBehaviour
{

public UnityEvent OnScoreChanged;
    
    public int Score {  get; private set; }
    public AudioSource source;
    public AudioClip collect;
    public void AddScore(int amount)
    {
        Score += amount;
        OnScoreChanged.Invoke();
        source.PlayOneShot(collect);
    }
}
