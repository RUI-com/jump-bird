using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
   public int playerScore;
   public TextMesh scoreText;
   public GameObject gameOverScreen;

   
  


   [ContextMenu("Increase Score")]
   public void addScore(int scoreToAdd){
    playerScore = playerScore +scoreToAdd;
    scoreText.text = playerScore.ToString();
   }
 
//     public void restartGame()
// {
//     Debug.Log("Restarting game...");
//     string sceneName = SceneManager.GetActiveScene().name;
//     Debug.Log("Reloading scene: " + sceneName);
//     SceneManager.LoadScene(sceneName);
//     Debug.Log("Scene reloaded.");
// }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}