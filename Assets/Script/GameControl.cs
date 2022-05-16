using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {
    public GameOverScript GameOverScreen;
    private int countVehicle = 0;
    private bool gameOver = false;
    public void GameOver() {
        Debug.Log("Game Over");
        GameOverScreen.Setup(countVehicle);
        gameOver = true;
    }

    public bool IsGameOver() {
        return gameOver;
    }
    public void AddCount(int num) {
        countVehicle += num;
    }
}
