// Pattern Matching test functions
namespace Patterns

module PatternMatching =

    let BasicTypeMatch (s:obj) =
        match s with
        | :? int as x when true -> 2
        | _ -> 0