using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game_manager : MonoBehaviour
{
    public TextMeshProUGUI MenuTextMeshPro, Health_ValueTextMeshPro, Sanity_ValueTextMeshPro;
    public string Menu;
    public int Health_value, Sanity_value;
    public GameObject Level_1_Choices;

    // Start is called before the first frame update
    void Start()
    {
        Health_value = 100;
        Sanity_value = 100;
    }

    // Update is called once per frame
    void Update()
    {
        MenuTextMeshPro.text = MenuTextMeshPro;
        Health_ValueTextMeshPro.text = Health_value.ToString();
        Sanity_ValueTextMeshPro.text = Sanity_value.ToString();
    }
    public void Choice_1()
    {
        Menu = "Its too dark.";
        Sanity_value -= 5;
    }
    public void Choice_2()
    {
        Menu = "Not much in here.";
        Sanity_value -= 5;
    }
    public void Choice_3()
    {
        Menu = "There's no one here.";
        Sanity_value = 5;
    }
    public void Start_game()
    {
        Level_1_Choices.SetActive(true);
        Start_game().SetActive(false);
        Exit_game().SetActive(false);
        Menu = "I wake up";
    }
    public void Exit_game()
    {
        Application Quit();
    }
}
