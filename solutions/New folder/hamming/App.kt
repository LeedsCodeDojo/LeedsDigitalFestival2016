package hamming

/**
 * Created by Sam & Andy on 27/04/2016.
 */
class App {

    fun hamming(arg1: String, arg2: String): Int {
        if (!arg1.length.equals(arg2.length) ) {
            return -1
        }
        return arg1.mapIndexed { i, c -> if (c == arg2.elementAt(i)) 0 else 1 }.sum()
    }

    fun hammingMark2(arg1: String, arg2: String): Int {
        return (1 .. arg1.length)
                    .filter({arg1[it] == arg2[it]})
                    .count()
    }

    fun charScore(char1 : Char, char2: Char): Int{
        return if (char1 == char2) 0 else 1
    }

    fun Int.min(y:Int): Int {return if (this > y) y else this}

    fun levenshtein(s: String, s1: String): Int? {
        var row = IntArray(s.length + 1, { x -> x }) // Top Row
        for (i in 1..s1.length) {
            var nextRow = IntArray(s.length + 1)  // Initialise Next Row
            nextRow[0] = row[0] + 1 // First element of new row = Move Down from previous row + 1
            for (j in 1..s.length) {
                val minValue = arrayOf(row[j] + 1,          // Move Down
                                     nextRow[j - 1] + 1,    // Move Right
                                     row[j - 1] + charScore(s[j - 1], s1[i - 1]))  // Diagonal
                                .reduce {x,y -> x.min(y)}   // Find minimum value of the 3 available moves
                nextRow[j] = minValue
            }
            row = nextRow
        }
        // Return last value from final row
        return row.reversed()[0]
    }
}