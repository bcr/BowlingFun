# Bowling [![Build Status](https://travis-ci.org/bcr/BowlingFun.svg?branch=master)](https://travis-ci.org/bcr/BowlingFun)

## Problem Statement

```text
Following is a take-home programming test.  This test is designed to
allow you to demonstrate your ability to design, implement, and test a
solution (not necessarily in that order).  You should plan to devote at
least one hour to this test, but may spend as much time as you like.

Assignment: Write a program to score a game of ten-pin (standard
American) bowling.  For general information and a description of the
game and scoring rules, see:

    http://en.wikipedia.org/wiki/Ten-pin_bowling

Your program should accept as input a series of throws (integers
representing the number of pins knocked down on a throw).

At a minimum, your program should compute the score for an entire game.  
For extra credit, you may provide the ability to see the current score
at any point in a game, provide game scoring for each frame (indicating
spares and strikes), etc.

Your program should incorporate both unit tests (tests of individial
classes/methods) and functional tests (given a series of throws
comprising a game, produce the correct game score).  If you implement
any extra credit, that must covered by tests as well.

Please submit all work product (including code, test code, any design
assumptions, notes, or anything else that you feel would be helpful in
evaluating the solution).  Make sure to indicate how much time you spent
on this task.
```

## Notes

I am scoring according to the [Traditional scoring](https://en.wikipedia.org/wiki/Ten-pin_bowling#Traditional_scoring) section of the Wikipedia article.

## Original Commands

These are the original commands I used to create my projects. Just informational.

```bash
dotnet new console -o Bcr.Bowling
dotnet new mstest -o Bcr.Bowling.Test

Bcr.Bowling.Test$ dotnet add reference ../Bcr.Bowling
```
