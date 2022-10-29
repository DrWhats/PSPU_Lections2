using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreLabel;
    [SerializeField] private int _score;
    [SerializeField] private Animator _animator;

    [SerializeField]
    public int scoreToAddAuto;

    void Start()
    {
        _scoreLabel.SetText(_score.ToString());
        InvokeRepeating("AutoAddScore", 1, 1F);
    }


    public void AddScore(int scoreToAdd)
    {
        _score += scoreToAdd;
        UpdateScoreLabel();
    }

    void UpdateScoreLabel()
    {
        _scoreLabel.SetText(_score.ToString());
    }

    public void PlayAnimation(string AnimationName)
    {
        _animator.Play(AnimationName);
            
    }

    public void AutoAddScore()
    {
        AddScore(scoreToAddAuto);
    }



}
