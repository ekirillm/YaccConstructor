//this file was generated by GNESCC
//source grammar:../../../Tests/GNESCC/test_4/test_4.yrd
//date:10/24/2011 11:49:21

module GNESCC.Actions_test_4

open Yard.Generators.GNESCCGenerator

let getUnmatched x expectedType =
    "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\n" + expectedType + " was expected." |> failwith
let s0 expr = 
    let inner  = 
        match expr with
        | RESeq [gnescc_x0] -> 
            let (gnescc_x0) =
                let yardElemAction expr = 
                    match expr with
                    | REClosure(lst) -> 
                        let yardClsAction expr = 
                            match expr with
                            | RELeaf e -> (e :?> _ ) 
                            | x -> getUnmatched x "RELeaf"

                        List.map yardClsAction lst 
                    | x -> getUnmatched x "REClosure"

                yardElemAction(gnescc_x0)
            (gnescc_x0 )
        | x -> getUnmatched x "RESeq"
    box (inner)
let e1 expr = 
    let inner  = 
        match expr with
        | RESeq [gnescc_x0] -> 
            let (gnescc_x0) =
                let yardElemAction expr = 
                    match expr with
                    | RELeaf m -> (m :?> _ ) 
                    | x -> getUnmatched x "RELeaf"

                yardElemAction(gnescc_x0)
            (gnescc_x0 )
        | x -> getUnmatched x "RESeq"
    box (inner)
let m2 expr = 
    let inner  = 
        match expr with
        | RESeq [gnescc_x0] -> 
            let (gnescc_x0) =
                let yardElemAction expr = 
                    match expr with
                    | RELeaf tMULT -> tMULT :?> 'a
                    | x -> getUnmatched x "RELeaf"

                yardElemAction(gnescc_x0)
            (gnescc_x0 )
        | x -> getUnmatched x "RESeq"
    box (inner)

let ruleToAction = dict [|(3,m2); (2,e1); (1,s0)|]
