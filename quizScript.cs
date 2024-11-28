using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class quizScript : MonoBehaviour
{
    //panel gameObjects
    public GameObject UIPanel;
    public GameObject loginPanel;
    public GameObject startQuizMenuPanel;
    public GameObject quizQuestion1Panel;
    public GameObject quizQuestion2Panel;
    public GameObject quizQuestion3Panel;
    public GameObject quizQuestion4Panel;
    public GameObject quizQuestion5Panel;
    public GameObject quizQuestion6Panel;
    public GameObject quizQuestion7Panel;
    public GameObject quizQuestion8Panel;
    public GameObject quizQuestion9Panel;
    public GameObject reviewMenuPanel;
    //startUI gameObjects
    public GameObject startButton;
    //loginUI gameObjects
    public GameObject loginButton;
    public GameObject nameSurnameTextField;
    public GameObject errorMessageText;
    //startQuizUI gameObjects
    public GameObject startQuizButton;
    public GameObject homeButton;
    //question1UI gameObjects
    public GameObject option1Q1button;
    public GameObject option2Q1button;
    public GameObject option3Q1button;
    public GameObject timeLeftTextQ1;
    //question2UI gameObjects
    public GameObject option1Q2button;
    public GameObject option2Q2button;
    public GameObject option3Q2button;
    public GameObject timeLeftTextQ2;
    //question3UI gameObjects
    public GameObject option1Q3button;
    public GameObject option2Q3button;
    public GameObject timeLeftTextQ3;
    //question4UI gameObjects
    public GameObject option1Q4button;
    public GameObject option2Q4button;
    public GameObject option3Q4button;
    public GameObject option4Q4button;
    public GameObject timeLeftTextQ4;
    //question5UI gameObjects
    public GameObject option1Q5button;
    public GameObject option2Q5button;
    public GameObject option3Q5button;
    public GameObject timeLeftTextQ5;
    //question6UI gameObjects
    public GameObject option1Q6button;
    public GameObject option2Q6button;
    public GameObject timeLeftTextQ6;
    //question7UI gameObjects
    public GameObject option1Q7button;
    public GameObject option2Q7button;
    public GameObject option3Q7button;
    public GameObject timeLeftTextQ7;
    //question8UI gameObjects
    public GameObject option1Q8button;
    public GameObject option2Q8button;
    public GameObject option3Q8button;
    public GameObject option4Q8button;
    public GameObject timeLeftTextQ8;
    //question9UI gameObjects
    public GameObject option1Q9button;
    public GameObject option2Q9button;
    public GameObject option3Q9button;
    public GameObject option4Q9button;
    public GameObject timeLeftTextQ9;
    //reviewUI gameObjects
    public GameObject resetButton;
    public GameObject nameScoreText;
    //score tracker (user gets 25 points everytime they answer a question correctly)
    public int score = 0;
    //name storage
    public string nameSurname = "";
    public int qNum;
    public int qCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        //checking if name entered by the user is valid and not null
        errorMessageText.SetActive(false);
        score = 0;
        nameSurname = "";

        if(PlayerPrefs.HasKey("PlayerName"))
        {
            nameSurname = PlayerPrefs.GetString("PlayerName");
        }
    }

    void Update()
    {

    }

    //method to shuffle questions being displayed
    public void displayNextQuestion()
    {
        //turning off start quiz menu and displaying randomized quiz question
        startQuizMenuPanel.SetActive(false);
        qCounter++;
        qNum = UnityEngine.Random.Range(1, 10);

        //checking which random number is generated to display specific panel
        if (qNum == 1)
        {
            quizQuestion1Panel.SetActive(true);
            quizQuestion2Panel.SetActive(false);
            quizQuestion3Panel.SetActive(false);
            quizQuestion4Panel.SetActive(false);
            quizQuestion5Panel.SetActive(false);
            quizQuestion6Panel.SetActive(false);
            quizQuestion7Panel.SetActive(false);
            quizQuestion8Panel.SetActive(false);
            quizQuestion9Panel.SetActive(false);
        }
        //displaying 2nd question
        if(qNum == 2)
        {
            quizQuestion1Panel.SetActive(false);
            quizQuestion2Panel.SetActive(true);
            quizQuestion3Panel.SetActive(false);
            quizQuestion4Panel.SetActive(false);
            quizQuestion5Panel.SetActive(false);
            quizQuestion6Panel.SetActive(false);
            quizQuestion7Panel.SetActive(false);
            quizQuestion8Panel.SetActive(false);
            quizQuestion9Panel.SetActive(false);
        }
        //displaying 3rd question
        if(qNum == 3)
        {
            quizQuestion1Panel.SetActive(false);
            quizQuestion2Panel.SetActive(false);
            quizQuestion3Panel.SetActive(true);
            quizQuestion4Panel.SetActive(false);
            quizQuestion5Panel.SetActive(false);
            quizQuestion6Panel.SetActive(false);
            quizQuestion7Panel.SetActive(false);
            quizQuestion8Panel.SetActive(false);
            quizQuestion9Panel.SetActive(false);
        }
        //displaying 4th question
        if(qNum == 4)
        {
            quizQuestion1Panel.SetActive(false);
            quizQuestion2Panel.SetActive(false);
            quizQuestion3Panel.SetActive(false);
            quizQuestion4Panel.SetActive(true);
            quizQuestion5Panel.SetActive(false);
            quizQuestion6Panel.SetActive(false);
            quizQuestion7Panel.SetActive(false);
            quizQuestion8Panel.SetActive(false);
            quizQuestion9Panel.SetActive(false);
        }
        //displaying 5th question
        if(qNum == 5)
        {
            quizQuestion1Panel.SetActive(false);
            quizQuestion2Panel.SetActive(false);
            quizQuestion3Panel.SetActive(false);
            quizQuestion4Panel.SetActive(false);
            quizQuestion5Panel.SetActive(true);
            quizQuestion6Panel.SetActive(false);
            quizQuestion7Panel.SetActive(false);
            quizQuestion8Panel.SetActive(false);
            quizQuestion9Panel.SetActive(false);
        }
        //displaying 6th question
        if(qNum == 6)
        {
            quizQuestion1Panel.SetActive(false);
            quizQuestion2Panel.SetActive(false);
            quizQuestion3Panel.SetActive(false);
            quizQuestion4Panel.SetActive(false);
            quizQuestion5Panel.SetActive(false);
            quizQuestion6Panel.SetActive(true);
            quizQuestion7Panel.SetActive(false);
            quizQuestion8Panel.SetActive(false);
            quizQuestion9Panel.SetActive(false);
        }
        //displaying 7th question
        if(qNum == 7)
        {
            quizQuestion1Panel.SetActive(false);
            quizQuestion2Panel.SetActive(false);
            quizQuestion3Panel.SetActive(false);
            quizQuestion4Panel.SetActive(false);
            quizQuestion5Panel.SetActive(false);
            quizQuestion6Panel.SetActive(false);
            quizQuestion7Panel.SetActive(true);
            quizQuestion8Panel.SetActive(false);
            quizQuestion9Panel.SetActive(false);
        }
        //displaying 8th question
        if(qNum == 8)
        {
            quizQuestion1Panel.SetActive(false);
            quizQuestion2Panel.SetActive(false);
            quizQuestion3Panel.SetActive(false);
            quizQuestion4Panel.SetActive(false);
            quizQuestion5Panel.SetActive(false);
            quizQuestion6Panel.SetActive(false);
            quizQuestion7Panel.SetActive(false);
            quizQuestion8Panel.SetActive(true);
            quizQuestion9Panel.SetActive(false);
        }
        //displaying 9th question
        if(qNum == 9)
        {
            quizQuestion1Panel.SetActive(false);
            quizQuestion2Panel.SetActive(false);
            quizQuestion3Panel.SetActive(false);
            quizQuestion4Panel.SetActive(false);
            quizQuestion5Panel.SetActive(false);
            quizQuestion6Panel.SetActive(false);
            quizQuestion7Panel.SetActive(false);
            quizQuestion8Panel.SetActive(false);
            quizQuestion9Panel.SetActive(true);
        }
        //if counter = 9, review menu pops up to show the user their score
        if(qCounter == 9)
        {
            //switching off other panels after nine numbers have been generated then taking user to review score menu
            quizQuestion1Panel.SetActive(false);
            quizQuestion2Panel.SetActive(false);
            quizQuestion3Panel.SetActive(false);
            quizQuestion4Panel.SetActive(false);
            quizQuestion5Panel.SetActive(false);
            quizQuestion6Panel.SetActive(false);
            quizQuestion7Panel.SetActive(false);
            quizQuestion8Panel.SetActive(false);
            quizQuestion9Panel.SetActive(false);
            reviewMenuPanel.SetActive(true);
        }
    }

    //update score method
    public void updateScore()
    {
        //if user clicks the correct button option their score will be updated
        score += 25;
    }

    //display loginUI method after start button clicked
    public void displayLoginInMenu()
    {
        UIPanel.SetActive(false);
        loginPanel.SetActive(true);
    }
    //display home page
    public void displayHomeUI()
    {
        startQuizMenuPanel.SetActive(false);
        UIPanel.SetActive(true);
    }
    //display startQuizMenu method after checking if name entered is valid
    public void checkLoginToQuizMenu()
    {
        //storing what the user entered in the input field
        nameSurname = nameSurnameTextField.GetComponent<Text>().text;
        if(!string.IsNullOrEmpty(nameSurname))
        {
            //saving the users name entered using playerprefs
            PlayerPrefs.SetString("PlayerName", nameSurname);
            PlayerPrefs.Save();

            //displaying next menu if user enters valid string
            loginPanel.SetActive(false);
            startQuizMenuPanel.SetActive(true);
        }
        else
        {
            //displaying error message if input field is left blank
            errorMessageText.SetActive(true);
        }
    }

    //display final score when button is clicked
    public void displayScoreButtonCLicked()
    {
        //display the score along with the learner's name, quiz start time, and quiz completion time
        string quizInfo = "Name: " + nameSurname + "\n";
        quizInfo += "Your final score is: " + score;
        //saving info into a text gameobject to display info from thw quiz
        nameScoreText.GetComponent<Text>().text = quizInfo;
        nameScoreText.SetActive(true);
    }
}