using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class IncreaseCount : MonoBehaviour, IAction
{
    int clickCount = 1;
    [SerializeField] TextMeshProUGUI countText;
    private void Awake() {
        countText.text = "Count: 0";
    }
    
    public void DoAction()
    {
        countText.text = $"Count: {clickCount++}";
    }
}
