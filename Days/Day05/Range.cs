﻿namespace AdventOfCode2023
{
    internal record Range(long Start, long Length, Range? Parent, long Shift)
    { 
        public long End => Start + Length;
    }
}
