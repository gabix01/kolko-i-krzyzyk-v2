using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(Button))]
public class Reset : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
