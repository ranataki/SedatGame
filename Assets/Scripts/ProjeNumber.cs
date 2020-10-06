using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProjeNumber : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI numText;
    int num;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
        Debug.Log("oyunun çalışıyo");
    }

    public void DahaFazlaPress()
    {
        min = num + 1;
        NextGuess();
    }

    public void DahaAzPress()
    {
        max = num - 1;
        NextGuess();
    }
 
    void  NextGuess()
    {
        num = Random.Range(min, max);
        numText.text = num.ToString();
    }
}
