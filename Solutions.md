Solutions
=========

Here are a couple of classic algorithms related to the problem.

### Hamming distance

Hamming distance, introduced by Richard Hamming in a 1950 paper *Error detecting and error correcting codes*, is a simple method which only works on strings of the same length.  It simply measures how many characters don't match in two given strings:

|  | char 1 | char 2 | char 3 | char 4 | char 5 | char 6 |
| --- | --- | --- | --- | --- | --- | --- |
| String 1 | S | m | y | t | h | e |
| String 1 | S | c | h | m | i | t |
| Different? | 0 | 1 | 1 | 1 | 1 | 1 |

Hamming distance: 5

##### Pseudocode

An iterative solution could be implemented like so:

    hammingDistance( string1, string2 )
      if string1 length <> string2 length, error
      distance = 0
      for each character in string1
        if string1[character] <> string2[character], increment distance
      return distance

### Levenshtein distance

Description, pseudocode



