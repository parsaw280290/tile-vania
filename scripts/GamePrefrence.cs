using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GamePrefrence
{
    public static string SECOND_CHAPTER_UNLOCKED = "SECOND_CHAPTER_UNLOCKED";
    public static string THIRD_CHAPTER_UNLOCKED = "THIRD_CHAPTER_UNLOCKED";
    public static string FOURTH_CHAPTER_UNLOCKED = "FOURTH_CHAPTER_UNLOCKED";
    public static string LAST_CHAPTER_UNLOCKED = "LAST_CHAPTER_UNLOCKED";
    public static string FIRST_DEATH = "FIRST_DEATH";
    public static string FIRST_COIN = "FIRST_COIN";
    public static string SECOND_COIN = "SECOND_COIN";
    public static string THIRD_COIN = "THIRD_COIN";
    public static string FORTH_COIN = "FOURTH_COIN";
    public static string LAST_COIN = "LAST_COIN";


    public static int GetFirstDeath()
    {
        return PlayerPrefs.GetInt(GamePrefrence.FIRST_DEATH);
    }
    public static void SetFirstDeath(int unlocked)
    {
        PlayerPrefs.SetInt(GamePrefrence.FIRST_DEATH, unlocked);
    }
    public static int GetSecondChapter()
    {
        return PlayerPrefs.GetInt(GamePrefrence.SECOND_CHAPTER_UNLOCKED);
    }
    public static void SetSecondChapter(int unlocked)
    {
        PlayerPrefs.SetInt(GamePrefrence.SECOND_CHAPTER_UNLOCKED, unlocked);
    }
    public static int GetThirdChapter()
    {
        return PlayerPrefs.GetInt(GamePrefrence.THIRD_CHAPTER_UNLOCKED);
    }
    public static void SetThirdChapter(int unlocked)
    {
        PlayerPrefs.SetInt(GamePrefrence.THIRD_CHAPTER_UNLOCKED, unlocked);
    }
    public static int GetFourthChapter()
    {
        return PlayerPrefs.GetInt(GamePrefrence.FOURTH_CHAPTER_UNLOCKED);
    }
    public static void SetFourthChapter(int unlocked)
    {
        PlayerPrefs.SetInt(GamePrefrence.FOURTH_CHAPTER_UNLOCKED, unlocked);
    }
    public static int GetLastChapter()
    {
        return PlayerPrefs.GetInt(GamePrefrence.LAST_CHAPTER_UNLOCKED);
    }
    public static void SetLastChapter(int unlocked)
    {
        PlayerPrefs.SetInt(GamePrefrence.LAST_CHAPTER_UNLOCKED, unlocked);
    }
    public static int GetFirstCoin()
    {
        return PlayerPrefs.GetInt(FIRST_COIN);
    }
    public static void SetFirstCoin(int coin)
    {
        PlayerPrefs.SetInt(FIRST_COIN, coin);
    }
    public static int GetSecondCoin()
    {
        return PlayerPrefs.GetInt(SECOND_COIN);
    }
    public static void SetSecondCoin(int coin)
    {
        PlayerPrefs.SetInt(SECOND_COIN, coin);
    }
    public static int GetThirdCoin()
    {
        return PlayerPrefs.GetInt(THIRD_COIN);
    }
    public static void SetThirdCoin(int coin)
    {
        PlayerPrefs.SetInt(THIRD_COIN, coin);
    }
    public static int GetFourthCoin()
    {
        return PlayerPrefs.GetInt(FORTH_COIN);
    }
    public static void SetFourthCoin(int coin)
    {
        PlayerPrefs.SetInt(FORTH_COIN, coin);
    }
    public static int GetLastCoin()
    {
        return PlayerPrefs.GetInt(LAST_COIN);
    }
    public static void SetLastCoin(int coin)
    {
        PlayerPrefs.SetInt(LAST_COIN, coin);
    }
}
