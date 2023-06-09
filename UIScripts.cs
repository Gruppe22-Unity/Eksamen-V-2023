using UnityEngine;
using UnityEngine.UI;

public class UIScripts : MonoBehaviour
{
    public Text gameHealthText;
    public Text levelNumberText;
    public Text scoreText;

    public void UpdateGameHealthUI(int health)
    {
        gameHealthText.text = "Game Health: " + health.ToString();
    }

    public void UpdateLevelNumberUI(int level)
    {
        levelNumberText.text = "Level: " + level.ToString();
    }

    public void UpdateScoreUI(int score)
    {
        scoreText.text = "Score: " + score.ToString();
    }
}