using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ShowPopup : MonoBehaviour{
	[SerializeField] GameObject exitPanel;
	[SerializeField] GameObject panel;


	Scene m_Scene;
	string sceneName;
	private void Start()
	{
		m_Scene = SceneManager.GetActiveScene();
		sceneName = m_Scene.name;
	}


	void Update(){
		if (Input.GetKeyDown(KeyCode.Escape)){
			if (SceneManager.GetActiveScene().buildIndex != 0){
				SceneManager.LoadScene(0);
			}
			else{
				if (exitPanel){
					exitPanel.SetActive(true);
				}
			}
		}
	}

	public void onUserClickYesNo(int choice){//choice==0 no     choice==1 yes
		if (choice == 1){
			SceneManager.LoadScene("welcomeScene");
		}
        else
        {
			exitPanel.SetActive(false);//else
			panel.SetActive(true);
		}
		
	}


	//public Button tryAgainBtn;
	public void onUserClickStart(int choice)
	{
		if (choice == 1)
		{
			//Debug.Log("easy");
			//EasyScene
			if(sceneName== "EasyScene")
            {
				SceneManager.LoadScene("EasyScene");
			}
			else if (sceneName == "MediumScene")
			{
				//Debug.Log("normal");
				//NormalScene
				SceneManager.LoadScene("MediumScene");
			}
			else if (sceneName == "HardScene")
			{
				//Debug.Log("hard");
				//HardScene
				SceneManager.LoadScene("HardScene");
			}

		}
		
	
	}


	public Button exitBtn;
	public void onUserClickExit(Button btn)
	{
		if (btn == exitBtn)
		{
			Application.Quit();
		}

	}

}