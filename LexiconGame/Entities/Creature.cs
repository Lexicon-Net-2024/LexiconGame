﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGame.Entities
{
    internal class Creature : IDrawable
    {
        private Cell cell;
        public Cell Cell 
        {
            get => cell;
         
            [MemberNotNull(nameof(cell))]
            set
            {
                ArgumentNullException.ThrowIfNull(value, nameof(cell));
                cell = value;
            } 
        }
        public string Symbol { get; }
        public ConsoleColor Color { get; protected set; } = ConsoleColor.Green;

        public Creature(Cell cell, string symbol)
        {
            if (string.IsNullOrWhiteSpace(symbol))
            {
                throw new ArgumentException($"'{nameof(symbol)}' cannot be null or whitespace.", nameof(symbol));
            }

            Cell = cell;
            Symbol = symbol;
        }

    }
}
