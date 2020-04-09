using System;
using System.Collections.Generic;
using System.Text;

namespace BlockS_App
{
    /// <summary>
    /// Декоратор лейбла
    /// </summary>
    class LabelBlockDecorator : AbstractBlockDecorator
    {
        private readonly string Label;
        public LabelBlockDecorator(AbstractBlock abstractBlock, string str) : base(abstractBlock)
        {
            Label = str;
        }
        /// <summary>
        /// Отрисовкалейбла
        /// </summary>
        private void DrawLabel()
        {
            Console.WriteLine(" ... drawing label " + Label);
        }
        /// <summary>
        /// Отрисовка процесса
        /// </summary>
        public override void Drow()
        {
            abstractBlock.Drow();
            DrawLabel();
        }
    }
}
