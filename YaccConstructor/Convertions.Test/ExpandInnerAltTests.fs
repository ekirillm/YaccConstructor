﻿//  ExpandInnerAltTests.fs contains unuit test for ExpandInnerAlt conversions
//
//  Copyright 2012 Semen Grigorev <rsdpisuy@gmail.com>
//
//  This file is part of YaccConctructor.
//
//  YaccConstructor is free software:you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.


module ExpandInnerAltTests

open Yard.Core
open Yard.Core.IL
open Yard.Core.IL.Production
open Yard.Core.IL.Definition
open Convertions.TransformAux
open NUnit.Framework
open ConvertionsTests

[<TestFixture>]
type ``Expand inner alts tests`` () =
    let basePath = System.IO.Path.Combine(convertionTestPath, "ExpandInnerAlt")
    let fe = getFrontend("YardFrontend")
    let conversion = "ExpandInnerAlt"
    [<Test>]
    member test.``Alt in seq 1`` () =
        Namer.resetRuleEnumerator()
        let loadIL = fe.ParseGrammar (System.IO.Path.Combine(basePath,"altInSeq1.yrd"))
        let result = ConvertionsManager.ApplyConvertion conversion loadIL
        let expected = 
            {
                info = {fileName = ""}
                head = None
                grammar =
                     [{
                            name = Source.t("s")
                            args = []
                            body =
                        
                                PSeq([                                        
                                        {dummyRule with rule = PRef (Source.t("x"),None)}
                                        ;{dummyRule with rule = PRef (Source.t("yard_exp_brackets_1"),None)}],None, None)                        
                            _public = true
                            metaArgs = []
                         };
                         {
                            name = Source.t("yard_exp_brackets_1")
                            args = []
                            body =
                             PAlt
                               (PSeq ([{dummyRule with rule = PRef (Source.t("y"),None)}],None,None),
                                PSeq ([{dummyRule with rule = PRef (Source.t("z"),None)}],None,None));
                            _public = false
                            metaArgs = []}]
                foot = None
                options = Map.empty
            }

        expected |> treeDump.Generate |> string |> printfn "%s"
        printfn "%s" "************************"
        result |> treeDump.Generate |> string |> printfn "%s"
        Assert.IsTrue(ILComparators.GrammarEqualsWithoutLineNumbers expected.grammar result.grammar)


    [<Test>]
    member test.``Alt in seq 2`` () =
        Namer.resetRuleEnumerator()
        let loadIL = fe.ParseGrammar (System.IO.Path.Combine(basePath,"altInSeq2.yrd"))
        let result = ConvertionsManager.ApplyConvertion conversion loadIL
        let expected = 
             {
                info = {fileName = ""}
                head = None
                grammar =
                     [{
                            name = Source.t("s")
                            args = []
                            body =
                                PSeq([                                        
                                        {dummyRule with rule = PRef (Source.t "x",None)}
                                        ;{dummyRule with rule = PRef (Source.t "yard_exp_brackets_1", None)}
                                        ;{dummyRule with rule = PRef (Source.t "m", None)}],None, None)
                            _public = true
                            metaArgs = []
                         };
                         {
                            name = Source.t("yard_exp_brackets_1")
                            args = []
                            body =
                             PAlt
                               (PSeq ([{dummyRule with rule = PRef (Source.t "y", None)}],None,None),
                                PSeq ([{dummyRule with rule = PRef (Source.t "z", None)}],None,None));
                            _public = false
                            metaArgs = []}]
                foot = None
                options = Map.empty
            }

        expected |> treeDump.Generate |> string |> printfn "%s"
        printfn "%s" "************************"
        result |> treeDump.Generate |> string |> printfn "%s"
        Assert.IsTrue(ILComparators.GrammarEqualsWithoutLineNumbers expected.grammar result.grammar)

    [<Test>]
    member test.``Alts in seq`` () =
        Namer.resetRuleEnumerator()
        let loadIL = fe.ParseGrammar (System.IO.Path.Combine(basePath,"altsInSeq.yrd"))
        let result = ConvertionsManager.ApplyConvertion conversion loadIL
        let expected = 
             {
                info = {fileName = ""}
                head = None
                grammar =
                     [{
                            name = Source.t("s")
                            args = []
                            body =
                                PSeq([                                        
                                        {dummyRule with rule = PRef (Source.t "x", None)}
                                        ;{dummyRule with rule = PRef (Source.t "yard_exp_brackets_1", None)}
                                        ;{dummyRule with rule = PRef (Source.t "yard_exp_brackets_2", None)}],None, None)                        
                            _public = true
                            metaArgs = []
                         };
                         {
                            name = Source.t("yard_exp_brackets_1")
                            args = []
                            body =
                             PAlt
                               (PSeq ([{dummyRule with rule = PRef (Source.t "y", None)}],None,None),
                                PSeq ([{dummyRule with rule = PRef (Source.t "z", None)}],None,None));
                            _public = false
                            metaArgs = []
                         };
                         {
                            name = Source.t("yard_exp_brackets_2")
                            args = []
                            body =
                             PAlt
                               (PSeq ([{dummyRule with rule = PRef (Source.t "m", None)}],None,None),
                                PSeq ([{dummyRule with rule = PRef (Source.t "n", None)}],None,None));
                            _public = false
                            metaArgs = []}]
                foot = None
                options = Map.empty
            }

        expected |> treeDump.Generate |> string |> printfn "%s"
        printfn "%s" "************************"
        result |> treeDump.Generate |> string |> printfn "%s"
        Assert.IsTrue(ILComparators.GrammarEqualsWithoutLineNumbers expected.grammar result.grammar)

    [<Test>]
    member test.``Nested alts`` () =
        Namer.resetRuleEnumerator()
        let loadIL = fe.ParseGrammar (System.IO.Path.Combine(basePath,"nestedAlts.yrd"))
        let result = ConvertionsManager.ApplyConvertion conversion loadIL
        let expected = 
             {
                info = {fileName = ""}
                head = None
                grammar =
                     [{
                            name = Source.t("s")
                            args = []
                            body = PSeq([{dummyRule with rule = PRef (Source.t "yard_exp_brackets_1", None)}],None, None)
                            _public = true
                            metaArgs = []
                         };
                         {
                            name = Source.t("yard_exp_brackets_1")
                            args = []
                            body =
                             PAlt
                               (PSeq ([{dummyRule with rule = PRef (Source.t "y", None)}],None,None),
                                PSeq ([{dummyRule with rule = PRef (Source.t "yard_exp_brackets_2", None)}],None,None));
                            _public = false
                            metaArgs = []
                         };
                          {
                            name = Source.t("yard_exp_brackets_2")
                            args = []
                            body =
                             PAlt
                               (PSeq ([{dummyRule with rule = PRef (Source.t "m", None)}],None,None),
                                PSeq ([{dummyRule with rule = PRef (Source.t "n",None)}],None,None));
                            _public = false
                            metaArgs = []}]
                foot = None
                options = Map.empty
            }

        expected |> treeDump.Generate |> string |> printfn "%s"
        printfn "%s" "************************"
        result |> treeDump.Generate |> string |> printfn "%s"
        Assert.IsTrue(ILComparators.GrammarEqualsWithoutLineNumbers expected.grammar result.grammar)

