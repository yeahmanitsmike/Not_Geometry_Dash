using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScreen : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene("Level");
    }
}
