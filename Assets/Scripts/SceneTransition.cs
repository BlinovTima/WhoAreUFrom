using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [Header("Scene numder")]

    public int _sceneNumber;

    public void Transition()
    {
        SceneManager.LoadScene(_sceneNumber);
    }
}
