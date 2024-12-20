using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _gameObject;
    [SerializeField] TextMeshProUGUI _levelText;
    [SerializeField] GameObject _finishWindow;
    [SerializeField] CoinManager _coinManager;

    private void Start()
    {
        _levelText.text = SceneManager.GetActiveScene().name;
    }
    public void Play()
    {
        _gameObject.SetActive(false);
        FindObjectOfType<PlayerBehaviour>().Play();
    }   
    public void ShowFinishWindow()
    {
        _finishWindow.SetActive(true);
    }

    public void NextLevel()
    {
        int next = SceneManager.GetActiveScene().buildIndex + 1;
        if (next < SceneManager.sceneCountInBuildSettings)
        {
            _coinManager.SaveToProgress();
            SceneManager.LoadScene(next);
        }
    }
}
