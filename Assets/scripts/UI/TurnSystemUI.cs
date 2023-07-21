using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TurnSystemUI : MonoBehaviour
{
    [SerializeField] private Button endTurnButton;
    [SerializeField] private TextMeshProUGUI turnNumberText;

    private void Start()
    {
        endTurnButton.onClick.AddListener(() =>
        {
            TurnSystem.Instance.NextTurn();
        });

        TurnSystem.Instance.OnTurnChanged += TurnSystem_OnTurnChanged;

        UpdateEndTurnText();
    }

    private void TurnSystem_OnTurnChanged(object sender, EventArgs e)
    {
        UpdateEndTurnText();
    }

    private void UpdateEndTurnText()
    {
        turnNumberText.text = "TURN " + TurnSystem.Instance.GetTurnNumber();
    }
}
