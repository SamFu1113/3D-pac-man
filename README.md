# 3D-pac-man

## Outline
1. [Introduction](#Introduction)
2. [Gameplay](#Gameplay)
3. [Difficulty](#Difficulty)
4. [Map](#Map)
5. [Monster](#Monster)
6. [Demo](#Demo)

## Introduction
&nbsp;&nbsp;3D Pac-Man is a maze chasing game. Paying tribute to the classic game Pac-Man released in 1980, 3D Pac-Man uses three-dimensional scenes to provide a more detailed and three-dimensional gaming experience, taking players back to the excitement of the Pac-Man console in the 1980s.

## Gameplay
&nbsp;&nbsp;The elf (Pac-Man) is located in a maze. There are 42 beans in the maze. As long as you can eat all the beans, you will win. The starting life is 3. If it reaches 0, it will fail. Besides, there are 4 other monsters in the maze that will continue to look for the elves.<br />
&nbsp;&nbsp;There are 4 other monsters in the maze that will continue to look for the elves. If the elf encounters a monster, the encountered monster will return to its starting point. On the other hand, the elf returns to a random starting point and its Life is deducted by 1. There are two types of beans: big beans and small beans. If the player eats big beans, the monster will become smaller and the player's speed will become faster. After a while it returned to its original state.

```sh
Game rules: There are 42 Supply, 7 BigSupply, and 4 monsters. The 4 monsters will continue to look for the player. When the player eats BigSupply, the monsters will become smaller and the player's speed will become faster. After a period of time, they will return to their original state. Once the player eats 42 items of supply, the monsters will become smaller.
EASY: The player is the fastest and the 4 monsters are the smallest in size.
MEDIUM: 玩家速度中等，4隻怪物大小中等
HARD: 玩家速度最慢，4隻怪物大小最大
#Life有3條，假如剩0條，會跳出Try Again 或 Back to Menu
```
```sh
#假如玩家途中碰到怪獸 碰到的怪獸回其怪獸起點 玩家則回原點（有設定兩個原點，採隨機回到任一個）且玩家Life 扣1
一進入遊戲會數3 2 1 GO（含GO共4秒）
在這4秒內，玩家無法移動且4隻怪獸也不會動
4秒後兩者皆可移動
```

## Difficulty
* 在遊戲中共有三種難度
    * EASY：玩家速度最快，怪物類型為小怪獸
    * MEDIUM：玩家速度中等，怪物類型為中等怪獸
    * HARD：玩家速度最慢，怪物類型為大怪獸

## Map

## Monster

## Demo
