namespace fsharpapp

module Say =
    let hello name =
        printfn "Hello %s" name
module MyTypes =
  type MyOption<'a> =
    | MySome of 'a
    | MyNone
  let value1 = MySome 1