using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    public GameObject[] Levels;
    public GameObject ResetScreen,End; 

    int currentLevel;

    //Try Again Screen
    public void wrongAnswer()
    {
        ResetScreen.SetActive(true);
    }

    //Return to previously attempted question.
    public void ResetGame()
    {
        ResetScreen.SetActive(false);
        Levels[currentLevel].SetActive(true);
    }

    //Load the Tic Tac Toe Game Scene
    public void GameScene()
    {
        SceneManager.LoadScene("Main");
    }

    //Difficulty Scene
    public void DifficultyScene()
    {
        SceneManager.LoadScene("Difficulty");
    }

    //Easy Scenes
    public void EasyCategoryScene()
    {
        SceneManager.LoadScene("EasyCategories");
    }

    public void EasyMathScene()
    {
        SceneManager.LoadScene("EasyMath");
    }

    public void EasyScienceScene()
    {
        SceneManager.LoadScene("EasyScience");
    }

    public void EasyEnglishScene()
    {
        SceneManager.LoadScene("EasyEnglish");
    }

    public void EasyTechnologyScene()
    {
        SceneManager.LoadScene("EasyTechnology");
    }

    //Medium Scenes
    public void MediumCategoryScene()
    {
        SceneManager.LoadScene("MediumCategories");
    }

    public void MediumMathScene()
    {
        SceneManager.LoadScene("MediumMath");
    }

    public void MediumScienceScene()
    {
        SceneManager.LoadScene("MediumScience");
    }

    public void MediumEnglishScene()
    {
        SceneManager.LoadScene("MediumEnglish");
    }

    public void MediumTechnologyScene()
    {
        SceneManager.LoadScene("MediumTechnology");
    }

    //Hard Scenes
    public void HardCategoryScene()
    {
        SceneManager.LoadScene("HardCategories");
    }

    public void HardMathScene()
    {
        SceneManager.LoadScene("HardMath");
    }

    public void HardScienceScene()
    {
        SceneManager.LoadScene("HardScience");
    }

    public void HardEnglishScene()
    {
        SceneManager.LoadScene("HardEnglish");
    }

    public void HardTechnologyScene()
    {
        SceneManager.LoadScene("HardTechnology");
    }

    //Start the questions at element 0 of the Levels array or the first question.
    public void StartQuestions()
    {
        ResetScreen.SetActive(false);
        Levels[currentLevel].SetActive(true);
    }

    //Increase level by one if correct. If last level correct show passed quiz screen.
    public void correctAnswer()
    {
        if(currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);

            currentLevel++;
            Levels[currentLevel].SetActive(true);
        }
        else
        {
            End.SetActive(true);
            Levels[currentLevel].SetActive(false);
        }
    }

    public void exitgame()
    {
        Debug.Log("exitgame");
        Application.Quit();
    }
    



    }
