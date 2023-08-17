using Core.Exceptions;
using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{

        public class GameService : IService
        {
            public int GetLastPlayer(Player player)
            {
                if (player.PlayerNumber <= 0)
                {
                    throw new CException("Number of Players must be greater than 0.");
                }

                return PlayGame(player); // 
            }

            public int PlayGame(Player player)
            {
                int temp = 0; //temp
                int lastplayer; //sonuc değeri
                int[] array = new int[player.PlayerNumber];
            
            for (int i = 0; i < player.PlayerNumber; i++)
                array[i] = i + 1;

            while (array.Length != 1)
            {
                int nextPlayerIndex = (temp + 1) % array.Length;
                int[] newArray = new int[array.Length - 1];
                int newArrayIndex = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (i != nextPlayerIndex)
                    {
                        newArray[newArrayIndex] = array[i];
                        newArrayIndex++;
                    }
                }

                array = newArray;
                if (temp + 2 > array.Length)
                {
                    temp = 0;
                }
                else
                {
                    temp += 1;
                }
            }
            lastplayer = array[0];
            return lastplayer;
            }
    }
}

