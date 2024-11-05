using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
   public string playerName;
   public int health;

   public static int playerCount = 0;

   public void InitializePlayer(string name, int initialhealth)
   {
      playerName = name;
      health = initialhealth;
      playerCount++;
   }

   public void Heal(int amount)
   {
      health += amount;
      Debug.Log(playerName + " healed by " + amount + "." + "current health : " + health);
   }

   public void Heal(bool fullRestore)
   {
      if (fullRestore)
      {
         health = 100; // Assume 100 is full health
         Debug.Log(playerName + "fully restored. Current health: " + health);
      }
   }

   public static void ShowPlayerCount()
   {
      Debug.Log("Total players created: " + playerCount);
   }
}
