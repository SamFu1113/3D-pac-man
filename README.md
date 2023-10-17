# 3D-pac-man

## Outline
1. Introduction
2. Gameplay
3. Difficulty
4. Map
5. Monster
6. Demo

## Introduction
&nbsp;&nbsp;3D Pac-Man是一款迷宮追逐遊戲。致敬1980年發行的經典遊戲Pac-Man，3D Pac-Man使用了三維的場景，提供了更加細緻和立體的遊戲體驗，帶領玩家回到1980年代Pac-Man機台的感動。

## Gameplay
&nbsp;&nbsp;小精靈 (Pac-Man) 位於一迷宮，迷宮中共有42顆豆子，只要能將豆子全數吃掉即可獲得勝利。起始Life為3，如扣至0則失敗。 在迷宮中另有4隻怪獸，會持續地尋找小精靈。假如小精靈碰到怪獸，碰到的怪獸回其怪獸起點，小精靈則回到隨機任一原點且Life 扣1。豆子共分2種：大豆子和小豆子，玩家吃到大豆子則怪獸變小隻、玩家速度變快，一段時間後又恢復原樣。

```sh
遊戲規則: 有42顆Supply，7顆BigSupply, 4隻怪獸。 4隻怪獸會持續找尋玩家，玩家吃到BigSupply則怪獸變小隻、玩家速度變快，一段時間後又恢復原樣，要吃完42顆Supply即獲勝。
EASY: 玩家速度最快，4隻怪物大小最小
MEDIUM: 玩家速度中等，4隻怪物大小中等
HARD: 玩家速度最慢，4隻怪物大小最大
#Life有3條，假如剩0條，會跳出Try Again 或 Back to Menu

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