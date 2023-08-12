using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class ToNextScene : MonoBehaviour
{
    public Button easyBtn;
    public Button normalBtn;
    public Button hardBtn;

    // Start is called before the first frame update
    void Start()
    {
        
        easyBtn.onClick.AddListener(() => buttonCallBack(easyBtn));
        normalBtn.onClick.AddListener(() => buttonCallBack(normalBtn));
        hardBtn.onClick.AddListener(() => buttonCallBack(hardBtn));

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void buttonCallBack(Button btn)
    {
        if(btn == easyBtn)
        {
            Debug.Log("easy");
            //EasyScene
            SceneManager.LoadScene("EasyScene");
        }
        else if(btn == normalBtn)
        {
            Debug.Log("normal");
            //NormalScene
            SceneManager.LoadScene("MediumScene");
        }
        else if(btn == hardBtn)
        {
            Debug.Log("hard");
            //HardScene
            SceneManager.LoadScene("HardScene");
        }
        

    }
}
