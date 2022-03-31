﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    [Header("Score")]
    public static TMP_Text _scoreUI;
    public TMP_Text scoreUI;
    public static TMP_Text _highscoreUI;
    public TMP_Text highscoreUI;
    public static UI instance;
    [Header("Health")]
    public RectTransform healthBar;
    [Range(0, 10)] public float healthBarWidth = 50f;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Awake()
    {
        instance = this;
        _scoreUI = scoreUI;
        _highscoreUI = highscoreUI;
    }
    // Update is called once per frame
    void Update()
    {
        healthBar.sizeDelta = Vector2.Lerp(healthBar.sizeDelta, new Vector2(healthBarWidth * Gunner.health, healthBar.sizeDelta.y), Time.deltaTime * 3);
    }
}
