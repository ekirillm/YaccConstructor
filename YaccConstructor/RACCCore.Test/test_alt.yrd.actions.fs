//this file was generated by RACC
//source grammar:..\Tests\RACC\test_alt\test_alt.yrd
//date:3/25/2011 13:24:24

module RACC.Actions_Alt

open Yard.Generators.RACCGenerator

let getUnmatched x expectedType =
    "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\n" + expectedType + " was expected." |> failwith

let value x = x.value

let s0 expr = 
    let inner  = 
        match expr with
        | REAlt(Some(x), None) -> 
            let yardLAltAction expr = 
                match expr with
                | RESeq [x0] -> 
                    let (p) =
                        let yardElemAction expr = 
                            match expr with
                            | RELeaf tPLUS -> tPLUS :?> 'a
                            | x -> getUnmatched x "RELeaf"

                        yardElemAction(x0)
                    ("Detected: " + (value p))
                | x -> getUnmatched x "RESeq"

            yardLAltAction x 
        | REAlt(None, Some(x)) -> 
            let yardRAltAction expr = 
                match expr with
                | RESeq [x0] -> 
                    let (m) =
                        let yardElemAction expr = 
                            match expr with
                            | RELeaf tMULT -> tMULT :?> 'a
                            | x -> getUnmatched x "RELeaf"

                        yardElemAction(x0)
                    ("Detected: " + (value m))
                | x -> getUnmatched x "RESeq"

            yardRAltAction x 
        | x -> getUnmatched x "REAlt"
    box (inner)

let ruleToAction = dict [|(1,s0)|]

