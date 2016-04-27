
let hammingDistance string1 string2 = 
    Seq.zip string1 string2
    |> Seq.filter (fun (char1, char2) -> not (char1 = char2))
    |> Seq.length

match hammingDistance "abc123" "abc123" with
    | 0 -> "Same strings PASSED"
    | _ -> "Same strings FAILED"

match hammingDistance "abc1234" "xbx1x3x" with
    | 4 -> "Different strings PASSED"
    | _ -> "Different strings FAILED"