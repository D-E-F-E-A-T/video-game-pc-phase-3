using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
AddEdgeCommand = 0
AddForestCommand = 1
AddGrassCommand = 2 
AddRockCommand = 3
AddStairsCommand = 4
AddStoneWallCommand = 5
AddTreeCommand = 6
AddWaterCommand = 7
DeclareCaveCommand = 8
DeclareDungeonCommand = 9
DeclareLandCommand = 10
DeclareLotCommand = 11
DeclareWorldCommand = 12
*/
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
            //commands.AddLast(new DeclareDungeonCommand("Dungeon3", 5, 5));
            //commands.AddLast(new DeclareDungeonCommand("Dungeon4", 5, 5));
            //commands.AddLast(new DeclareDungeonCommand("Dungeon5", 5, 5));
            //commands.AddLast(new DeclareDungeonCommand("Dungeon6", 5, 5));
            //commands.AddLast(new DeclareDungeonCommand("Dungeon7", 5, 5));

            //commands.AddLast(new DeclareCaveCommand("CaveGetFirstSword", 1, 1));
            //commands.AddLast(new DeclareCaveCommand("Cave1", 5, 5));
            //commands.AddLast(new DeclareCaveCommand("Cave2", 5, 5));
            //commands.AddLast(new DeclareCaveCommand("Cave3", 5, 5));



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
            //            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddGrassCommand(3, 0, 0));

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
            commands.AddLast(new AddStairsCommand(2, 4, 4, 1));

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

            commands.AddLast(new AddTreeCommand(2, 7, 7));
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
            commands.AddLast(new AddTreeCommand(2, 4, 3));
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
    }
}

