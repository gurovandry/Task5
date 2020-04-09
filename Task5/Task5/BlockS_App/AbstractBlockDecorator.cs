using System;
using System.Collections.Generic;
using System.Text;

namespace BlockS_App
{
    /// <summary>
    /// Класс абстрактного декоратора
    /// </summary>
    class AbstractBlockDecorator : AbstractBlock
    {
        public  AbstractBlock abstractBlock;
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="aB">Декорируемый класс</param>
        public AbstractBlockDecorator(AbstractBlock aB)
        {
            abstractBlock = aB;
        }
    }
}
