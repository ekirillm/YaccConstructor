//this tables was generated by RACC
//source grammar:..\Tests\RACC\test_l_attr\test_l_attr.yrd
//date:3/25/2011 13:24:29

#light "off"
module Yard.Generators.RACCGenerator.Tables_L_attr

open Yard.Generators.RACCGenerator

type symbol =
    | T_NUMBER
    | NT_e
    | NT_s
    | NT_raccStart
let getTag smb =
    match smb with
    | T_NUMBER -> 3
    | NT_e -> 2
    | NT_s -> 1
    | NT_raccStart -> 0
let getName tag =
    match tag with
    | 3 -> T_NUMBER
    | 2 -> NT_e
    | 1 -> NT_s
    | 0 -> NT_raccStart
let private autumataDict = 
dict [|(0,{ 
   DIDToStateMap = dict [|(0,(State 0));(1,(State 1));(2,DummyState)|];
   DStartState   = 0;
   DFinaleStates = Set.ofArray [|1|];
   DRules        = Set.ofArray [|{ 
   FromStateID = 0;
   Symbol      = (DSymbol 1);
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbS 0))|]
|];
   ToStateID   = 1;
}
;{ 
   FromStateID = 1;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 0))|]
|];
   ToStateID   = 2;
}
|];
}
);(1,{ 
   DIDToStateMap = dict [|(0,(State 0));(1,(State 1));(2,DummyState)|];
   DStartState   = 0;
   DFinaleStates = Set.ofArray [|1|];
   DRules        = Set.ofArray [|{ 
   FromStateID = 0;
   Symbol      = (DSymbol 2);
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSeqS 2));(FATrace (TSmbS 1))|]
|];
   ToStateID   = 1;
}
;{ 
   FromStateID = 1;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 1));(FATrace (TSeqE 2))|]
|];
   ToStateID   = 2;
}
|];
}
);(2,{ 
   DIDToStateMap = dict [|(0,(State 0));(1,(State 1));(2,DummyState)|];
   DStartState   = 0;
   DFinaleStates = Set.ofArray [|1|];
   DRules        = Set.ofArray [|{ 
   FromStateID = 0;
   Symbol      = (DSymbol 3);
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSeqS 4));(FATrace (TSmbS 3))|]
|];
   ToStateID   = 1;
}
;{ 
   FromStateID = 1;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 3));(FATrace (TSeqE 4))|]
|];
   ToStateID   = 2;
}
|];
}
)|]

let private gotoSet = 
    Set.ofArray [|((0, 0, 1), set [(0, 1)]);((0, 0, 2), set [(1, 1)]);((0, 0, 3), set [(2, 1)]);((1, 0, 2), set [(1, 1)]);((1, 0, 3), set [(2, 1)]);((2, 0, 3), set [(2, 1)])|]
    |> dict
let tables = { gotoSet = gotoSet; automataDict = autumataDict }

