﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stealth
{
    public class Sprites
    {
        public sbyte[,] Texture;
        public Point Location;

        public Sprites() { }
    }

    public partial class Stealth
    {
        public enum SpriteList { apple, player, COUNT };
        public static sbyte[][,] Sprites = new sbyte[(int)SpriteList.COUNT][,]
        {
            new sbyte[WALL_HEIGHT, WALL_WIDTH]
            {
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-1,-1,-1,-1,-1,-1,-1,-1, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3,-3,-3,-3,-3,-3, },
                {-3,-3,-3, 3, 3,-3,-3,-3, },
                {-3,-3, 3,-3,-3, 3,-3,-3, },
                {-3, 3,-3,-3,-3,-3, 3,-3, },
                { 3,-3,-3,-3,-3,-3,-3, 3, },
                { 3,-3,-3,-3,-3,-3,-3, 3, },
                {-3, 3,-3,-3,-3,-3, 3,-3, },
                {-3,-3, 3,-3,-3, 3,-3,-3, },
                {-3,-3,-3, 3, 3,-3,-3,-3, },
            },
            new sbyte[WALL_HEIGHT, WALL_WIDTH]
            {
                {-1,-1,-1,-1,-1,-1,-1,-1, },
                {-1,-1,-1,-1,-1,-1,-1,-1, },
                {-1,-1,-1,-1,-1,-1,-1,-1, },
                {-1,-1,-1,-1,-1,-1,-1,-1, },
                {-1,-1,-1,-1,-1,-1,-1,-1, },
                {-1,-1,-1,-1,-1,-1,-1,-1, },
                {-1,-1,-1,-1,-1,-1,-1,-1, },
                {-1,-1,-1,-1,-1,-1,-1,-1, },
                {-1,-1,-1, 0, 0, 1,-1,-1, },
                {-1,-1, 0, 1, 1, 2, 1,-1, },
                {-1, 0, 1, 2, 2, 2, 2, 1, },
                {-1, 0, 1, 3, 0, 2, 3, 0, },
                {-1, 0, 1, 2, 2, 2, 2, 2, },
                { 0, 1, 1, 2, 1, 1, 2,-1, },
                { 1, 2, 1, 1, 2, 2, 1, 1, },
                { 1, 2, 2, 2, 1, 1, 1, 1, },
                { 1, 2, 2, 2, 3, 3, 1,-1, },
                { 1, 1, 1, 1, 2, 3, 1,-1, },
                { 1, 2, 2, 2, 1, 1, 1, 3, },
                { 0, 1, 1, 1, 2, 2, 1, 3, },
                { 0, 0, 0, 0, 1, 1, 1,-1, },
                { 1, 1, 1, 1, 0, 0, 0,-1, },
                { 1, 2, 2, 2, 1, 1, 1,-1, },
                { 1, 2, 2, 2, 2, 2, 1,-1, },
                { 1, 3, 2, 0, 2, 3, 1,-1, },
                { 1, 3, 2, 1, 2, 3, 1,-1, },
                { 1, 3, 2, 0, 2, 3, 1,-1, },
                { 1, 2, 2, 1, 1, 2, 1,-1, },
                { 1, 1, 2, 1, 2, 1, 1,-1, },
                { 1, 2, 1, 1, 2, 2, 3, 0, },
                { 1, 2, 2, 3, 0, 0, 0,-1, },
                {-1, 0, 0, 0,-1,-1,-1,-1, },
            }
        };
    }
}
