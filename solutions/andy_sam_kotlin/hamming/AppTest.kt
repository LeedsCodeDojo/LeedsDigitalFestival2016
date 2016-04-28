package hamming

import org.junit.Assert.assertEquals
import org.junit.Test

/**
 * Created by Andy on 27/04/2016.
 */
class AppTest {

    @Test fun testHamming() {
        val h = App()
        assertEquals (0 , h.hamming("smith", "smith"))
    }

    @Test fun testHamming2() {
        val h = App()
        assertEquals (1 , h.hamming("smith", "smyth"))
    }

    @Test fun testLevenshtein() {
        val h = App()
        assertEquals (1 , h.levenshtein("smith", "smyth"))
        assertEquals (3 , h.levenshtein("kittens", "sitting"))
        assertEquals (4 , h.levenshtein("attcgccaggt", "aatcgccgatggg"))
    }

}
