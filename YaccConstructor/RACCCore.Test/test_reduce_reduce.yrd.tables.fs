//this tables was generated by RACC
//source grammar:..\Tests\RACC\test_reduce_reduce\test_reduce_reduce.yrd
//date:3/25/2011 13:24:34

#light "off"
module Yard.Generators.RACCGenerator.Tables_Rdc_Rdc

open Yard.Generators.RACCGenerator

type symbol =
    | T_PLUS
    | T_NUMBER
    | NT_b
    | NT_a
    | NT_s
    | NT_raccStart
let getTag smb =
    match smb with
    | T_PLUS -> 5
    | T_NUMBER -> 4
    | NT_b -> 3
    | NT_a -> 2
    | NT_s -> 1
    | NT_raccStart -> 0
let getName tag =
    match tag with
    | 5 -> T_PLUS
    | 4 -> T_NUMBER
    | 3 -> NT_b
    | 2 -> NT_a
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
   DIDToStateMap = dict [|(0,(State 0));(1,(State 1));(2,(State 2));(3,DummyState);(4,DummyState)|];
   DStartState   = 0;
   DFinaleStates = Set.ofArray [|1;2|];
   DRules        = Set.ofArray [|{ 
   FromStateID = 0;
   Symbol      = (DSymbol 2);
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSeqS 7));(FATrace (TAlt1S 5));(FATrace (TSeqS 2));(FATrace (TSmbS 1))|]
;List.ofArray [|(FATrace (TSeqS 7));(FATrace (TAlt2S 6));(FATrace (TSeqS 4));(FATrace (TSmbS 3))|]
|];
   ToStateID   = 1;
}
;{ 
   FromStateID = 0;
   Symbol      = (DSymbol 3);
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSeqS 7));(FATrace (TAlt1S 5));(FATrace (TSeqS 2));(FATrace (TSmbS 1))|]
;List.ofArray [|(FATrace (TSeqS 7));(FATrace (TAlt2S 6));(FATrace (TSeqS 4));(FATrace (TSmbS 3))|]
|];
   ToStateID   = 2;
}
;{ 
   FromStateID = 1;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 1));(FATrace (TSeqE 2));(FATrace (TAlt1E 5));(FATrace (TSeqE 7))|]
|];
   ToStateID   = 3;
}
;{ 
   FromStateID = 2;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 3));(FATrace (TSeqE 4));(FATrace (TAlt2E 6));(FATrace (TSeqE 7))|]
|];
   ToStateID   = 4;
}
|];
}
);(2,{ 
   DIDToStateMap = dict [|(0,(State 0));(1,(State 1));(2,(State 2));(3,(State 3));(4,DummyState)|];
   DStartState   = 0;
   DFinaleStates = Set.ofArray [|3|];
   DRules        = Set.ofArray [|{ 
   FromStateID = 0;
   Symbol      = (DSymbol 4);
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSeqS 11));(FATrace (TSmbS 8))|]
|];
   ToStateID   = 1;
}
;{ 
   FromStateID = 1;
   Symbol      = (DSymbol 5);
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 8));(FATrace (TSmbS 9))|]
|];
   ToStateID   = 2;
}
;{ 
   FromStateID = 2;
   Symbol      = (DSymbol 4);
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 9));(FATrace (TSmbS 10))|]
|];
   ToStateID   = 3;
}
;{ 
   FromStateID = 3;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 10));(FATrace (TSeqE 11))|]
|];
   ToStateID   = 4;
}
|];
}
);(3,{ 
   DIDToStateMap = dict [|(0,(State 0));(1,(State 1));(2,(State 2));(3,(State 3));(4,DummyState)|];
   DStartState   = 0;
   DFinaleStates = Set.ofArray [|3|];
   DRules        = Set.ofArray [|{ 
   FromStateID = 0;
   Symbol      = (DSymbol 4);
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSeqS 15));(FATrace (TSmbS 12))|]
|];
   ToStateID   = 1;
}
;{ 
   FromStateID = 1;
   Symbol      = (DSymbol 5);
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 12));(FATrace (TSmbS 13))|]
|];
   ToStateID   = 2;
}
;{ 
   FromStateID = 2;
   Symbol      = (DSymbol 4);
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 13));(FATrace (TSmbS 14))|]
|];
   ToStateID   = 3;
}
;{ 
   FromStateID = 3;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 14));(FATrace (TSeqE 15))|]
|];
   ToStateID   = 4;
}
|];
}
)|]

let private gotoSet = 
    Set.ofArray [|((0, 0, 1), set [(0, 1)]);((0, 0, 2), set [(1, 1)]);((0, 0, 3), set [(1, 2)]);((0, 0, 4), set [(2, 1); (3, 1)]);((1, 0, 2), set [(1, 1)]);((1, 0, 3), set [(1, 2)]);((1, 0, 4), set [(2, 1); (3, 1)]);((2, 0, 4), set [(2, 1)]);((2, 1, 5), set [(2, 2)]);((2, 2, 4), set [(2, 3)]);((3, 0, 4), set [(3, 1)]);((3, 1, 5), set [(3, 2)]);((3, 2, 4), set [(3, 3)])|]
    |> dict
let tables = { gotoSet = gotoSet; automataDict = autumataDict }

