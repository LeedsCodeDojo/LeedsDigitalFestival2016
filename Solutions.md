Solutions
=========

#### Hamming distance

Hamming distance, introduced by Richard Hamming in a 1950 paper *Error detecting and error correcting codes*, is a simple method which only works on strings of the same length.  It simply measures how many characters don't match in two strings:

|  | char 1 | char 2 | char 3 | char 4 | char 5 | char 6 | char 7 |
| --- | --- | --- | --- | --- | --- | --- | --- |
| **String 1** | K | i | t | t | e | n | s |
| **String 2** | S | i | t | t | i | n | g |
| **Different?** | 1 | 0 | 0 | 0 | 1 | 0 | 1 |

Hamming distance: 3

Another way to think of it is that the only operation that can be applied is substitution of one character for another.

##### Pseudocode

A procedural implementation:

    hammingDistance( string1, string2 )
      if string1 length <> string2 length, error
      distance = 0
      for each character in string1
        if string1[character] <> string2[character], increment distance
      return distance

#### Levenshtein distance

Levenshtein distance, also known as Edit distance, involves working out how many single-character 'edits' need to be applied to one string to transform it into the other.  It was described by Vladimir Levenshtein in 1965.

While more complicated to implement that Hamming distance, it can be used on different-length strings, and gives results much closer to what we would intuitively think of as correct.

In standard Levenshtein distance, the allowed operations are:
* Substitution
* Insertion
* Deletion

For example:

|  | char 1 | char 2 | char 3 | char 4 | char 5 | char 6 | char 7 |
| --- | --- | --- | --- | --- | --- | --- | --- |
| **String 1** | K | i | t | t | e | n | |
| Substitution | **S** | i | t | t | e | n | |
| Substitution | S | i | t | t | **i** | n | |
| Insertion | S | i | t | t | i | n | **g** |
| **String 2** | S | i | t | t | i | n | g |

Levenshtein distance: 3

##### Pseudocode

A recursive implementation could look like this:

    LevenshteinDistance(string1, s1_length, string2, s2_length)
      cost = 0

      if s1_length = 0, return s2_length
      if s2_length = 0, return s1_length

      if string1[s1_length - 1] = string2[s2_length - 2]
        cost = 0
      else
        cost = 1

      // return minimum of delete char string1, delete char from string2, and delete char from both
      return minimum(LevenshteinDistance(string1, s1_length - 1, string2, s2_length    ) + 1,
                     LevenshteinDistance(string1, s1_length    , string2, s2_length - 1) + 1,
                     LevenshteinDistance(string1, s1_length - 1, string2, s2_length - 1) + cost)

This is very inefficient as it calculates the distance of the same substring several times.
