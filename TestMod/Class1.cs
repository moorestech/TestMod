using System;
using Mod.Base;

namespace TestMod
{
    public class Class1 : MoorestechServerModEntryPoint 
    {
        public override void OnLoad(ServerModEntryInterface serverModEntryInterface)
        {
            Console.WriteLine("Mod Loaded!");
        }
    }
}