/*
    Copyright 2016 Richard Bernardino

    Licensed under the Apache License, Version 2.0 (the "License");  
    you may not use this file except in compliance with the License.  
    You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0  

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
    See the License for the specific language governing permissions and  
    limitations under the License.  
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy
{
    public sealed class DefaultWorldBuilder
    {
        public IEnumerable<BuildCommand> Build()
        {
            LinkedList<BuildCommand> commands =
                new LinkedList<BuildCommand>();

            commands.AddLast(new DeclareWorldCommand("Default"));

            // Could specify color in the region then let
            //  individual subdivisions override, if need to.
            commands.AddLast(new DeclareLandCommand(0, 5, 5, 2, 2));

            commands.AddLast(new DeclareDungeonCommand(1, 5, 7, 2, 6));
            commands.AddLast(new DeclareDungeonCommand(2, 6, 7, 3, 4));
            commands.AddLast(new DeclareDungeonCommand(3, 7, 5, 3, 1));
            commands.AddLast(new DeclareDungeonCommand(4, 7, 7, 3, 3));
            commands.AddLast(new DeclareDungeonCommand(5, 9, 10, 5, 7));
            commands.AddLast(new DeclareDungeonCommand(6, 11, 7, 6, 2));
            commands.AddLast(new DeclareDungeonCommand(7, 9, 8, 4, 5));
            commands.AddLast(new DeclareDungeonCommand(8, 9, 8, 4, 5));




            BuildScreen0(commands);
            BuildScreen1(commands);
            BuildScreen2(commands);
            BuildScreen3(commands);
            BuildScreen4(commands);
            BuildScreen5(commands);
            BuildScreen6(commands);
            BuildScreen7(commands);
            BuildScreen8(commands);
            BuildScreen9(commands);
            BuildScreen10(commands);
            BuildScreen11(commands);
            BuildScreen12(commands);
            BuildScreen13(commands);
            BuildScreen14(commands);
            BuildScreen15(commands);
            BuildScreen16(commands);
            BuildScreen17(commands);
            BuildScreen18(commands);
            BuildScreen19(commands);
            BuildScreen20(commands);
            BuildScreen21(commands);
            BuildScreen22(commands);
            BuildScreen23(commands);
            BuildScreen24(commands);

            // Dungeon 1
            BuildScreen25(commands);
            BuildScreen26(commands);
            BuildScreen27(commands);
            BuildScreen28(commands);
            BuildScreen29(commands);
            BuildScreen30(commands);
            BuildScreen32(commands);
            BuildScreen33(commands);

            BuildScreen35(commands);
            BuildScreen39(commands);
            BuildScreen40(commands);

            BuildScreen43(commands);
            BuildScreen44(commands);
            BuildScreen45(commands);

            BuildScreen48(commands);
            BuildScreen53(commands);

            // Dungeon 2
            BuildScreen54(commands);
            BuildScreen55(commands);
            BuildScreen56(commands);
            BuildScreen58(commands);

            BuildScreen60(commands);
            BuildScreen62(commands);
            BuildScreen64(commands);

            BuildScreen66(commands);
            BuildScreen67(commands);
            BuildScreen68(commands);
            BuildScreen69(commands);
            BuildScreen70(commands);
            BuildScreen71(commands);

            BuildScreen74(commands);
            BuildScreen76(commands);

            BuildScreen79(commands);
            BuildScreen80(commands);
            BuildScreen81(commands);
            BuildScreen82(commands);

            BuildScreen88(commands);

            BuildScreen94(commands);


            // Dungeon 3
            BuildScreen101(commands);
            BuildScreen105(commands);

            BuildScreen107(commands);
            BuildScreen108(commands);
            BuildScreen109(commands);
            BuildScreen110(commands);
            BuildScreen111(commands);
            BuildScreen112(commands);
            BuildScreen113(commands);

            BuildScreen114(commands);
            BuildScreen116(commands);
            BuildScreen118(commands);
            BuildScreen120(commands);

            BuildScreen121(commands);
            BuildScreen122(commands);
            BuildScreen123(commands);
            BuildScreen124(commands);
            BuildScreen125(commands);
            BuildScreen126(commands);
            BuildScreen127(commands);

            BuildScreen129(commands);
            BuildScreen133(commands);

            // Dungeon 4
            BuildScreen140(commands);

            BuildScreen141(commands);
            BuildScreen142(commands);
            BuildScreen143(commands);

            BuildScreen144(commands);
            BuildScreen145(commands);
            BuildScreen146(commands);
            BuildScreen147(commands);
            BuildScreen148(commands);

            BuildScreen149(commands);
            BuildScreen150(commands);
            BuildScreen151(commands);
            BuildScreen152(commands);
            BuildScreen153(commands);
            BuildScreen154(commands);

            BuildScreen155(commands);
            BuildScreen156(commands);
            BuildScreen157(commands);
            BuildScreen158(commands);

            BuildScreen159(commands);
            BuildScreen160(commands);
            BuildScreen161(commands);
            BuildScreen162(commands);

            BuildScreen163(commands);
            BuildScreen164(commands);

            // Dungeon 5
            BuildScreen200(commands);

            BuildScreen201(commands);

            BuildScreen202(commands);
            BuildScreen203(commands);
            BuildScreen204(commands);
            BuildScreen205(commands);

            BuildScreen206(commands);
            BuildScreen207(commands);
            BuildScreen208(commands);
            BuildScreen209(commands);
            BuildScreen210(commands);
            BuildScreen211(commands);
            BuildScreen212(commands);

            BuildScreen213(commands);
            BuildScreen214(commands);
            BuildScreen215(commands);

            BuildScreen216(commands);
            BuildScreen217(commands);
            BuildScreen218(commands);
            BuildScreen219(commands);
            BuildScreen220(commands);
            BuildScreen221(commands);
            BuildScreen222(commands);

            BuildScreen223(commands);
            BuildScreen224(commands);

            BuildScreen225(commands);
            BuildScreen226(commands);

            BuildScreen227(commands);
            BuildScreen228(commands);

            BuildScreen229(commands);

            // Dungeon 6
            BuildScreen250(commands);
            BuildScreen251(commands);
            BuildScreen252(commands);
            BuildScreen253(commands);
            BuildScreen254(commands);

            BuildScreen255(commands);
            BuildScreen256(commands);
            BuildScreen257(commands);
            BuildScreen258(commands);
            BuildScreen259(commands);
            BuildScreen260(commands);
            BuildScreen261(commands);

            BuildScreen262(commands);
            BuildScreen263(commands);
            BuildScreen264(commands);
            BuildScreen265(commands);
            BuildScreen266(commands);
            BuildScreen267(commands);

            BuildScreen268(commands);
            BuildScreen269(commands);
            BuildScreen270(commands);
            BuildScreen271(commands);
            BuildScreen272(commands);
            BuildScreen273(commands);
            BuildScreen274(commands);
            BuildScreen275(commands);
            BuildScreen276(commands);

            BuildScreen277(commands);
            BuildScreen278(commands);
            BuildScreen279(commands);
            BuildScreen280(commands);

            BuildScreen281(commands);
            BuildScreen282(commands);
            BuildScreen283(commands);
            BuildScreen284(commands);
            BuildScreen285(commands);
            BuildScreen286(commands);

            BuildScreen287(commands);
            BuildScreen288(commands);
            BuildScreen289(commands);
            BuildScreen290(commands);

            // Dungeon 7
            BuildScreen300(commands);

            BuildScreen301(commands);
            BuildScreen302(commands);
            BuildScreen303(commands);
            BuildScreen304(commands);
            BuildScreen305(commands);

            BuildScreen306(commands);
            BuildScreen307(commands);
            BuildScreen308(commands);
            BuildScreen309(commands);
            BuildScreen310(commands);
            BuildScreen311(commands);
            BuildScreen312(commands);

            BuildScreen313(commands);
            BuildScreen314(commands);
            BuildScreen315(commands);
            BuildScreen316(commands);
            BuildScreen317(commands);
            BuildScreen318(commands);
            BuildScreen319(commands);

            BuildScreen320(commands);
            BuildScreen321(commands);
            BuildScreen322(commands);
            BuildScreen323(commands);
            BuildScreen324(commands);
            BuildScreen325(commands);
            BuildScreen326(commands);

            BuildScreen327(commands);
            BuildScreen328(commands);
            BuildScreen329(commands);
            BuildScreen330(commands);
            BuildScreen331(commands);
            BuildScreen332(commands);
            BuildScreen333(commands);

            BuildScreen334(commands);
            BuildScreen335(commands);
            BuildScreen336(commands);
            BuildScreen337(commands);

            BuildScreen338(commands);
            BuildScreen339(commands);
            BuildScreen340(commands);
            BuildScreen341(commands);
            BuildScreen342(commands);
            BuildScreen343(commands);

            // Dungeon 8
            BuildScreen400(commands);
            BuildScreen401(commands);
            BuildScreen402(commands);
            BuildScreen403(commands);
            BuildScreen404(commands);
            BuildScreen405(commands);
            BuildScreen406(commands);
            BuildScreen407(commands);

            BuildScreen408(commands);
            BuildScreen409(commands);
            BuildScreen410(commands);
            BuildScreen411(commands);
            BuildScreen412(commands);
            BuildScreen413(commands);
            BuildScreen414(commands);
            BuildScreen415(commands);
            BuildScreen416(commands);

            BuildScreen417(commands);
            BuildScreen418(commands);
            BuildScreen419(commands);
            BuildScreen420(commands);
            BuildScreen421(commands);
            BuildScreen422(commands);
            BuildScreen423(commands);
            BuildScreen424(commands);
            BuildScreen425(commands);

            BuildScreen426(commands);
            BuildScreen427(commands);
            BuildScreen428(commands);
            BuildScreen429(commands);
            BuildScreen430(commands);
            BuildScreen431(commands);
            BuildScreen432(commands);
            BuildScreen433(commands);
            BuildScreen434(commands);

            BuildScreen435(commands);
            BuildScreen436(commands);
            BuildScreen437(commands);
            BuildScreen438(commands);
            BuildScreen439(commands);
            BuildScreen440(commands);
            BuildScreen441(commands);
            BuildScreen442(commands);
            BuildScreen443(commands);

            BuildScreen444(commands);
            BuildScreen445(commands);
            BuildScreen446(commands);
            BuildScreen447(commands);
            BuildScreen448(commands);
            BuildScreen449(commands);
            BuildScreen450(commands);
            BuildScreen451(commands);
            BuildScreen452(commands);

            BuildScreen453(commands);
            BuildScreen454(commands);
            BuildScreen455(commands);
            BuildScreen456(commands);
            BuildScreen457(commands);
            BuildScreen458(commands);
            BuildScreen459(commands);
            BuildScreen460(commands);
            BuildScreen461(commands);














            //SemanticCheckCommands(commands);
            return commands;
        }

        private void BuildScreen0(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 0, 0, 222, 184, 135));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));
            commands.AddLast(new AddTreeCommand(2, 7, 0));
            commands.AddLast(new AddTreeCommand(2, 8, 0));
            commands.AddLast(new AddTreeCommand(2, 9, 0));
            commands.AddLast(new AddTreeCommand(2, 10, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));
            commands.AddLast(new AddTreeCommand(2, 7, 1));
            commands.AddLast(new AddTreeCommand(2, 8, 1));
            commands.AddLast(new AddTreeCommand(2, 9, 1));
            commands.AddLast(new AddTreeCommand(2, 10, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 0, 6));
            commands.AddLast(new AddTreeCommand(2, 1, 6));
            commands.AddLast(new AddTreeCommand(2, 2, 6));

            commands.AddLast(new AddTreeCommand(2, 0, 7));
            commands.AddLast(new AddTreeCommand(2, 0, 8));

            commands.AddLast(new AddTreeCommand(2, 1, 7));
            commands.AddLast(new AddTreeCommand(2, 1, 8));

            commands.AddLast(new AddStairsCommand(2, 4, 7, 2));



            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 13, 5));
            commands.AddLast(new AddTreeCommand(2, 14, 5));
            commands.AddLast(new AddTreeCommand(2, 15, 5));
            commands.AddLast(new AddTreeCommand(2, 16, 5));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));
            commands.AddLast(new AddTreeCommand(2, 5, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 6, 11));

            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));
            commands.AddLast(new AddTreeCommand(2, 6, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));


            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 1));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 1));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 1));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 5));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 5));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 5));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 5));
        }

        private void BuildScreen1(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 1, 0, 222, 184, 135));

            commands.AddLast(new AddStoneWallCommand(2, 0, 0));
            commands.AddLast(new AddStoneWallCommand(2, 1, 0));
            commands.AddLast(new AddStoneWallCommand(2, 2, 0));
            commands.AddLast(new AddStoneWallCommand(2, 3, 0));
            commands.AddLast(new AddStoneWallCommand(2, 4, 0));
            commands.AddLast(new AddStoneWallCommand(2, 5, 0));
            commands.AddLast(new AddStoneWallCommand(2, 6, 0));
            commands.AddLast(new AddStoneWallCommand(2, 7, 0));
            commands.AddLast(new AddStoneWallCommand(2, 8, 0));
            commands.AddLast(new AddStoneWallCommand(2, 9, 0));
            commands.AddLast(new AddStoneWallCommand(2, 10, 0));
            commands.AddLast(new AddStoneWallCommand(2, 11, 0));
            commands.AddLast(new AddStoneWallCommand(2, 12, 0));
            commands.AddLast(new AddStoneWallCommand(2, 13, 0));
            commands.AddLast(new AddStoneWallCommand(2, 14, 0));
            commands.AddLast(new AddStoneWallCommand(2, 15, 0));
            commands.AddLast(new AddStoneWallCommand(2, 16, 0));

            commands.AddLast(new AddStoneWallCommand(2, 0, 1));
            commands.AddLast(new AddStoneWallCommand(2, 1, 1));
            commands.AddLast(new AddStoneWallCommand(2, 2, 1));
            commands.AddLast(new AddStoneWallCommand(2, 3, 1));
            commands.AddLast(new AddStoneWallCommand(2, 4, 1));
            commands.AddLast(new AddStoneWallCommand(2, 5, 1));
            commands.AddLast(new AddStoneWallCommand(2, 6, 1));
            commands.AddLast(new AddStoneWallCommand(2, 7, 1));
            commands.AddLast(new AddStoneWallCommand(2, 8, 1));
            commands.AddLast(new AddStoneWallCommand(2, 9, 1));
            commands.AddLast(new AddStoneWallCommand(2, 10, 1));
            commands.AddLast(new AddStoneWallCommand(2, 11, 1));
            commands.AddLast(new AddStoneWallCommand(2, 12, 1));
            commands.AddLast(new AddStoneWallCommand(2, 13, 1));
            commands.AddLast(new AddStoneWallCommand(2, 14, 1));
            commands.AddLast(new AddStoneWallCommand(2, 15, 1));
            commands.AddLast(new AddStoneWallCommand(2, 16, 1));

            commands.AddLast(new AddStoneWallCommand(2, 0, 2));
            commands.AddLast(new AddStoneWallCommand(2, 1, 2));
            commands.AddLast(new AddStoneWallCommand(2, 15, 2));
            commands.AddLast(new AddStoneWallCommand(2, 16, 2));

            commands.AddLast(new AddStoneWallCommand(2, 0, 3));
            commands.AddLast(new AddStoneWallCommand(2, 1, 3));
            commands.AddLast(new AddStoneWallCommand(2, 15, 3));
            commands.AddLast(new AddStoneWallCommand(2, 16, 3));

            commands.AddLast(new AddStoneWallCommand(2, 0, 4));
            commands.AddLast(new AddStoneWallCommand(2, 1, 4));
            commands.AddLast(new AddStoneWallCommand(2, 15, 4));
            commands.AddLast(new AddStoneWallCommand(2, 16, 4));

            commands.AddLast(new AddStoneWallCommand(2, 0, 5));
            commands.AddLast(new AddStoneWallCommand(2, 1, 5));
            commands.AddLast(new AddStoneWallCommand(2, 15, 5));
            commands.AddLast(new AddStoneWallCommand(2, 16, 5));


            commands.AddLast(new AddStoneWallCommand(2, 0, 9));
            commands.AddLast(new AddStoneWallCommand(2, 1, 9));
            commands.AddLast(new AddStoneWallCommand(2, 15, 9));
            commands.AddLast(new AddStoneWallCommand(2, 16, 9));

            commands.AddLast(new AddStoneWallCommand(2, 0, 10));
            commands.AddLast(new AddStoneWallCommand(2, 1, 10));
            commands.AddLast(new AddStoneWallCommand(2, 15, 10));
            commands.AddLast(new AddStoneWallCommand(2, 16, 10));

            commands.AddLast(new AddStoneWallCommand(2, 0, 11));
            commands.AddLast(new AddStoneWallCommand(2, 1, 11));
            commands.AddLast(new AddStoneWallCommand(2, 15, 11));
            commands.AddLast(new AddStoneWallCommand(2, 16, 11));

            commands.AddLast(new AddStoneWallCommand(2, 0, 12));
            commands.AddLast(new AddStoneWallCommand(2, 1, 12));
            commands.AddLast(new AddStoneWallCommand(2, 15, 12));
            commands.AddLast(new AddStoneWallCommand(2, 16, 12));

            commands.AddLast(new AddStoneWallCommand(2, 0, 13));
            commands.AddLast(new AddStoneWallCommand(2, 1, 13));
            commands.AddLast(new AddStoneWallCommand(2, 15, 13));
            commands.AddLast(new AddStoneWallCommand(2, 16, 13));



            commands.AddLast(new AddStoneWallCommand(2, 0, 13));
            commands.AddLast(new AddStoneWallCommand(2, 1, 13));
            commands.AddLast(new AddStoneWallCommand(2, 2, 13));
            commands.AddLast(new AddStoneWallCommand(2, 3, 13));
            commands.AddLast(new AddStoneWallCommand(2, 4, 13));
            commands.AddLast(new AddStoneWallCommand(2, 5, 13));
            commands.AddLast(new AddStoneWallCommand(2, 6, 13));
            commands.AddLast(new AddStoneWallCommand(2, 10, 13));
            commands.AddLast(new AddStoneWallCommand(2, 11, 13));
            commands.AddLast(new AddStoneWallCommand(2, 12, 13));
            commands.AddLast(new AddStoneWallCommand(2, 13, 13));
            commands.AddLast(new AddStoneWallCommand(2, 14, 13));
            commands.AddLast(new AddStoneWallCommand(2, 15, 13));

            commands.AddLast(new AddStoneWallCommand(2, 0, 14));
            commands.AddLast(new AddStoneWallCommand(2, 1, 14));
            commands.AddLast(new AddStoneWallCommand(2, 2, 14));
            commands.AddLast(new AddStoneWallCommand(2, 3, 14));
            commands.AddLast(new AddStoneWallCommand(2, 4, 14));
            commands.AddLast(new AddStoneWallCommand(2, 5, 14));
            commands.AddLast(new AddStoneWallCommand(2, 6, 14));
            commands.AddLast(new AddStoneWallCommand(2, 10, 14));
            commands.AddLast(new AddStoneWallCommand(2, 11, 14));
            commands.AddLast(new AddStoneWallCommand(2, 12, 14));
            commands.AddLast(new AddStoneWallCommand(2, 13, 14));
            commands.AddLast(new AddStoneWallCommand(2, 14, 14));
            commands.AddLast(new AddStoneWallCommand(2, 15, 14));

            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 7, 3));
            commands.AddLast(new AddTreeCommand(2, 9, 3));
            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));

            commands.AddLast(new AddTreeCommand(2, 3, 5));
            commands.AddLast(new AddTreeCommand(2, 5, 5));
            commands.AddLast(new AddTreeCommand(2, 7, 5));
            commands.AddLast(new AddTreeCommand(2, 9, 5));
            commands.AddLast(new AddTreeCommand(2, 11, 5));
            commands.AddLast(new AddTreeCommand(2, 13, 5));

            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 5, 9));
            commands.AddLast(new AddTreeCommand(2, 7, 9));
            commands.AddLast(new AddTreeCommand(2, 9, 9));
            commands.AddLast(new AddTreeCommand(2, 11, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));

            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 7, 11));
            commands.AddLast(new AddTreeCommand(2, 9, 11));
            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));



            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 0));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 0));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 6));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 6));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 6));

            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 2));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 2));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 2));
        }

        private void BuildScreen2(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 2, 0, 222, 184, 135));

            commands.AddLast(new AddStoneWallCommand(2, 0, 0));
            commands.AddLast(new AddStoneWallCommand(2, 1, 0));
            commands.AddLast(new AddStoneWallCommand(2, 2, 0));
            commands.AddLast(new AddStoneWallCommand(2, 3, 0));
            commands.AddLast(new AddStoneWallCommand(2, 4, 0));
            commands.AddLast(new AddStoneWallCommand(2, 5, 0));
            commands.AddLast(new AddStoneWallCommand(2, 6, 0));
            commands.AddLast(new AddStoneWallCommand(2, 7, 0));
            commands.AddLast(new AddStoneWallCommand(2, 8, 0));
            commands.AddLast(new AddStoneWallCommand(2, 9, 0));
            commands.AddLast(new AddStoneWallCommand(2, 10, 0));
            commands.AddLast(new AddStoneWallCommand(2, 11, 0));
            commands.AddLast(new AddStoneWallCommand(2, 12, 0));
            commands.AddLast(new AddStoneWallCommand(2, 13, 0));
            commands.AddLast(new AddStoneWallCommand(2, 14, 0));
            commands.AddLast(new AddStoneWallCommand(2, 15, 0));
            commands.AddLast(new AddStoneWallCommand(2, 16, 0));

            commands.AddLast(new AddStoneWallCommand(2, 0, 1));
            commands.AddLast(new AddStoneWallCommand(2, 1, 1));
            commands.AddLast(new AddStoneWallCommand(2, 2, 1));
            commands.AddLast(new AddStoneWallCommand(2, 3, 1));
            commands.AddLast(new AddStoneWallCommand(2, 4, 1));
            commands.AddLast(new AddStoneWallCommand(2, 5, 1));
            commands.AddLast(new AddStoneWallCommand(2, 6, 1));
            commands.AddLast(new AddStoneWallCommand(2, 7, 1));
            commands.AddLast(new AddStoneWallCommand(2, 8, 1));
            commands.AddLast(new AddStoneWallCommand(2, 9, 1));
            commands.AddLast(new AddStoneWallCommand(2, 10, 1));
            commands.AddLast(new AddStoneWallCommand(2, 11, 1));
            commands.AddLast(new AddStoneWallCommand(2, 12, 1));
            commands.AddLast(new AddStoneWallCommand(2, 13, 1));
            commands.AddLast(new AddStoneWallCommand(2, 14, 1));
            commands.AddLast(new AddStoneWallCommand(2, 15, 1));
            commands.AddLast(new AddStoneWallCommand(2, 16, 1));

            commands.AddLast(new AddStoneWallCommand(2, 0, 2));
            commands.AddLast(new AddStoneWallCommand(2, 1, 2));
            commands.AddLast(new AddWaterCommand(2, 15, 2));
            commands.AddLast(new AddWaterCommand(2, 16, 2));

            commands.AddLast(new AddStoneWallCommand(2, 0, 3));
            commands.AddLast(new AddStoneWallCommand(2, 1, 3));
            commands.AddLast(new AddStoneWallCommand(2, 15, 3));
            commands.AddLast(new AddStoneWallCommand(2, 16, 3));

            commands.AddLast(new AddStoneWallCommand(2, 0, 4));
            commands.AddLast(new AddStoneWallCommand(2, 1, 4));
            commands.AddLast(new AddStoneWallCommand(2, 15, 4));
            commands.AddLast(new AddStoneWallCommand(2, 16, 4));

            commands.AddLast(new AddStoneWallCommand(2, 0, 5));
            commands.AddLast(new AddStoneWallCommand(2, 1, 5));
            commands.AddLast(new AddStoneWallCommand(2, 15, 5));
            commands.AddLast(new AddStoneWallCommand(2, 16, 5));

            commands.AddLast(new AddStoneWallCommand(2, 15, 6));
            commands.AddLast(new AddStoneWallCommand(2, 16, 6));

            commands.AddLast(new AddStoneWallCommand(2, 15, 7));
            commands.AddLast(new AddStoneWallCommand(2, 16, 7));

            commands.AddLast(new AddStoneWallCommand(2, 15, 8));
            commands.AddLast(new AddStoneWallCommand(2, 16, 8));


            commands.AddLast(new AddStoneWallCommand(2, 0, 9));
            commands.AddLast(new AddStoneWallCommand(2, 1, 9));
            commands.AddLast(new AddStoneWallCommand(2, 15, 9));
            commands.AddLast(new AddStoneWallCommand(2, 16, 9));

            commands.AddLast(new AddStoneWallCommand(2, 0, 10));
            commands.AddLast(new AddStoneWallCommand(2, 1, 10));
            commands.AddLast(new AddStoneWallCommand(2, 15, 10));
            commands.AddLast(new AddStoneWallCommand(2, 16, 10));

            commands.AddLast(new AddStoneWallCommand(2, 0, 11));
            commands.AddLast(new AddStoneWallCommand(2, 1, 11));
            commands.AddLast(new AddStoneWallCommand(2, 15, 11));
            commands.AddLast(new AddStoneWallCommand(2, 16, 11));

            commands.AddLast(new AddStoneWallCommand(2, 0, 12));
            commands.AddLast(new AddStoneWallCommand(2, 1, 12));
            commands.AddLast(new AddStoneWallCommand(2, 15, 12));
            commands.AddLast(new AddStoneWallCommand(2, 16, 12));

            commands.AddLast(new AddStoneWallCommand(2, 0, 13));
            commands.AddLast(new AddStoneWallCommand(2, 1, 13));
            commands.AddLast(new AddStoneWallCommand(2, 15, 13));
            commands.AddLast(new AddStoneWallCommand(2, 16, 13));



            commands.AddLast(new AddStoneWallCommand(2, 0, 13));
            commands.AddLast(new AddStoneWallCommand(2, 1, 13));
            commands.AddLast(new AddStoneWallCommand(2, 2, 13));
            commands.AddLast(new AddStoneWallCommand(2, 3, 13));
            commands.AddLast(new AddStoneWallCommand(2, 4, 13));
            commands.AddLast(new AddStoneWallCommand(2, 5, 13));
            commands.AddLast(new AddStoneWallCommand(2, 6, 13));
            commands.AddLast(new AddStoneWallCommand(2, 7, 13));
            commands.AddLast(new AddStoneWallCommand(2, 8, 13));
            commands.AddLast(new AddStoneWallCommand(2, 9, 13));
            commands.AddLast(new AddStoneWallCommand(2, 10, 13));
            commands.AddLast(new AddWaterCommand(2, 11, 13));
            commands.AddLast(new AddWaterCommand(2, 12, 13));
            commands.AddLast(new AddWaterCommand(2, 13, 13));
            commands.AddLast(new AddStoneWallCommand(2, 14, 13));
            commands.AddLast(new AddStoneWallCommand(2, 15, 13));

            commands.AddLast(new AddStoneWallCommand(2, 0, 14));
            commands.AddLast(new AddStoneWallCommand(2, 1, 14));
            commands.AddLast(new AddStoneWallCommand(2, 2, 14));
            commands.AddLast(new AddStoneWallCommand(2, 3, 14));
            commands.AddLast(new AddStoneWallCommand(2, 4, 14));
            commands.AddLast(new AddStoneWallCommand(2, 5, 14));
            commands.AddLast(new AddStoneWallCommand(2, 6, 14));
            commands.AddLast(new AddStoneWallCommand(2, 7, 14));
            commands.AddLast(new AddStoneWallCommand(2, 8, 14));
            commands.AddLast(new AddStoneWallCommand(2, 9, 14));
            commands.AddLast(new AddStoneWallCommand(2, 10, 14));
            commands.AddLast(new AddWaterCommand(2, 11, 14));
            commands.AddLast(new AddWaterCommand(2, 12, 14));
            commands.AddLast(new AddWaterCommand(2, 13, 14));
            commands.AddLast(new AddStoneWallCommand(2, 14, 14));
            commands.AddLast(new AddStoneWallCommand(2, 15, 14));
            commands.AddLast(new AddStoneWallCommand(2, 16, 14));




            commands.AddLast(new AddWaterCommand(2, 2, 2));
            commands.AddLast(new AddWaterCommand(2, 3, 2));
            commands.AddLast(new AddWaterCommand(2, 4, 2));
            commands.AddLast(new AddWaterCommand(2, 5, 2));
            commands.AddLast(new AddWaterCommand(2, 6, 2));
            commands.AddLast(new AddWaterCommand(2, 7, 2));
            commands.AddLast(new AddWaterCommand(2, 8, 2));
            commands.AddLast(new AddWaterCommand(2, 9, 2));
            commands.AddLast(new AddWaterCommand(2, 10, 2));
            commands.AddLast(new AddWaterCommand(2, 11, 2));
            commands.AddLast(new AddWaterCommand(2, 12, 2));
            commands.AddLast(new AddWaterCommand(2, 13, 2));
            commands.AddLast(new AddWaterCommand(2, 14, 2));

            commands.AddLast(new AddWaterCommand(2, 2, 3));
            commands.AddLast(new AddWaterCommand(2, 3, 3));
            commands.AddLast(new AddWaterCommand(2, 4, 3));
            commands.AddLast(new AddWaterCommand(2, 5, 3));
            commands.AddLast(new AddWaterCommand(2, 6, 3));
            commands.AddLast(new AddWaterCommand(2, 7, 3));
            commands.AddLast(new AddWaterCommand(2, 8, 3));
            commands.AddLast(new AddWaterCommand(2, 9, 3));
            commands.AddLast(new AddWaterCommand(2, 10, 3));
            commands.AddLast(new AddWaterCommand(2, 11, 3));
            commands.AddLast(new AddWaterCommand(2, 12, 3));
            commands.AddLast(new AddWaterCommand(2, 13, 3));
            commands.AddLast(new AddWaterCommand(2, 14, 3));

            commands.AddLast(new AddWaterCommand(2, 2, 4));
            commands.AddLast(new AddWaterCommand(2, 3, 4));
            commands.AddLast(new AddWaterCommand(2, 4, 4));
            commands.AddLast(new AddWaterCommand(2, 5, 4));
            commands.AddLast(new AddWaterCommand(2, 6, 4));
            commands.AddLast(new AddWaterCommand(2, 7, 4));
            commands.AddLast(new AddWaterCommand(2, 8, 4));
            commands.AddLast(new AddWaterCommand(2, 9, 4));
            commands.AddLast(new AddWaterCommand(2, 10, 4));
            commands.AddLast(new AddWaterCommand(2, 11, 4));
            commands.AddLast(new AddWaterCommand(2, 12, 4));
            commands.AddLast(new AddWaterCommand(2, 13, 4));
            commands.AddLast(new AddWaterCommand(2, 14, 4));

            commands.AddLast(new AddWaterCommand(2, 2, 5));
            commands.AddLast(new AddWaterCommand(2, 3, 5));
            commands.AddLast(new AddWaterCommand(2, 4, 5));
            commands.AddLast(new AddWaterCommand(2, 5, 5));
            commands.AddLast(new AddWaterCommand(2, 6, 5));
            commands.AddLast(new AddWaterCommand(2, 10, 5));
            commands.AddLast(new AddWaterCommand(2, 11, 5));
            commands.AddLast(new AddWaterCommand(2, 12, 5));
            commands.AddLast(new AddWaterCommand(2, 13, 5));
            commands.AddLast(new AddWaterCommand(2, 14, 5));





            commands.AddLast(new AddWaterCommand(2, 2, 9));
            commands.AddLast(new AddWaterCommand(2, 3, 9));
            commands.AddLast(new AddWaterCommand(2, 4, 9));
            commands.AddLast(new AddWaterCommand(2, 5, 9));
            commands.AddLast(new AddWaterCommand(2, 6, 9));
            commands.AddLast(new AddWaterCommand(2, 10, 9));
            commands.AddLast(new AddWaterCommand(2, 11, 9));
            commands.AddLast(new AddWaterCommand(2, 12, 9));
            commands.AddLast(new AddWaterCommand(2, 13, 9));
            commands.AddLast(new AddWaterCommand(2, 14, 9));

            commands.AddLast(new AddWaterCommand(2, 2, 10));
            commands.AddLast(new AddWaterCommand(2, 3, 10));
            commands.AddLast(new AddWaterCommand(2, 4, 10));
            commands.AddLast(new AddWaterCommand(2, 5, 10));
            commands.AddLast(new AddWaterCommand(2, 6, 10));
            commands.AddLast(new AddWaterCommand(2, 7, 10));
            commands.AddLast(new AddWaterCommand(2, 8, 10));
            commands.AddLast(new AddWaterCommand(2, 9, 10));
            commands.AddLast(new AddWaterCommand(2, 10, 10));
            commands.AddLast(new AddWaterCommand(2, 11, 10));
            commands.AddLast(new AddWaterCommand(2, 12, 10));
            commands.AddLast(new AddWaterCommand(2, 13, 10));
            commands.AddLast(new AddWaterCommand(2, 14, 10));

            commands.AddLast(new AddWaterCommand(2, 2, 11));
            commands.AddLast(new AddWaterCommand(2, 3, 11));
            commands.AddLast(new AddWaterCommand(2, 4, 11));
            commands.AddLast(new AddWaterCommand(2, 5, 11));
            commands.AddLast(new AddWaterCommand(2, 6, 11));
            commands.AddLast(new AddWaterCommand(2, 7, 11));
            commands.AddLast(new AddWaterCommand(2, 8, 11));
            commands.AddLast(new AddWaterCommand(2, 9, 11));
            commands.AddLast(new AddWaterCommand(2, 10, 11));
            commands.AddLast(new AddWaterCommand(2, 11, 11));
            commands.AddLast(new AddWaterCommand(2, 12, 11));
            commands.AddLast(new AddWaterCommand(2, 13, 11));
            commands.AddLast(new AddWaterCommand(2, 14, 11));

            commands.AddLast(new AddWaterCommand(2, 2, 12));
            commands.AddLast(new AddWaterCommand(2, 3, 12));
            commands.AddLast(new AddWaterCommand(2, 4, 12));
            commands.AddLast(new AddWaterCommand(2, 5, 12));
            commands.AddLast(new AddWaterCommand(2, 6, 12));
            commands.AddLast(new AddWaterCommand(2, 7, 12));
            commands.AddLast(new AddWaterCommand(2, 8, 12));
            commands.AddLast(new AddWaterCommand(2, 9, 12));
            commands.AddLast(new AddWaterCommand(2, 10, 12));
            commands.AddLast(new AddWaterCommand(2, 11, 12));
            commands.AddLast(new AddWaterCommand(2, 12, 12));
            commands.AddLast(new AddWaterCommand(2, 13, 12));
            commands.AddLast(new AddWaterCommand(2, 14, 12));


            commands.AddLast(new AddRockCommand(2, 0, 6));
            commands.AddLast(new AddRockCommand(2, 1, 6));
            commands.AddLast(new AddRockCommand(2, 2, 6));
            commands.AddLast(new AddRockCommand(2, 3, 6));
            commands.AddLast(new AddRockCommand(2, 4, 6));
            commands.AddLast(new AddRockCommand(2, 5, 6));
            commands.AddLast(new AddRockCommand(2, 6, 6));
            commands.AddLast(new AddRockCommand(2, 7, 5));
            commands.AddLast(new AddRockCommand(2, 8, 5));
            commands.AddLast(new AddRockCommand(2, 9, 5));
            commands.AddLast(new AddRockCommand(2, 10, 6));

            commands.AddLast(new AddRockCommand(2, 10, 7));

            commands.AddLast(new AddRockCommand(2, 0, 8));
            commands.AddLast(new AddRockCommand(2, 1, 8));
            commands.AddLast(new AddRockCommand(2, 2, 8));
            commands.AddLast(new AddRockCommand(2, 3, 8));
            commands.AddLast(new AddRockCommand(2, 4, 8));
            commands.AddLast(new AddRockCommand(2, 5, 8));
            commands.AddLast(new AddRockCommand(2, 6, 8));
            commands.AddLast(new AddRockCommand(2, 7, 9));
            commands.AddLast(new AddRockCommand(2, 8, 9));
            commands.AddLast(new AddRockCommand(2, 9, 9));
            commands.AddLast(new AddRockCommand(2, 10, 8));


            commands.AddLast(new AddWaterCommand(2, 11, 6));
            commands.AddLast(new AddWaterCommand(2, 12, 6));
            commands.AddLast(new AddWaterCommand(2, 13, 6));
            commands.AddLast(new AddWaterCommand(2, 14, 6));

            commands.AddLast(new AddWaterCommand(2, 11, 7));
            commands.AddLast(new AddWaterCommand(2, 12, 7));
            commands.AddLast(new AddWaterCommand(2, 13, 7));
            commands.AddLast(new AddWaterCommand(2, 14, 7));

            commands.AddLast(new AddWaterCommand(2, 11, 8));
            commands.AddLast(new AddWaterCommand(2, 12, 8));
            commands.AddLast(new AddWaterCommand(2, 13, 8));
            commands.AddLast(new AddWaterCommand(2, 14, 8));












            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 1));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 1));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 1));

            commands.AddLast(new AddStairsCommand(2, 8, 7, 6));
        }

        private void BuildScreen3(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 3, 0, 222, 184, 135));

            commands.AddLast(new AddStoneWallCommand(2, 0, 0));
            commands.AddLast(new AddStoneWallCommand(2, 1, 0));
            commands.AddLast(new AddStoneWallCommand(2, 2, 0));
            commands.AddLast(new AddStoneWallCommand(2, 3, 0));
            commands.AddLast(new AddStoneWallCommand(2, 4, 0));
            commands.AddLast(new AddStoneWallCommand(2, 5, 0));
            commands.AddLast(new AddStoneWallCommand(2, 6, 0));
            commands.AddLast(new AddStoneWallCommand(2, 7, 0));
            commands.AddLast(new AddStoneWallCommand(2, 8, 0));
            commands.AddLast(new AddStoneWallCommand(2, 9, 0));
            commands.AddLast(new AddStoneWallCommand(2, 10, 0));
            commands.AddLast(new AddStoneWallCommand(2, 11, 0));
            commands.AddLast(new AddStoneWallCommand(2, 12, 0));
            commands.AddLast(new AddStoneWallCommand(2, 13, 0));
            commands.AddLast(new AddStoneWallCommand(2, 14, 0));
            commands.AddLast(new AddStoneWallCommand(2, 15, 0));
            commands.AddLast(new AddStoneWallCommand(2, 16, 0));

            commands.AddLast(new AddWaterCommand(2, 0, 1));
            commands.AddLast(new AddWaterCommand(2, 1, 1));
            commands.AddLast(new AddWaterCommand(2, 2, 1));
            commands.AddLast(new AddWaterCommand(2, 3, 1));
            commands.AddLast(new AddWaterCommand(2, 4, 1));
            commands.AddLast(new AddWaterCommand(2, 5, 1));
            commands.AddLast(new AddWaterCommand(2, 6, 1));
            commands.AddLast(new AddWaterCommand(2, 7, 1));
            commands.AddLast(new AddWaterCommand(2, 8, 1));
            commands.AddLast(new AddWaterCommand(2, 9, 1));
            commands.AddLast(new AddWaterCommand(2, 10, 1));
            commands.AddLast(new AddWaterCommand(2, 11, 1));
            commands.AddLast(new AddWaterCommand(2, 12, 1));
            commands.AddLast(new AddWaterCommand(2, 13, 1));
            commands.AddLast(new AddWaterCommand(2, 14, 1));
            commands.AddLast(new AddWaterCommand(2, 15, 1));
            commands.AddLast(new AddStoneWallCommand(2, 16, 1));

            commands.AddLast(new AddWaterCommand(2, 0, 2));
            commands.AddLast(new AddWaterCommand(2, 1, 2));
            commands.AddLast(new AddWaterCommand(2, 2, 2));
            commands.AddLast(new AddWaterCommand(2, 3, 2));
            commands.AddLast(new AddWaterCommand(2, 4, 2));
            commands.AddLast(new AddWaterCommand(2, 5, 2));
            commands.AddLast(new AddWaterCommand(2, 6, 2));
            commands.AddLast(new AddWaterCommand(2, 7, 2));
            commands.AddLast(new AddWaterCommand(2, 8, 2));
            commands.AddLast(new AddWaterCommand(2, 9, 2));
            commands.AddLast(new AddWaterCommand(2, 10, 2));
            commands.AddLast(new AddWaterCommand(2, 11, 2));
            commands.AddLast(new AddWaterCommand(2, 12, 2));
            commands.AddLast(new AddWaterCommand(2, 13, 2));
            commands.AddLast(new AddWaterCommand(2, 14, 2));
            commands.AddLast(new AddWaterCommand(2, 15, 2));
            commands.AddLast(new AddStoneWallCommand(2, 16, 2));

            commands.AddLast(new AddStoneWallCommand(2, 0, 3));
            commands.AddLast(new AddStoneWallCommand(2, 1, 3));
            commands.AddLast(new AddStoneWallCommand(2, 2, 3));
            commands.AddLast(new AddStoneWallCommand(2, 3, 3));
            commands.AddLast(new AddStoneWallCommand(2, 4, 3));
            commands.AddLast(new AddStoneWallCommand(2, 5, 3));
            commands.AddLast(new AddStoneWallCommand(2, 6, 3));
            commands.AddLast(new AddStoneWallCommand(2, 7, 3));
            commands.AddLast(new AddStoneWallCommand(2, 8, 3));
            commands.AddLast(new AddStoneWallCommand(2, 9, 3));
            commands.AddLast(new AddStoneWallCommand(2, 10, 3));
            commands.AddLast(new AddStoneWallCommand(2, 11, 3));
            commands.AddLast(new AddStoneWallCommand(2, 12, 3));
            commands.AddLast(new AddWaterCommand(2, 13, 3));
            commands.AddLast(new AddWaterCommand(2, 14, 3));
            commands.AddLast(new AddWaterCommand(2, 15, 3));
            commands.AddLast(new AddStoneWallCommand(2, 16, 3));

            commands.AddLast(new AddStoneWallCommand(2, 0, 4));
            commands.AddLast(new AddStoneWallCommand(2, 1, 4));
            commands.AddLast(new AddStoneWallCommand(2, 2, 4));
            commands.AddLast(new AddStoneWallCommand(2, 3, 4));
            commands.AddLast(new AddStoneWallCommand(2, 4, 4));
            commands.AddLast(new AddStoneWallCommand(2, 5, 4));
            commands.AddLast(new AddStoneWallCommand(2, 6, 4));
            commands.AddLast(new AddStoneWallCommand(2, 7, 4));
            commands.AddLast(new AddStoneWallCommand(2, 8, 4));
            commands.AddLast(new AddStoneWallCommand(2, 9, 4));
            commands.AddLast(new AddStoneWallCommand(2, 10, 4));
            commands.AddLast(new AddStoneWallCommand(2, 11, 4));
            commands.AddLast(new AddStoneWallCommand(2, 12, 4));
            commands.AddLast(new AddStoneWallCommand(2, 13, 4));
            commands.AddLast(new AddWaterCommand(2, 14, 4));
            commands.AddLast(new AddWaterCommand(2, 15, 4));
            commands.AddLast(new AddStoneWallCommand(2, 16, 4));

            commands.AddLast(new AddStoneWallCommand(2, 0, 5));
            commands.AddLast(new AddStoneWallCommand(2, 1, 5));
            commands.AddLast(new AddStoneWallCommand(2, 2, 5));
            commands.AddLast(new AddStoneWallCommand(2, 12, 5));
            commands.AddLast(new AddStoneWallCommand(2, 13, 5));
            commands.AddLast(new AddWaterCommand(2, 14, 5));
            commands.AddLast(new AddWaterCommand(2, 15, 5));
            commands.AddLast(new AddWaterCommand(2, 16, 5));

            commands.AddLast(new AddStoneWallCommand(2, 0, 6));
            commands.AddLast(new AddStoneWallCommand(2, 1, 6));
            commands.AddLast(new AddStoneWallCommand(2, 13, 6));
            commands.AddLast(new AddWaterCommand(2, 14, 6));
            commands.AddLast(new AddWaterCommand(2, 15, 6));
            commands.AddLast(new AddWaterCommand(2, 16, 6));

            commands.AddLast(new AddStoneWallCommand(2, 0, 7));
            commands.AddLast(new AddStoneWallCommand(2, 1, 7));
            commands.AddLast(new AddStoneWallCommand(2, 13, 7));
            commands.AddLast(new AddStoneWallCommand(2, 14, 7));
            commands.AddLast(new AddWaterCommand(2, 15, 7));
            commands.AddLast(new AddWaterCommand(2, 16, 7));

            commands.AddLast(new AddStoneWallCommand(2, 0, 8));
            commands.AddLast(new AddStoneWallCommand(2, 1, 8));
            commands.AddLast(new AddStoneWallCommand(2, 14, 8));
            commands.AddLast(new AddWaterCommand(2, 15, 8));
            commands.AddLast(new AddWaterCommand(2, 16, 8));

            commands.AddLast(new AddStoneWallCommand(2, 0, 9));
            commands.AddLast(new AddStoneWallCommand(2, 14, 9));
            commands.AddLast(new AddStoneWallCommand(2, 15, 9));
            commands.AddLast(new AddStoneWallCommand(2, 16, 9));

            commands.AddLast(new AddStoneWallCommand(2, 0, 10));
            commands.AddLast(new AddStoneWallCommand(2, 15, 10));
            commands.AddLast(new AddStoneWallCommand(2, 16, 10));

            commands.AddLast(new AddStoneWallCommand(2, 0, 11));
            commands.AddLast(new AddStoneWallCommand(2, 16, 11));

            commands.AddLast(new AddStoneWallCommand(2, 0, 12));
            commands.AddLast(new AddStoneWallCommand(2, 1, 12));
            commands.AddLast(new AddStoneWallCommand(2, 16, 12));

            commands.AddLast(new AddStoneWallCommand(2, 0, 13));
            commands.AddLast(new AddStoneWallCommand(2, 1, 13));
            commands.AddLast(new AddStoneWallCommand(2, 2, 13));
            commands.AddLast(new AddStoneWallCommand(2, 15, 13));
            commands.AddLast(new AddStoneWallCommand(2, 16, 13));

            commands.AddLast(new AddStoneWallCommand(2, 0, 14));
            commands.AddLast(new AddStoneWallCommand(2, 1, 14));
            commands.AddLast(new AddStoneWallCommand(2, 2, 14));
            commands.AddLast(new AddStoneWallCommand(2, 3, 14));
            commands.AddLast(new AddStoneWallCommand(2, 4, 14));
            commands.AddLast(new AddStoneWallCommand(2, 5, 14));
            commands.AddLast(new AddStoneWallCommand(2, 6, 14));
            commands.AddLast(new AddStoneWallCommand(2, 11, 14));
            commands.AddLast(new AddStoneWallCommand(2, 12, 14));
            commands.AddLast(new AddStoneWallCommand(2, 13, 14));
            commands.AddLast(new AddStoneWallCommand(2, 14, 14));
            commands.AddLast(new AddStoneWallCommand(2, 15, 14));
            commands.AddLast(new AddStoneWallCommand(2, 16, 14));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 8));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 8));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 8));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 8));

        }

        private void BuildScreen4(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 4, 0, 222, 184, 135));

            commands.AddLast(new AddStoneWallCommand(2, 0, 0));
            commands.AddLast(new AddStoneWallCommand(2, 1, 0));
            commands.AddLast(new AddStoneWallCommand(2, 2, 0));
            commands.AddLast(new AddStoneWallCommand(2, 3, 0));
            commands.AddLast(new AddStoneWallCommand(2, 4, 0));
            commands.AddLast(new AddStoneWallCommand(2, 5, 0));
            commands.AddLast(new AddStoneWallCommand(2, 6, 0));
            commands.AddLast(new AddStoneWallCommand(2, 7, 0));
            commands.AddLast(new AddStoneWallCommand(2, 8, 0));
            commands.AddLast(new AddStoneWallCommand(2, 9, 0));
            commands.AddLast(new AddStoneWallCommand(2, 10, 0));
            commands.AddLast(new AddStoneWallCommand(2, 11, 0));
            commands.AddLast(new AddStoneWallCommand(2, 12, 0));
            commands.AddLast(new AddStoneWallCommand(2, 13, 0));
            commands.AddLast(new AddStoneWallCommand(2, 14, 0));
            commands.AddLast(new AddStoneWallCommand(2, 15, 0));
            commands.AddLast(new AddStoneWallCommand(2, 16, 0));

            commands.AddLast(new AddStoneWallCommand(2, 0, 1));
            commands.AddLast(new AddStoneWallCommand(2, 1, 1));
            commands.AddLast(new AddStoneWallCommand(2, 2, 1));
            commands.AddLast(new AddWaterCommand(2, 3, 1));
            commands.AddLast(new AddWaterCommand(2, 4, 1));
            commands.AddLast(new AddWaterCommand(2, 5, 1));
            commands.AddLast(new AddWaterCommand(2, 6, 1));
            commands.AddLast(new AddWaterCommand(2, 7, 1));
            commands.AddLast(new AddWaterCommand(2, 8, 1));
            commands.AddLast(new AddWaterCommand(2, 9, 1));
            commands.AddLast(new AddWaterCommand(2, 10, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddStoneWallCommand(2, 14, 1));
            commands.AddLast(new AddStoneWallCommand(2, 15, 1));
            commands.AddLast(new AddStoneWallCommand(2, 16, 1));

            commands.AddLast(new AddStoneWallCommand(2, 0, 2));
            commands.AddLast(new AddStoneWallCommand(2, 1, 2));
            commands.AddLast(new AddWaterCommand(2, 2, 2));
            commands.AddLast(new AddWaterCommand(2, 3, 2));
            commands.AddLast(new AddWaterCommand(2, 4, 2));
            commands.AddLast(new AddWaterCommand(2, 5, 2));
            commands.AddLast(new AddWaterCommand(2, 6, 2));
            commands.AddLast(new AddWaterCommand(2, 7, 2));
            commands.AddLast(new AddWaterCommand(2, 8, 2));
            commands.AddLast(new AddWaterCommand(2, 9, 2));
            commands.AddLast(new AddWaterCommand(2, 10, 2));
            commands.AddLast(new AddStoneWallCommand(2, 15, 2));
            commands.AddLast(new AddStoneWallCommand(2, 16, 2));

            commands.AddLast(new AddStoneWallCommand(2, 0, 3));
            commands.AddLast(new AddWaterCommand(2, 1, 3));
            commands.AddLast(new AddWaterCommand(2, 2, 3));
            commands.AddLast(new AddWaterCommand(2, 3, 3));
            commands.AddLast(new AddWaterCommand(2, 4, 3));
            commands.AddLast(new AddWaterCommand(2, 5, 3));
            commands.AddLast(new AddWaterCommand(2, 6, 3));
            commands.AddLast(new AddWaterCommand(2, 7, 3));
            commands.AddLast(new AddWaterCommand(2, 8, 3));
            commands.AddLast(new AddWaterCommand(2, 9, 3));
            commands.AddLast(new AddWaterCommand(2, 10, 3));
            commands.AddLast(new AddWaterCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddStoneWallCommand(2, 16, 3));

            commands.AddLast(new AddStoneWallCommand(2, 0, 4));
            commands.AddLast(new AddWaterCommand(2, 1, 4));
            commands.AddLast(new AddWaterCommand(2, 2, 4));
            commands.AddLast(new AddWaterCommand(2, 3, 4));
            commands.AddLast(new AddWaterCommand(2, 4, 4));
            commands.AddLast(new AddWaterCommand(2, 5, 4));
            commands.AddLast(new AddWaterCommand(2, 6, 4));
            commands.AddLast(new AddWaterCommand(2, 7, 4));
            commands.AddLast(new AddWaterCommand(2, 8, 4));
            commands.AddLast(new AddWaterCommand(2, 9, 4));
            commands.AddLast(new AddWaterCommand(2, 10, 4));
            commands.AddLast(new AddWaterCommand(2, 11, 4));
            commands.AddLast(new AddWaterCommand(2, 12, 4));
            commands.AddLast(new AddRockCommand(2, 13, 4));
            commands.AddLast(new AddStoneWallCommand(2, 16, 4));

            commands.AddLast(new AddWaterCommand(2, 0, 5));
            commands.AddLast(new AddWaterCommand(2, 1, 5));
            commands.AddLast(new AddWaterCommand(2, 2, 5));
            commands.AddLast(new AddWaterCommand(2, 3, 5));
            commands.AddLast(new AddWaterCommand(2, 4, 5));
            commands.AddLast(new AddWaterCommand(2, 5, 5));
            commands.AddLast(new AddWaterCommand(2, 6, 5));
            commands.AddLast(new AddWaterCommand(2, 7, 5));
            commands.AddLast(new AddTreeCommand(2, 9, 5));
            commands.AddLast(new AddWaterCommand(2, 10, 5));
            commands.AddLast(new AddWaterCommand(2, 11, 5));
            commands.AddLast(new AddWaterCommand(2, 12, 5));
            commands.AddLast(new AddWaterCommand(2, 13, 5));
            commands.AddLast(new AddWaterCommand(2, 14, 5));
            commands.AddLast(new AddWaterCommand(2, 15, 5));
            commands.AddLast(new AddStoneWallCommand(2, 16, 5));

            commands.AddLast(new AddWaterCommand(2, 0, 6));
            commands.AddLast(new AddWaterCommand(2, 1, 6));
            commands.AddLast(new AddWaterCommand(2, 2, 6));
            commands.AddLast(new AddWaterCommand(2, 3, 6));
            commands.AddLast(new AddWaterCommand(2, 4, 6));
            commands.AddLast(new AddWaterCommand(2, 5, 6));
            commands.AddLast(new AddRockCommand(2, 6, 6));
            commands.AddLast(new AddWaterCommand(2, 10, 6));
            commands.AddLast(new AddWaterCommand(2, 11, 6));
            commands.AddLast(new AddWaterCommand(2, 12, 6));
            commands.AddLast(new AddWaterCommand(2, 13, 6));
            commands.AddLast(new AddWaterCommand(2, 14, 6));
            commands.AddLast(new AddWaterCommand(2, 15, 6));
            commands.AddLast(new AddStoneWallCommand(2, 16, 6));

            commands.AddLast(new AddWaterCommand(2, 0, 7));
            commands.AddLast(new AddWaterCommand(2, 1, 7));
            commands.AddLast(new AddWaterCommand(2, 2, 7));
            commands.AddLast(new AddWaterCommand(2, 3, 7));
            commands.AddLast(new AddWaterCommand(2, 4, 7));
            commands.AddLast(new AddWaterCommand(2, 5, 7));
            commands.AddLast(new AddWaterCommand(2, 10, 7));
            commands.AddLast(new AddWaterCommand(2, 11, 7));
            commands.AddLast(new AddWaterCommand(2, 12, 7));
            commands.AddLast(new AddWaterCommand(2, 13, 7));
            commands.AddLast(new AddWaterCommand(2, 14, 7));
            commands.AddLast(new AddWaterCommand(2, 15, 7));
            commands.AddLast(new AddStoneWallCommand(2, 16, 7));

            commands.AddLast(new AddWaterCommand(2, 0, 8));
            commands.AddLast(new AddRockCommand(2, 2, 8));
            commands.AddLast(new AddWaterCommand(2, 3, 8));
            commands.AddLast(new AddWaterCommand(2, 4, 8));
            commands.AddLast(new AddWaterCommand(2, 5, 8));
            commands.AddLast(new AddTreeCommand(2, 6, 8));
            commands.AddLast(new AddWaterCommand(2, 9, 8));
            commands.AddLast(new AddWaterCommand(2, 10, 8));
            commands.AddLast(new AddWaterCommand(2, 11, 8));
            commands.AddLast(new AddWaterCommand(2, 12, 8));
            commands.AddLast(new AddWaterCommand(2, 13, 8));
            commands.AddLast(new AddWaterCommand(2, 14, 8));
            commands.AddLast(new AddWaterCommand(2, 15, 8));
            commands.AddLast(new AddStoneWallCommand(2, 16, 8));

            commands.AddLast(new AddStoneWallCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 3, 9));
            commands.AddLast(new AddWaterCommand(2, 4, 9));
            commands.AddLast(new AddWaterCommand(2, 5, 9));
            commands.AddLast(new AddWaterCommand(2, 6, 9));
            commands.AddLast(new AddWaterCommand(2, 7, 9));
            commands.AddLast(new AddWaterCommand(2, 8, 9));
            commands.AddLast(new AddWaterCommand(2, 9, 9));
            commands.AddLast(new AddWaterCommand(2, 10, 9));
            commands.AddLast(new AddWaterCommand(2, 11, 9));
            commands.AddLast(new AddWaterCommand(2, 12, 9));
            commands.AddLast(new AddWaterCommand(2, 13, 9));
            commands.AddLast(new AddWaterCommand(2, 14, 9));
            commands.AddLast(new AddWaterCommand(2, 15, 9));
            commands.AddLast(new AddStoneWallCommand(2, 16, 9));

            commands.AddLast(new AddStoneWallCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddWaterCommand(2, 4, 10));
            commands.AddLast(new AddWaterCommand(2, 5, 10));
            commands.AddLast(new AddWaterCommand(2, 6, 10));
            commands.AddLast(new AddWaterCommand(2, 7, 10));
            commands.AddLast(new AddWaterCommand(2, 8, 10));
            commands.AddLast(new AddWaterCommand(2, 9, 10));
            commands.AddLast(new AddWaterCommand(2, 10, 10));
            commands.AddLast(new AddWaterCommand(2, 11, 10));
            commands.AddLast(new AddWaterCommand(2, 12, 10));
            commands.AddLast(new AddWaterCommand(2, 13, 10));
            commands.AddLast(new AddWaterCommand(2, 14, 10));
            commands.AddLast(new AddWaterCommand(2, 15, 10));
            commands.AddLast(new AddStoneWallCommand(2, 16, 10));

            commands.AddLast(new AddStoneWallCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 4, 11));
            commands.AddLast(new AddWaterCommand(2, 5, 11));
            commands.AddLast(new AddWaterCommand(2, 6, 11));
            commands.AddLast(new AddWaterCommand(2, 7, 11));
            commands.AddLast(new AddWaterCommand(2, 8, 11));
            commands.AddLast(new AddWaterCommand(2, 9, 11));
            commands.AddLast(new AddWaterCommand(2, 10, 11));
            commands.AddLast(new AddWaterCommand(2, 11, 11));
            commands.AddLast(new AddWaterCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddStoneWallCommand(2, 16, 11));

            commands.AddLast(new AddStoneWallCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddStoneWallCommand(2, 16, 12));

            commands.AddLast(new AddStoneWallCommand(2, 0, 13));
            commands.AddLast(new AddStoneWallCommand(2, 1, 13));
            commands.AddLast(new AddRockCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddStoneWallCommand(2, 16, 13));

            commands.AddLast(new AddStoneWallCommand(2, 0, 14));
            commands.AddLast(new AddStoneWallCommand(2, 1, 14));
            commands.AddLast(new AddStoneWallCommand(2, 2, 14));
            commands.AddLast(new AddStoneWallCommand(2, 3, 14));
            commands.AddLast(new AddStoneWallCommand(2, 4, 14));
            commands.AddLast(new AddStoneWallCommand(2, 5, 14));
            commands.AddLast(new AddStoneWallCommand(2, 6, 14));

            commands.AddLast(new AddStoneWallCommand(2, 11, 14));
            commands.AddLast(new AddStoneWallCommand(2, 12, 14));
            commands.AddLast(new AddStoneWallCommand(2, 13, 14));
            commands.AddLast(new AddStoneWallCommand(2, 14, 14));
            commands.AddLast(new AddStoneWallCommand(2, 15, 14));
            commands.AddLast(new AddStoneWallCommand(2, 16, 14));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 9));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 9));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 9));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 9));

        }

        private void BuildScreen5(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 0, 1, 222, 184, 135));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 0, 6));
            commands.AddLast(new AddTreeCommand(2, 1, 6));
            commands.AddLast(new AddTreeCommand(2, 2, 6));

            commands.AddLast(new AddTreeCommand(2, 0, 7));
            commands.AddLast(new AddTreeCommand(2, 0, 8));



            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(4, 15, 5));
            commands.AddLast(new AddTreeCommand(4, 16, 5));

            commands.AddLast(new AddTreeCommand(4, 15, 6));
            commands.AddLast(new AddTreeCommand(4, 16, 6));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));
            commands.AddLast(new AddTreeCommand(2, 5, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 6, 11));

            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));
            commands.AddLast(new AddTreeCommand(2, 6, 12));
            commands.AddLast(new AddTreeCommand(2, 7, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));
            commands.AddLast(new AddTreeCommand(2, 7, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));
            commands.AddLast(new AddTreeCommand(2, 7, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));


            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 0));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 0));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 0));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 0));

            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 6));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 6));

            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 10));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 10));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 10));
        }

        private void BuildScreen6(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 1, 1, 222, 184, 135));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddStoneWallCommand(2, 0, 0));
            commands.AddLast(new AddStoneWallCommand(2, 1, 0));
            commands.AddLast(new AddStoneWallCommand(2, 2, 0));
            commands.AddLast(new AddStoneWallCommand(2, 3, 0));
            commands.AddLast(new AddStoneWallCommand(2, 4, 0));
            commands.AddLast(new AddStoneWallCommand(2, 5, 0));
            commands.AddLast(new AddStoneWallCommand(2, 6, 0));

            commands.AddLast(new AddStoneWallCommand(2, 0, 1));
            commands.AddLast(new AddStoneWallCommand(2, 1, 1));
            commands.AddLast(new AddStoneWallCommand(2, 2, 1));
            commands.AddLast(new AddStoneWallCommand(2, 3, 1));
            commands.AddLast(new AddStoneWallCommand(2, 4, 1));
            commands.AddLast(new AddStoneWallCommand(2, 5, 1));
            commands.AddLast(new AddStoneWallCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 0, 6));
            commands.AddLast(new AddTreeCommand(2, 1, 6));
            commands.AddLast(new AddTreeCommand(2, 2, 6));


            // Upper-right forest
            commands.AddLast(new AddStoneWallCommand(2, 11, 0));
            commands.AddLast(new AddStoneWallCommand(2, 12, 0));
            commands.AddLast(new AddStoneWallCommand(2, 13, 0));
            commands.AddLast(new AddStoneWallCommand(2, 14, 0));
            commands.AddLast(new AddStoneWallCommand(2, 15, 0));
            commands.AddLast(new AddStoneWallCommand(2, 16, 0));

            commands.AddLast(new AddStoneWallCommand(2, 11, 1));
            commands.AddLast(new AddStoneWallCommand(2, 12, 1));
            commands.AddLast(new AddStoneWallCommand(2, 13, 1));
            commands.AddLast(new AddStoneWallCommand(2, 14, 1));
            commands.AddLast(new AddStoneWallCommand(2, 15, 1));
            commands.AddLast(new AddStoneWallCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(4, 16, 5));
            commands.AddLast(new AddTreeCommand(4, 16, 6));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));
            commands.AddLast(new AddTreeCommand(2, 5, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 6, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));
            commands.AddLast(new AddTreeCommand(2, 6, 12));
            commands.AddLast(new AddTreeCommand(2, 7, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));
            commands.AddLast(new AddTreeCommand(2, 7, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));
            commands.AddLast(new AddTreeCommand(2, 7, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));


            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 11));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 11));


            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 7));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 7));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 7));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 7));

            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 13));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 13));

            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 17));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 17));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 17));
        }

        private void BuildScreen7(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 2, 1, 222, 184, 135));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddStoneWallCommand(2, 0, 0));
            commands.AddLast(new AddStoneWallCommand(2, 1, 0));
            commands.AddLast(new AddStoneWallCommand(2, 2, 0));
            commands.AddLast(new AddStoneWallCommand(2, 3, 0));
            commands.AddLast(new AddStoneWallCommand(2, 4, 0));
            commands.AddLast(new AddStoneWallCommand(2, 5, 0));
            commands.AddLast(new AddStoneWallCommand(2, 6, 0));
            commands.AddLast(new AddStoneWallCommand(2, 7, 0));
            commands.AddLast(new AddStoneWallCommand(2, 8, 0));
            commands.AddLast(new AddStoneWallCommand(2, 9, 0));
            commands.AddLast(new AddStoneWallCommand(2, 10, 0));
            commands.AddLast(new AddStoneWallCommand(2, 11, 0));
            commands.AddLast(new AddStoneWallCommand(2, 12, 0));
            commands.AddLast(new AddStoneWallCommand(2, 13, 0));
            commands.AddLast(new AddStoneWallCommand(2, 14, 0));
            commands.AddLast(new AddStoneWallCommand(2, 15, 0));
            commands.AddLast(new AddStoneWallCommand(2, 16, 0));

            commands.AddLast(new AddStoneWallCommand(2, 0, 1));
            commands.AddLast(new AddStoneWallCommand(2, 1, 1));
            commands.AddLast(new AddStoneWallCommand(2, 2, 1));
            commands.AddLast(new AddStoneWallCommand(2, 3, 1));
            commands.AddLast(new AddStoneWallCommand(2, 4, 1));
            commands.AddLast(new AddStoneWallCommand(2, 5, 1));
            commands.AddLast(new AddStoneWallCommand(2, 6, 1));
            commands.AddLast(new AddStoneWallCommand(2, 7, 1));
            commands.AddLast(new AddStoneWallCommand(2, 8, 1));
            commands.AddLast(new AddStoneWallCommand(2, 9, 1));
            commands.AddLast(new AddStoneWallCommand(2, 10, 1));
            commands.AddLast(new AddStoneWallCommand(2, 11, 1));
            commands.AddLast(new AddStoneWallCommand(2, 12, 1));
            commands.AddLast(new AddStoneWallCommand(2, 13, 1));
            commands.AddLast(new AddStoneWallCommand(2, 14, 1));
            commands.AddLast(new AddStoneWallCommand(2, 15, 1));
            commands.AddLast(new AddStoneWallCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));
            commands.AddLast(new AddTreeCommand(2, 7, 2));
            commands.AddLast(new AddTreeCommand(2, 8, 2));
            commands.AddLast(new AddTreeCommand(2, 9, 2));
            commands.AddLast(new AddTreeCommand(2, 10, 2));
            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));


            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 0, 6));
            commands.AddLast(new AddTreeCommand(2, 1, 6));
            commands.AddLast(new AddTreeCommand(2, 2, 6));



            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));




            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 0, 6));
            commands.AddLast(new AddTreeCommand(2, 1, 6));
            commands.AddLast(new AddTreeCommand(2, 2, 6));



            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));
            commands.AddLast(new AddTreeCommand(2, 5, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 6, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));
            commands.AddLast(new AddTreeCommand(2, 6, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));


            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 6));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 6));

            commands.AddLast(new AddEdgeCommand(4, 16, 5, 1, 8));
            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 8));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 8));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 8));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 12));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 12));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 12));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 12));
        }

        private void BuildScreen8(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 3, 1, 222, 184, 135));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));




            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 15, 5));
            commands.AddLast(new AddTreeCommand(2, 16, 5));

            commands.AddLast(new AddTreeCommand(2, 15, 6));
            commands.AddLast(new AddTreeCommand(2, 16, 6));

            commands.AddLast(new AddStairsCommand(2, 14, 2, 1));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));

            commands.AddLast(new AddEdgeCommand(4, 0, 5, 3, 7));
            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 7));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 7));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 7));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 3));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 3));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 3));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 3));

            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 9));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 9));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 13));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 13));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 13));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 13));
        }

        private void BuildScreen9(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 4, 1, 222, 184, 135));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 0, 6));
            commands.AddLast(new AddTreeCommand(2, 1, 6));
            commands.AddLast(new AddTreeCommand(2, 2, 6));





            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 15, 5));
            commands.AddLast(new AddTreeCommand(2, 16, 5));

            commands.AddLast(new AddTreeCommand(2, 15, 6));
            commands.AddLast(new AddTreeCommand(2, 16, 6));

            commands.AddLast(new AddTreeCommand(2, 15, 7));
            commands.AddLast(new AddTreeCommand(2, 16, 7));

            commands.AddLast(new AddTreeCommand(2, 15, 8));
            commands.AddLast(new AddTreeCommand(2, 16, 8));



            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));
            commands.AddLast(new AddTreeCommand(2, 5, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 6, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));
            commands.AddLast(new AddTreeCommand(2, 6, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));



            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));

            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 8));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 8));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 4));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 4));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 4));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 4));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 14));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 14));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 14));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 14));
        }

        private void BuildScreen10(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 0, 2, 222, 184, 135));

            commands.AddLast(new AddWaterCommand(2, 0, 0));
            commands.AddLast(new AddWaterCommand(2, 1, 0));
            commands.AddLast(new AddWaterCommand(2, 2, 0));

            commands.AddLast(new AddWaterCommand(2, 0, 1));
            commands.AddLast(new AddWaterCommand(2, 1, 1));
            commands.AddLast(new AddWaterCommand(2, 2, 1));

            commands.AddLast(new AddWaterCommand(2, 0, 2));
            commands.AddLast(new AddWaterCommand(2, 1, 2));
            commands.AddLast(new AddWaterCommand(2, 2, 2));

            commands.AddLast(new AddWaterCommand(2, 0, 3));
            commands.AddLast(new AddWaterCommand(2, 1, 3));
            commands.AddLast(new AddWaterCommand(2, 2, 3));

            commands.AddLast(new AddWaterCommand(2, 0, 4));
            commands.AddLast(new AddWaterCommand(2, 1, 4));
            commands.AddLast(new AddWaterCommand(2, 2, 4));

            commands.AddLast(new AddWaterCommand(2, 0, 5));
            commands.AddLast(new AddWaterCommand(2, 1, 5));
            commands.AddLast(new AddWaterCommand(2, 2, 5));

            commands.AddLast(new AddWaterCommand(2, 0, 6));
            commands.AddLast(new AddWaterCommand(2, 1, 6));
            commands.AddLast(new AddWaterCommand(2, 2, 6));

            commands.AddLast(new AddWaterCommand(2, 0, 7));
            commands.AddLast(new AddWaterCommand(2, 1, 7));
            commands.AddLast(new AddWaterCommand(2, 2, 7));

            commands.AddLast(new AddWaterCommand(2, 0, 8));
            commands.AddLast(new AddWaterCommand(2, 1, 8));
            commands.AddLast(new AddWaterCommand(2, 2, 8));

            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 1, 9));
            commands.AddLast(new AddWaterCommand(2, 2, 9));

            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 1, 10));
            commands.AddLast(new AddWaterCommand(2, 2, 10));

            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 1, 11));
            commands.AddLast(new AddWaterCommand(2, 2, 11));

            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 1, 12));
            commands.AddLast(new AddWaterCommand(2, 2, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));

            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));
            commands.AddLast(new AddTreeCommand(2, 7, 0));

            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));

            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));


            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 5));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 5));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 5));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 5));

            commands.AddLast(new AddEdgeCommand(4, 16, 5, 1, 12));
            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 12));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 12));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 12));



            commands.AddLast(new AddEdgeCommand(4, 3, 14, 2, 15));
            commands.AddLast(new AddEdgeCommand(4, 4, 14, 2, 15));
            commands.AddLast(new AddEdgeCommand(4, 5, 14, 2, 15));
            commands.AddLast(new AddEdgeCommand(4, 6, 14, 2, 15));
            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 15));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 15));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 15));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 15));


        }

        private void BuildScreen11(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 1, 2, 222, 184, 135));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));
            commands.AddLast(new AddTreeCommand(2, 7, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));




            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 16, 5));

            commands.AddLast(new AddTreeCommand(2, 16, 6));



            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));





            commands.AddLast(new AddEdgeCommand(4, 0, 5, 3, 10));
            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 10));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 10));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 10));

            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 6));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 6));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 6));

            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 12));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 12));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 16));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 16));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 16));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 16));
        }

        private void BuildScreen12(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 2, 2, 222, 184, 135));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));     
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddStairsCommand(2, 4, 4, 8));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 0, 6));
            commands.AddLast(new AddTreeCommand(2, 1, 6));
            commands.AddLast(new AddTreeCommand(2, 2, 6));


            // Upper - right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(4, 16, 5));
            commands.AddLast(new AddTreeCommand(4, 16, 6));


            // Lower - left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));
            commands.AddLast(new AddTreeCommand(2, 5, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 6, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));
            commands.AddLast(new AddTreeCommand(2, 6, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


            // Lower - right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));



            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 11));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 11));


            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 7));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 7));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 7));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 7));

            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 13));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 13));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 17));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 17));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 17));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 17));
        }

        private void BuildScreen13(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 3, 2, 222, 184, 135));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 0, 6));
            commands.AddLast(new AddTreeCommand(2, 1, 6));
            commands.AddLast(new AddTreeCommand(2, 2, 6));


            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));
            commands.AddLast(new AddTreeCommand(2, 5, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 6, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));
            commands.AddLast(new AddTreeCommand(2, 6, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));


            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 16));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 16));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 11));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 11));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 11));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 11));

            commands.AddLast(new AddEdgeCommand(4, 16, 5, 1, 14));
            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 14));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 14));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 14));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 18));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 18));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 18));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 18));
        }

        private void BuildScreen14(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 4, 2, 222, 184, 135));

            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 16, 5));

            commands.AddLast(new AddTreeCommand(2, 7, 6));
            commands.AddLast(new AddTreeCommand(2, 8, 6));
            commands.AddLast(new AddTreeCommand(2, 9, 6));
            commands.AddLast(new AddTreeCommand(2, 16, 6));

//            commands.AddLast(new AddTreeCommand(2, 7, 7));
            commands.AddLast(new AddStairsCommand(2, 8, 7, 5));
            commands.AddLast(new AddTreeCommand(2, 9, 7));
            commands.AddLast(new AddTreeCommand(2, 16, 7));

            commands.AddLast(new AddTreeCommand(2, 7, 8));
            commands.AddLast(new AddTreeCommand(2, 8, 8));
            commands.AddLast(new AddTreeCommand(2, 9, 8));
            commands.AddLast(new AddTreeCommand(2, 16, 8));

            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));

            commands.AddLast(new AddEdgeCommand(4, 0, 5, 3, 13));
            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 13));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 13));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 13));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 9));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 9));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 9));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 9));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 19));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 19));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 19));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 19));
        }

        private void BuildScreen15(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 0, 3, 222, 184, 135));

            commands.AddLast(new AddWaterCommand(2, 0, 0));
            commands.AddLast(new AddWaterCommand(2, 1, 0));
            commands.AddLast(new AddWaterCommand(2, 2, 0));

            commands.AddLast(new AddWaterCommand(2, 0, 1));
            commands.AddLast(new AddWaterCommand(2, 1, 1));
            commands.AddLast(new AddWaterCommand(2, 2, 1));

            commands.AddLast(new AddWaterCommand(2, 0, 2));
            commands.AddLast(new AddWaterCommand(2, 1, 2));
            commands.AddLast(new AddWaterCommand(2, 2, 2));

            commands.AddLast(new AddWaterCommand(2, 0, 3));
            commands.AddLast(new AddWaterCommand(2, 1, 3));
            commands.AddLast(new AddWaterCommand(2, 2, 3));

            commands.AddLast(new AddWaterCommand(2, 0, 4));
            commands.AddLast(new AddWaterCommand(2, 1, 4));
            commands.AddLast(new AddWaterCommand(2, 2, 4));
            commands.AddLast(new AddWaterCommand(2, 3, 4));

            commands.AddLast(new AddWaterCommand(2, 0, 5));
            commands.AddLast(new AddWaterCommand(2, 1, 5));
            commands.AddLast(new AddWaterCommand(2, 2, 5));
            commands.AddLast(new AddWaterCommand(2, 3, 5));
            commands.AddLast(new AddWaterCommand(2, 4, 5));

            commands.AddLast(new AddWaterCommand(2, 0, 6));
            commands.AddLast(new AddWaterCommand(2, 1, 6));
            commands.AddLast(new AddWaterCommand(2, 2, 6));
            commands.AddLast(new AddWaterCommand(2, 3, 6));
            commands.AddLast(new AddWaterCommand(2, 4, 6));
            commands.AddLast(new AddWaterCommand(2, 5, 6));

            commands.AddLast(new AddWaterCommand(2, 0, 7));
            commands.AddLast(new AddWaterCommand(2, 1, 7));
            commands.AddLast(new AddWaterCommand(2, 2, 7));
            commands.AddLast(new AddWaterCommand(2, 3, 7));
            commands.AddLast(new AddWaterCommand(2, 4, 7));
            commands.AddLast(new AddWaterCommand(2, 5, 7));
            commands.AddLast(new AddWaterCommand(2, 6, 7));

            commands.AddLast(new AddWaterCommand(2, 0, 8));
            commands.AddLast(new AddWaterCommand(2, 1, 8));
            commands.AddLast(new AddWaterCommand(2, 2, 8));
            commands.AddLast(new AddWaterCommand(2, 3, 8));
            commands.AddLast(new AddWaterCommand(2, 4, 8));
            commands.AddLast(new AddWaterCommand(2, 5, 8));
            commands.AddLast(new AddWaterCommand(2, 6, 8));
            commands.AddLast(new AddWaterCommand(2, 7, 8));

            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 1, 9));
            commands.AddLast(new AddWaterCommand(2, 2, 9));
            commands.AddLast(new AddWaterCommand(2, 3, 9));
            commands.AddLast(new AddWaterCommand(2, 4, 9));
            commands.AddLast(new AddWaterCommand(2, 5, 9));
            commands.AddLast(new AddWaterCommand(2, 6, 9));
            commands.AddLast(new AddWaterCommand(2, 7, 9));

            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 1, 10));
            commands.AddLast(new AddWaterCommand(2, 2, 10));
            commands.AddLast(new AddWaterCommand(2, 3, 10));
            commands.AddLast(new AddWaterCommand(2, 4, 10));
            commands.AddLast(new AddWaterCommand(2, 5, 10));
            commands.AddLast(new AddWaterCommand(2, 6, 10));
            commands.AddLast(new AddWaterCommand(2, 7, 10));

            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 1, 11));
            commands.AddLast(new AddWaterCommand(2, 2, 11));
            commands.AddLast(new AddWaterCommand(2, 3, 11));
            commands.AddLast(new AddWaterCommand(2, 4, 11));
            commands.AddLast(new AddWaterCommand(2, 5, 11));
            commands.AddLast(new AddWaterCommand(2, 6, 11));
            commands.AddLast(new AddWaterCommand(2, 7, 11));

            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 1, 12));
            commands.AddLast(new AddWaterCommand(2, 2, 12));
            commands.AddLast(new AddWaterCommand(2, 3, 12));
            commands.AddLast(new AddWaterCommand(2, 4, 12));
            commands.AddLast(new AddWaterCommand(2, 5, 12));
            commands.AddLast(new AddWaterCommand(2, 6, 12));
            commands.AddLast(new AddWaterCommand(2, 7, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));
            commands.AddLast(new AddWaterCommand(2, 3, 13));
            commands.AddLast(new AddWaterCommand(2, 4, 13));
            commands.AddLast(new AddWaterCommand(2, 5, 13));
            commands.AddLast(new AddWaterCommand(2, 6, 13));
            commands.AddLast(new AddWaterCommand(2, 7, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddWaterCommand(2, 3, 14));
            commands.AddLast(new AddWaterCommand(2, 4, 14));
            commands.AddLast(new AddWaterCommand(2, 5, 14));
            commands.AddLast(new AddWaterCommand(2, 6, 14));
            commands.AddLast(new AddWaterCommand(2, 7, 14));





            commands.AddLast(new AddWaterCommand(2, 0, 6));
            commands.AddLast(new AddWaterCommand(2, 1, 6));
            commands.AddLast(new AddWaterCommand(2, 2, 6));

            commands.AddLast(new AddWaterCommand(2, 0, 7));
            commands.AddLast(new AddWaterCommand(2, 1, 7));
            commands.AddLast(new AddWaterCommand(2, 2, 7));

            commands.AddLast(new AddWaterCommand(2, 0, 8));
            commands.AddLast(new AddWaterCommand(2, 1, 8));
            commands.AddLast(new AddWaterCommand(2, 2, 8));

            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 1, 9));
            commands.AddLast(new AddWaterCommand(2, 2, 9));

            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 1, 10));
            commands.AddLast(new AddWaterCommand(2, 2, 10));

            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 1, 11));
            commands.AddLast(new AddWaterCommand(2, 2, 11));

            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 1, 12));
            commands.AddLast(new AddWaterCommand(2, 2, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));

            /*
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));
            commands.AddLast(new AddTreeCommand(2, 7, 0));

            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));

            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            */


            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 15, 5));
            commands.AddLast(new AddTreeCommand(2, 16, 5));

            commands.AddLast(new AddTreeCommand(2, 15, 6));
            commands.AddLast(new AddTreeCommand(2, 16, 6));

            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));

            commands.AddLast(new AddEdgeCommand(4, 3, 0, 0, 10));
            commands.AddLast(new AddEdgeCommand(4, 4, 0, 0, 10));
            commands.AddLast(new AddEdgeCommand(4, 5, 0, 0, 10));
            commands.AddLast(new AddEdgeCommand(4, 6, 0, 0, 10));
            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 10));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 10));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 10));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 10));


            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 16));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 16));

            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 20));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 20));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 20));


        }

        private void BuildScreen16(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 1, 3, 222, 184, 135));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 0, 6));
            commands.AddLast(new AddTreeCommand(2, 1, 6));
            commands.AddLast(new AddTreeCommand(2, 2, 6));


            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(4, 15, 5));
            commands.AddLast(new AddTreeCommand(4, 16, 5));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));
            commands.AddLast(new AddTreeCommand(2, 5, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 6, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));
            commands.AddLast(new AddTreeCommand(2, 6, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));


            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 15));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 15));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 11));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 11));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 11));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 11));

            commands.AddLast(new AddEdgeCommand(4, 16, 5, 1, 17));
            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 17));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 17));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 17));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 21));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 21));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 21));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 21));
        }

        private void BuildScreen17(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 2, 3, 222, 184, 135));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));



            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));
            commands.AddLast(new AddTreeCommand(2, 5, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 6, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));
            commands.AddLast(new AddTreeCommand(2, 6, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));


            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 16));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 16));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 16));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 12));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 12));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 12));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 12));

            commands.AddLast(new AddEdgeCommand(4, 16, 5, 1, 18));
            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 18));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 18));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 18));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 22));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 22));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 22));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 22));
        }

        private void BuildScreen18(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 3, 3, 222, 184, 135));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));



            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));



            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));


            commands.AddLast(new AddEdgeCommand(4, 0, 5, 3, 17));
            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 17));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 17));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 17));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 13));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 13));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 13));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 13));

            commands.AddLast(new AddEdgeCommand(4, 16, 4, 1, 19));
            commands.AddLast(new AddEdgeCommand(4, 16, 5, 1, 19));
            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 19));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 19));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 19));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 23));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 23));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 23));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 23));
        }

        private void BuildScreen19(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 4, 3, 222, 184, 135));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));



            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 12, 5));
            commands.AddLast(new AddTreeCommand(2, 13, 5));
            commands.AddLast(new AddTreeCommand(2, 14, 5));
            commands.AddLast(new AddTreeCommand(2, 15, 5));
            commands.AddLast(new AddTreeCommand(2, 16, 5));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 15, 5));
            commands.AddLast(new AddTreeCommand(2, 16, 5));

            commands.AddLast(new AddTreeCommand(2, 15, 6));
            commands.AddLast(new AddTreeCommand(2, 16, 6));

            commands.AddLast(new AddTreeCommand(2, 15, 7));
            commands.AddLast(new AddTreeCommand(2, 16, 7));

            commands.AddLast(new AddTreeCommand(2, 15, 8));
            commands.AddLast(new AddTreeCommand(2, 16, 8));

            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));

            commands.AddLast(new AddEdgeCommand(4, 0, 5, 3, 18));
            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 18));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 18));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 18));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 14));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 14));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 14));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 14));

            commands.AddLast(new AddEdgeCommand(4, 5, 14, 2, 24));
            commands.AddLast(new AddEdgeCommand(4, 6, 14, 2, 24));
            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 24));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 24));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 24));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 24));
            commands.AddLast(new AddEdgeCommand(4, 11, 14, 2, 24));
        }

        private void BuildScreen20(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 0, 4, 222, 184, 135));

            commands.AddLast(new AddWaterCommand(2, 0, 0));
            commands.AddLast(new AddWaterCommand(2, 1, 0));
            commands.AddLast(new AddWaterCommand(2, 2, 0));
            commands.AddLast(new AddWaterCommand(2, 3, 0));
            commands.AddLast(new AddWaterCommand(2, 4, 0));
            commands.AddLast(new AddWaterCommand(2, 5, 0));
            commands.AddLast(new AddWaterCommand(2, 6, 0));
            commands.AddLast(new AddWaterCommand(2, 7, 0));

            commands.AddLast(new AddWaterCommand(2, 0, 1));
            commands.AddLast(new AddWaterCommand(2, 1, 1));
            commands.AddLast(new AddWaterCommand(2, 2, 1));
            commands.AddLast(new AddWaterCommand(2, 3, 1));
            commands.AddLast(new AddWaterCommand(2, 4, 1));
            commands.AddLast(new AddWaterCommand(2, 5, 1));
            commands.AddLast(new AddWaterCommand(2, 6, 1));
            commands.AddLast(new AddWaterCommand(2, 7, 1));

            commands.AddLast(new AddWaterCommand(2, 0, 2));
            commands.AddLast(new AddWaterCommand(2, 1, 2));
            commands.AddLast(new AddWaterCommand(2, 2, 2));
            commands.AddLast(new AddWaterCommand(2, 3, 2));
            commands.AddLast(new AddWaterCommand(2, 4, 2));
            commands.AddLast(new AddWaterCommand(2, 5, 2));
            commands.AddLast(new AddWaterCommand(2, 6, 2));
            commands.AddLast(new AddWaterCommand(2, 7, 2));

            commands.AddLast(new AddWaterCommand(2, 0, 3));
            commands.AddLast(new AddWaterCommand(2, 1, 3));
            commands.AddLast(new AddWaterCommand(2, 2, 3));
            commands.AddLast(new AddWaterCommand(2, 3, 3));
            commands.AddLast(new AddWaterCommand(2, 4, 3));
            commands.AddLast(new AddWaterCommand(2, 5, 3));
            commands.AddLast(new AddWaterCommand(2, 6, 3));
            commands.AddLast(new AddWaterCommand(2, 7, 3));

            commands.AddLast(new AddWaterCommand(2, 0, 4));
            commands.AddLast(new AddWaterCommand(2, 1, 4));
            commands.AddLast(new AddWaterCommand(2, 2, 4));
            commands.AddLast(new AddWaterCommand(2, 3, 4));
            commands.AddLast(new AddWaterCommand(2, 4, 4));
            commands.AddLast(new AddWaterCommand(2, 5, 4));
            commands.AddLast(new AddWaterCommand(2, 6, 4));
            commands.AddLast(new AddWaterCommand(2, 7, 4));

            commands.AddLast(new AddWaterCommand(2, 0, 5));
            commands.AddLast(new AddWaterCommand(2, 1, 5));
            commands.AddLast(new AddWaterCommand(2, 2, 5));
            commands.AddLast(new AddWaterCommand(2, 3, 5));
            commands.AddLast(new AddWaterCommand(2, 4, 5));
            commands.AddLast(new AddWaterCommand(2, 5, 5));
            commands.AddLast(new AddWaterCommand(2, 6, 5));
            commands.AddLast(new AddWaterCommand(2, 7, 5));

            commands.AddLast(new AddWaterCommand(2, 0, 6));
            commands.AddLast(new AddWaterCommand(2, 1, 6));
            commands.AddLast(new AddWaterCommand(2, 2, 6));
            commands.AddLast(new AddWaterCommand(2, 3, 6));
            commands.AddLast(new AddWaterCommand(2, 4, 6));
            commands.AddLast(new AddWaterCommand(2, 5, 6));
            commands.AddLast(new AddWaterCommand(2, 6, 6));
            commands.AddLast(new AddWaterCommand(2, 7, 6));

            commands.AddLast(new AddWaterCommand(2, 0, 7));
            commands.AddLast(new AddWaterCommand(2, 1, 7));
            commands.AddLast(new AddWaterCommand(2, 2, 7));
            commands.AddLast(new AddWaterCommand(2, 3, 7));
            commands.AddLast(new AddWaterCommand(2, 4, 7));
            commands.AddLast(new AddWaterCommand(2, 5, 7));
            commands.AddLast(new AddWaterCommand(2, 6, 7));
            commands.AddLast(new AddWaterCommand(2, 7, 7));

            commands.AddLast(new AddWaterCommand(2, 0, 8));
            commands.AddLast(new AddWaterCommand(2, 1, 8));
            commands.AddLast(new AddWaterCommand(2, 2, 8));
            commands.AddLast(new AddWaterCommand(2, 3, 8));
            commands.AddLast(new AddWaterCommand(2, 4, 8));
            commands.AddLast(new AddWaterCommand(2, 5, 8));
            commands.AddLast(new AddWaterCommand(2, 6, 8));
            commands.AddLast(new AddWaterCommand(2, 7, 8));




            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));



            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 1, 9));
            commands.AddLast(new AddWaterCommand(2, 2, 9));
            commands.AddLast(new AddWaterCommand(2, 3, 9));
            commands.AddLast(new AddWaterCommand(2, 4, 9));
            commands.AddLast(new AddWaterCommand(2, 5, 9));
            commands.AddLast(new AddWaterCommand(2, 6, 9));
            commands.AddLast(new AddWaterCommand(2, 7, 9));
            commands.AddLast(new AddWaterCommand(2, 8, 9));
            commands.AddLast(new AddWaterCommand(2, 9, 9));
            commands.AddLast(new AddWaterCommand(2, 10, 9));
            commands.AddLast(new AddWaterCommand(2, 11, 9));
            commands.AddLast(new AddWaterCommand(2, 12, 9));
            commands.AddLast(new AddWaterCommand(2, 13, 9));
            commands.AddLast(new AddWaterCommand(2, 14, 9));
            commands.AddLast(new AddWaterCommand(2, 15, 9));
            commands.AddLast(new AddWaterCommand(2, 16, 9));

            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 1, 10));
            commands.AddLast(new AddWaterCommand(2, 2, 10));
            commands.AddLast(new AddWaterCommand(2, 3, 10));
            commands.AddLast(new AddWaterCommand(2, 4, 10));
            commands.AddLast(new AddWaterCommand(2, 5, 10));
            commands.AddLast(new AddWaterCommand(2, 6, 10));
            commands.AddLast(new AddWaterCommand(2, 7, 10));
            commands.AddLast(new AddWaterCommand(2, 8, 10));
            commands.AddLast(new AddWaterCommand(2, 9, 10));
            commands.AddLast(new AddWaterCommand(2, 10, 10));
            commands.AddLast(new AddWaterCommand(2, 11, 10));
            commands.AddLast(new AddWaterCommand(2, 12, 10));
            commands.AddLast(new AddWaterCommand(2, 13, 10));
            commands.AddLast(new AddWaterCommand(2, 14, 10));
            commands.AddLast(new AddWaterCommand(2, 15, 10));
            commands.AddLast(new AddWaterCommand(2, 16, 10));

            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 1, 11));
            commands.AddLast(new AddWaterCommand(2, 2, 11));
            commands.AddLast(new AddWaterCommand(2, 3, 11));
            commands.AddLast(new AddWaterCommand(2, 4, 11));
            commands.AddLast(new AddWaterCommand(2, 5, 11));
            commands.AddLast(new AddWaterCommand(2, 6, 11));
            commands.AddLast(new AddWaterCommand(2, 7, 11));
            commands.AddLast(new AddWaterCommand(2, 8, 11));
            commands.AddLast(new AddWaterCommand(2, 9, 11));
            commands.AddLast(new AddWaterCommand(2, 10, 11));
            commands.AddLast(new AddWaterCommand(2, 11, 11));
            commands.AddLast(new AddWaterCommand(2, 12, 11));
            commands.AddLast(new AddWaterCommand(2, 13, 11));
            commands.AddLast(new AddWaterCommand(2, 14, 11));
            commands.AddLast(new AddWaterCommand(2, 15, 11));
            commands.AddLast(new AddWaterCommand(2, 16, 11));



            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 1, 12));
            commands.AddLast(new AddWaterCommand(2, 2, 12));
            commands.AddLast(new AddWaterCommand(2, 3, 12));
            commands.AddLast(new AddWaterCommand(2, 4, 12));
            commands.AddLast(new AddWaterCommand(2, 5, 12));
            commands.AddLast(new AddWaterCommand(2, 6, 12));
            commands.AddLast(new AddWaterCommand(2, 7, 12));
            commands.AddLast(new AddWaterCommand(2, 8, 12));
            commands.AddLast(new AddWaterCommand(2, 9, 12));
            commands.AddLast(new AddWaterCommand(2, 10, 12));
            commands.AddLast(new AddWaterCommand(2, 11, 12));
            commands.AddLast(new AddWaterCommand(2, 12, 12));
            commands.AddLast(new AddWaterCommand(2, 13, 12));
            commands.AddLast(new AddWaterCommand(2, 14, 12));
            commands.AddLast(new AddWaterCommand(2, 15, 12));
            commands.AddLast(new AddWaterCommand(2, 16, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));
            commands.AddLast(new AddWaterCommand(2, 3, 13));
            commands.AddLast(new AddWaterCommand(2, 4, 13));
            commands.AddLast(new AddWaterCommand(2, 5, 13));
            commands.AddLast(new AddWaterCommand(2, 6, 13));
            commands.AddLast(new AddWaterCommand(2, 7, 13));
            commands.AddLast(new AddWaterCommand(2, 8, 13));
            commands.AddLast(new AddWaterCommand(2, 9, 13));
            commands.AddLast(new AddWaterCommand(2, 10, 13));
            commands.AddLast(new AddWaterCommand(2, 11, 13));
            commands.AddLast(new AddWaterCommand(2, 12, 13));
            commands.AddLast(new AddWaterCommand(2, 13, 13));
            commands.AddLast(new AddWaterCommand(2, 14, 13));
            commands.AddLast(new AddWaterCommand(2, 15, 13));
            commands.AddLast(new AddWaterCommand(2, 16, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddWaterCommand(2, 3, 14));
            commands.AddLast(new AddWaterCommand(2, 4, 14));
            commands.AddLast(new AddWaterCommand(2, 5, 14));
            commands.AddLast(new AddWaterCommand(2, 6, 14));
            commands.AddLast(new AddWaterCommand(2, 7, 14));
            commands.AddLast(new AddWaterCommand(2, 8, 14));
            commands.AddLast(new AddWaterCommand(2, 9, 14));
            commands.AddLast(new AddWaterCommand(2, 10, 14));
            commands.AddLast(new AddWaterCommand(2, 11, 14));
            commands.AddLast(new AddWaterCommand(2, 12, 14));
            commands.AddLast(new AddWaterCommand(2, 13, 14));
            commands.AddLast(new AddWaterCommand(2, 14, 14));
            commands.AddLast(new AddWaterCommand(2, 15, 14));
            commands.AddLast(new AddWaterCommand(2, 16, 14));



            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 15));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 15));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 15));

            commands.AddLast(new AddEdgeCommand(4, 16, 5, 1, 21));
            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 21));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 21));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 21));

        }

        private void BuildScreen21(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 1, 4, 222, 184, 135));

            // Upper-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddStairsCommand(2, 4, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));

            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 2, 6));


            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));




            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 1, 9));
            commands.AddLast(new AddWaterCommand(2, 2, 9));
            commands.AddLast(new AddWaterCommand(2, 3, 9));
            commands.AddLast(new AddWaterCommand(2, 4, 9));
            commands.AddLast(new AddWaterCommand(2, 5, 9));
            commands.AddLast(new AddWaterCommand(2, 6, 9));
            commands.AddLast(new AddWaterCommand(2, 7, 9));
            commands.AddLast(new AddWaterCommand(2, 8, 9));
            commands.AddLast(new AddWaterCommand(2, 9, 9));
            commands.AddLast(new AddWaterCommand(2, 10, 9));
            commands.AddLast(new AddWaterCommand(2, 11, 9));
            commands.AddLast(new AddWaterCommand(2, 12, 9));
            commands.AddLast(new AddWaterCommand(2, 13, 9));
            commands.AddLast(new AddWaterCommand(2, 14, 9));
            commands.AddLast(new AddWaterCommand(2, 15, 9));
            commands.AddLast(new AddWaterCommand(2, 16, 9));

            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 1, 10));
            commands.AddLast(new AddWaterCommand(2, 2, 10));
            commands.AddLast(new AddWaterCommand(2, 3, 10));
            commands.AddLast(new AddWaterCommand(2, 4, 10));
            commands.AddLast(new AddWaterCommand(2, 5, 10));
            commands.AddLast(new AddWaterCommand(2, 6, 10));
            commands.AddLast(new AddWaterCommand(2, 7, 10));
            commands.AddLast(new AddWaterCommand(2, 8, 10));
            commands.AddLast(new AddWaterCommand(2, 9, 10));
            commands.AddLast(new AddWaterCommand(2, 10, 10));
            commands.AddLast(new AddWaterCommand(2, 11, 10));
            commands.AddLast(new AddWaterCommand(2, 12, 10));
            commands.AddLast(new AddWaterCommand(2, 13, 10));
            commands.AddLast(new AddWaterCommand(2, 14, 10));
            commands.AddLast(new AddWaterCommand(2, 15, 10));
            commands.AddLast(new AddWaterCommand(2, 16, 10));

            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 1, 11));
            commands.AddLast(new AddWaterCommand(2, 2, 11));
            commands.AddLast(new AddWaterCommand(2, 3, 11));
            commands.AddLast(new AddWaterCommand(2, 4, 11));
            commands.AddLast(new AddWaterCommand(2, 5, 11));
            commands.AddLast(new AddWaterCommand(2, 6, 11));
            commands.AddLast(new AddWaterCommand(2, 7, 11));
            commands.AddLast(new AddWaterCommand(2, 8, 11));
            commands.AddLast(new AddWaterCommand(2, 9, 11));
            commands.AddLast(new AddWaterCommand(2, 10, 11));
            commands.AddLast(new AddWaterCommand(2, 11, 11));
            commands.AddLast(new AddWaterCommand(2, 12, 11));
            commands.AddLast(new AddWaterCommand(2, 13, 11));
            commands.AddLast(new AddWaterCommand(2, 14, 11));
            commands.AddLast(new AddWaterCommand(2, 15, 11));
            commands.AddLast(new AddWaterCommand(2, 16, 11));



            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 1, 12));
            commands.AddLast(new AddWaterCommand(2, 2, 12));
            commands.AddLast(new AddWaterCommand(2, 3, 12));
            commands.AddLast(new AddWaterCommand(2, 4, 12));
            commands.AddLast(new AddWaterCommand(2, 5, 12));
            commands.AddLast(new AddWaterCommand(2, 6, 12));
            commands.AddLast(new AddWaterCommand(2, 7, 12));
            commands.AddLast(new AddWaterCommand(2, 8, 12));
            commands.AddLast(new AddWaterCommand(2, 9, 12));
            commands.AddLast(new AddWaterCommand(2, 10, 12));
            commands.AddLast(new AddWaterCommand(2, 11, 12));
            commands.AddLast(new AddWaterCommand(2, 12, 12));
            commands.AddLast(new AddWaterCommand(2, 13, 12));
            commands.AddLast(new AddWaterCommand(2, 14, 12));
            commands.AddLast(new AddWaterCommand(2, 15, 12));
            commands.AddLast(new AddWaterCommand(2, 16, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));
            commands.AddLast(new AddWaterCommand(2, 3, 13));
            commands.AddLast(new AddWaterCommand(2, 4, 13));
            commands.AddLast(new AddWaterCommand(2, 5, 13));
            commands.AddLast(new AddWaterCommand(2, 6, 13));
            commands.AddLast(new AddWaterCommand(2, 7, 13));
            commands.AddLast(new AddWaterCommand(2, 8, 13));
            commands.AddLast(new AddWaterCommand(2, 9, 13));
            commands.AddLast(new AddWaterCommand(2, 10, 13));
            commands.AddLast(new AddWaterCommand(2, 11, 13));
            commands.AddLast(new AddWaterCommand(2, 12, 13));
            commands.AddLast(new AddWaterCommand(2, 13, 13));
            commands.AddLast(new AddWaterCommand(2, 14, 13));
            commands.AddLast(new AddWaterCommand(2, 15, 13));
            commands.AddLast(new AddWaterCommand(2, 16, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddWaterCommand(2, 3, 14));
            commands.AddLast(new AddWaterCommand(2, 4, 14));
            commands.AddLast(new AddWaterCommand(2, 5, 14));
            commands.AddLast(new AddWaterCommand(2, 6, 14));
            commands.AddLast(new AddWaterCommand(2, 7, 14));
            commands.AddLast(new AddWaterCommand(2, 8, 14));
            commands.AddLast(new AddWaterCommand(2, 9, 14));
            commands.AddLast(new AddWaterCommand(2, 10, 14));
            commands.AddLast(new AddWaterCommand(2, 11, 14));
            commands.AddLast(new AddWaterCommand(2, 12, 14));
            commands.AddLast(new AddWaterCommand(2, 13, 14));
            commands.AddLast(new AddWaterCommand(2, 14, 14));
            commands.AddLast(new AddWaterCommand(2, 15, 14));
            commands.AddLast(new AddWaterCommand(2, 16, 14));

            commands.AddLast(new AddEdgeCommand(4, 0, 5, 3, 20));
            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 20));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 20));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 20));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 16));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 16));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 16));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 16));

            commands.AddLast(new AddEdgeCommand(4, 16, 5, 1, 22));
            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 22));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 22));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 22));

        }

        private void BuildScreen22(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 2, 4, 222, 184, 135));

            // Upper-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));






            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 1, 9));
            commands.AddLast(new AddWaterCommand(2, 2, 9));
            commands.AddLast(new AddWaterCommand(2, 3, 9));

            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 1, 10));
            commands.AddLast(new AddWaterCommand(2, 2, 10));
            commands.AddLast(new AddWaterCommand(2, 3, 10));

            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 1, 11));
            commands.AddLast(new AddWaterCommand(2, 2, 11));
            commands.AddLast(new AddWaterCommand(2, 3, 11));

            commands.AddLast(new AddWaterCommand(2, 13, 9));
            commands.AddLast(new AddWaterCommand(2, 14, 9));
            commands.AddLast(new AddWaterCommand(2, 15, 9));
            commands.AddLast(new AddWaterCommand(2, 16, 9));

            commands.AddLast(new AddWaterCommand(2, 13, 10));
            commands.AddLast(new AddWaterCommand(2, 14, 10));
            commands.AddLast(new AddWaterCommand(2, 15, 10));
            commands.AddLast(new AddWaterCommand(2, 16, 10));

            commands.AddLast(new AddWaterCommand(2, 13, 11));
            commands.AddLast(new AddWaterCommand(2, 14, 11));
            commands.AddLast(new AddWaterCommand(2, 15, 11));
            commands.AddLast(new AddWaterCommand(2, 16, 11));


            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 1, 12));
            commands.AddLast(new AddWaterCommand(2, 2, 12));
            commands.AddLast(new AddWaterCommand(2, 3, 12));
            commands.AddLast(new AddWaterCommand(2, 4, 12));
            commands.AddLast(new AddWaterCommand(2, 5, 12));
            commands.AddLast(new AddWaterCommand(2, 6, 12));
            commands.AddLast(new AddWaterCommand(2, 7, 12));
            commands.AddLast(new AddWaterCommand(2, 8, 12));
            commands.AddLast(new AddWaterCommand(2, 9, 12));
            commands.AddLast(new AddWaterCommand(2, 10, 12));
            commands.AddLast(new AddWaterCommand(2, 11, 12));
            commands.AddLast(new AddWaterCommand(2, 12, 12));
            commands.AddLast(new AddWaterCommand(2, 13, 12));
            commands.AddLast(new AddWaterCommand(2, 14, 12));
            commands.AddLast(new AddWaterCommand(2, 15, 12));
            commands.AddLast(new AddWaterCommand(2, 16, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));
            commands.AddLast(new AddWaterCommand(2, 3, 13));
            commands.AddLast(new AddWaterCommand(2, 4, 13));
            commands.AddLast(new AddWaterCommand(2, 5, 13));
            commands.AddLast(new AddWaterCommand(2, 6, 13));
            commands.AddLast(new AddWaterCommand(2, 7, 13));
            commands.AddLast(new AddWaterCommand(2, 8, 13));
            commands.AddLast(new AddWaterCommand(2, 9, 13));
            commands.AddLast(new AddWaterCommand(2, 10, 13));
            commands.AddLast(new AddWaterCommand(2, 11, 13));
            commands.AddLast(new AddWaterCommand(2, 12, 13));
            commands.AddLast(new AddWaterCommand(2, 13, 13));
            commands.AddLast(new AddWaterCommand(2, 14, 13));
            commands.AddLast(new AddWaterCommand(2, 15, 13));
            commands.AddLast(new AddWaterCommand(2, 16, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddWaterCommand(2, 3, 14));
            commands.AddLast(new AddWaterCommand(2, 4, 14));
            commands.AddLast(new AddWaterCommand(2, 5, 14));
            commands.AddLast(new AddWaterCommand(2, 6, 14));
            commands.AddLast(new AddWaterCommand(2, 7, 14));
            commands.AddLast(new AddWaterCommand(2, 8, 14));
            commands.AddLast(new AddWaterCommand(2, 9, 14));
            commands.AddLast(new AddWaterCommand(2, 10, 14));
            commands.AddLast(new AddWaterCommand(2, 11, 14));
            commands.AddLast(new AddWaterCommand(2, 12, 14));
            commands.AddLast(new AddWaterCommand(2, 13, 14));
            commands.AddLast(new AddWaterCommand(2, 14, 14));
            commands.AddLast(new AddWaterCommand(2, 15, 14));
            commands.AddLast(new AddWaterCommand(2, 16, 14));


            commands.AddLast(new AddEdgeCommand(4, 0, 5, 3, 21));
            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 21));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 21));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 21));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 17));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 17));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 17));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 17));

            commands.AddLast(new AddEdgeCommand(4, 16, 5, 1, 23));
            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 23));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 23));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 23));

        }

        private void BuildScreen23(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 3, 4, 222, 184, 135));

            // Upper-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddStairsCommand(2, 5, 2, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));


            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 12, 5));
            commands.AddLast(new AddTreeCommand(2, 13, 5));
            commands.AddLast(new AddTreeCommand(2, 14, 5));
            commands.AddLast(new AddTreeCommand(2, 15, 5));
            commands.AddLast(new AddTreeCommand(2, 16, 5));


            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 0, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));
            commands.AddLast(new AddWaterCommand(2, 3, 13));
            commands.AddLast(new AddWaterCommand(2, 4, 13));
            commands.AddLast(new AddWaterCommand(2, 5, 13));
            commands.AddLast(new AddWaterCommand(2, 6, 13));
            commands.AddLast(new AddWaterCommand(2, 7, 13));
            commands.AddLast(new AddWaterCommand(2, 8, 13));
            commands.AddLast(new AddWaterCommand(2, 9, 13));
            commands.AddLast(new AddWaterCommand(2, 10, 13));
            commands.AddLast(new AddWaterCommand(2, 11, 13));
            commands.AddLast(new AddWaterCommand(2, 12, 13));
            commands.AddLast(new AddWaterCommand(2, 13, 13));
            commands.AddLast(new AddWaterCommand(2, 14, 13));
            commands.AddLast(new AddWaterCommand(2, 15, 13));
            commands.AddLast(new AddWaterCommand(2, 16, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddWaterCommand(2, 3, 14));
            commands.AddLast(new AddWaterCommand(2, 4, 14));
            commands.AddLast(new AddWaterCommand(2, 5, 14));
            commands.AddLast(new AddWaterCommand(2, 6, 14));
            commands.AddLast(new AddWaterCommand(2, 7, 14));
            commands.AddLast(new AddWaterCommand(2, 8, 14));
            commands.AddLast(new AddWaterCommand(2, 9, 14));
            commands.AddLast(new AddWaterCommand(2, 10, 14));
            commands.AddLast(new AddWaterCommand(2, 11, 14));
            commands.AddLast(new AddWaterCommand(2, 12, 14));
            commands.AddLast(new AddWaterCommand(2, 13, 14));
            commands.AddLast(new AddWaterCommand(2, 14, 14));
            commands.AddLast(new AddWaterCommand(2, 15, 14));
            commands.AddLast(new AddWaterCommand(2, 16, 14));



            commands.AddLast(new AddEdgeCommand(4, 0, 5, 3, 22));
            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 22));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 22));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 22));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 18));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 18));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 18));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 18));

            commands.AddLast(new AddEdgeCommand(4, 16, 5, 1, 24));
            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 24));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 24));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 24));
            commands.AddLast(new AddEdgeCommand(4, 16, 9, 1, 24));
            commands.AddLast(new AddEdgeCommand(4, 16, 10, 1, 24));
            commands.AddLast(new AddEdgeCommand(4, 16, 11, 1, 24));
            commands.AddLast(new AddEdgeCommand(4, 16, 12, 1, 24));
        }

        private void BuildScreen24(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 4, 4, 222, 184, 135));

            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 16, 5));

            commands.AddLast(new AddTreeCommand(2, 16, 6));

            commands.AddLast(new AddTreeCommand(2, 16, 7));

            commands.AddLast(new AddTreeCommand(2, 16, 8));

            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddWaterCommand(2, 3, 14));
            commands.AddLast(new AddWaterCommand(2, 4, 14));
            commands.AddLast(new AddWaterCommand(2, 5, 14));
            commands.AddLast(new AddWaterCommand(2, 6, 14));
            commands.AddLast(new AddWaterCommand(2, 7, 14));
            commands.AddLast(new AddWaterCommand(2, 8, 14));
            commands.AddLast(new AddWaterCommand(2, 9, 14));
            commands.AddLast(new AddWaterCommand(2, 10, 14));
            commands.AddLast(new AddWaterCommand(2, 11, 14));
            commands.AddLast(new AddWaterCommand(2, 12, 14));
            commands.AddLast(new AddWaterCommand(2, 13, 14));
            commands.AddLast(new AddWaterCommand(2, 14, 14));
            commands.AddLast(new AddWaterCommand(2, 15, 14));
            commands.AddLast(new AddWaterCommand(2, 16, 14));

            commands.AddLast(new AddEdgeCommand(4, 0, 5, 3, 23));
            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 23));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 23));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 23));
            commands.AddLast(new AddEdgeCommand(4, 0, 9, 3, 23));
            commands.AddLast(new AddEdgeCommand(4, 0, 10, 3, 23));
            commands.AddLast(new AddEdgeCommand(4, 0, 11, 3, 23));
            commands.AddLast(new AddEdgeCommand(4, 0, 12, 3, 23));

            commands.AddLast(new AddEdgeCommand(4, 5, 0, 0, 19));
            commands.AddLast(new AddEdgeCommand(4, 6, 0, 0, 19));
            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 19));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 19));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 19));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 19));
            commands.AddLast(new AddEdgeCommand(4, 11, 0, 0, 19));
        }

        private void BuildScreen25(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 2, 6, 104, 133, 195));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 28));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 28));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 28));
        }

        private void BuildScreen26(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 0, 5, 104, 133, 195));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 27));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 27));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 27));
        }

        private void BuildScreen27(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 1, 5, 104, 133, 195));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 26));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 26));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 26));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 28));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 28));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 28));
        }

        private void BuildScreen28(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 2, 5, 104, 133, 195));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 32));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 32));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 32));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 29));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 29));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 29));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 25));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 25));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 25));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 27));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 27));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 27));
        }

        private void BuildScreen29(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 3, 5, 104, 133, 195));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 32));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 32));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 32));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 30));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 30));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 30));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 25));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 25));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 25));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 28));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 28));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 28));

        }

        private void BuildScreen30(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 4, 5, 104, 133, 195));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 35));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 35));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 35));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 30));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 30));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 30));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 25));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 25));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 25));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 29));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 29));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 29));

        }

        private void BuildScreen32(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 1, 4, 104, 133, 195));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 35));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 35));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 35));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 33));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 33));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 33));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 25));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 25));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 25));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 29));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 29));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 29));
        }

        private void BuildScreen33(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 2, 4, 104, 133, 195));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 35));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 35));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 35));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 33));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 33));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 33));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 28));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 28));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 28));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 32));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 32));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 32));
        }

        private void BuildScreen35(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 4, 4, 104, 133, 195));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 40));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 40));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 40));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 33));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 33));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 33));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 30));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 30));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 30));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 32));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 32));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 32));
        }

        private void BuildScreen39(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 3, 3, 104, 133, 195));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 40));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 40));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 40));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 40));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 40));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 40));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 30));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 30));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 30));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 32));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 32));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 32));
        }

        private void BuildScreen40(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 4, 3, 104, 133, 195));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 40));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 40));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 40));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 33));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 33));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 33));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 35));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 35));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 35));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 39));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 39));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 39));
        }

        private void BuildScreen43(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 2, 2, 104, 133, 195));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 48));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 48));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 48));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 44));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 44));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 44));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 35));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 35));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 35));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 39));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 39));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 39));
        }

        private void BuildScreen44(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 3, 2, 104, 133, 195));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 45));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 45));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 45));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 45));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 45));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 39));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 39));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 39));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 43));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 43));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 43));
        }

        private void BuildScreen45(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 4, 2, 104, 133, 195));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 45));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 45));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 45));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 45));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 45));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 39));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 39));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 39));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 44));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 44));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 44));
        }

        private void BuildScreen48(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 2, 1, 104, 133, 195));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 53));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 53));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 53));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 45));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 45));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 43));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 43));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 43));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 44));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 44));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 44));
        }

        private void BuildScreen53(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 2, 0, 104, 133, 195));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 53));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 53));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 53));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 45));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 45));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 48));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 48));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 48));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 44));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 44));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 44));
        }

        private void BuildScreen54(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 0, 6, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 60));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 60));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 60));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 55));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 55));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 55));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 48));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 48));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 48));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 44));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 44));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 44));
        }

        private void BuildScreen55(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 1, 6, 65, 182, 73));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 60));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 60));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 60));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 56));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 56));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 56));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 48));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 48));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 48));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 54));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 54));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 54));
        }

        private void BuildScreen56(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 2, 6, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 62));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 62));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 62));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 56));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 48));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 48));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 48));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 55));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 55));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 55));
        }

        private void BuildScreen58(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 4, 6, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 64));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 64));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 64));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 56));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 48));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 48));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 48));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 55));
        }

        private void BuildScreen60(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 0, 5, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 66));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 66));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 66));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 56));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 54));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 54));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 54));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 55));
        }

        private void BuildScreen62(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 2, 5, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 68));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 68));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 68));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 56));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 56));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 56));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 56));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 55));
        }

        private void BuildScreen64(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 4, 5, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 70));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 70));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 70));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 56));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 58));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 58));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 58));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 55));
        }

        private void BuildScreen66(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 0, 4, 65, 182, 73));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 70));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 70));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 70));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 56));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 60));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 60));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 60));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 55));
        }

        private void BuildScreen67(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 1, 4, 65, 182, 73));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 70));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 70));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 70));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 68));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 68));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 68));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 60));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 60));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 60));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 55));
        }

        private void BuildScreen68(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 2, 4, 65, 182, 73));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 70));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 70));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 70));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 69));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 69));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 69));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 62));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 62));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 62));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 67));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 67));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 67));
        }

        private void BuildScreen69(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 3, 4, 65, 182, 73));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 70));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 70));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 70));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 70));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 70));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 70));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 60));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 60));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 60));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 68));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 68));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 68));
        }

        private void BuildScreen70(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 4, 4, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 76));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 76));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 76));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 71));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 71));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 71));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 64));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 64));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 64));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 69));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 69));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 69));
        }

        private void BuildScreen71(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 5, 4, 65, 182, 73));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 70));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 70));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 70));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 71));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 71));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 71));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 60));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 60));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 60));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 70));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 70));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 70));
        }

        private void BuildScreen74(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 2, 3, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 80));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 80));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 80));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 71));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 71));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 71));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 60));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 60));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 60));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 70));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 70));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 70));
        }

        private void BuildScreen76(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 4, 3, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 82));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 82));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 82));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 71));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 71));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 71));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 76));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 76));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 76));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 70));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 70));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 70));
        }

        private void BuildScreen79(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 1, 2, 65, 182, 73));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 82));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 82));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 82));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 80));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 80));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 80));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 76));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 76));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 76));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 70));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 70));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 70));
        }

        private void BuildScreen80(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 2, 2, 65, 182, 73));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 82));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 82));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 82));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 81));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 81));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 81));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 74));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 74));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 74));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 79));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 79));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 79));
        }

        private void BuildScreen81(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 3, 2, 65, 182, 73));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 82));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 82));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 82));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 82));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 82));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 82));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 74));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 74));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 74));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 80));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 80));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 80));
        }

        private void BuildScreen82(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 4, 2, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 88));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 88));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 88));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 83));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 83));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 83));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 76));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 76));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 76));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 81));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 81));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 81));
        }

        private void BuildScreen88(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 4, 1, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 94));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 94));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 94));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 83));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 83));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 83));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 82));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 82));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 82));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 81));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 81));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 81));
        }

        private void BuildScreen94(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 4, 0, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 88));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 88));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 88));
        }

        private void BuildScreen101(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 1, 4, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 108));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 108));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 108));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 83));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 83));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 83));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 82));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 82));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 82));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 81));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 81));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 81));
        }

        private void BuildScreen105(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 5, 4, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 112));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 112));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 112));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 83));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 83));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 83));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 82));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 82));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 82));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 81));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 81));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 81));
        }

        private void BuildScreen107(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 0, 3, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 114));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 114));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 114));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 108));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 108));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 108));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 82));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 82));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 82));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 81));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 81));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 81));
        }

        private void BuildScreen108(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 1, 3, 200, 205, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 114));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 114));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 114));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 109));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 109));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 109));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 101));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 101));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 101));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 107));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 107));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 107));
        }

        private void BuildScreen109(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 2, 3, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 116));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 116));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 116));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 109));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 109));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 109));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 101));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 101));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 101));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 108));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 108));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 108));
        }

        private void BuildScreen110(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 3, 3, 200, 205, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 116));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 116));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 116));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 111));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 111));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 111));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 101));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 101));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 101));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 108));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 108));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 108));
        }

        private void BuildScreen111(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 4, 3, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 118));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 118));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 118));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 112));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 112));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 112));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 101));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 101));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 101));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 110));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 110));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 110));
        }

        private void BuildScreen112(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 5, 3, 200, 205, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 118));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 118));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 118));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 113));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 113));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 113));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 105));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 105));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 105));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 111));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 111));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 111));
        }

        private void BuildScreen113(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 6, 3, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 120));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 120));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 120));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 113));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 113));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 113));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 105));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 105));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 105));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 112));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 112));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 112));
        }

        private void BuildScreen114(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 0, 2, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 121));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 121));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 121));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 113));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 113));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 113));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 107));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 107));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 107));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 111));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 111));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 111));
        }

        private void BuildScreen116(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 2, 2, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 123));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 123));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 123));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 113));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 113));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 113));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 109));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 109));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 109));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 111));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 111));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 111));
        }

        private void BuildScreen118(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 4, 2, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 125));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 125));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 125));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 113));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 113));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 113));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 111));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 111));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 111));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 111));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 111));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 111));
        }

        private void BuildScreen120(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 6, 2, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 127));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 127));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 127));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 113));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 113));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 113));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 113));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 113));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 113));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 111));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 111));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 111));
        }

        private void BuildScreen121(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 0, 1, 200, 205, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 127));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 127));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 127));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 122));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 122));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 122));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 114));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 114));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 114));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 111));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 111));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 111));
        }

        private void BuildScreen122(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 1, 1, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 129));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 129));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 129));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 122));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 122));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 122));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 114));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 114));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 114));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 121));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 121));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 121));
        }

        private void BuildScreen123(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 2, 1, 200, 205, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 127));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 127));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 127));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 124));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 124));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 124));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 116));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 116));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 116));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 121));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 121));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 121));
        }

        private void BuildScreen124(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 3, 1, 200, 205, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 127));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 127));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 127));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 125));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 125));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 125));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 116));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 116));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 116));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 123));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 123));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 123));
        }

        private void BuildScreen125(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 4, 1, 200, 205, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 127));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 127));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 127));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 126));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 126));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 126));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 118));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 118));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 118));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 124));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 124));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 124));
        }

        private void BuildScreen126(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 5, 1, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 133));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 133));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 133));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 124));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 124));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 124));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 118));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 118));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 118));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 125));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 125));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 125));
        }

        private void BuildScreen127(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 6, 1, 200, 205, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 133));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 133));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 133));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 120));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 120));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 120));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 120));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 120));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 120));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 126));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 126));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 126));
        }

        private void BuildScreen129(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 1, 0, 200, 205, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 133));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 133));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 133));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 120));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 120));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 120));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 122));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 122));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 122));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 126));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 126));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 126));
        }

        private void BuildScreen133(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 5, 0, 200, 205, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 133));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 133));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 133));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 120));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 120));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 120));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 126));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 126));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 126));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 126));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 126));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 126));
        }

        private void BuildScreen140(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 4, 6, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 142));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 142));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 142));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 120));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 120));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 120));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 126));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 126));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 126));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 126));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 126));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 126));
        }

        private void BuildScreen141(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 1, 5, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 144));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 144));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 144));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 120));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 120));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 120));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 126));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 126));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 126));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 126));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 126));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 126));
        }

        private void BuildScreen142(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 4, 5, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 146));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 146));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 146));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 143));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 143));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 143));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 140));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 140));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 140));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 126));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 126));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 126));
        }

        private void BuildScreen143(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 5, 5, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 147));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 147));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 147));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 142));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 142));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 142));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 140));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 140));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 140));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 142));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 142));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 142));
        }

        private void BuildScreen144(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 1, 4, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 150));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 150));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 150));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 145));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 145));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 145));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 141));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 141));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 141));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 142));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 142));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 142));
        }

        private void BuildScreen145(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 2, 4, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 151));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 151));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 151));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 145));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 145));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 145));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 141));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 141));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 141));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 144));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 144));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 144));
        }

        private void BuildScreen146(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 4, 4, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 153));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 153));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 153));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 147));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 147));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 147));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 142));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 142));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 142));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 144));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 144));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 144));
        }

        private void BuildScreen147(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 5, 4, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 153));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 153));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 153));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 148));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 148));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 148));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 143));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 143));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 143));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 146));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 146));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 146));
        }

        private void BuildScreen148(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 6, 4, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 154));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 154));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 154));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 148));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 148));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 148));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 143));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 143));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 143));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 147));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 147));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 147));
        }

        private void BuildScreen149(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 0, 3, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 155));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 155));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 155));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 150));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 150));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 150));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 143));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 143));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 143));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 147));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 147));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 147));
        }

        private void BuildScreen150(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 1, 3, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 151));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 151));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 151));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 151));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 151));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 151));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 144));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 144));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 144));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 149));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 149));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 149));
        }

        private void BuildScreen151(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 2, 3, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 151));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 151));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 151));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 152));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 152));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 152));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 145));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 145));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 145));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 150));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 150));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 150));
        }

        private void BuildScreen152(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 3, 3, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 157));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 157));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 157));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 153));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 153));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 153));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 145));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 145));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 145));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 151));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 151));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 151));
        }

        private void BuildScreen153(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 4, 3, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 157));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 157));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 157));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 153));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 153));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 153));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 146));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 146));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 146));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 152));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 152));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 152));
        }

        private void BuildScreen154(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 6, 3, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 157));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 157));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 157));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 153));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 153));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 153));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 148));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 148));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 148));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 152));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 152));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 152));
        }

        private void BuildScreen155(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 0, 2, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 157));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 157));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 157));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 153));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 153));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 153));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 149));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 149));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 149));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 152));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 152));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 152));
        }

        private void BuildScreen156(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 2, 2, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 159));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 159));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 159));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 153));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 153));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 153));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 149));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 149));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 149));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 152));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 152));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 152));
        }

        private void BuildScreen157(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 3, 2, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 160));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 160));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 160));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 158));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 158));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 158));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 152));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 152));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 152));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 152));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 152));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 152));
        }

        private void BuildScreen158(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 4, 2, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 160));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 160));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 160));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 158));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 158));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 158));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 152));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 152));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 152));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 157));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 157));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 157));
        }

        private void BuildScreen159(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 2, 1, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 163));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 163));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 163));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 160));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 160));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 160));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 156));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 156));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 156));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 157));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 157));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 157));
        }

        private void BuildScreen160(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 3, 1, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 161));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 161));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 161));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 161));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 161));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 161));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 157));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 157));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 157));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 159));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 159));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 159));
        }

        private void BuildScreen161(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 4, 1, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 161));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 161));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 161));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 162));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 162));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 157));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 157));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 157));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 160));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 160));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 160));
        }

        private void BuildScreen162(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 5, 1, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 164));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 164));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 164));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 162));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 162));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 157));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 157));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 157));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 161));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 161));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 161));
        }

        private void BuildScreen163(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 2, 0, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 164));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 164));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 164));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 162));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 162));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 159));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 159));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 159));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 161));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 161));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 161));
        }

        private void BuildScreen164(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 5, 0, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 164));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 164));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 164));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 162));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 162));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 162));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 162));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 162));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 161));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 161));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 161));
        }

        private void BuildScreen200(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 5, 9, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 201));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 201));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 201));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 162));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 162));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 162));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 162));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 162));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 161));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 161));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 161));
        }

        private void BuildScreen201(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 5, 8, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 204));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 204));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 204));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 162));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 162));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 200));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 200));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 200));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 161));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 161));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 161));
        }

        private void BuildScreen202(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 3, 7, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 209));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 209));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 209));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 203));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 203));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 203));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 200));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 161));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 161));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 161));
        }

        private void BuildScreen203(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 4, 7, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 209));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 209));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 209));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 204));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 204));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 204));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 200));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 202));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 202));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 202));
        }

        private void BuildScreen204(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 5, 7, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 211));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 211));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 211));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 205));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 205));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 205));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 201));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 201));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 201));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 203));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 203));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 203));
        }

        private void BuildScreen205(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 6, 7, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 209));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 209));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 209));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 204));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 204));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 204));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 200));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 204));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 204));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 204));
        }

        private void BuildScreen206(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 0, 6, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 209));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 209));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 209));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 207));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 207));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 207));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 200));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 204));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 204));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 204));
        }

        private void BuildScreen207(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 1, 6, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 209));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 209));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 209));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 208));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 208));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 208));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 200));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 206));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 206));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 206));
        }

        private void BuildScreen208(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 2, 6, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 209));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 209));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 209));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 209));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 209));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 209));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 200));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 207));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 207));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 207));
        }

        private void BuildScreen209(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 3, 6, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 213));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 213));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 213));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 210));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 210));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 210));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 202));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 202));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 202));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 208));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 208));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 208));
        }

        private void BuildScreen210(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 4, 6, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 213));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 213));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 213));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 210));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 210));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 210));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 202));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 202));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 202));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 209));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 209));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 209));
        }

        private void BuildScreen211(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 5, 6, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 213));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 213));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 213));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 210));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 210));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 210));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 204));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 204));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 204));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 209));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 209));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 209));
        }

        private void BuildScreen212(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 7, 6, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 214));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 214));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 214));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 210));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 210));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 210));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 204));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 204));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 204));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 209));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 209));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 209));
        }

        private void BuildScreen213(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 3, 5, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 218));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 218));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 218));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 210));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 210));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 210));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 209));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 209));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 209));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 209));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 209));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 209));
        }

        private void BuildScreen214(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 7, 5, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 222));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 222));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 222));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 215));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 215));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 215));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 212));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 212));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 212));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 209));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 209));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 209));
        }

        private void BuildScreen215(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 8, 5, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 222));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 222));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 222));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 215));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 215));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 215));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 212));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 212));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 212));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 214));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 214));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 214));
        }

        private void BuildScreen216(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 1, 4, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 222));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 222));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 222));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 217));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 217));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 217));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 212));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 212));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 212));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 214));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 214));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 214));
        }

        private void BuildScreen217(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 2, 4, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 225));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 225));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 225));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 218));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 218));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 218));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 212));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 212));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 212));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 216));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 216));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 216));
        }

        private void BuildScreen218(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 3, 4, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 225));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 225));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 225));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 219));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 219));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 219));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 213));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 213));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 213));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 217));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 217));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 217));
        }

        private void BuildScreen219(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 4, 4, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 225));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 225));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 225));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 220));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 220));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 220));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 213));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 213));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 213));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 218));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 218));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 218));
        }

        private void BuildScreen220(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 5, 4, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 224));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 224));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 224));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 221));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 221));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 221));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 213));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 213));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 213));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 219));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 219));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 219));
        }

        private void BuildScreen221(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 6, 4, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 224));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 224));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 224));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 222));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 222));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 222));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 213));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 213));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 213));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 220));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 220));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 220));
        }

        private void BuildScreen222(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 7, 4, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 224));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 224));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 224));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 222));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 222));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 222));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 214));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 214));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 214));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 221));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 221));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 221));
        }

        private void BuildScreen223(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 2, 3, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 224));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 224));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 224));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 222));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 222));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 222));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 217));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 217));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 217));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 220));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 220));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 220));
        }

        private void BuildScreen224(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 5, 3, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 225));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 225));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 225));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 222));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 222));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 222));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 220));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 220));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 220));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 220));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 220));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 220));
        }

        private void BuildScreen225(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 5, 2, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 228));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 228));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 228));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 226));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 226));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 226));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 224));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 224));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 224));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 220));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 220));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 220));
        }

        private void BuildScreen226(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 6, 2, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 228));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 228));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 228));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 226));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 226));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 226));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 224));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 224));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 224));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 225));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 225));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 225));
        }

        private void BuildScreen227(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 4, 1, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 228));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 228));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 228));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 228));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 228));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 228));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 224));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 224));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 224));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 225));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 225));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 225));
        }

        private void BuildScreen228(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 5, 1, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 229));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 229));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 229));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 228));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 228));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 228));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 225));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 225));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 225));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 227));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 227));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 227));
        }

        private void BuildScreen229(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 5, 0, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 229));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 229));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 229));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 228));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 228));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 228));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 228));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 228));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 228));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 227));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 227));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 227));
        }

        private void BuildScreen250(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 2, 6, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 229));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 229));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 229));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 251));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 251));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 251));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 228));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 228));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 228));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 227));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 227));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 227));
        }

        private void BuildScreen251(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 3, 6, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 229));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 229));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 229));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 252));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 252));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 252));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 228));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 228));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 228));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 250));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 250));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 250));
        }

        private void BuildScreen252(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 4, 6, 192, 192, 192));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 256));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 256));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 256));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 252));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 252));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 252));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 228));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 228));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 228));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 251));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 251));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 251));
        }

        private void BuildScreen253(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 6, 6, 192, 192, 192));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 258));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 258));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 258));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 252));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 252));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 252));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 228));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 228));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 228));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 251));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 251));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 251));
        }

        private void BuildScreen254(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 9, 6, 192, 192, 192));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 254));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 254));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 254));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 252));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 252));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 252));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 228));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 228));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 228));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 251));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 251));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 251));
        }

        private void BuildScreen255(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 2, 5, 192, 192, 192));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 264));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 264));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 264));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 252));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 252));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 252));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 228));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 228));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 228));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 251));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 251));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 251));
        }

        private void BuildScreen256(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 4, 5, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 264));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 264));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 264));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 257));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 257));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 257));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 252));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 252));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 252));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 251));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 251));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 251));
        }

        private void BuildScreen257(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 5, 5, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 258));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 258));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 258));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 258));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 258));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 258));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 228));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 228));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 228));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 256));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 256));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 256));
        }

        private void BuildScreen258(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 6, 5, 192, 192, 192));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 266));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 266));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 266));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 259));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 259));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 259));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 253));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 253));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 253));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 257));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 257));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 257));
        }

        private void BuildScreen259(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 7, 5, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 266));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 266));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 266));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 260));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 260));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 260));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 253));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 253));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 253));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 258));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 258));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 258));
        }

        private void BuildScreen260(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 8, 5, 192, 192, 192));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 267));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 267));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 267));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 261));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 261));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 261));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 253));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 253));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 253));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 259));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 259));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 259));
        }

        private void BuildScreen261(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 9, 5, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 267));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 267));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 267));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 261));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 261));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 261));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 254));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 254));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 254));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 260));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 260));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 260));
        }

        private void BuildScreen262(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 0, 4, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 267));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 267));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 267));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 263));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 263));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 263));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 254));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 254));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 254));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 260));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 260));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 260));
        }

        private void BuildScreen263(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 1, 4, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 267));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 267));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 267));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 264));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 264));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 264));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 254));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 254));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 254));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 262));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 262));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 262));
        }

        private void BuildScreen264(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 2, 4, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 269));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 269));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 269));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 265));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 265));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 265));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 255));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 255));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 255));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 263));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 263));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 263));
        }

        private void BuildScreen265(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 3, 4, 192, 192, 192));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 270));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 270));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 270));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 265));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 265));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 265));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 255));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 255));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 255));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 264));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 264));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 264));
        }

        private void BuildScreen266(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 6, 4, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 273));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 273));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 273));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 265));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 265));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 265));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 258));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 258));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 258));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 264));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 264));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 264));
        }

        private void BuildScreen267(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 8, 4, 192, 192, 192));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 275));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 275));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 275));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 265));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 265));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 265));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 260));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 260));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 260));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 264));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 264));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 264));
        }

        private void BuildScreen268(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 1, 3, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 275));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 275));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 275));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 269));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 269));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 269));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 260));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 260));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 260));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 264));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 264));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 264));
        }

        private void BuildScreen269(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 2, 3, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 275));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 275));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 275));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 270));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 270));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 270));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 260));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 260));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 260));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 268));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 268));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 268));
        }

        private void BuildScreen270(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 3, 3, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 275));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 275));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 275));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 271));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 271));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 271));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 265));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 265));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 265));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 269));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 269));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 269));
        }

        private void BuildScreen271(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 4, 3, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 275));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 275));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 275));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 272));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 272));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 272));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 265));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 265));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 265));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 270));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 270));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 270));
        }

        private void BuildScreen272(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 5, 3, 192, 192, 192));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 277));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 277));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 277));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 272));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 272));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 272));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 265));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 265));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 265));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 271));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 271));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 271));
        }

        private void BuildScreen273(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 6, 3, 192, 192, 192));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 278));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 278));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 278));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 272));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 272));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 272));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 265));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 265));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 265));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 271));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 271));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 271));
        }

        private void BuildScreen274(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 7, 3, 192, 192, 192));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 279));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 279));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 279));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 272));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 272));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 272));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 265));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 265));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 265));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 271));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 271));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 271));
        }

        private void BuildScreen275(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 8, 3, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 279));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 279));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 279));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 276));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 276));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 276));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 267));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 267));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 267));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 271));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 271));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 271));
        }

        private void BuildScreen276(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 9, 3, 192, 192, 192));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 280));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 280));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 280));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 276));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 276));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 276));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 267));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 267));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 267));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 275));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 275));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 275));
        }

        private void BuildScreen277(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 5, 2, 192, 192, 192));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 282));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 282));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 282));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 278));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 278));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 278));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 272));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 272));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 272));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 275));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 275));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 275));
        }

        private void BuildScreen278(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 6, 2, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 282));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 282));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 282));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 279));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 279));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 279));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 273));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 273));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 273));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 278));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 278));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 278));
        }

        private void BuildScreen279(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 7, 2, 192, 192, 192));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 283));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 283));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 283));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 279));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 279));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 279));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 272));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 272));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 272));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 278));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 278));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 278));
        }

        private void BuildScreen280(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 9, 2, 192, 192, 192));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 285));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 285));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 285));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 279));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 279));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 279));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 276));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 276));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 276));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 278));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 278));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 278));
        }

        private void BuildScreen281(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 3, 1, 192, 192, 192));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 287));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 287));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 287));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 279));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 279));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 279));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 276));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 276));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 276));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 278));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 278));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 278));
        }

        private void BuildScreen282(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 5, 1, 192, 192, 192));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 289));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 289));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 289));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 279));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 279));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 279));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 277));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 277));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 277));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 278));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 278));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 278));
        }

        private void BuildScreen283(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 7, 1, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 284));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 284));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 284));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 284));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 284));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 284));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 279));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 279));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 279));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 278));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 278));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 278));
        }

        private void BuildScreen284(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 8, 1, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 285));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 285));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 285));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 285));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 285));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 285));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 279));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 279));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 279));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 283));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 283));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 283));
        }

        private void BuildScreen285(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 9, 1, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 285));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 285));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 285));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 286));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 286));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 286));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 280));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 280));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 280));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 284));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 284));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 284));
        }

        private void BuildScreen286(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 10, 1, 192, 192, 192));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 290));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 290));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 290));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 286));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 286));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 286));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 280));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 280));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 280));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 285));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 285));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 285));
        }

        private void BuildScreen287(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 3, 0, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 290));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 290));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 290));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 288));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 288));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 288));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 281));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 281));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 281));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 285));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 285));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 285));
        }

        private void BuildScreen288(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 4, 0, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 290));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 290));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 290));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 289));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 289));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 289));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 281));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 281));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 281));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 287));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 287));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 287));
        }

        private void BuildScreen289(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 5, 0, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 290));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 290));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 290));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 289));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 289));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 289));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 282));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 282));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 282));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 288));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 288));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 288));
        }

        private void BuildScreen290(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(6, 10, 0, 192, 192, 192));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 290));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 290));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 290));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 289));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 289));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 289));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 286));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 286));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 286));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 288));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 288));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 288));
        }

        private void BuildScreen300(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 2, 7, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 302));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 302));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 302));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 289));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 289));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 289));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 286));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 286));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 286));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 288));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 288));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 288));
        }

        private void BuildScreen301(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 1, 6, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 307));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 307));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 307));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 289));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 289));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 289));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 286));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 286));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 286));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 288));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 288));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 288));
        }

        private void BuildScreen302(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 1, 6, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 308));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 308));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 308));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 289));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 289));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 289));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 300));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 300));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 300));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 288));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 288));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 288));
        }

        private void BuildScreen303(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 5, 6, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 311));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 311));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 311));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 304));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 304));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 304));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 300));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 300));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 300));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 288));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 288));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 288));
        }

        private void BuildScreen304(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 6, 6, 215, 215, 0));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 311));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 311));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 311));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 305));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 305));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 305));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 300));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 300));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 300));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 305));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 305));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 305));
        }

        private void BuildScreen305(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 7, 6, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 312));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 312));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 312));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 305));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 305));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 305));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 300));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 300));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 300));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 304));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 304));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 304));
        }

        private void BuildScreen306(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 0, 5, 215, 215, 0));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 312));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 312));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 312));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 307));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 307));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 307));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 300));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 300));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 300));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 304));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 304));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 304));
        }

        private void BuildScreen307(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 0, 5, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 313));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 313));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 313));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 308));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 308));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 308));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 301));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 301));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 301));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 306));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 306));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 306));
        }

        private void BuildScreen308(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 2, 5, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 314));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 314));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 314));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 308));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 308));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 308));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 302));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 302));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 302));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 307));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 307));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 307));
        }

        private void BuildScreen309(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 3, 5, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 315));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 315));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 315));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 310));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 310));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 310));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 302));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 302));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 302));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 307));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 307));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 307));
        }

        private void BuildScreen310(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 4, 5, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 316));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 316));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 316));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 311));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 311));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 311));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 302));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 302));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 302));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 309));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 309));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 309));
        }

        private void BuildScreen311(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 5, 5, 215, 215, 0));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 316));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 316));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 316));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 311));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 311));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 311));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 303));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 303));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 303));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 311));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 311));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 311));
        }

        private void BuildScreen312(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 7, 5, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 319));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 319));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 319));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 311));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 311));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 311));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 305));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 305));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 305));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 311));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 311));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 311));
        }

        private void BuildScreen313(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 1, 4, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 319));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 319));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 319));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 311));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 311));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 311));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 305));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 305));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 305));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 311));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 311));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 311));
        }

        private void BuildScreen314(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 2, 4, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 321));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 321));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 321));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 311));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 311));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 311));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 308));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 308));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 308));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 311));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 311));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 311));
        }

        private void BuildScreen315(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 3, 4, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 322));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 322));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 322));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 311));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 311));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 311));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 309));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 309));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 309));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 311));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 311));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 311));
        }

        private void BuildScreen316(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 4, 4, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 323));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 323));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 323));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 317));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 317));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 317));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 310));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 310));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 310));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 311));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 311));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 311));
        }

        private void BuildScreen317(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 5, 4, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 324));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 324));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 324));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 318));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 318));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 318));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 31));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 310));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 310));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 316));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 316));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 316));
        }

        private void BuildScreen318(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 6, 4, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 325));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 325));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 325));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 319));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 319));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 319));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 31));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 310));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 310));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 317));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 317));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 317));
        }

        private void BuildScreen319(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 7, 4, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 326));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 326));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 326));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 319));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 319));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 319));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 312));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 312));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 312));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 317));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 317));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 317));
        }

        private void BuildScreen320(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 1, 3, 215, 215, 0));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 326));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 326));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 326));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 319));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 319));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 319));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 313));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 313));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 313));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 317));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 317));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 317));
        }

        private void BuildScreen321(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 2, 3, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 328));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 328));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 328));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 319));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 319));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 319));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 314));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 314));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 314));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 317));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 317));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 317));
        }

        private void BuildScreen322(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 3, 3, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 329));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 329));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 329));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 319));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 319));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 319));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 315));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 315));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 315));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 317));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 317));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 317));
        }

        private void BuildScreen323(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 4, 3, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 330));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 330));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 330));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 319));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 319));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 319));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 316));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 316));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 316));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 317));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 317));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 317));
        }

        private void BuildScreen324(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 5, 3, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 331));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 331));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 331));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 325));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 325));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 325));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 317));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 317));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 317));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 317));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 317));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 317));
        }

        private void BuildScreen325(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 6, 3, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 332));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 332));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 332));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 325));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 325));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 325));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 318));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 318));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 318));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 324));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 324));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 324));
        }

        private void BuildScreen326(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 7, 3, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 333));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 333));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 333));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 325));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 325));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 325));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 319));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 319));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 319));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 324));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 324));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 324));
        }

        private void BuildScreen327(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 1, 2, 215, 215, 0));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 333));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 333));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 333));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 328));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 328));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 328));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 319));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 319));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 319));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 324));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 324));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 324));
        }

        private void BuildScreen328(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 2, 2, 215, 215, 0));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 333));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 333));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 333));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 329));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 329));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 329));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 321));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 321));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 321));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 327));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 327));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 327));
        }

        private void BuildScreen329(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 3, 2, 215, 215, 0));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 333));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 333));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 333));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 329));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 329));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 329));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 322));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 322));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 322));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 328));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 328));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 328));
        }

        private void BuildScreen330(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 4, 2, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 336));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 336));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 336));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 329));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 329));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 329));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 323));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 323));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 323));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 328));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 328));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 328));
        }

        private void BuildScreen331(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 5, 2, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 337));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 337));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 337));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 332));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 332));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 332));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 324));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 324));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 324));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 328));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 328));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 328));
        }

        private void BuildScreen332(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 6, 2, 215, 215, 0));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 337));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 337));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 337));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 332));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 332));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 332));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 324));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 324));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 324));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 331));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 331));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 331));
        }

        private void BuildScreen333(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 7, 2, 215, 215, 0));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 337));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 337));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 337));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 332));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 332));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 332));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 326));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 326));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 326));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 331));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 331));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 331));
        }

        private void BuildScreen334(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 2, 1, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 339));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 339));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 339));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 335));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 335));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 335));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 326));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 326));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 326));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 331));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 331));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 331));
        }

        private void BuildScreen335(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 3, 1, 215, 215, 0));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 337));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 337));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 337));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 336));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 336));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 336));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 326));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 326));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 326));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 334));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 334));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 334));
        }

        private void BuildScreen336(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 4, 1, 215, 215, 0));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 337));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 337));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 337));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 336));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 336));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 336));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 330));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 330));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 330));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 335));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 335));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 335));
        }

        private void BuildScreen337(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 5, 1, 215, 215, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 340));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 340));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 340));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 336));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 336));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 336));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 331));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 331));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 331));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 335));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 335));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 335));
        }

        private void BuildScreen338(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 1, 0, 215, 215, 0));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 340));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 340));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 340));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 329));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 329));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 329));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 331));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 331));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 331));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 335));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 335));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 335));
        }

        private void BuildScreen339(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 2, 0, 215, 215, 0));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 340));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 340));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 340));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 329));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 329));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 329));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 334));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 334));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 334));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 338));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 338));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 338));
        }

        private void BuildScreen340(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 5, 0, 215, 215, 0));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 340));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 340));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 340));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 341));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 341));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 341));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 337));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 337));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 337));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 338));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 338));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 338));
        }

        private void BuildScreen341(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 6, 0, 215, 215, 0));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 340));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 340));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 340));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 342));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 342));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 342));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 337));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 340));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 340));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 340));
        }

        private void BuildScreen342(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 7, 0, 215, 215, 0));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 340));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 340));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 340));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 343));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 343));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 343));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 337));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 341));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 341));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 341));
        }

        private void BuildScreen343(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(7, 8, 0, 215, 215, 0));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 340));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 340));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 340));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 343));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 343));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 343));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 337));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 342));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 342));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 342));
        }

        private void BuildScreen400(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 0, 6, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 408));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 408));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 408));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 343));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 343));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 343));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 337));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 342));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 342));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 342));
        }

        private void BuildScreen401(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 1, 6, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 409));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 409));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 409));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 343));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 343));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 343));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 337));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 342));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 342));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 342));
        }

        private void BuildScreen402(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 3, 6, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 411));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 411));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 411));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 343));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 343));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 343));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 337));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 342));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 342));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 342));
        }

        private void BuildScreen403(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 4, 6, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 411));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 411));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 411));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 404));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 404));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 404));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 337));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 342));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 342));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 342));
        }

        private void BuildScreen404(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 5, 6, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 413));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 413));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 413));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 405));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 405));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 405));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 337));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 403));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 403));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 403));
        }

        private void BuildScreen405(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 6, 6, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 414));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 414));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 414));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 406));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 406));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 406));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 337));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 404));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 404));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 404));
        }

        private void BuildScreen406(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 7, 6, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 415));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 415));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 415));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 407));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 407));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 407));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 337));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 405));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 405));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 405));
        }

        private void BuildScreen407(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 8, 6, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 416));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 416));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 416));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 407));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 407));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 407));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 337));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 337));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 407));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 407));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 407));
        }

        private void BuildScreen408(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 0, 5, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 416));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 416));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 416));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 409));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 409));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 409));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 408));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 408));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 408));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 407));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 407));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 407));
        }

        private void BuildScreen409(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 1, 5, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 418));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 418));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 418));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 410));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 410));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 410));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 401));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 401));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 401));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 408));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 408));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 408));
        }

        private void BuildScreen410(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 2, 5, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 419));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 419));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 419));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 411));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 411));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 411));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 401));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 401));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 401));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 409));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 409));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 409));
        }

        private void BuildScreen411(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 3, 5, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 420));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 420));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 420));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 412));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 412));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 412));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 402));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 402));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 402));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 410));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 410));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 410));
        }

        private void BuildScreen412(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 4, 5, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 421));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 421));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 421));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 413));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 413));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 413));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 403));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 403));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 403));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 411));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 411));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 411));
        }

        private void BuildScreen413(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 5, 5, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 422));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 422));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 422));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 414));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 414));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 414));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 404));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 404));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 404));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 412));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 412));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 412));
        }

        private void BuildScreen414(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 6, 5, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 423));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 423));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 423));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 414));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 414));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 414));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 405));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 405));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 405));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 413));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 413));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 413));
        }

        private void BuildScreen415(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 7, 5, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 423));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 423));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 423));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 414));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 414));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 414));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 406));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 406));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 406));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 413));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 413));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 413));
        }

        private void BuildScreen416(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 8, 5, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 425));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 425));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 425));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 414));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 414));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 414));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 407));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 407));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 407));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 413));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 413));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 413));
        }

        private void BuildScreen417(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 0, 4, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 425));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 425));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 425));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 418));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 418));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 418));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 407));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 407));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 407));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 413));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 413));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 413));
        }

        private void BuildScreen418(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 1, 4, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 425));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 425));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 425));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 419));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 419));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 419));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 409));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 409));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 409));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 417));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 417));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 417));
        }

        private void BuildScreen419(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 2, 4, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 425));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 425));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 425));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 420));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 420));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 420));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 410));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 410));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 410));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 418));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 418));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 418));
        }

        private void BuildScreen420(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 3, 4, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 425));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 425));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 425));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 421));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 421));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 421));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 411));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 411));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 411));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 419));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 419));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 419));
        }

        private void BuildScreen421(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 4, 4, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 425));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 425));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 425));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 422));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 422));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 422));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 412));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 412));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 412));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 420));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 420));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 420));
        }

        private void BuildScreen422(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 5, 4, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 431));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 431));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 431));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 423));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 423));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 423));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 413));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 413));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 413));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 421));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 421));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 421));
        }

        private void BuildScreen423(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 6, 4, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 432));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 432));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 432));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 424));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 424));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 424));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 414));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 414));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 414));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 422));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 422));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 422));
        }

        private void BuildScreen424(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 7, 4, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 433));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 433));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 433));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 425));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 425));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 425));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 415));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 415));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 415));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 423));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 423));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 423));
        }

        private void BuildScreen425(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 8, 4, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 433));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 433));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 433));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 425));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 425));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 425));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 416));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 416));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 416));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 423));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 423));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 423));
        }

        private void BuildScreen426(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 0, 3, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 435));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 435));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 435));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 427));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 427));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 427));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 416));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 416));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 416));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 423));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 423));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 423));
        }

        private void BuildScreen427(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 1, 3, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 436));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 436));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 436));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 428));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 428));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 428));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 416));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 416));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 416));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 426));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 426));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 426));
        }

        private void BuildScreen428(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 2, 3, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 437));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 437));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 437));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 429));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 429));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 429));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 428));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 428));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 428));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 427));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 427));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 427));
        }

        private void BuildScreen429(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 3, 3, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 438));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 438));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 438));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 429));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 429));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 429));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 428));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 428));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 428));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 428));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 428));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 428));
        }

        private void BuildScreen430(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 4, 3, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 439));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 439));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 439));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 429));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 429));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 429));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 428));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 428));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 428));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 428));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 428));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 428));
        }

        private void BuildScreen431(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 5, 3, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 439));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 439));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 439));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 429));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 429));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 429));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 422));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 422));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 422));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 428));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 428));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 428));
        }

        private void BuildScreen432(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 6, 3, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 441));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 441));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 441));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 429));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 429));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 429));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 423));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 423));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 423));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 428));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 428));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 428));
        }

        private void BuildScreen433(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 7, 3, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 441));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 441));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 441));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 434));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 434));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 434));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 433));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 433));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 433));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 428));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 428));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 428));
        }

        private void BuildScreen434(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 8, 3, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 441));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 441));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 441));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 434));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 434));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 434));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 433));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 433));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 4233));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 433));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 433));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 433));
        }

        private void BuildScreen435(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 0, 2, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 441));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 441));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 441));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 434));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 434));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 434));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 435));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 435));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 435));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 433));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 433));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 433));
        }

        private void BuildScreen436(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 1, 2, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 445));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 445));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 445));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 434));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 434));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 434));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 436));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 436));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 436));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 433));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 433));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 433));
        }

        private void BuildScreen437(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 2, 2, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 446));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 446));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 446));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 434));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 434));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 434));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 437));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 437));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 437));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 436));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 436));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 436));
        }

        private void BuildScreen438(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 3, 2, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 446));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 446));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 446));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 434));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 434));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 434));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 429));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 429));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 429));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 436));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 436));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 436));
        }

        private void BuildScreen439(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 4, 2, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 448));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 448));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 448));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 440));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 440));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 440));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 430));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 430));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 430));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 436));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 436));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 436));
        }

        private void BuildScreen440(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 5, 2, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 449));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 449));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 449));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 441));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 441));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 441));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 430));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 430));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 430));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 439));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 439));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 439));
        }

        private void BuildScreen441(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 6, 2, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 450));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 450));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 450));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 442));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 442));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 442));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 432));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 432));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 432));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 440));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 440));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 440));
        }

        private void BuildScreen442(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 7, 2, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 451));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 451));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 451));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 442));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 442));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 442));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 432));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 432));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 432));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 441));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 441));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 441));
        }

        private void BuildScreen443(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 8, 2, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 452));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 452));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 452));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 442));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 442));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 442));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 432));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 432));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 432));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 441));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 441));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 441));
        }

        private void BuildScreen444(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 0, 1, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 453));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 453));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 453));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 442));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 442));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 442));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 432));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 432));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 432));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 441));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 441));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 441));
        }

        private void BuildScreen445(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 1, 1, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 454));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 454));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 454));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 442));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 442));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 442));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 436));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 436));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 436));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 441));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 441));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 441));
        }

        private void BuildScreen446(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 2, 1, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 455));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 455));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 455));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 447));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 447));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 447));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 437));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 437));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 437));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 445));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 445));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 445));
        }

        private void BuildScreen447(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 3, 1, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 456));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 456));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 456));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 447));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 447));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 447));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 437));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 437));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 437));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 446));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 446));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 446));
        }

        private void BuildScreen448(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 4, 1, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 457));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 457));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 457));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 449));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 449));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 449));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 439));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 439));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 439));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 446));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 446));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 446));
        }

        private void BuildScreen449(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 5, 1, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 458));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 458));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 458));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 450));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 450));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 450));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 440));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 440));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 440));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 448));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 448));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 448));
        }

        private void BuildScreen450(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 6, 1, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 459));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 459));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 459));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 450));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 450));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 450));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 441));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 441));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 441));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 449));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 449));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 449));
        }

        private void BuildScreen451(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 7, 1, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 459));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 459));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 459));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 450));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 450));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 450));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 442));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 442));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 442));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 449));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 449));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 449));
        }

        private void BuildScreen452(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 8, 1, 35, 31, 32));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 461));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 461));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 461));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 450));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 450));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 450));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 442));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 442));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 442));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 449));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 449));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 449));
        }

        private void BuildScreen453(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 0, 0, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 461));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 461));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 461));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 454));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 454));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 454));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 444));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 444));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 444));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 449));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 449));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 449));
        }

        private void BuildScreen454(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 1, 0, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 461));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 461));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 461));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 454));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 454));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 454));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 445));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 445));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 445));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 453));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 453));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 453));
        }

        private void BuildScreen455(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 2, 0, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 461));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 461));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 461));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 454));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 454));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 454));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 446));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 446));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 446));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 453));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 453));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 453));
        }

        private void BuildScreen456(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 3, 0, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 461));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 461));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 461));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 457));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 457));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 457));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 447));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 447));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 447));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 453));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 453));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 453));
        }

        private void BuildScreen457(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 4, 0, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 461));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 461));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 461));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 457));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 457));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 457));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 448));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 448));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 448));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 453));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 453));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 453));
        }

        private void BuildScreen458(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 5, 0, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 461));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 461));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 461));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 457));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 457));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 457));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 449));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 449));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 449));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 453));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 453));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 453));
        }

        private void BuildScreen459(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 6, 0, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 461));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 461));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 461));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 460));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 460));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 460));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 450));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 450));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 450));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 453));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 453));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 453));
        }

        private void BuildScreen460(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 7, 0, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 461));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 461));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 461));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 461));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 461));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 461));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 450));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 450));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 450));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 459));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 459));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 459));
        }

        private void BuildScreen461(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(8, 8, 0, 35, 31, 32));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 461));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 461));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 461));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 461));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 461));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 461));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 452));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 452));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 452));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 460));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 460));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 460));
        }
    }
}








