(*
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
*)

let rec findfactors (n:bigint) x a = 
    if x = n then
        x::a
    elif n % x = 0I then 
        findfactors (n/x) x (x::a)
    else
        findfactors n (x+1I) a

let numberToFindFactors = 600851475143I

let factors = findfactors numberToFindFactors 2I [] |> List.max |> printfn "%A"

