using System;
using System.Collections.Generic;
using System.Text;

namespace BlockS_App
{
    /// <summary>
    /// класс клиента
    /// </summary>
    class Interface
    {
        /// <summary>
        /// Метод создания процесса
        /// </summary>
        /// <param name="weig">размер рамки</param>
        public void Create_Process(int weig = 0)
        {
            ProcessBlock processBlock = new ProcessBlock();
            if (weig == 0)
            {
                processBlock.Drow();
            }
            else
            {
                try
                {
                    BorderBlockDecorator borderBlock = new BorderBlockDecorator(processBlock, weig);
                    borderBlock.Drow();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Error of procces");
                }
            }
        }

        /// <summary>
        /// Метод создания терминального блока
        /// </summary>
        /// <param name="lb"> лейбл </param>
        public void Create_Term(string lb = "0")
        {
            TerminatorBlock terminatorBlock = new TerminatorBlock();
            if (lb == "0")
            {
                terminatorBlock.Drow();
            }
            else
            {
                try
                {
                    LabelBlockDecorator labelBlock = new LabelBlockDecorator(terminatorBlock, lb);
                    labelBlock.Drow();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Error of term");
                }
            }
        }
    }
}
