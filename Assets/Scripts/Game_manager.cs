using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game_manager : MonoBehaviour
{
    public TextMeshProUGUI MenuTextMeshPro, HealthTextMeshPro, SanityTextMeshPro;
    public string Menu;
    public int Health_value, Sanity_value;
    public GameObject Level_1_Choices;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MenuTextMeshPro.text = MenuText;
        HealthTextMeshPro.text = Health_value.ToString();
        SanityTextMeshPro.text = Sanity_value.ToString();
    }
    public void Choice_1
    {
        MenuText = "It seems quiet... But, where is everyone?";
        Health_value = 100;
        Level_1_Choices.SetActive(false);
    }
    public void Choice_2
    {
        MenuText = "Someone decided to rummage through my bag, damn. They only left a lighter.";
    }
    public void Choice_3 
    { 
        MenuText = "There's a toolbox next to the elevator. It was working earlier.";
        Level_1_Choices.SetActive(false);
        Level_2_Choices.SetActive(true);
        Health_value = 100;
        Sanity -= 5;
    }
}
