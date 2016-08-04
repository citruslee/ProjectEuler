(*
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.
*)
let ispalindrome str = 
    let str = str |> string |> Seq.filter ((<>) ' ') |> Seq.toList
    str = (str |> List.rev)


let numbers = seq {
    for x in 100 .. 999 - 1 do
        for y in 100 .. 999 - 1 do
            if ispalindrome (x*y) then
                yield (x*y)
                  } |> Seq.max |> printfn "%A"
