using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeToPuzzle : MonoBehaviour
{

    public void GoToPuzzle()
    {
        SceneManager.LoadScene("Puzzle");
    }

}
