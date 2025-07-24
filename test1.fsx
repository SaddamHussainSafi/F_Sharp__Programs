// LabAssignment.fsx
open System

// Salaries list
let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

// Filter high-income salaries (above 100,000)
let highIncomeSalaries = List.filter (fun s -> s > 100000) salaries

// Function to calculate tax based on 2021 Federal Income Tax Brackets
let calculateTax salary =
    match salary with
    | s when s <= 49020 -> float s * 0.15
    | s when s <= 98040 -> float s * 0.205
    | s when s <= 151978 -> float s * 0.26
    | s when s <= 216511 -> float s * 0.29
    | _ -> float salary * 0.33

// Map function to calculate tax for all salaries
let taxes = List.map calculateTax salaries

// Filter salaries less than 49,020 and add 20,000 using map
let incrementedSalaries =
    salaries
    |> List.filter (fun s -> s < 49020)
    |> List.map (fun s -> s + 20000)

// Filter salaries between 50,000 and 100,000 and sum them using fold
let sumMidRangeSalaries =
    salaries
    |> List.filter (fun s -> s >= 50000 && s <= 100000)
    |> List.fold (+) 0

// Tail recursive function to sum multiples of 3 up to a given number (assumed multiple of 3)
let sumMultiplesOf3 n =
    let rec loop current acc =
        if current <= 0 then acc
        else loop (current - 3) (acc + current)
    loop n 0

// Test the tail recursive function with example 27
let testSum = sumMultiplesOf3 27

// Print results
printfn "Salaries: %A" salaries
printfn "High income salaries (>100,000): %A" highIncomeSalaries
printfn "Taxes for all salaries: %A" taxes
printfn "Salaries less than 49,020 incremented by 20,000: %A" incrementedSalaries
printfn "Sum of salaries between 50,000 and 100,000: %d" sumMidRangeSalaries
printfn "Sum of multiples of 3 up to 27: %d" testSum
