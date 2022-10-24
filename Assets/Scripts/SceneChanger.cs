using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Game{
public class SceneChanger : MonoBehaviour
{
	public void ChangeScene(string sceneName)
	{
		SceneManager.LoadScene ("Run");
		PlayerMovement.alive = true;

	}
	public void Exit()
	{
		Application.Quit ();
	}
}
}