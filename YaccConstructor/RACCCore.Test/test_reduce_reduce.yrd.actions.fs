//this file was generated by RACC
//source grammar:..\Tests\RACC\test_reduce_reduce\test_reduce_reduce.yrd
//date:3/25/2011 13:24:34

module RACC.Actions_Rdc_Rdc

open Yard.Generators.RACCGenerator

let getUnmatched x expectedType =
    "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\n" + expectedType + " was expected." |> failwith
let s0 expr = 
    let inner  = 
        match expr with
        | RESeq [x0] -> 
            let (res:string) =
                let yardElemAction expr = 
                    match expr with
                    | REAlt(Some(x), None) -> 
                        let yardLAltAction expr = 
                            match expr with
                            | RESeq [x0] -> 
                                let (r) =
                                    let yardElemAction expr = 
                                        match expr with
                                        | RELeaf a -> (a :?> _ ) 
                                        | x -> getUnmatched x "RELeaf"

                                    yardElemAction(x0)
                                (r)
                            | x -> getUnmatched x "RESeq"

                        yardLAltAction x 
                    | REAlt(None, Some(x)) -> 
                        let yardRAltAction expr = 
                            match expr with
                            | RESeq [x0] -> 
                                let (r) =
                                    let yardElemAction expr = 
                                        match expr with
                                        | RELeaf b -> (b :?> _ ) 
                                        | x -> getUnmatched x "RELeaf"

                                    yardElemAction(x0)
                                (r)
                            | x -> getUnmatched x "RESeq"

                        yardRAltAction x 
                    | x -> getUnmatched x "REAlt"

                yardElemAction(x0)
            (res)
        | x -> getUnmatched x "RESeq"
    box (inner)
let a1 expr = 
    let inner  = 
        match expr with
        | RESeq [racc_x0; racc_x1; racc_x2] -> 
            let (racc_x0) =
                let yardElemAction expr = 
                    match expr with
                    | RELeaf tNUMBER -> tNUMBER :?> 'a
                    | x -> getUnmatched x "RELeaf"

                yardElemAction(racc_x0)
            let (racc_x1) =
                let yardElemAction expr = 
                    match expr with
                    | RELeaf tPLUS -> tPLUS :?> 'a
                    | x -> getUnmatched x "RELeaf"

                yardElemAction(racc_x1)
            let (racc_x2) =
                let yardElemAction expr = 
                    match expr with
                    | RELeaf tNUMBER -> tNUMBER :?> 'a
                    | x -> getUnmatched x "RELeaf"

                yardElemAction(racc_x2)
            ( "A" )
        | x -> getUnmatched x "RESeq"
    box (inner)
let b2 expr = 
    let inner  = 
        match expr with
        | RESeq [racc_x0; racc_x1; racc_x2] -> 
            let (racc_x0) =
                let yardElemAction expr = 
                    match expr with
                    | RELeaf tNUMBER -> tNUMBER :?> 'a
                    | x -> getUnmatched x "RELeaf"

                yardElemAction(racc_x0)
            let (racc_x1) =
                let yardElemAction expr = 
                    match expr with
                    | RELeaf tPLUS -> tPLUS :?> 'a
                    | x -> getUnmatched x "RELeaf"

                yardElemAction(racc_x1)
            let (racc_x2) =
                let yardElemAction expr = 
                    match expr with
                    | RELeaf tNUMBER -> tNUMBER :?> 'a
                    | x -> getUnmatched x "RELeaf"

                yardElemAction(racc_x2)
            ( "B" )
        | x -> getUnmatched x "RESeq"
    box (inner)

let ruleToAction = dict [|(3,b2); (2,a1); (1,s0)|]

