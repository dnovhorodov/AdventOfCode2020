#load "..\shared.fs"
#load "puzzle.fs"

open AdventOfCode

let sample = DayOne.solveExample "day-01/example.txt"
let res = DayOne.sumUpTo2020 [1721;979;366;299;675;1456]