Problem: Identity Matching
==========================

Companies such as Callcredit process a lot of data about people, and one of the main challenges is working out what person a given record represents.

Without a unique identifier, this comes down to comparing various fields of the record against properties of known individuals.  However, when data comes in a variety of formats, with mistakes and missing values, this is not always straightforward.  For example, it's difficult to tell which of these represent the same person:

| Title | Name 1  | Name 2 | Name 3 | DOB | Address 1 | Address 2 | Address 3 | 
| --- | --- | --- | --- | --- | --- | --- | --- |
| Miss | Jane | H | Doe | 01/01/1980 | 10 Main Street | Leeds | W YORKS | 
| Ms | J |  | Doe | 01/01/1980 | 10 Main Street | Horsforth | Leeds | 
|  | Jane |  | Do |  | 10 Man Street | Leeds | W YORKS | 
| Mrs | Jane | H | Doe | 01/01/1950 | 10 Main Street | Leeds | W YORKS | 
| Miss | Jane | H | Doe |  | 10 Main Street | Leeds | W YORKS | 
