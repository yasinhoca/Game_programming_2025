using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class baslat : MonoBehaviour
{
    public void PlayGame() {
        SceneManager.LoadScene("part1"); // menu'nun sayısal sıra değeri de yazılabilir
    }
}
