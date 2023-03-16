namespace fsharpapp

module Say =
    let hello name =
        printfn "Hello %s" name
module types =
  type MyOption<'a> =
    | Some
    | None
