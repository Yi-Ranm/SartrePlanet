﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Battle
{
    public class EnergyUI : MonoBehaviour
    {
        private BasePlayer player;
        public int ColorIndex;
        private float MaxEnergy;
        private Slider slider;
        void Awake()
        {
            player = BasePlayer.Player;
            slider = GetComponent<Slider>();
            MaxEnergy = player.MaxEnergy;
            player.WhenEnergyChange += SliderChange;
        }
        public void SliderChange(int color, float ChangeValue)
        {
            if (color == ColorIndex)
            {
                slider.value += ChangeValue / MaxEnergy;
            }
        }
        private void OnDisable()
        {
            player.WhenEnergyChange -= SliderChange;
        }
    }
}
