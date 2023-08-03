using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FailCanvas : MonoBehaviour
{
    public GameObject panel;
    public Button back2Menu;

    public GameObject exitPanel;

    // Start is called before the first frame update
    void Start()
    {

        back2Menu.onClick.AddListener(() => showExitPanel());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showExitPanel()
    {
        panel.SetActive(false);
        exitPanel.SetActive(true);
    }
}
