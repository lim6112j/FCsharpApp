namespace fsharpapp

module Say =
    let hello name =
        printfn "Hello %s" name
module MyTypes =
  type MyOption<'a> =
    | MySome of 'a
    | MyNone
  let value1 = MySome 1
module Example =
    let withYieldBang =
        seq {
            for i in 0..10..100 do
                yield! seq { i..1 .. i + 9 }
        }
  
    let withYield =
        seq {
            for i in 0..10..100 do
                yield seq { i..1 .. i + 9 }
        }
