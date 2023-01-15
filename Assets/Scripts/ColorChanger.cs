using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour, IAction
{
    static System.Random rnd = new System.Random();
    Button colorButton;
    [SerializeField] Color[] colors = 
        { Color.red, Color.black, Color.blue, Color.cyan, Color.green };

    private void Awake() {
        colorButton = GetComponent<Button>();
    }
    public void DoAction()
    {
        colorButton.GetComponent<Image>().color = colors[rnd.Next(0, colors.Length)];
    }
}
