using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject UI, Choices, Intro_room_choice, Intro_elevator_choice, Titlescreen, Ending1;
    public int health, sanity;
    public TextMeshProUGUI healthText, sanityText, GameText;
    // Start is called before the first frame update
    void Start()
    {
        Titlescreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = health.ToString();
        sanityText.text = sanity.ToString();

        if (health <= 0)
        {
            Ending1.SetActive(true);
            Choices.SetActive(false);
            UI.SetActive(false);
        }
        if (sanity <= 0)
        {
            Ending1.SetActive(true);
            Choices.SetActive(false);
            UI.SetActive(false);
        }
    }
    
    public void StartGameButton()
    {
        Titlescreen.SetActive(false);
        Intro_room_choice.SetActive(true);
        UI.SetActive(true);
    }
    public void EndGameButton()
    {
        Application.Quit();
    }
    public void IR_Choice_1()
    {
        GameText.text = "Where is everyone?";
        sanity -= 5;
    }
    public void IR_Choice_2()
    {
        GameText.text = "Damn, someone decided to rummage through my things... There's only a lighter left.";
        sanity -= 5;
    }
    public void IR_Choice_3()
    {
        Intro_room_choice.SetActive(false);
        Intro_elevator_choice.SetActive(true);
        sanity -= 5;
    }
    public void Ending1_choice1()
    {
        Choices.SetActive(true);
        Intro_room_choice.SetActive(true);
        UI.SetActive(true);
    }
    public void Ending1_choice2()
    {
        Application.Quit();
    }
}
