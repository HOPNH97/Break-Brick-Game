using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Text txtDiem;
    int diem = 0;

    public void IncreasePoint()
    {
        diem++;
        SetPoint();
    }
    void SetPoint()
    {
        txtDiem.text = "Scores: " + diem.ToString();
    }
}
