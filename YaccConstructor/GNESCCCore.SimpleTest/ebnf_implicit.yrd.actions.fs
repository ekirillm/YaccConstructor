//this file was generated by GNESCC
//source grammar:ebnf_implicit.yrd
//date:16.12.2011 11:39:54

module GNESCC.Actions_ebnf_implicit

open Yard.Generators.GNESCCGenerator

let getUnmatched x expectedType =
    "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\n" + expectedType + " was expected." |> failwith
let s0 expr = 
    let inner  = 
        match expr with
        | REAlt(Some(x), None) -> 
            let yardLAltAction expr = 
                match expr with
                | RESeq [gnescc_x0] -> 
                    let (gnescc_x0) =
                        let yardElemAction expr = 
                            match expr with
                            | RELeaf b -> (b :?> _ ) 
                            | x -> getUnmatched x "RELeaf"

                        yardElemAction(gnescc_x0)
                    (gnescc_x0 )
                | x -> getUnmatched x "RESeq"

            yardLAltAction x 
        | REAlt(None, Some(x)) -> 
            let yardRAltAction expr = 
                match expr with
                | RESeq [gnescc_x0] -> 
                    let (gnescc_x0) =
                        let yardElemAction expr = 
                            match expr with
                            | RELeaf tA -> tA :?> 'a
                            | x -> getUnmatched x "RELeaf"

                        yardElemAction(gnescc_x0)
                    (gnescc_x0 )
                | x -> getUnmatched x "RESeq"

            yardRAltAction x 
        | x -> getUnmatched x "REAlt"
    box (inner)
let b1 expr = 
    let inner  = 
        match expr with
        | RESeq [gnescc_x0] -> 
            let (gnescc_x0) =
                let yardElemAction expr = 
                    match expr with
                    | REClosure(lst) -> 
                        let yardClsAction expr = 
                            match expr with
                            | RELeaf s -> (s :?> _ ) 
                            | x -> getUnmatched x "RELeaf"

                        List.map yardClsAction lst 
                    | x -> getUnmatched x "REClosure"

                yardElemAction(gnescc_x0)
            (gnescc_x0 )
        | x -> getUnmatched x "RESeq"
    box (inner)

let ruleToAction = dict [|(2,b1); (1,s0)|]
