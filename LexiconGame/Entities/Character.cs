﻿using LexiconGame.Entities;
using LexiconGame.LinitedList;

internal class Character : Creature
{
    public LimitedList<Item> BackPack { get; set; }
    public Character(Cell cell) : base(cell, "H ")
    {
        Color = ConsoleColor.White;
        BackPack = new LimitedList<Item>(3);
    }
}