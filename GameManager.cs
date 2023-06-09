using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UIScripts uiScripts;

    private int gameHealth;
    private int levelNumber;
    private int score;

    private void Start()
    {
        InitializeGame();
    }

    private void InitializeGame()
    {
        // Sett opp startverdier for game health, levelnummer og score
        gameHealth = 3;
        levelNumber = 1;
        score = 0;

        // Oppdater UI
        uiScripts.UpdateGameHealthUI(gameHealth);
        uiScripts.UpdateLevelNumberUI(levelNumber);
        uiScripts.UpdateScoreUI(score);
    }
    public void IncreaseLevelNumber()
    {
        levelNumber++;

        // Oppdater UI
        uiScripts.UpdateLevelNumberUI(levelNumber);
    }

    public void IncreaseScore(int amount)
    {
        score += amount;

        // Oppdater UI
        uiScripts.UpdateScoreUI(score);
    }
    public void DecreaseGameHealth(int amount)
    {
        gameHealth -= amount;

        // Oppdater UI
        uiScripts.UpdateGameHealthUI(gameHealth);

        if (gameHealth <= 0)
        {
            // Spilleren har mistet all helse, håndter spillerens død her
            GameOver();
        }
    }

    private void GameOver()
    {
        Debug.Log(" Game Over 🙁 ");
    }
}