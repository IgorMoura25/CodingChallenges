using CodingChallenges.Arrays;
using CodingChallenges.Trees.BinarySearchTree;
using System.Collections;

HashTableChallenges.CallReturnFirstRecurringNumber();

ArrayChallenges.CallMergeSortedArrays();
ArrayChallenges.CallHigherSumOfHourGlasses();
ArrayChallenges.CallDiagonalDifference();
ArrayChallenges.Staircase(6);
ArrayChallenges.CallMiniMaxSum();
ArrayChallenges.CallBirthdayCakeCandles();

var tree = new BinarySearchTree();
var lookup1 = tree.Lookup(9);

tree.Insert(9);
tree.Insert(4);
tree.Insert(6);
tree.Insert(20);
tree.Insert(170);
tree.Insert(15);
tree.Insert(1);

var lookup2 = tree.Lookup(9);
var lookup3 = tree.Lookup(170);
var lookup4 = tree.Lookup(50);

Console.ReadKey();