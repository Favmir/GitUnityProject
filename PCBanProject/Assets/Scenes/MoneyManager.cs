using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    Text Scoreboard;

    private int _money;

    public void ChangeMoney(int value)
    {
        _money += value;
        Scoreboard.text = _money.ToString();
    }
}
