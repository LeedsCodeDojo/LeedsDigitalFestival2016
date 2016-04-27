Problem: Identity Matching
==========================

### Overview

Companies such as Callcredit process a lot of data about people, and one of the main challenges is working out what person a given record represents.

Without a unique identifier, this comes down to comparing various fields of the record against properties of known individuals.  However, when data comes in a variety of formats, with mistakes and missing values, this is not always straightforward.  For example, it's difficult to tell which of these represent the same person:

| Title | Name 1  | Name 2 | Name 3 | DOB | Address 1 | Address 2 | Address 3 | 
| --- | --- | --- | --- | --- | --- | --- | --- |
| Miss | Jane | H | Doe | 01/01/1980 | 10 Main Street | Leeds | W YORKS | 
| Ms | J |  | Doe | 01/01/1950 | 10 Main Street | Horsforth | Leeds | 
|  | Jane |  | Do |  | 10 Man Street | Leeds | W YORKS | 
| Mrs | Jayne | H | Dow | 01/01/1980 | 18 Main Street | H'fth | yorks | 
| Miss | Jane | H | Doe |  | 10 Main Street | Leeds | W YORKS | 

When you consider the not uncommon situations of twins with similar names, or parent and child with the same name, living at the same address, you can see the complexities.

### String Comparison

Solving the whole problem involves many different techniques, and can be adjusted depending on how important it is to avoid under or over-matching.  There is no right answer as to whether two records represent the same person or not.

One sub-problem, which is better defined and has a definite answer, is determining how similar two strings of characters are:

    distance("schmit", "smithe") = ?

There are several well-known ways of comparing strings, such as using Levenshtein distance or Hamming distance, but the important things is that once you have a measurement you can use that as part of your overall strategy.

### Tonight's Problem

Write an algorithm that can take two strings and give a value representing their similarity.  You can try and implement one of the algorithms described in the other document (Levenshtein distance or Hamming distance), or make up your own.

Test it to see if it gives results that match your intuition about how similar some names are.
