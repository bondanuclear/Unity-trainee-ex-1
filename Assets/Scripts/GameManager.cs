using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Button colorButton;
    [SerializeField] Button countButton;
    public void IncreaseCount()
    {
        countButton.GetComponent<IAction>().DoAction();
    }
    public void ChangeColor()
    {
        colorButton.GetComponent<IAction>().DoAction();
    }
}
