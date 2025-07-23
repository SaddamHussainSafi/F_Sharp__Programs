// Lab Assignment - F# Programming Tasks

// 1. Partial Application: Exponentiation function
let power exponent value = 
    pown value exponent

// Partial application for square and cube
let square = power 2
let cube = power 3

// Test partial application
printfn "Square of 4: %d" (square 4)
printfn "Cube of 2: %d" (cube 2)
printfn "Square of 5: %d" (square 5)
printfn "Cube of 3: %d" (cube 3)


// 2. Tail Recursion 1: Product of all elements in a list
let productList lst =
    let rec loop acc remaining =
        match remaining with
        | [] -> acc
        | x::xs -> loop (acc * x) xs
    loop 1 lst

// Test productList
let testList = [1; 2; 3; 4; 5]
printfn "Product of list elements: %d" (productList testList)


// 3. Tail Recursion 2: Product of all odd numbers from n down to 1 (n odd)
let productOdd n =
    let rec loop acc current =
        if current < 1 then acc
        else loop (acc * current) (current - 2)
    loop 1 n

// Test productOdd
printfn "Product of odd numbers from 11 to 1: %d" (productOdd 11)


// 4. Using Map Function with a Collection: Trim strings
let names : string list = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]
let trimmedNames = List.map (fun (s:string) -> s.Trim()) names

// Print trimmed names
printfn "Trimmed names:"
trimmedNames |> List.iter (printfn "%s")


// 5. Using Filter and Reduce with a Collection:
// Sequence of first 700 positive integers
let seq700 = seq {1 .. 700}
// Convert to list
let list700 = Seq.toList seq700
// Filter out elements that are multiples of both 7 and 5
let filtered = List.filter (fun x -> not (x % 35 = 0)) list700
// Sum all filtered numbers using fold
let sumFiltered = List.fold (+) 0 filtered

printfn "Sum of numbers from 1 to 700 excluding multiples of 35: %d" sumFiltered


// 6. Using Filter and Reduce with Collection of Strings:
let stringList : string list = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]
// Filter elements that have letter 'I' or 'i'
let filteredStrings = List.filter (fun (s:string) -> s.ToLower().Contains("i")) stringList
// Concatenate all filtered names using fold
let concatenated = List.fold (+) "" filteredStrings

printfn "Concatenated names with letter 'i': %s" concatenated
