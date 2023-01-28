using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    [SerializeField] private Text scoreLabel;
    [SerializeField] private SettingsPopup settingsPopup;

    public void Start()
    {
        settingsPopup.Close();
    }

    void Update()
    {
        scoreLabel.text = Time.realtimeSinceStartup.ToString();
    }

    public void OnPointerDown()
    {
        Debug.Log("pointer down");
    }

    public void OnOpenSettings()
    {
        settingsPopup.Open();
    }
}
