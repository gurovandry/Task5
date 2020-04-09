using System;
using System.Collections.Generic;
using System.Text;

namespace BlockS_App
{
    /// <summary>
    /// Класс декорирования размера рамки
    /// </summary>
    class BorderBlockDecorator : AbstractBlockDecorator
    {
        /// <summary>
        /// Переменная для хранения размеров рамки
        /// </summary>
        private int BorderWidth;
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="abstractBlock"> декорируемый класс</param>
        /// <param name="bW"> размер рамки</param>
        public BorderBlockDecorator(AbstractBlock abstractBlock, int bW) : base(abstractBlock)
        {
            BorderWidth = bW;
        }
        /// <summary>
        /// Метод прорисовки рамки
        /// </summary>
        private void DrawBorder()
        {
            ///выполняемые конструкции
            Console.WriteLine(" ... drawing border with width " + Convert.ToString(BorderWidth));
        }
        /// <summary>
        /// Метод отрисовки блока
        /// </summary>
        public override void Drow()
        {
            abstractBlock.Drow();
            DrawBorder();

        }
    }
}
